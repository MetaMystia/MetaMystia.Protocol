using System;

namespace MetaMystia.Protocol.Transport;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class RoomRelayAttribute : Attribute;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class PublicRelayAttribute : Attribute;

// ReSharper disable once UnusedType.Global
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class ServerRelayAttribute : RoomRelayAttribute;
