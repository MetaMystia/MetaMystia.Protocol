using MemoryPack;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.PrepScene;

/// <summary>任何玩家 → 所有玩家：通告本人备菜阶段就绪（IzakayaPrepScene）。</summary>
[MemoryPackable]
[RoomRelay]
public partial class PrepReadyMessage : NetworkMessage;
