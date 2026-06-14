using MemoryPack;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

/// <summary>
/// 主机 → 所有客机：通告客人移动到排队队列
/// </summary>
[MemoryPackable]
public partial class MoveToQueueMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
}
