using MemoryPack;
using MetaMystia.Protocol.Data;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

/// <summary>
/// 主机 → 所有客机：确认上菜成功
/// </summary>
[MemoryPackable]
public partial class ConfirmServeMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
    public int OrderSeq { get; set; }
    public SellableFoodData Food { get; set; } = null!;
    public SellableFoodData Beverage { get; set; } = null!;
}
