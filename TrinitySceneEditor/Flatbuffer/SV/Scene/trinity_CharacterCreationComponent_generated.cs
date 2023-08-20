// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct trinity_CharacterCreationComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static trinity_CharacterCreationComponent GetRootAstrinity_CharacterCreationComponent(ByteBuffer _bb) { return GetRootAstrinity_CharacterCreationComponent(_bb, new trinity_CharacterCreationComponent()); }
  public static trinity_CharacterCreationComponent GetRootAstrinity_CharacterCreationComponent(ByteBuffer _bb, trinity_CharacterCreationComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public trinity_CharacterCreationComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string FilePath { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFilePathBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetFilePathBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetFilePathArray() { return __p.__vector_as_array<byte>(4); }
  public uint FilePath2 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public bool Unk2 { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float Unk3 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk4 { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk5 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public uint Unk6 { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public float Unk7 { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public uint Unk8 { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public float Unk9 { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public uint Unk10 { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public float Unk11 { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public uint Unk12 { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public float Unk13 { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<Titan.TrinityScene.trinity_CharacterCreationComponent> Createtrinity_CharacterCreationComponent(FlatBufferBuilder builder,
      StringOffset file_pathOffset = default(StringOffset),
      uint file_path_2 = 0,
      bool unk_2 = false,
      float unk_3 = 0.0f,
      float unk_4 = 0.0f,
      float unk_5 = 0.0f,
      uint unk_6 = 0,
      float unk_7 = 0.0f,
      uint unk_8 = 0,
      float unk_9 = 0.0f,
      uint unk_10 = 0,
      float unk_11 = 0.0f,
      uint unk_12 = 0,
      float unk_13 = 0.0f) {
    builder.StartTable(14);
    trinity_CharacterCreationComponent.AddUnk13(builder, unk_13);
    trinity_CharacterCreationComponent.AddUnk12(builder, unk_12);
    trinity_CharacterCreationComponent.AddUnk11(builder, unk_11);
    trinity_CharacterCreationComponent.AddUnk10(builder, unk_10);
    trinity_CharacterCreationComponent.AddUnk9(builder, unk_9);
    trinity_CharacterCreationComponent.AddUnk8(builder, unk_8);
    trinity_CharacterCreationComponent.AddUnk7(builder, unk_7);
    trinity_CharacterCreationComponent.AddUnk6(builder, unk_6);
    trinity_CharacterCreationComponent.AddUnk5(builder, unk_5);
    trinity_CharacterCreationComponent.AddUnk4(builder, unk_4);
    trinity_CharacterCreationComponent.AddUnk3(builder, unk_3);
    trinity_CharacterCreationComponent.AddFilePath2(builder, file_path_2);
    trinity_CharacterCreationComponent.AddFilePath(builder, file_pathOffset);
    trinity_CharacterCreationComponent.AddUnk2(builder, unk_2);
    return trinity_CharacterCreationComponent.Endtrinity_CharacterCreationComponent(builder);
  }

  public static void Starttrinity_CharacterCreationComponent(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddFilePath(FlatBufferBuilder builder, StringOffset filePathOffset) { builder.AddOffset(0, filePathOffset.Value, 0); }
  public static void AddFilePath2(FlatBufferBuilder builder, uint filePath2) { builder.AddUint(1, filePath2, 0); }
  public static void AddUnk2(FlatBufferBuilder builder, bool unk2) { builder.AddBool(2, unk2, false); }
  public static void AddUnk3(FlatBufferBuilder builder, float unk3) { builder.AddFloat(3, unk3, 0.0f); }
  public static void AddUnk4(FlatBufferBuilder builder, float unk4) { builder.AddFloat(4, unk4, 0.0f); }
  public static void AddUnk5(FlatBufferBuilder builder, float unk5) { builder.AddFloat(5, unk5, 0.0f); }
  public static void AddUnk6(FlatBufferBuilder builder, uint unk6) { builder.AddUint(6, unk6, 0); }
  public static void AddUnk7(FlatBufferBuilder builder, float unk7) { builder.AddFloat(7, unk7, 0.0f); }
  public static void AddUnk8(FlatBufferBuilder builder, uint unk8) { builder.AddUint(8, unk8, 0); }
  public static void AddUnk9(FlatBufferBuilder builder, float unk9) { builder.AddFloat(9, unk9, 0.0f); }
  public static void AddUnk10(FlatBufferBuilder builder, uint unk10) { builder.AddUint(10, unk10, 0); }
  public static void AddUnk11(FlatBufferBuilder builder, float unk11) { builder.AddFloat(11, unk11, 0.0f); }
  public static void AddUnk12(FlatBufferBuilder builder, uint unk12) { builder.AddUint(12, unk12, 0); }
  public static void AddUnk13(FlatBufferBuilder builder, float unk13) { builder.AddFloat(13, unk13, 0.0f); }
  public static Offset<Titan.TrinityScene.trinity_CharacterCreationComponent> Endtrinity_CharacterCreationComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.trinity_CharacterCreationComponent>(o);
  }
  public static void Finishtrinity_CharacterCreationComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_CharacterCreationComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedtrinity_CharacterCreationComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_CharacterCreationComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public trinity_CharacterCreationComponentT UnPack() {
    var _o = new trinity_CharacterCreationComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(trinity_CharacterCreationComponentT _o) {
    _o.FilePath = this.FilePath;
    _o.FilePath2 = this.FilePath2;
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
  }
  public static Offset<Titan.TrinityScene.trinity_CharacterCreationComponent> Pack(FlatBufferBuilder builder, trinity_CharacterCreationComponentT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.trinity_CharacterCreationComponent>);
    var _file_path = _o.FilePath == null ? default(StringOffset) : builder.CreateString(_o.FilePath);
    return Createtrinity_CharacterCreationComponent(
      builder,
      _file_path,
      _o.FilePath2,
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
      _o.Unk13);
  }
}

public class trinity_CharacterCreationComponentT
{
  public string FilePath { get; set; }
  public uint FilePath2 { get; set; }
  public bool Unk2 { get; set; }
  public float Unk3 { get; set; }
  public float Unk4 { get; set; }
  public float Unk5 { get; set; }
  public uint Unk6 { get; set; }
  public float Unk7 { get; set; }
  public uint Unk8 { get; set; }
  public float Unk9 { get; set; }
  public uint Unk10 { get; set; }
  public float Unk11 { get; set; }
  public uint Unk12 { get; set; }
  public float Unk13 { get; set; }

  public trinity_CharacterCreationComponentT() {
    this.FilePath = null;
    this.FilePath2 = 0;
    this.Unk2 = false;
    this.Unk3 = 0.0f;
    this.Unk4 = 0.0f;
    this.Unk5 = 0.0f;
    this.Unk6 = 0;
    this.Unk7 = 0.0f;
    this.Unk8 = 0;
    this.Unk9 = 0.0f;
    this.Unk10 = 0;
    this.Unk11 = 0.0f;
    this.Unk12 = 0;
    this.Unk13 = 0.0f;
  }
  public static trinity_CharacterCreationComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return trinity_CharacterCreationComponent.GetRootAstrinity_CharacterCreationComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    trinity_CharacterCreationComponent.Finishtrinity_CharacterCreationComponentBuffer(fbb, trinity_CharacterCreationComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
