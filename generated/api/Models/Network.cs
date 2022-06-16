// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Network interface for the destination instances</summary>
    public partial class Network :
        Commvault.Powershell.Models.INetwork,
        Commvault.Powershell.Models.INetworkInternal
    {

        /// <summary>Backing field for <see cref="NetworkDisplayName" /> property.</summary>
        private string _networkDisplayName;

        /// <summary>Network display name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NetworkDisplayName { get => this._networkDisplayName; set => this._networkDisplayName = value; }

        /// <summary>Backing field for <see cref="NetworkName" /> property.</summary>
        private string _networkName;

        /// <summary>Name of network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NetworkName { get => this._networkName; set => this._networkName = value; }

        /// <summary>Backing field for <see cref="SubnetId" /> property.</summary>
        private string _subnetId;

        /// <summary>subnet id of network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SubnetId { get => this._subnetId; set => this._subnetId = value; }

        /// <summary>Creates an new <see cref="Network" /> instance.</summary>
        public Network()
        {

        }
    }
    /// Network interface for the destination instances
    public partial interface INetwork :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Network display name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Network display name",
        SerializedName = @"networkDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkDisplayName { get; set; }
        /// <summary>Name of network</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of network",
        SerializedName = @"networkName",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkName { get; set; }
        /// <summary>subnet id of network</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"subnet id of network",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }

    }
    /// Network interface for the destination instances
    internal partial interface INetworkInternal

    {
        /// <summary>Network display name</summary>
        string NetworkDisplayName { get; set; }
        /// <summary>Name of network</summary>
        string NetworkName { get; set; }
        /// <summary>subnet id of network</summary>
        string SubnetId { get; set; }

    }
}