using MemoryPack;
using MetaMystia.Protocol.Logging;
using MetaMystia.Protocol.Transport;

namespace MetaMystia.Protocol.Messages.Common;

/// <summary>
/// 任何玩家 → 所有玩家：发送聊天消息<br/>
/// 原 MessageAction
/// </summary>
[MemoryPackable]
[PublicRelay]
[MessageLogLevel(OnReceive = MessageLogLevel.Message, OnSend = MessageLogLevel.Message)]
public partial class ChatMessage : NetworkMessage
{
    [MemoryPackIgnore]
    private const int MaxMessageLength = 1024;
    
    public string Message { get; private set; } = string.Empty;
    
    /// <summary> 简单的工厂方法 </summary>
    // ReSharper disable once UnusedMember.Global
    public static ChatMessage Create(string msg)
    {
        return new ChatMessage
        {
            Message = msg.Length <= MaxMessageLength ? msg : msg[..MaxMessageLength]
        };
    }
}
