// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Replication options for Azure</summary>
    public partial class OverrideReplicationOptionsAzure :
        Commvault.Powershell.Models.IOverrideReplicationOptionsAzure,
        Commvault.Powershell.Models.IOverrideReplicationOptionsAzureInternal
    {

        /// <summary>Backing field for <see cref="VMDisplayName" /> property.</summary>
        private string _vMDisplayName;

        /// <summary>Display name of destination VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string VMDisplayName { get => this._vMDisplayName; set => this._vMDisplayName = value; }

        /// <summary>Creates an new <see cref="OverrideReplicationOptionsAzure" /> instance.</summary>
        public OverrideReplicationOptionsAzure()
        {

        }
    }
    /// Replication options for Azure
    public partial interface IOverrideReplicationOptionsAzure :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Display name of destination VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of destination VM",
        SerializedName = @"vmDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string VMDisplayName { get; set; }

    }
    /// Replication options for Azure
    internal partial interface IOverrideReplicationOptionsAzureInternal

    {
        /// <summary>Display name of destination VM</summary>
        string VMDisplayName { get; set; }

    }
}