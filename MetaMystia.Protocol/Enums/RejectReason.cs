namespace MetaMystia.Protocol.Enums;

// ReSharper disable UnusedMember.Global

/// <summary>
/// 连接拒绝原因枚举
/// </summary>
public enum RejectReason : byte
{
    /// <summary>未知错误</summary>
    UnknownError = 0,
    
    /// <summary>模组版本不匹配</summary>
    ModVersionMismatch = 1,
    
    /// <summary>游戏版本不匹配</summary>
    GameVersionMismatch = 2,
    
    /// <summary>游戏资源未加载</summary>
    GameResourcesNotLoaded = 3,
    
    /// <summary>房间已满</summary>
    RoomFull = 4,
    
    /// <summary>重复的PeerId</summary>
    DuplicatePeerId = 5,
    
    /// <summary>无效的玩家ID</summary>
    InvalidPlayerId = 6,
    
    /// <summary>准备阶段不允许连接</summary>
    PrepWorkConnectNotAllowed = 7
}
