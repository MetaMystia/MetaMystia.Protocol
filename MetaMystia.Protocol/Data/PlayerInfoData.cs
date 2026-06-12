using MemoryPack;

namespace MetaMystia.Protocol.Data;

/// <summary>
/// HelloAck 中携带的已有 peer 信息
/// </summary>
[MemoryPackable]
public partial class PlayerInfoData
{
    public int Uid { get; set; } = -1;
    public string PeerId { get; set; } = "";
    public ResourceDatabaseData IncrementalDataBase { get; set; } = null!;
    public PlayerSkinData Skin { get; set; } = null!;
    public bool IsDayOver { get; set; }
    public bool IsPrepOver { get; set; }
}