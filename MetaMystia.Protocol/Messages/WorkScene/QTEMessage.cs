using MemoryPack;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.WorkScene;

/// <summary>
/// 任何玩家 → 全体玩家：通告某个厨具的 QTE 结果以启动料理倒计时，总是在 CookAction 之后触发
/// QTE(Quick Time Event): 夜雀之歌
/// </summary>
[MemoryPackable]
[RoomRelay]
public partial class QTEMessage : NetworkMessage
{
    public int GridIndex { get; set; }
    public float QTEScore { get; set; }
}
