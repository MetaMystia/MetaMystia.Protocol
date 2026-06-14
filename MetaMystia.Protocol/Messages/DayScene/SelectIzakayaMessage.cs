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
    public string MapLabel { get; set; } = string.Empty;
    public int MapLevel { get; set; }
}
