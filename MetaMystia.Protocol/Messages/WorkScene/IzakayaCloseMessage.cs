using MemoryPack;

namespace MetaMystia.Protocol.Messages.WorkScene;

/// <summary>
/// 主机 → 所有客机：广播打烊
/// </summary>
[MemoryPackable]
public partial class IzakayaCloseMessage : NetworkMessage;
