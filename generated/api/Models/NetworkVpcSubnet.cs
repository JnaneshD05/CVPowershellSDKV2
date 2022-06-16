// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Network info</summary>
    public partial class NetworkVpcSubnet :
        Commvault.Powershell.Models.INetworkVpcSubnet,
        Commvault.Powershell.Models.INetworkVpcSubnetInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="SubnetId" /> property.</summary>
        private string _subnetId;

        /// <summary>The ID of the subnet</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SubnetId { get => this._subnetId; set => this._subnetId = value; }

        /// <summary>Backing field for <see cref="Vpc" /> property.</summary>
        private string _vpc;

        /// <summary>The ID of the VPC</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Vpc { get => this._vpc; set => this._vpc = value; }

        /// <summary>Creates an new <see cref="NetworkVpcSubnet" /> instance.</summary>
        public NetworkVpcSubnet()
        {

        }
    }
    /// Network info
    public partial interface INetworkVpcSubnet :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>The name of the network</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the network",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The ID of the subnet</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the subnet",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }
        /// <summary>The ID of the VPC</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the VPC",
        SerializedName = @"vpc",
        PossibleTypes = new [] { typeof(string) })]
        string Vpc { get; set; }

    }
    /// Network info
    internal partial interface INetworkVpcSubnetInternal

    {
        /// <summary>The name of the network</summary>
        string Name { get; set; }
        /// <summary>The ID of the subnet</summary>
        string SubnetId { get; set; }
        /// <summary>The ID of the VPC</summary>
        string Vpc { get; set; }

    }
}