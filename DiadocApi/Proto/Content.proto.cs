//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Content.proto
namespace Diadoc.Api.Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Content")]
  public partial class Content : global::ProtoBuf.IExtensible
  {
    public Content() {}
    
    private int _Size;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Size", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public int Size
    {
      get { return _Size; }
      set { _Size = value; }
    }

    private byte[] _Data = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] Data
    {
      get { return _Data; }
      set { _Data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}