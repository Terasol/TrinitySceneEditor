// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Titan.TrinityScene
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct pe_AudioPlayerComponent : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_3_3(); }
  public static pe_AudioPlayerComponent GetRootAspe_AudioPlayerComponent(ByteBuffer _bb) { return GetRootAspe_AudioPlayerComponent(_bb, new pe_AudioPlayerComponent()); }
  public static pe_AudioPlayerComponent GetRootAspe_AudioPlayerComponent(ByteBuffer _bb, pe_AudioPlayerComponent obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public pe_AudioPlayerComponent __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void Startpe_AudioPlayerComponent(FlatBufferBuilder builder) { builder.StartTable(0); }
  public static Offset<Titan.TrinityScene.pe_AudioPlayerComponent> Endpe_AudioPlayerComponent(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<Titan.TrinityScene.pe_AudioPlayerComponent>(o);
  }
  public static void Finishpe_AudioPlayerComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.pe_AudioPlayerComponent> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedpe_AudioPlayerComponentBuffer(FlatBufferBuilder builder, Offset<Titan.TrinityScene.pe_AudioPlayerComponent> offset) { builder.FinishSizePrefixed(offset.Value); }
  public pe_AudioPlayerComponentT UnPack() {
    var _o = new pe_AudioPlayerComponentT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(pe_AudioPlayerComponentT _o) {
  }
  public static Offset<Titan.TrinityScene.pe_AudioPlayerComponent> Pack(FlatBufferBuilder builder, pe_AudioPlayerComponentT _o) {
    if (_o == null) return default(Offset<Titan.TrinityScene.pe_AudioPlayerComponent>);
    Startpe_AudioPlayerComponent(builder);
    return Endpe_AudioPlayerComponent(builder);
  }
}

public class pe_AudioPlayerComponentT
{

  public pe_AudioPlayerComponentT() {
  }
  public static pe_AudioPlayerComponentT DeserializeFromBinary(byte[] fbBuffer) {
    return pe_AudioPlayerComponent.GetRootAspe_AudioPlayerComponent(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    pe_AudioPlayerComponent.Finishpe_AudioPlayerComponentBuffer(fbb, pe_AudioPlayerComponent.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
