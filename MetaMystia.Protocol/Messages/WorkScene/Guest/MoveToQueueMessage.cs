using MemoryPack;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

[MemoryPackable]
public partial class MoveToQueueMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
}
