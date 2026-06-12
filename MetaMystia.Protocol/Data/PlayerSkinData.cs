using MemoryPack;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Data;

[MemoryPackable]
public partial class PlayerSkinData
{
    public int CharacterId { get; set; } = -1;   // -1 表示主角（Mystia）
    public SkinSelectedType SelectedType { get; set; } = SkinSelectedType.Default;
    // 默认值为0
    public int SkinIndex { get; set; }
    /// <summary>
    /// 在线皮肤名（皮肤站标识），非空时优先使用。
    /// 默认值为null
    /// </summary>
    public string? NetSkinName { get; set; }
}