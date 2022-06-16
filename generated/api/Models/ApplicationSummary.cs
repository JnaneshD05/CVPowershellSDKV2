// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Gives the summary of the virtual machines.</summary>
    public partial class ApplicationSummary :
        Commvault.Powershell.Models.IApplicationSummary,
        Commvault.Powershell.Models.IApplicationSummaryInternal
    {

        /// <summary>Backing field for <see cref="ApplicationGroup" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _applicationGroup;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName ApplicationGroup { get => (this._applicationGroup = this._applicationGroup ?? new Commvault.Powershell.Models.IdName()); set => this._applicationGroup = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ApplicationGroupId { get => ((Commvault.Powershell.Models.IIdNameInternal)ApplicationGroup).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)ApplicationGroup).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ApplicationGroupName { get => ((Commvault.Powershell.Models.IIdNameInternal)ApplicationGroup).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)ApplicationGroup).Name = value ?? null; }

        /// <summary>Backing field for <see cref="ApplicationSize" /> property.</summary>
        private int? _applicationSize;

        /// <summary>The total space allocated(in bytes) for the virtual machine.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? ApplicationSize { get => this._applicationSize; set => this._applicationSize = value; }

        /// <summary>Backing field for <see cref="Cluster" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _cluster;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Cluster { get => (this._cluster = this._cluster ?? new Commvault.Powershell.Models.IdName()); set => this._cluster = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ClusterId { get => ((Commvault.Powershell.Models.IIdNameInternal)Cluster).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Cluster).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ClusterName { get => ((Commvault.Powershell.Models.IIdNameInternal)Cluster).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Cluster).Name = value ?? null; }

        /// <summary>Backing field for <see cref="CommcellName" /> property.</summary>
        private string _commcellName;

        /// <summary>Name of the commcell the VM belongs</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CommcellName { get => this._commcellName; set => this._commcellName = value; }

        /// <summary>Internal Acessors for ApplicationGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IApplicationSummaryInternal.ApplicationGroup { get => (this._applicationGroup = this._applicationGroup ?? new Commvault.Powershell.Models.IdName()); set { {_applicationGroup = value;} } }

        /// <summary>Internal Acessors for Cluster</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IApplicationSummaryInternal.Cluster { get => (this._cluster = this._cluster ?? new Commvault.Powershell.Models.IdName()); set { {_cluster = value;} } }

        /// <summary>Internal Acessors for Company</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IApplicationSummaryInternal.Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set { {_company = value;} } }

        /// <summary>Internal Acessors for LastBackup</summary>
        Commvault.Powershell.Models.ILastBackup Commvault.Powershell.Models.IApplicationSummaryInternal.LastBackup { get => (this._lastBackup = this._lastBackup ?? new Commvault.Powershell.Models.LastBackup()); set { {_lastBackup = value;} } }

        /// <summary>Internal Acessors for Plan</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IApplicationSummaryInternal.Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.IdName()); set { {_plan = value;} } }

        /// <summary>Internal Acessors for Sla</summary>
        Commvault.Powershell.Models.IVMSla Commvault.Powershell.Models.IApplicationSummaryInternal.Sla { get => (this._sla = this._sla ?? new Commvault.Powershell.Models.VMSla()); set { {_sla = value;} } }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _company;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set => this._company = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? CompanyId { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Host" /> property.</summary>
        private string _host;

        /// <summary>
        /// The host name for the computer where the source virtual machine or instance resides.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Host { get => this._host; set => this._host = value; }

        /// <summary>Backing field for <see cref="K8ApplicationSize" /> property.</summary>
        private int? _k8ApplicationSize;

        /// <summary>The amount of data being protected for the VM client(in bytes)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? K8ApplicationSize { get => this._k8ApplicationSize; set => this._k8ApplicationSize = value; }

        /// <summary>Backing field for <see cref="LastBackup" /> property.</summary>
        private Commvault.Powershell.Models.ILastBackup _lastBackup;

        /// <summary>last backup job details for the client</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ILastBackup LastBackup { get => (this._lastBackup = this._lastBackup ?? new Commvault.Powershell.Models.LastBackup()); set => this._lastBackup = value; }

        /// <summary>Failure reason for the last backup job</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string LastBackupFailureReason { get => ((Commvault.Powershell.Models.ILastBackupInternal)LastBackup).FailureReason; set => ((Commvault.Powershell.Models.ILastBackupInternal)LastBackup).FailureReason = value ?? null; }

        /// <summary>Job id of the last backup job</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? LastBackupJobId { get => ((Commvault.Powershell.Models.ILastBackupInternal)LastBackup).JobId; set => ((Commvault.Powershell.Models.ILastBackupInternal)LastBackup).JobId = value ?? default(int); }

        /// <summary>UNIX time for the last successful backup job run</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? LastBackupLastSuccessfulBackupTime { get => ((Commvault.Powershell.Models.ILastBackupInternal)LastBackup).LastSuccessfulBackupTime; set => ((Commvault.Powershell.Models.ILastBackupInternal)LastBackup).LastSuccessfulBackupTime = value ?? default(int); }

        /// <summary>Status of the last backup job performed.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string LastBackupStatus { get => ((Commvault.Powershell.Models.ILastBackupInternal)LastBackup).Status; set => ((Commvault.Powershell.Models.ILastBackupInternal)LastBackup).Status = value ?? null; }

        /// <summary>UNIX time for the last backup job run</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? LastBackupTime { get => ((Commvault.Powershell.Models.ILastBackupInternal)LastBackup).Time; set => ((Commvault.Powershell.Models.ILastBackupInternal)LastBackup).Time = value ?? default(int); }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The display name of the VM.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="OS" /> property.</summary>
        private string _oS;

        /// <summary>The operating system version for the VM or instance.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string OS { get => this._oS; set => this._oS = value; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _plan;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.IdName()); set => this._plan = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? PlanId { get => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PlanName { get => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Sla" /> property.</summary>
        private Commvault.Powershell.Models.IVMSla _sla;

        /// <summary>VMSLA</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IVMSla Sla { get => (this._sla = this._sla ?? new Commvault.Powershell.Models.VMSla()); set => this._sla = value; }

        /// <summary>The reason for the current SLA status of the VM client</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SlaReason { get => ((Commvault.Powershell.Models.IVMSlaInternal)Sla).Reason; set => ((Commvault.Powershell.Models.IVMSlaInternal)Sla).Reason = value ?? null; }

        /// <summary>Provides the SLA status.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SlaStatus { get => ((Commvault.Powershell.Models.IVMSlaInternal)Sla).Status; set => ((Commvault.Powershell.Models.IVMSlaInternal)Sla).Status = value ?? null; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status of the backup for the VM, instance, or container.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="Uuid" /> property.</summary>
        private string _uuid;

        /// <summary>The globally unique identifier for the VM client.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Uuid { get => this._uuid; set => this._uuid = value; }

        /// <summary>Backing field for <see cref="Vendor" /> property.</summary>
        private string _vendor;

        /// <summary>The hypervisor where the VM is located.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Vendor { get => this._vendor; set => this._vendor = value; }

        /// <summary>Creates an new <see cref="ApplicationSummary" /> instance.</summary>
        public ApplicationSummary()
        {

        }
    }
    /// Gives the summary of the virtual machines.
    public partial interface IApplicationSummary :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? ApplicationGroupId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationGroupName { get; set; }
        /// <summary>The total space allocated(in bytes) for the virtual machine.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total space allocated(in bytes) for the virtual machine.",
        SerializedName = @"applicationSize",
        PossibleTypes = new [] { typeof(int) })]
        int? ApplicationSize { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? ClusterId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterName { get; set; }
        /// <summary>Name of the commcell the VM belongs</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the commcell the VM belongs",
        SerializedName = @"commcellName",
        PossibleTypes = new [] { typeof(string) })]
        string CommcellName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? CompanyId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyName { get; set; }
        /// <summary>
        /// The host name for the computer where the source virtual machine or instance resides.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The host name for the computer where the source virtual machine or instance resides.",
        SerializedName = @"host",
        PossibleTypes = new [] { typeof(string) })]
        string Host { get; set; }
        /// <summary>The amount of data being protected for the VM client(in bytes)</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The amount of data being protected for the VM client(in bytes)",
        SerializedName = @"K8applicationSize",
        PossibleTypes = new [] { typeof(int) })]
        int? K8ApplicationSize { get; set; }
        /// <summary>Failure reason for the last backup job</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Failure reason for the last backup job",
        SerializedName = @"failureReason",
        PossibleTypes = new [] { typeof(string) })]
        string LastBackupFailureReason { get; set; }
        /// <summary>Job id of the last backup job</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Job id of the last backup job",
        SerializedName = @"jobId",
        PossibleTypes = new [] { typeof(int) })]
        int? LastBackupJobId { get; set; }
        /// <summary>UNIX time for the last successful backup job run</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"UNIX time for the last successful backup job run",
        SerializedName = @"lastSuccessfulBackupTime",
        PossibleTypes = new [] { typeof(int) })]
        int? LastBackupLastSuccessfulBackupTime { get; set; }
        /// <summary>Status of the last backup job performed.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status of the last backup job performed.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string LastBackupStatus { get; set; }
        /// <summary>UNIX time for the last backup job run</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"UNIX time for the last backup job run",
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(int) })]
        int? LastBackupTime { get; set; }
        /// <summary>The display name of the VM.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the VM.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The operating system version for the VM or instance.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The operating system version for the VM or instance.",
        SerializedName = @"os",
        PossibleTypes = new [] { typeof(string) })]
        string OS { get; set; }

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
        /// <summary>The reason for the current SLA status of the VM client</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reason for the current SLA status of the VM client",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        string SlaReason { get; set; }
        /// <summary>Provides the SLA status.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provides the SLA status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string SlaStatus { get; set; }
        /// <summary>The status of the backup for the VM, instance, or container.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the backup for the VM, instance, or  container.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>The globally unique identifier for the VM client.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The globally unique identifier for the VM client.",
        SerializedName = @"UUID",
        PossibleTypes = new [] { typeof(string) })]
        string Uuid { get; set; }
        /// <summary>The hypervisor where the VM is located.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The hypervisor where the VM is located.",
        SerializedName = @"vendor",
        PossibleTypes = new [] { typeof(string) })]
        string Vendor { get; set; }

    }
    /// Gives the summary of the virtual machines.
    internal partial interface IApplicationSummaryInternal

    {
        Commvault.Powershell.Models.IIdName ApplicationGroup { get; set; }

        int? ApplicationGroupId { get; set; }

        string ApplicationGroupName { get; set; }
        /// <summary>The total space allocated(in bytes) for the virtual machine.</summary>
        int? ApplicationSize { get; set; }

        Commvault.Powershell.Models.IIdName Cluster { get; set; }

        int? ClusterId { get; set; }

        string ClusterName { get; set; }
        /// <summary>Name of the commcell the VM belongs</summary>
        string CommcellName { get; set; }

        Commvault.Powershell.Models.IIdName Company { get; set; }

        int? CompanyId { get; set; }

        string CompanyName { get; set; }
        /// <summary>
        /// The host name for the computer where the source virtual machine or instance resides.
        /// </summary>
        string Host { get; set; }
        /// <summary>The amount of data being protected for the VM client(in bytes)</summary>
        int? K8ApplicationSize { get; set; }
        /// <summary>last backup job details for the client</summary>
        Commvault.Powershell.Models.ILastBackup LastBackup { get; set; }
        /// <summary>Failure reason for the last backup job</summary>
        string LastBackupFailureReason { get; set; }
        /// <summary>Job id of the last backup job</summary>
        int? LastBackupJobId { get; set; }
        /// <summary>UNIX time for the last successful backup job run</summary>
        int? LastBackupLastSuccessfulBackupTime { get; set; }
        /// <summary>Status of the last backup job performed.</summary>
        string LastBackupStatus { get; set; }
        /// <summary>UNIX time for the last backup job run</summary>
        int? LastBackupTime { get; set; }
        /// <summary>The display name of the VM.</summary>
        string Name { get; set; }
        /// <summary>The operating system version for the VM or instance.</summary>
        string OS { get; set; }

        Commvault.Powershell.Models.IIdName Plan { get; set; }

        int? PlanId { get; set; }

        string PlanName { get; set; }
        /// <summary>VMSLA</summary>
        Commvault.Powershell.Models.IVMSla Sla { get; set; }
        /// <summary>The reason for the current SLA status of the VM client</summary>
        string SlaReason { get; set; }
        /// <summary>Provides the SLA status.</summary>
        string SlaStatus { get; set; }
        /// <summary>The status of the backup for the VM, instance, or container.</summary>
        string Status { get; set; }
        /// <summary>The globally unique identifier for the VM client.</summary>
        string Uuid { get; set; }
        /// <summary>The hypervisor where the VM is located.</summary>
        string Vendor { get; set; }

    }
}