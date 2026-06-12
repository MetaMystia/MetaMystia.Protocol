using MemoryPack;
using MetaMystia.Protocol.Data;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

/// <summary>
/// 上菜/撤回 Action。设计参考 docs/GuestFSM-Model.md §2.8。
/// 不再 <c>[RoomRelay]</c>：主机收到客机请求后做冲突仲裁，决定是否接受并广播。
/// 拒绝时不广播——根本原因（host 当前权威值）必然来自先前某次 host 状态变更，
/// 那次变更的广播已在主机→sender 的 TCP 流中（队列或在途），sender 早晚会处理并自然回滚。
/// </summary>
[MemoryPackable]
public partial class ServeSellableMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
    public int OrderSeq { get; set; }
    public SellableFoodData Requested { get; set; } = null!;
    public SellableFoodData BasedOn { get; set; } = null!;
    public SellableType SellableType { get; set; }
}
