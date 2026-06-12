using MemoryPack;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

[MemoryPackable]
public partial class GenerateOrderMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
    public OrderGenerationResult Result { get; set; }
    public OrderGenerationResult? OverrideResult { get; set; }
    public OrderType OrderType { get; set; }
    public int RequestFood { get; set; }
    public int RequestBev { get; set; }
    public int DeskCode { get; set; }
    public bool NotShowInUI { get; set; }
    public bool FreeOrder { get; set; }
}
