// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ti_ModelDitherFadeComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ti_ModelDitherFadeComponent GetRootAsti_ModelDitherFadeComponent(ByteBuffer _bb) { return GetRootAsti_ModelDitherFadeComponent(_bb, new ti_ModelDitherFadeComponent()); }
  public static ti_ModelDitherFadeComponent GetRootAsti_ModelDitherFadeComponent(ByteBuffer _bb, ti_ModelDitherFadeComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ti_ModelDitherFadeComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public bool Unk0 { get { int o = __p.__offset(4); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float Unk1 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk2 { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk3 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk4 { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<Titan.TrinityScene.ti_ModelDitherFadeComponent> Createti_ModelDitherFadeComponent(FlatBufferBuilder builder,
      bool unk0 = false,
      float unk1 = 0.0f,
      float unk2 = 0.0f,
      float unk3 = 0.0f,
      float unk4 = 0.0f) {
    builder.StartTable(5);
    ti_ModelDitherFadeComponent.AddUnk4(builder, unk4);
    ti_ModelDitherFadeComponent.AddUnk3(builder, unk3);
    ti_ModelDitherFadeComponent.AddUnk2(builder, unk2);
    ti_ModelDitherFadeComponent.AddUnk1(builder, unk1);
    ti_ModelDitherFadeComponent.AddUnk0(builder, unk0);
    return ti_ModelDitherFadeComponent.Endti_ModelDitherFadeComponent(builder);
  }

  public static void Startti_ModelDitherFadeComponent(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddUnk0(FlatBufferBuilder builder, bool unk0) { builder.AddBool(0, unk0, false); }
  public static void AddUnk1(FlatBufferBuilder builder, float unk1) { builder.AddFloat(1, unk1, 0.0f); }
  public static void AddUnk2(FlatBufferBuilder builder, float unk2) { builder.AddFloat(2, unk2, 0.0f); }
  public static void AddUnk3(FlatBufferBuilder builder, float unk3) { builder.AddFloat(3, unk3, 0.0f); }
  public static void AddUnk4(FlatBufferBuilder builder, float unk4) { builder.AddFloat(4, unk4, 0.0f); }
  public static Offset<Titan.TrinityScene.ti_ModelDitherFadeComponent> Endti_ModelDitherFadeComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.ti_ModelDitherFadeComponent>(o);
  }
  public static void Finishti_ModelDitherFadeComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.ti_ModelDitherFadeComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedti_ModelDitherFadeComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.ti_ModelDitherFadeComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public ti_ModelDitherFadeComponentT UnPack() {
    var _o = new ti_ModelDitherFadeComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ti_ModelDitherFadeComponentT _o) {
    _o.Unk0 = this.Unk0;
    _o.Unk1 = this.Unk1;
    _o.Unk2 = this.Unk2;
    _o.Unk3 = this.Unk3;
    _o.Unk4 = this.Unk4;
  }
  public static Offset<Titan.TrinityScene.ti_ModelDitherFadeComponent> Pack(FlatBufferBuilder builder, ti_ModelDitherFadeComponentT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.ti_ModelDitherFadeComponent>);
    return Createti_ModelDitherFadeComponent(
      builder,
      _o.Unk0,
      _o.Unk1,
      _o.Unk2,
      _o.Unk3,
      _o.Unk4);
  }
}

public class ti_ModelDitherFadeComponentT
{
  public bool Unk0 { get; set; }
  public float Unk1 { get; set; }
  public float Unk2 { get; set; }
  public float Unk3 { get; set; }
  public float Unk4 { get; set; }

  public ti_ModelDitherFadeComponentT() {
    this.Unk0 = false;
    this.Unk1 = 0.0f;
    this.Unk2 = 0.0f;
    this.Unk3 = 0.0f;
    this.Unk4 = 0.0f;
  }
  public static ti_ModelDitherFadeComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return ti_ModelDitherFadeComponent.GetRootAsti_ModelDitherFadeComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    ti_ModelDitherFadeComponent.Finishti_ModelDitherFadeComponentBuffer(fbb, ti_ModelDitherFadeComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
