using MemoryPack;

namespace MetaMystia.Protocol.Data;

/// <summary>
/// 玩家信息数据，用于HelloAck中携带的已有peer信息
/// </summary>
[MemoryPackable]
public partial class PlayerInfoData
{
    /// <summary>玩家的UID（唯一标识符，由主机生成）</summary>
    public int Uid { get; set; } = -1;
    
    /// <summary>玩家的PeerId（显示名称）</summary>
    public string PeerId { get; set; } = "";
    
    /// <summary>增量资源数据库</summary>
    public ResourceDatabaseData IncrementalDataBase { get; set; } = null!;
    
    /// <summary>玩家皮肤信息</summary>
    public PlayerSkinData Skin { get; set; } = null!;
    
    /// <summary>当日工作是否已结束</summary>
    public bool IsDayOver { get; set; }
    
    /// <summary>准备阶段是否已完成</summary>
    public bool IsPrepOver { get; set; }
}