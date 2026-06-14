namespace MetaMystia.Protocol.Transport;

// ReSharper disable UnusedMember.Global
// ReSharper disable once UnusedType.Global
/// <summary>
/// 多人游戏会话状态管理器。
/// 管理当前连接的传输类型、同步范围、房间角色等状态信息。
/// </summary>
public sealed class MpSession
{
    /// <summary>当前使用的传输类型</summary>
    public TransportKind TransportKind { get; private set; } = TransportKind.None;
    
    /// <summary>当前的同步范围（公域/房间）</summary>
    public SyncScope SyncScope { get; private set; } = SyncScope.None;
    
    /// <summary>在房间中的角色（主机/客机）</summary>
    public RoomRole RoomRole { get; private set; } = RoomRole.None;
    
    /// <summary>当前房间的唯一标识</summary>
    public string RoomId { get; private set; } = "";
    
    /// <summary>主机的UID</summary>
    public int HostUid { get; private set; } = MpConstants.UnassignedUid;

    /// <summary>是否处于在线状态</summary>
    public bool IsOnline => TransportKind != TransportKind.None;
    
    /// <summary>是否处于公域（中继服务器但不在房间内）</summary>
    public bool IsInPublicScope => SyncScope == SyncScope.Public;
    
    /// <summary>是否处于房间内</summary>
    public bool IsInRoom => SyncScope == SyncScope.Room;
    
    /// <summary>是否为房间主机</summary>
    public bool IsRoomHost => IsInRoom && RoomRole == RoomRole.Host;
    
    /// <summary>是否为房间客机</summary>
    public bool IsRoomClient => IsInRoom && RoomRole == RoomRole.Client;
    
    /// <summary>是否通过中继服务器连接</summary>
    public bool IsRelay => TransportKind == TransportKind.RelayClient;

    /// <summary>
    /// 重置会话状态为初始状态
    /// </summary>
    public void Reset()
    {
        TransportKind = TransportKind.None;
        SyncScope = SyncScope.None;
        RoomRole = RoomRole.None;
        RoomId = "";
        HostUid = MpConstants.UnassignedUid;
    }

    /// <summary>
    /// 进入直连主机模式
    /// </summary>
    public void EnterDirectHostRoom()
    {
        TransportKind = TransportKind.DirectHost;
        SyncScope = SyncScope.Room;
        RoomRole = RoomRole.Host;
        RoomId = "direct";
        HostUid = MpConstants.HostUid;
    }

    /// <summary>
    /// 进入直连客机模式（连接到直连主机）
    /// </summary>
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

    /// <summary>
    /// 进入中继服务器的房间
    /// </summary>
    /// <param name="roomRole">在房间中的角色（主机/客机）</param>
    /// <param name="roomId">房间的唯一标识</param>
    /// <param name="hostUid">主机的UID</param>
    public void EnterRelayRoom(RoomRole roomRole, string roomId, int hostUid)
    {
        TransportKind = TransportKind.RelayClient;
        SyncScope = SyncScope.Room;
        RoomRole = roomRole;
        RoomId = roomId;
        HostUid = hostUid;
    }

    /// <summary>
    /// 从中继房间退出到公域
    /// 如果当前不是中继连接，则重置会话状态
    /// </summary>
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