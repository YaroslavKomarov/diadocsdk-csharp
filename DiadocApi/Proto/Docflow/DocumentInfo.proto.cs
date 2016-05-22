//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Docflow/DocumentInfo.proto
// Note: requires additional types generated from: DocumentType.proto
// Note: requires additional types generated from: DocumentDirection.proto
namespace Diadoc.Api.Proto.Docflow
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DocumentInfo")]
  public partial class DocumentInfo : global::ProtoBuf.IExtensible
  {
    public DocumentInfo() {}
    

    private Diadoc.Api.Proto.DocumentType _DocumentType = Diadoc.Api.Proto.DocumentType.UnknownDocumentType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DocumentType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.DocumentType.UnknownDocumentType)]
    public Diadoc.Api.Proto.DocumentType DocumentType
    {
      get { return _DocumentType; }
      set { _DocumentType = value; }
    }

    private Diadoc.Api.Proto.DocumentDirection _DocumentDirection = Diadoc.Api.Proto.DocumentDirection.UnknownDocumentDirection;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DocumentDirection", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.DocumentDirection.UnknownDocumentDirection)]
    public Diadoc.Api.Proto.DocumentDirection DocumentDirection
    {
      get { return _DocumentDirection; }
      set { _DocumentDirection = value; }
    }

    private bool _IsTest = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IsTest", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool IsTest
    {
      get { return _IsTest; }
      set { _IsTest = value; }
    }

    private string _CustomDocumentId = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"CustomDocumentId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string CustomDocumentId
    {
      get { return _CustomDocumentId; }
      set { _CustomDocumentId = value; }
    }

    private string _FromDepartmentId = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"FromDepartmentId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string FromDepartmentId
    {
      get { return _FromDepartmentId; }
      set { _FromDepartmentId = value; }
    }

    private string _ToDepartmentId = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ToDepartmentId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ToDepartmentId
    {
      get { return _ToDepartmentId; }
      set { _ToDepartmentId = value; }
    }

    private string _CounteragentBoxId = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"CounteragentBoxId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string CounteragentBoxId
    {
      get { return _CounteragentBoxId; }
      set { _CounteragentBoxId = value; }
    }

    private Diadoc.Api.Proto.Docflow.DocumentDateAndNumber _DocumentDateAndNumber = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DocumentDateAndNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.DocumentDateAndNumber DocumentDateAndNumber
    {
      get { return _DocumentDateAndNumber; }
      set { _DocumentDateAndNumber = value; }
    }

    private Diadoc.Api.Proto.Docflow.BasicDocumentInfo _BasicDocumentInfo = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"BasicDocumentInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.BasicDocumentInfo BasicDocumentInfo
    {
      get { return _BasicDocumentInfo; }
      set { _BasicDocumentInfo = value; }
    }

    private Diadoc.Api.Proto.Docflow.InvoiceDocumentInfo _InvoiceInfo = null;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"InvoiceInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.InvoiceDocumentInfo InvoiceInfo
    {
      get { return _InvoiceInfo; }
      set { _InvoiceInfo = value; }
    }

    private Diadoc.Api.Proto.Docflow.InvoiceCorrectionDocumentInfo _InvoiceCorrectionInfo = null;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"InvoiceCorrectionInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.InvoiceCorrectionDocumentInfo InvoiceCorrectionInfo
    {
      get { return _InvoiceCorrectionInfo; }
      set { _InvoiceCorrectionInfo = value; }
    }

    private Diadoc.Api.Proto.Docflow.PriceListDocumentInfo _PriceListInfo = null;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"PriceListInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.PriceListDocumentInfo PriceListInfo
    {
      get { return _PriceListInfo; }
      set { _PriceListInfo = value; }
    }

    private Diadoc.Api.Proto.Docflow.ContractDocumentInfo _ContractInfo = null;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"ContractInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.ContractDocumentInfo ContractInfo
    {
      get { return _ContractInfo; }
      set { _ContractInfo = value; }
    }

    private Diadoc.Api.Proto.Docflow.SupplementaryAgreementDocumentInfo _SupplementaryAgreementInfo = null;
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"SupplementaryAgreementInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.SupplementaryAgreementDocumentInfo SupplementaryAgreementInfo
    {
      get { return _SupplementaryAgreementInfo; }
      set { _SupplementaryAgreementInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DocumentDateAndNumber")]
  public partial class DocumentDateAndNumber : global::ProtoBuf.IExtensible
  {
    public DocumentDateAndNumber() {}
    

    private string _DocumentDate = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DocumentDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string DocumentDate
    {
      get { return _DocumentDate; }
      set { _DocumentDate = value; }
    }

    private string _DocumentNumber = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DocumentNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string DocumentNumber
    {
      get { return _DocumentNumber; }
      set { _DocumentNumber = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BasicDocumentInfo")]
  public partial class BasicDocumentInfo : global::ProtoBuf.IExtensible
  {
    public BasicDocumentInfo() {}
    

    private string _Total = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Total", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Total
    {
      get { return _Total; }
      set { _Total = value; }
    }

    private bool _NoVat = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"NoVat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool NoVat
    {
      get { return _NoVat; }
      set { _NoVat = value; }
    }

    private string _Vat = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Vat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Vat
    {
      get { return _Vat; }
      set { _Vat = value; }
    }

    private string _Grounds = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Grounds", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Grounds
    {
      get { return _Grounds; }
      set { _Grounds = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InvoiceDocumentInfo")]
  public partial class InvoiceDocumentInfo : global::ProtoBuf.IExtensible
  {
    public InvoiceDocumentInfo() {}
    

    private string _Total = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Total", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Total
    {
      get { return _Total; }
      set { _Total = value; }
    }

    private string _Vat = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Vat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Vat
    {
      get { return _Vat; }
      set { _Vat = value; }
    }

    private int _CurrencyCode = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"CurrencyCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int CurrencyCode
    {
      get { return _CurrencyCode; }
      set { _CurrencyCode = value; }
    }

    private Diadoc.Api.Proto.Docflow.DocumentDateAndNumber _OriginalInvoiceDateAndNumber = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"OriginalInvoiceDateAndNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.DocumentDateAndNumber OriginalInvoiceDateAndNumber
    {
      get { return _OriginalInvoiceDateAndNumber; }
      set { _OriginalInvoiceDateAndNumber = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InvoiceCorrectionDocumentInfo")]
  public partial class InvoiceCorrectionDocumentInfo : global::ProtoBuf.IExtensible
  {
    public InvoiceCorrectionDocumentInfo() {}
    

    private string _TotalInc = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"TotalInc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TotalInc
    {
      get { return _TotalInc; }
      set { _TotalInc = value; }
    }

    private string _TotalDec = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"TotalDec", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TotalDec
    {
      get { return _TotalDec; }
      set { _TotalDec = value; }
    }

    private string _VatInc = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"VatInc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string VatInc
    {
      get { return _VatInc; }
      set { _VatInc = value; }
    }

    private string _VatDec = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"VatDec", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string VatDec
    {
      get { return _VatDec; }
      set { _VatDec = value; }
    }

    private int _CurrencyCode = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"CurrencyCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int CurrencyCode
    {
      get { return _CurrencyCode; }
      set { _CurrencyCode = value; }
    }

    private Diadoc.Api.Proto.Docflow.DocumentDateAndNumber _OriginalInvoiceDateAndNumber = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"OriginalInvoiceDateAndNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.DocumentDateAndNumber OriginalInvoiceDateAndNumber
    {
      get { return _OriginalInvoiceDateAndNumber; }
      set { _OriginalInvoiceDateAndNumber = value; }
    }

    private Diadoc.Api.Proto.Docflow.DocumentDateAndNumber _OriginalInvoiceRevisionDateAndNumber = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"OriginalInvoiceRevisionDateAndNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.DocumentDateAndNumber OriginalInvoiceRevisionDateAndNumber
    {
      get { return _OriginalInvoiceRevisionDateAndNumber; }
      set { _OriginalInvoiceRevisionDateAndNumber = value; }
    }

    private Diadoc.Api.Proto.Docflow.DocumentDateAndNumber _OriginalInvoiceCorrectionDateAndNumber = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"OriginalInvoiceCorrectionDateAndNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.DocumentDateAndNumber OriginalInvoiceCorrectionDateAndNumber
    {
      get { return _OriginalInvoiceCorrectionDateAndNumber; }
      set { _OriginalInvoiceCorrectionDateAndNumber = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PriceListDocumentInfo")]
  public partial class PriceListDocumentInfo : global::ProtoBuf.IExtensible
  {
    public PriceListDocumentInfo() {}
    

    private string _PriceListEffectiveDate = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"PriceListEffectiveDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string PriceListEffectiveDate
    {
      get { return _PriceListEffectiveDate; }
      set { _PriceListEffectiveDate = value; }
    }

    private Diadoc.Api.Proto.Docflow.DocumentDateAndNumber _ContractDocumentDateAndNumber = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ContractDocumentDateAndNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.DocumentDateAndNumber ContractDocumentDateAndNumber
    {
      get { return _ContractDocumentDateAndNumber; }
      set { _ContractDocumentDateAndNumber = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ContractDocumentInfo")]
  public partial class ContractDocumentInfo : global::ProtoBuf.IExtensible
  {
    public ContractDocumentInfo() {}
    

    private string _ContractPrice = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ContractPrice", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ContractPrice
    {
      get { return _ContractPrice; }
      set { _ContractPrice = value; }
    }

    private string _ContractType = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ContractType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ContractType
    {
      get { return _ContractType; }
      set { _ContractType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SupplementaryAgreementDocumentInfo")]
  public partial class SupplementaryAgreementDocumentInfo : global::ProtoBuf.IExtensible
  {
    public SupplementaryAgreementDocumentInfo() {}
    

    private string _Total = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Total", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Total
    {
      get { return _Total; }
      set { _Total = value; }
    }

    private string _ContractType = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ContractType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ContractType
    {
      get { return _ContractType; }
      set { _ContractType = value; }
    }

    private string _ContractNumber = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ContractNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ContractNumber
    {
      get { return _ContractNumber; }
      set { _ContractNumber = value; }
    }

    private string _ContractDate = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ContractDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ContractDate
    {
      get { return _ContractDate; }
      set { _ContractDate = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}