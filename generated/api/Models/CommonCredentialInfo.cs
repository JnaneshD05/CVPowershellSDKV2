// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>CommonCredentialInfo</summary>
    public partial class CommonCredentialInfo :
        Commvault.Powershell.Models.ICommonCredentialInfo,
        Commvault.Powershell.Models.ICommonCredentialInfoInternal
    {

        /// <summary>Internal Acessors for OwnerUser</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICommonCredentialInfoInternal.OwnerUser { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).OwnerUser; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).OwnerUser = value; }

        /// <summary>Internal Acessors for OwnerUserGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICommonCredentialInfoInternal.OwnerUserGroup { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).OwnerUserGroup; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).OwnerUserGroup = value; }

        /// <summary>Internal Acessors for Security</summary>
        Commvault.Powershell.Models.ICredentialSecurity Commvault.Powershell.Models.ICommonCredentialInfoInternal.Security { get => (this._security = this._security ?? new Commvault.Powershell.Models.CredentialSecurity()); set { {_security = value;} } }

        /// <summary>Internal Acessors for SecurityOwner</summary>
        Commvault.Powershell.Models.ICredentialOwner Commvault.Powershell.Models.ICommonCredentialInfoInternal.SecurityOwner { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).Owner; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).Owner = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Security" /> property.</summary>
        private Commvault.Powershell.Models.ICredentialSecurity _security;

        /// <summary>Security association of a list of users and user groups</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ICredentialSecurity Security { get => (this._security = this._security ?? new Commvault.Powershell.Models.CredentialSecurity()); set => this._security = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.ICredentialSecurityAssociations[] SecurityAssociations { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).Associations; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).Associations = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? UserGroupId { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserGroupId; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserGroupId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserGroupName { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserGroupName; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserGroupName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? UserId { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserId; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserName { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserName; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserName = value ?? null; }

        /// <summary>Creates an new <see cref="CommonCredentialInfo" /> instance.</summary>
        public CommonCredentialInfo()
        {

        }
    }
    /// CommonCredentialInfo
    public partial interface ICommonCredentialInfo :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Description of Credential</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of Credential",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }

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
    /// CommonCredentialInfo
    internal partial interface ICommonCredentialInfoInternal

    {
        /// <summary>Description of Credential</summary>
        string Description { get; set; }

        Commvault.Powershell.Models.IIdName OwnerUser { get; set; }

        Commvault.Powershell.Models.IIdName OwnerUserGroup { get; set; }
        /// <summary>Security association of a list of users and user groups</summary>
        Commvault.Powershell.Models.ICredentialSecurity Security { get; set; }

        Commvault.Powershell.Models.ICredentialSecurityAssociations[] SecurityAssociations { get; set; }
        /// <summary>Owner of a credential can be a user or user group</summary>
        Commvault.Powershell.Models.ICredentialOwner SecurityOwner { get; set; }

        int? UserGroupId { get; set; }

        string UserGroupName { get; set; }

        int? UserId { get; set; }

        string UserName { get; set; }

    }
}