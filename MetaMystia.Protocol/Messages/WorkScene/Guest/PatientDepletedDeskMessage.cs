using MemoryPack;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

/// <summary>
/// 主机判定桌上耐心耗尽：
/// 调用栈: GuestGroupController.UpdatePatient (CurrentPatient&lt;=0)
///       -> OnPatientDepeletedCallback (= GuestsManager.PatientDepletedLeave)
///       -> EventManager.LoseAllCombo
///       -> RemoveFromPatientCountdown
///       -> OnPatienceRunOutCallback
///       -> onOrderRemove(PeekOrders) + registeredCharacterArrivedEvents.Remove(DeskCode)
///       -> onForcePannelClosingWhenGuestRepellCallback (若匹配)
///       -> GuestPay(toLeave, includeTip: true)
///       -> LeaveFromDesk(toLeave)
/// 客机重放需要等价地推进副作用，但 PatientDepletedLeave 是 private，所以由
/// GuestReplayService.ReplayPatientDepletedLeave 复刻。
/// </summary>
[MemoryPackable]
public partial class PatientDepletedDeskMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
}
