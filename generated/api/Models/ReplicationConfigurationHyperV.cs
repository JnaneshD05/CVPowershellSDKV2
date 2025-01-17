// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Replication configuration for HyperV</summary>
    public partial class ReplicationConfigurationHyperV :
        Commvault.Powershell.Models.IReplicationConfigurationHyperV,
        Commvault.Powershell.Models.IReplicationConfigurationHyperVInternal
    {

        /// <summary>Internal Acessors for OverrideReplicationOptions</summary>
        Commvault.Powershell.Models.IOverrideReplicationOptionsHyperV Commvault.Powershell.Models.IReplicationConfigurationHyperVInternal.OverrideReplicationOptions { get => (this._overrideReplicationOptions = this._overrideReplicationOptions ?? new Commvault.Powershell.Models.OverrideReplicationOptionsHyperV()); set { {_overrideReplicationOptions = value;} } }

        /// <summary>Backing field for <see cref="DestinationVM" /> property.</summary>
        private string _destinationVM;

        /// <summary>Destination VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DestinationVM { get => this._destinationVM; set => this._destinationVM = value; }

        /// <summary>Backing field for <see cref="DestinationVolume" /> property.</summary>
        private string _destinationVolume;

        /// <summary>Destination volume for hyperV</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DestinationVolume { get => this._destinationVolume; set => this._destinationVolume = value; }

        /// <summary>Backing field for <see cref="HypervHost" /> property.</summary>
        private string _hypervHost;

        /// <summary>Hypervisor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string HypervHost { get => this._hypervHost; set => this._hypervHost = value; }

        /// <summary>Select a network interface from the Network adapter list</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.INetworkName[] OverrideReplicationOptionNetworkAdapter { get => ((Commvault.Powershell.Models.IOverrideReplicationOptionsHyperVInternal)OverrideReplicationOptions).NetworkAdapter; set => ((Commvault.Powershell.Models.IOverrideReplicationOptionsHyperVInternal)OverrideReplicationOptions).NetworkAdapter = value ?? null /* arrayOf */; }

        /// <summary>
        /// Register replicated virtual machines to the failover cluster for the destination client.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string OverrideReplicationOptionRegisterVMWithFailoverCluster { get => ((Commvault.Powershell.Models.IOverrideReplicationOptionsHyperVInternal)OverrideReplicationOptions).RegisterVMWithFailoverCluster; set => ((Commvault.Powershell.Models.IOverrideReplicationOptionsHyperVInternal)OverrideReplicationOptions).RegisterVMWithFailoverCluster = value ?? null; }

        /// <summary>Display name for the destination VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string OverrideReplicationOptionVMDisplayName { get => ((Commvault.Powershell.Models.IOverrideReplicationOptionsHyperVInternal)OverrideReplicationOptions).VMDisplayName; set => ((Commvault.Powershell.Models.IOverrideReplicationOptionsHyperVInternal)OverrideReplicationOptions).VMDisplayName = value ?? null; }

        /// <summary>Backing field for <see cref="OverrideReplicationOptions" /> property.</summary>
        private Commvault.Powershell.Models.IOverrideReplicationOptionsHyperV _overrideReplicationOptions;

        /// <summary>Replication options for HyperV</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IOverrideReplicationOptionsHyperV OverrideReplicationOptions { get => (this._overrideReplicationOptions = this._overrideReplicationOptions ?? new Commvault.Powershell.Models.OverrideReplicationOptionsHyperV()); set => this._overrideReplicationOptions = value; }

        /// <summary>Backing field for <see cref="SourceVM" /> property.</summary>
        private string _sourceVM;

        /// <summary>Source VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SourceVM { get => this._sourceVM; set => this._sourceVM = value; }

        /// <summary>Creates an new <see cref="ReplicationConfigurationHyperV" /> instance.</summary>
        public ReplicationConfigurationHyperV()
        {

        }
    }
    /// Replication configuration for HyperV
    public partial interface IReplicationConfigurationHyperV :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Destination VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Destination VM",
        SerializedName = @"destinationVM",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationVM { get; set; }
        /// <summary>Destination volume for hyperV</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Destination volume for hyperV",
        SerializedName = @"destinationVolume",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationVolume { get; set; }
        /// <summary>Hypervisor</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Hypervisor",
        SerializedName = @"hypervHost",
        PossibleTypes = new [] { typeof(string) })]
        string HypervHost { get; set; }
        /// <summary>Select a network interface from the Network adapter list</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Select a network interface from the Network adapter list",
        SerializedName = @"networkAdapter",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.INetworkName) })]
        Commvault.Powershell.Models.INetworkName[] OverrideReplicationOptionNetworkAdapter { get; set; }
        /// <summary>
        /// Register replicated virtual machines to the failover cluster for the destination client.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Register replicated virtual machines to the failover cluster for the destination client.",
        SerializedName = @"registerVMWithFailoverCluster",
        PossibleTypes = new [] { typeof(string) })]
        string OverrideReplicationOptionRegisterVMWithFailoverCluster { get; set; }
        /// <summary>Display name for the destination VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name for the destination VM",
        SerializedName = @"vmDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string OverrideReplicationOptionVMDisplayName { get; set; }
        /// <summary>Source VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Source VM",
        SerializedName = @"sourceVM",
        PossibleTypes = new [] { typeof(string) })]
        string SourceVM { get; set; }

    }
    /// Replication configuration for HyperV
    internal partial interface IReplicationConfigurationHyperVInternal

    {
        /// <summary>Destination VM</summary>
        string DestinationVM { get; set; }
        /// <summary>Destination volume for hyperV</summary>
        string DestinationVolume { get; set; }
        /// <summary>Hypervisor</summary>
        string HypervHost { get; set; }
        /// <summary>Select a network interface from the Network adapter list</summary>
        Commvault.Powershell.Models.INetworkName[] OverrideReplicationOptionNetworkAdapter { get; set; }
        /// <summary>
        /// Register replicated virtual machines to the failover cluster for the destination client.
        /// </summary>
        string OverrideReplicationOptionRegisterVMWithFailoverCluster { get; set; }
        /// <summary>Display name for the destination VM</summary>
        string OverrideReplicationOptionVMDisplayName { get; set; }
        /// <summary>Replication options for HyperV</summary>
        Commvault.Powershell.Models.IOverrideReplicationOptionsHyperV OverrideReplicationOptions { get; set; }
        /// <summary>Source VM</summary>
        string SourceVM { get; set; }

    }
}