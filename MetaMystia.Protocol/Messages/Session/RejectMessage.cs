using MemoryPack;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Messages.Session;

/// <summary>
/// 主机 → 客机：连接被拒绝，携带拒绝原因。客机收到后显示通知并断开。
/// </summary>
[MemoryPackable]
public partial class RejectMessage : NetworkMessage
{
    public RejectReason Reason { get; set; }
    public string[] ReasonArgs { get; set; } = [];
}