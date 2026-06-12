using System.Collections.Generic;
using MemoryPack;

namespace MetaMystia.Protocol.Messages.WorkScene.Guest;

/// <summary>
/// 客机 -> 主机：同步客机白天邀请的稀客列表，主机在夜晚前合并到自己的邀请列表。
/// </summary>
[MemoryPackable]
public partial class GuestInviteMessage : NetworkMessage
{
    public List<int> InvitedGuestIds { get; set; } = [];
}
