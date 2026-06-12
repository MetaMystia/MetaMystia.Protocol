using MemoryPack;
using MetaMystia.Protocol.Data;

namespace MetaMystia.Protocol.Messages.PrepScene;

/// <summary>主机 → 全体玩家：确认备菜阶段全员就绪，并下发主机权威备菜表。</summary>
[MemoryPackable]
public partial class PrepAllReadyMessage : NetworkMessage
{
    public TableData PrepTableData { get; set; } = new();
}
