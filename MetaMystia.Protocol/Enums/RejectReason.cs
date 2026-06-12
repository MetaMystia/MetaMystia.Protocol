namespace MetaMystia.Protocol.Enums;

// ReSharper disable UnusedMember.Global

public enum RejectReason : byte
{
    UnknownError = 0,
    ModVersionMismatch = 1,
    GameVersionMismatch = 2,
    GameResourcesNotLoaded = 3,
    RoomFull = 4,
    DuplicatePeerId = 5,
    InvalidPlayerId = 6,
    PrepWorkConnectNotAllowed = 7      // 原 PrepWorkReconnectBlocked
}
