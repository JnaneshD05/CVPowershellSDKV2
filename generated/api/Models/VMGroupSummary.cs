// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class VMGroupSummary :
        Commvault.Powershell.Models.IVMGroupSummary,
        Commvault.Powershell.Models.IVMGroupSummaryInternal
    {

        /// <summary>Internal Acessors for Company</summary>
        Commvault.Powershell.Models.ICompanyInfo Commvault.Powershell.Models.IVMGroupSummaryInternal.Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.CompanyInfo()); set { {_company = value;} } }

        /// <summary>Internal Acessors for Hypervisor</summary>
        Commvault.Powershell.Models.IIdNameDisplayName Commvault.Powershell.Models.IVMGroupSummaryInternal.Hypervisor { get => (this._hypervisor = this._hypervisor ?? new Commvault.Powershell.Models.IdNameDisplayName()); set { {_hypervisor = value;} } }

        /// <summary>Internal Acessors for Instance</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IVMGroupSummaryInternal.Instance { get => (this._instance = this._instance ?? new Commvault.Powershell.Models.IdName()); set { {_instance = value;} } }

        /// <summary>Internal Acessors for LastBackup</summary>
        Commvault.Powershell.Models.ILastBackupJobInfo Commvault.Powershell.Models.IVMGroupSummaryInternal.LastBackup { get => (this._lastBackup = this._lastBackup ?? new Commvault.Powershell.Models.LastBackupJobInfo()); set { {_lastBackup = value;} } }

        /// <summary>Internal Acessors for Plan</summary>
        Commvault.Powershell.Models.IPlanIdNameType Commvault.Powershell.Models.IVMGroupSummaryInternal.Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.PlanIdNameType()); set { {_plan = value;} } }

        /// <summary>Internal Acessors for ReplicationGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IVMGroupSummaryInternal.ReplicationGroup { get => (this._replicationGroup = this._replicationGroup ?? new Commvault.Powershell.Models.IdName()); set { {_replicationGroup = value;} } }

        /// <summary>Internal Acessors for VMGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IVMGroupSummaryInternal.VMGroup { get => (this._vMGroup = this._vMGroup ?? new Commvault.Powershell.Models.IdName()); set { {_vMGroup = value;} } }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private Commvault.Powershell.Models.ICompanyInfo _company;

        /// <summary>companyInfo</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ICompanyInfo Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.CompanyInfo()); set => this._company = value; }

        /// <summary>Id of company</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? CompanyId { get => ((Commvault.Powershell.Models.ICompanyInfoInternal)Company).Id; set => ((Commvault.Powershell.Models.ICompanyInfoInternal)Company).Id = value ?? default(int); }

        /// <summary>Multi Commcell Id of company</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? CompanyMultiCommcellId { get => ((Commvault.Powershell.Models.ICompanyInfoInternal)Company).MultiCommcellId; set => ((Commvault.Powershell.Models.ICompanyInfoInternal)Company).MultiCommcellId = value ?? default(int); }

        /// <summary>Name of company</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Commvault.Powershell.Models.ICompanyInfoInternal)Company).Name; set => ((Commvault.Powershell.Models.ICompanyInfoInternal)Company).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Hypervisor" /> property.</summary>
        private Commvault.Powershell.Models.IIdNameDisplayName _hypervisor;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdNameDisplayName Hypervisor { get => (this._hypervisor = this._hypervisor ?? new Commvault.Powershell.Models.IdNameDisplayName()); set => this._hypervisor = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string HypervisorDisplayName { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Hypervisor).DisplayName; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Hypervisor).DisplayName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? HypervisorId { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Hypervisor).Id; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Hypervisor).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string HypervisorName { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Hypervisor).Name; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Hypervisor).Name = value ?? null; }

        /// <summary>Backing field for <see cref="HypervisorType" /> property.</summary>
        private string _hypervisorType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string HypervisorType { get => this._hypervisorType; set => this._hypervisorType = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="IndexingStatus" /> property.</summary>
        private string _indexingStatus;

        /// <summary>Type of indexing status.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string IndexingStatus { get => this._indexingStatus; set => this._indexingStatus = value; }

        /// <summary>Backing field for <see cref="Instance" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _instance;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Instance { get => (this._instance = this._instance ?? new Commvault.Powershell.Models.IdName()); set => this._instance = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? InstanceId { get => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string InstanceName { get => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Name = value ?? null; }

        /// <summary>Backing field for <see cref="IsDefaultVMGroup" /> property.</summary>
        private bool? _isDefaultVMGroup;

        /// <summary>True if subclient is default subclient</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? IsDefaultVMGroup { get => this._isDefaultVMGroup; set => this._isDefaultVMGroup = value; }

        /// <summary>Backing field for <see cref="LastBackup" /> property.</summary>
        private Commvault.Powershell.Models.ILastBackupJobInfo _lastBackup;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ILastBackupJobInfo LastBackup { get => (this._lastBackup = this._lastBackup ?? new Commvault.Powershell.Models.LastBackupJobInfo()); set => this._lastBackup = value; }

        /// <summary>Gives the reason for the last backup job failing, if the last backup job fails.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string LastBackupFailureReason { get => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).FailureReason; set => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).FailureReason = value ?? null; }

        /// <summary>Returns the job id of the last backup job performed.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? LastBackupJobId { get => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).JobId; set => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).JobId = value ?? default(int); }

        /// <summary>Status of the last backup job performed.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string LastBackupStatus { get => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).Status; set => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).Status = value ?? null; }

        /// <summary>
        /// Shows the time when the last back up job was carried out. The time is provided in unix time format.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? LastBackupTime { get => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).Time; set => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).Time = value ?? default(long); }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private Commvault.Powershell.Models.IPlanIdNameType _plan;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IPlanIdNameType Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.PlanIdNameType()); set => this._plan = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? PlanId { get => ((Commvault.Powershell.Models.IPlanIdNameTypeInternal)Plan).Id; set => ((Commvault.Powershell.Models.IPlanIdNameTypeInternal)Plan).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PlanName { get => ((Commvault.Powershell.Models.IPlanIdNameTypeInternal)Plan).Name; set => ((Commvault.Powershell.Models.IPlanIdNameTypeInternal)Plan).Name = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PlanSubType { get => ((Commvault.Powershell.Models.IPlanIdNameTypeInternal)Plan).SubType; set => ((Commvault.Powershell.Models.IPlanIdNameTypeInternal)Plan).SubType = value ?? null; }

        /// <summary>Backing field for <see cref="ReplicationGroup" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _replicationGroup;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName ReplicationGroup { get => (this._replicationGroup = this._replicationGroup ?? new Commvault.Powershell.Models.IdName()); set => this._replicationGroup = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ReplicationGroupId { get => ((Commvault.Powershell.Models.IIdNameInternal)ReplicationGroup).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)ReplicationGroup).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ReplicationGroupName { get => ((Commvault.Powershell.Models.IIdNameInternal)ReplicationGroup).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)ReplicationGroup).Name = value ?? null; }

        /// <summary>Backing field for <see cref="SnapBackupEnabled" /> property.</summary>
        private bool? _snapBackupEnabled;

        /// <summary>true if snap backup enabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? SnapBackupEnabled { get => this._snapBackupEnabled; set => this._snapBackupEnabled = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="StoragePolicyRetentionExtension" /> property.</summary>
        private bool? _storagePolicyRetentionExtension;

        /// <summary>True if extend storage policy Retention was set in VMGroup for deleted files</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? StoragePolicyRetentionExtension { get => this._storagePolicyRetentionExtension; set => this._storagePolicyRetentionExtension = value; }

        /// <summary>Backing field for <see cref="Tags" /> property.</summary>
        private Commvault.Powershell.Models.IIdNameValue[] _tags;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdNameValue[] Tags { get => this._tags; set => this._tags = value; }

        /// <summary>Backing field for <see cref="VMGroup" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _vMGroup;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName VMGroup { get => (this._vMGroup = this._vMGroup ?? new Commvault.Powershell.Models.IdName()); set => this._vMGroup = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? VMGroupId { get => ((Commvault.Powershell.Models.IIdNameInternal)VMGroup).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)VMGroup).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string VMGroupName { get => ((Commvault.Powershell.Models.IIdNameInternal)VMGroup).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)VMGroup).Name = value ?? null; }

        /// <summary>Creates an new <see cref="VMGroupSummary" /> instance.</summary>
        public VMGroupSummary()
        {

        }
    }
    public partial interface IVMGroupSummary :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Id of company</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of company",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? CompanyId { get; set; }
        /// <summary>Multi Commcell Id of company</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Multi Commcell Id of company",
        SerializedName = @"multiCommcellId",
        PossibleTypes = new [] { typeof(int) })]
        int? CompanyMultiCommcellId { get; set; }
        /// <summary>Name of company</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of company",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string HypervisorDisplayName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? HypervisorId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string HypervisorName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"HypervisorType",
        PossibleTypes = new [] { typeof(string) })]
        string HypervisorType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }
        /// <summary>Type of indexing status.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of indexing status.",
        SerializedName = @"indexingStatus",
        PossibleTypes = new [] { typeof(string) })]
        string IndexingStatus { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? InstanceId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceName { get; set; }
        /// <summary>True if subclient is default subclient</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if subclient is default subclient",
        SerializedName = @"isDefaultVMGroup",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDefaultVMGroup { get; set; }
        /// <summary>Gives the reason for the last backup job failing, if the last backup job fails.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gives the reason for the last backup job failing, if the last backup job fails.",
        SerializedName = @"failureReason",
        PossibleTypes = new [] { typeof(string) })]
        string LastBackupFailureReason { get; set; }
        /// <summary>Returns the job id of the last backup job performed.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Returns the job id of the last backup job performed.",
        SerializedName = @"jobId",
        PossibleTypes = new [] { typeof(int) })]
        int? LastBackupJobId { get; set; }
        /// <summary>Status of the last backup job performed.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status of the last backup job performed.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string LastBackupStatus { get; set; }
        /// <summary>
        /// Shows the time when the last back up job was carried out. The time is provided in unix time format.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Shows the time when the last back up job was carried out. The time is provided in unix time format.",
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(long) })]
        long? LastBackupTime { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? PlanId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string PlanName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"subType",
        PossibleTypes = new [] { typeof(string) })]
        string PlanSubType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? ReplicationGroupId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicationGroupName { get; set; }
        /// <summary>true if snap backup enabled</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @" true if snap backup enabled",
        SerializedName = @"SnapBackupEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SnapBackupEnabled { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>True if extend storage policy Retention was set in VMGroup for deleted files</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if extend storage policy Retention was set in VMGroup for deleted files",
        SerializedName = @"storagePolicyRetentionExtension",
        PossibleTypes = new [] { typeof(bool) })]
        bool? StoragePolicyRetentionExtension { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdNameValue) })]
        Commvault.Powershell.Models.IIdNameValue[] Tags { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? VMGroupId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string VMGroupName { get; set; }

    }
    internal partial interface IVMGroupSummaryInternal

    {
        /// <summary>companyInfo</summary>
        Commvault.Powershell.Models.ICompanyInfo Company { get; set; }
        /// <summary>Id of company</summary>
        int? CompanyId { get; set; }
        /// <summary>Multi Commcell Id of company</summary>
        int? CompanyMultiCommcellId { get; set; }
        /// <summary>Name of company</summary>
        string CompanyName { get; set; }

        Commvault.Powershell.Models.IIdNameDisplayName Hypervisor { get; set; }

        string HypervisorDisplayName { get; set; }

        int? HypervisorId { get; set; }

        string HypervisorName { get; set; }

        string HypervisorType { get; set; }

        int? Id { get; set; }
        /// <summary>Type of indexing status.</summary>
        string IndexingStatus { get; set; }

        Commvault.Powershell.Models.IIdName Instance { get; set; }

        int? InstanceId { get; set; }

        string InstanceName { get; set; }
        /// <summary>True if subclient is default subclient</summary>
        bool? IsDefaultVMGroup { get; set; }

        Commvault.Powershell.Models.ILastBackupJobInfo LastBackup { get; set; }
        /// <summary>Gives the reason for the last backup job failing, if the last backup job fails.</summary>
        string LastBackupFailureReason { get; set; }
        /// <summary>Returns the job id of the last backup job performed.</summary>
        int? LastBackupJobId { get; set; }
        /// <summary>Status of the last backup job performed.</summary>
        string LastBackupStatus { get; set; }
        /// <summary>
        /// Shows the time when the last back up job was carried out. The time is provided in unix time format.
        /// </summary>
        long? LastBackupTime { get; set; }

        string Name { get; set; }

        Commvault.Powershell.Models.IPlanIdNameType Plan { get; set; }

        int? PlanId { get; set; }

        string PlanName { get; set; }

        string PlanSubType { get; set; }

        Commvault.Powershell.Models.IIdName ReplicationGroup { get; set; }

        int? ReplicationGroupId { get; set; }

        string ReplicationGroupName { get; set; }
        /// <summary>true if snap backup enabled</summary>
        bool? SnapBackupEnabled { get; set; }

        string Status { get; set; }
        /// <summary>True if extend storage policy Retention was set in VMGroup for deleted files</summary>
        bool? StoragePolicyRetentionExtension { get; set; }

        Commvault.Powershell.Models.IIdNameValue[] Tags { get; set; }

        Commvault.Powershell.Models.IIdName VMGroup { get; set; }

        int? VMGroupId { get; set; }

        string VMGroupName { get; set; }

    }
}