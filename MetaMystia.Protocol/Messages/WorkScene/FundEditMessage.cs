using MemoryPack;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Messages.WorkScene;

/// <summary>
/// 任何玩家 → 全体玩家: NightScene.EventUtility.EventManager.FundEdit 的网络同步
/// </summary>
[MemoryPackable]
public partial class FundEditMessage : NetworkMessage
{
    public float Value { get; set; }
    public MathOperation MathOp { get; set; }
}
