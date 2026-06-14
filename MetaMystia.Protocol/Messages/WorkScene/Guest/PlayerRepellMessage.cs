using MemoryPack;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

/// <summary>
/// 任何玩家 → 所有玩家：通告玩家驱赶客人
/// </summary>
[MemoryPackable]
[RoomRelay]
public partial class PlayerRepellMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
}
