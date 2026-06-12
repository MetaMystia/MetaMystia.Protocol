using MemoryPack;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

[MemoryPackable]
[RoomRelay]
public partial class PlayerRepellMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
}
