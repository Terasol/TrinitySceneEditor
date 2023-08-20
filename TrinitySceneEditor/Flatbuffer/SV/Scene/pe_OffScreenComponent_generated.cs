// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct pe_OffScreenComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static pe_OffScreenComponent GetRootAspe_OffScreenComponent(ByteBuffer _bb) { return GetRootAspe_OffScreenComponent(_bb, new pe_OffScreenComponent()); }
  public static pe_OffScreenComponent GetRootAspe_OffScreenComponent(ByteBuffer _bb, pe_OffScreenComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public pe_OffScreenComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Unk0 { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint Unk1 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public float Unk2 { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public uint Unk3 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint Unk4 { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string Unk5 { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUnk5Bytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetUnk5Bytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetUnk5Array() { return __p.__vector_as_array<byte>(14); }

  public static Offset<Titan.TrinityScene.pe_OffScreenComponent> Createpe_OffScreenComponent(FlatBufferBuilder builder,
      uint unk_0 = 0,
      uint unk_1 = 0,
      float unk_2 = 0.0f,
      uint unk_3 = 0,
      uint unk_4 = 0,
      StringOffset unk_5Offset = default(StringOffset)) {
    builder.StartTable(6);
    pe_OffScreenComponent.AddUnk5(builder, unk_5Offset);
    pe_OffScreenComponent.AddUnk4(builder, unk_4);
    pe_OffScreenComponent.AddUnk3(builder, unk_3);
    pe_OffScreenComponent.AddUnk2(builder, unk_2);
    pe_OffScreenComponent.AddUnk1(builder, unk_1);
    pe_OffScreenComponent.AddUnk0(builder, unk_0);
    return pe_OffScreenComponent.Endpe_OffScreenComponent(builder);
  }

  public static void Startpe_OffScreenComponent(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddUnk0(FlatBufferBuilder builder, uint unk0) { builder.AddUint(0, unk0, 0); }
  public static void AddUnk1(FlatBufferBuilder builder, uint unk1) { builder.AddUint(1, unk1, 0); }
  public static void AddUnk2(FlatBufferBuilder builder, float unk2) { builder.AddFloat(2, unk2, 0.0f); }
  public static void AddUnk3(FlatBufferBuilder builder, uint unk3) { builder.AddUint(3, unk3, 0); }
  public static void AddUnk4(FlatBufferBuilder builder, uint unk4) { builder.AddUint(4, unk4, 0); }
  public static void AddUnk5(FlatBufferBuilder builder, StringOffset unk5Offset) { builder.AddOffset(5, unk5Offset.Value, 0); }
  public static Offset<Titan.TrinityScene.pe_OffScreenComponent> Endpe_OffScreenComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.pe_OffScreenComponent>(o);
  }
  public static void Finishpe_OffScreenComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.pe_OffScreenComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedpe_OffScreenComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.pe_OffScreenComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public pe_OffScreenComponentT UnPack() {
    var _o = new pe_OffScreenComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(pe_OffScreenComponentT _o) {
    _o.Unk0 = this.Unk0;
    _o.Unk1 = this.Unk1;
    _o.Unk2 = this.Unk2;
    _o.Unk3 = this.Unk3;
    _o.Unk4 = this.Unk4;
    _o.Unk5 = this.Unk5;
  }
  public static Offset<Titan.TrinityScene.pe_OffScreenComponent> Pack(FlatBufferBuilder builder, pe_OffScreenComponentT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.pe_OffScreenComponent>);
    var _unk_5 = _o.Unk5 == null ? default(StringOffset) : builder.CreateString(_o.Unk5);
    return Createpe_OffScreenComponent(
      builder,
      _o.Unk0,
      _o.Unk1,
      _o.Unk2,
      _o.Unk3,
      _o.Unk4,
      _unk_5);
  }
}

public class pe_OffScreenComponentT
{
  public uint Unk0 { get; set; }
  public uint Unk1 { get; set; }
  public float Unk2 { get; set; }
  public uint Unk3 { get; set; }
  public uint Unk4 { get; set; }
  public string Unk5 { get; set; }

  public pe_OffScreenComponentT() {
    this.Unk0 = 0;
    this.Unk1 = 0;
    this.Unk2 = 0.0f;
    this.Unk3 = 0;
    this.Unk4 = 0;
    this.Unk5 = null;
  }
  public static pe_OffScreenComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return pe_OffScreenComponent.GetRootAspe_OffScreenComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    pe_OffScreenComponent.Finishpe_OffScreenComponentBuffer(fbb, pe_OffScreenComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}