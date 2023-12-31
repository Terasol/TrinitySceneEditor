// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct trinity_ParticleComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static trinity_ParticleComponent GetRootAstrinity_ParticleComponent(ByteBuffer _bb) { return GetRootAstrinity_ParticleComponent(_bb, new trinity_ParticleComponent()); }
  public static trinity_ParticleComponent GetRootAstrinity_ParticleComponent(ByteBuffer _bb, trinity_ParticleComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public trinity_ParticleComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string FilePath { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFilePathBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetFilePathBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetFilePathArray() { return __p.__vector_as_array<byte>(4); }
  public string Unk1 { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUnk1Bytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetUnk1Bytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetUnk1Array() { return __p.__vector_as_array<byte>(6); }
  public bool Unk2 { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string ParticleName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetParticleNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetParticleNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetParticleNameArray() { return __p.__vector_as_array<byte>(10); }
  public string ParticleParent { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetParticleParentBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetParticleParentBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetParticleParentArray() { return __p.__vector_as_array<byte>(12); }
  public bool Unk5 { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool Unk6 { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool Unk7 { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public uint Unk8 { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint Unk9 { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public float Unk10 { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool Unk11 { get { int o = __p.__offset(26); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)true; } }

  public static Offset<Titan.TrinityScene.trinity_ParticleComponent> Createtrinity_ParticleComponent(FlatBufferBuilder builder,
      StringOffset file_pathOffset = default(StringOffset),
      StringOffset unk_1Offset = default(StringOffset),
      bool unk_2 = false,
      StringOffset particle_nameOffset = default(StringOffset),
      StringOffset particle_parentOffset = default(StringOffset),
      bool unk_5 = false,
      bool unk_6 = false,
      bool unk_7 = false,
      uint unk_8 = 0,
      uint unk_9 = 0,
      float unk_10 = 0.0f,
      bool unk_11 = true) {
    builder.StartTable(12);
    trinity_ParticleComponent.AddUnk10(builder, unk_10);
    trinity_ParticleComponent.AddUnk9(builder, unk_9);
    trinity_ParticleComponent.AddUnk8(builder, unk_8);
    trinity_ParticleComponent.AddParticleParent(builder, particle_parentOffset);
    trinity_ParticleComponent.AddParticleName(builder, particle_nameOffset);
    trinity_ParticleComponent.AddUnk1(builder, unk_1Offset);
    trinity_ParticleComponent.AddFilePath(builder, file_pathOffset);
    trinity_ParticleComponent.AddUnk11(builder, unk_11);
    trinity_ParticleComponent.AddUnk7(builder, unk_7);
    trinity_ParticleComponent.AddUnk6(builder, unk_6);
    trinity_ParticleComponent.AddUnk5(builder, unk_5);
    trinity_ParticleComponent.AddUnk2(builder, unk_2);
    return trinity_ParticleComponent.Endtrinity_ParticleComponent(builder);
  }

  public static void Starttrinity_ParticleComponent(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddFilePath(FlatBufferBuilder builder, StringOffset filePathOffset) { builder.AddOffset(0, filePathOffset.Value, 0); }
  public static void AddUnk1(FlatBufferBuilder builder, StringOffset unk1Offset) { builder.AddOffset(1, unk1Offset.Value, 0); }
  public static void AddUnk2(FlatBufferBuilder builder, bool unk2) { builder.AddBool(2, unk2, false); }
  public static void AddParticleName(FlatBufferBuilder builder, StringOffset particleNameOffset) { builder.AddOffset(3, particleNameOffset.Value, 0); }
  public static void AddParticleParent(FlatBufferBuilder builder, StringOffset particleParentOffset) { builder.AddOffset(4, particleParentOffset.Value, 0); }
  public static void AddUnk5(FlatBufferBuilder builder, bool unk5) { builder.AddBool(5, unk5, false); }
  public static void AddUnk6(FlatBufferBuilder builder, bool unk6) { builder.AddBool(6, unk6, false); }
  public static void AddUnk7(FlatBufferBuilder builder, bool unk7) { builder.AddBool(7, unk7, false); }
  public static void AddUnk8(FlatBufferBuilder builder, uint unk8) { builder.AddUint(8, unk8, 0); }
  public static void AddUnk9(FlatBufferBuilder builder, uint unk9) { builder.AddUint(9, unk9, 0); }
  public static void AddUnk10(FlatBufferBuilder builder, float unk10) { builder.AddFloat(10, unk10, 0.0f); }
  public static void AddUnk11(FlatBufferBuilder builder, bool unk11) { builder.AddBool(11, unk11, true); }
  public static Offset<Titan.TrinityScene.trinity_ParticleComponent> Endtrinity_ParticleComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.trinity_ParticleComponent>(o);
  }
  public static void Finishtrinity_ParticleComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_ParticleComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedtrinity_ParticleComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_ParticleComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public trinity_ParticleComponentT UnPack() {
    var _o = new trinity_ParticleComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(trinity_ParticleComponentT _o) {
    _o.FilePath = this.FilePath;
    _o.Unk1 = this.Unk1;
    _o.Unk2 = this.Unk2;
    _o.ParticleName = this.ParticleName;
    _o.ParticleParent = this.ParticleParent;
    _o.Unk5 = this.Unk5;
    _o.Unk6 = this.Unk6;
    _o.Unk7 = this.Unk7;
    _o.Unk8 = this.Unk8;
    _o.Unk9 = this.Unk9;
    _o.Unk10 = this.Unk10;
    _o.Unk11 = this.Unk11;
  }
  public static Offset<Titan.TrinityScene.trinity_ParticleComponent> Pack(FlatBufferBuilder builder, trinity_ParticleComponentT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.trinity_ParticleComponent>);
    var _file_path = _o.FilePath == null ? default(StringOffset) : builder.CreateString(_o.FilePath);
    var _unk_1 = _o.Unk1 == null ? default(StringOffset) : builder.CreateString(_o.Unk1);
    var _particle_name = _o.ParticleName == null ? default(StringOffset) : builder.CreateString(_o.ParticleName);
    var _particle_parent = _o.ParticleParent == null ? default(StringOffset) : builder.CreateString(_o.ParticleParent);
    return Createtrinity_ParticleComponent(
      builder,
      _file_path,
      _unk_1,
      _o.Unk2,
      _particle_name,
      _particle_parent,
      _o.Unk5,
      _o.Unk6,
      _o.Unk7,
      _o.Unk8,
      _o.Unk9,
      _o.Unk10,
      _o.Unk11);
  }
}

public class trinity_ParticleComponentT
{
  public string FilePath { get; set; }
  public string Unk1 { get; set; }
  public bool Unk2 { get; set; }
  public string ParticleName { get; set; }
  public string ParticleParent { get; set; }
  public bool Unk5 { get; set; }
  public bool Unk6 { get; set; }
  public bool Unk7 { get; set; }
  public uint Unk8 { get; set; }
  public uint Unk9 { get; set; }
  public float Unk10 { get; set; }
  public bool Unk11 { get; set; }

  public trinity_ParticleComponentT() {
    this.FilePath = null;
    this.Unk1 = null;
    this.Unk2 = false;
    this.ParticleName = null;
    this.ParticleParent = null;
    this.Unk5 = false;
    this.Unk6 = false;
    this.Unk7 = false;
    this.Unk8 = 0;
    this.Unk9 = 0;
    this.Unk10 = 0.0f;
    this.Unk11 = true;
  }
  public static trinity_ParticleComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return trinity_ParticleComponent.GetRootAstrinity_ParticleComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    trinity_ParticleComponent.Finishtrinity_ParticleComponentBuffer(fbb, trinity_ParticleComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
