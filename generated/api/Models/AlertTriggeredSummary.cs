// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Summary of the Alert Triggered</summary>
    public partial class AlertTriggeredSummary :
        Commvault.Powershell.Models.IAlertTriggeredSummary,
        Commvault.Powershell.Models.IAlertTriggeredSummaryInternal
    {

        /// <summary>Backing field for <see cref="Client" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _client;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Client { get => (this._client = this._client ?? new Commvault.Powershell.Models.IdName()); set => this._client = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ClientId { get => ((Commvault.Powershell.Models.IIdNameInternal)Client).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Client).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ClientName { get => ((Commvault.Powershell.Models.IIdNameInternal)Client).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Client).Name = value ?? null; }

        /// <summary>Internal Acessors for Client</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IAlertTriggeredSummaryInternal.Client { get => (this._client = this._client ?? new Commvault.Powershell.Models.IdName()); set { {_client = value;} } }

        /// <summary>Internal Acessors for Company</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IAlertTriggeredSummaryInternal.Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set { {_company = value;} } }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _company;

        /// <summary>Organization corresponding to alert</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set => this._company = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? CompanyId { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name = value ?? null; }

        /// <summary>Backing field for <see cref="DetectedCriterion" /> property.</summary>
        private string _detectedCriterion;

        /// <summary>detection criteria for the triggered alert to be generated</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DetectedCriterion { get => this._detectedCriterion; set => this._detectedCriterion = value; }

        /// <summary>Backing field for <see cref="DetectedTime" /> property.</summary>
        private int? _detectedTime;

        /// <summary>Unix Epoch Time</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? DetectedTime { get => this._detectedTime; set => this._detectedTime = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        /// <summary>Triggered Alert Id</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Info" /> property.</summary>
        private string _info;

        /// <summary>Name of the Alert Triggered</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Info { get => this._info; set => this._info = value; }

        /// <summary>Backing field for <see cref="JobId" /> property.</summary>
        private int? _jobId;

        /// <summary>Job Id by which this Alert was Triggered</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? JobId { get => this._jobId; set => this._jobId = value; }

        /// <summary>Backing field for <see cref="Notes" /> property.</summary>
        private string _notes;

        /// <summary>contains any descriptive note written for the alert</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Notes { get => this._notes; set => this._notes = value; }

        /// <summary>Backing field for <see cref="ReadStatus" /> property.</summary>
        private bool? _readStatus;

        /// <summary>Gives the Alert Read Status. True if Read and False if Unread</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? ReadStatus { get => this._readStatus; set => this._readStatus = value; }

        /// <summary>Backing field for <see cref="Severity" /> property.</summary>
        private string _severity;

        /// <summary>Alert Severity Level</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Severity { get => this._severity; set => this._severity = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>alert type for which the triggered alert was generated</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="AlertTriggeredSummary" /> instance.</summary>
        public AlertTriggeredSummary()
        {

        }
    }
    /// Summary of the Alert Triggered
    public partial interface IAlertTriggeredSummary :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
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
        /// <summary>detection criteria for the triggered alert to be generated</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"detection criteria for the triggered alert to be generated",
        SerializedName = @"detectedCriterion",
        PossibleTypes = new [] { typeof(string) })]
        string DetectedCriterion { get; set; }
        /// <summary>Unix Epoch Time</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unix Epoch Time",
        SerializedName = @"detectedTime",
        PossibleTypes = new [] { typeof(int) })]
        int? DetectedTime { get; set; }
        /// <summary>Triggered Alert Id</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Triggered Alert Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }
        /// <summary>Name of the Alert Triggered</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the Alert Triggered",
        SerializedName = @"info",
        PossibleTypes = new [] { typeof(string) })]
        string Info { get; set; }
        /// <summary>Job Id by which this Alert was Triggered</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Job Id by which this Alert was Triggered",
        SerializedName = @"jobId",
        PossibleTypes = new [] { typeof(int) })]
        int? JobId { get; set; }
        /// <summary>contains any descriptive note written for the alert</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"contains any descriptive note written for the alert",
        SerializedName = @"notes",
        PossibleTypes = new [] { typeof(string) })]
        string Notes { get; set; }
        /// <summary>Gives the Alert Read Status. True if Read and False if Unread</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gives the Alert Read Status. True if Read and False if Unread",
        SerializedName = @"readStatus",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ReadStatus { get; set; }
        /// <summary>Alert Severity Level</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Alert Severity Level",
        SerializedName = @"severity",
        PossibleTypes = new [] { typeof(string) })]
        string Severity { get; set; }
        /// <summary>alert type for which the triggered alert was generated</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"alert type for which the triggered alert was generated",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Summary of the Alert Triggered
    internal partial interface IAlertTriggeredSummaryInternal

    {
        Commvault.Powershell.Models.IIdName Client { get; set; }

        int? ClientId { get; set; }

        string ClientName { get; set; }
        /// <summary>Organization corresponding to alert</summary>
        Commvault.Powershell.Models.IIdName Company { get; set; }

        int? CompanyId { get; set; }

        string CompanyName { get; set; }
        /// <summary>detection criteria for the triggered alert to be generated</summary>
        string DetectedCriterion { get; set; }
        /// <summary>Unix Epoch Time</summary>
        int? DetectedTime { get; set; }
        /// <summary>Triggered Alert Id</summary>
        int? Id { get; set; }
        /// <summary>Name of the Alert Triggered</summary>
        string Info { get; set; }
        /// <summary>Job Id by which this Alert was Triggered</summary>
        int? JobId { get; set; }
        /// <summary>contains any descriptive note written for the alert</summary>
        string Notes { get; set; }
        /// <summary>Gives the Alert Read Status. True if Read and False if Unread</summary>
        bool? ReadStatus { get; set; }
        /// <summary>Alert Severity Level</summary>
        string Severity { get; set; }
        /// <summary>alert type for which the triggered alert was generated</summary>
        string Type { get; set; }

    }
}