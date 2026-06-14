using MemoryPack;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Data;

/// <summary>
/// 玩家皮肤数据
/// </summary>
[MemoryPackable]
public partial class PlayerSkinData
{
    /// <summary>角色ID，-1表示主角（Mystia）</summary>
    public int CharacterId { get; set; } = -1;
    
    /// <summary>皮肤选择类型</summary>
    public SkinSelectedType SelectedType { get; set; } = SkinSelectedType.Default;
    
    /// <summary>皮肤索引（默认值为0）</summary>
    public int SkinIndex { get; set; }
    
    /// <summary>
    /// 在线皮肤名（皮肤站标识），非空时优先使用<br/>
    /// 默认值为null
    /// </summary>
    public string? NetSkinName { get; set; }
}