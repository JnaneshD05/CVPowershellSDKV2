// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class PlanBackupDestination :
        Commvault.Powershell.Models.IPlanBackupDestination,
        Commvault.Powershell.Models.IPlanBackupDestinationInternal
    {

        /// <summary>Backing field for <see cref="BackupStartTime" /> property.</summary>
        private int? _backupStartTime;

        /// <summary>
        /// Backup start time in number of seconds. The time is provided in unix time format.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? BackupStartTime { get => this._backupStartTime; set => this._backupStartTime = value; }

        /// <summary>Backing field for <see cref="BackupsToCopy" /> property.</summary>
        private string _backupsToCopy;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string BackupsToCopy { get => this._backupsToCopy; set => this._backupsToCopy = value; }

        /// <summary>Internal Acessors for ExtendedRetentionRuleFirstExtendedRetentionRule</summary>
        Commvault.Powershell.Models.IPlanRetentionRule Commvault.Powershell.Models.IPlanBackupDestinationInternal.ExtendedRetentionRuleFirstExtendedRetentionRule { get => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).FirstExtendedRetentionRule; set => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).FirstExtendedRetentionRule = value; }

        /// <summary>Internal Acessors for ExtendedRetentionRuleSecondExtendedRetentionRule</summary>
        Commvault.Powershell.Models.IPlanRetentionRule Commvault.Powershell.Models.IPlanBackupDestinationInternal.ExtendedRetentionRuleSecondExtendedRetentionRule { get => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).SecondExtendedRetentionRule; set => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).SecondExtendedRetentionRule = value; }

        /// <summary>Internal Acessors for ExtendedRetentionRuleThirdExtendedRetentionRule</summary>
        Commvault.Powershell.Models.IPlanRetentionRule Commvault.Powershell.Models.IPlanBackupDestinationInternal.ExtendedRetentionRuleThirdExtendedRetentionRule { get => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).ThirdExtendedRetentionRule; set => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).ThirdExtendedRetentionRule = value; }

        /// <summary>Internal Acessors for ExtendedRetentionRules</summary>
        Commvault.Powershell.Models.IExtendedRetentionRules Commvault.Powershell.Models.IPlanBackupDestinationInternal.ExtendedRetentionRules { get => (this._extendedRetentionRules = this._extendedRetentionRules ?? new Commvault.Powershell.Models.ExtendedRetentionRules()); set { {_extendedRetentionRules = value;} } }

        /// <summary>Internal Acessors for PlanBackupDestinationPlanBackupDestination</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IPlanBackupDestinationInternal.PlanBackupDestinationPlanBackupDestination { get => (this._planBackupDestinationPlanBackupDestination = this._planBackupDestinationPlanBackupDestination ?? new Commvault.Powershell.Models.IdName()); set { {_planBackupDestinationPlanBackupDestination = value;} } }

        /// <summary>Internal Acessors for Region</summary>
        Commvault.Powershell.Models.IIdNameDisplayName Commvault.Powershell.Models.IPlanBackupDestinationInternal.Region { get => (this._region = this._region ?? new Commvault.Powershell.Models.IdNameDisplayName()); set { {_region = value;} } }

        /// <summary>Internal Acessors for SourceCopy</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IPlanBackupDestinationInternal.SourceCopy { get => (this._sourceCopy = this._sourceCopy ?? new Commvault.Powershell.Models.IdName()); set { {_sourceCopy = value;} } }

        /// <summary>Internal Acessors for StoragePool</summary>
        Commvault.Powershell.Models.IStoragePool Commvault.Powershell.Models.IPlanBackupDestinationInternal.StoragePool { get => (this._storagePool = this._storagePool ?? new Commvault.Powershell.Models.StoragePool()); set { {_storagePool = value;} } }

        /// <summary>Backing field for <see cref="CopyType" /> property.</summary>
        private string _copyType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CopyType { get => this._copyType; set => this._copyType = value; }

        /// <summary>Backing field for <see cref="CopyTypeName" /> property.</summary>
        private string _copyTypeName;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CopyTypeName { get => this._copyTypeName; set => this._copyTypeName = value; }

        /// <summary>Backing field for <see cref="ExtendedRetentionRules" /> property.</summary>
        private Commvault.Powershell.Models.IExtendedRetentionRules _extendedRetentionRules;

        /// <summary>
        /// If you want to update, specify the whole object. Extended retention rules should be bigger than retention period.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IExtendedRetentionRules ExtendedRetentionRules { get => (this._extendedRetentionRules = this._extendedRetentionRules ?? new Commvault.Powershell.Models.ExtendedRetentionRules()); set => this._extendedRetentionRules = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? FirstExtendedRetentionRuleIsInfiniteRetention { get => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).FirstExtendedRetentionRuleIsInfiniteRetention; set => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).FirstExtendedRetentionRuleIsInfiniteRetention = value ?? default(bool); }

        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? FirstExtendedRetentionRuleRetentionPeriodDays { get => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).FirstExtendedRetentionRuleRetentionPeriodDays; set => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).FirstExtendedRetentionRuleRetentionPeriodDays = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string FirstExtendedRetentionRuleType { get => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).FirstExtendedRetentionRuleType; set => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).FirstExtendedRetentionRuleType = value ?? null; }

        /// <summary>Backing field for <see cref="IsDefault" /> property.</summary>
        private bool? _isDefault;

        /// <summary>Is this a default backup destination?</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? IsDefault { get => this._isDefault; set => this._isDefault = value; }

        /// <summary>Backing field for <see cref="IsMirrorCopy" /> property.</summary>
        private bool? _isMirrorCopy;

        /// <summary>Is this a mirror copy?</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? IsMirrorCopy { get => this._isMirrorCopy; set => this._isMirrorCopy = value; }

        /// <summary>Backing field for <see cref="IsSnapCopy" /> property.</summary>
        private bool? _isSnapCopy;

        /// <summary>Is this a snap copy?</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? IsSnapCopy { get => this._isSnapCopy; set => this._isSnapCopy = value; }

        /// <summary>Backing field for <see cref="Mappings" /> property.</summary>
        private Commvault.Powershell.Models.ISnapshotCopyMapping[] _mappings;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.ISnapshotCopyMapping[] Mappings { get => this._mappings; set => this._mappings = value; }

        /// <summary>Backing field for <see cref="NetAppCloudTarget" /> property.</summary>
        private bool? _netAppCloudTarget;

        /// <summary>
        /// Only for snap copy. Tells if the snap copy supports SVM Mapping to NetApp cloud targets only.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? NetAppCloudTarget { get => this._netAppCloudTarget; set => this._netAppCloudTarget = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? PlanBackupDestinationId { get => ((Commvault.Powershell.Models.IIdNameInternal)PlanBackupDestinationPlanBackupDestination).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)PlanBackupDestinationPlanBackupDestination).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PlanBackupDestinationName { get => ((Commvault.Powershell.Models.IIdNameInternal)PlanBackupDestinationPlanBackupDestination).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)PlanBackupDestinationPlanBackupDestination).Name = value ?? null; }

        /// <summary>
        /// Backing field for <see cref="PlanBackupDestinationPlanBackupDestination" /> property.
        /// </summary>
        private Commvault.Powershell.Models.IIdName _planBackupDestinationPlanBackupDestination;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName PlanBackupDestinationPlanBackupDestination { get => (this._planBackupDestinationPlanBackupDestination = this._planBackupDestinationPlanBackupDestination ?? new Commvault.Powershell.Models.IdName()); set => this._planBackupDestinationPlanBackupDestination = value; }

        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private Commvault.Powershell.Models.IIdNameDisplayName _region;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdNameDisplayName Region { get => (this._region = this._region ?? new Commvault.Powershell.Models.IdNameDisplayName()); set => this._region = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RegionDisplayName { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).DisplayName; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).DisplayName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? RegionId { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).Id; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RegionName { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).Name; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).Name = value ?? null; }

        /// <summary>Backing field for <see cref="RetentionPeriodDays" /> property.</summary>
        private int? _retentionPeriodDays;

        /// <summary>Retention period in days</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? RetentionPeriodDays { get => this._retentionPeriodDays; set => this._retentionPeriodDays = value; }

        /// <summary>Backing field for <see cref="RetentionRuleType" /> property.</summary>
        private string _retentionRuleType;

        /// <summary>Which type of retention rule should be used for the given backup destination</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string RetentionRuleType { get => this._retentionRuleType; set => this._retentionRuleType = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? SecondExtendedRetentionRuleIsInfiniteRetention { get => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).SecondExtendedRetentionRuleIsInfiniteRetention; set => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).SecondExtendedRetentionRuleIsInfiniteRetention = value ?? default(bool); }

        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SecondExtendedRetentionRuleRetentionPeriodDays { get => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).SecondExtendedRetentionRuleRetentionPeriodDays; set => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).SecondExtendedRetentionRuleRetentionPeriodDays = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SecondExtendedRetentionRuleType { get => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).SecondExtendedRetentionRuleType; set => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).SecondExtendedRetentionRuleType = value ?? null; }

        /// <summary>Backing field for <see cref="SnapRecoveryPoints" /> property.</summary>
        private int? _snapRecoveryPoints;

        /// <summary>Number of snap recovery points for snap copy for retention</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? SnapRecoveryPoints { get => this._snapRecoveryPoints; set => this._snapRecoveryPoints = value; }

        /// <summary>Backing field for <see cref="SourceCopy" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _sourceCopy;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName SourceCopy { get => (this._sourceCopy = this._sourceCopy ?? new Commvault.Powershell.Models.IdName()); set => this._sourceCopy = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SourceCopyId { get => ((Commvault.Powershell.Models.IIdNameInternal)SourceCopy).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)SourceCopy).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SourceCopyName { get => ((Commvault.Powershell.Models.IIdNameInternal)SourceCopy).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)SourceCopy).Name = value ?? null; }

        /// <summary>Backing field for <see cref="StoragePool" /> property.</summary>
        private Commvault.Powershell.Models.IStoragePool _storagePool;

        /// <summary>StoragePool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IStoragePool StoragePool { get => (this._storagePool = this._storagePool ?? new Commvault.Powershell.Models.StoragePool()); set => this._storagePool = value; }

        /// <summary>Id of Storage Pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? StoragePoolId { get => ((Commvault.Powershell.Models.IStoragePoolInternal)StoragePool).Id; set => ((Commvault.Powershell.Models.IStoragePoolInternal)StoragePool).Id = value ?? default(int); }

        /// <summary>Name of Storage Pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string StoragePoolName { get => ((Commvault.Powershell.Models.IStoragePoolInternal)StoragePool).Name; set => ((Commvault.Powershell.Models.IStoragePoolInternal)StoragePool).Name = value ?? null; }

        /// <summary>Type of Storage Pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string StoragePoolType { get => ((Commvault.Powershell.Models.IStoragePoolInternal)StoragePool).Type; set => ((Commvault.Powershell.Models.IStoragePoolInternal)StoragePool).Type = value ?? null; }

        /// <summary>Backing field for <see cref="StorageType" /> property.</summary>
        private string _storageType;

        /// <summary>StorageType</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string StorageType { get => this._storageType; set => this._storageType = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ThirdExtendedRetentionRuleIsInfiniteRetention { get => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).ThirdExtendedRetentionRuleIsInfiniteRetention; set => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).ThirdExtendedRetentionRuleIsInfiniteRetention = value ?? default(bool); }

        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ThirdExtendedRetentionRuleRetentionPeriodDays { get => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).ThirdExtendedRetentionRuleRetentionPeriodDays; set => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).ThirdExtendedRetentionRuleRetentionPeriodDays = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ThirdExtendedRetentionRuleType { get => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).ThirdExtendedRetentionRuleType; set => ((Commvault.Powershell.Models.IExtendedRetentionRulesInternal)ExtendedRetentionRules).ThirdExtendedRetentionRuleType = value ?? null; }

        /// <summary>Backing field for <see cref="UseExtendedRetentionRules" /> property.</summary>
        private bool? _useExtendedRetentionRules;

        /// <summary>Should extended retention rules be used</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? UseExtendedRetentionRules { get => this._useExtendedRetentionRules; set => this._useExtendedRetentionRules = value; }

        /// <summary>Creates an new <see cref="PlanBackupDestination" /> instance.</summary>
        public PlanBackupDestination()
        {

        }
    }
    public partial interface IPlanBackupDestination :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Backup start time in number of seconds. The time is provided in unix time format.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Backup start time in number of seconds. The time is provided in unix time format.",
        SerializedName = @"backupStartTime",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupStartTime { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"backupsToCopy",
        PossibleTypes = new [] { typeof(string) })]
        string BackupsToCopy { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"copyType",
        PossibleTypes = new [] { typeof(string) })]
        string CopyType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"copyTypeName",
        PossibleTypes = new [] { typeof(string) })]
        string CopyTypeName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isInfiniteRetention",
        PossibleTypes = new [] { typeof(bool) })]
        bool? FirstExtendedRetentionRuleIsInfiniteRetention { get; set; }
        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.",
        SerializedName = @"retentionPeriodDays",
        PossibleTypes = new [] { typeof(int) })]
        int? FirstExtendedRetentionRuleRetentionPeriodDays { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string FirstExtendedRetentionRuleType { get; set; }
        /// <summary>Is this a default backup destination?</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is this a default backup destination?",
        SerializedName = @"isDefault",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDefault { get; set; }
        /// <summary>Is this a mirror copy?</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is this a mirror copy?",
        SerializedName = @"isMirrorCopy",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsMirrorCopy { get; set; }
        /// <summary>Is this a snap copy?</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is this a snap copy?",
        SerializedName = @"isSnapCopy",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsSnapCopy { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"mappings",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ISnapshotCopyMapping) })]
        Commvault.Powershell.Models.ISnapshotCopyMapping[] Mappings { get; set; }
        /// <summary>
        /// Only for snap copy. Tells if the snap copy supports SVM Mapping to NetApp cloud targets only.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Only for snap copy. Tells if the snap copy supports SVM Mapping to NetApp cloud targets only.",
        SerializedName = @"netAppCloudTarget",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NetAppCloudTarget { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? PlanBackupDestinationId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string PlanBackupDestinationName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string RegionDisplayName { get; set; }

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
        /// <summary>Retention period in days</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Retention period in days",
        SerializedName = @"retentionPeriodDays",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionPeriodDays { get; set; }
        /// <summary>Which type of retention rule should be used for the given backup destination</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Which type of retention rule should be used for the given backup destination",
        SerializedName = @"retentionRuleType",
        PossibleTypes = new [] { typeof(string) })]
        string RetentionRuleType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isInfiniteRetention",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SecondExtendedRetentionRuleIsInfiniteRetention { get; set; }
        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.",
        SerializedName = @"retentionPeriodDays",
        PossibleTypes = new [] { typeof(int) })]
        int? SecondExtendedRetentionRuleRetentionPeriodDays { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string SecondExtendedRetentionRuleType { get; set; }
        /// <summary>Number of snap recovery points for snap copy for retention</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of snap recovery points for snap copy for retention",
        SerializedName = @"snapRecoveryPoints",
        PossibleTypes = new [] { typeof(int) })]
        int? SnapRecoveryPoints { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? SourceCopyId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SourceCopyName { get; set; }
        /// <summary>Id of Storage Pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of Storage Pool",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? StoragePoolId { get; set; }
        /// <summary>Name of Storage Pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of Storage Pool",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string StoragePoolName { get; set; }
        /// <summary>Type of Storage Pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of Storage Pool",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string StoragePoolType { get; set; }
        /// <summary>StorageType</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"StorageType",
        SerializedName = @"storageType",
        PossibleTypes = new [] { typeof(string) })]
        string StorageType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isInfiniteRetention",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ThirdExtendedRetentionRuleIsInfiniteRetention { get; set; }
        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.",
        SerializedName = @"retentionPeriodDays",
        PossibleTypes = new [] { typeof(int) })]
        int? ThirdExtendedRetentionRuleRetentionPeriodDays { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string ThirdExtendedRetentionRuleType { get; set; }
        /// <summary>Should extended retention rules be used</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Should extended retention rules be used",
        SerializedName = @"useExtendedRetentionRules",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseExtendedRetentionRules { get; set; }

    }
    internal partial interface IPlanBackupDestinationInternal

    {
        /// <summary>
        /// Backup start time in number of seconds. The time is provided in unix time format.
        /// </summary>
        int? BackupStartTime { get; set; }

        string BackupsToCopy { get; set; }

        string CopyType { get; set; }

        string CopyTypeName { get; set; }

        Commvault.Powershell.Models.IPlanRetentionRule ExtendedRetentionRuleFirstExtendedRetentionRule { get; set; }

        Commvault.Powershell.Models.IPlanRetentionRule ExtendedRetentionRuleSecondExtendedRetentionRule { get; set; }

        Commvault.Powershell.Models.IPlanRetentionRule ExtendedRetentionRuleThirdExtendedRetentionRule { get; set; }
        /// <summary>
        /// If you want to update, specify the whole object. Extended retention rules should be bigger than retention period.
        /// </summary>
        Commvault.Powershell.Models.IExtendedRetentionRules ExtendedRetentionRules { get; set; }

        bool? FirstExtendedRetentionRuleIsInfiniteRetention { get; set; }
        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        int? FirstExtendedRetentionRuleRetentionPeriodDays { get; set; }

        string FirstExtendedRetentionRuleType { get; set; }
        /// <summary>Is this a default backup destination?</summary>
        bool? IsDefault { get; set; }
        /// <summary>Is this a mirror copy?</summary>
        bool? IsMirrorCopy { get; set; }
        /// <summary>Is this a snap copy?</summary>
        bool? IsSnapCopy { get; set; }

        Commvault.Powershell.Models.ISnapshotCopyMapping[] Mappings { get; set; }
        /// <summary>
        /// Only for snap copy. Tells if the snap copy supports SVM Mapping to NetApp cloud targets only.
        /// </summary>
        bool? NetAppCloudTarget { get; set; }

        int? PlanBackupDestinationId { get; set; }

        string PlanBackupDestinationName { get; set; }

        Commvault.Powershell.Models.IIdName PlanBackupDestinationPlanBackupDestination { get; set; }

        Commvault.Powershell.Models.IIdNameDisplayName Region { get; set; }

        string RegionDisplayName { get; set; }

        int? RegionId { get; set; }

        string RegionName { get; set; }
        /// <summary>Retention period in days</summary>
        int? RetentionPeriodDays { get; set; }
        /// <summary>Which type of retention rule should be used for the given backup destination</summary>
        string RetentionRuleType { get; set; }

        bool? SecondExtendedRetentionRuleIsInfiniteRetention { get; set; }
        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        int? SecondExtendedRetentionRuleRetentionPeriodDays { get; set; }

        string SecondExtendedRetentionRuleType { get; set; }
        /// <summary>Number of snap recovery points for snap copy for retention</summary>
        int? SnapRecoveryPoints { get; set; }

        Commvault.Powershell.Models.IIdName SourceCopy { get; set; }

        int? SourceCopyId { get; set; }

        string SourceCopyName { get; set; }
        /// <summary>StoragePool</summary>
        Commvault.Powershell.Models.IStoragePool StoragePool { get; set; }
        /// <summary>Id of Storage Pool</summary>
        int? StoragePoolId { get; set; }
        /// <summary>Name of Storage Pool</summary>
        string StoragePoolName { get; set; }
        /// <summary>Type of Storage Pool</summary>
        string StoragePoolType { get; set; }
        /// <summary>StorageType</summary>
        string StorageType { get; set; }

        bool? ThirdExtendedRetentionRuleIsInfiniteRetention { get; set; }
        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        int? ThirdExtendedRetentionRuleRetentionPeriodDays { get; set; }

        string ThirdExtendedRetentionRuleType { get; set; }
        /// <summary>Should extended retention rules be used</summary>
        bool? UseExtendedRetentionRules { get; set; }

    }
}