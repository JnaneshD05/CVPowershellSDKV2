// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Reference to a user and user group</summary>
    public partial class CredentialSecurityAssociations :
        Commvault.Powershell.Models.ICredentialSecurityAssociations,
        Commvault.Powershell.Models.ICredentialSecurityAssociationsInternal
    {

        /// <summary>Internal Acessors for Permissions</summary>
        Commvault.Powershell.Models.IPermissionResp Commvault.Powershell.Models.ICredentialSecurityAssociationsInternal.Permissions { get => (this._permissions = this._permissions ?? new Commvault.Powershell.Models.PermissionResp()); set { {_permissions = value;} } }

        /// <summary>Internal Acessors for User</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICredentialSecurityAssociationsInternal.User { get => (this._user = this._user ?? new Commvault.Powershell.Models.IdName()); set { {_user = value;} } }

        /// <summary>Internal Acessors for UserGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICredentialSecurityAssociationsInternal.UserGroup { get => (this._userGroup = this._userGroup ?? new Commvault.Powershell.Models.IdName()); set { {_userGroup = value;} } }

        /// <summary>Backing field for <see cref="IsCreatorAssociation" /> property.</summary>
        private bool? _isCreatorAssociation;

        /// <summary>To check if the user/user group associated is the owner.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? IsCreatorAssociation { get => this._isCreatorAssociation; set => this._isCreatorAssociation = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? PermissionCategoryId { get => ((Commvault.Powershell.Models.IPermissionRespInternal)Permissions).CategoryId; set => ((Commvault.Powershell.Models.IPermissionRespInternal)Permissions).CategoryId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PermissionCategoryName { get => ((Commvault.Powershell.Models.IPermissionRespInternal)Permissions).CategoryName; set => ((Commvault.Powershell.Models.IPermissionRespInternal)Permissions).CategoryName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? PermissionId { get => ((Commvault.Powershell.Models.IPermissionRespInternal)Permissions).PermissionId; set => ((Commvault.Powershell.Models.IPermissionRespInternal)Permissions).PermissionId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PermissionName { get => ((Commvault.Powershell.Models.IPermissionRespInternal)Permissions).PermissionName; set => ((Commvault.Powershell.Models.IPermissionRespInternal)Permissions).PermissionName = value ?? null; }

        /// <summary>Returns the type of association.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PermissionType { get => ((Commvault.Powershell.Models.IPermissionRespInternal)Permissions).Type; set => ((Commvault.Powershell.Models.IPermissionRespInternal)Permissions).Type = value ?? null; }

        /// <summary>Backing field for <see cref="Permissions" /> property.</summary>
        private Commvault.Powershell.Models.IPermissionResp _permissions;

        /// <summary>
        /// List of permissions associated with the entity. Either categoryId and categoryName or permissionId and permissionName
        /// will be returned. If categoryId or categoryName is returned, all the corresponding permissions in the category are associated
        /// with the entity.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IPermissionResp Permissions { get => (this._permissions = this._permissions ?? new Commvault.Powershell.Models.PermissionResp()); set => this._permissions = value; }

        /// <summary>Backing field for <see cref="User" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _user;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName User { get => (this._user = this._user ?? new Commvault.Powershell.Models.IdName()); set => this._user = value; }

        /// <summary>Backing field for <see cref="UserGroup" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _userGroup;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName UserGroup { get => (this._userGroup = this._userGroup ?? new Commvault.Powershell.Models.IdName()); set => this._userGroup = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? UserGroupId { get => ((Commvault.Powershell.Models.IIdNameInternal)UserGroup).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)UserGroup).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserGroupName { get => ((Commvault.Powershell.Models.IIdNameInternal)UserGroup).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)UserGroup).Name = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? UserId { get => ((Commvault.Powershell.Models.IIdNameInternal)User).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)User).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserName { get => ((Commvault.Powershell.Models.IIdNameInternal)User).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)User).Name = value ?? null; }

        /// <summary>Creates an new <see cref="CredentialSecurityAssociations" /> instance.</summary>
        public CredentialSecurityAssociations()
        {

        }
    }
    /// Reference to a user and user group
    public partial interface ICredentialSecurityAssociations :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>To check if the user/user group associated is the owner.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"To check if the user/user group associated is the owner.",
        SerializedName = @"isCreatorAssociation",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsCreatorAssociation { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"categoryId",
        PossibleTypes = new [] { typeof(int) })]
        int? PermissionCategoryId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"categoryName",
        PossibleTypes = new [] { typeof(string) })]
        string PermissionCategoryName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"permissionId",
        PossibleTypes = new [] { typeof(int) })]
        int? PermissionId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"permissionName",
        PossibleTypes = new [] { typeof(string) })]
        string PermissionName { get; set; }
        /// <summary>Returns the type of association.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Returns the type of association.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string PermissionType { get; set; }

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
    /// Reference to a user and user group
    internal partial interface ICredentialSecurityAssociationsInternal

    {
        /// <summary>To check if the user/user group associated is the owner.</summary>
        bool? IsCreatorAssociation { get; set; }

        int? PermissionCategoryId { get; set; }

        string PermissionCategoryName { get; set; }

        int? PermissionId { get; set; }

        string PermissionName { get; set; }
        /// <summary>Returns the type of association.</summary>
        string PermissionType { get; set; }
        /// <summary>
        /// List of permissions associated with the entity. Either categoryId and categoryName or permissionId and permissionName
        /// will be returned. If categoryId or categoryName is returned, all the corresponding permissions in the category are associated
        /// with the entity.
        /// </summary>
        Commvault.Powershell.Models.IPermissionResp Permissions { get; set; }

        Commvault.Powershell.Models.IIdName User { get; set; }

        Commvault.Powershell.Models.IIdName UserGroup { get; set; }

        int? UserGroupId { get; set; }

        string UserGroupName { get; set; }

        int? UserId { get; set; }

        string UserName { get; set; }

    }
}