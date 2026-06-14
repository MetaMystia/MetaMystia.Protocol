using MemoryPack;
using MetaMystia.Protocol.Data;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

/// <summary>
/// 主机 → 所有客机：通告生成新客人
/// </summary>
[MemoryPackable]
public partial class GuestSpawnMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
    public GuestSpawnInfoData SpawnInfo { get; set; } = null!;
}
