// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct trinity_GridStremingGroup : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static trinity_GridStremingGroup GetRootAstrinity_GridStremingGroup(ByteBuffer _bb) { return GetRootAstrinity_GridStremingGroup(_bb, new trinity_GridStremingGroup()); }
  public static trinity_GridStremingGroup GetRootAstrinity_GridStremingGroup(ByteBuffer _bb, trinity_GridStremingGroup obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public trinity_GridStremingGroup __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Unk0 { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUnk0Bytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetUnk0Bytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetUnk0Array() { return __p.__vector_as_array<byte>(4); }
  public bool Unk1 { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public Vec3f? Unk2 { get { int o = __p.__offset(8); return o != 0 ? (Vec3f?)(new Vec3f()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public float Unk3(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int Unk3Length { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetUnk3Bytes() { return __p.__vector_as_span<float>(10, 4); }
#else
  public ArraySegment<byte>? GetUnk3Bytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public float[] GetUnk3Array() { return __p.__vector_as_array<float>(10); }
  public ushort Unk4(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUshort(__p.__vector(o) + j * 2) : (ushort)0; }
  public int Unk4Length { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<ushort> GetUnk4Bytes() { return __p.__vector_as_span<ushort>(12, 2); }
#else
  public ArraySegment<byte>? GetUnk4Bytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public ushort[] GetUnk4Array() { return __p.__vector_as_array<ushort>(12); }
  public float Unk5 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Unk6 { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<Titan.TrinityScene.trinity_GridStremingGroup> Createtrinity_GridStremingGroup(FlatBufferBuilder builder,
      StringOffset unk_0Offset = default(StringOffset),
      bool unk_1 = false,
      Vec3fT unk_2 = null,
      VectorOffset unk_3Offset = default(VectorOffset),
      VectorOffset unk_4Offset = default(VectorOffset),
      float unk_5 = 0.0f,
      float unk_6 = 0.0f) {
    builder.StartTable(7);
    trinity_GridStremingGroup.AddUnk6(builder, unk_6);
    trinity_GridStremingGroup.AddUnk5(builder, unk_5);
    trinity_GridStremingGroup.AddUnk4(builder, unk_4Offset);
    trinity_GridStremingGroup.AddUnk3(builder, unk_3Offset);
    trinity_GridStremingGroup.AddUnk2(builder, Vec3f.Pack(builder, unk_2));
    trinity_GridStremingGroup.AddUnk0(builder, unk_0Offset);
    trinity_GridStremingGroup.AddUnk1(builder, unk_1);
    return trinity_GridStremingGroup.Endtrinity_GridStremingGroup(builder);
  }

  public static void Starttrinity_GridStremingGroup(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddUnk0(FlatBufferBuilder builder, StringOffset unk0Offset) { builder.AddOffset(0, unk0Offset.Value, 0); }
  public static void AddUnk1(FlatBufferBuilder builder, bool unk1) { builder.AddBool(1, unk1, false); }
  public static void AddUnk2(FlatBufferBuilder builder, Offset<Vec3f> unk2Offset) { builder.AddStruct(2, unk2Offset.Value, 0); }
  public static void AddUnk3(FlatBufferBuilder builder, VectorOffset unk3Offset) { builder.AddOffset(3, unk3Offset.Value, 0); }
  public static VectorOffset CreateUnk3Vector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateUnk3VectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk3VectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk3VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnk3Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnk4(FlatBufferBuilder builder, VectorOffset unk4Offset) { builder.AddOffset(4, unk4Offset.Value, 0); }
  public static VectorOffset CreateUnk4Vector(FlatBufferBuilder builder, ushort[] data) { builder.StartVector(2, data.Length, 2); for (int i = data.Length - 1; i >= 0; i--) builder.AddUshort(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateUnk4VectorBlock(FlatBufferBuilder builder, ushort[] data) { builder.StartVector(2, data.Length, 2); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk4VectorBlock(FlatBufferBuilder builder, ArraySegment<ushort> data) { builder.StartVector(2, data.Count, 2); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnk4VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<ushort>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnk4Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(2, numElems, 2); }
  public static void AddUnk5(FlatBufferBuilder builder, float unk5) { builder.AddFloat(5, unk5, 0.0f); }
  public static void AddUnk6(FlatBufferBuilder builder, float unk6) { builder.AddFloat(6, unk6, 0.0f); }
  public static Offset<Titan.TrinityScene.trinity_GridStremingGroup> Endtrinity_GridStremingGroup(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.trinity_GridStremingGroup>(o);
  }
  public static void Finishtrinity_GridStremingGroupBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_GridStremingGroup> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedtrinity_GridStremingGroupBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_GridStremingGroup> offset) { builder.FinishSizePrefixed(offset.Value); }
  public trinity_GridStremingGroupT UnPack() {
    var _o = new trinity_GridStremingGroupT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(trinity_GridStremingGroupT _o) {
    _o.Unk0 = this.Unk0;
    _o.Unk1 = this.Unk1;
    _o.Unk2 = this.Unk2.HasValue ? this.Unk2.Value.UnPack() : null;
    _o.Unk3 = new List<float>();
    for (var _j = 0; _j < this.Unk3Length; ++_j) {_o.Unk3.Add(this.Unk3(_j));}
    _o.Unk4 = new List<ushort>();
    for (var _j = 0; _j < this.Unk4Length; ++_j) {_o.Unk4.Add(this.Unk4(_j));}
    _o.Unk5 = this.Unk5;
    _o.Unk6 = this.Unk6;
  }
  public static Offset<Titan.TrinityScene.trinity_GridStremingGroup> Pack(FlatBufferBuilder builder, trinity_GridStremingGroupT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.trinity_GridStremingGroup>);
    var _unk_0 = _o.Unk0 == null ? default(StringOffset) : builder.CreateString(_o.Unk0);
    var _unk_3 = default(VectorOffset);
    if (_o.Unk3 != null) {
      var __unk_3 = _o.Unk3.ToArray();
      _unk_3 = CreateUnk3Vector(builder, __unk_3);
    }
    var _unk_4 = default(VectorOffset);
    if (_o.Unk4 != null) {
      var __unk_4 = _o.Unk4.ToArray();
      _unk_4 = CreateUnk4Vector(builder, __unk_4);
    }
    return Createtrinity_GridStremingGroup(
      builder,
      _unk_0,
      _o.Unk1,
      _o.Unk2,
      _unk_3,
      _unk_4,
      _o.Unk5,
      _o.Unk6);
  }
}

public class trinity_GridStremingGroupT
{
  public string Unk0 { get; set; }
  public bool Unk1 { get; set; }
  public Vec3fT Unk2 { get; set; }
  public List<float> Unk3 { get; set; }
  public List<ushort> Unk4 { get; set; }
  public float Unk5 { get; set; }
  public float Unk6 { get; set; }

  public trinity_GridStremingGroupT() {
    this.Unk0 = null;
    this.Unk1 = false;
    this.Unk2 = new Vec3fT();
    this.Unk3 = null;
    this.Unk4 = null;
    this.Unk5 = 0.0f;
    this.Unk6 = 0.0f;
  }
  public static trinity_GridStremingGroupT DeserializeFromBinary(byte[] fbBuffer) {
    return trinity_GridStremingGroup.GetRootAstrinity_GridStremingGroup(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    trinity_GridStremingGroup.Finishtrinity_GridStremingGroupBuffer(fbb, trinity_GridStremingGroup.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
