//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Documents/DocumentZip.proto
namespace Diadoc.Api.Proto.Documents
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DocumentZipGenerationResult")]
  public partial class DocumentZipGenerationResult : global::ProtoBuf.IExtensible
  {
    public DocumentZipGenerationResult() {}
    

    private string _ZipFileNameOnShelf = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ZipFileNameOnShelf", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ZipFileNameOnShelf
    {
      get { return _ZipFileNameOnShelf; }
      set { _ZipFileNameOnShelf = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}