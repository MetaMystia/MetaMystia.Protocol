namespace MetaMystia.Protocol.Enums;

/// <summary>
/// QTE增益效果枚举
/// </summary>
// ReSharper disable UnusedMember.Global
public enum QTEBuff
{
    /// <summary>立即完食</summary>
    InstantEvaluation = 0,
    
    /// <summary>耐心不减</summary>
    PatientFreeze = 1,
    
    /// <summary>投掷上菜</summary>
    ThrowDeliver = 2,
    
    /// <summary>热火朝天</summary>
    Fever = 3,
    
    /// <summary>永续热火朝天</summary>
    FeverInfinite = -1
}
