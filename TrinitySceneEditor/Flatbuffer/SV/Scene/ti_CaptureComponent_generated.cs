// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ti_CaptureComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ti_CaptureComponent GetRootAsti_CaptureComponent(ByteBuffer _bb) { return GetRootAsti_CaptureComponent(_bb, new ti_CaptureComponent()); }
  public static ti_CaptureComponent GetRootAsti_CaptureComponent(ByteBuffer _bb, ti_CaptureComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ti_CaptureComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Unk0 { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint Unk1 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<Titan.TrinityScene.ti_CaptureComponent> Createti_CaptureComponent(FlatBufferBuilder builder,
      uint unk_0 = 0,
      uint unk_1 = 0) {
    builder.StartTable(2);
    ti_CaptureComponent.AddUnk1(builder, unk_1);
    ti_CaptureComponent.AddUnk0(builder, unk_0);
    return ti_CaptureComponent.Endti_CaptureComponent(builder);
  }

  public static void Startti_CaptureComponent(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddUnk0(FlatBufferBuilder builder, uint unk0) { builder.AddUint(0, unk0, 0); }
  public static void AddUnk1(FlatBufferBuilder builder, uint unk1) { builder.AddUint(1, unk1, 0); }
  public static Offset<Titan.TrinityScene.ti_CaptureComponent> Endti_CaptureComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.ti_CaptureComponent>(o);
  }
  public static void Finishti_CaptureComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.ti_CaptureComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedti_CaptureComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.ti_CaptureComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public ti_CaptureComponentT UnPack() {
    var _o = new ti_CaptureComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ti_CaptureComponentT _o) {
    _o.Unk0 = this.Unk0;
    _o.Unk1 = this.Unk1;
  }
  public static Offset<Titan.TrinityScene.ti_CaptureComponent> Pack(FlatBufferBuilder builder, ti_CaptureComponentT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.ti_CaptureComponent>);
    return Createti_CaptureComponent(
      builder,
      _o.Unk0,
      _o.Unk1);
  }
}

public class ti_CaptureComponentT
{
  public uint Unk0 { get; set; }
  public uint Unk1 { get; set; }

  public ti_CaptureComponentT() {
    this.Unk0 = 0;
    this.Unk1 = 0;
  }
  public static ti_CaptureComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return ti_CaptureComponent.GetRootAsti_CaptureComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    ti_CaptureComponent.Finishti_CaptureComponentBuffer(fbb, ti_CaptureComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
