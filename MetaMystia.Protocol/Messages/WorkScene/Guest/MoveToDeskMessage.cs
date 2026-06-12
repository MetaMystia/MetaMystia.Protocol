using MemoryPack;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

[MemoryPackable]
public partial class MoveToDeskMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
    public int DeskCode { get; set; }
}
