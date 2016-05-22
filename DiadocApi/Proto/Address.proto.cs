//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Address.proto
namespace Diadoc.Api.Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Address")]
  public partial class Address : global::ProtoBuf.IExtensible
  {
    public Address() {}
    

    private Diadoc.Api.Proto.RussianAddress _RussianAddress = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RussianAddress", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.RussianAddress RussianAddress
    {
      get { return _RussianAddress; }
      set { _RussianAddress = value; }
    }

    private Diadoc.Api.Proto.ForeignAddress _ForeignAddress = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ForeignAddress", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.ForeignAddress ForeignAddress
    {
      get { return _ForeignAddress; }
      set { _ForeignAddress = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RussianAddress")]
  public partial class RussianAddress : global::ProtoBuf.IExtensible
  {
    public RussianAddress() {}
    

    private string _ZipCode = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ZipCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ZipCode
    {
      get { return _ZipCode; }
      set { _ZipCode = value; }
    }
    private string _Region;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Region", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Region
    {
      get { return _Region; }
      set { _Region = value; }
    }

    private string _Territory = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Territory", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Territory
    {
      get { return _Territory; }
      set { _Territory = value; }
    }

    private string _City = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"City", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string City
    {
      get { return _City; }
      set { _City = value; }
    }

    private string _Locality = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Locality", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Locality
    {
      get { return _Locality; }
      set { _Locality = value; }
    }

    private string _Street = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Street", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Street
    {
      get { return _Street; }
      set { _Street = value; }
    }

    private string _Building = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Building", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Building
    {
      get { return _Building; }
      set { _Building = value; }
    }

    private string _Block = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Block", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Block
    {
      get { return _Block; }
      set { _Block = value; }
    }

    private string _Apartment = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Apartment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Apartment
    {
      get { return _Apartment; }
      set { _Apartment = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ForeignAddress")]
  public partial class ForeignAddress : global::ProtoBuf.IExtensible
  {
    public ForeignAddress() {}
    
    private string _Country;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Country", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Country
    {
      get { return _Country; }
      set { _Country = value; }
    }
    private string _Address;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Address", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Address
    {
      get { return _Address; }
      set { _Address = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}