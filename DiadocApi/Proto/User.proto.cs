//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: User.proto
// Note: requires additional types generated from: CertificateInfo.proto
namespace Diadoc.Api.Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"User")]
  public partial class User : global::ProtoBuf.IExtensible
  {
    public User() {}
    

    private string _Id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Id
    {
      get { return _Id; }
      set { _Id = value; }
    }

    private string _LastName = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"LastName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string LastName
    {
      get { return _LastName; }
      set { _LastName = value; }
    }

    private string _FirstName = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"FirstName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string FirstName
    {
      get { return _FirstName; }
      set { _FirstName = value; }
    }

    private string _MiddleName = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"MiddleName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string MiddleName
    {
      get { return _MiddleName; }
      set { _MiddleName = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.CertificateInfo> _CloudCertificates = new global::System.Collections.Generic.List<Diadoc.Api.Proto.CertificateInfo>();
    [global::ProtoBuf.ProtoMember(5, Name=@"CloudCertificates", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.CertificateInfo> CloudCertificates
    {
      get { return _CloudCertificates; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}