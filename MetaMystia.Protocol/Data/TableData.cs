using System.Collections.Generic;
using MemoryPack;

namespace MetaMystia.Protocol.Data;

/// <summary>
/// 桌子数据，包含配方和饮料的增减记录以及厨具槽位状态
/// </summary>
[MemoryPackable]
public partial class TableData
{
    /// <summary>配方添加记录（ID -> 时间戳）</summary>
    public Dictionary<int, long> RecipeAdditions { get; set; } = [];
    
    /// <summary>配方删除记录（ID -> 时间戳）</summary>
    public Dictionary<int, long> RecipeDeletions { get; set; } = [];

    /// <summary>饮料添加记录（ID -> 时间戳）</summary>
    public Dictionary<int, long> BeverageAdditions { get; set; } = [];
    
    /// <summary>饮料删除记录（ID -> 时间戳）</summary>
    public Dictionary<int, long> BeverageDeletions { get; set; } = [];

    /// <summary>厨具槽位数组</summary>
    public CookerSlotData[] Cookers { get; set; } = CookerSlotData.CreateDefaultArray();
    
    /// <summary>
    /// 克隆当前桌子数据
    /// </summary>
    /// <returns>克隆后的TableData实例</returns>
    // ReSharper disable once UnusedMember.Global
    public TableData Clone()
    {
        var clonedCookers = new CookerSlotData[Cookers.Length];
        for (var i = 0; i < Cookers.Length; i++)
            clonedCookers[i] = Cookers[i].Clone();

        return new TableData
        {
            RecipeAdditions = new Dictionary<int, long>(RecipeAdditions),
            RecipeDeletions = new Dictionary<int, long>(RecipeDeletions),
            BeverageAdditions = new Dictionary<int, long>(BeverageAdditions),
            BeverageDeletions = new Dictionary<int, long>(BeverageDeletions),
            Cookers = clonedCookers
        };
    }
}