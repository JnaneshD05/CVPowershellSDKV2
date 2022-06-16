// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Used to provide the entities associated.</summary>
    public partial class AssocEntity :
        Commvault.Powershell.Models.IAssocEntity,
        Commvault.Powershell.Models.IAssocEntityInternal
    {

        /// <summary>Internal Acessors for PermissionList</summary>
        Commvault.Powershell.Models.IPermissionResp Commvault.Powershell.Models.IAssocEntityInternal.PermissionList { get => (this._permissionList = this._permissionList ?? new Commvault.Powershell.Models.PermissionResp()); set { {_permissionList = value;} } }

        /// <summary>Internal Acessors for Role</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IAssocEntityInternal.Role { get => (this._role = this._role ?? new Commvault.Powershell.Models.IdName()); set { {_role = value;} } }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="PermissionList" /> property.</summary>
        private Commvault.Powershell.Models.IPermissionResp _permissionList;

        /// <summary>
        /// List of permissions associated with the entity. Either categoryId and categoryName or permissionId and permissionName
        /// will be returned. If categoryId or categoryName is returned, all the corresponding permissions in the category are associated
        /// with the entity.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IPermissionResp PermissionList { get => (this._permissionList = this._permissionList ?? new Commvault.Powershell.Models.PermissionResp()); set => this._permissionList = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? PermissionListCategoryId { get => ((Commvault.Powershell.Models.IPermissionRespInternal)PermissionList).CategoryId; set => ((Commvault.Powershell.Models.IPermissionRespInternal)PermissionList).CategoryId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PermissionListCategoryName { get => ((Commvault.Powershell.Models.IPermissionRespInternal)PermissionList).CategoryName; set => ((Commvault.Powershell.Models.IPermissionRespInternal)PermissionList).CategoryName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? PermissionListPermissionId { get => ((Commvault.Powershell.Models.IPermissionRespInternal)PermissionList).PermissionId; set => ((Commvault.Powershell.Models.IPermissionRespInternal)PermissionList).PermissionId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PermissionListPermissionName { get => ((Commvault.Powershell.Models.IPermissionRespInternal)PermissionList).PermissionName; set => ((Commvault.Powershell.Models.IPermissionRespInternal)PermissionList).PermissionName = value ?? null; }

        /// <summary>Returns the type of association.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PermissionListType { get => ((Commvault.Powershell.Models.IPermissionRespInternal)PermissionList).Type; set => ((Commvault.Powershell.Models.IPermissionRespInternal)PermissionList).Type = value ?? null; }

        /// <summary>Backing field for <see cref="Role" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _role;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Role { get => (this._role = this._role ?? new Commvault.Powershell.Models.IdName()); set => this._role = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? RoleId { get => ((Commvault.Powershell.Models.IIdNameInternal)Role).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Role).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RoleName { get => ((Commvault.Powershell.Models.IIdNameInternal)Role).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Role).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>type of entities associated.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="AssocEntity" /> instance.</summary>
        public AssocEntity()
        {

        }
    }
    /// Used to provide the entities associated.
    public partial interface IAssocEntity :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"categoryId",
        PossibleTypes = new [] { typeof(int) })]
        int? PermissionListCategoryId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"categoryName",
        PossibleTypes = new [] { typeof(string) })]
        string PermissionListCategoryName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"permissionId",
        PossibleTypes = new [] { typeof(int) })]
        int? PermissionListPermissionId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"permissionName",
        PossibleTypes = new [] { typeof(string) })]
        string PermissionListPermissionName { get; set; }
        /// <summary>Returns the type of association.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Returns the type of association.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string PermissionListType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? RoleId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string RoleName { get; set; }
        /// <summary>type of entities associated.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"type of entities associated.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Used to provide the entities associated.
    internal partial interface IAssocEntityInternal

    {
        int? Id { get; set; }

        string Name { get; set; }
        /// <summary>
        /// List of permissions associated with the entity. Either categoryId and categoryName or permissionId and permissionName
        /// will be returned. If categoryId or categoryName is returned, all the corresponding permissions in the category are associated
        /// with the entity.
        /// </summary>
        Commvault.Powershell.Models.IPermissionResp PermissionList { get; set; }

        int? PermissionListCategoryId { get; set; }

        string PermissionListCategoryName { get; set; }

        int? PermissionListPermissionId { get; set; }

        string PermissionListPermissionName { get; set; }
        /// <summary>Returns the type of association.</summary>
        string PermissionListType { get; set; }

        Commvault.Powershell.Models.IIdName Role { get; set; }

        int? RoleId { get; set; }

        string RoleName { get; set; }
        /// <summary>type of entities associated.</summary>
        string Type { get; set; }

    }
}