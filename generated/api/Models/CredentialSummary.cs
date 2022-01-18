// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Summary of a credential</summary>
    public partial class CredentialSummary :
        Commvault.Powershell.Models.ICredentialSummary,
        Commvault.Powershell.Models.ICredentialSummaryInternal
    {

        /// <summary>Backing field for <see cref="AccountType" /> property.</summary>
        private string _accountType;

        /// <summary>CredentialAccountType</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string AccountType { get => this._accountType; set => this._accountType = value; }

        /// <summary>Backing field for <see cref="AuthType" /> property.</summary>
        private string _authType;

        /// <summary>
        /// Aunthentication type applicable only for Cloud Accounts with Amazon Web Services or Microsoft Azure as vendor.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string AuthType { get => this._authType; set => this._authType = value; }

        /// <summary>Backing field for <see cref="Commcell" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _commcell;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Commcell { get => (this._commcell = this._commcell ?? new Commvault.Powershell.Models.IdName()); set => this._commcell = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? CommcellId { get => ((Commvault.Powershell.Models.IIdNameInternal)Commcell).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Commcell).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CommcellName { get => ((Commvault.Powershell.Models.IIdNameInternal)Commcell).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Commcell).Name = value ?? null; }

        /// <summary>Internal Acessors for Commcell</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICredentialSummaryInternal.Commcell { get => (this._commcell = this._commcell ?? new Commvault.Powershell.Models.IdName()); set { {_commcell = value;} } }

        /// <summary>Internal Acessors for Company</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICredentialSummaryInternal.Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set { {_company = value;} } }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _company;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set => this._company = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? CompanyId { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        /// <summary>Id of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="VendorType" /> property.</summary>
        private string _vendorType;

        /// <summary>Cloud vendor types appilcable only for Cloud Account type</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string VendorType { get => this._vendorType; set => this._vendorType = value; }

        /// <summary>Creates an new <see cref="CredentialSummary" /> instance.</summary>
        public CredentialSummary()
        {

        }
    }
    /// Summary of a credential
    public partial interface ICredentialSummary :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>CredentialAccountType</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"CredentialAccountType",
        SerializedName = @"accountType",
        PossibleTypes = new [] { typeof(string) })]
        string AccountType { get; set; }
        /// <summary>
        /// Aunthentication type applicable only for Cloud Accounts with Amazon Web Services or Microsoft Azure as vendor.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Aunthentication type applicable only for Cloud Accounts with Amazon Web Services or Microsoft Azure as vendor.",
        SerializedName = @"authType",
        PossibleTypes = new [] { typeof(string) })]
        string AuthType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? CommcellId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CommcellName { get; set; }

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
        /// <summary>Description of Credential</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of Credential",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Id of Credential</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of Credential",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }
        /// <summary>Name of Credential</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of Credential",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Cloud vendor types appilcable only for Cloud Account type</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Cloud vendor types appilcable only for Cloud Account type",
        SerializedName = @"vendorType",
        PossibleTypes = new [] { typeof(string) })]
        string VendorType { get; set; }

    }
    /// Summary of a credential
    internal partial interface ICredentialSummaryInternal

    {
        /// <summary>CredentialAccountType</summary>
        string AccountType { get; set; }
        /// <summary>
        /// Aunthentication type applicable only for Cloud Accounts with Amazon Web Services or Microsoft Azure as vendor.
        /// </summary>
        string AuthType { get; set; }

        Commvault.Powershell.Models.IIdName Commcell { get; set; }

        int? CommcellId { get; set; }

        string CommcellName { get; set; }

        Commvault.Powershell.Models.IIdName Company { get; set; }

        int? CompanyId { get; set; }

        string CompanyName { get; set; }
        /// <summary>Description of Credential</summary>
        string Description { get; set; }
        /// <summary>Id of Credential</summary>
        int? Id { get; set; }
        /// <summary>Name of Credential</summary>
        string Name { get; set; }
        /// <summary>Cloud vendor types appilcable only for Cloud Account type</summary>
        string VendorType { get; set; }

    }
}