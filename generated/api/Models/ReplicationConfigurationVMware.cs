// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Replication configuration for VMware</summary>
    public partial class ReplicationConfigurationVMware :
        Commvault.Powershell.Models.IReplicationConfigurationVMware,
        Commvault.Powershell.Models.IReplicationConfigurationVMwareInternal
    {

        /// <summary>Internal Acessors for OverrideReplicationOptions</summary>
        Commvault.Powershell.Models.IOverrideReplicationOptionsVMWare Commvault.Powershell.Models.IReplicationConfigurationVMwareInternal.OverrideReplicationOptions { get => (this._overrideReplicationOptions = this._overrideReplicationOptions ?? new Commvault.Powershell.Models.OverrideReplicationOptionsVMWare()); set { {_overrideReplicationOptions = value;} } }

        /// <summary>Backing field for <see cref="Datastore" /> property.</summary>
        private string _datastore;

        /// <summary>Select a datastore to be used for virtual machine disks</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Datastore { get => this._datastore; set => this._datastore = value; }

        /// <summary>Backing field for <see cref="DestinationHost" /> property.</summary>
        private string _destinationHost;

        /// <summary>Destination hypervisor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DestinationHost { get => this._destinationHost; set => this._destinationHost = value; }

        /// <summary>Backing field for <see cref="DestinationVM" /> property.</summary>
        private string _destinationVM;

        /// <summary>The replicated VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DestinationVM { get => this._destinationVM; set => this._destinationVM = value; }

        /// <summary>Select a datastore to be used for virtual machine disks</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string OverrideReplicationOptionDatastore { get => ((Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal)OverrideReplicationOptions).Datastore; set => ((Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal)OverrideReplicationOptions).Datastore = value ?? null; }

        /// <summary>Host for the destination VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string OverrideReplicationOptionDestinationHost { get => ((Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal)OverrideReplicationOptions).DestinationHost; set => ((Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal)OverrideReplicationOptions).DestinationHost = value ?? null; }

        /// <summary>Customize IP address settings</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IIPAddressSetting[] OverrideReplicationOptionIPAddressSettings { get => ((Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal)OverrideReplicationOptions).IPAddressSettings; set => ((Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal)OverrideReplicationOptions).IPAddressSettings = value ?? null /* arrayOf */; }

        /// <summary>Mapping between a source network and a destination network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.INetworkSetting[] OverrideReplicationOptionNetworkSettings { get => ((Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal)OverrideReplicationOptions).NetworkSettings; set => ((Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal)OverrideReplicationOptions).NetworkSettings = value ?? null /* arrayOf */; }

        /// <summary>Select a resource pool for the destination VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string OverrideReplicationOptionResourcePool { get => ((Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal)OverrideReplicationOptions).ResourcePool; set => ((Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal)OverrideReplicationOptions).ResourcePool = value ?? null; }

        /// <summary>Enter the display name for the destination VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string OverrideReplicationOptionVMDisplayName { get => ((Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal)OverrideReplicationOptions).VMDisplayName; set => ((Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal)OverrideReplicationOptions).VMDisplayName = value ?? null; }

        /// <summary>VM folder replication</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string OverrideReplicationOptionVMFolder { get => ((Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal)OverrideReplicationOptions).VMFolder; set => ((Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareInternal)OverrideReplicationOptions).VMFolder = value ?? null; }

        /// <summary>Backing field for <see cref="OverrideReplicationOptions" /> property.</summary>
        private Commvault.Powershell.Models.IOverrideReplicationOptionsVMWare _overrideReplicationOptions;

        /// <summary>Replication options for VMware</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IOverrideReplicationOptionsVMWare OverrideReplicationOptions { get => (this._overrideReplicationOptions = this._overrideReplicationOptions ?? new Commvault.Powershell.Models.OverrideReplicationOptionsVMWare()); set => this._overrideReplicationOptions = value; }

        /// <summary>Backing field for <see cref="SourceVM" /> property.</summary>
        private string _sourceVM;

        /// <summary>The source VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SourceVM { get => this._sourceVM; set => this._sourceVM = value; }

        /// <summary>Creates an new <see cref="ReplicationConfigurationVMware" /> instance.</summary>
        public ReplicationConfigurationVMware()
        {

        }
    }
    /// Replication configuration for VMware
    public partial interface IReplicationConfigurationVMware :
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
        /// <summary>Destination hypervisor</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Destination hypervisor",
        SerializedName = @"destinationHost",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationHost { get; set; }
        /// <summary>The replicated VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The replicated VM",
        SerializedName = @"destinationVM",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationVM { get; set; }
        /// <summary>Select a datastore to be used for virtual machine disks</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Select a datastore to be used for virtual machine disks",
        SerializedName = @"datastore",
        PossibleTypes = new [] { typeof(string) })]
        string OverrideReplicationOptionDatastore { get; set; }
        /// <summary>Host for the destination VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Host for the destination VM",
        SerializedName = @"destinationHost",
        PossibleTypes = new [] { typeof(string) })]
        string OverrideReplicationOptionDestinationHost { get; set; }
        /// <summary>Customize IP address settings</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Customize IP address settings",
        SerializedName = @"ipAddressSettings",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIPAddressSetting) })]
        Commvault.Powershell.Models.IIPAddressSetting[] OverrideReplicationOptionIPAddressSettings { get; set; }
        /// <summary>Mapping between a source network and a destination network</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mapping between a source network and a destination network",
        SerializedName = @"networkSettings",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.INetworkSetting) })]
        Commvault.Powershell.Models.INetworkSetting[] OverrideReplicationOptionNetworkSettings { get; set; }
        /// <summary>Select a resource pool for the destination VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Select a resource pool for the destination VM",
        SerializedName = @"resourcePool",
        PossibleTypes = new [] { typeof(string) })]
        string OverrideReplicationOptionResourcePool { get; set; }
        /// <summary>Enter the display name for the destination VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enter the display name for the destination VM",
        SerializedName = @"vmDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string OverrideReplicationOptionVMDisplayName { get; set; }
        /// <summary>VM folder replication</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"VM folder replication",
        SerializedName = @"vmFolder",
        PossibleTypes = new [] { typeof(string) })]
        string OverrideReplicationOptionVMFolder { get; set; }
        /// <summary>The source VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The source VM",
        SerializedName = @"sourceVM",
        PossibleTypes = new [] { typeof(string) })]
        string SourceVM { get; set; }

    }
    /// Replication configuration for VMware
    internal partial interface IReplicationConfigurationVMwareInternal

    {
        /// <summary>Select a datastore to be used for virtual machine disks</summary>
        string Datastore { get; set; }
        /// <summary>Destination hypervisor</summary>
        string DestinationHost { get; set; }
        /// <summary>The replicated VM</summary>
        string DestinationVM { get; set; }
        /// <summary>Select a datastore to be used for virtual machine disks</summary>
        string OverrideReplicationOptionDatastore { get; set; }
        /// <summary>Host for the destination VM</summary>
        string OverrideReplicationOptionDestinationHost { get; set; }
        /// <summary>Customize IP address settings</summary>
        Commvault.Powershell.Models.IIPAddressSetting[] OverrideReplicationOptionIPAddressSettings { get; set; }
        /// <summary>Mapping between a source network and a destination network</summary>
        Commvault.Powershell.Models.INetworkSetting[] OverrideReplicationOptionNetworkSettings { get; set; }
        /// <summary>Select a resource pool for the destination VM</summary>
        string OverrideReplicationOptionResourcePool { get; set; }
        /// <summary>Enter the display name for the destination VM</summary>
        string OverrideReplicationOptionVMDisplayName { get; set; }
        /// <summary>VM folder replication</summary>
        string OverrideReplicationOptionVMFolder { get; set; }
        /// <summary>Replication options for VMware</summary>
        Commvault.Powershell.Models.IOverrideReplicationOptionsVMWare OverrideReplicationOptions { get; set; }
        /// <summary>The source VM</summary>
        string SourceVM { get; set; }

    }
}