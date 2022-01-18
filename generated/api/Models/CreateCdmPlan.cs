// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class CreateCdmPlan :
        Commvault.Powershell.Models.ICreateCdmPlan,
        Commvault.Powershell.Models.ICreateCdmPlanInternal
    {

        /// <summary>Backing field for <see cref="BackupDestinations" /> property.</summary>
        private Commvault.Powershell.Models.ICreatePlanBackupDestination[] _backupDestinations;

        /// <summary>Copy destinations for the plan. Specify where you want to store your data.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.ICreatePlanBackupDestination[] BackupDestinations { get => this._backupDestinations; set => this._backupDestinations = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IPlanSchedule[] BackupFrequencySchedules { get => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).BackupFrequencySchedules; set => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).BackupFrequencySchedules = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DatabaseOptions</summary>
        Commvault.Powershell.Models.IServerPlanDatabaseOptions Commvault.Powershell.Models.ICreateCdmPlanInternal.DatabaseOptions { get => (this._databaseOptions = this._databaseOptions ?? new Commvault.Powershell.Models.ServerPlanDatabaseOptions()); set { {_databaseOptions = value;} } }

        /// <summary>Internal Acessors for Rpo</summary>
        Commvault.Powershell.Models.IServerBackupPlanRpo Commvault.Powershell.Models.ICreateCdmPlanInternal.Rpo { get => (this._rpo = this._rpo ?? new Commvault.Powershell.Models.ServerBackupPlanRpo()); set { {_rpo = value;} } }

        /// <summary>Internal Acessors for RpoBackupFrequency</summary>
        Commvault.Powershell.Models.IPlanSchedules Commvault.Powershell.Models.ICreateCdmPlanInternal.RpoBackupFrequency { get => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).BackupFrequency; set => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).BackupFrequency = value; }

        /// <summary>Internal Acessors for SnapshotOptions</summary>
        Commvault.Powershell.Models.ICreatePlanSnapshotOptions Commvault.Powershell.Models.ICreateCdmPlanInternal.SnapshotOptions { get => (this._snapshotOptions = this._snapshotOptions ?? new Commvault.Powershell.Models.CreatePlanSnapshotOptions()); set { {_snapshotOptions = value;} } }

        /// <summary>Commit frequency in hours</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? DatabaseOptionCommitFrequencyInHours { get => ((Commvault.Powershell.Models.IServerPlanDatabaseOptionsInternal)DatabaseOptions).CommitFrequencyInHours; set => ((Commvault.Powershell.Models.IServerPlanDatabaseOptionsInternal)DatabaseOptions).CommitFrequencyInHours = value ?? default(int); }

        /// <summary>Log backup RPO in minutes</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? DatabaseOptionLogBackupRpoMins { get => ((Commvault.Powershell.Models.IServerPlanDatabaseOptionsInternal)DatabaseOptions).LogBackupRpoMins; set => ((Commvault.Powershell.Models.IServerPlanDatabaseOptionsInternal)DatabaseOptions).LogBackupRpoMins = value ?? default(int); }

        /// <summary>Use disk cache for log backups</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? DatabaseOptionUseDiskCacheForLogBackups { get => ((Commvault.Powershell.Models.IServerPlanDatabaseOptionsInternal)DatabaseOptions).UseDiskCacheForLogBackups; set => ((Commvault.Powershell.Models.IServerPlanDatabaseOptionsInternal)DatabaseOptions).UseDiskCacheForLogBackups = value ?? default(bool); }

        /// <summary>Backing field for <see cref="DatabaseOptions" /> property.</summary>
        private Commvault.Powershell.Models.IServerPlanDatabaseOptions _databaseOptions;

        /// <summary>This feature applies only to database agents</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IServerPlanDatabaseOptions DatabaseOptions { get => (this._databaseOptions = this._databaseOptions ?? new Commvault.Powershell.Models.ServerPlanDatabaseOptions()); set => this._databaseOptions = value; }

        /// <summary>Backing field for <see cref="PlanName" /> property.</summary>
        private string _planName;

        /// <summary>Name of the new plan</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string PlanName { get => this._planName; set => this._planName = value; }

        /// <summary>Backing field for <see cref="Rpo" /> property.</summary>
        private Commvault.Powershell.Models.IServerBackupPlanRpo _rpo;

        /// <summary>
        /// Recovery Point Objective (RPO) is the maximum amount of time that data can be lost during a service disruption. Your RPO
        /// determines the frequency of your backup jobs.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IServerBackupPlanRpo Rpo { get => (this._rpo = this._rpo ?? new Commvault.Powershell.Models.ServerBackupPlanRpo()); set => this._rpo = value; }

        /// <summary>Backup window for incremental backup</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IDayAndTime[] RpoBackupWindow { get => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).BackupWindow; set => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).BackupWindow = value ?? null /* arrayOf */; }

        /// <summary>Backup window for full backup</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IDayAndTime[] RpoFullBackupWindow { get => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).FullBackupWindow; set => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).FullBackupWindow = value ?? null /* arrayOf */; }

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

        /// <summary>Creates an new <see cref="CreateCdmPlan" /> instance.</summary>
        public CreateCdmPlan()
        {

        }
    }
    public partial interface ICreateCdmPlan :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Copy destinations for the plan. Specify where you want to store your data.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Copy destinations for the plan. Specify where you want to store your data.",
        SerializedName = @"backupDestinations",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ICreatePlanBackupDestination) })]
        Commvault.Powershell.Models.ICreatePlanBackupDestination[] BackupDestinations { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"schedules",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IPlanSchedule) })]
        Commvault.Powershell.Models.IPlanSchedule[] BackupFrequencySchedules { get; set; }
        /// <summary>Commit frequency in hours</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Commit frequency in hours",
        SerializedName = @"commitFrequencyInHours",
        PossibleTypes = new [] { typeof(int) })]
        int? DatabaseOptionCommitFrequencyInHours { get; set; }
        /// <summary>Log backup RPO in minutes</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Log backup RPO in minutes",
        SerializedName = @"logBackupRPOMins",
        PossibleTypes = new [] { typeof(int) })]
        int? DatabaseOptionLogBackupRpoMins { get; set; }
        /// <summary>Use disk cache for log backups</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Use disk cache for log backups",
        SerializedName = @"useDiskCacheForLogBackups",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DatabaseOptionUseDiskCacheForLogBackups { get; set; }
        /// <summary>Name of the new plan</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the new plan",
        SerializedName = @"planName",
        PossibleTypes = new [] { typeof(string) })]
        string PlanName { get; set; }
        /// <summary>Backup window for incremental backup</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Backup window for incremental backup",
        SerializedName = @"backupWindow",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IDayAndTime) })]
        Commvault.Powershell.Models.IDayAndTime[] RpoBackupWindow { get; set; }
        /// <summary>Backup window for full backup</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Backup window for full backup",
        SerializedName = @"fullBackupWindow",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IDayAndTime) })]
        Commvault.Powershell.Models.IDayAndTime[] RpoFullBackupWindow { get; set; }
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
    internal partial interface ICreateCdmPlanInternal

    {
        /// <summary>Copy destinations for the plan. Specify where you want to store your data.</summary>
        Commvault.Powershell.Models.ICreatePlanBackupDestination[] BackupDestinations { get; set; }

        Commvault.Powershell.Models.IPlanSchedule[] BackupFrequencySchedules { get; set; }
        /// <summary>Commit frequency in hours</summary>
        int? DatabaseOptionCommitFrequencyInHours { get; set; }
        /// <summary>Log backup RPO in minutes</summary>
        int? DatabaseOptionLogBackupRpoMins { get; set; }
        /// <summary>Use disk cache for log backups</summary>
        bool? DatabaseOptionUseDiskCacheForLogBackups { get; set; }
        /// <summary>This feature applies only to database agents</summary>
        Commvault.Powershell.Models.IServerPlanDatabaseOptions DatabaseOptions { get; set; }
        /// <summary>Name of the new plan</summary>
        string PlanName { get; set; }
        /// <summary>
        /// Recovery Point Objective (RPO) is the maximum amount of time that data can be lost during a service disruption. Your RPO
        /// determines the frequency of your backup jobs.
        /// </summary>
        Commvault.Powershell.Models.IServerBackupPlanRpo Rpo { get; set; }
        /// <summary>PlanSchedules</summary>
        Commvault.Powershell.Models.IPlanSchedules RpoBackupFrequency { get; set; }
        /// <summary>Backup window for incremental backup</summary>
        Commvault.Powershell.Models.IDayAndTime[] RpoBackupWindow { get; set; }
        /// <summary>Backup window for full backup</summary>
        Commvault.Powershell.Models.IDayAndTime[] RpoFullBackupWindow { get; set; }
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