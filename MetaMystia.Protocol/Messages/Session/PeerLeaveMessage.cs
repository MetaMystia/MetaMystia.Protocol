using MemoryPack;
using MetaMystia.Protocol.Logging;

namespace MetaMystia.Protocol.Messages.Session;

/// <summary>
/// 主机 → 所有客机：通告玩家离开
/// </summary>
[MemoryPackable]
[MessageLogLevel(OnReceive = MessageLogLevel.Message)]
public partial class PeerLeaveMessage : NetworkMessage
{
    public int PeerUid { get; set; }
}
