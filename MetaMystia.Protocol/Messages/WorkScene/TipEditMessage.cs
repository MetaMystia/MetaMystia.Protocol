using MemoryPack;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Messages.WorkScene;

/// <summary>
/// 任何玩家 → 全体玩家: NightScene.EventUtility.EventManager.TipEdit 的网络同步
/// </summary>
[MemoryPackable]
public partial class TipEditMessage : NetworkMessage
{
    public int IntValue { get; set; }
    public ServeType ServeType { get; set; }
    public float ComboBuff { get; set; }
    public float MoodBuff { get; set; }
    public float ExtraBuff { get; set; }
}
