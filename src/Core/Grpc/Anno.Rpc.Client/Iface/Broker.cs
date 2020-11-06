// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Broker.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Anno.Rpc {

  /// <summary>Holder for reflection information generated from Broker.proto</summary>
  public static partial class BrokerReflection {

    #region Descriptor
    /// <summary>File descriptor for Broker.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BrokerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxCcm9rZXIucHJvdG8SCEFubm8uUnBjGgtlbXB0eS5wcm90byJiCgVNaWNy",
            "bxIKCgJpcBgBIAEoCRIMCgRwb3J0GAIgASgFEg8KB3RpbWVvdXQYAyABKAUS",
            "DAoEbmFtZRgEIAEoCRIQCghuaWNrbmFtZRgFIAEoCRIOCgZ3ZWlnaHQYBiAB",
            "KAUiMAoNR2V0TWljcm9SZXBseRIfCgZtaWNyb3MYASADKAsyDy5Bbm5vLlJw",
            "Yy5NaWNybyJwCg1Ccm9rZXJSZXF1ZXN0EjEKBWlucHV0GAEgAygLMiIuQW5u",
            "by5ScGMuQnJva2VyUmVxdWVzdC5JbnB1dEVudHJ5GiwKCklucHV0RW50cnkS",
            "CwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4ASIiCg9HZXRNaWNyb1Jl",
            "cXVlc3QSDwoHcmVxdWVzdBgBIAEoCSIcCgtCcm9rZXJSZXBseRINCgVyZXBs",
            "eRgBIAEoCSIaCglQaW5nUmVwbHkSDQoFcmVwbHkYASABKAgidgoQQWRkYnJv",
            "a2VyUmVxdWVzdBI0CgVpbnB1dBgBIAMoCzIlLkFubm8uUnBjLkFkZGJyb2tl",
            "clJlcXVlc3QuSW5wdXRFbnRyeRosCgpJbnB1dEVudHJ5EgsKA2tleRgBIAEo",
            "CRINCgV2YWx1ZRgCIAEoCToCOAEygAEKDUJyb2tlclNlcnZpY2USOgoGYnJv",
            "a2VyEhcuQW5uby5ScGMuQnJva2VyUmVxdWVzdBoVLkFubm8uUnBjLkJyb2tl",
            "clJlcGx5IgASMwoEUGluZxIWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRoTLkFu",
            "bm8uUnBjLlBpbmdSZXBseTL5AQoMQnJva2VyQ2VudGVyEjYKCkFkZF9icm9r",
            "ZXISDy5Bbm5vLlJwYy5NaWNybxoVLkFubm8uUnBjLkJyb2tlclJlcGx5IgAS",
            "QAoIR2V0TWljcm8SGS5Bbm5vLlJwYy5HZXRNaWNyb1JlcXVlc3QaFy5Bbm5v",
            "LlJwYy5HZXRNaWNyb1JlcGx5IgASOgoGSW52b2tlEhcuQW5uby5ScGMuQnJv",
            "a2VyUmVxdWVzdBoVLkFubm8uUnBjLkJyb2tlclJlcGx5IgASMwoEUGluZxIW",
            "Lmdvb2dsZS5wcm90b2J1Zi5FbXB0eRoTLkFubm8uUnBjLlBpbmdSZXBseWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Anno.Rpc.Micro), global::Anno.Rpc.Micro.Parser, new[]{ "Ip", "Port", "Timeout", "Name", "Nickname", "Weight" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Anno.Rpc.GetMicroReply), global::Anno.Rpc.GetMicroReply.Parser, new[]{ "Micros" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Anno.Rpc.BrokerRequest), global::Anno.Rpc.BrokerRequest.Parser, new[]{ "Input" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Anno.Rpc.GetMicroRequest), global::Anno.Rpc.GetMicroRequest.Parser, new[]{ "Request" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Anno.Rpc.BrokerReply), global::Anno.Rpc.BrokerReply.Parser, new[]{ "Reply" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Anno.Rpc.PingReply), global::Anno.Rpc.PingReply.Parser, new[]{ "Reply" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Anno.Rpc.AddbrokerRequest), global::Anno.Rpc.AddbrokerRequest.Parser, new[]{ "Input" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Micro : pb::IMessage<Micro> {
    private static readonly pb::MessageParser<Micro> _parser = new pb::MessageParser<Micro>(() => new Micro());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Micro> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Anno.Rpc.BrokerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Micro() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Micro(Micro other) : this() {
      ip_ = other.ip_;
      port_ = other.port_;
      timeout_ = other.timeout_;
      name_ = other.name_;
      nickname_ = other.nickname_;
      weight_ = other.weight_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Micro Clone() {
      return new Micro(this);
    }

    /// <summary>Field number for the "ip" field.</summary>
    public const int IpFieldNumber = 1;
    private string ip_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Ip {
      get { return ip_; }
      set {
        ip_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "port" field.</summary>
    public const int PortFieldNumber = 2;
    private int port_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Port {
      get { return port_; }
      set {
        port_ = value;
      }
    }

    /// <summary>Field number for the "timeout" field.</summary>
    public const int TimeoutFieldNumber = 3;
    private int timeout_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Timeout {
      get { return timeout_; }
      set {
        timeout_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 5;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "weight" field.</summary>
    public const int WeightFieldNumber = 6;
    private int weight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Weight {
      get { return weight_; }
      set {
        weight_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Micro);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Micro other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ip != other.Ip) return false;
      if (Port != other.Port) return false;
      if (Timeout != other.Timeout) return false;
      if (Name != other.Name) return false;
      if (Nickname != other.Nickname) return false;
      if (Weight != other.Weight) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ip.Length != 0) hash ^= Ip.GetHashCode();
      if (Port != 0) hash ^= Port.GetHashCode();
      if (Timeout != 0) hash ^= Timeout.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (Weight != 0) hash ^= Weight.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Ip.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Ip);
      }
      if (Port != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Port);
      }
      if (Timeout != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Timeout);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Name);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Nickname);
      }
      if (Weight != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Weight);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ip.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ip);
      }
      if (Port != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Port);
      }
      if (Timeout != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Timeout);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (Weight != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Weight);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Micro other) {
      if (other == null) {
        return;
      }
      if (other.Ip.Length != 0) {
        Ip = other.Ip;
      }
      if (other.Port != 0) {
        Port = other.Port;
      }
      if (other.Timeout != 0) {
        Timeout = other.Timeout;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.Weight != 0) {
        Weight = other.Weight;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Ip = input.ReadString();
            break;
          }
          case 16: {
            Port = input.ReadInt32();
            break;
          }
          case 24: {
            Timeout = input.ReadInt32();
            break;
          }
          case 34: {
            Name = input.ReadString();
            break;
          }
          case 42: {
            Nickname = input.ReadString();
            break;
          }
          case 48: {
            Weight = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetMicroReply : pb::IMessage<GetMicroReply> {
    private static readonly pb::MessageParser<GetMicroReply> _parser = new pb::MessageParser<GetMicroReply>(() => new GetMicroReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetMicroReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Anno.Rpc.BrokerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMicroReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMicroReply(GetMicroReply other) : this() {
      micros_ = other.micros_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMicroReply Clone() {
      return new GetMicroReply(this);
    }

    /// <summary>Field number for the "micros" field.</summary>
    public const int MicrosFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Anno.Rpc.Micro> _repeated_micros_codec
        = pb::FieldCodec.ForMessage(10, global::Anno.Rpc.Micro.Parser);
    private readonly pbc::RepeatedField<global::Anno.Rpc.Micro> micros_ = new pbc::RepeatedField<global::Anno.Rpc.Micro>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Anno.Rpc.Micro> Micros {
      get { return micros_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetMicroReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetMicroReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!micros_.Equals(other.micros_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= micros_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      micros_.WriteTo(output, _repeated_micros_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += micros_.CalculateSize(_repeated_micros_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetMicroReply other) {
      if (other == null) {
        return;
      }
      micros_.Add(other.micros_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            micros_.AddEntriesFrom(input, _repeated_micros_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class BrokerRequest : pb::IMessage<BrokerRequest> {
    private static readonly pb::MessageParser<BrokerRequest> _parser = new pb::MessageParser<BrokerRequest>(() => new BrokerRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BrokerRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Anno.Rpc.BrokerReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BrokerRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BrokerRequest(BrokerRequest other) : this() {
      input_ = other.input_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BrokerRequest Clone() {
      return new BrokerRequest(this);
    }

    /// <summary>Field number for the "input" field.</summary>
    public const int InputFieldNumber = 1;
    private static readonly pbc::MapField<string, string>.Codec _map_input_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 10);
    private readonly pbc::MapField<string, string> input_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Input {
      get { return input_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BrokerRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BrokerRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Input.Equals(other.Input)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Input.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      input_.WriteTo(output, _map_input_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += input_.CalculateSize(_map_input_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BrokerRequest other) {
      if (other == null) {
        return;
      }
      input_.Add(other.input_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            input_.AddEntriesFrom(input, _map_input_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetMicroRequest : pb::IMessage<GetMicroRequest> {
    private static readonly pb::MessageParser<GetMicroRequest> _parser = new pb::MessageParser<GetMicroRequest>(() => new GetMicroRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetMicroRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Anno.Rpc.BrokerReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMicroRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMicroRequest(GetMicroRequest other) : this() {
      request_ = other.request_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMicroRequest Clone() {
      return new GetMicroRequest(this);
    }

    /// <summary>Field number for the "request" field.</summary>
    public const int RequestFieldNumber = 1;
    private string request_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Request {
      get { return request_; }
      set {
        request_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetMicroRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetMicroRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Request != other.Request) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Request.Length != 0) hash ^= Request.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Request.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Request);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Request.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Request);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetMicroRequest other) {
      if (other == null) {
        return;
      }
      if (other.Request.Length != 0) {
        Request = other.Request;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Request = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class BrokerReply : pb::IMessage<BrokerReply> {
    private static readonly pb::MessageParser<BrokerReply> _parser = new pb::MessageParser<BrokerReply>(() => new BrokerReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BrokerReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Anno.Rpc.BrokerReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BrokerReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BrokerReply(BrokerReply other) : this() {
      reply_ = other.reply_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BrokerReply Clone() {
      return new BrokerReply(this);
    }

    /// <summary>Field number for the "reply" field.</summary>
    public const int ReplyFieldNumber = 1;
    private string reply_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Reply {
      get { return reply_; }
      set {
        reply_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BrokerReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BrokerReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Reply != other.Reply) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Reply.Length != 0) hash ^= Reply.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Reply.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Reply);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Reply.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Reply);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BrokerReply other) {
      if (other == null) {
        return;
      }
      if (other.Reply.Length != 0) {
        Reply = other.Reply;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Reply = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PingReply : pb::IMessage<PingReply> {
    private static readonly pb::MessageParser<PingReply> _parser = new pb::MessageParser<PingReply>(() => new PingReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PingReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Anno.Rpc.BrokerReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingReply(PingReply other) : this() {
      reply_ = other.reply_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingReply Clone() {
      return new PingReply(this);
    }

    /// <summary>Field number for the "reply" field.</summary>
    public const int ReplyFieldNumber = 1;
    private bool reply_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Reply {
      get { return reply_; }
      set {
        reply_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PingReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PingReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Reply != other.Reply) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Reply != false) hash ^= Reply.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Reply != false) {
        output.WriteRawTag(8);
        output.WriteBool(Reply);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Reply != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PingReply other) {
      if (other == null) {
        return;
      }
      if (other.Reply != false) {
        Reply = other.Reply;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Reply = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AddbrokerRequest : pb::IMessage<AddbrokerRequest> {
    private static readonly pb::MessageParser<AddbrokerRequest> _parser = new pb::MessageParser<AddbrokerRequest>(() => new AddbrokerRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddbrokerRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Anno.Rpc.BrokerReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddbrokerRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddbrokerRequest(AddbrokerRequest other) : this() {
      input_ = other.input_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddbrokerRequest Clone() {
      return new AddbrokerRequest(this);
    }

    /// <summary>Field number for the "input" field.</summary>
    public const int InputFieldNumber = 1;
    private static readonly pbc::MapField<string, string>.Codec _map_input_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 10);
    private readonly pbc::MapField<string, string> input_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Input {
      get { return input_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddbrokerRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddbrokerRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Input.Equals(other.Input)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Input.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      input_.WriteTo(output, _map_input_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += input_.CalculateSize(_map_input_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddbrokerRequest other) {
      if (other == null) {
        return;
      }
      input_.Add(other.input_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            input_.AddEntriesFrom(input, _map_input_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code