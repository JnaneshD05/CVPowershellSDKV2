// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Replication options for Amazon</summary>
    public partial class OverrideReplicationOptionsAmazon :
        Commvault.Powershell.Models.IOverrideReplicationOptionsAmazon,
        Commvault.Powershell.Models.IOverrideReplicationOptionsAmazonInternal
    {

        /// <summary>Backing field for <see cref="AutoSelectSecurityGroup" /> property.</summary>
        private Commvault.Powershell.Models.ISecurityGroup[] _autoSelectSecurityGroup;

        /// <summary>Select a security group for the destination instances</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.ISecurityGroup[] AutoSelectSecurityGroup { get => this._autoSelectSecurityGroup; set => this._autoSelectSecurityGroup = value; }

        /// <summary>Backing field for <see cref="AvailabilityZone" /> property.</summary>
        private string _availabilityZone;

        /// <summary>Destination zone</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string AvailabilityZone { get => this._availabilityZone; set => this._availabilityZone = value; }

        /// <summary>Internal Acessors for Network</summary>
        Commvault.Powershell.Models.INetwork Commvault.Powershell.Models.IOverrideReplicationOptionsAmazonInternal.Network { get => (this._network = this._network ?? new Commvault.Powershell.Models.Network()); set { {_network = value;} } }

        /// <summary>Backing field for <see cref="ComputerName" /> property.</summary>
        private string _computerName;

        /// <summary>Enable required drivers to be installed on the Amazon guest instance</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ComputerName { get => this._computerName; set => this._computerName = value; }

        /// <summary>Backing field for <see cref="EncryptionKey" /> property.</summary>
        private string _encryptionKey;

        /// <summary>Encryption key if used</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string EncryptionKey { get => this._encryptionKey; set => this._encryptionKey = value; }

        /// <summary>Backing field for <see cref="InstanceName" /> property.</summary>
        private string _instanceName;

        /// <summary>Display name for the destination instance</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string InstanceName { get => this._instanceName; set => this._instanceName = value; }

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>Provides the available CPU cores and memory for the instance.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>Backing field for <see cref="Network" /> property.</summary>
        private Commvault.Powershell.Models.INetwork _network;

        /// <summary>Network interface for the destination instances</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.INetwork Network { get => (this._network = this._network ?? new Commvault.Powershell.Models.Network()); set => this._network = value; }

        /// <summary>Network display name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string NetworkDisplayName { get => ((Commvault.Powershell.Models.INetworkInternal)Network).NetworkDisplayName; set => ((Commvault.Powershell.Models.INetworkInternal)Network).NetworkDisplayName = value ?? null; }

        /// <summary>Name of network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string NetworkName { get => ((Commvault.Powershell.Models.INetworkInternal)Network).NetworkName; set => ((Commvault.Powershell.Models.INetworkInternal)Network).NetworkName = value ?? null; }

        /// <summary>subnet id of network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string NetworkSubnetId { get => ((Commvault.Powershell.Models.INetworkInternal)Network).SubnetId; set => ((Commvault.Powershell.Models.INetworkInternal)Network).SubnetId = value ?? null; }

        /// <summary>Backing field for <see cref="UserName" /> property.</summary>
        private string _userName;

        /// <summary>Enable required drivers to be installed on the Amazon guest instance</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UserName { get => this._userName; set => this._userName = value; }

        /// <summary>Backing field for <see cref="VolumeType" /> property.</summary>
        private string _volumeType;

        /// <summary>Type of volume used for replication</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string VolumeType { get => this._volumeType; set => this._volumeType = value; }

        /// <summary>Creates an new <see cref="OverrideReplicationOptionsAmazon" /> instance.</summary>
        public OverrideReplicationOptionsAmazon()
        {

        }
    }
    /// Replication options for Amazon
    public partial interface IOverrideReplicationOptionsAmazon :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Select a security group for the destination instances</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Select a security group for the destination instances",
        SerializedName = @"autoSelectSecurityGroup",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ISecurityGroup) })]
        Commvault.Powershell.Models.ISecurityGroup[] AutoSelectSecurityGroup { get; set; }
        /// <summary>Destination zone</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Destination zone",
        SerializedName = @"availabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string AvailabilityZone { get; set; }
        /// <summary>Enable required drivers to be installed on the Amazon guest instance</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable required drivers to be installed on the Amazon guest instance",
        SerializedName = @"computerName",
        PossibleTypes = new [] { typeof(string) })]
        string ComputerName { get; set; }
        /// <summary>Encryption key if used</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Encryption key if used",
        SerializedName = @"encryptionKey",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionKey { get; set; }
        /// <summary>Display name for the destination instance</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name for the destination instance",
        SerializedName = @"instanceName",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceName { get; set; }
        /// <summary>Provides the available CPU cores and memory for the instance.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provides the available CPU cores and memory for the instance.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }
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
        string NetworkSubnetId { get; set; }
        /// <summary>Enable required drivers to be installed on the Amazon guest instance</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable required drivers to be installed on the Amazon guest instance",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }
        /// <summary>Type of volume used for replication</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of volume used for replication",
        SerializedName = @"volumeType",
        PossibleTypes = new [] { typeof(string) })]
        string VolumeType { get; set; }

    }
    /// Replication options for Amazon
    internal partial interface IOverrideReplicationOptionsAmazonInternal

    {
        /// <summary>Select a security group for the destination instances</summary>
        Commvault.Powershell.Models.ISecurityGroup[] AutoSelectSecurityGroup { get; set; }
        /// <summary>Destination zone</summary>
        string AvailabilityZone { get; set; }
        /// <summary>Enable required drivers to be installed on the Amazon guest instance</summary>
        string ComputerName { get; set; }
        /// <summary>Encryption key if used</summary>
        string EncryptionKey { get; set; }
        /// <summary>Display name for the destination instance</summary>
        string InstanceName { get; set; }
        /// <summary>Provides the available CPU cores and memory for the instance.</summary>
        string InstanceType { get; set; }
        /// <summary>Network interface for the destination instances</summary>
        Commvault.Powershell.Models.INetwork Network { get; set; }
        /// <summary>Network display name</summary>
        string NetworkDisplayName { get; set; }
        /// <summary>Name of network</summary>
        string NetworkName { get; set; }
        /// <summary>subnet id of network</summary>
        string NetworkSubnetId { get; set; }
        /// <summary>Enable required drivers to be installed on the Amazon guest instance</summary>
        string UserName { get; set; }
        /// <summary>Type of volume used for replication</summary>
        string VolumeType { get; set; }

    }
}