// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// List of permissions associated with the entity. Either categoryId and categoryName or permissionId and permissionName
    /// will be returned. If categoryId or categoryName is returned, all the corresponding permissions in the category are associated
    /// with the entity.
    /// </summary>
    public partial class PermissionResp :
        Commvault.Powershell.Models.IPermissionResp,
        Commvault.Powershell.Models.IPermissionRespInternal
    {

        /// <summary>Backing field for <see cref="CategoryId" /> property.</summary>
        private int? _categoryId;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? CategoryId { get => this._categoryId; set => this._categoryId = value; }

        /// <summary>Backing field for <see cref="CategoryName" /> property.</summary>
        private string _categoryName;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CategoryName { get => this._categoryName; set => this._categoryName = value; }

        /// <summary>Backing field for <see cref="PermissionId" /> property.</summary>
        private int? _permissionId;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? PermissionId { get => this._permissionId; set => this._permissionId = value; }

        /// <summary>Backing field for <see cref="PermissionName" /> property.</summary>
        private string _permissionName;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string PermissionName { get => this._permissionName; set => this._permissionName = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Returns the type of association.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="PermissionResp" /> instance.</summary>
        public PermissionResp()
        {

        }
    }
    /// List of permissions associated with the entity. Either categoryId and categoryName or permissionId and permissionName
    /// will be returned. If categoryId or categoryName is returned, all the corresponding permissions in the category are associated
    /// with the entity.
    public partial interface IPermissionResp :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"categoryId",
        PossibleTypes = new [] { typeof(int) })]
        int? CategoryId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"categoryName",
        PossibleTypes = new [] { typeof(string) })]
        string CategoryName { get; set; }

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
        string Type { get; set; }

    }
    /// List of permissions associated with the entity. Either categoryId and categoryName or permissionId and permissionName
    /// will be returned. If categoryId or categoryName is returned, all the corresponding permissions in the category are associated
    /// with the entity.
    internal partial interface IPermissionRespInternal

    {
        int? CategoryId { get; set; }

        string CategoryName { get; set; }

        int? PermissionId { get; set; }

        string PermissionName { get; set; }
        /// <summary>Returns the type of association.</summary>
        string Type { get; set; }

    }
}