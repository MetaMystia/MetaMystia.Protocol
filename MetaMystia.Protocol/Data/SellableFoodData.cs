using MemoryPack;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Data;

/// <summary>
/// 可售卖食物数据
/// </summary>
[MemoryPackable]
public partial class SellableFoodData
{
    /// <summary>可售卖类型（食物/饮料）</summary>
    public SellableType Type { get; set; }
    
    /// <summary>物品ID</summary>
    public int Id { get; set; }
    
    /// <summary>等级</summary>
    public int Level { get; set; }
    
    /// <summary>附加原料ID列表</summary>
    public int[] ModifierIds { get; set; } = [];
    
    /// <summary>附加标签列表</summary>
    public int[] AdditiveTags { get; set; } = [];
    
    /// <summary>烹饪ID</summary>
    public int CookId { get; set; }
}