using MemoryPack;
using MetaMystia.Protocol.Logging;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.WorkScene;

/// <summary>
/// 任何玩家 → 全体玩家：夜间角色移动同步
/// </summary>
[MemoryPackable]
[PublicRelay]
[MessageLogLevel(OnSend = MessageLogLevel.Debug, OnReceive = MessageLogLevel.Debug)]
public partial class NightMoveSyncMessage : NetworkMessage
{
    public float Vx { get; set; }
    public float Vy { get; set; }
    public float Px { get; set; }
    public float Py { get; set; }
    public float Speed { get; set; }
}
