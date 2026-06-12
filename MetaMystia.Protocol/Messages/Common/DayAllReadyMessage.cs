using MemoryPack;

namespace MetaMystia.Protocol.Messages.Common;

/// <summary>主机 → 全体玩家：确认白天阶段全员就绪，客机收到后推进场景。</summary>
[MemoryPackable]
public partial class DayAllReadyMessage : NetworkMessage;
