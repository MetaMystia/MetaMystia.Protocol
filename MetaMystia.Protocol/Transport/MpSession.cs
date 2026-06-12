namespace MetaMystia.Protocol.Transport;

// ReSharper disable UnusedMember.Global
// ReSharper disable once UnusedType.Global
public sealed class MpSession
{
    public TransportKind TransportKind { get; private set; } = TransportKind.None;
    public SyncScope SyncScope { get; private set; } = SyncScope.None;
    public RoomRole RoomRole { get; private set; } = RoomRole.None;
    public string RoomId { get; private set; } = "";
    public int HostUid { get; private set; } = MpConstants.UnassignedUid;

    public bool IsOnline => TransportKind != TransportKind.None;
    public bool IsInPublicScope => SyncScope == SyncScope.Public;
    public bool IsInRoom => SyncScope == SyncScope.Room;
    public bool IsRoomHost => IsInRoom && RoomRole == RoomRole.Host;
    public bool IsRoomClient => IsInRoom && RoomRole == RoomRole.Client;
    public bool IsRelay => TransportKind == TransportKind.RelayClient;

    public void Reset()
    {
        TransportKind = TransportKind.None;
        SyncScope = SyncScope.None;
        RoomRole = RoomRole.None;
        RoomId = "";
        HostUid = MpConstants.UnassignedUid;
    }

    public void EnterDirectHostRoom()
    {
        TransportKind = TransportKind.DirectHost;
        SyncScope = SyncScope.Room;
        RoomRole = RoomRole.Host;
        RoomId = "direct";
        HostUid = MpConstants.HostUid;
    }

    public void EnterDirectClientRoom()
    {
        TransportKind = TransportKind.DirectClient;
        SyncScope = SyncScope.Room;
        RoomRole = RoomRole.Client;
        RoomId = "direct";
        HostUid = MpConstants.HostUid;
    }

    /// <summary>已连上中继、处于公域；不在任何玩法房间内。</summary>
    public void EnterRelayPublic()
    {
        TransportKind = TransportKind.RelayClient;
        SyncScope = SyncScope.Public;
        RoomRole = RoomRole.None;
        RoomId = "";
        HostUid = MpConstants.UnassignedUid;
    }

    public void EnterRelayRoom(RoomRole roomRole, string roomId, int hostUid)
    {
        TransportKind = TransportKind.RelayClient;
        SyncScope = SyncScope.Room;
        RoomRole = roomRole;
        RoomId = roomId;
        HostUid = hostUid;
    }

    public void LeaveRelayRoomToPublic()
    {
        if (TransportKind != TransportKind.RelayClient)
        {
            Reset();
            return;
        }
        EnterRelayPublic();
    }
}