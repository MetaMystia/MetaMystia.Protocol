using System;
using System.Collections.Generic;
using System.IO;

namespace MetaMystia.Protocol.Transport;

// ReSharper disable UnusedMember.Global
// ReSharper disable once UnusedType.Global
public sealed class PacketBuffer
{
    private MemoryStream _buffer = new();

    public void Write(byte[] data, int offset, int count)
    {
        _buffer.Position = _buffer.Length;
        _buffer.Write(data, offset, count);
        _buffer.Position = 0;
    }

    public List<NetPacket> ExtractPackets()
    {
        var packets = new List<NetPacket>();
        while (true)
        {
            if (_buffer.Length - _buffer.Position < 4) break;
            var lenBytes = new byte[4];
            // ReSharper disable once MustUseReturnValue
            _buffer.Read(lenBytes, 0, 4);
            
            var bodyLength = BitConverter.ToInt32(lenBytes, 0);
            if (_buffer.Length - _buffer.Position < bodyLength)
            {
                _buffer.Position -= 4;
                break;
            }
            var body = new byte[bodyLength];
            // ReSharper disable once MustUseReturnValue
            _buffer.Read(body, 0, bodyLength);
            packets.Add(NetPacket.FromBytes(body));
        }

        if (_buffer.Position < _buffer.Length)
        {
            var leftover = _buffer.ToArray()[(int)_buffer.Position..];
            _buffer = new MemoryStream();
            _buffer.Write(leftover, 0, leftover.Length);
            _buffer.Position = 0;
        }
        else
        {
            _buffer = new MemoryStream();
        }

        return packets;
    }
}
