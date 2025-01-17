// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Gives the summary of each instance.</summary>
    public partial class InstanceSummary :
        Commvault.Powershell.Models.IInstanceSummary,
        Commvault.Powershell.Models.IInstanceSummaryInternal
    {

        /// <summary>Backing field for <see cref="ApplicationSize" /> property.</summary>
        private int? _applicationSize;

        /// <summary>Gives the application size of the instance. It is returned in bytes.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? ApplicationSize { get => this._applicationSize; set => this._applicationSize = value; }

        /// <summary>Backing field for <see cref="Client" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _client;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Client { get => (this._client = this._client ?? new Commvault.Powershell.Models.IdName()); set => this._client = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ClientId { get => ((Commvault.Powershell.Models.IIdNameInternal)Client).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Client).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ClientName { get => ((Commvault.Powershell.Models.IIdNameInternal)Client).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Client).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Commcell" /> property.</summary>
        private Commvault.Powershell.Models.ICommcellInfo _commcell;

        /// <summary>CommcellInfo</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ICommcellInfo Commcell { get => (this._commcell = this._commcell ?? new Commvault.Powershell.Models.CommcellInfo()); set => this._commcell = value; }

        /// <summary>Name of the commcell the entity belongs to.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CommcellName { get => ((Commvault.Powershell.Models.ICommcellInfoInternal)Commcell).Name; set => ((Commvault.Powershell.Models.ICommcellInfoInternal)Commcell).Name = value ?? null; }

        /// <summary>Internal Acessors for Client</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IInstanceSummaryInternal.Client { get => (this._client = this._client ?? new Commvault.Powershell.Models.IdName()); set { {_client = value;} } }

        /// <summary>Internal Acessors for Commcell</summary>
        Commvault.Powershell.Models.ICommcellInfo Commvault.Powershell.Models.IInstanceSummaryInternal.Commcell { get => (this._commcell = this._commcell ?? new Commvault.Powershell.Models.CommcellInfo()); set { {_commcell = value;} } }

        /// <summary>Internal Acessors for Company</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IInstanceSummaryInternal.Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set { {_company = value;} } }

        /// <summary>Internal Acessors for LastBackup</summary>
        Commvault.Powershell.Models.ILastBackupJobInfo Commvault.Powershell.Models.IInstanceSummaryInternal.LastBackup { get => (this._lastBackup = this._lastBackup ?? new Commvault.Powershell.Models.LastBackupJobInfo()); set { {_lastBackup = value;} } }

        /// <summary>Internal Acessors for Plan</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IInstanceSummaryInternal.Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.IdName()); set { {_plan = value;} } }

        /// <summary>Internal Acessors for Sla</summary>
        Commvault.Powershell.Models.ISlaDetails Commvault.Powershell.Models.IInstanceSummaryInternal.Sla { get => (this._sla = this._sla ?? new Commvault.Powershell.Models.SlaDetails()); set { {_sla = value;} } }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _company;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set => this._company = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? CompanyId { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name = value ?? null; }

        /// <summary>Backing field for <see cref="DatabaseEngine" /> property.</summary>
        private string _databaseEngine;

        /// <summary>
        /// Name of database engine which is the underlying software component that a database management system uses to create, read,
        /// update and delete data from the database.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DatabaseEngine { get => this._databaseEngine; set => this._databaseEngine = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        /// <summary>Gives the id of the instance.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

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

        /// <summary>Gives the name of the instance.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="NotReadyReason" /> property.</summary>
        private string _notReadyReason;

        /// <summary>
        /// If the instance isn't ready, this provides the reason as to why the instance isn't ready.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NotReadyReason { get => this._notReadyReason; set => this._notReadyReason = value; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _plan;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.IdName()); set => this._plan = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? PlanId { get => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PlanName { get => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Server" /> property.</summary>
        private string _server;

        /// <summary>Gives the server to which the instance belongs to.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Server { get => this._server; set => this._server = value; }

        /// <summary>Backing field for <see cref="Sla" /> property.</summary>
        private Commvault.Powershell.Models.ISlaDetails _sla;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ISlaDetails Sla { get => (this._sla = this._sla ?? new Commvault.Powershell.Models.SlaDetails()); set => this._sla = value; }

        /// <summary>Provides a reason on why the SLA might not be met.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IReasonDetails[] SlaReasonList { get => ((Commvault.Powershell.Models.ISlaDetailsInternal)Sla).ReasonList; set => ((Commvault.Powershell.Models.ISlaDetailsInternal)Sla).ReasonList = value ?? null /* arrayOf */; }

        /// <summary>Provides the SLA status.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SlaStatus { get => ((Commvault.Powershell.Models.ISlaDetailsInternal)Sla).Status; set => ((Commvault.Powershell.Models.ISlaDetailsInternal)Sla).Status = value ?? null; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>
        /// The status of the instance. If the instance isn't ready, the reason is also provided.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="Vendor" /> property.</summary>
        private string _vendor;

        /// <summary>The cloud vendor for the instance.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Vendor { get => this._vendor; set => this._vendor = value; }

        /// <summary>Creates an new <see cref="InstanceSummary" /> instance.</summary>
        public InstanceSummary()
        {

        }
    }
    /// Gives the summary of each instance.
    public partial interface IInstanceSummary :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Gives the application size of the instance. It is returned in bytes.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gives the application size of the instance. It is returned in bytes.",
        SerializedName = @"applicationSize",
        PossibleTypes = new [] { typeof(int) })]
        int? ApplicationSize { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? ClientId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ClientName { get; set; }
        /// <summary>Name of the commcell the entity belongs to.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the commcell the entity belongs to.",
        SerializedName = @"name",
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
        /// Name of database engine which is the underlying software component that a database management system uses to create, read,
        /// update and delete data from the database.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of database engine which is the underlying software component that a database management system uses to create, read, update and delete data from the database.",
        SerializedName = @"databaseEngine",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseEngine { get; set; }
        /// <summary>Gives the id of the instance.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gives the id of the instance.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }
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
        /// <summary>Gives the name of the instance.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gives the name of the instance.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// If the instance isn't ready, this provides the reason as to why the instance isn't ready.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If the instance isn't ready, this provides the reason as to why the instance isn't ready.",
        SerializedName = @"notReadyReason",
        PossibleTypes = new [] { typeof(string) })]
        string NotReadyReason { get; set; }

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
        /// <summary>Gives the server to which the instance belongs to.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gives the server to which the instance belongs to.",
        SerializedName = @"server",
        PossibleTypes = new [] { typeof(string) })]
        string Server { get; set; }
        /// <summary>Provides a reason on why the SLA might not be met.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provides a reason on why the SLA might not be met.",
        SerializedName = @"reasonList",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IReasonDetails) })]
        Commvault.Powershell.Models.IReasonDetails[] SlaReasonList { get; set; }
        /// <summary>Provides the SLA status.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provides the SLA status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string SlaStatus { get; set; }
        /// <summary>
        /// The status of the instance. If the instance isn't ready, the reason is also provided.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the instance. If the instance isn't ready, the reason is also provided.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>The cloud vendor for the instance.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The cloud vendor for the instance.",
        SerializedName = @"vendor",
        PossibleTypes = new [] { typeof(string) })]
        string Vendor { get; set; }

    }
    /// Gives the summary of each instance.
    internal partial interface IInstanceSummaryInternal

    {
        /// <summary>Gives the application size of the instance. It is returned in bytes.</summary>
        int? ApplicationSize { get; set; }

        Commvault.Powershell.Models.IIdName Client { get; set; }

        int? ClientId { get; set; }

        string ClientName { get; set; }
        /// <summary>CommcellInfo</summary>
        Commvault.Powershell.Models.ICommcellInfo Commcell { get; set; }
        /// <summary>Name of the commcell the entity belongs to.</summary>
        string CommcellName { get; set; }

        Commvault.Powershell.Models.IIdName Company { get; set; }

        int? CompanyId { get; set; }

        string CompanyName { get; set; }
        /// <summary>
        /// Name of database engine which is the underlying software component that a database management system uses to create, read,
        /// update and delete data from the database.
        /// </summary>
        string DatabaseEngine { get; set; }
        /// <summary>Gives the id of the instance.</summary>
        int? Id { get; set; }

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
        /// <summary>Gives the name of the instance.</summary>
        string Name { get; set; }
        /// <summary>
        /// If the instance isn't ready, this provides the reason as to why the instance isn't ready.
        /// </summary>
        string NotReadyReason { get; set; }

        Commvault.Powershell.Models.IIdName Plan { get; set; }

        int? PlanId { get; set; }

        string PlanName { get; set; }
        /// <summary>Gives the server to which the instance belongs to.</summary>
        string Server { get; set; }

        Commvault.Powershell.Models.ISlaDetails Sla { get; set; }
        /// <summary>Provides a reason on why the SLA might not be met.</summary>
        Commvault.Powershell.Models.IReasonDetails[] SlaReasonList { get; set; }
        /// <summary>Provides the SLA status.</summary>
        string SlaStatus { get; set; }
        /// <summary>
        /// The status of the instance. If the instance isn't ready, the reason is also provided.
        /// </summary>
        string Status { get; set; }
        /// <summary>The cloud vendor for the instance.</summary>
        string Vendor { get; set; }

    }
}