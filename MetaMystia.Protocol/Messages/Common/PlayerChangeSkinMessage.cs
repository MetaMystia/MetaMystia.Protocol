using MemoryPack;
using MetaMystia.Protocol.Data;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.Common;

/// <summary>
/// 皮肤变更网络同步 Action。
/// 当玩家通过 /skin 命令更改皮肤时，广播给所有其他玩家。
/// </summary>
[MemoryPackable]
[PublicRelay]
public partial class PlayerChangeSkinMessage : NetworkMessage
{
    public PlayerSkinData Skin { get; set; } = null!;
}
