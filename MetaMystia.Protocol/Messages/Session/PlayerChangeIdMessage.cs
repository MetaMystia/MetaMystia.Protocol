using MemoryPack;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.Session;

/// <summary>
/// 任何玩家 → 所有玩家：通告玩家 ID 变更
/// </summary>
[MemoryPackable]
[PublicRelay]
public partial class PlayerChangeIdMessage : NetworkMessage
{
    public string NewPlayerId { get; set; } = string.Empty;
}
