using System;
using System.Collections.Generic;
using System.IO;

namespace MetaMystia.Protocol.Transport;

// ReSharper disable UnusedMember.Global
// ReSharper disable once UnusedType.Global
/// <summary>
/// 数据包缓冲区，用于累积和解析网络数据流中的完整数据包。
/// 支持TCP流式传输中数据包的边界处理。
/// </summary>
public sealed class PacketBuffer
{
    private MemoryStream _buffer = new();

    /// <summary>
    /// 向缓冲区写入数据
    /// </summary>
    /// <param name="data">要写入的数据</param>
    /// <param name="offset">数据的起始偏移量</param>
    /// <param name="count">要写入的字节数</param>
    public void Write(byte[] data, int offset, int count)
    {
        _buffer.Position = _buffer.Length;
        _buffer.Write(data, offset, count);
        _buffer.Position = 0;
    }

    /// <summary>
    /// 从缓冲区中提取所有完整的数据包
    /// 剩余不完整的数据会保留在缓冲区中等待后续数据
    /// </summary>
    /// <returns>提取出的完整数据包列表</returns>
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
