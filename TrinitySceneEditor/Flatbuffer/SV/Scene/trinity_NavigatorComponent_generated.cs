// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct trinity_NavigatorComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static trinity_NavigatorComponent GetRootAstrinity_NavigatorComponent(ByteBuffer _bb) { return GetRootAstrinity_NavigatorComponent(_bb, new trinity_NavigatorComponent()); }
  public static trinity_NavigatorComponent GetRootAstrinity_NavigatorComponent(ByteBuffer _bb, trinity_NavigatorComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public trinity_NavigatorComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string ComponentName { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetComponentNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetComponentNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetComponentNameArray() { return __p.__vector_as_array<byte>(4); }
  public float Unk1 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk2 { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk3 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk4 { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk5 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk6 { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk7 { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk8 { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk9 { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk10 { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk11 { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk12 { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk13 { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk14 { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk15 { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public uint Unk16 { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<Titan.TrinityScene.trinity_NavigatorComponent> Createtrinity_NavigatorComponent(FlatBufferBuilder builder,
      StringOffset component_nameOffset = default(StringOffset),
      float unk_1 = 0.0f,
      float unk_2 = 0.0f,
      float unk_3 = 0.0f,
      float unk_4 = 0.0f,
      float unk_5 = 0.0f,
      float unk_6 = 0.0f,
      float unk_7 = 0.0f,
      float unk_8 = 0.0f,
      float unk_9 = 0.0f,
      float unk_10 = 0.0f,
      float unk_11 = 0.0f,
      float unk_12 = 0.0f,
      float unk_13 = 0.0f,
      float unk_14 = 0.0f,
      float unk_15 = 0.0f,
      uint unk_16 = 0) {
    builder.StartTable(17);
    trinity_NavigatorComponent.AddUnk16(builder, unk_16);
    trinity_NavigatorComponent.AddUnk15(builder, unk_15);
    trinity_NavigatorComponent.AddUnk14(builder, unk_14);
    trinity_NavigatorComponent.AddUnk13(builder, unk_13);
    trinity_NavigatorComponent.AddUnk12(builder, unk_12);
    trinity_NavigatorComponent.AddUnk11(builder, unk_11);
    trinity_NavigatorComponent.AddUnk10(builder, unk_10);
    trinity_NavigatorComponent.AddUnk9(builder, unk_9);
    trinity_NavigatorComponent.AddUnk8(builder, unk_8);
    trinity_NavigatorComponent.AddUnk7(builder, unk_7);
    trinity_NavigatorComponent.AddUnk6(builder, unk_6);
    trinity_NavigatorComponent.AddUnk5(builder, unk_5);
    trinity_NavigatorComponent.AddUnk4(builder, unk_4);
    trinity_NavigatorComponent.AddUnk3(builder, unk_3);
    trinity_NavigatorComponent.AddUnk2(builder, unk_2);
    trinity_NavigatorComponent.AddUnk1(builder, unk_1);
    trinity_NavigatorComponent.AddComponentName(builder, component_nameOffset);
    return trinity_NavigatorComponent.Endtrinity_NavigatorComponent(builder);
  }

  public static void Starttrinity_NavigatorComponent(FlatBufferBuilder builder) { builder.StartTable(17); }
  public static void AddComponentName(FlatBufferBuilder builder, StringOffset componentNameOffset) { builder.AddOffset(0, componentNameOffset.Value, 0); }
  public static void AddUnk1(FlatBufferBuilder builder, float unk1) { builder.AddFloat(1, unk1, 0.0f); }
  public static void AddUnk2(FlatBufferBuilder builder, float unk2) { builder.AddFloat(2, unk2, 0.0f); }
  public static void AddUnk3(FlatBufferBuilder builder, float unk3) { builder.AddFloat(3, unk3, 0.0f); }
  public static void AddUnk4(FlatBufferBuilder builder, float unk4) { builder.AddFloat(4, unk4, 0.0f); }
  public static void AddUnk5(FlatBufferBuilder builder, float unk5) { builder.AddFloat(5, unk5, 0.0f); }
  public static void AddUnk6(FlatBufferBuilder builder, float unk6) { builder.AddFloat(6, unk6, 0.0f); }
  public static void AddUnk7(FlatBufferBuilder builder, float unk7) { builder.AddFloat(7, unk7, 0.0f); }
  public static void AddUnk8(FlatBufferBuilder builder, float unk8) { builder.AddFloat(8, unk8, 0.0f); }
  public static void AddUnk9(FlatBufferBuilder builder, float unk9) { builder.AddFloat(9, unk9, 0.0f); }
  public static void AddUnk10(FlatBufferBuilder builder, float unk10) { builder.AddFloat(10, unk10, 0.0f); }
  public static void AddUnk11(FlatBufferBuilder builder, float unk11) { builder.AddFloat(11, unk11, 0.0f); }
  public static void AddUnk12(FlatBufferBuilder builder, float unk12) { builder.AddFloat(12, unk12, 0.0f); }
  public static void AddUnk13(FlatBufferBuilder builder, float unk13) { builder.AddFloat(13, unk13, 0.0f); }
  public static void AddUnk14(FlatBufferBuilder builder, float unk14) { builder.AddFloat(14, unk14, 0.0f); }
  public static void AddUnk15(FlatBufferBuilder builder, float unk15) { builder.AddFloat(15, unk15, 0.0f); }
  public static void AddUnk16(FlatBufferBuilder builder, uint unk16) { builder.AddUint(16, unk16, 0); }
  public static Offset<Titan.TrinityScene.trinity_NavigatorComponent> Endtrinity_NavigatorComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.trinity_NavigatorComponent>(o);
  }
  public static void Finishtrinity_NavigatorComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_NavigatorComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedtrinity_NavigatorComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_NavigatorComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public trinity_NavigatorComponentT UnPack() {
    var _o = new trinity_NavigatorComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(trinity_NavigatorComponentT _o) {
    _o.ComponentName = this.ComponentName;
    _o.Unk1 = this.Unk1;
    _o.Unk2 = this.Unk2;
    _o.Unk3 = this.Unk3;
    _o.Unk4 = this.Unk4;
    _o.Unk5 = this.Unk5;
    _o.Unk6 = this.Unk6;
    _o.Unk7 = this.Unk7;
    _o.Unk8 = this.Unk8;
    _o.Unk9 = this.Unk9;
    _o.Unk10 = this.Unk10;
    _o.Unk11 = this.Unk11;
    _o.Unk12 = this.Unk12;
    _o.Unk13 = this.Unk13;
    _o.Unk14 = this.Unk14;
    _o.Unk15 = this.Unk15;
    _o.Unk16 = this.Unk16;
  }
  public static Offset<Titan.TrinityScene.trinity_NavigatorComponent> Pack(FlatBufferBuilder builder, trinity_NavigatorComponentT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.trinity_NavigatorComponent>);
    var _component_name = _o.ComponentName == null ? default(StringOffset) : builder.CreateString(_o.ComponentName);
    return Createtrinity_NavigatorComponent(
      builder,
      _component_name,
      _o.Unk1,
      _o.Unk2,
      _o.Unk3,
      _o.Unk4,
      _o.Unk5,
      _o.Unk6,
      _o.Unk7,
      _o.Unk8,
      _o.Unk9,
      _o.Unk10,
      _o.Unk11,
      _o.Unk12,
      _o.Unk13,
      _o.Unk14,
      _o.Unk15,
      _o.Unk16);
  }
}

public class trinity_NavigatorComponentT
{
  public string ComponentName { get; set; }
  public float Unk1 { get; set; }
  public float Unk2 { get; set; }
  public float Unk3 { get; set; }
  public float Unk4 { get; set; }
  public float Unk5 { get; set; }
  public float Unk6 { get; set; }
  public float Unk7 { get; set; }
  public float Unk8 { get; set; }
  public float Unk9 { get; set; }
  public float Unk10 { get; set; }
  public float Unk11 { get; set; }
  public float Unk12 { get; set; }
  public float Unk13 { get; set; }
  public float Unk14 { get; set; }
  public float Unk15 { get; set; }
  public uint Unk16 { get; set; }

  public trinity_NavigatorComponentT() {
    this.ComponentName = null;
    this.Unk1 = 0.0f;
    this.Unk2 = 0.0f;
    this.Unk3 = 0.0f;
    this.Unk4 = 0.0f;
    this.Unk5 = 0.0f;
    this.Unk6 = 0.0f;
    this.Unk7 = 0.0f;
    this.Unk8 = 0.0f;
    this.Unk9 = 0.0f;
    this.Unk10 = 0.0f;
    this.Unk11 = 0.0f;
    this.Unk12 = 0.0f;
    this.Unk13 = 0.0f;
    this.Unk14 = 0.0f;
    this.Unk15 = 0.0f;
    this.Unk16 = 0;
  }
  public static trinity_NavigatorComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return trinity_NavigatorComponent.GetRootAstrinity_NavigatorComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    trinity_NavigatorComponent.Finishtrinity_NavigatorComponentBuffer(fbb, trinity_NavigatorComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}