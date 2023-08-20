// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.FileSystem
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TRPFS : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static TRPFS GetRootAsTRPFS(ByteBuffer _bb) { return GetRootAsTRPFS(_bb, new TRPFS()); }
  public static TRPFS GetRootAsTRPFS(ByteBuffer _bb, TRPFS obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TRPFS __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ulong FileHashes(int j) { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUlong(__p.__vector(o) + j * 8) : (ulong)0; }
  public int FileHashesLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<ulong> GetFileHashesBytes() { return __p.__vector_as_span<ulong>(4, 8); }
#else
  public ArraySegment<byte>? GetFileHashesBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public ulong[] GetFileHashesArray() { return __p.__vector_as_array<ulong>(4); }
  public ulong FileOffsets(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUlong(__p.__vector(o) + j * 8) : (ulong)0; }
  public int FileOffsetsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<ulong> GetFileOffsetsBytes() { return __p.__vector_as_span<ulong>(6, 8); }
#else
  public ArraySegment<byte>? GetFileOffsetsBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public ulong[] GetFileOffsetsArray() { return __p.__vector_as_array<ulong>(6); }

  public static Offset<Titan.FileSystem.TRPFS> CreateTRPFS(FlatBufferBuilder builder,
      VectorOffset file_hashesOffset = default(VectorOffset),
      VectorOffset file_offsetsOffset = default(VectorOffset)) {
    builder.StartTable(2);
    TRPFS.AddFileOffsets(builder, file_offsetsOffset);
    TRPFS.AddFileHashes(builder, file_hashesOffset);
    return TRPFS.EndTRPFS(builder);
  }

  public static void StartTRPFS(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddFileHashes(FlatBufferBuilder builder, VectorOffset fileHashesOffset) { builder.AddOffset(0, fileHashesOffset.Value, 0); }
  public static VectorOffset CreateFileHashesVector(FlatBufferBuilder builder, ulong[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddUlong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateFileHashesVectorBlock(FlatBufferBuilder builder, ulong[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFileHashesVectorBlock(FlatBufferBuilder builder, ArraySegment<ulong> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFileHashesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<ulong>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartFileHashesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddFileOffsets(FlatBufferBuilder builder, VectorOffset fileOffsetsOffset) { builder.AddOffset(1, fileOffsetsOffset.Value, 0); }
  public static VectorOffset CreateFileOffsetsVector(FlatBufferBuilder builder, ulong[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddUlong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateFileOffsetsVectorBlock(FlatBufferBuilder builder, ulong[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFileOffsetsVectorBlock(FlatBufferBuilder builder, ArraySegment<ulong> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFileOffsetsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<ulong>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartFileOffsetsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<Titan.FileSystem.TRPFS> EndTRPFS(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.FileSystem.TRPFS>(o);
  }
  public static void FinishTRPFSBuffer(FlatBufferBuilder builder, Offset<Titan.FileSystem.TRPFS> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedTRPFSBuffer(FlatBufferBuilder builder, Offset<Titan.FileSystem.TRPFS> offset) { builder.FinishSizePrefixed(offset.Value); }
  public TRPFST UnPack() {
    var _o = new TRPFST();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TRPFST _o) {
    _o.FileHashes = new List<ulong>();
    for (var _j = 0; _j < this.FileHashesLength; ++_j) {_o.FileHashes.Add(this.FileHashes(_j));}
    _o.FileOffsets = new List<ulong>();
    for (var _j = 0; _j < this.FileOffsetsLength; ++_j) {_o.FileOffsets.Add(this.FileOffsets(_j));}
  }
  public static Offset<Titan.FileSystem.TRPFS> Pack(FlatBufferBuilder builder, TRPFST _o) {
    if (_o == null) return default(Offset<Titan.FileSystem.TRPFS>);
    var _file_hashes = default(VectorOffset);
    if (_o.FileHashes != null) {
      var __file_hashes = _o.FileHashes.ToArray();
      _file_hashes = CreateFileHashesVector(builder, __file_hashes);
    }
    var _file_offsets = default(VectorOffset);
    if (_o.FileOffsets != null) {
      var __file_offsets = _o.FileOffsets.ToArray();
      _file_offsets = CreateFileOffsetsVector(builder, __file_offsets);
    }
    return CreateTRPFS(
      builder,
      _file_hashes,
      _file_offsets);
  }
}

public class TRPFST
{
  public List<ulong> FileHashes { get; set; }
  public List<ulong> FileOffsets { get; set; }

  public TRPFST() {
    this.FileHashes = null;
    this.FileOffsets = null;
  }
  public static TRPFST DeserializeFromBinary(byte[] fbBuffer) {
    return TRPFS.GetRootAsTRPFS(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    TRPFS.FinishTRPFSBuffer(fbb, TRPFS.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}