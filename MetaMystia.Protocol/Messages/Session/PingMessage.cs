using MemoryPack;
using MetaMystia.Protocol.Logging;

namespace MetaMystia.Protocol.Messages.Session;

[MemoryPackable]
[MessageLogLevel(OnReceive = MessageLogLevel.Debug, OnSend = MessageLogLevel.Debug)]
public partial class PingMessage : NetworkMessage
{
    public int Id { get; set; }
}
