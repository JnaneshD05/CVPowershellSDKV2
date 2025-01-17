// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Applicable only for credentials with Cloud Account and Vendor Type as Microsoft Azure
    /// </summary>
    public partial class AzureCredentialContentWithTenantId :
        Commvault.Powershell.Models.IAzureCredentialContentWithTenantId,
        Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal
    {

        /// <summary>Backing field for <see cref="ApplicationId" /> property.</summary>
        private string _applicationId;

        /// <summary>Unique Azure application ID</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ApplicationId { get => this._applicationId; set => this._applicationId = value; }

        /// <summary>Internal Acessors for Endpoints</summary>
        Commvault.Powershell.Models.IAzureEndpoints Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal.Endpoints { get => (this._endpoints = this._endpoints ?? new Commvault.Powershell.Models.AzureEndpoints()); set { {_endpoints = value;} } }

        /// <summary>Internal Acessors for OwnerUser</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal.OwnerUser { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).OwnerUser; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).OwnerUser = value; }

        /// <summary>Internal Acessors for OwnerUserGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal.OwnerUserGroup { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).OwnerUserGroup; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).OwnerUserGroup = value; }

        /// <summary>Internal Acessors for Security</summary>
        Commvault.Powershell.Models.ICredentialSecurity Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal.Security { get => (this._security = this._security ?? new Commvault.Powershell.Models.CredentialSecurity()); set { {_security = value;} } }

        /// <summary>Internal Acessors for SecurityOwner</summary>
        Commvault.Powershell.Models.ICredentialOwner Commvault.Powershell.Models.IAzureCredentialContentWithTenantIdInternal.SecurityOwner { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).Owner; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).Owner = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Updated description of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string EndpointActiveDirectory { get => ((Commvault.Powershell.Models.IAzureEndpointsInternal)Endpoints).ActiveDirectory; set => ((Commvault.Powershell.Models.IAzureEndpointsInternal)Endpoints).ActiveDirectory = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string EndpointResourceManager { get => ((Commvault.Powershell.Models.IAzureEndpointsInternal)Endpoints).ResourceManager; set => ((Commvault.Powershell.Models.IAzureEndpointsInternal)Endpoints).ResourceManager = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string EndpointStorage { get => ((Commvault.Powershell.Models.IAzureEndpointsInternal)Endpoints).Storage; set => ((Commvault.Powershell.Models.IAzureEndpointsInternal)Endpoints).Storage = value ?? null; }

        /// <summary>Backing field for <see cref="Endpoints" /> property.</summary>
        private Commvault.Powershell.Models.IAzureEndpoints _endpoints;

        /// <summary>Endpoints for Aunthentication, Storage and Management</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IAzureEndpoints Endpoints { get => (this._endpoints = this._endpoints ?? new Commvault.Powershell.Models.AzureEndpoints()); set => this._endpoints = value; }

        /// <summary>Backing field for <see cref="Environment" /> property.</summary>
        private string _environment;

        /// <summary>Azure cloud deployed region</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Environment { get => this._environment; set => this._environment = value; }

        /// <summary>Backing field for <see cref="NewApplicationSecret" /> property.</summary>
        private string _newApplicationSecret;

        /// <summary>Application secret of Credential and must be in base64 encoded format.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NewApplicationSecret { get => this._newApplicationSecret; set => this._newApplicationSecret = value; }

        /// <summary>Backing field for <see cref="NewName" /> property.</summary>
        private string _newName;

        /// <summary>Updated name of credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NewName { get => this._newName; set => this._newName = value; }

        /// <summary>Backing field for <see cref="Security" /> property.</summary>
        private Commvault.Powershell.Models.ICredentialSecurity _security;

        /// <summary>Security association of a list of users and user groups</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ICredentialSecurity Security { get => (this._security = this._security ?? new Commvault.Powershell.Models.CredentialSecurity()); set => this._security = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.ICredentialSecurityAssociations[] SecurityAssociations { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).Associations; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).Associations = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Unique Azure active directory ID</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; set => this._tenantId = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? UserGroupId { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserGroupId; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserGroupId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserGroupName { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserGroupName; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserGroupName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? UserId { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserId; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserName { get => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserName; set => ((Commvault.Powershell.Models.ICredentialSecurityInternal)Security).UserName = value ?? null; }

        /// <summary>Creates an new <see cref="AzureCredentialContentWithTenantId" /> instance.</summary>
        public AzureCredentialContentWithTenantId()
        {

        }
    }
    /// Applicable only for credentials with Cloud Account and Vendor Type as Microsoft Azure
    public partial interface IAzureCredentialContentWithTenantId :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Unique Azure application ID</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unique Azure application ID",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationId { get; set; }
        /// <summary>Updated description of Credential</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Updated description of Credential",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"activeDirectory",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointActiveDirectory { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"resourceManager",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointResourceManager { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"storage",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointStorage { get; set; }
        /// <summary>Azure cloud deployed region</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure cloud deployed region",
        SerializedName = @"environment",
        PossibleTypes = new [] { typeof(string) })]
        string Environment { get; set; }
        /// <summary>Application secret of Credential and must be in base64 encoded format.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Application secret of Credential and must be in base64 encoded format.",
        SerializedName = @"newApplicationSecret",
        PossibleTypes = new [] { typeof(string) })]
        string NewApplicationSecret { get; set; }
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
        /// <summary>Unique Azure active directory ID</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unique Azure active directory ID",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }

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
    /// Applicable only for credentials with Cloud Account and Vendor Type as Microsoft Azure
    internal partial interface IAzureCredentialContentWithTenantIdInternal

    {
        /// <summary>Unique Azure application ID</summary>
        string ApplicationId { get; set; }
        /// <summary>Updated description of Credential</summary>
        string Description { get; set; }

        string EndpointActiveDirectory { get; set; }

        string EndpointResourceManager { get; set; }

        string EndpointStorage { get; set; }
        /// <summary>Endpoints for Aunthentication, Storage and Management</summary>
        Commvault.Powershell.Models.IAzureEndpoints Endpoints { get; set; }
        /// <summary>Azure cloud deployed region</summary>
        string Environment { get; set; }
        /// <summary>Application secret of Credential and must be in base64 encoded format.</summary>
        string NewApplicationSecret { get; set; }
        /// <summary>Updated name of credential</summary>
        string NewName { get; set; }

        Commvault.Powershell.Models.IIdName OwnerUser { get; set; }

        Commvault.Powershell.Models.IIdName OwnerUserGroup { get; set; }
        /// <summary>Security association of a list of users and user groups</summary>
        Commvault.Powershell.Models.ICredentialSecurity Security { get; set; }

        Commvault.Powershell.Models.ICredentialSecurityAssociations[] SecurityAssociations { get; set; }
        /// <summary>Owner of a credential can be a user or user group</summary>
        Commvault.Powershell.Models.ICredentialOwner SecurityOwner { get; set; }
        /// <summary>Unique Azure active directory ID</summary>
        string TenantId { get; set; }

        int? UserGroupId { get; set; }

        string UserGroupName { get; set; }

        int? UserId { get; set; }

        string UserName { get; set; }

    }
}