using MemoryPack;
using MetaMystia.Protocol.Enums;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.Common;

/// <summary>
/// 所有玩家 → 所有玩家：通告自身 Scene 切换
/// </summary>
[MemoryPackable]
[PublicRelay]
public partial class SceneTransitMessage : NetworkMessage
{
    /// <summary>
    /// 切换后的 Scene
    /// </summary>
    public Scene Scene { get; set; }
}
