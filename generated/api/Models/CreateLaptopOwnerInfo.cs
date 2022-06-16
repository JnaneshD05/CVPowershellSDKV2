// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>This is the data model for creating a laptop owner info</summary>
    public partial class CreateLaptopOwnerInfo :
        Commvault.Powershell.Models.ICreateLaptopOwnerInfo,
        Commvault.Powershell.Models.ICreateLaptopOwnerInfoInternal
    {

        /// <summary>Internal Acessors for Company</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICreateLaptopOwnerInfoInternal.Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set { {_company = value;} } }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _company;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set => this._company = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? CompanyId { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Host" /> property.</summary>
        private string _host;

        /// <summary>Host name of the laptop</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Host { get => this._host; set => this._host = value; }

        /// <summary>Backing field for <see cref="LaptopName" /> property.</summary>
        private string _laptopName;

        /// <summary>Display name of the laptop</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string LaptopName { get => this._laptopName; set => this._laptopName = value; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>Operating system of the owner</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; set => this._oSType = value; }

        /// <summary>Backing field for <see cref="OwnerEmail" /> property.</summary>
        private string _ownerEmail;

        /// <summary>Email address of the owner</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string OwnerEmail { get => this._ownerEmail; set => this._ownerEmail = value; }

        /// <summary>Backing field for <see cref="OwnerUpn" /> property.</summary>
        private string _ownerUpn;

        /// <summary>UPN of the owner</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string OwnerUpn { get => this._ownerUpn; set => this._ownerUpn = value; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>Serial number of the laptop</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; set => this._serialNumber = value; }

        /// <summary>Creates an new <see cref="CreateLaptopOwnerInfo" /> instance.</summary>
        public CreateLaptopOwnerInfo()
        {

        }
    }
    /// This is the data model for creating a laptop owner info
    public partial interface ICreateLaptopOwnerInfo :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? CompanyId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyName { get; set; }
        /// <summary>Host name of the laptop</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Host name of the laptop",
        SerializedName = @"host",
        PossibleTypes = new [] { typeof(string) })]
        string Host { get; set; }
        /// <summary>Display name of the laptop</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the laptop",
        SerializedName = @"laptopName",
        PossibleTypes = new [] { typeof(string) })]
        string LaptopName { get; set; }
        /// <summary>Operating system of the owner</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operating system of the owner",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        string OSType { get; set; }
        /// <summary>Email address of the owner</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email address of the owner",
        SerializedName = @"ownerEmail",
        PossibleTypes = new [] { typeof(string) })]
        string OwnerEmail { get; set; }
        /// <summary>UPN of the owner</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"UPN of the owner",
        SerializedName = @"ownerUPN",
        PossibleTypes = new [] { typeof(string) })]
        string OwnerUpn { get; set; }
        /// <summary>Serial number of the laptop</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Serial number of the laptop",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get; set; }

    }
    /// This is the data model for creating a laptop owner info
    internal partial interface ICreateLaptopOwnerInfoInternal

    {
        Commvault.Powershell.Models.IIdName Company { get; set; }

        int? CompanyId { get; set; }

        string CompanyName { get; set; }
        /// <summary>Host name of the laptop</summary>
        string Host { get; set; }
        /// <summary>Display name of the laptop</summary>
        string LaptopName { get; set; }
        /// <summary>Operating system of the owner</summary>
        string OSType { get; set; }
        /// <summary>Email address of the owner</summary>
        string OwnerEmail { get; set; }
        /// <summary>UPN of the owner</summary>
        string OwnerUpn { get; set; }
        /// <summary>Serial number of the laptop</summary>
        string SerialNumber { get; set; }

    }
}