using MemoryPack;
using MetaMystia.Protocol.Data;
using MetaMystia.Protocol.Logging;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.PrepScene;

/// <summary>
/// 任何玩家 → 所有玩家：通告 PrepScene 的食谱/酒水/厨具变更，使用 Last-Write-Wins 策略合并数据，所有玩家对等
/// </summary>
[MemoryPackable]
[RoomRelay]
[MessageLogLevel(OnSendLogOnlyAction = true, OnReceiveLogOnlyAction = true)]
public partial class UpdatePrepMessage : NetworkMessage
{
    public TableData PrepTableData { get; set; } = new();
}
