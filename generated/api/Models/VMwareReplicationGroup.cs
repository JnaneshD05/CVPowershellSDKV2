// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Replication group details pertaining to VMware</summary>
    public partial class VMwareReplicationGroup :
        Commvault.Powershell.Models.IVMwareReplicationGroup,
        Commvault.Powershell.Models.IVMwareReplicationGroupInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.IReplicationGroup" />
        /// </summary>
        private Commvault.Powershell.Models.IReplicationGroup __replicationGroup = new Commvault.Powershell.Models.ReplicationGroup();

        /// <summary>Backing field for <see cref="AdvancedOption" /> property.</summary>
        private Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWare _advancedOption;

        /// <summary>Advanced options for VMWare replication group</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWare AdvancedOption { get => (this._advancedOption = this._advancedOption ?? new Commvault.Powershell.Models.ReplicationGroupAdvOptionsVMWare()); set => this._advancedOption = value; }

        /// <summary>
        /// Select the disk provisioning type for the destination VM. The values are case sensitive.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string AdvancedOptionDiskProvisioning { get => ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareInternal)AdvancedOption).DiskProvisioning; set => ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareInternal)AdvancedOption).DiskProvisioning = value ?? null; }

        /// <summary>Number of snapshots to retain on destination VM</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? AdvancedOptionSnapshotsToRetain { get => ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareInternal)AdvancedOption).SnapshotsToRetain; set => ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareInternal)AdvancedOption).SnapshotsToRetain = value ?? default(int); }

        /// <summary>Choose transport mode based on environment. Values are case sensitive</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string AdvancedOptionTransportMode { get => ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareInternal)AdvancedOption).TransportMode; set => ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareInternal)AdvancedOption).TransportMode = value ?? null; }

        /// <summary>Replace an existing virtual machine with the same name in the target location</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? AdvancedOptionUnconditionalOverwrite { get => ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareInternal)AdvancedOption).UnconditionalOverwrite; set => ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareInternal)AdvancedOption).UnconditionalOverwrite = value ?? default(bool); }

        /// <summary>
        /// Validates that the destination VM is bootable by powering it on and then powering off
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? AdvancedOptionValidateDestinationVM { get => ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareInternal)AdvancedOption).ValidateDestinationVM; set => ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareInternal)AdvancedOption).ValidateDestinationVM = value ?? default(bool); }

        /// <summary>Internal Acessors for AdvancedOption</summary>
        Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWare Commvault.Powershell.Models.IVMwareReplicationGroupInternal.AdvancedOption { get => (this._advancedOption = this._advancedOption ?? new Commvault.Powershell.Models.ReplicationGroupAdvOptionsVMWare()); set { {_advancedOption = value;} } }

        /// <summary>Internal Acessors for Vendor</summary>
        string Commvault.Powershell.Models.IVMwareReplicationGroupInternal.Vendor { get => this._vendor; set { {_vendor = value;} } }

        /// <summary>Replication group id</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? Id { get => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).Id; set => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).Id = value; }

        /// <summary>Replication group name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Name { get => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).Name; set => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).Name = value; }

        /// <summary>Backing field for <see cref="ReplicationConfiguration" /> property.</summary>
        private Commvault.Powershell.Models.IReplicationConfigurationVMware[] _replicationConfiguration;

        /// <summary>replication configuration for VMware replication group</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IReplicationConfigurationVMware[] ReplicationConfiguration { get => this._replicationConfiguration; set => this._replicationConfiguration = value; }

        /// <summary>Frequency of replication</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IRpo Rpo { get => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).Rpo; set => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).Rpo = value; }

        /// <summary>
        /// Max amount of time for which data can be lost during a service disruption. Determines frequency of backup jobs in minutes
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? RpoReplicationFrequency { get => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).RpoReplicationFrequency; set => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).RpoReplicationFrequency = value; }

        /// <summary>List of storage configured for a replication group</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IReplicationGroupStorageList Storage { get => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).Storage; set => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).Storage = value; }

        /// <summary>List of all storages which are configured for that replication group</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IStorageCopy[] StorageCopies { get => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).StorageCopies; set => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).StorageCopies = value; }

        /// <summary>Main storage which is used for replication</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string StorageCopyForReplication { get => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).StorageCopyForReplication; set => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).StorageCopyForReplication = value; }

        /// <summary>Summary of replication group</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IReplicationGroupSummary Summary { get => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).Summary; set => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).Summary = value; }

        /// <summary>Vendor used as destination for replication.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string SummaryDestinationVendor { get => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).SummaryDestinationVendor; set => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).SummaryDestinationVendor = value; }

        /// <summary>Can be used to identify destination for full VM restore</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string SummaryRecoveryTarget { get => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).SummaryRecoveryTarget; set => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).SummaryRecoveryTarget = value; }

        /// <summary>The field specifies the type of replication that is to be performed</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string SummaryReplicationType { get => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).SummaryReplicationType; set => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).SummaryReplicationType = value; }

        /// <summary>Source hypervisor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string SummarySource { get => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).SummarySource; set => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).SummarySource = value; }

        /// <summary>State of replication group. Values are case sensitive</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string SummaryState { get => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).SummaryState; set => ((Commvault.Powershell.Models.IReplicationGroupInternal)__replicationGroup).SummaryState = value; }

        /// <summary>Backing field for <see cref="Vendor" /> property.</summary>
        private string _vendor= @"VMware";

        /// <summary>Vendor type of this replication group. Values in enum are case sensitive</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Vendor { get => this._vendor; }

        /// <summary>Creates an new <see cref="VMwareReplicationGroup" /> instance.</summary>
        public VMwareReplicationGroup()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Commvault.Powershell.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Commvault.Powershell.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__replicationGroup), __replicationGroup);
            await eventListener.AssertObjectIsValid(nameof(__replicationGroup), __replicationGroup);
        }
    }
    /// Replication group details pertaining to VMware
    public partial interface IVMwareReplicationGroup :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.IReplicationGroup
    {
        /// <summary>
        /// Select the disk provisioning type for the destination VM. The values are case sensitive.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Select the disk provisioning type for the destination VM. The values are case sensitive.",
        SerializedName = @"diskProvisioning",
        PossibleTypes = new [] { typeof(string) })]
        string AdvancedOptionDiskProvisioning { get; set; }
        /// <summary>Number of snapshots to retain on destination VM</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of snapshots to retain on destination VM",
        SerializedName = @"SnapshotsToRetain",
        PossibleTypes = new [] { typeof(int) })]
        int? AdvancedOptionSnapshotsToRetain { get; set; }
        /// <summary>Choose transport mode based on environment. Values are case sensitive</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Choose transport mode based on environment. Values are case sensitive",
        SerializedName = @"transportMode",
        PossibleTypes = new [] { typeof(string) })]
        string AdvancedOptionTransportMode { get; set; }
        /// <summary>Replace an existing virtual machine with the same name in the target location</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Replace an existing virtual machine with the same name in the target location",
        SerializedName = @"unconditionalOverwrite",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AdvancedOptionUnconditionalOverwrite { get; set; }
        /// <summary>
        /// Validates that the destination VM is bootable by powering it on and then powering off
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Validates that the destination VM is bootable by powering it on and then powering off",
        SerializedName = @"validateDestinationVM",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AdvancedOptionValidateDestinationVM { get; set; }
        /// <summary>replication configuration for VMware replication group</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"replication configuration for VMware replication group",
        SerializedName = @"replicationConfiguration",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IReplicationConfigurationVMware) })]
        Commvault.Powershell.Models.IReplicationConfigurationVMware[] ReplicationConfiguration { get; set; }
        /// <summary>Vendor type of this replication group. Values in enum are case sensitive</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"Vendor type of this replication group. Values in enum are case sensitive",
        SerializedName = @"vendor",
        PossibleTypes = new [] { typeof(string) })]
        string Vendor { get;  }

    }
    /// Replication group details pertaining to VMware
    internal partial interface IVMwareReplicationGroupInternal :
        Commvault.Powershell.Models.IReplicationGroupInternal
    {
        /// <summary>Advanced options for VMWare replication group</summary>
        Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWare AdvancedOption { get; set; }
        /// <summary>
        /// Select the disk provisioning type for the destination VM. The values are case sensitive.
        /// </summary>
        string AdvancedOptionDiskProvisioning { get; set; }
        /// <summary>Number of snapshots to retain on destination VM</summary>
        int? AdvancedOptionSnapshotsToRetain { get; set; }
        /// <summary>Choose transport mode based on environment. Values are case sensitive</summary>
        string AdvancedOptionTransportMode { get; set; }
        /// <summary>Replace an existing virtual machine with the same name in the target location</summary>
        bool? AdvancedOptionUnconditionalOverwrite { get; set; }
        /// <summary>
        /// Validates that the destination VM is bootable by powering it on and then powering off
        /// </summary>
        bool? AdvancedOptionValidateDestinationVM { get; set; }
        /// <summary>replication configuration for VMware replication group</summary>
        Commvault.Powershell.Models.IReplicationConfigurationVMware[] ReplicationConfiguration { get; set; }
        /// <summary>Vendor type of this replication group. Values in enum are case sensitive</summary>
        string Vendor { get; set; }

    }
}