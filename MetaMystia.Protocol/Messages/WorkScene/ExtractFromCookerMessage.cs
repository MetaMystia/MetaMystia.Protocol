using MemoryPack;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.WorkScene;

/// <summary>
/// 任何玩家 → 全体玩家：通告某个厨具(包括空厨具)中的料理被取出
/// </summary>
[MemoryPackable]
[RoomRelay]
public partial class ExtractFromCookerMessage : NetworkMessage
{
    public int GridIndex { get; set; }
}
