// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class CreatePlanBackupDestinations :
        Commvault.Powershell.Models.ICreatePlanBackupDestinations,
        Commvault.Powershell.Models.ICreatePlanBackupDestinationsInternal
    {

        /// <summary>Internal Acessors for Region</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICreatePlanBackupDestinationsInternal.Region { get => (this._region = this._region ?? new Commvault.Powershell.Models.IdName()); set { {_region = value;} } }

        /// <summary>Internal Acessors for SnapshotOptions</summary>
        Commvault.Powershell.Models.ICreatePlanSnapshotOptions Commvault.Powershell.Models.ICreatePlanBackupDestinationsInternal.SnapshotOptions { get => (this._snapshotOptions = this._snapshotOptions ?? new Commvault.Powershell.Models.CreatePlanSnapshotOptions()); set { {_snapshotOptions = value;} } }

        /// <summary>Backing field for <see cref="Destinations" /> property.</summary>
        private Commvault.Powershell.Models.ICreatePlanBackupDestination[] _destinations;

        /// <summary>List of backup destinations to create</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.ICreatePlanBackupDestination[] Destinations { get => this._destinations; set => this._destinations = value; }

        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _region;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Region { get => (this._region = this._region ?? new Commvault.Powershell.Models.IdName()); set => this._region = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? RegionId { get => ((Commvault.Powershell.Models.IIdNameInternal)Region).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Region).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RegionName { get => ((Commvault.Powershell.Models.IIdNameInternal)Region).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Region).Name = value ?? null; }

        /// <summary>Backup copy RPO in minutes</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SnapshotOptionBackupCopyRpoMins { get => ((Commvault.Powershell.Models.ICreatePlanSnapshotOptionsInternal)SnapshotOptions).BackupCopyRpoMins; set => ((Commvault.Powershell.Models.ICreatePlanSnapshotOptionsInternal)SnapshotOptions).BackupCopyRpoMins = value ?? default(int); }

        /// <summary>Flag to enable backup copy</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? SnapshotOptionEnableBackupCopy { get => ((Commvault.Powershell.Models.ICreatePlanSnapshotOptionsInternal)SnapshotOptions).EnableBackupCopy; set => ((Commvault.Powershell.Models.ICreatePlanSnapshotOptionsInternal)SnapshotOptions).EnableBackupCopy = value ?? default(bool); }

        /// <summary>
        /// Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified,
        /// this takes precedence.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SnapshotOptionRetentionPeriodDays { get => ((Commvault.Powershell.Models.ICreatePlanSnapshotOptionsInternal)SnapshotOptions).RetentionPeriodDays; set => ((Commvault.Powershell.Models.ICreatePlanSnapshotOptionsInternal)SnapshotOptions).RetentionPeriodDays = value ?? default(int); }

        /// <summary>
        /// Number of snap recovery points for default snap copy for retention. Can be specified instead of retention period in Days
        /// for default snap copy.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SnapshotOptionSnapRecoveryPoints { get => ((Commvault.Powershell.Models.ICreatePlanSnapshotOptionsInternal)SnapshotOptions).SnapRecoveryPoints; set => ((Commvault.Powershell.Models.ICreatePlanSnapshotOptionsInternal)SnapshotOptions).SnapRecoveryPoints = value ?? default(int); }

        /// <summary>Backing field for <see cref="SnapshotOptions" /> property.</summary>
        private Commvault.Powershell.Models.ICreatePlanSnapshotOptions _snapshotOptions;

        /// <summary>This feature applies only to File System Agents</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ICreatePlanSnapshotOptions SnapshotOptions { get => (this._snapshotOptions = this._snapshotOptions ?? new Commvault.Powershell.Models.CreatePlanSnapshotOptions()); set => this._snapshotOptions = value; }

        /// <summary>Creates an new <see cref="CreatePlanBackupDestinations" /> instance.</summary>
        public CreatePlanBackupDestinations()
        {

        }
    }
    public partial interface ICreatePlanBackupDestinations :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>List of backup destinations to create</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"List of backup destinations to create",
        SerializedName = @"destinations",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ICreatePlanBackupDestination) })]
        Commvault.Powershell.Models.ICreatePlanBackupDestination[] Destinations { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? RegionId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string RegionName { get; set; }
        /// <summary>Backup copy RPO in minutes</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Backup copy RPO in minutes",
        SerializedName = @"backupCopyRPOMins",
        PossibleTypes = new [] { typeof(int) })]
        int? SnapshotOptionBackupCopyRpoMins { get; set; }
        /// <summary>Flag to enable backup copy</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to enable backup copy",
        SerializedName = @"enableBackupCopy",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SnapshotOptionEnableBackupCopy { get; set; }
        /// <summary>
        /// Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified,
        /// this takes precedence.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified, this takes precedence.",
        SerializedName = @"retentionPeriodDays",
        PossibleTypes = new [] { typeof(int) })]
        int? SnapshotOptionRetentionPeriodDays { get; set; }
        /// <summary>
        /// Number of snap recovery points for default snap copy for retention. Can be specified instead of retention period in Days
        /// for default snap copy.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of snap recovery points for default snap copy for retention. Can be specified instead of retention period in Days for default snap copy.",
        SerializedName = @"snapRecoveryPoints",
        PossibleTypes = new [] { typeof(int) })]
        int? SnapshotOptionSnapRecoveryPoints { get; set; }

    }
    internal partial interface ICreatePlanBackupDestinationsInternal

    {
        /// <summary>List of backup destinations to create</summary>
        Commvault.Powershell.Models.ICreatePlanBackupDestination[] Destinations { get; set; }

        Commvault.Powershell.Models.IIdName Region { get; set; }

        int? RegionId { get; set; }

        string RegionName { get; set; }
        /// <summary>Backup copy RPO in minutes</summary>
        int? SnapshotOptionBackupCopyRpoMins { get; set; }
        /// <summary>Flag to enable backup copy</summary>
        bool? SnapshotOptionEnableBackupCopy { get; set; }
        /// <summary>
        /// Retention period in days. -1 can be specified for infinite retention. If this and snapRecoveryPoints both are not specified,
        /// this takes precedence.
        /// </summary>
        int? SnapshotOptionRetentionPeriodDays { get; set; }
        /// <summary>
        /// Number of snap recovery points for default snap copy for retention. Can be specified instead of retention period in Days
        /// for default snap copy.
        /// </summary>
        int? SnapshotOptionSnapRecoveryPoints { get; set; }
        /// <summary>This feature applies only to File System Agents</summary>
        Commvault.Powershell.Models.ICreatePlanSnapshotOptions SnapshotOptions { get; set; }

    }
}