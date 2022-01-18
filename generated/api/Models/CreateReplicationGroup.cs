// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// SourceHypervisor is the hypervisor that has the VM's to be backed up. This should be already configured. Recovery target
    /// contains the replication options that will be applied to the selected VM's. This should be already configured. ID is mandatory
    /// for sourceHypervisor and recovery target. Provide both the id and the name for the storage and the vms.
    /// </summary>
    public partial class CreateReplicationGroup :
        Commvault.Powershell.Models.ICreateReplicationGroup,
        Commvault.Powershell.Models.ICreateReplicationGroupInternal
    {

        /// <summary>Internal Acessors for RecoveryTarget</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICreateReplicationGroupInternal.RecoveryTarget { get => (this._recoveryTarget = this._recoveryTarget ?? new Commvault.Powershell.Models.IdName()); set { {_recoveryTarget = value;} } }

        /// <summary>Internal Acessors for SourceHypervisor</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICreateReplicationGroupInternal.SourceHypervisor { get => (this._sourceHypervisor = this._sourceHypervisor ?? new Commvault.Powershell.Models.IdName()); set { {_sourceHypervisor = value;} } }

        /// <summary>Backing field for <see cref="FrequencyInMinutes" /> property.</summary>
        private int? _frequencyInMinutes;

        /// <summary>The field denotes the frequency of replication.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? FrequencyInMinutes { get => this._frequencyInMinutes; set => this._frequencyInMinutes = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the replication group being created</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="RecoveryTarget" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _recoveryTarget;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName RecoveryTarget { get => (this._recoveryTarget = this._recoveryTarget ?? new Commvault.Powershell.Models.IdName()); set => this._recoveryTarget = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? RecoveryTargetId { get => ((Commvault.Powershell.Models.IIdNameInternal)RecoveryTarget).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)RecoveryTarget).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RecoveryTargetName { get => ((Commvault.Powershell.Models.IIdNameInternal)RecoveryTarget).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)RecoveryTarget).Name = value ?? null; }

        /// <summary>Backing field for <see cref="SourceHypervisor" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _sourceHypervisor;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName SourceHypervisor { get => (this._sourceHypervisor = this._sourceHypervisor ?? new Commvault.Powershell.Models.IdName()); set => this._sourceHypervisor = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SourceHypervisorId { get => ((Commvault.Powershell.Models.IIdNameInternal)SourceHypervisor).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)SourceHypervisor).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SourceHypervisorName { get => ((Commvault.Powershell.Models.IIdNameInternal)SourceHypervisor).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)SourceHypervisor).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Storage" /> property.</summary>
        private Commvault.Powershell.Models.IStorageCopyCreate[] _storage;

        /// <summary>
        /// The primary and an optional secondary storage that will be used for storing the source VM data for replication. The secondary
        /// storage if provided, will be the default source for replication.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IStorageCopyCreate[] Storage { get => this._storage; set => this._storage = value; }

        /// <summary>Backing field for <see cref="Vms" /> property.</summary>
        private Commvault.Powershell.Models.INameGuid[] _vms;

        /// <summary>A list of name and GUID of all the virtual machines that have to be replicated</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.INameGuid[] Vms { get => this._vms; set => this._vms = value; }

        /// <summary>Creates an new <see cref="CreateReplicationGroup" /> instance.</summary>
        public CreateReplicationGroup()
        {

        }
    }
    /// SourceHypervisor is the hypervisor that has the VM's to be backed up. This should be already configured. Recovery target
    /// contains the replication options that will be applied to the selected VM's. This should be already configured. ID is mandatory
    /// for sourceHypervisor and recovery target. Provide both the id and the name for the storage and the vms.
    public partial interface ICreateReplicationGroup :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>The field denotes the frequency of replication.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The field denotes the frequency of replication.",
        SerializedName = @"frequencyInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? FrequencyInMinutes { get; set; }
        /// <summary>The name of the replication group being created</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the replication group being created",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? RecoveryTargetId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryTargetName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? SourceHypervisorId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SourceHypervisorName { get; set; }
        /// <summary>
        /// The primary and an optional secondary storage that will be used for storing the source VM data for replication. The secondary
        /// storage if provided, will be the default source for replication.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The primary and an optional secondary storage that will be used for storing the source VM data for replication. The secondary storage if provided, will be the default source for replication.",
        SerializedName = @"storage",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IStorageCopyCreate) })]
        Commvault.Powershell.Models.IStorageCopyCreate[] Storage { get; set; }
        /// <summary>A list of name and GUID of all the virtual machines that have to be replicated</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"A list of name and GUID of all the virtual machines that have to be replicated",
        SerializedName = @"vms",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.INameGuid) })]
        Commvault.Powershell.Models.INameGuid[] Vms { get; set; }

    }
    /// SourceHypervisor is the hypervisor that has the VM's to be backed up. This should be already configured. Recovery target
    /// contains the replication options that will be applied to the selected VM's. This should be already configured. ID is mandatory
    /// for sourceHypervisor and recovery target. Provide both the id and the name for the storage and the vms.
    internal partial interface ICreateReplicationGroupInternal

    {
        /// <summary>The field denotes the frequency of replication.</summary>
        int? FrequencyInMinutes { get; set; }
        /// <summary>The name of the replication group being created</summary>
        string Name { get; set; }

        Commvault.Powershell.Models.IIdName RecoveryTarget { get; set; }

        int? RecoveryTargetId { get; set; }

        string RecoveryTargetName { get; set; }

        Commvault.Powershell.Models.IIdName SourceHypervisor { get; set; }

        int? SourceHypervisorId { get; set; }

        string SourceHypervisorName { get; set; }
        /// <summary>
        /// The primary and an optional secondary storage that will be used for storing the source VM data for replication. The secondary
        /// storage if provided, will be the default source for replication.
        /// </summary>
        Commvault.Powershell.Models.IStorageCopyCreate[] Storage { get; set; }
        /// <summary>A list of name and GUID of all the virtual machines that have to be replicated</summary>
        Commvault.Powershell.Models.INameGuid[] Vms { get; set; }

    }
}