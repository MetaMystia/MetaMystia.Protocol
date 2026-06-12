using System;
using MemoryPack;
using MetaMystia.Protocol.Messages;

namespace MetaMystia.Protocol.Transport;

// ReSharper disable UnusedMember.Global
[MemoryPackable]
public partial class NetPacket(NetworkMessage[] networkMessages)
{
    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public NetworkMessage[] NetworkMessages { get; set; } = networkMessages;

    public byte[] ToBytesWithLength()
    {
        var body = MemoryPackSerializer.Serialize(this);
        var result = new byte[4 + body.Length];
        BitConverter.GetBytes(body.Length).CopyTo(result, 0);
        Buffer.BlockCopy(body, 0, result, 4, body.Length);
        return result;
    }

    public static NetPacket FromBytes(byte[] data) =>
        MemoryPackSerializer.Deserialize<NetPacket>(data)!;

    public NetworkMessage GetFirstAction() =>
        NetworkMessages.Length > 0 ? NetworkMessages[0] : throw new InvalidOperationException("Empty packet");

    public static NetPacket FromSingleAction(NetworkMessage networkMessage) => new([networkMessage]);
}
