using MemoryPack;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

[MemoryPackable]
public partial class SendFromQueueMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
}
