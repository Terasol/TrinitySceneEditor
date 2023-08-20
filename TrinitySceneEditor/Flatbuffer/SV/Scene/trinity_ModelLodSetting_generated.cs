// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ModelLoadData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static ModelLoadData GetRootAsModelLoadData(ByteBuffer _bb) { return GetRootAsModelLoadData(_bb, new ModelLoadData()); }
  public static ModelLoadData GetRootAsModelLoadData(ByteBuffer _bb, ModelLoadData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ModelLoadData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Unk0 { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUnk0Bytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetUnk0Bytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetUnk0Array() { return __p.__vector_as_array<byte>(4); }
  public float Unk1 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk2(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int Unk2Length { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetUnk2Bytes() { return __p.__vector_as_span<float>(8, 4); }
#else
  public ArraySegment<byte>? GetUnk2Bytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public float[] GetUnk2Array() { return __p.__vector_as_array<float>(8); }

  public static Offset<Titan.TrinityScene.ModelLoadData> CreateModelLoadData(FlatBufferBuilder builder,
      StringOffset unk_0Offset = default(StringOffset),
      float unk_1 = 0.0f,
      VectorOffset unk_2Offset = default(VectorOffset)) {
    builder.StartTable(3);
    ModelLoadData.AddUnk2(builder, unk_2Offset);
    ModelLoadData.AddUnk1(builder, unk_1);
    ModelLoadData.AddUnk0(builder, unk_0Offset);
    return ModelLoadData.EndModelLoadData(builder);
  }

  public static void StartModelLoadData(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddUnk0(FlatBufferBuilder builder, StringOffset unk0Offset) { builder.AddOffset(0, unk0Offset.Value, 0); }
  public static void AddUnk1(FlatBufferBuilder builder, float unk1) { builder.AddFloat(1, unk1, 0.0f); }
  public static void AddUnk2(FlatBufferBuilder builder, VectorOffset unk2Offset) { builder.AddOffset(2, unk2Offset.Value, 0); }
  public static VectorOffset CreateUnk2Vector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateUnk2VectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk2VectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnk2Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Titan.TrinityScene.ModelLoadData> EndModelLoadData(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.ModelLoadData>(o);
  }
  public ModelLoadDataT UnPack() {
    var _o = new ModelLoadDataT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ModelLoadDataT _o) {
    _o.Unk0 = this.Unk0;
    _o.Unk1 = this.Unk1;
    _o.Unk2 = new List<float>();
    for (var _j = 0; _j < this.Unk2Length; ++_j) {_o.Unk2.Add(this.Unk2(_j));}
  }
  public static Offset<Titan.TrinityScene.ModelLoadData> Pack(FlatBufferBuilder builder, ModelLoadDataT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.ModelLoadData>);
    var _unk_0 = _o.Unk0 == null ? default(StringOffset) : builder.CreateString(_o.Unk0);
    var _unk_2 = default(VectorOffset);
    if (_o.Unk2 != null) {
      var __unk_2 = _o.Unk2.ToArray();
      _unk_2 = CreateUnk2Vector(builder, __unk_2);
    }
    return CreateModelLoadData(
      builder,
      _unk_0,
      _o.Unk1,
      _unk_2);
  }
}

public class ModelLoadDataT
{
  public string Unk0 { get; set; }
  public float Unk1 { get; set; }
  public List<float> Unk2 { get; set; }

  public ModelLoadDataT() {
    this.Unk0 = null;
    this.Unk1 = 0.0f;
    this.Unk2 = null;
  }
}

public struct trinity_ModelLodSetting : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static trinity_ModelLodSetting GetRootAstrinity_ModelLodSetting(ByteBuffer _bb) { return GetRootAstrinity_ModelLodSetting(_bb, new trinity_ModelLodSetting()); }
  public static trinity_ModelLodSetting GetRootAstrinity_ModelLodSetting(ByteBuffer _bb, trinity_ModelLodSetting obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public trinity_ModelLodSetting __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Unk0 { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUnk0Bytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetUnk0Bytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetUnk0Array() { return __p.__vector_as_array<byte>(4); }
  public string Patern { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPaternBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetPaternBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetPaternArray() { return __p.__vector_as_array<byte>(6); }
  public float Unk2(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int Unk2Length { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetUnk2Bytes() { return __p.__vector_as_span<float>(8, 4); }
#else
  public ArraySegment<byte>? GetUnk2Bytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public float[] GetUnk2Array() { return __p.__vector_as_array<float>(8); }
  public Titan.TrinityScene.ModelLoadData? Unk3(int j) { int o = __p.__offset(10); return o != 0 ? (Titan.TrinityScene.ModelLoadData?)(new Titan.TrinityScene.ModelLoadData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int Unk3Length { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Titan.TrinityScene.trinity_ModelLodSetting> Createtrinity_ModelLodSetting(FlatBufferBuilder builder,
      StringOffset unk_0Offset = default(StringOffset),
      StringOffset paternOffset = default(StringOffset),
      VectorOffset unk_2Offset = default(VectorOffset),
      VectorOffset unk_3Offset = default(VectorOffset)) {
    builder.StartTable(4);
    trinity_ModelLodSetting.AddUnk3(builder, unk_3Offset);
    trinity_ModelLodSetting.AddUnk2(builder, unk_2Offset);
    trinity_ModelLodSetting.AddPatern(builder, paternOffset);
    trinity_ModelLodSetting.AddUnk0(builder, unk_0Offset);
    return trinity_ModelLodSetting.Endtrinity_ModelLodSetting(builder);
  }

  public static void Starttrinity_ModelLodSetting(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddUnk0(FlatBufferBuilder builder, StringOffset unk0Offset) { builder.AddOffset(0, unk0Offset.Value, 0); }
  public static void AddPatern(FlatBufferBuilder builder, StringOffset paternOffset) { builder.AddOffset(1, paternOffset.Value, 0); }
  public static void AddUnk2(FlatBufferBuilder builder, VectorOffset unk2Offset) { builder.AddOffset(2, unk2Offset.Value, 0); }
  public static VectorOffset CreateUnk2Vector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateUnk2VectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk2VectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnk2Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnk3(FlatBufferBuilder builder, VectorOffset unk3Offset) { builder.AddOffset(3, unk3Offset.Value, 0); }
  public static VectorOffset CreateUnk3Vector(FlatBufferBuilder builder, Offset<Titan.TrinityScene.ModelLoadData>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateUnk3VectorBlock(FlatBufferBuilder builder, Offset<Titan.TrinityScene.ModelLoadData>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk3VectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Titan.TrinityScene.ModelLoadData>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk3VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Titan.TrinityScene.ModelLoadData>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnk3Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Titan.TrinityScene.trinity_ModelLodSetting> Endtrinity_ModelLodSetting(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.trinity_ModelLodSetting>(o);
  }
  public static void Finishtrinity_ModelLodSettingBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_ModelLodSetting> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedtrinity_ModelLodSettingBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_ModelLodSetting> offset) { builder.FinishSizePrefixed(offset.Value); }
  public trinity_ModelLodSettingT UnPack() {
    var _o = new trinity_ModelLodSettingT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(trinity_ModelLodSettingT _o) {
    _o.Unk0 = this.Unk0;
    _o.Patern = this.Patern;
    _o.Unk2 = new List<float>();
    for (var _j = 0; _j < this.Unk2Length; ++_j) {_o.Unk2.Add(this.Unk2(_j));}
    _o.Unk3 = new List<Titan.TrinityScene.ModelLoadDataT>();
    for (var _j = 0; _j < this.Unk3Length; ++_j) {_o.Unk3.Add(this.Unk3(_j).HasValue ? this.Unk3(_j).Value.UnPack() : null);}
  }
  public static Offset<Titan.TrinityScene.trinity_ModelLodSetting> Pack(FlatBufferBuilder builder, trinity_ModelLodSettingT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.trinity_ModelLodSetting>);
    var _unk_0 = _o.Unk0 == null ? default(StringOffset) : builder.CreateString(_o.Unk0);
    var _patern = _o.Patern == null ? default(StringOffset) : builder.CreateString(_o.Patern);
    var _unk_2 = default(VectorOffset);
    if (_o.Unk2 != null) {
      var __unk_2 = _o.Unk2.ToArray();
      _unk_2 = CreateUnk2Vector(builder, __unk_2);
    }
    var _unk_3 = default(VectorOffset);
    if (_o.Unk3 != null) {
      var __unk_3 = new Offset<Titan.TrinityScene.ModelLoadData>[_o.Unk3.Count];
      for (var _j = 0; _j < __unk_3.Length; ++_j) { __unk_3[_j] = Titan.TrinityScene.ModelLoadData.Pack(builder, _o.Unk3[_j]); }
      _unk_3 = CreateUnk3Vector(builder, __unk_3);
    }
    return Createtrinity_ModelLodSetting(
      builder,
      _unk_0,
      _patern,
      _unk_2,
      _unk_3);
  }
}

public class trinity_ModelLodSettingT
{
  public string Unk0 { get; set; }
  public string Patern { get; set; }
  public List<float> Unk2 { get; set; }
  public List<Titan.TrinityScene.ModelLoadDataT> Unk3 { get; set; }

  public trinity_ModelLodSettingT() {
    this.Unk0 = null;
    this.Patern = null;
    this.Unk2 = null;
    this.Unk3 = null;
  }
  public static trinity_ModelLodSettingT DeserializeFromBinary(byte[] fbBuffer) {
    return trinity_ModelLodSetting.GetRootAstrinity_ModelLodSetting(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    trinity_ModelLodSetting.Finishtrinity_ModelLodSettingBuffer(fbb, trinity_ModelLodSetting.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}