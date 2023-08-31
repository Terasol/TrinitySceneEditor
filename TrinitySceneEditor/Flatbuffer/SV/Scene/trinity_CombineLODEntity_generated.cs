// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LODEntity : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static LODEntity GetRootAsLODEntity(ByteBuffer _bb) { return GetRootAsLODEntity(_bb, new LODEntity()); }
  public static LODEntity GetRootAsLODEntity(ByteBuffer _bb, LODEntity obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LODEntity __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string TrmdlFilePath { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTrmdlFilePathBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetTrmdlFilePathBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetTrmdlFilePathArray() { return __p.__vector_as_array<byte>(4); }
  public string TracnFilePath { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTracnFilePathBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetTracnFilePathBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetTracnFilePathArray() { return __p.__vector_as_array<byte>(6); }
  public string Hash { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetHashBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetHashBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetHashArray() { return __p.__vector_as_array<byte>(8); }

  public static Offset<Titan.TrinityScene.LODEntity> CreateLODEntity(FlatBufferBuilder builder,
      StringOffset trmdl_file_pathOffset = default(StringOffset),
      StringOffset tracn_file_pathOffset = default(StringOffset),
      StringOffset hashOffset = default(StringOffset)) {
    builder.StartTable(3);
    LODEntity.AddHash(builder, hashOffset);
    LODEntity.AddTracnFilePath(builder, tracn_file_pathOffset);
    LODEntity.AddTrmdlFilePath(builder, trmdl_file_pathOffset);
    return LODEntity.EndLODEntity(builder);
  }

  public static void StartLODEntity(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddTrmdlFilePath(FlatBufferBuilder builder, StringOffset trmdlFilePathOffset) { builder.AddOffset(0, trmdlFilePathOffset.Value, 0); }
  public static void AddTracnFilePath(FlatBufferBuilder builder, StringOffset tracnFilePathOffset) { builder.AddOffset(1, tracnFilePathOffset.Value, 0); }
  public static void AddHash(FlatBufferBuilder builder, StringOffset hashOffset) { builder.AddOffset(2, hashOffset.Value, 0); }
  public static Offset<Titan.TrinityScene.LODEntity> EndLODEntity(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.LODEntity>(o);
  }
  public LODEntityT UnPack() {
    var _o = new LODEntityT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LODEntityT _o) {
    _o.TrmdlFilePath = this.TrmdlFilePath;
    _o.TracnFilePath = this.TracnFilePath;
    _o.Hash = this.Hash;
  }
  public static Offset<Titan.TrinityScene.LODEntity> Pack(FlatBufferBuilder builder, LODEntityT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.LODEntity>);
    var _trmdl_file_path = _o.TrmdlFilePath == null ? default(StringOffset) : builder.CreateString(_o.TrmdlFilePath);
    var _tracn_file_path = _o.TracnFilePath == null ? default(StringOffset) : builder.CreateString(_o.TracnFilePath);
    var _hash = _o.Hash == null ? default(StringOffset) : builder.CreateString(_o.Hash);
    return CreateLODEntity(
      builder,
      _trmdl_file_path,
      _tracn_file_path,
      _hash);
  }
}

public class LODEntityT
{
  public string TrmdlFilePath { get; set; }
  public string TracnFilePath { get; set; }
  public string Hash { get; set; }

  public LODEntityT() {
    this.TrmdlFilePath = null;
    this.TracnFilePath = null;
    this.Hash = null;
  }
}

public struct trinity_CombineLODEntity : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static trinity_CombineLODEntity GetRootAstrinity_CombineLODEntity(ByteBuffer _bb) { return GetRootAstrinity_CombineLODEntity(_bb, new trinity_CombineLODEntity()); }
  public static trinity_CombineLODEntity GetRootAstrinity_CombineLODEntity(ByteBuffer _bb, trinity_CombineLODEntity obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public trinity_CombineLODEntity __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Unk0 { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUnk0Bytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetUnk0Bytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetUnk0Array() { return __p.__vector_as_array<byte>(4); }
  public uint Unk1 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string Unk2(int j) { int o = __p.__offset(8); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int Unk2Length { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
  public Vec3f? Unk3 { get { int o = __p.__offset(10); return o != 0 ? (Vec3f?)(new Vec3f()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public float Unk4 { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk5 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public uint Unk6 { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint Unk7 { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public Titan.TrinityScene.LODEntity? Unk8(int j) { int o = __p.__offset(20); return o != 0 ? (Titan.TrinityScene.LODEntity?)(new Titan.TrinityScene.LODEntity()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int Unk8Length { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<Titan.TrinityScene.trinity_CombineLODEntity> Createtrinity_CombineLODEntity(FlatBufferBuilder builder,
      StringOffset unk_0Offset = default(StringOffset),
      uint unk_1 = 0,
      VectorOffset unk_2Offset = default(VectorOffset),
      Vec3fT unk_3 = null,
      float unk_4 = 0.0f,
      float unk_5 = 0.0f,
      uint unk_6 = 0,
      uint unk_7 = 0,
      VectorOffset unk_8Offset = default(VectorOffset)) {
    builder.StartTable(9);
    trinity_CombineLODEntity.AddUnk8(builder, unk_8Offset);
    trinity_CombineLODEntity.AddUnk7(builder, unk_7);
    trinity_CombineLODEntity.AddUnk6(builder, unk_6);
    trinity_CombineLODEntity.AddUnk5(builder, unk_5);
    trinity_CombineLODEntity.AddUnk4(builder, unk_4);
    trinity_CombineLODEntity.AddUnk3(builder, Vec3f.Pack(builder, unk_3));
    trinity_CombineLODEntity.AddUnk2(builder, unk_2Offset);
    trinity_CombineLODEntity.AddUnk1(builder, unk_1);
    trinity_CombineLODEntity.AddUnk0(builder, unk_0Offset);
    return trinity_CombineLODEntity.Endtrinity_CombineLODEntity(builder);
  }

  public static void Starttrinity_CombineLODEntity(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddUnk0(FlatBufferBuilder builder, StringOffset unk0Offset) { builder.AddOffset(0, unk0Offset.Value, 0); }
  public static void AddUnk1(FlatBufferBuilder builder, uint unk1) { builder.AddUint(1, unk1, 0); }
  public static void AddUnk2(FlatBufferBuilder builder, VectorOffset unk2Offset) { builder.AddOffset(2, unk2Offset.Value, 0); }
  public static VectorOffset CreateUnk2Vector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateUnk2VectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk2VectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnk2Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnk3(FlatBufferBuilder builder, Offset<Vec3f> unk3Offset) { builder.AddStruct(3, unk3Offset.Value, 0); }
  public static void AddUnk4(FlatBufferBuilder builder, float unk4) { builder.AddFloat(4, unk4, 0.0f); }
  public static void AddUnk5(FlatBufferBuilder builder, float unk5) { builder.AddFloat(5, unk5, 0.0f); }
  public static void AddUnk6(FlatBufferBuilder builder, uint unk6) { builder.AddUint(6, unk6, 0); }
  public static void AddUnk7(FlatBufferBuilder builder, uint unk7) { builder.AddUint(7, unk7, 0); }
  public static void AddUnk8(FlatBufferBuilder builder, VectorOffset unk8Offset) { builder.AddOffset(8, unk8Offset.Value, 0); }
  public static VectorOffset CreateUnk8Vector(FlatBufferBuilder builder, Offset<Titan.TrinityScene.LODEntity>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateUnk8VectorBlock(FlatBufferBuilder builder, Offset<Titan.TrinityScene.LODEntity>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk8VectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Titan.TrinityScene.LODEntity>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk8VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<Titan.TrinityScene.LODEntity>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnk8Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<Titan.TrinityScene.trinity_CombineLODEntity> Endtrinity_CombineLODEntity(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.trinity_CombineLODEntity>(o);
  }
  public static void Finishtrinity_CombineLODEntityBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_CombineLODEntity> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedtrinity_CombineLODEntityBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_CombineLODEntity> offset) { builder.FinishSizePrefixed(offset.Value); }
  public trinity_CombineLODEntityT UnPack() {
    var _o = new trinity_CombineLODEntityT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(trinity_CombineLODEntityT _o) {
    _o.Unk0 = this.Unk0;
    _o.Unk1 = this.Unk1;
    _o.Unk2 = new List<string>();
    for (var _j = 0; _j < this.Unk2Length; ++_j) {_o.Unk2.Add(this.Unk2(_j));}
    _o.Unk3 = this.Unk3.HasValue ? this.Unk3.Value.UnPack() : null;
    _o.Unk4 = this.Unk4;
    _o.Unk5 = this.Unk5;
    _o.Unk6 = this.Unk6;
    _o.Unk7 = this.Unk7;
    _o.Unk8 = new List<Titan.TrinityScene.LODEntityT>();
    for (var _j = 0; _j < this.Unk8Length; ++_j) {_o.Unk8.Add(this.Unk8(_j).HasValue ? this.Unk8(_j).Value.UnPack() : null);}
  }
  public static Offset<Titan.TrinityScene.trinity_CombineLODEntity> Pack(FlatBufferBuilder builder, trinity_CombineLODEntityT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.trinity_CombineLODEntity>);
    var _unk_0 = _o.Unk0 == null ? default(StringOffset) : builder.CreateString(_o.Unk0);
    var _unk_2 = default(VectorOffset);
    if (_o.Unk2 != null) {
      var __unk_2 = new StringOffset[_o.Unk2.Count];
      for (var _j = 0; _j < __unk_2.Length; ++_j) { __unk_2[_j] = builder.CreateString(_o.Unk2[_j]); }
      _unk_2 = CreateUnk2Vector(builder, __unk_2);
    }
    var _unk_8 = default(VectorOffset);
    if (_o.Unk8 != null) {
      var __unk_8 = new Offset<Titan.TrinityScene.LODEntity>[_o.Unk8.Count];
      for (var _j = 0; _j < __unk_8.Length; ++_j) { __unk_8[_j] = Titan.TrinityScene.LODEntity.Pack(builder, _o.Unk8[_j]); }
      _unk_8 = CreateUnk8Vector(builder, __unk_8);
    }
    return Createtrinity_CombineLODEntity(
      builder,
      _unk_0,
      _o.Unk1,
      _unk_2,
      _o.Unk3,
      _o.Unk4,
      _o.Unk5,
      _o.Unk6,
      _o.Unk7,
      _unk_8);
  }
}

public class trinity_CombineLODEntityT
{
  public string Unk0 { get; set; }
  public uint Unk1 { get; set; }
  public List<string> Unk2 { get; set; }
  public Vec3fT Unk3 { get; set; }
  public float Unk4 { get; set; }
  public float Unk5 { get; set; }
  public uint Unk6 { get; set; }
  public uint Unk7 { get; set; }
  public List<Titan.TrinityScene.LODEntityT> Unk8 { get; set; }

  public trinity_CombineLODEntityT() {
    this.Unk0 = null;
    this.Unk1 = 0;
    this.Unk2 = null;
    this.Unk3 = new Vec3fT();
    this.Unk4 = 0.0f;
    this.Unk5 = 0.0f;
    this.Unk6 = 0;
    this.Unk7 = 0;
    this.Unk8 = null;
  }
  public static trinity_CombineLODEntityT DeserializeFromBinary(byte[] fbBuffer) {
    return trinity_CombineLODEntity.GetRootAstrinity_CombineLODEntity(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    trinity_CombineLODEntity.Finishtrinity_CombineLODEntityBuffer(fbb, trinity_CombineLODEntity.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
