namespace MetaMystia.Protocol.Enums;

// 不太优雅，但目前只能手动与原游戏对齐了，建议用Switch转换为游戏内部枚举
// 注意：以下的代码理论上不应该修改！

// ReSharper disable UnusedMember.Global

public enum EvaluationResult
{
    Exbad,
    Bad,
    Normal,
    Good,
    ExGood,
    Null
}

public enum GuestType
{
    Normal,
    Special
}

public enum LeaveType
{
    Move,
    Fading,
    Delete,
    MoveToTargetPosition
}

public enum MathOperation
{
    Add,
    Multiply,
    Set
}

public enum OrderGenerationResult
{
    Succeed,
    OrderCountDepleted,
    NoMoney,
    ExceedEndurance,
    NotContinue
}

public enum OrderType
{
    Normal,
    Special
}

public enum Scene
{
    DayScene,
    MainScene,
    LoadScene,
    IzakayaPrepScene,
    WorkScene,
    ResultScene,
    StaffScene,
    EmptyScene
}

public enum SellableType
{
    Food,
    Beverage
}

public enum ServeType
{
    Player,
    Boss
}

public enum SkinSelectedType
{
    Default = 0,
    Explicit = 1,
    DLC = 2
}
