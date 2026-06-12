using MemoryPack;
using MetaMystia.Protocol.Data;

namespace MetaMystia.Protocol.Messages.Session;

/// <summary>
/// 主机 → 客机：握手确认，携带分配的 UID 和现有所有 peer 信息
/// </summary>
[MemoryPackable]
public partial class HelloAckMessage : NetworkMessage
{
    public int AssignedUid { get; set; }

    /// <summary>
    /// 主机信息（uid=0），注意使用前判空
    /// </summary>
    public PlayerInfoData? HostInfo { get; set; }

    /// <summary>
    /// 已有 peer 列表（不含新加入者自身和主机）
    /// </summary>
    public PlayerInfoData[] ExistingPeers { get; set; } = [];
}