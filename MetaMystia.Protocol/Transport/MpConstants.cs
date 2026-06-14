namespace MetaMystia.Protocol.Transport;

// ReSharper disable UnusedMember.Global
/// <summary>
/// 多人游戏协议常量定义
/// </summary>
public static class MpConstants
{
    /// <summary>默认端口号</summary>
    public const int DefaultPort = 40815;
    
    /// <summary>主机的UID（固定为0）</summary>
    public const int HostUid = 0;
    
    /// <summary>未分配的UID值</summary>
    public const int UnassignedUid = -1;
    
    /// <summary>
    /// 协议版本号<br/>
    /// 大/小版本更新时需要修改（修订号更改一般不用改）
    /// </summary>
    public const short ProtocolVersion = 1;
}
