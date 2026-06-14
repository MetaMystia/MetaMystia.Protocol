using MemoryPack;

namespace MetaMystia.Protocol.Messages.DayScene;

/// <summary>
/// 主机 → 全体客机：确认全员选店一致，客机收到后执行场景切换。
/// </summary>
[MemoryPackable]
public partial class ConfirmIzakayaMessage : NetworkMessage
{
    /// <summary>开店地址标签，字符串形式，如BeastForest</summary>
    public string MapLabel { get; set; } = string.Empty;
    /// <summary>地图等级，有效值为1,2,3</summary>
    public int MapLevel { get; set; }
}
