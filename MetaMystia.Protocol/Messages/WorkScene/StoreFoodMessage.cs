using MemoryPack;
using MetaMystia.Protocol.Data;
using MetaMystia.Protocol.Logging;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.WorkScene;

/// <summary>
/// 任何玩家 → 全体玩家：通告某个料理被放入保温箱中，与 ExtractFood 对应
/// </summary>
[MemoryPackable]
[RoomRelay]
[MessageLogLevel(OnSendLogOnlyAction = true, OnReceiveLogOnlyAction = true)]
public partial class StoreFoodMessage : NetworkMessage
{
    public SellableFoodData Food { get; set; } = null!;
}
