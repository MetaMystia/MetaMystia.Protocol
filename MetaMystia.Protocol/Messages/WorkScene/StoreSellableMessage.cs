using MemoryPack;
using MetaMystia.Protocol.Data;
using MetaMystia.Protocol.Logging;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.WorkScene;

/// <summary>
/// 任何玩家 → 所有玩家：通告玩家将 Sellable 储存在空厨具上
/// </summary>
// ReSharper disable UnusedMember.Global
[MemoryPackable]
[RoomRelay]
[MessageLogLevel(OnSendLogOnlyAction = true, OnReceiveLogOnlyAction = true)]
public partial class StoreSellableMessage : NetworkMessage
{
    public enum StoreType
    {
        Food,
        Beverage
    }

    public int GridIndex { get; set; }
    public SellableFoodData Food { get; set; } = null!;
    public int BeverageId { get; set; }
    public StoreType FoodType { get; set; }
}
