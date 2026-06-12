using MemoryPack;
using MetaMystia.Protocol.Data;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

[MemoryPackable]
public partial class ConfirmServeMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
    public int OrderSeq { get; set; }
    public SellableFoodData Food { get; set; } = null!;
    public SellableFoodData Beverage { get; set; } = null!;
}
