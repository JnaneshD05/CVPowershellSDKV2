// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>List of roles</summary>
    public partial class RoleListResponse :
        Commvault.Powershell.Models.IRoleListResponse,
        Commvault.Powershell.Models.IRoleListResponseInternal
    {

        /// <summary>Backing field for <see cref="Roles" /> property.</summary>
        private Commvault.Powershell.Models.IRoleSummary[] _roles;

        /// <summary>List of all the existing roles</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IRoleSummary[] Roles { get => this._roles; set => this._roles = value; }

        /// <summary>Creates an new <see cref="RoleListResponse" /> instance.</summary>
        public RoleListResponse()
        {

        }
    }
    /// List of roles
    public partial interface IRoleListResponse :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>List of all the existing roles</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of all the existing roles",
        SerializedName = @"roles",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IRoleSummary) })]
        Commvault.Powershell.Models.IRoleSummary[] Roles { get; set; }

    }
    /// List of roles
    internal partial interface IRoleListResponseInternal

    {
        /// <summary>List of all the existing roles</summary>
        Commvault.Powershell.Models.IRoleSummary[] Roles { get; set; }

    }
}