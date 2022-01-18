// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Applicable only for credentials with Cloud Account and Vendor Type as Salesforce Connected App
    /// </summary>
    public partial class SalesforceCredentialContent :
        Commvault.Powershell.Models.ISalesforceCredentialContent,
        Commvault.Powershell.Models.ISalesforceCredentialContentInternal
    {

        /// <summary>Internal Acessors for OwnerUser</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ISalesforceCredentialContentInternal.OwnerUser { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).OwnerUser; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).OwnerUser = value; }

        /// <summary>Internal Acessors for OwnerUserGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ISalesforceCredentialContentInternal.OwnerUserGroup { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).OwnerUserGroup; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).OwnerUserGroup = value; }

        /// <summary>Internal Acessors for Security</summary>
        Commvault.Powershell.Models.IUpdateCredentialSecurity Commvault.Powershell.Models.ISalesforceCredentialContentInternal.Security { get => (this._security = this._security ?? new Commvault.Powershell.Models.UpdateCredentialSecurity()); set { {_security = value;} } }

        /// <summary>Internal Acessors for SecurityOwner</summary>
        Commvault.Powershell.Models.ICredentialOwner Commvault.Powershell.Models.ISalesforceCredentialContentInternal.SecurityOwner { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).Owner; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).Owner = value; }

        /// <summary>Backing field for <see cref="ConsumerKey" /> property.</summary>
        private string _consumerKey;

        /// <summary>Consumer key of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ConsumerKey { get => this._consumerKey; set => this._consumerKey = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Updated description of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="NewConsumerSecret" /> property.</summary>
        private string _newConsumerSecret;

        /// <summary>Consumer secret of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NewConsumerSecret { get => this._newConsumerSecret; set => this._newConsumerSecret = value; }

        /// <summary>Backing field for <see cref="NewName" /> property.</summary>
        private string _newName;

        /// <summary>Updated name of credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NewName { get => this._newName; set => this._newName = value; }

        /// <summary>Backing field for <see cref="Security" /> property.</summary>
        private Commvault.Powershell.Models.IUpdateCredentialSecurity _security;

        /// <summary>Update Security association of a list of users and user groups</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IUpdateCredentialSecurity Security { get => (this._security = this._security ?? new Commvault.Powershell.Models.UpdateCredentialSecurity()); set => this._security = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.ICredentialSecurityAssociations[] SecurityAssociations { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).Associations; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).Associations = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? UserGroupId { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserGroupId; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserGroupId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserGroupName { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserGroupName; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserGroupName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? UserId { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserId; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserName { get => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserName; set => ((Commvault.Powershell.Models.IUpdateCredentialSecurityInternal)Security).UserName = value ?? null; }

        /// <summary>Creates an new <see cref="SalesforceCredentialContent" /> instance.</summary>
        public SalesforceCredentialContent()
        {

        }
    }
    /// Applicable only for credentials with Cloud Account and Vendor Type as Salesforce Connected App
    public partial interface ISalesforceCredentialContent :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Consumer key of Credential</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Consumer key of Credential",
        SerializedName = @"consumerKey",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumerKey { get; set; }
        /// <summary>Updated description of Credential</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Updated description of Credential",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Consumer secret of Credential</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Consumer secret of Credential",
        SerializedName = @"newConsumerSecret",
        PossibleTypes = new [] { typeof(string) })]
        string NewConsumerSecret { get; set; }
        /// <summary>Updated name of credential</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Updated name of credential",
        SerializedName = @"newName",
        PossibleTypes = new [] { typeof(string) })]
        string NewName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"associations",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ICredentialSecurityAssociations) })]
        Commvault.Powershell.Models.ICredentialSecurityAssociations[] SecurityAssociations { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? UserGroupId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string UserGroupName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? UserId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }

    }
    /// Applicable only for credentials with Cloud Account and Vendor Type as Salesforce Connected App
    internal partial interface ISalesforceCredentialContentInternal

    {
        /// <summary>Consumer key of Credential</summary>
        string ConsumerKey { get; set; }
        /// <summary>Updated description of Credential</summary>
        string Description { get; set; }
        /// <summary>Consumer secret of Credential</summary>
        string NewConsumerSecret { get; set; }
        /// <summary>Updated name of credential</summary>
        string NewName { get; set; }

        Commvault.Powershell.Models.IIdName OwnerUser { get; set; }

        Commvault.Powershell.Models.IIdName OwnerUserGroup { get; set; }
        /// <summary>Update Security association of a list of users and user groups</summary>
        Commvault.Powershell.Models.IUpdateCredentialSecurity Security { get; set; }

        Commvault.Powershell.Models.ICredentialSecurityAssociations[] SecurityAssociations { get; set; }
        /// <summary>Owner of a credential can be a user or user group</summary>
        Commvault.Powershell.Models.ICredentialOwner SecurityOwner { get; set; }

        int? UserGroupId { get; set; }

        string UserGroupName { get; set; }

        int? UserId { get; set; }

        string UserName { get; set; }

    }
}