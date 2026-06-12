using MemoryPack;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

/// <summary>
/// 主机判定排队耐心耗尽：
/// 调用栈: GuestGroupController.UpdatePatient (CurrentPatient&lt;=0)
///       -> OnPatientDepeletedCallback (= PostInitializeGuestGroup 内闭包 OnPatientDepleted)
///       -> GuestsManager.RemoveFromPatientCountdown
///       -> GuestGroupController.MoveToSpawn
/// 与桌上耐心耗尽不同：不付款、不清订单、不关面板、绕过 LeaveFromDesk。
/// 客机重放仅做 RemoveFromPatientCountdown + MoveToSpawn 这条最小副作用。
/// </summary>
[MemoryPackable]
public partial class PatientDepletedQueueMessage : NetworkMessage
{
    public int RuntimeId { get; set; }
}
