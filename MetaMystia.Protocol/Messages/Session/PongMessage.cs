using MemoryPack;
using MetaMystia.Protocol.Logging;

namespace MetaMystia.Protocol.Messages.Session;

[MemoryPackable]
[MessageLogLevel(OnReceive = MessageLogLevel.Debug, OnSend = MessageLogLevel.Debug)]
public partial class PongMessage : NetworkMessage
{
    public int Id { get; set; }
}
