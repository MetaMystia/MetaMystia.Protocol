using MemoryPack;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Data;

[MemoryPackable]
public partial class SellableFoodData
{
    public SellableType Type { get; set; }
    public int Id { get; set; }
    public int Level { get; set; }
    public int[] ModifierIds { get; set; } = []; // 附加原料
    public int[] AdditiveTags { get; set; } = [];
    public int CookId { get; set; }
}