using MemoryPack;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

/// <summary>
/// 主机 → 所有客机：通告客人移动到指定桌子
/// </summary>
[MemoryPackable]
public partial class MoveToDeskMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
    public int DeskCode { get; set; }
}
