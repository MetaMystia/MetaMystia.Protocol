using System;
using MemoryPack;
using MetaMystia.Protocol.Messages.Common;
using MetaMystia.Protocol.Messages.DayScene;
using MetaMystia.Protocol.Messages.PrepScene;
using MetaMystia.Protocol.Messages.Session;
using MetaMystia.Protocol.Messages.WorkScene;
using MetaMystia.Protocol.Messages.WorkScene.Guest;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages;

// ReSharper disable UnusedMember.Global
[MemoryPackable]
[MemoryPackUnion((ushort)MessageType.Ping, typeof(PingMessage))]
[MemoryPackUnion((ushort)MessageType.Pong, typeof(PongMessage))]
[MemoryPackUnion((ushort)MessageType.Hello, typeof(HelloMessage))]
[MemoryPackUnion((ushort)MessageType.HelloAck, typeof(HelloAckMessage))]
[MemoryPackUnion((ushort)MessageType.Reject, typeof(RejectMessage))]
[MemoryPackUnion((ushort)MessageType.PeerJoin, typeof(PeerJoinMessage))]
[MemoryPackUnion((ushort)MessageType.PeerLeave, typeof(PeerLeaveMessage))]
[MemoryPackUnion((ushort)MessageType.PlayerChangeId, typeof(PlayerChangeIdMessage))]
[MemoryPackUnion((ushort)MessageType.PlayerChangeSkin, typeof(PlayerChangeSkinMessage))]
[MemoryPackUnion((ushort)MessageType.Chat, typeof(ChatMessage))]
[MemoryPackUnion((ushort)MessageType.SceneTransit, typeof(SceneTransitMessage))]
[MemoryPackUnion((ushort)MessageType.MoveSync, typeof(MoveSyncMessage))]
[MemoryPackUnion((ushort)MessageType.NightMoveSync, typeof(NightMoveSyncMessage))]
[MemoryPackUnion((ushort)MessageType.DayReady, typeof(DayReadyMessage))]
[MemoryPackUnion((ushort)MessageType.DayAllReady, typeof(DayAllReadyMessage))]
[MemoryPackUnion((ushort)MessageType.SelectIzakaya, typeof(SelectIzakayaMessage))]
[MemoryPackUnion((ushort)MessageType.ConfirmIzakaya, typeof(ConfirmIzakayaMessage))]
[MemoryPackUnion((ushort)MessageType.UpdatePrep, typeof(UpdatePrepMessage))]
[MemoryPackUnion((ushort)MessageType.PrepReady, typeof(PrepReadyMessage))]
[MemoryPackUnion((ushort)MessageType.PrepAllReady, typeof(PrepAllReadyMessage))]
[MemoryPackUnion((ushort)MessageType.NightCook, typeof(NightCookMessage))]
[MemoryPackUnion((ushort)MessageType.ExtractFromCooker, typeof(ExtractFromCookerMessage))]
[MemoryPackUnion((ushort)MessageType.StoreFood, typeof(StoreFoodMessage))]
[MemoryPackUnion((ushort)MessageType.StoreSellable, typeof(StoreSellableMessage))]
[MemoryPackUnion((ushort)MessageType.ExtractFood, typeof(ExtractFoodMessage))]
[MemoryPackUnion((ushort)MessageType.QTE, typeof(QTEMessage))]
[MemoryPackUnion((ushort)MessageType.Buff, typeof(BuffMessage))]
[MemoryPackUnion((ushort)MessageType.GuestInvite, typeof(GuestInviteMessage))]
[MemoryPackUnion((ushort)MessageType.GuestSpawn, typeof(GuestSpawnMessage))]
[MemoryPackUnion((ushort)MessageType.MoveToDesk, typeof(MoveToDeskMessage))]
[MemoryPackUnion((ushort)MessageType.MoveToQueue, typeof(MoveToQueueMessage))]
[MemoryPackUnion((ushort)MessageType.PlayerRepel, typeof(PlayerRepellMessage))]
[MemoryPackUnion((ushort)MessageType.GenerateOrder, typeof(GenerateOrderMessage))]
[MemoryPackUnion((ushort)MessageType.ServeSellable, typeof(ServeSellableMessage))]
[MemoryPackUnion((ushort)MessageType.EvaluateOrder, typeof(EvaluateOrderMessage))]
[MemoryPackUnion((ushort)MessageType.ConfirmServe, typeof(ConfirmServeMessage))]
[MemoryPackUnion((ushort)MessageType.GuestLeave, typeof(GuestLeaveMessage))]
[MemoryPackUnion((ushort)MessageType.SendFromQueue, typeof(SendFromQueueMessage))]
[MemoryPackUnion((ushort)MessageType.PatientDepletedQueue, typeof(PatientDepletedQueueMessage))]
[MemoryPackUnion((ushort)MessageType.PatientDepletedDesk, typeof(PatientDepletedDeskMessage))]
[MemoryPackUnion((ushort)MessageType.GuestKill, typeof(GuestKillMessage))]
[MemoryPackUnion((ushort)MessageType.FundEdit, typeof(FundEditMessage))]
[MemoryPackUnion((ushort)MessageType.TipEdit, typeof(TipEditMessage))]
[MemoryPackUnion((ushort)MessageType.ExpEdit, typeof(ExpEditMessage))]
[MemoryPackUnion((ushort)MessageType.PassionEdit, typeof(PassionEditMessage))]
[MemoryPackUnion((ushort)MessageType.IzakayaClose, typeof(IzakayaCloseMessage))]
public abstract partial class NetworkMessage
{
    protected long TimestampMs { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

    /// <summary>
    /// 发送者的 UID（主机=0，客机=1,2,3...）
    /// </summary>
    // ReSharper disable once MemberCanBeProtected.Global
    public int SenderUid { get; set; } = MpConstants.UnassignedUid;

    [MemoryPackIgnore] public int? WireTargetUid { get; set; }
    [MemoryPackIgnore] public int? WireExceptUid { get; set; }
    
    public override string ToString() => GetType().Name;
}