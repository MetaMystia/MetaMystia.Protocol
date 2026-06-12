using System;

#nullable disable
namespace MetaMystia.Protocol.Logging;

/// <summary>The level, or severity of a log entry. (From BepInEx)</summary>
// ReSharper disable UnusedMember.Global
[Flags]
public enum MessageLogLevel
{
    /// <summary>No level selected.</summary>
    None = 0,
    /// <summary>
    ///     A fatal error has occurred, which cannot be recovered from.
    /// </summary>
    Fatal = 1,
    /// <summary>An error has occured, but can be recovered from.</summary>
    Error = 2,
    /// <summary>
    ///     A warning has been produced, but does not necessarily mean that something wrong has happened.
    /// </summary>
    Warning = 4,
    /// <summary>
    ///     An important message that should be displayed to the user.
    /// </summary>
    Message = 8,
    /// <summary>A message of low importance.</summary>
    Info = 16, // 0x00000010
    /// <summary>
    ///     A message that would likely only interest a developer.
    /// </summary>
    Debug = 32, // 0x00000020
    /// <summary>All log levels.</summary>
    All = Debug | Info | Message | Warning | Error | Fatal // 0x0000003F
}
