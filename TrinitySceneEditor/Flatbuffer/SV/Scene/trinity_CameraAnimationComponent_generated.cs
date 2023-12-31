// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct trinity_CameraAnimationComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static trinity_CameraAnimationComponent GetRootAstrinity_CameraAnimationComponent(ByteBuffer _bb) { return GetRootAstrinity_CameraAnimationComponent(_bb, new trinity_CameraAnimationComponent()); }
  public static trinity_CameraAnimationComponent GetRootAstrinity_CameraAnimationComponent(ByteBuffer _bb, trinity_CameraAnimationComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public trinity_CameraAnimationComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public string FilePath { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFilePathBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetFilePathBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetFilePathArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<Titan.TrinityScene.trinity_CameraAnimationComponent> Createtrinity_CameraAnimationComponent(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      StringOffset file_pathOffset = default(StringOffset)) {
    builder.StartTable(2);
    trinity_CameraAnimationComponent.AddFilePath(builder, file_pathOffset);
    trinity_CameraAnimationComponent.AddName(builder, nameOffset);
    return trinity_CameraAnimationComponent.Endtrinity_CameraAnimationComponent(builder);
  }

  public static void Starttrinity_CameraAnimationComponent(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddFilePath(FlatBufferBuilder builder, StringOffset filePathOffset) { builder.AddOffset(1, filePathOffset.Value, 0); }
  public static Offset<Titan.TrinityScene.trinity_CameraAnimationComponent> Endtrinity_CameraAnimationComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.trinity_CameraAnimationComponent>(o);
  }
  public static void Finishtrinity_CameraAnimationComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_CameraAnimationComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedtrinity_CameraAnimationComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.trinity_CameraAnimationComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public trinity_CameraAnimationComponentT UnPack() {
    var _o = new trinity_CameraAnimationComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(trinity_CameraAnimationComponentT _o) {
    _o.Name = this.Name;
    _o.FilePath = this.FilePath;
  }
  public static Offset<Titan.TrinityScene.trinity_CameraAnimationComponent> Pack(FlatBufferBuilder builder, trinity_CameraAnimationComponentT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.trinity_CameraAnimationComponent>);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _file_path = _o.FilePath == null ? default(StringOffset) : builder.CreateString(_o.FilePath);
    return Createtrinity_CameraAnimationComponent(
      builder,
      _name,
      _file_path);
  }
}

public class trinity_CameraAnimationComponentT
{
  public string Name { get; set; }
  public string FilePath { get; set; }

  public trinity_CameraAnimationComponentT() {
    this.Name = null;
    this.FilePath = null;
  }
  public static trinity_CameraAnimationComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return trinity_CameraAnimationComponent.GetRootAstrinity_CameraAnimationComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    trinity_CameraAnimationComponent.Finishtrinity_CameraAnimationComponentBuffer(fbb, trinity_CameraAnimationComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
