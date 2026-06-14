using MemoryPack;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.Common;

/// <summary>
/// 客机 → 主机：通告自身白天阶段就绪
/// </summary>
[MemoryPackable]
[RoomRelay]
public partial class DayReadyMessage : NetworkMessage;
