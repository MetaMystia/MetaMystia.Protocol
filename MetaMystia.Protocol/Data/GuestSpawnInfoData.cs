using MemoryPack;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Data;

/// <summary>
/// 客人生成信息数据
/// </summary>
[MemoryPackable]
public partial class GuestSpawnInfoData
{
    /// <summary>客人类型（普通/特殊）</summary>
    public GuestType GuestType { get; set; }
    
    /// <summary>客人ID列表</summary>
    public int[] Ids { get; set; } = null!;
    
    /// <summary>客人携带的资金</summary>
    public int Fund { get; set; }
    
    /// <summary>最大携带资金上限</summary>
    public int MaxFundCarry { get; set; }
    
    /// <summary>是否有普通生成参数</summary>
    public bool HasNormalSpawnArgs { get; set; }
    
    /// <summary>是否覆盖生成位置</summary>
    public bool HasOverrideSpawnPosition { get; set; }
    
    /// <summary>覆盖生成位置的X坐标</summary>
    public float OverrideSpawnX { get; set; }
    
    /// <summary>覆盖生成位置的Y坐标</summary>
    public float OverrideSpawnY { get; set; }
    
    /// <summary>覆盖生成位置的Z坐标</summary>
    public float OverrideSpawnZ { get; set; }
    
    /// <summary>离开类型</summary>
    public LeaveType LeaveType { get; set; } = LeaveType.Move;
    
    /// <summary>目标桌子编码，-1表示无目标</summary>
    public int TargetDeskCode { get; set; } = -1;
    
    /// <summary>是否应该淡出</summary>
    public bool ShouldFade { get; set; } = true;
}