namespace MetaMystia.Protocol.Enums;

// 不太优雅，但目前只能手动与原游戏对齐了，建议用Switch转换为游戏内部枚举
// 注意：以下的代码理论上不应该修改！

/// <summary>
/// 订单评价结果枚举
/// </summary>
// ReSharper disable UnusedMember.Global
public enum EvaluationResult
{
    /// <summary>极度不满</summary>
    Exbad,
    
    /// <summary>不满</summary>
    Bad,
    
    /// <summary>普通</summary>
    Normal,
    
    /// <summary>满意</summary>
    Good,
    
    /// <summary>完美（释放奖励符卡）</summary>
    ExGood,
    
    /// <summary>Fallback</summary>
    Null
}

/// <summary>
/// 客人类型枚举
/// </summary>
public enum GuestType
{
    /// <summary>普通顾客</summary>
    Normal,
    
    /// <summary>稀有/特殊顾客</summary>
    Special
}

/// <summary>
/// 离开类型枚举
/// </summary>
public enum LeaveType
{
    /// <summary>移动离开</summary>
    Move,
    
    /// <summary>淡出离开</summary>
    Fading,
    
    /// <summary>删除离开</summary>
    Delete,
    
    /// <summary>移动到目标位置</summary>
    MoveToTargetPosition
}

/// <summary>
/// 数学运算类型枚举
/// </summary>
public enum MathOperation
{
    /// <summary>加法</summary>
    Add,
    
    /// <summary>乘法</summary>
    Multiply,
    
    /// <summary>赋值</summary>
    Set
}

/// <summary>
/// 订单生成结果枚举
/// </summary>
public enum OrderGenerationResult
{
    /// <summary>成功</summary>
    Succeed,
    
    /// <summary>订单数量耗尽</summary>
    OrderCountDepleted,
    
    /// <summary>资金不足</summary>
    NoMoney,
    
    /// <summary>耐心耗尽</summary>
    ExceedEndurance,
    
    /// <summary>不继续</summary>
    NotContinue
}

/// <summary>
/// 订单类型枚举
/// </summary>
public enum OrderType
{
    /// <summary>普通顾客订单</summary>
    Normal,
    
    /// <summary>稀有/特殊顾客订单</summary>
    Special
}

/// <summary>
/// 游戏场景枚举
/// </summary>
public enum Scene
{
    /// <summary>白天场景</summary>
    DayScene,
    
    /// <summary>主场景</summary>
    MainScene,
    
    /// <summary>加载场景</summary>
    LoadScene,
    
    /// <summary>居酒屋准备场景</summary>
    IzakayaPrepScene,
    
    /// <summary>工作场景（夜间）</summary>
    WorkScene,
    
    /// <summary>结算场景</summary>
    ResultScene,
    
    /// <summary>制作人员名单场景</summary>
    StaffScene,
    
    /// <summary>空场景</summary>
    EmptyScene
}

/// <summary>
/// 可售卖类型枚举
/// </summary>
public enum SellableType
{
    /// <summary>食物</summary>
    Food,
    
    /// <summary>酒水</summary>
    Beverage
}

/// <summary>
/// 服务类型枚举
/// </summary>
public enum ServeType
{
    /// <summary></summary>
    Player,
    
    /// <summary></summary>
    Boss
}

/// <summary>
/// 皮肤选择类型枚举
/// </summary>
public enum SkinSelectedType
{
    /// <summary>默认皮肤</summary>
    Default = 0,
    
    /// <summary>显式选择，只对Mystia和Kyouko生效</summary>
    Explicit = 1,
    
    /// <summary>DLC皮肤</summary>
    DLC = 2
}
