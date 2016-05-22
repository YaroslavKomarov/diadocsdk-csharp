//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Docflow/BilateralDocflow.proto
// Note: requires additional types generated from: Docflow/ReceiptDocflow.proto
// Note: requires additional types generated from: Docflow/RecipientSignatureDocflow.proto
// Note: requires additional types generated from: Docflow/RecipientSignatureRejectionDocflow.proto
namespace Diadoc.Api.Proto.Docflow
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BilateralDocflow")]
  public partial class BilateralDocflow : global::ProtoBuf.IExtensible
  {
    public BilateralDocflow() {}
    

    private bool _IsFinished = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IsFinished", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool IsFinished
    {
      get { return _IsFinished; }
      set { _IsFinished = value; }
    }

    private Diadoc.Api.Proto.Docflow.ReceiptDocflow _ReceiptDocflow = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ReceiptDocflow", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.ReceiptDocflow ReceiptDocflow
    {
      get { return _ReceiptDocflow; }
      set { _ReceiptDocflow = value; }
    }

    private Diadoc.Api.Proto.Docflow.RecipientSignatureDocflow _RecipientSignatureDocflow = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"RecipientSignatureDocflow", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.RecipientSignatureDocflow RecipientSignatureDocflow
    {
      get { return _RecipientSignatureDocflow; }
      set { _RecipientSignatureDocflow = value; }
    }

    private Diadoc.Api.Proto.Docflow.RecipientSignatureRejectionDocflow _RecipientSignatureRejectionDocflow = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"RecipientSignatureRejectionDocflow", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.RecipientSignatureRejectionDocflow RecipientSignatureRejectionDocflow
    {
      get { return _RecipientSignatureRejectionDocflow; }
      set { _RecipientSignatureRejectionDocflow = value; }
    }

    private bool _IsReceiptRequested = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"IsReceiptRequested", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool IsReceiptRequested
    {
      get { return _IsReceiptRequested; }
      set { _IsReceiptRequested = value; }
    }

    private bool _IsRecipientSignatureRequested = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"IsRecipientSignatureRequested", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool IsRecipientSignatureRequested
    {
      get { return _IsRecipientSignatureRequested; }
      set { _IsRecipientSignatureRequested = value; }
    }

    private bool _IsDocumentSignedByRecipient = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"IsDocumentSignedByRecipient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool IsDocumentSignedByRecipient
    {
      get { return _IsDocumentSignedByRecipient; }
      set { _IsDocumentSignedByRecipient = value; }
    }

    private bool _IsDocumentRejectedByRecipient = default(bool);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"IsDocumentRejectedByRecipient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool IsDocumentRejectedByRecipient
    {
      get { return _IsDocumentRejectedByRecipient; }
      set { _IsDocumentRejectedByRecipient = value; }
    }

    private bool _CanDocumentBeReceipted = default(bool);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CanDocumentBeReceipted", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool CanDocumentBeReceipted
    {
      get { return _CanDocumentBeReceipted; }
      set { _CanDocumentBeReceipted = value; }
    }

    private bool _CanDocumentBeSignedBySender = default(bool);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"CanDocumentBeSignedBySender", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool CanDocumentBeSignedBySender
    {
      get { return _CanDocumentBeSignedBySender; }
      set { _CanDocumentBeSignedBySender = value; }
    }

    private bool _CanDocumentBeSignedOrRejectedByRecipient = default(bool);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"CanDocumentBeSignedOrRejectedByRecipient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool CanDocumentBeSignedOrRejectedByRecipient
    {
      get { return _CanDocumentBeSignedOrRejectedByRecipient; }
      set { _CanDocumentBeSignedOrRejectedByRecipient = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}