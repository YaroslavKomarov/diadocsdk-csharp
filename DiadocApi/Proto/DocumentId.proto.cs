//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: DocumentId.proto
namespace Diadoc.Api.Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DocumentId")]
  public partial class DocumentId : global::ProtoBuf.IExtensible
  {
    public DocumentId() {}
    
    private string _MessageId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"MessageId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MessageId
    {
      get { return _MessageId; }
      set { _MessageId = value; }
    }
    private string _EntityId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"EntityId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string EntityId
    {
      get { return _EntityId; }
      set { _EntityId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DocumentIdEx")]
  public partial class DocumentIdEx : global::ProtoBuf.IExtensible
  {
    public DocumentIdEx() {}
    
    private string _MessageId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"MessageId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MessageId
    {
      get { return _MessageId; }
      set { _MessageId = value; }
    }
    private string _EntityId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"EntityId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string EntityId
    {
      get { return _EntityId; }
      set { _EntityId = value; }
    }
    private string _BoxId;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"BoxId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BoxId
    {
      get { return _BoxId; }
      set { _BoxId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}