using MemoryPack;
using MetaMystia.Protocol.Enums;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

/// <summary>
/// 主机 FSM 异常 (FallBack) 时广播的强制清理信号。
/// 客机收到后调用 GuestFSM.DoKill -> GuestReplayService.ReplayForceCleanupGuest 释放
/// 桌位 / 顾客图标 / 可赶客注册 / 耐心倒计时 / 桌面 sprite 等全局状态，并把 FSM 推到 Dead。
///
/// 仅由主机 FallBack 路径发出；客机 FallBack 不广播 (客机异常通常源于自身与主机不同步，
/// 不应反向污染主机权威)。
/// </summary>
[MemoryPackable]
public partial class GuestKillMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
    public GuestFsmState HostStateBeforeKill { get; set; }  // 调试用：观测主客状态分歧
    public int DeskCode { get; set; } = -1;
}
