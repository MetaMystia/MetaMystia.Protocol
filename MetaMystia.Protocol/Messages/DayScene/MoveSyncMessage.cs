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
    /// <summary>x轴速度</summary>
    public float Vx { get; set; }
    /// <summary>y轴速度</summary>
    public float Vy { get; set; }
    /// <summary>x轴位置</summary>
    public float Px { get; set; }
    /// <summary>y轴位置</summary>
    public float Py { get; set; }
    /// <summary>是否开启疾跑</summary>
    public bool IsSprinting { get; set; }
    /// <summary>移动速度</summary>
    public float Speed { get; set; }
    /// <summary>地图标签</summary>
    public string MapLabel { get; set; } = string.Empty;

}
