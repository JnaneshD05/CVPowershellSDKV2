// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>List of identity servers</summary>
    public partial class IdentityServersListResp :
        Commvault.Powershell.Models.IIdentityServersListResp,
        Commvault.Powershell.Models.IIdentityServersListRespInternal
    {

        /// <summary>Backing field for <see cref="IdentityServers" /> property.</summary>
        private Commvault.Powershell.Models.IIdentityServer[] _identityServers;

        /// <summary>Identity servers list</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdentityServer[] IdentityServers { get => this._identityServers; set => this._identityServers = value; }

        /// <summary>Creates an new <see cref="IdentityServersListResp" /> instance.</summary>
        public IdentityServersListResp()
        {

        }
    }
    /// List of identity servers
    public partial interface IIdentityServersListResp :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Identity servers list</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity servers list",
        SerializedName = @"identityServers",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdentityServer) })]
        Commvault.Powershell.Models.IIdentityServer[] IdentityServers { get; set; }

    }
    /// List of identity servers
    internal partial interface IIdentityServersListRespInternal

    {
        /// <summary>Identity servers list</summary>
        Commvault.Powershell.Models.IIdentityServer[] IdentityServers { get; set; }

    }
}