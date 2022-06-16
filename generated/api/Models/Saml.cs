// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Get SAML response</summary>
    public partial class Saml :
        Commvault.Powershell.Models.ISaml,
        Commvault.Powershell.Models.ISamlInternal
    {

        /// <summary>Companies associated with SAML</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IIdName[] AssociationCompanies { get => ((Commvault.Powershell.Models.ISamlAssociationsInternal)Associations).Companies; set => ((Commvault.Powershell.Models.ISamlAssociationsInternal)Associations).Companies = value ?? null /* arrayOf */; }

        /// <summary>Domains associated with SAML</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IIdName[] AssociationDomains { get => ((Commvault.Powershell.Models.ISamlAssociationsInternal)Associations).Domains; set => ((Commvault.Powershell.Models.ISamlAssociationsInternal)Associations).Domains = value ?? null /* arrayOf */; }

        /// <summary>Email suffixes associated with SAML</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] AssociationEmailSuffixes { get => ((Commvault.Powershell.Models.ISamlAssociationsInternal)Associations).EmailSuffixes; set => ((Commvault.Powershell.Models.ISamlAssociationsInternal)Associations).EmailSuffixes = value ?? null /* arrayOf */; }

        /// <summary>user groups associated with SAML</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IIdName[] AssociationUserGroups { get => ((Commvault.Powershell.Models.ISamlAssociationsInternal)Associations).UserGroups; set => ((Commvault.Powershell.Models.ISamlAssociationsInternal)Associations).UserGroups = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Associations" /> property.</summary>
        private Commvault.Powershell.Models.ISamlAssociations _associations;

        /// <summary>SAMLAssociations</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ISamlAssociations Associations { get => (this._associations = this._associations ?? new Commvault.Powershell.Models.SamlAssociations()); set => this._associations = value; }

        /// <summary>Backing field for <see cref="AttributeMappings" /> property.</summary>
        private Commvault.Powershell.Models.ISamlAttributes[] _attributeMappings;

        /// <summary>attribute mapping details</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.ISamlAttributes[] AttributeMappings { get => this._attributeMappings; set => this._attributeMappings = value; }

        /// <summary>Backing field for <see cref="AutoCreateUser" /> property.</summary>
        private bool? _autoCreateUser;

        /// <summary>
        /// This auto-creates non-existing user if the user detail match with the identity rule.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? AutoCreateUser { get => this._autoCreateUser; set => this._autoCreateUser = value; }

        /// <summary>Internal Acessors for Associations</summary>
        Commvault.Powershell.Models.ISamlAssociations Commvault.Powershell.Models.ISamlInternal.Associations { get => (this._associations = this._associations ?? new Commvault.Powershell.Models.SamlAssociations()); set { {_associations = value;} } }

        /// <summary>Internal Acessors for CreatedForCompany</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ISamlInternal.CreatedForCompany { get => (this._createdForCompany = this._createdForCompany ?? new Commvault.Powershell.Models.IdName()); set { {_createdForCompany = value;} } }

        /// <summary>Internal Acessors for IdentityProviderMetaData</summary>
        Commvault.Powershell.Models.ISamlidpMetaDataResp Commvault.Powershell.Models.ISamlInternal.IdentityProviderMetaData { get => (this._identityProviderMetaData = this._identityProviderMetaData ?? new Commvault.Powershell.Models.SamlidpMetaDataResp()); set { {_identityProviderMetaData = value;} } }

        /// <summary>Internal Acessors for ServiceProviderMetaData</summary>
        Commvault.Powershell.Models.ISamlspMetaDataResp Commvault.Powershell.Models.ISamlInternal.ServiceProviderMetaData { get => (this._serviceProviderMetaData = this._serviceProviderMetaData ?? new Commvault.Powershell.Models.SamlspMetaDataResp()); set { {_serviceProviderMetaData = value;} } }

        /// <summary>Internal Acessors for UserGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ISamlInternal.UserGroup { get => (this._userGroup = this._userGroup ?? new Commvault.Powershell.Models.IdName()); set { {_userGroup = value;} } }

        /// <summary>Backing field for <see cref="CreatedForCompany" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _createdForCompany;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName CreatedForCompany { get => (this._createdForCompany = this._createdForCompany ?? new Commvault.Powershell.Models.IdName()); set => this._createdForCompany = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? CreatedForCompanyId { get => ((Commvault.Powershell.Models.IIdNameInternal)CreatedForCompany).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)CreatedForCompany).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CreatedForCompanyName { get => ((Commvault.Powershell.Models.IIdNameInternal)CreatedForCompany).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)CreatedForCompany).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>SAML description</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Boolean to indicate whether SAML is enabled.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="IdentityProviderMetaData" /> property.</summary>
        private Commvault.Powershell.Models.ISamlidpMetaDataResp _identityProviderMetaData;

        /// <summary>SAML Identity provider meta data response</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ISamlidpMetaDataResp IdentityProviderMetaData { get => (this._identityProviderMetaData = this._identityProviderMetaData ?? new Commvault.Powershell.Models.SamlidpMetaDataResp()); set => this._identityProviderMetaData = value; }

        /// <summary>Identity provider entity</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string IdentityProviderMetaDataEntityId { get => ((Commvault.Powershell.Models.ISamlidpMetaDataRespInternal)IdentityProviderMetaData).EntityId; set => ((Commvault.Powershell.Models.ISamlidpMetaDataRespInternal)IdentityProviderMetaData).EntityId = value ?? null; }

        /// <summary>Identity Provider log-out URL</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string IdentityProviderMetaDataLogoutUrl { get => ((Commvault.Powershell.Models.ISamlidpMetaDataRespInternal)IdentityProviderMetaData).LogoutUrl; set => ((Commvault.Powershell.Models.ISamlidpMetaDataRespInternal)IdentityProviderMetaData).LogoutUrl = value ?? null; }

        /// <summary>Identity provider redirect URL</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string IdentityProviderMetaDataRedirectUrl { get => ((Commvault.Powershell.Models.ISamlidpMetaDataRespInternal)IdentityProviderMetaData).RedirectUrl; set => ((Commvault.Powershell.Models.ISamlidpMetaDataRespInternal)IdentityProviderMetaData).RedirectUrl = value ?? null; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>SAML name.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="NameIdAttribute" /> property.</summary>
        private string _nameIdAttribute;

        /// <summary>nameID in SAML assertion subject is used to perform login.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NameIdAttribute { get => this._nameIdAttribute; set => this._nameIdAttribute = value; }

        /// <summary>Backing field for <see cref="ServiceProviderMetaData" /> property.</summary>
        private Commvault.Powershell.Models.ISamlspMetaDataResp _serviceProviderMetaData;

        /// <summary>SAMLSPMetaDataResp</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ISamlspMetaDataResp ServiceProviderMetaData { get => (this._serviceProviderMetaData = this._serviceProviderMetaData ?? new Commvault.Powershell.Models.SamlspMetaDataResp()); set => this._serviceProviderMetaData = value; }

        /// <summary>Service provider entity</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ServiceProviderMetaDataEntityId { get => ((Commvault.Powershell.Models.ISamlspMetaDataRespInternal)ServiceProviderMetaData).EntityId; set => ((Commvault.Powershell.Models.ISamlspMetaDataRespInternal)ServiceProviderMetaData).EntityId = value ?? null; }

        /// <summary>single log out url</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ServiceProviderMetaDataSingleLogoutUrl { get => ((Commvault.Powershell.Models.ISamlspMetaDataRespInternal)ServiceProviderMetaData).SingleLogoutUrl; set => ((Commvault.Powershell.Models.ISamlspMetaDataRespInternal)ServiceProviderMetaData).SingleLogoutUrl = value ?? null; }

        /// <summary>single sign on URL</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ServiceProviderMetaDataSingleSignOnUrl { get => ((Commvault.Powershell.Models.ISamlspMetaDataRespInternal)ServiceProviderMetaData).SingleSignOnUrl; set => ((Commvault.Powershell.Models.ISamlspMetaDataRespInternal)ServiceProviderMetaData).SingleSignOnUrl = value ?? null; }

        /// <summary>Backing field for <see cref="UserGroup" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _userGroup;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName UserGroup { get => (this._userGroup = this._userGroup ?? new Commvault.Powershell.Models.IdName()); set => this._userGroup = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? UserGroupId { get => ((Commvault.Powershell.Models.IIdNameInternal)UserGroup).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)UserGroup).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserGroupName { get => ((Commvault.Powershell.Models.IIdNameInternal)UserGroup).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)UserGroup).Name = value ?? null; }

        /// <summary>Backing field for <see cref="UserGroups" /> property.</summary>
        private Commvault.Powershell.Models.ICompanyWithUserGroupAssocDetails[] _userGroups;

        /// <summary>
        /// By default, auto-created users will be associated to the Tenant Users group of the company. Add mapping to override this
        /// behaviour for a company.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.ICompanyWithUserGroupAssocDetails[] UserGroups { get => this._userGroups; set => this._userGroups = value; }

        /// <summary>Creates an new <see cref="Saml" /> instance.</summary>
        public Saml()
        {

        }
    }
    /// Get SAML response
    public partial interface ISaml :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Companies associated with SAML</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Companies associated with SAML",
        SerializedName = @"companies",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] AssociationCompanies { get; set; }
        /// <summary>Domains associated with SAML</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Domains associated with SAML",
        SerializedName = @"domains",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] AssociationDomains { get; set; }
        /// <summary>Email suffixes associated with SAML</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email suffixes associated with SAML",
        SerializedName = @"emailSuffixes",
        PossibleTypes = new [] { typeof(string) })]
        string[] AssociationEmailSuffixes { get; set; }
        /// <summary>user groups associated with SAML</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"user groups associated with SAML",
        SerializedName = @"userGroups",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] AssociationUserGroups { get; set; }
        /// <summary>attribute mapping details</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"attribute mapping details",
        SerializedName = @"attributeMappings",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ISamlAttributes) })]
        Commvault.Powershell.Models.ISamlAttributes[] AttributeMappings { get; set; }
        /// <summary>
        /// This auto-creates non-existing user if the user detail match with the identity rule.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This auto-creates non-existing user if the user detail match with the identity rule.",
        SerializedName = @"autoCreateUser",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AutoCreateUser { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? CreatedForCompanyId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedForCompanyName { get; set; }
        /// <summary>SAML description</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SAML description",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Boolean to indicate whether SAML is enabled.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Boolean to indicate whether SAML is enabled.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>Identity provider entity</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity provider entity",
        SerializedName = @"entityId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityProviderMetaDataEntityId { get; set; }
        /// <summary>Identity Provider log-out URL</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity Provider log-out URL",
        SerializedName = @"logoutUrl",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityProviderMetaDataLogoutUrl { get; set; }
        /// <summary>Identity provider redirect URL</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity provider redirect URL",
        SerializedName = @"redirectUrl",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityProviderMetaDataRedirectUrl { get; set; }
        /// <summary>SAML name.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SAML name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>nameID in SAML assertion subject is used to perform login.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"nameID in SAML assertion subject is used to perform login.",
        SerializedName = @"nameIDAttribute",
        PossibleTypes = new [] { typeof(string) })]
        string NameIdAttribute { get; set; }
        /// <summary>Service provider entity</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service provider entity",
        SerializedName = @"entityId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceProviderMetaDataEntityId { get; set; }
        /// <summary>single log out url</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"single log out url",
        SerializedName = @"singleLogoutUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceProviderMetaDataSingleLogoutUrl { get; set; }
        /// <summary>single sign on URL</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"single sign on URL",
        SerializedName = @"singleSignOnUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceProviderMetaDataSingleSignOnUrl { get; set; }

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
        /// <summary>
        /// By default, auto-created users will be associated to the Tenant Users group of the company. Add mapping to override this
        /// behaviour for a company.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"By default, auto-created users will be associated to the Tenant Users group of the company. Add mapping to override this behaviour for a company.",
        SerializedName = @"userGroups",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ICompanyWithUserGroupAssocDetails) })]
        Commvault.Powershell.Models.ICompanyWithUserGroupAssocDetails[] UserGroups { get; set; }

    }
    /// Get SAML response
    internal partial interface ISamlInternal

    {
        /// <summary>Companies associated with SAML</summary>
        Commvault.Powershell.Models.IIdName[] AssociationCompanies { get; set; }
        /// <summary>Domains associated with SAML</summary>
        Commvault.Powershell.Models.IIdName[] AssociationDomains { get; set; }
        /// <summary>Email suffixes associated with SAML</summary>
        string[] AssociationEmailSuffixes { get; set; }
        /// <summary>user groups associated with SAML</summary>
        Commvault.Powershell.Models.IIdName[] AssociationUserGroups { get; set; }
        /// <summary>SAMLAssociations</summary>
        Commvault.Powershell.Models.ISamlAssociations Associations { get; set; }
        /// <summary>attribute mapping details</summary>
        Commvault.Powershell.Models.ISamlAttributes[] AttributeMappings { get; set; }
        /// <summary>
        /// This auto-creates non-existing user if the user detail match with the identity rule.
        /// </summary>
        bool? AutoCreateUser { get; set; }

        Commvault.Powershell.Models.IIdName CreatedForCompany { get; set; }

        int? CreatedForCompanyId { get; set; }

        string CreatedForCompanyName { get; set; }
        /// <summary>SAML description</summary>
        string Description { get; set; }
        /// <summary>Boolean to indicate whether SAML is enabled.</summary>
        bool? Enabled { get; set; }
        /// <summary>SAML Identity provider meta data response</summary>
        Commvault.Powershell.Models.ISamlidpMetaDataResp IdentityProviderMetaData { get; set; }
        /// <summary>Identity provider entity</summary>
        string IdentityProviderMetaDataEntityId { get; set; }
        /// <summary>Identity Provider log-out URL</summary>
        string IdentityProviderMetaDataLogoutUrl { get; set; }
        /// <summary>Identity provider redirect URL</summary>
        string IdentityProviderMetaDataRedirectUrl { get; set; }
        /// <summary>SAML name.</summary>
        string Name { get; set; }
        /// <summary>nameID in SAML assertion subject is used to perform login.</summary>
        string NameIdAttribute { get; set; }
        /// <summary>SAMLSPMetaDataResp</summary>
        Commvault.Powershell.Models.ISamlspMetaDataResp ServiceProviderMetaData { get; set; }
        /// <summary>Service provider entity</summary>
        string ServiceProviderMetaDataEntityId { get; set; }
        /// <summary>single log out url</summary>
        string ServiceProviderMetaDataSingleLogoutUrl { get; set; }
        /// <summary>single sign on URL</summary>
        string ServiceProviderMetaDataSingleSignOnUrl { get; set; }

        Commvault.Powershell.Models.IIdName UserGroup { get; set; }

        int? UserGroupId { get; set; }

        string UserGroupName { get; set; }
        /// <summary>
        /// By default, auto-created users will be associated to the Tenant Users group of the company. Add mapping to override this
        /// behaviour for a company.
        /// </summary>
        Commvault.Powershell.Models.ICompanyWithUserGroupAssocDetails[] UserGroups { get; set; }

    }
}