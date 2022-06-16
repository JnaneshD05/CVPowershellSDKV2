// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class CreateServerPlan :
        Commvault.Powershell.Models.ICreateServerPlan,
        Commvault.Powershell.Models.ICreateServerPlanInternal
    {

        /// <summary>Backing field for <see cref="AllowPlanOverride" /> property.</summary>
        private bool? _allowPlanOverride;

        /// <summary>Flag to enable overriding of plan. Plan cannot be overriden by default.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? AllowPlanOverride { get => this._allowPlanOverride; set => this._allowPlanOverride = value; }

        /// <summary>Backing field for <see cref="BackupContent" /> property.</summary>
        private Commvault.Powershell.Models.IPlanContent _backupContent;

        /// <summary>This feature applies only to file system agents</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IPlanContent BackupContent { get => (this._backupContent = this._backupContent ?? new Commvault.Powershell.Models.PlanContent()); set => this._backupContent = value; }

        /// <summary>Do you want to back up the system state? Applicable only for Windows</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? BackupContentBackupSystemState { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).BackupSystemState; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).BackupSystemState = value ?? default(bool); }

        /// <summary>
        /// Do you want to back up system state only with full backup? Applicable only if the value of backupSystemState is true
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? BackupContentBackupSystemStateOnlyWithFullBackup { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).BackupSystemStateOnlyWithFullBackup; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).BackupSystemStateOnlyWithFullBackup = value ?? default(bool); }

        /// <summary>Paths to exclude for Mac</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] BackupContentMacExcludedPaths { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).MacExcludedPaths; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).MacExcludedPaths = value ?? null /* arrayOf */; }

        /// <summary>Paths to include for Mac</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] BackupContentMacIncludedPaths { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).MacIncludedPaths; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).MacIncludedPaths = value ?? null /* arrayOf */; }

        /// <summary>Paths to exclude for UNIX</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] BackupContentUnixExcludedPaths { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).UnixExcludedPaths; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).UnixExcludedPaths = value ?? null /* arrayOf */; }

        /// <summary>Paths to include for UNIX</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] BackupContentUnixIncludedPaths { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).UnixIncludedPaths; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).UnixIncludedPaths = value ?? null /* arrayOf */; }

        /// <summary>
        /// Do you want to back up system state with VSS? Applicable only if the value of backupSystemState is true
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? BackupContentUseVssForSystemState { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).UseVssForSystemState; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).UseVssForSystemState = value ?? default(bool); }

        /// <summary>Paths to exclude for Windows</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] BackupContentWindowsExcludedPaths { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).WindowsExcludedPaths; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).WindowsExcludedPaths = value ?? null /* arrayOf */; }

        /// <summary>Paths to include for Windows</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] BackupContentWindowsIncludedPaths { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).WindowsIncludedPaths; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).WindowsIncludedPaths = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="BackupDestinations" /> property.</summary>
        private Commvault.Powershell.Models.ICreatePlanBackupDestination[] _backupDestinations;

        /// <summary>
        /// Backup destinations for the plan. Specify where you want to store your backup data.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.ICreatePlanBackupDestination[] BackupDestinations { get => this._backupDestinations; set => this._backupDestinations = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IPlanSchedule[] BackupFrequencySchedules { get => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).BackupFrequencySchedules; set => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).BackupFrequencySchedules = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for BackupContent</summary>
        Commvault.Powershell.Models.IPlanContent Commvault.Powershell.Models.ICreateServerPlanInternal.BackupContent { get => (this._backupContent = this._backupContent ?? new Commvault.Powershell.Models.PlanContent()); set { {_backupContent = value;} } }

        /// <summary>Internal Acessors for DatabaseOptions</summary>
        Commvault.Powershell.Models.IServerPlanDatabaseOptions Commvault.Powershell.Models.ICreateServerPlanInternal.DatabaseOptions { get => (this._databaseOptions = this._databaseOptions ?? new Commvault.Powershell.Models.ServerPlanDatabaseOptions()); set { {_databaseOptions = value;} } }

        /// <summary>Internal Acessors for OverrideRestrictions</summary>
        Commvault.Powershell.Models.IPlanOverrideSettings Commvault.Powershell.Models.ICreateServerPlanInternal.OverrideRestrictions { get => (this._overrideRestrictions = this._overrideRestrictions ?? new Commvault.Powershell.Models.PlanOverrideSettings()); set { {_overrideRestrictions = value;} } }

        /// <summary>Internal Acessors for ParentPlan</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICreateServerPlanInternal.ParentPlan { get => (this._parentPlan = this._parentPlan ?? new Commvault.Powershell.Models.IdName()); set { {_parentPlan = value;} } }

        /// <summary>Internal Acessors for Rpo</summary>
        Commvault.Powershell.Models.IServerBackupPlanRpo Commvault.Powershell.Models.ICreateServerPlanInternal.Rpo { get => (this._rpo = this._rpo ?? new Commvault.Powershell.Models.ServerBackupPlanRpo()); set { {_rpo = value;} } }

        /// <summary>Internal Acessors for RpoBackupFrequency</summary>
        Commvault.Powershell.Models.IPlanSchedules Commvault.Powershell.Models.ICreateServerPlanInternal.RpoBackupFrequency { get => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).BackupFrequency; set => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).BackupFrequency = value; }

        /// <summary>Internal Acessors for SnapshotOptions</summary>
        Commvault.Powershell.Models.ICreatePlanSnapshotOptions Commvault.Powershell.Models.ICreateServerPlanInternal.SnapshotOptions { get => (this._snapshotOptions = this._snapshotOptions ?? new Commvault.Powershell.Models.CreatePlanSnapshotOptions()); set { {_snapshotOptions = value;} } }

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

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string OverrideRestrictionBackupContent { get => ((Commvault.Powershell.Models.IPlanOverrideSettingsInternal)OverrideRestrictions).BackupContent; set => ((Commvault.Powershell.Models.IPlanOverrideSettingsInternal)OverrideRestrictions).BackupContent = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string OverrideRestrictionRpo { get => ((Commvault.Powershell.Models.IPlanOverrideSettingsInternal)OverrideRestrictions).Rpo; set => ((Commvault.Powershell.Models.IPlanOverrideSettingsInternal)OverrideRestrictions).Rpo = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string OverrideRestrictionStoragePool { get => ((Commvault.Powershell.Models.IPlanOverrideSettingsInternal)OverrideRestrictions).StoragePool; set => ((Commvault.Powershell.Models.IPlanOverrideSettingsInternal)OverrideRestrictions).StoragePool = value ?? null; }

        /// <summary>Backing field for <see cref="OverrideRestrictions" /> property.</summary>
        private Commvault.Powershell.Models.IPlanOverrideSettings _overrideRestrictions;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IPlanOverrideSettings OverrideRestrictions { get => (this._overrideRestrictions = this._overrideRestrictions ?? new Commvault.Powershell.Models.PlanOverrideSettings()); set => this._overrideRestrictions = value; }

        /// <summary>Backing field for <see cref="ParentPlan" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _parentPlan;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName ParentPlan { get => (this._parentPlan = this._parentPlan ?? new Commvault.Powershell.Models.IdName()); set => this._parentPlan = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ParentPlanId { get => ((Commvault.Powershell.Models.IIdNameInternal)ParentPlan).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)ParentPlan).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ParentPlanName { get => ((Commvault.Powershell.Models.IIdNameInternal)ParentPlan).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)ParentPlan).Name = value ?? null; }

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

        /// <summary>Creates an new <see cref="CreateServerPlan" /> instance.</summary>
        public CreateServerPlan()
        {

        }
    }
    public partial interface ICreateServerPlan :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Flag to enable overriding of plan. Plan cannot be overriden by default.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to enable overriding of plan. Plan cannot be overriden by default.",
        SerializedName = @"allowPlanOverride",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowPlanOverride { get; set; }
        /// <summary>Do you want to back up the system state? Applicable only for Windows</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Do you want to back up the system state? Applicable only for Windows",
        SerializedName = @"backupSystemState",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BackupContentBackupSystemState { get; set; }
        /// <summary>
        /// Do you want to back up system state only with full backup? Applicable only if the value of backupSystemState is true
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Do you want to back up system state only with full backup? Applicable only if the value of backupSystemState is true",
        SerializedName = @"backupSystemStateOnlyWithFullBackup",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BackupContentBackupSystemStateOnlyWithFullBackup { get; set; }
        /// <summary>Paths to exclude for Mac</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Paths to exclude for Mac",
        SerializedName = @"macExcludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] BackupContentMacExcludedPaths { get; set; }
        /// <summary>Paths to include for Mac</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Paths to include for Mac",
        SerializedName = @"macIncludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] BackupContentMacIncludedPaths { get; set; }
        /// <summary>Paths to exclude for UNIX</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Paths to exclude for UNIX",
        SerializedName = @"unixExcludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] BackupContentUnixExcludedPaths { get; set; }
        /// <summary>Paths to include for UNIX</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Paths to include for UNIX",
        SerializedName = @"unixIncludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] BackupContentUnixIncludedPaths { get; set; }
        /// <summary>
        /// Do you want to back up system state with VSS? Applicable only if the value of backupSystemState is true
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Do you want to back up system state with VSS? Applicable only if the value of backupSystemState is true",
        SerializedName = @"useVSSForSystemState",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BackupContentUseVssForSystemState { get; set; }
        /// <summary>Paths to exclude for Windows</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Paths to exclude for Windows",
        SerializedName = @"windowsExcludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] BackupContentWindowsExcludedPaths { get; set; }
        /// <summary>Paths to include for Windows</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Paths to include for Windows",
        SerializedName = @"windowsIncludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] BackupContentWindowsIncludedPaths { get; set; }
        /// <summary>
        /// Backup destinations for the plan. Specify where you want to store your backup data.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Backup destinations for the plan. Specify where you want to store your backup data.",
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

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"backupContent",
        PossibleTypes = new [] { typeof(string) })]
        string OverrideRestrictionBackupContent { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"RPO",
        PossibleTypes = new [] { typeof(string) })]
        string OverrideRestrictionRpo { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"storagePool",
        PossibleTypes = new [] { typeof(string) })]
        string OverrideRestrictionStoragePool { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? ParentPlanId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ParentPlanName { get; set; }
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
    internal partial interface ICreateServerPlanInternal

    {
        /// <summary>Flag to enable overriding of plan. Plan cannot be overriden by default.</summary>
        bool? AllowPlanOverride { get; set; }
        /// <summary>This feature applies only to file system agents</summary>
        Commvault.Powershell.Models.IPlanContent BackupContent { get; set; }
        /// <summary>Do you want to back up the system state? Applicable only for Windows</summary>
        bool? BackupContentBackupSystemState { get; set; }
        /// <summary>
        /// Do you want to back up system state only with full backup? Applicable only if the value of backupSystemState is true
        /// </summary>
        bool? BackupContentBackupSystemStateOnlyWithFullBackup { get; set; }
        /// <summary>Paths to exclude for Mac</summary>
        string[] BackupContentMacExcludedPaths { get; set; }
        /// <summary>Paths to include for Mac</summary>
        string[] BackupContentMacIncludedPaths { get; set; }
        /// <summary>Paths to exclude for UNIX</summary>
        string[] BackupContentUnixExcludedPaths { get; set; }
        /// <summary>Paths to include for UNIX</summary>
        string[] BackupContentUnixIncludedPaths { get; set; }
        /// <summary>
        /// Do you want to back up system state with VSS? Applicable only if the value of backupSystemState is true
        /// </summary>
        bool? BackupContentUseVssForSystemState { get; set; }
        /// <summary>Paths to exclude for Windows</summary>
        string[] BackupContentWindowsExcludedPaths { get; set; }
        /// <summary>Paths to include for Windows</summary>
        string[] BackupContentWindowsIncludedPaths { get; set; }
        /// <summary>
        /// Backup destinations for the plan. Specify where you want to store your backup data.
        /// </summary>
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

        string OverrideRestrictionBackupContent { get; set; }

        string OverrideRestrictionRpo { get; set; }

        string OverrideRestrictionStoragePool { get; set; }

        Commvault.Powershell.Models.IPlanOverrideSettings OverrideRestrictions { get; set; }

        Commvault.Powershell.Models.IIdName ParentPlan { get; set; }

        int? ParentPlanId { get; set; }

        string ParentPlanName { get; set; }
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