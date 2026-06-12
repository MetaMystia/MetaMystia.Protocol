using MemoryPack;
using MetaMystia.Protocol.Enums;
using MetaMystia.Protocol.Logging;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.WorkScene;

/// <summary>
/// 任何玩家 → 全体玩家：通告触发 QTE Buff
/// </summary>
[MemoryPackable]
[RoomRelay]
[MessageLogLevel(OnReceive = MessageLogLevel.Message, OnSend = MessageLogLevel.Message)]
public partial class BuffMessage : NetworkMessage
{
    public QTEBuff Buff { get; set; }
}
