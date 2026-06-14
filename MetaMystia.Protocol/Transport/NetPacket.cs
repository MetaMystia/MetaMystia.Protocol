using System;
using MemoryPack;
using MetaMystia.Protocol.Messages;

namespace MetaMystia.Protocol.Transport;

// ReSharper disable UnusedMember.Global
/// <summary>
/// 网络数据包，包含一个或多个网络消息。
/// 用于在网络上传输和序列化消息集合。
/// </summary>
[MemoryPackable]
public partial class NetPacket(NetworkMessage[] networkMessages)
{
    /// <summary>
    /// 包含的网络消息数组
    /// </summary>
    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public NetworkMessage[] NetworkMessages { get; set; } = networkMessages;

    /// <summary>
    /// 将数据包序列化为字节数组，包含4字节长度前缀
    /// </summary>
    /// <returns>带有长度前缀的字节数组</returns>
    public byte[] ToBytesWithLength()
    {
        var body = MemoryPackSerializer.Serialize(this);
        var result = new byte[4 + body.Length];
        BitConverter.GetBytes(body.Length).CopyTo(result, 0);
        Buffer.BlockCopy(body, 0, result, 4, body.Length);
        return result;
    }

    /// <summary>
    /// 从字节数组反序列化数据包
    /// </summary>
    /// <param name="data">包含数据包的字节数组</param>
    /// <returns>反序列化后的NetPacket实例</returns>
    public static NetPacket FromBytes(byte[] data) =>
        MemoryPackSerializer.Deserialize<NetPacket>(data)!;

    /// <summary>
    /// 获取第一个消息
    /// </summary>
    /// <returns>第一个网络消息</returns>
    /// <exception cref="InvalidOperationException">数据包为空时抛出</exception>
    public NetworkMessage GetFirstMessage() =>
        NetworkMessages.Length > 0 ? NetworkMessages[0] : throw new InvalidOperationException("Empty packet");

    /// <summary>
    /// 从单个消息创建数据包
    /// </summary>
    /// <param name="networkMessage">要封装的网络消息</param>
    /// <returns>包含该消息的NetPacket实例</returns>
    public static NetPacket FromSingleMessage(NetworkMessage networkMessage) => new([networkMessage]);
}
