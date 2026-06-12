using MemoryPack;

namespace MetaMystia.Protocol.Messages.DayScene;

/// <summary>
/// 主机 → 全体客机：确认全员选店一致，客机收到后执行场景切换。
/// </summary>
[MemoryPackable]
public partial class ConfirmIzakayaMessage : NetworkMessage
{
    public string MapLabel { get; set; } = string.Empty;
    // 默认值为0
    public int MapLevel { get; set; }
}
