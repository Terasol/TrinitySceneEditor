// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct trinity_LightDirectApplierComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static trinity_LightDirectApplierComponent GetRootAstrinity_LightDirectApplierComponent(ByteBuffer _bb) { return GetRootAstrinity_LightDirectApplierComponent(_bb, new trinity_LightDirectApplierComponent()); }
  public static trinity_LightDirectApplierComponent GetRootAstrinity_LightDirectApplierComponent(ByteBuffer _bb, trinity_LightDirectApplierComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public trinity_LightDirectApplierComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Unk0 { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<Titan.TrinityScene.trinity_LightDirectApplierComponent> Createtrinity_LightDirectApplierComponent(FlatBufferBuilder builder,
      uint unk_0 = 0) {
    builder.StartTable(1);
    trinity_LightDirectApplierComponent.AddUnk0(builder, unk_0);
    return trinity_LightDirectApplierComponent.Endtrinity_LightDirectApplierComponent(builder);
  }

  public static void Starttrinity_LightDirectApplierComponent(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddUnk0(FlatBufferBuilder builder, uint unk0) { builder.AddUint(0, unk0, 0); }
  public static Offset<Titan.TrinityScene.trinity_LightDirectApplierComponent> Endtrinity_LightDirectApplierComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.trinity_LightDirectApplierComponent>(o);
  }
  public static void Finishtrinity_LightDirectApplierComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_LightDirectApplierComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedtrinity_LightDirectApplierComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_LightDirectApplierComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public trinity_LightDirectApplierComponentT UnPack() {
    var _o = new trinity_LightDirectApplierComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(trinity_LightDirectApplierComponentT _o) {
    _o.Unk0 = this.Unk0;
  }
  public static Offset<Titan.TrinityScene.trinity_LightDirectApplierComponent> Pack(FlatBufferBuilder builder, trinity_LightDirectApplierComponentT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.trinity_LightDirectApplierComponent>);
    return Createtrinity_LightDirectApplierComponent(
      builder,
      _o.Unk0);
  }
}

public class trinity_LightDirectApplierComponentT
{
  public uint Unk0 { get; set; }

  public trinity_LightDirectApplierComponentT() {
    this.Unk0 = 0;
  }
  public static trinity_LightDirectApplierComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return trinity_LightDirectApplierComponent.GetRootAstrinity_LightDirectApplierComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    trinity_LightDirectApplierComponent.Finishtrinity_LightDirectApplierComponentBuffer(fbb, trinity_LightDirectApplierComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
