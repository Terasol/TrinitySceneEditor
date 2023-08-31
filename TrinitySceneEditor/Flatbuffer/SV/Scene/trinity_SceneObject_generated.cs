// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct unknown_sceneObject_data : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static unknown_sceneObject_data GetRootAsunknown_sceneObject_data(ByteBuffer _bb) { return GetRootAsunknown_sceneObject_data(_bb, new unknown_sceneObject_data()); }
  public static unknown_sceneObject_data GetRootAsunknown_sceneObject_data(ByteBuffer _bb, unknown_sceneObject_data obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public unknown_sceneObject_data __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Vec3f? Unk1 { get { int o = __p.__offset(4); return o != 0 ? (Vec3f?)(new Vec3f()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public float Unk2 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<Titan.TrinityScene.unknown_sceneObject_data> Createunknown_sceneObject_data(FlatBufferBuilder builder,
      Vec3fT unk1 = null,
      float unk2 = 0.0f) {
    builder.StartTable(2);
    unknown_sceneObject_data.AddUnk2(builder, unk2);
    unknown_sceneObject_data.AddUnk1(builder, Vec3f.Pack(builder, unk1));
    return unknown_sceneObject_data.Endunknown_sceneObject_data(builder);
  }

  public static void Startunknown_sceneObject_data(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddUnk1(FlatBufferBuilder builder, Offset<Vec3f> unk1Offset) { builder.AddStruct(0, unk1Offset.Value, 0); }
  public static void AddUnk2(FlatBufferBuilder builder, float unk2) { builder.AddFloat(1, unk2, 0.0f); }
  public static Offset<Titan.TrinityScene.unknown_sceneObject_data> Endunknown_sceneObject_data(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.unknown_sceneObject_data>(o);
  }
  public unknown_sceneObject_dataT UnPack() {
    var _o = new unknown_sceneObject_dataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(unknown_sceneObject_dataT _o) {
    _o.Unk1 = this.Unk1.HasValue ? this.Unk1.Value.UnPack() : null;
    _o.Unk2 = this.Unk2;
  }
  public static Offset<Titan.TrinityScene.unknown_sceneObject_data> Pack(FlatBufferBuilder builder, unknown_sceneObject_dataT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.unknown_sceneObject_data>);
    return Createunknown_sceneObject_data(
      builder,
      _o.Unk1,
      _o.Unk2);
  }
}

public class unknown_sceneObject_dataT
{
  public Vec3fT Unk1 { get; set; }
  public float Unk2 { get; set; }

  public unknown_sceneObject_dataT() {
    this.Unk1 = new Vec3fT();
    this.Unk2 = 0.0f;
  }
}

public struct additional_SRT_Data : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static additional_SRT_Data GetRootAsadditional_SRT_Data(ByteBuffer _bb) { return GetRootAsadditional_SRT_Data(_bb, new additional_SRT_Data()); }
  public static additional_SRT_Data GetRootAsadditional_SRT_Data(ByteBuffer _bb, additional_SRT_Data obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public additional_SRT_Data __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Unk0 { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string NameOfUsedVec3f { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameOfUsedVec3fBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameOfUsedVec3fBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameOfUsedVec3fArray() { return __p.__vector_as_array<byte>(6); }
  public SRT? Unk2 { get { int o = __p.__offset(8); return o != 0 ? (SRT?)(new SRT()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<Titan.TrinityScene.additional_SRT_Data> Createadditional_SRT_Data(FlatBufferBuilder builder,
      uint unk0 = 0,
      StringOffset name_of_used_vec3fOffset = default(StringOffset),
      Offset<SRT> unk2Offset = default(Offset<SRT>)) {
    builder.StartTable(3);
    additional_SRT_Data.AddUnk2(builder, unk2Offset);
    additional_SRT_Data.AddNameOfUsedVec3f(builder, name_of_used_vec3fOffset);
    additional_SRT_Data.AddUnk0(builder, unk0);
    return additional_SRT_Data.Endadditional_SRT_Data(builder);
  }

  public static void Startadditional_SRT_Data(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddUnk0(FlatBufferBuilder builder, uint unk0) { builder.AddUint(0, unk0, 0); }
  public static void AddNameOfUsedVec3f(FlatBufferBuilder builder, StringOffset nameOfUsedVec3fOffset) { builder.AddOffset(1, nameOfUsedVec3fOffset.Value, 0); }
  public static void AddUnk2(FlatBufferBuilder builder, Offset<SRT> unk2Offset) { builder.AddOffset(2, unk2Offset.Value, 0); }
  public static Offset<Titan.TrinityScene.additional_SRT_Data> Endadditional_SRT_Data(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.additional_SRT_Data>(o);
  }
  public additional_SRT_DataT UnPack() {
    var _o = new additional_SRT_DataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(additional_SRT_DataT _o) {
    _o.Unk0 = this.Unk0;
    _o.NameOfUsedVec3f = this.NameOfUsedVec3f;
    _o.Unk2 = this.Unk2.HasValue ? this.Unk2.Value.UnPack() : null;
  }
  public static Offset<Titan.TrinityScene.additional_SRT_Data> Pack(FlatBufferBuilder builder, additional_SRT_DataT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.additional_SRT_Data>);
    var _name_of_used_vec3f = _o.NameOfUsedVec3f == null ? default(StringOffset) : builder.CreateString(_o.NameOfUsedVec3f);
    var _unk2 = _o.Unk2 == null ? default(Offset<SRT>) : SRT.Pack(builder, _o.Unk2);
    return Createadditional_SRT_Data(
      builder,
      _o.Unk0,
      _name_of_used_vec3f,
      _unk2);
  }
}

public class additional_SRT_DataT
{
  public uint Unk0 { get; set; }
  public string NameOfUsedVec3f { get; set; }
  public SRTT Unk2 { get; set; }

  public additional_SRT_DataT() {
    this.Unk0 = 0;
    this.NameOfUsedVec3f = null;
    this.Unk2 = null;
  }
}

public struct trinity_SceneObject : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static trinity_SceneObject GetRootAstrinity_SceneObject(ByteBuffer _bb) { return GetRootAstrinity_SceneObject(_bb, new trinity_SceneObject()); }
  public static trinity_SceneObject GetRootAstrinity_SceneObject(ByteBuffer _bb, trinity_SceneObject obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public trinity_SceneObject __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public SRT? Srt { get { int o = __p.__offset(6); return o != 0 ? (SRT?)(new SRT()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public bool Unk2 { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool Unk3 { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string Unk4 { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUnk4Bytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetUnk4Bytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetUnk4Array() { return __p.__vector_as_array<byte>(12); }
  public bool Unk5 { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public uint Unk6 { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public Titan.TrinityScene.additional_SRT_Data? AdditionalSRTData(int j) { int o = __p.__offset(18); return o != 0 ? (Titan.TrinityScene.additional_SRT_Data?)(new Titan.TrinityScene.additional_SRT_Data()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int AdditionalSRTDataLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string Unk8(int j) { int o = __p.__offset(20); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int Unk8Length { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
  public Titan.TrinityScene.unknown_sceneObject_data? Unk9 { get { int o = __p.__offset(22); return o != 0 ? (Titan.TrinityScene.unknown_sceneObject_data?)(new Titan.TrinityScene.unknown_sceneObject_data()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<Titan.TrinityScene.trinity_SceneObject> Createtrinity_SceneObject(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      Offset<SRT> srtOffset = default(Offset<SRT>),
      bool unk2 = false,
      bool unk3 = false,
      StringOffset unk4Offset = default(StringOffset),
      bool unk5 = false,
      uint unk6 = 0,
      VectorOffset additionalSRTDataOffset = default(VectorOffset),
      VectorOffset unk8Offset = default(VectorOffset),
      Offset<Titan.TrinityScene.unknown_sceneObject_data> unk9Offset = default(Offset<Titan.TrinityScene.unknown_sceneObject_data>)) {
    builder.StartTable(10);
    trinity_SceneObject.AddUnk9(builder, unk9Offset);
    trinity_SceneObject.AddUnk8(builder, unk8Offset);
    trinity_SceneObject.AddAdditionalSRTData(builder, additionalSRTDataOffset);
    trinity_SceneObject.AddUnk6(builder, unk6);
    trinity_SceneObject.AddUnk4(builder, unk4Offset);
    trinity_SceneObject.AddSrt(builder, srtOffset);
    trinity_SceneObject.AddName(builder, nameOffset);
    trinity_SceneObject.AddUnk5(builder, unk5);
    trinity_SceneObject.AddUnk3(builder, unk3);
    trinity_SceneObject.AddUnk2(builder, unk2);
    return trinity_SceneObject.Endtrinity_SceneObject(builder);
  }

  public static void Starttrinity_SceneObject(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddSrt(FlatBufferBuilder builder, Offset<SRT> srtOffset) { builder.AddOffset(1, srtOffset.Value, 0); }
  public static void AddUnk2(FlatBufferBuilder builder, bool unk2) { builder.AddBool(2, unk2, false); }
  public static void AddUnk3(FlatBufferBuilder builder, bool unk3) { builder.AddBool(3, unk3, false); }
  public static void AddUnk4(FlatBufferBuilder builder, StringOffset unk4Offset) { builder.AddOffset(4, unk4Offset.Value, 0); }
  public static void AddUnk5(FlatBufferBuilder builder, bool unk5) { builder.AddBool(5, unk5, false); }
  public static void AddUnk6(FlatBufferBuilder builder, uint unk6) { builder.AddUint(6, unk6, 0); }
  public static void AddAdditionalSRTData(FlatBufferBuilder builder, VectorOffset additionalSRTDataOffset) { builder.AddOffset(7, additionalSRTDataOffset.Value, 0); }
  public static VectorOffset CreateAdditionalSRTDataVector(FlatBufferBuilder builder, Offset<Titan.TrinityScene.additional_SRT_Data>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateAdditionalSRTDataVectorBlock(FlatBufferBuilder builder, Offset<Titan.TrinityScene.additional_SRT_Data>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAdditionalSRTDataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Titan.TrinityScene.additional_SRT_Data>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAdditionalSRTDataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Titan.TrinityScene.additional_SRT_Data>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartAdditionalSRTDataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnk8(FlatBufferBuilder builder, VectorOffset unk8Offset) { builder.AddOffset(8, unk8Offset.Value, 0); }
  public static VectorOffset CreateUnk8Vector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateUnk8VectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk8VectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk8VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnk8Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnk9(FlatBufferBuilder builder, Offset<Titan.TrinityScene.unknown_sceneObject_data> unk9Offset) { builder.AddOffset(9, unk9Offset.Value, 0); }
  public static Offset<Titan.TrinityScene.trinity_SceneObject> Endtrinity_SceneObject(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.trinity_SceneObject>(o);
  }
  public static void Finishtrinity_SceneObjectBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_SceneObject> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedtrinity_SceneObjectBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_SceneObject> offset) { builder.FinishSizePrefixed(offset.Value); }
  public trinity_SceneObjectT UnPack() {
    var _o = new trinity_SceneObjectT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(trinity_SceneObjectT _o) {
    _o.Name = this.Name;
    _o.Srt = this.Srt.HasValue ? this.Srt.Value.UnPack() : null;
    _o.Unk2 = this.Unk2;
    _o.Unk3 = this.Unk3;
    _o.Unk4 = this.Unk4;
    _o.Unk5 = this.Unk5;
    _o.Unk6 = this.Unk6;
    _o.AdditionalSRTData = new List<Titan.TrinityScene.additional_SRT_DataT>();
    for (var _j = 0; _j < this.AdditionalSRTDataLength; ++_j) {_o.AdditionalSRTData.Add(this.AdditionalSRTData(_j).HasValue ? this.AdditionalSRTData(_j).Value.UnPack() : null);}
    _o.Unk8 = new List<string>();
    for (var _j = 0; _j < this.Unk8Length; ++_j) {_o.Unk8.Add(this.Unk8(_j));}
    _o.Unk9 = this.Unk9.HasValue ? this.Unk9.Value.UnPack() : null;
  }
  public static Offset<Titan.TrinityScene.trinity_SceneObject> Pack(FlatBufferBuilder builder, trinity_SceneObjectT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.trinity_SceneObject>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _srt = _o.Srt == null ? default(Offset<SRT>) : SRT.Pack(builder, _o.Srt);
    var _unk4 = _o.Unk4 == null ? default(StringOffset) : builder.CreateString(_o.Unk4);
    var _additionalSRTData = default(VectorOffset);
    if (_o.AdditionalSRTData != null) {
      var __additionalSRTData = new Offset<Titan.TrinityScene.additional_SRT_Data>[_o.AdditionalSRTData.Count];
      for (var _j = 0; _j < __additionalSRTData.Length; ++_j) { __additionalSRTData[_j] = Titan.TrinityScene.additional_SRT_Data.Pack(builder, _o.AdditionalSRTData[_j]); }
      _additionalSRTData = CreateAdditionalSRTDataVector(builder, __additionalSRTData);
    }
    var _unk8 = default(VectorOffset);
    if (_o.Unk8 != null) {
      var __unk8 = new StringOffset[_o.Unk8.Count];
      for (var _j = 0; _j < __unk8.Length; ++_j) { __unk8[_j] = builder.CreateString(_o.Unk8[_j]); }
      _unk8 = CreateUnk8Vector(builder, __unk8);
    }
    var _unk9 = _o.Unk9 == null ? default(Offset<Titan.TrinityScene.unknown_sceneObject_data>) : Titan.TrinityScene.unknown_sceneObject_data.Pack(builder, _o.Unk9);
    return Createtrinity_SceneObject(
      builder,
      _name,
      _srt,
      _o.Unk2,
      _o.Unk3,
      _unk4,
      _o.Unk5,
      _o.Unk6,
      _additionalSRTData,
      _unk8,
      _unk9);
  }
}

public class trinity_SceneObjectT
{
  public string Name { get; set; }
  public SRTT Srt { get; set; }
  public bool Unk2 { get; set; }
  public bool Unk3 { get; set; }
  public string Unk4 { get; set; }
  public bool Unk5 { get; set; }
  public uint Unk6 { get; set; }
  public List<Titan.TrinityScene.additional_SRT_DataT> AdditionalSRTData { get; set; }
  public List<string> Unk8 { get; set; }
  public Titan.TrinityScene.unknown_sceneObject_dataT Unk9 { get; set; }

  public trinity_SceneObjectT() {
    this.Name = null;
    this.Srt = null;
    this.Unk2 = false;
    this.Unk3 = false;
    this.Unk4 = null;
    this.Unk5 = false;
    this.Unk6 = 0;
    this.AdditionalSRTData = null;
    this.Unk8 = null;
    this.Unk9 = null;
  }
  public static trinity_SceneObjectT DeserializeFromBinary(byte[] fbBuffer) {
    return trinity_SceneObject.GetRootAstrinity_SceneObject(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    trinity_SceneObject.Finishtrinity_SceneObjectBuffer(fbb, trinity_SceneObject.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
