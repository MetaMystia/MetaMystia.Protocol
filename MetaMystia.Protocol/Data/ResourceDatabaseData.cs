using System.Collections.Generic;
using MemoryPack;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Data;

/// <summary>
/// 资源数据库数据，用于同步玩家之间的资源配置
/// </summary>
[MemoryPackable]
public partial class ResourceDatabaseData
{
    /// <summary>
    /// DLC 标识位：None = 全量模式（向后兼容），非 None = 增量模式（Lists 仅含 ResourceEx extras）
    /// </summary>
    public DLCPack DLCFlags { get; set; } = DLCPack.None;

    /// <summary>食物ID列表（来自DataBaseCore）</summary>
    public List<int> Foods { get; set; } = [];
    
    /// <summary>配方ID列表（来自DataBaseCore）</summary>
    public List<int> Recipes { get; set; } = [];
    
    /// <summary>饮料ID列表（来自DataBaseCore）</summary>
    public List<int> Beverages { get; set; } = [];
    
    /// <summary>食材ID列表（来自DataBaseCore）</summary>
    public List<int> Ingredients { get; set; } = [];
    
    /// <summary>厨具ID列表（来自DataBaseCore）</summary>
    public List<int> Cookers { get; set; } = [];
    
    /// <summary>物品ID列表（来自DataBaseCore）</summary>
    public List<int> Items { get; set; } = [];
    
    /// <summary>居酒屋ID列表（来自DataBaseCore）</summary>
    public List<int> Izakayas { get; set; } = [];
    
    /// <summary>特殊客人ID列表（来自DataBaseCharacter）</summary>
    public List<int> SpecialGuests { get; set; } = [];
    
    /// <summary>普通客人ID列表（来自DataBaseCharacter）</summary>
    public List<int> NormalGuests { get; set; } = [];
}