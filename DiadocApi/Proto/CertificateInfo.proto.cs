//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: CertificateInfo.proto
namespace Diadoc.Api.Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CertificateInfo")]
  public partial class CertificateInfo : global::ProtoBuf.IExtensible
  {
    public CertificateInfo() {}
    

    private string _Thumbprint = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Thumbprint", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Thumbprint
    {
      get { return _Thumbprint; }
      set { _Thumbprint = value; }
    }

    private long _ValidFrom = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ValidFrom", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long ValidFrom
    {
      get { return _ValidFrom; }
      set { _ValidFrom = value; }
    }

    private long _ValidTo = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ValidTo", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long ValidTo
    {
      get { return _ValidTo; }
      set { _ValidTo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}