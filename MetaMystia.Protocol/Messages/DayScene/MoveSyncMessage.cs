using MemoryPack;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.DayScene;

/// <summary>
/// 任何玩家 → 全体玩家：通告角色移动同步，主要是白天。
/// </summary>
[MemoryPackable]
[PublicRelay]
public partial class MoveSyncMessage : NetworkMessage
{
    public float Vx { get; set; }
    public float Vy { get; set; }
    public float Px { get; set; }
    public float Py { get; set; }
    public bool IsSprinting { get; set; }
    public float Speed { get; set; }
    public string MapLabel { get; set; } = string.Empty;

}
