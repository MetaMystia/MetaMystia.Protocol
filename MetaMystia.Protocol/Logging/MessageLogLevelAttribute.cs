using System;

namespace MetaMystia.Protocol.Logging;

// ReSharper disable UnusedAutoPropertyAccessor.Global
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class MessageLogLevelAttribute : Attribute
{
    public MessageLogLevel OnReceive { get; set; } = MessageLogLevel.Info;
    public MessageLogLevel OnSend { get; set; } = MessageLogLevel.Info;
    public bool OnReceiveLogOnlyAction { get; set; } // 是否只打印消息类型不打印内容
    public bool OnSendLogOnlyAction { get; set; }
}