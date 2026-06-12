using MemoryPack;
using MetaMystia.Protocol.Data;
using MetaMystia.Protocol.Logging;

namespace MetaMystia.Protocol.Messages.Session;

/// <summary>
/// 主机 → 所有客机：通告新玩家加入
/// </summary>
[MemoryPackable]
[MessageLogLevel(OnReceive = MessageLogLevel.Message)]
public partial class PeerJoinMessage : NetworkMessage
{
    /// <summary>判空，判空！</summary>
    public PlayerInfoData PeerInfo { get; set; } = null!;
}
