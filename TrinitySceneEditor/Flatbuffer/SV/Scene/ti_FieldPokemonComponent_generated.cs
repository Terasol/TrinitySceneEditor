// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ti_FieldPokemonComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ti_FieldPokemonComponent GetRootAsti_FieldPokemonComponent(ByteBuffer _bb) { return GetRootAsti_FieldPokemonComponent(_bb, new ti_FieldPokemonComponent()); }
  public static ti_FieldPokemonComponent GetRootAsti_FieldPokemonComponent(ByteBuffer _bb, ti_FieldPokemonComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ti_FieldPokemonComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint NationalDexId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint Res1 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint Res2 { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint Res3 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint Res4 { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<Titan.TrinityScene.ti_FieldPokemonComponent> Createti_FieldPokemonComponent(FlatBufferBuilder builder,
      uint national_dex_id = 0,
      uint res_1 = 0,
      uint res_2 = 0,
      uint res_3 = 0,
      uint res_4 = 0) {
    builder.StartTable(5);
    ti_FieldPokemonComponent.AddRes4(builder, res_4);
    ti_FieldPokemonComponent.AddRes3(builder, res_3);
    ti_FieldPokemonComponent.AddRes2(builder, res_2);
    ti_FieldPokemonComponent.AddRes1(builder, res_1);
    ti_FieldPokemonComponent.AddNationalDexId(builder, national_dex_id);
    return ti_FieldPokemonComponent.Endti_FieldPokemonComponent(builder);
  }

  public static void Startti_FieldPokemonComponent(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddNationalDexId(FlatBufferBuilder builder, uint nationalDexId) { builder.AddUint(0, nationalDexId, 0); }
  public static void AddRes1(FlatBufferBuilder builder, uint res1) { builder.AddUint(1, res1, 0); }
  public static void AddRes2(FlatBufferBuilder builder, uint res2) { builder.AddUint(2, res2, 0); }
  public static void AddRes3(FlatBufferBuilder builder, uint res3) { builder.AddUint(3, res3, 0); }
  public static void AddRes4(FlatBufferBuilder builder, uint res4) { builder.AddUint(4, res4, 0); }
  public static Offset<Titan.TrinityScene.ti_FieldPokemonComponent> Endti_FieldPokemonComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.ti_FieldPokemonComponent>(o);
  }
  public static void Finishti_FieldPokemonComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.ti_FieldPokemonComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedti_FieldPokemonComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.ti_FieldPokemonComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public ti_FieldPokemonComponentT UnPack() {
    var _o = new ti_FieldPokemonComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ti_FieldPokemonComponentT _o) {
    _o.NationalDexId = this.NationalDexId;
    _o.Res1 = this.Res1;
    _o.Res2 = this.Res2;
    _o.Res3 = this.Res3;
    _o.Res4 = this.Res4;
  }
  public static Offset<Titan.TrinityScene.ti_FieldPokemonComponent> Pack(FlatBufferBuilder builder, ti_FieldPokemonComponentT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.ti_FieldPokemonComponent>);
    return Createti_FieldPokemonComponent(
      builder,
      _o.NationalDexId,
      _o.Res1,
      _o.Res2,
      _o.Res3,
      _o.Res4);
  }
}

public class ti_FieldPokemonComponentT
{
  public uint NationalDexId { get; set; }
  public uint Res1 { get; set; }
  public uint Res2 { get; set; }
  public uint Res3 { get; set; }
  public uint Res4 { get; set; }

  public ti_FieldPokemonComponentT() {
    this.NationalDexId = 0;
    this.Res1 = 0;
    this.Res2 = 0;
    this.Res3 = 0;
    this.Res4 = 0;
  }
  public static ti_FieldPokemonComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return ti_FieldPokemonComponent.GetRootAsti_FieldPokemonComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    ti_FieldPokemonComponent.Finishti_FieldPokemonComponentBuffer(fbb, ti_FieldPokemonComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
