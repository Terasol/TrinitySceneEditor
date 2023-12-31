// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct trinity_NavmeshComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static trinity_NavmeshComponent GetRootAstrinity_NavmeshComponent(ByteBuffer _bb) { return GetRootAstrinity_NavmeshComponent(_bb, new trinity_NavmeshComponent()); }
  public static trinity_NavmeshComponent GetRootAstrinity_NavmeshComponent(ByteBuffer _bb, trinity_NavmeshComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public trinity_NavmeshComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string NavmeshFilePath { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNavmeshFilePathBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNavmeshFilePathBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNavmeshFilePathArray() { return __p.__vector_as_array<byte>(4); }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public bool Unk2 { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float Unk3 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<Titan.TrinityScene.trinity_NavmeshComponent> Createtrinity_NavmeshComponent(FlatBufferBuilder builder,
      StringOffset navmesh_file_pathOffset = default(StringOffset),
      StringOffset nameOffset = default(StringOffset),
      bool unk_2 = false,
      float unk_3 = 0.0f) {
    builder.StartTable(4);
    trinity_NavmeshComponent.AddUnk3(builder, unk_3);
    trinity_NavmeshComponent.AddName(builder, nameOffset);
    trinity_NavmeshComponent.AddNavmeshFilePath(builder, navmesh_file_pathOffset);
    trinity_NavmeshComponent.AddUnk2(builder, unk_2);
    return trinity_NavmeshComponent.Endtrinity_NavmeshComponent(builder);
  }

  public static void Starttrinity_NavmeshComponent(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddNavmeshFilePath(FlatBufferBuilder builder, StringOffset navmeshFilePathOffset) { builder.AddOffset(0, navmeshFilePathOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddUnk2(FlatBufferBuilder builder, bool unk2) { builder.AddBool(2, unk2, false); }
  public static void AddUnk3(FlatBufferBuilder builder, float unk3) { builder.AddFloat(3, unk3, 0.0f); }
  public static Offset<Titan.TrinityScene.trinity_NavmeshComponent> Endtrinity_NavmeshComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.trinity_NavmeshComponent>(o);
  }
  public static void Finishtrinity_NavmeshComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_NavmeshComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedtrinity_NavmeshComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_NavmeshComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public trinity_NavmeshComponentT UnPack() {
    var _o = new trinity_NavmeshComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(trinity_NavmeshComponentT _o) {
    _o.NavmeshFilePath = this.NavmeshFilePath;
    _o.Name = this.Name;
    _o.Unk2 = this.Unk2;
    _o.Unk3 = this.Unk3;
  }
  public static Offset<Titan.TrinityScene.trinity_NavmeshComponent> Pack(FlatBufferBuilder builder, trinity_NavmeshComponentT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.trinity_NavmeshComponent>);
    var _navmesh_file_path = _o.NavmeshFilePath == null ? default(StringOffset) : builder.CreateString(_o.NavmeshFilePath);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    return Createtrinity_NavmeshComponent(
      builder,
      _navmesh_file_path,
      _name,
      _o.Unk2,
      _o.Unk3);
  }
}

public class trinity_NavmeshComponentT
{
  public string NavmeshFilePath { get; set; }
  public string Name { get; set; }
  public bool Unk2 { get; set; }
  public float Unk3 { get; set; }

  public trinity_NavmeshComponentT() {
    this.NavmeshFilePath = null;
    this.Name = null;
    this.Unk2 = false;
    this.Unk3 = 0.0f;
  }
  public static trinity_NavmeshComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return trinity_NavmeshComponent.GetRootAstrinity_NavmeshComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    trinity_NavmeshComponent.Finishtrinity_NavmeshComponentBuffer(fbb, trinity_NavmeshComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
