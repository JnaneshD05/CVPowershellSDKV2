// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Used to return details of a replication group whose replicationGroupId has been provided
    /// </summary>
    public partial class ReplicationGroup :
        Commvault.Powershell.Models.IReplicationGroup,
        Commvault.Powershell.Models.IReplicationGroupInternal
    {

        /// <summary>Internal Acessors for Rpo</summary>
        Commvault.Powershell.Models.IRpo Commvault.Powershell.Models.IReplicationGroupInternal.Rpo { get => (this._rpo = this._rpo ?? new Commvault.Powershell.Models.Rpo()); set { {_rpo = value;} } }

        /// <summary>Internal Acessors for Storage</summary>
        Commvault.Powershell.Models.IReplicationGroupStorageList Commvault.Powershell.Models.IReplicationGroupInternal.Storage { get => (this._storage = this._storage ?? new Commvault.Powershell.Models.ReplicationGroupStorageList()); set { {_storage = value;} } }

        /// <summary>Internal Acessors for Summary</summary>
        Commvault.Powershell.Models.IReplicationGroupSummary Commvault.Powershell.Models.IReplicationGroupInternal.Summary { get => (this._summary = this._summary ?? new Commvault.Powershell.Models.ReplicationGroupSummary()); set { {_summary = value;} } }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        /// <summary>Replication group id</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Replication group name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Rpo" /> property.</summary>
        private Commvault.Powershell.Models.IRpo _rpo;

        /// <summary>Frequency of replication</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IRpo Rpo { get => (this._rpo = this._rpo ?? new Commvault.Powershell.Models.Rpo()); set => this._rpo = value; }

        /// <summary>
        /// Max amount of time for which data can be lost during a service disruption. Determines frequency of backup jobs in minutes
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? RpoReplicationFrequency { get => ((Commvault.Powershell.Models.IRpoInternal)Rpo).ReplicationFrequency; set => ((Commvault.Powershell.Models.IRpoInternal)Rpo).ReplicationFrequency = value ?? default(int); }

        /// <summary>Backing field for <see cref="Storage" /> property.</summary>
        private Commvault.Powershell.Models.IReplicationGroupStorageList _storage;

        /// <summary>List of storage configured for a replication group</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IReplicationGroupStorageList Storage { get => (this._storage = this._storage ?? new Commvault.Powershell.Models.ReplicationGroupStorageList()); set => this._storage = value; }

        /// <summary>List of all storages which are configured for that replication group</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IStorageCopy[] StorageCopies { get => ((Commvault.Powershell.Models.IReplicationGroupStorageListInternal)Storage).Copies; set => ((Commvault.Powershell.Models.IReplicationGroupStorageListInternal)Storage).Copies = value ?? null /* arrayOf */; }

        /// <summary>Main storage which is used for replication</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string StorageCopyForReplication { get => ((Commvault.Powershell.Models.IReplicationGroupStorageListInternal)Storage).CopyForReplication; set => ((Commvault.Powershell.Models.IReplicationGroupStorageListInternal)Storage).CopyForReplication = value ?? null; }

        /// <summary>Backing field for <see cref="Summary" /> property.</summary>
        private Commvault.Powershell.Models.IReplicationGroupSummary _summary;

        /// <summary>Summary of replication group</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IReplicationGroupSummary Summary { get => (this._summary = this._summary ?? new Commvault.Powershell.Models.ReplicationGroupSummary()); set => this._summary = value; }

        /// <summary>Vendor used as destination for replication.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SummaryDestinationVendor { get => ((Commvault.Powershell.Models.IReplicationGroupSummaryInternal)Summary).DestinationVendor; set => ((Commvault.Powershell.Models.IReplicationGroupSummaryInternal)Summary).DestinationVendor = value ?? null; }

        /// <summary>Can be used to identify destination for full VM restore</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SummaryRecoveryTarget { get => ((Commvault.Powershell.Models.IReplicationGroupSummaryInternal)Summary).RecoveryTarget; set => ((Commvault.Powershell.Models.IReplicationGroupSummaryInternal)Summary).RecoveryTarget = value ?? null; }

        /// <summary>The field specifies the type of replication that is to be performed</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SummaryReplicationType { get => ((Commvault.Powershell.Models.IReplicationGroupSummaryInternal)Summary).ReplicationType; set => ((Commvault.Powershell.Models.IReplicationGroupSummaryInternal)Summary).ReplicationType = value ?? null; }

        /// <summary>Source hypervisor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SummarySource { get => ((Commvault.Powershell.Models.IReplicationGroupSummaryInternal)Summary).Source; set => ((Commvault.Powershell.Models.IReplicationGroupSummaryInternal)Summary).Source = value ?? null; }

        /// <summary>State of replication group. Values are case sensitive</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SummaryState { get => ((Commvault.Powershell.Models.IReplicationGroupSummaryInternal)Summary).State; set => ((Commvault.Powershell.Models.IReplicationGroupSummaryInternal)Summary).State = value ?? null; }

        /// <summary>Creates an new <see cref="ReplicationGroup" /> instance.</summary>
        public ReplicationGroup()
        {

        }
    }
    /// Used to return details of a replication group whose replicationGroupId has been provided
    public partial interface IReplicationGroup :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Replication group id</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Replication group id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }
        /// <summary>Replication group name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Replication group name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// Max amount of time for which data can be lost during a service disruption. Determines frequency of backup jobs in minutes
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Max amount of time for which data can be lost during a service disruption. Determines frequency of backup jobs in minutes",
        SerializedName = @"replicationFrequency",
        PossibleTypes = new [] { typeof(int) })]
        int? RpoReplicationFrequency { get; set; }
        /// <summary>List of all storages which are configured for that replication group</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of all storages which are configured for that replication group",
        SerializedName = @"copies",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IStorageCopy) })]
        Commvault.Powershell.Models.IStorageCopy[] StorageCopies { get; set; }
        /// <summary>Main storage which is used for replication</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Main storage which is used for replication",
        SerializedName = @"copyForReplication",
        PossibleTypes = new [] { typeof(string) })]
        string StorageCopyForReplication { get; set; }
        /// <summary>Vendor used as destination for replication.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Vendor used as destination for replication.",
        SerializedName = @"destinationVendor",
        PossibleTypes = new [] { typeof(string) })]
        string SummaryDestinationVendor { get; set; }
        /// <summary>Can be used to identify destination for full VM restore</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Can be used to identify destination for full VM restore",
        SerializedName = @"recoveryTarget",
        PossibleTypes = new [] { typeof(string) })]
        string SummaryRecoveryTarget { get; set; }
        /// <summary>The field specifies the type of replication that is to be performed</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The field specifies the type of replication that is to be performed",
        SerializedName = @"replicationType",
        PossibleTypes = new [] { typeof(string) })]
        string SummaryReplicationType { get; set; }
        /// <summary>Source hypervisor</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Source hypervisor",
        SerializedName = @"source",
        PossibleTypes = new [] { typeof(string) })]
        string SummarySource { get; set; }
        /// <summary>State of replication group. Values are case sensitive</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of replication group. Values are case sensitive",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string SummaryState { get; set; }

    }
    /// Used to return details of a replication group whose replicationGroupId has been provided
    internal partial interface IReplicationGroupInternal

    {
        /// <summary>Replication group id</summary>
        int? Id { get; set; }
        /// <summary>Replication group name</summary>
        string Name { get; set; }
        /// <summary>Frequency of replication</summary>
        Commvault.Powershell.Models.IRpo Rpo { get; set; }
        /// <summary>
        /// Max amount of time for which data can be lost during a service disruption. Determines frequency of backup jobs in minutes
        /// </summary>
        int? RpoReplicationFrequency { get; set; }
        /// <summary>List of storage configured for a replication group</summary>
        Commvault.Powershell.Models.IReplicationGroupStorageList Storage { get; set; }
        /// <summary>List of all storages which are configured for that replication group</summary>
        Commvault.Powershell.Models.IStorageCopy[] StorageCopies { get; set; }
        /// <summary>Main storage which is used for replication</summary>
        string StorageCopyForReplication { get; set; }
        /// <summary>Summary of replication group</summary>
        Commvault.Powershell.Models.IReplicationGroupSummary Summary { get; set; }
        /// <summary>Vendor used as destination for replication.</summary>
        string SummaryDestinationVendor { get; set; }
        /// <summary>Can be used to identify destination for full VM restore</summary>
        string SummaryRecoveryTarget { get; set; }
        /// <summary>The field specifies the type of replication that is to be performed</summary>
        string SummaryReplicationType { get; set; }
        /// <summary>Source hypervisor</summary>
        string SummarySource { get; set; }
        /// <summary>State of replication group. Values are case sensitive</summary>
        string SummaryState { get; set; }

    }
}