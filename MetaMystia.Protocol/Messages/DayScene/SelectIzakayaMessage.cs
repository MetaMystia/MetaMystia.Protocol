using MemoryPack;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.DayScene;

/// <summary>
/// 任何玩家 → 所有玩家：通告玩家所选店铺地点和等级
/// </summary>
[MemoryPackable]
[RoomRelay]
public partial class SelectIzakayaMessage : NetworkMessage
{
    /// <summary>开店地址标签，字符串形式，如BeastForest</summary>
    public string MapLabel { get; set; } = string.Empty;
    /// <summary>地图等级，有效值为1,2,3</summary>
    public int MapLevel { get; set; }
}
