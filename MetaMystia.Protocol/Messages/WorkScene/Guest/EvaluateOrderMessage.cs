using MemoryPack;
using MetaMystia.Protocol.Data;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

[MemoryPackable]
public partial class EvaluateOrderMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
    public int OrderSeq { get; set; }
    public SellableFoodData Food { get; set; } = null!;
    public SellableFoodData Beverage { get; set; } = null!;
    public EvaluationResult EvalResult { get; set; }
}
