// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Replication options for VMware</summary>
    public partial class OverrideReplicationOptionsVMWare :
        Commvault.Powershell.Models.IOverrideReplicationOptionsVMWare,
        Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal
    {

        /// <summary>Backing field for <see cref="Datastore" /> property.</summary>
        private string _datastore;

        /// <summary>Select a datastore to be used for virtual machine disks</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Datastore { get => this._datastore; set => this._datastore = value; }

        /// <summary>Backing field for <see cref="DestinationHost" /> property.</summary>
        private string _destinationHost;

        /// <summary>Host for the destination VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DestinationHost { get => this._destinationHost; set => this._destinationHost = value; }

        /// <summary>Backing field for <see cref="IPAddressSettings" /> property.</summary>
        private Commvault.Powershell.Models.IIPAddressSetting[] _iPAddressSettings;

        /// <summary>Customize IP address settings</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIPAddressSetting[] IPAddressSettings { get => this._iPAddressSettings; set => this._iPAddressSettings = value; }

        /// <summary>Backing field for <see cref="NetworkSettings" /> property.</summary>
        private Commvault.Powershell.Models.INetworkSetting[] _networkSettings;

        /// <summary>Mapping between a source network and a destination network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.INetworkSetting[] NetworkSettings { get => this._networkSettings; set => this._networkSettings = value; }

        /// <summary>Backing field for <see cref="ResourcePool" /> property.</summary>
        private string _resourcePool;

        /// <summary>Select a resource pool for the destination VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ResourcePool { get => this._resourcePool; set => this._resourcePool = value; }

        /// <summary>Backing field for <see cref="VMDisplayName" /> property.</summary>
        private string _vMDisplayName;

        /// <summary>Enter the display name for the destination VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string VMDisplayName { get => this._vMDisplayName; set => this._vMDisplayName = value; }

        /// <summary>Backing field for <see cref="VMFolder" /> property.</summary>
        private string _vMFolder;

        /// <summary>VM folder replication</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string VMFolder { get => this._vMFolder; set => this._vMFolder = value; }

        /// <summary>Creates an new <see cref="OverrideReplicationOptionsVMWare" /> instance.</summary>
        public OverrideReplicationOptionsVMWare()
        {

        }
    }
    /// Replication options for VMware
    public partial interface IOverrideReplicationOptionsVMWare :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Select a datastore to be used for virtual machine disks</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Select a datastore to be used for virtual machine disks",
        SerializedName = @"datastore",
        PossibleTypes = new [] { typeof(string) })]
        string Datastore { get; set; }
        /// <summary>Host for the destination VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Host for the destination VM",
        SerializedName = @"destinationHost",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationHost { get; set; }
        /// <summary>Customize IP address settings</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Customize IP address settings",
        SerializedName = @"ipAddressSettings",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIPAddressSetting) })]
        Commvault.Powershell.Models.IIPAddressSetting[] IPAddressSettings { get; set; }
        /// <summary>Mapping between a source network and a destination network</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mapping between a source network and a destination network",
        SerializedName = @"networkSettings",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.INetworkSetting) })]
        Commvault.Powershell.Models.INetworkSetting[] NetworkSettings { get; set; }
        /// <summary>Select a resource pool for the destination VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Select a resource pool for the destination VM",
        SerializedName = @"resourcePool",
        PossibleTypes = new [] { typeof(string) })]
        string ResourcePool { get; set; }
        /// <summary>Enter the display name for the destination VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enter the display name for the destination VM",
        SerializedName = @"vmDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string VMDisplayName { get; set; }
        /// <summary>VM folder replication</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"VM folder replication",
        SerializedName = @"vmFolder",
        PossibleTypes = new [] { typeof(string) })]
        string VMFolder { get; set; }

    }
    /// Replication options for VMware
    internal partial interface IOverrideReplicationOptionsVMWareInternal

    {
        /// <summary>Select a datastore to be used for virtual machine disks</summary>
        string Datastore { get; set; }
        /// <summary>Host for the destination VM</summary>
        string DestinationHost { get; set; }
        /// <summary>Customize IP address settings</summary>
        Commvault.Powershell.Models.IIPAddressSetting[] IPAddressSettings { get; set; }
        /// <summary>Mapping between a source network and a destination network</summary>
        Commvault.Powershell.Models.INetworkSetting[] NetworkSettings { get; set; }
        /// <summary>Select a resource pool for the destination VM</summary>
        string ResourcePool { get; set; }
        /// <summary>Enter the display name for the destination VM</summary>
        string VMDisplayName { get; set; }
        /// <summary>VM folder replication</summary>
        string VMFolder { get; set; }

    }
}