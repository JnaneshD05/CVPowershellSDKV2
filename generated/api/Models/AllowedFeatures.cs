// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Get details about allowed features of a laptop plan</summary>
    public partial class AllowedFeatures :
        Commvault.Powershell.Models.IAllowedFeatures,
        Commvault.Powershell.Models.IAllowedFeaturesInternal
    {

        /// <summary>Backing field for <see cref="Archiving" /> property.</summary>
        private bool? _archiving;

        /// <summary>Flag to enable archiving of laptop data</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Archiving { get => this._archiving; set => this._archiving = value; }

        /// <summary>
        /// After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving
        /// rules
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ArchivingRuleAfterArchiving { get => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).AfterArchiving; set => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).AfterArchiving = value ?? null; }

        /// <summary>To archive files based on the Read-Only attribute, set to TRUE</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ArchivingRuleArchiveReadOnlyFiles { get => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).ArchiveReadOnlyFiles; set => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).ArchiveReadOnlyFiles = value ?? default(bool); }

        /// <summary>
        /// To archive files based on the last accessed date of each file within the folder, specify the number of days
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ArchivingRuleFileAccessTimeOlderThan { get => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).FileAccessTimeOlderThan; set => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).FileAccessTimeOlderThan = value ?? default(int); }

        /// <summary>
        /// To archive files based on the time the files were created within the folder, specify the number of days
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ArchivingRuleFileCreatedTimeOlderThan { get => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).FileCreatedTimeOlderThan; set => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).FileCreatedTimeOlderThan = value ?? default(int); }

        /// <summary>
        /// To archive files based on the last modified date of each file within the folder, specify the number of days
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ArchivingRuleFileModifiedTimeOlderThan { get => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).FileModifiedTimeOlderThan; set => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).FileModifiedTimeOlderThan = value ?? default(int); }

        /// <summary>
        /// To archive files based on the size of the file, specify the minimum file size in KB. All files whose size ranges between
        /// the minimum and maximum values are archived.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ArchivingRuleFileSizeGreaterThan { get => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).FileSizeGreaterThan; set => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).FileSizeGreaterThan = value ?? default(int); }

        /// <summary>
        /// To archive files based on the size of the file, specify the maximum file size in KB. All files whose size ranges between
        /// the minimum and maximum values are archived.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ArchivingRuleMaximumFileSize { get => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).MaximumFileSize; set => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).MaximumFileSize = value ?? default(int); }

        /// <summary>
        /// When free disk space falls below specified amount (in percentage), start cleaning up the disk
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ArchivingRuleStartCleaningIfLessThan { get => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).StartCleaningIfLessThan; set => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).StartCleaningIfLessThan = value ?? default(int); }

        /// <summary>
        /// When free disk space more than specified amount (in percentage), stop cleaning up the disk
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ArchivingRuleStopCleaningIfupto { get => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).StopCleaningIfupto; set => ((Commvault.Powershell.Models.IArchivingRulesInternal)ArchivingRules).StopCleaningIfupto = value ?? default(int); }

        /// <summary>Backing field for <see cref="ArchivingRules" /> property.</summary>
        private Commvault.Powershell.Models.IArchivingRules _archivingRules;

        /// <summary>These rules are enforced only when archiving is set to true</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IArchivingRules ArchivingRules { get => (this._archivingRules = this._archivingRules ?? new Commvault.Powershell.Models.ArchivingRules()); set => this._archivingRules = value; }

        /// <summary>Internal Acessors for ArchivingRules</summary>
        Commvault.Powershell.Models.IArchivingRules Commvault.Powershell.Models.IAllowedFeaturesInternal.ArchivingRules { get => (this._archivingRules = this._archivingRules ?? new Commvault.Powershell.Models.ArchivingRules()); set { {_archivingRules = value;} } }

        /// <summary>Internal Acessors for EdgeDriveSettingIndexServer</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IAllowedFeaturesInternal.EdgeDriveSettingIndexServer { get => ((Commvault.Powershell.Models.IEdgeDriveSettingsInternal)EdgeDriveSettings).IndexServer; set => ((Commvault.Powershell.Models.IEdgeDriveSettingsInternal)EdgeDriveSettings).IndexServer = value; }

        /// <summary>Internal Acessors for EdgeDriveSettings</summary>
        Commvault.Powershell.Models.IEdgeDriveSettings Commvault.Powershell.Models.IAllowedFeaturesInternal.EdgeDriveSettings { get => (this._edgeDriveSettings = this._edgeDriveSettings ?? new Commvault.Powershell.Models.EdgeDriveSettings()); set { {_edgeDriveSettings = value;} } }

        /// <summary>Backing field for <see cref="Dlp" /> property.</summary>
        private bool? _dlp;

        /// <summary>Flag to enable Data loss protection</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Dlp { get => this._dlp; set => this._dlp = value; }

        /// <summary>Backing field for <see cref="EdgeDrive" /> property.</summary>
        private bool? _edgeDrive;

        /// <summary>Flag to enable Edge Drive</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? EdgeDrive { get => this._edgeDrive; set => this._edgeDrive = value; }

        /// <summary>
        /// Enable auditing which logs the activities based on user interaction like creating, editing, moving, renaming, downloading
        /// or deleting files.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? EdgeDriveSettingAuditDriveOperations { get => ((Commvault.Powershell.Models.IEdgeDriveSettingsInternal)EdgeDriveSettings).AuditDriveOperations; set => ((Commvault.Powershell.Models.IEdgeDriveSettingsInternal)EdgeDriveSettings).AuditDriveOperations = value ?? default(bool); }

        /// <summary>
        /// Maximum number of gigabytes that you can store in the Edge Drive. Value as -1 means no quota is set.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? EdgeDriveSettingEdgeDriveQuota { get => ((Commvault.Powershell.Models.IEdgeDriveSettingsInternal)EdgeDriveSettings).EdgeDriveQuota; set => ((Commvault.Powershell.Models.IEdgeDriveSettingsInternal)EdgeDriveSettings).EdgeDriveQuota = value ?? default(int); }

        /// <summary>
        /// Enables alert notification feature which allows the share user or share owner to subscribe for share notifications when
        /// any activities are performed on the Edge Drive or the Collaborative share. The user can receive the notifications on the
        /// Web Console or as an email notification.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? EdgeDriveSettingNotificationsForShares { get => ((Commvault.Powershell.Models.IEdgeDriveSettingsInternal)EdgeDriveSettings).NotificationsForShares; set => ((Commvault.Powershell.Models.IEdgeDriveSettingsInternal)EdgeDriveSettings).NotificationsForShares = value ?? default(bool); }

        /// <summary>Backing field for <see cref="EdgeDriveSettings" /> property.</summary>
        private Commvault.Powershell.Models.IEdgeDriveSettings _edgeDriveSettings;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IEdgeDriveSettings EdgeDriveSettings { get => (this._edgeDriveSettings = this._edgeDriveSettings ?? new Commvault.Powershell.Models.EdgeDriveSettings()); set => this._edgeDriveSettings = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? IndexServerId { get => ((Commvault.Powershell.Models.IEdgeDriveSettingsInternal)EdgeDriveSettings).IndexServerId; set => ((Commvault.Powershell.Models.IEdgeDriveSettingsInternal)EdgeDriveSettings).IndexServerId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string IndexServerName { get => ((Commvault.Powershell.Models.IEdgeDriveSettingsInternal)EdgeDriveSettings).IndexServerName; set => ((Commvault.Powershell.Models.IEdgeDriveSettingsInternal)EdgeDriveSettings).IndexServerName = value ?? null; }

        /// <summary>Creates an new <see cref="AllowedFeatures" /> instance.</summary>
        public AllowedFeatures()
        {

        }
    }
    /// Get details about allowed features of a laptop plan
    public partial interface IAllowedFeatures :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Flag to enable archiving of laptop data</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to enable archiving of laptop data",
        SerializedName = @"archiving",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Archiving { get; set; }
        /// <summary>
        /// After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving
        /// rules
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving rules",
        SerializedName = @"afterArchiving",
        PossibleTypes = new [] { typeof(string) })]
        string ArchivingRuleAfterArchiving { get; set; }
        /// <summary>To archive files based on the Read-Only attribute, set to TRUE</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"To archive files based on the Read-Only attribute, set to TRUE",
        SerializedName = @"archiveReadOnlyFiles",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ArchivingRuleArchiveReadOnlyFiles { get; set; }
        /// <summary>
        /// To archive files based on the last accessed date of each file within the folder, specify the number of days
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"To archive files based on the last accessed date of each file within the folder, specify the number of days",
        SerializedName = @"fileAccessTimeOlderThan",
        PossibleTypes = new [] { typeof(int) })]
        int? ArchivingRuleFileAccessTimeOlderThan { get; set; }
        /// <summary>
        /// To archive files based on the time the files were created within the folder, specify the number of days
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"To archive files based on the time the files were created within the folder, specify the number of days",
        SerializedName = @"fileCreatedTimeOlderThan",
        PossibleTypes = new [] { typeof(int) })]
        int? ArchivingRuleFileCreatedTimeOlderThan { get; set; }
        /// <summary>
        /// To archive files based on the last modified date of each file within the folder, specify the number of days
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"To archive files based on the last modified date of each file within the folder, specify the number of days",
        SerializedName = @"fileModifiedTimeOlderThan",
        PossibleTypes = new [] { typeof(int) })]
        int? ArchivingRuleFileModifiedTimeOlderThan { get; set; }
        /// <summary>
        /// To archive files based on the size of the file, specify the minimum file size in KB. All files whose size ranges between
        /// the minimum and maximum values are archived.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"To archive files based on the size of the file, specify the minimum file size in KB. All files whose size ranges between the minimum and maximum values are archived.",
        SerializedName = @"fileSizeGreaterThan",
        PossibleTypes = new [] { typeof(int) })]
        int? ArchivingRuleFileSizeGreaterThan { get; set; }
        /// <summary>
        /// To archive files based on the size of the file, specify the maximum file size in KB. All files whose size ranges between
        /// the minimum and maximum values are archived.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"To archive files based on the size of the file, specify the maximum file size in KB. All files whose size ranges between the minimum and maximum values are archived.",
        SerializedName = @"maximumFileSize",
        PossibleTypes = new [] { typeof(int) })]
        int? ArchivingRuleMaximumFileSize { get; set; }
        /// <summary>
        /// When free disk space falls below specified amount (in percentage), start cleaning up the disk
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When free disk space falls below specified amount (in percentage), start cleaning up the disk",
        SerializedName = @"startCleaningIfLessThan",
        PossibleTypes = new [] { typeof(int) })]
        int? ArchivingRuleStartCleaningIfLessThan { get; set; }
        /// <summary>
        /// When free disk space more than specified amount (in percentage), stop cleaning up the disk
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When free disk space more than specified amount (in percentage), stop cleaning up the disk",
        SerializedName = @"stopCleaningIfupto",
        PossibleTypes = new [] { typeof(int) })]
        int? ArchivingRuleStopCleaningIfupto { get; set; }
        /// <summary>Flag to enable Data loss protection</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to enable Data loss protection",
        SerializedName = @"DLP",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Dlp { get; set; }
        /// <summary>Flag to enable Edge Drive</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to enable Edge Drive",
        SerializedName = @"edgeDrive",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EdgeDrive { get; set; }
        /// <summary>
        /// Enable auditing which logs the activities based on user interaction like creating, editing, moving, renaming, downloading
        /// or deleting files.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable auditing which logs the activities based on user interaction like creating, editing, moving, renaming, downloading or deleting files.",
        SerializedName = @"auditDriveOperations",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EdgeDriveSettingAuditDriveOperations { get; set; }
        /// <summary>
        /// Maximum number of gigabytes that you can store in the Edge Drive. Value as -1 means no quota is set.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of gigabytes that you can store in the Edge Drive. Value as -1 means no quota is set.",
        SerializedName = @"edgeDriveQuota",
        PossibleTypes = new [] { typeof(int) })]
        int? EdgeDriveSettingEdgeDriveQuota { get; set; }
        /// <summary>
        /// Enables alert notification feature which allows the share user or share owner to subscribe for share notifications when
        /// any activities are performed on the Edge Drive or the Collaborative share. The user can receive the notifications on the
        /// Web Console or as an email notification.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enables alert notification feature which allows the share user or share owner to subscribe for share notifications when any activities are performed on the Edge Drive or the Collaborative share. The user can receive the notifications on the Web Console or as an email notification.",
        SerializedName = @"notificationsForShares",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EdgeDriveSettingNotificationsForShares { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? IndexServerId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string IndexServerName { get; set; }

    }
    /// Get details about allowed features of a laptop plan
    internal partial interface IAllowedFeaturesInternal

    {
        /// <summary>Flag to enable archiving of laptop data</summary>
        bool? Archiving { get; set; }
        /// <summary>
        /// After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving
        /// rules
        /// </summary>
        string ArchivingRuleAfterArchiving { get; set; }
        /// <summary>To archive files based on the Read-Only attribute, set to TRUE</summary>
        bool? ArchivingRuleArchiveReadOnlyFiles { get; set; }
        /// <summary>
        /// To archive files based on the last accessed date of each file within the folder, specify the number of days
        /// </summary>
        int? ArchivingRuleFileAccessTimeOlderThan { get; set; }
        /// <summary>
        /// To archive files based on the time the files were created within the folder, specify the number of days
        /// </summary>
        int? ArchivingRuleFileCreatedTimeOlderThan { get; set; }
        /// <summary>
        /// To archive files based on the last modified date of each file within the folder, specify the number of days
        /// </summary>
        int? ArchivingRuleFileModifiedTimeOlderThan { get; set; }
        /// <summary>
        /// To archive files based on the size of the file, specify the minimum file size in KB. All files whose size ranges between
        /// the minimum and maximum values are archived.
        /// </summary>
        int? ArchivingRuleFileSizeGreaterThan { get; set; }
        /// <summary>
        /// To archive files based on the size of the file, specify the maximum file size in KB. All files whose size ranges between
        /// the minimum and maximum values are archived.
        /// </summary>
        int? ArchivingRuleMaximumFileSize { get; set; }
        /// <summary>
        /// When free disk space falls below specified amount (in percentage), start cleaning up the disk
        /// </summary>
        int? ArchivingRuleStartCleaningIfLessThan { get; set; }
        /// <summary>
        /// When free disk space more than specified amount (in percentage), stop cleaning up the disk
        /// </summary>
        int? ArchivingRuleStopCleaningIfupto { get; set; }
        /// <summary>These rules are enforced only when archiving is set to true</summary>
        Commvault.Powershell.Models.IArchivingRules ArchivingRules { get; set; }
        /// <summary>Flag to enable Data loss protection</summary>
        bool? Dlp { get; set; }
        /// <summary>Flag to enable Edge Drive</summary>
        bool? EdgeDrive { get; set; }
        /// <summary>
        /// Enable auditing which logs the activities based on user interaction like creating, editing, moving, renaming, downloading
        /// or deleting files.
        /// </summary>
        bool? EdgeDriveSettingAuditDriveOperations { get; set; }
        /// <summary>
        /// Maximum number of gigabytes that you can store in the Edge Drive. Value as -1 means no quota is set.
        /// </summary>
        int? EdgeDriveSettingEdgeDriveQuota { get; set; }

        Commvault.Powershell.Models.IIdName EdgeDriveSettingIndexServer { get; set; }
        /// <summary>
        /// Enables alert notification feature which allows the share user or share owner to subscribe for share notifications when
        /// any activities are performed on the Edge Drive or the Collaborative share. The user can receive the notifications on the
        /// Web Console or as an email notification.
        /// </summary>
        bool? EdgeDriveSettingNotificationsForShares { get; set; }

        Commvault.Powershell.Models.IEdgeDriveSettings EdgeDriveSettings { get; set; }

        int? IndexServerId { get; set; }

        string IndexServerName { get; set; }

    }
}