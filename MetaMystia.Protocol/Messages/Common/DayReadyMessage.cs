using MemoryPack;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.Common;

[MemoryPackable]
[RoomRelay]
public partial class DayReadyMessage : NetworkMessage;
