using MemoryPack;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

/// <summary>
/// 主机 → 所有客机：通告客人从队列进入餐厅
/// </summary>
[MemoryPackable]
public partial class SendFromQueueMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
}
