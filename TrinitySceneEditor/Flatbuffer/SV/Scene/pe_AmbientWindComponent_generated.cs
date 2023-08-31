// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct pe_AmbientWindComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static pe_AmbientWindComponent GetRootAspe_AmbientWindComponent(ByteBuffer _bb) { return GetRootAspe_AmbientWindComponent(_bb, new pe_AmbientWindComponent()); }
  public static pe_AmbientWindComponent GetRootAspe_AmbientWindComponent(ByteBuffer _bb, pe_AmbientWindComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public pe_AmbientWindComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Unk0 { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUnk0Bytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetUnk0Bytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetUnk0Array() { return __p.__vector_as_array<byte>(4); }
  public Vec3f? Unk1 { get { int o = __p.__offset(6); return o != 0 ? (Vec3f?)(new Vec3f()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public float Res2 { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk3 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk4 { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<Titan.TrinityScene.pe_AmbientWindComponent> Createpe_AmbientWindComponent(FlatBufferBuilder builder,
      StringOffset unk_0Offset = default(StringOffset),
      Vec3fT unk_1 = null,
      float res_2 = 0.0f,
      float unk_3 = 0.0f,
      float unk_4 = 0.0f) {
    builder.StartTable(5);
    pe_AmbientWindComponent.AddUnk4(builder, unk_4);
    pe_AmbientWindComponent.AddUnk3(builder, unk_3);
    pe_AmbientWindComponent.AddRes2(builder, res_2);
    pe_AmbientWindComponent.AddUnk1(builder, Vec3f.Pack(builder, unk_1));
    pe_AmbientWindComponent.AddUnk0(builder, unk_0Offset);
    return pe_AmbientWindComponent.Endpe_AmbientWindComponent(builder);
  }

  public static void Startpe_AmbientWindComponent(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddUnk0(FlatBufferBuilder builder, StringOffset unk0Offset) { builder.AddOffset(0, unk0Offset.Value, 0); }
  public static void AddUnk1(FlatBufferBuilder builder, Offset<Vec3f> unk1Offset) { builder.AddStruct(1, unk1Offset.Value, 0); }
  public static void AddRes2(FlatBufferBuilder builder, float res2) { builder.AddFloat(2, res2, 0.0f); }
  public static void AddUnk3(FlatBufferBuilder builder, float unk3) { builder.AddFloat(3, unk3, 0.0f); }
  public static void AddUnk4(FlatBufferBuilder builder, float unk4) { builder.AddFloat(4, unk4, 0.0f); }
  public static Offset<Titan.TrinityScene.pe_AmbientWindComponent> Endpe_AmbientWindComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.pe_AmbientWindComponent>(o);
  }
  public static void Finishpe_AmbientWindComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.pe_AmbientWindComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedpe_AmbientWindComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.pe_AmbientWindComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public pe_AmbientWindComponentT UnPack() {
    var _o = new pe_AmbientWindComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(pe_AmbientWindComponentT _o) {
    _o.Unk0 = this.Unk0;
    _o.Unk1 = this.Unk1.HasValue ? this.Unk1.Value.UnPack() : null;
    _o.Res2 = this.Res2;
    _o.Unk3 = this.Unk3;
    _o.Unk4 = this.Unk4;
  }
  public static Offset<Titan.TrinityScene.pe_AmbientWindComponent> Pack(FlatBufferBuilder builder, pe_AmbientWindComponentT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.pe_AmbientWindComponent>);
    var _unk_0 = _o.Unk0 == null ? default(StringOffset) : builder.CreateString(_o.Unk0);
    return Createpe_AmbientWindComponent(
      builder,
      _unk_0,
      _o.Unk1,
      _o.Res2,
      _o.Unk3,
      _o.Unk4);
  }
}

public class pe_AmbientWindComponentT
{
  public string Unk0 { get; set; }
  public Vec3fT Unk1 { get; set; }
  public float Res2 { get; set; }
  public float Unk3 { get; set; }
  public float Unk4 { get; set; }

  public pe_AmbientWindComponentT() {
    this.Unk0 = null;
    this.Unk1 = new Vec3fT();
    this.Res2 = 0.0f;
    this.Unk3 = 0.0f;
    this.Unk4 = 0.0f;
  }
  public static pe_AmbientWindComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return pe_AmbientWindComponent.GetRootAspe_AmbientWindComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    pe_AmbientWindComponent.Finishpe_AmbientWindComponentBuffer(fbb, pe_AmbientWindComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
