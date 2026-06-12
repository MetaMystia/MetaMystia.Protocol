using MemoryPack;
using MetaMystia.Protocol.Data;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Messages.Session;

/// <summary>
/// 客机 → 主机：握手请求。主机验证后回复 HelloAckAction。
/// </summary>
[MemoryPackable]
public partial class HelloMessage : NetworkMessage
{
    public string Version { get; set; } = "";
    public string GameVersion { get; set; } = "";
    public Scene CurrentGameScene { get; set; }
    /// <summary>判空，判空！</summary>
    public PlayerInfoData PeerInfo { get; set; } = null!;
}
