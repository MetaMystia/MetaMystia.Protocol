using System;

namespace MetaMystia.Protocol.Enums;

/// <summary>
/// DLC 标识位，用于增量 ResourceDatabase 传输
/// </summary>
// ReSharper disable UnusedMember.Global
[Flags]
public enum DLCPack : byte
{
    None = 0,
    Core = 1 << 0,
    DLC1 = 1 << 1,
    DLC2 = 1 << 2,
    DLCMusic = 1 << 3,
    DLC3 = 1 << 4,
    DLC4 = 1 << 5,
    DLC5 = 1 << 6,

    All = Core | DLC1 | DLC2 | DLCMusic | DLC3 | DLC4 | DLC5
}