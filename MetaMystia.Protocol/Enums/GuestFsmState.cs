namespace MetaMystia.Protocol.Enums;

// ReSharper disable UnusedMember.Global
public enum GuestFsmState
{
    None,               // 尚未接收到任何顾客生命周期事件
    Constructed,        // 控制器已创建，但还未确定入队还是入座
    Queued,             // 正在等待位排队，尚未占桌
    SeatMoving,         // 已分配桌位，角色正在移动到座位
    SeatedDelay,        // 已落座，处于首单前的短暂延时
    WaitingServe,       // 订单已打开，正在等待料理和酒水送达
    Evaluating,         // 已开始评价，本单不再接受服务
    EatingDelay,        // 评价表现与吃饭动画等待中
    ContinueDecision,   // 评价结束，正在决定续单还是离开
    Leaving,            // 已开始离桌，正在收尾
    Left,               // 实体已彻底离开场景，本轮生命周期结束
    Manual,             // 手动顾客轨道，由外部脚本驱动
    Dead                // 联机崩溃的顾客，已被清理
}
