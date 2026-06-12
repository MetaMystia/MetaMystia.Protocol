using System.Collections.Generic;
using MemoryPack;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Data;

[MemoryPackable]
public partial class ResourceDatabaseData
{
    /// <summary>
    /// DLC 标识位：None = 全量模式（向后兼容），非 None = 增量模式（Lists 仅含 ResourceEx extras）
    /// </summary>
    public DLCPack DLCFlags { get; set; } = DLCPack.None;

    // from DataBaseCore
    public List<int> Foods { get; set; } = [];
    public List<int> Recipes { get; set; } = [];
    public List<int> Beverages { get; set; } = [];
    public List<int> Ingredients { get; set; } = [];
    public List<int> Cookers { get; set; } = [];
    public List<int> Items { get; set; } = [];
    public List<int> Izakayas { get; set; } = [];
    
    // from DataBaseCharacter
    public List<int> SpecialGuests { get; set; } = [];
    public List<int> NormalGuests { get; set; } = [];
}