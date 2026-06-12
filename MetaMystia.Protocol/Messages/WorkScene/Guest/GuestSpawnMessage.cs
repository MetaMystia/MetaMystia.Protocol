using MemoryPack;
using MetaMystia.Protocol.Data;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

[MemoryPackable]
public partial class GuestSpawnMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
    public GuestSpawnInfoData SpawnInfo { get; set; } = null!;
}
