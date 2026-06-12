using MemoryPack;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Data;

[MemoryPackable]
public partial class GuestSpawnInfoData
{
    public GuestType GuestType { get; set; }
    public int[] Ids { get; set; } = null!;
    public int Fund { get; set; }
    public int MaxFundCarry { get; set; }
    public bool HasNormalSpawnArgs { get; set; }
    public bool HasOverrideSpawnPosition { get; set; }
    public float OverrideSpawnX { get; set; }
    public float OverrideSpawnY { get; set; }
    public float OverrideSpawnZ { get; set; }
    public LeaveType LeaveType { get; set; } = LeaveType.Move;
    public int TargetDeskCode { get; set; } = -1;
    public bool ShouldFade { get; set; } = true;
}