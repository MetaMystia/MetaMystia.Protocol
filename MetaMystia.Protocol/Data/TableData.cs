using System.Collections.Generic;
using MemoryPack;

namespace MetaMystia.Protocol.Data;

[MemoryPackable]
public partial class TableData
{
    public Dictionary<int, long> RecipeAdditions { get; set; } = [];
    public Dictionary<int, long> RecipeDeletions { get; set; } = [];

    public Dictionary<int, long> BeverageAdditions { get; set; } = [];
    public Dictionary<int, long> BeverageDeletions { get; set; } = [];

    public CookerSlotData[] Cookers { get; set; } = CookerSlotData.CreateDefaultArray();
    
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