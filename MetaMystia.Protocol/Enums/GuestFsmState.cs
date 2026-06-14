namespace MetaMystia.Protocol.Enums;

// ReSharper disable UnusedMember.Global

/// <summary>
/// 客人有限状态机状态枚举
/// </summary>
public enum GuestFsmState
{
    /// <summary>尚未接收到任何顾客生命周期事件</summary>
    None,
    
    /// <summary>控制器已创建，但还未确定入队还是入座</summary>
    Constructed,
    
    /// <summary>正在等待位排队，尚未占桌</summary>
    Queued,
    
    /// <summary>已分配桌位，角色正在移动到座位</summary>
    SeatMoving,
    
    /// <summary>已落座，处于首单前的短暂延时</summary>
    SeatedDelay,
    
    /// <summary>订单已打开，正在等待料理和酒水送达</summary>
    WaitingServe,
    
    /// <summary>已开始评价，本单不再接受服务</summary>
    Evaluating,
    
    /// <summary>评价表现与吃饭动画等待中</summary>
    EatingDelay,
    
    /// <summary>评价结束，正在决定续单还是离开</summary>
    ContinueDecision,
    
    /// <summary>已开始离桌，正在收尾</summary>
    Leaving,
    
    /// <summary>实体已彻底离开场景，本轮生命周期结束</summary>
    Left,
    
    /// <summary>手动顾客轨道，由外部脚本驱动</summary>
    Manual,
    
    /// <summary>联机崩溃的顾客，已被清理</summary>
    Dead
}
