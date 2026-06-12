using System;
using MemoryPack;

namespace MetaMystia.Protocol.Transport;

// ReSharper disable UnusedMember.Global
[MemoryPackable]
public partial class NetPacket(Action[] actions)
{
    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public Action[] Actions { get; set; } = actions;

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

    public Action GetFirstAction() =>
        Actions.Length > 0 ? Actions[0] : throw new InvalidOperationException("Empty packet");

    public static NetPacket FromSingleAction(Action action) => new([action]);
}
