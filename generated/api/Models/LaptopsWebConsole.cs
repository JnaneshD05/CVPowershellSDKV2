// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class LaptopsWebConsole :
        Commvault.Powershell.Models.ILaptopsWebConsole,
        Commvault.Powershell.Models.ILaptopsWebConsoleInternal
    {

        /// <summary>Internal Acessors for LastBackupJobInfo</summary>
        Commvault.Powershell.Models.ILastBackupJobInfo Commvault.Powershell.Models.ILaptopsWebConsoleInternal.LastBackupJobInfo { get => (this._lastBackupJobInfo = this._lastBackupJobInfo ?? new Commvault.Powershell.Models.LastBackupJobInfo()); set { {_lastBackupJobInfo = value;} } }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        /// <summary>id of the laptop client</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="LastBackupJobInfo" /> property.</summary>
        private Commvault.Powershell.Models.ILastBackupJobInfo _lastBackupJobInfo;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ILastBackupJobInfo LastBackupJobInfo { get => (this._lastBackupJobInfo = this._lastBackupJobInfo ?? new Commvault.Powershell.Models.LastBackupJobInfo()); set => this._lastBackupJobInfo = value; }

        /// <summary>Gives the reason for the last backup job failing, if the last backup job fails.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string LastBackupJobInfoFailureReason { get => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackupJobInfo).FailureReason; set => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackupJobInfo).FailureReason = value ?? null; }

        /// <summary>Returns the job id of the last backup job performed.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? LastBackupJobInfoJobId { get => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackupJobInfo).JobId; set => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackupJobInfo).JobId = value ?? default(int); }

        /// <summary>Status of the last backup job performed.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string LastBackupJobInfoStatus { get => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackupJobInfo).Status; set => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackupJobInfo).Status = value ?? null; }

        /// <summary>
        /// Shows the time when the last back up job was carried out. The time is provided in unix time format.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? LastBackupJobInfoTime { get => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackupJobInfo).Time; set => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackupJobInfo).Time = value ?? default(long); }

        /// <summary>Backing field for <see cref="LastBackupTime" /> property.</summary>
        private int? _lastBackupTime;

        /// <summary>This specifies the last backup time (in unix timestamp)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? LastBackupTime { get => this._lastBackupTime; set => this._lastBackupTime = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>name of the laptop client</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="NextBackupTime" /> property.</summary>
        private int? _nextBackupTime;

        /// <summary>This species the timestamp (in unix timestamp) of the next scheduled backup</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? NextBackupTime { get => this._nextBackupTime; set => this._nextBackupTime = value; }

        /// <summary>Backing field for <see cref="SlaReason" /> property.</summary>
        private string _slaReason;

        /// <summary>reason for the current sla status</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SlaReason { get => this._slaReason; set => this._slaReason = value; }

        /// <summary>Backing field for <see cref="SlaStatus" /> property.</summary>
        private string _slaStatus;

        /// <summary>Provides the SLA status.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SlaStatus { get => this._slaStatus; set => this._slaStatus = value; }

        /// <summary>Backing field for <see cref="TotalBackupSize" /> property.</summary>
        private int? _totalBackupSize;

        /// <summary>This specifies the total backup size (in bytes)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? TotalBackupSize { get => this._totalBackupSize; set => this._totalBackupSize = value; }

        /// <summary>Creates an new <see cref="LaptopsWebConsole" /> instance.</summary>
        public LaptopsWebConsole()
        {

        }
    }
    public partial interface ILaptopsWebConsole :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>id of the laptop client</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"id of the laptop client",
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
        string LastBackupJobInfoFailureReason { get; set; }
        /// <summary>Returns the job id of the last backup job performed.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Returns the job id of the last backup job performed.",
        SerializedName = @"jobId",
        PossibleTypes = new [] { typeof(int) })]
        int? LastBackupJobInfoJobId { get; set; }
        /// <summary>Status of the last backup job performed.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status of the last backup job performed.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string LastBackupJobInfoStatus { get; set; }
        /// <summary>
        /// Shows the time when the last back up job was carried out. The time is provided in unix time format.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Shows the time when the last back up job was carried out. The time is provided in unix time format.",
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(long) })]
        long? LastBackupJobInfoTime { get; set; }
        /// <summary>This specifies the last backup time (in unix timestamp)</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This specifies the last backup time (in unix timestamp)",
        SerializedName = @"lastBackupTime",
        PossibleTypes = new [] { typeof(int) })]
        int? LastBackupTime { get; set; }
        /// <summary>name of the laptop client</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"name of the laptop client",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>This species the timestamp (in unix timestamp) of the next scheduled backup</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This species the timestamp (in unix timestamp) of the next scheduled backup",
        SerializedName = @"nextBackupTime",
        PossibleTypes = new [] { typeof(int) })]
        int? NextBackupTime { get; set; }
        /// <summary>reason for the current sla status</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"reason for the current sla status",
        SerializedName = @"slaReason",
        PossibleTypes = new [] { typeof(string) })]
        string SlaReason { get; set; }
        /// <summary>Provides the SLA status.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provides the SLA status.",
        SerializedName = @"slaStatus",
        PossibleTypes = new [] { typeof(string) })]
        string SlaStatus { get; set; }
        /// <summary>This specifies the total backup size (in bytes)</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This specifies the total backup size (in bytes)",
        SerializedName = @"totalBackupSize",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalBackupSize { get; set; }

    }
    internal partial interface ILaptopsWebConsoleInternal

    {
        /// <summary>id of the laptop client</summary>
        int? Id { get; set; }

        Commvault.Powershell.Models.ILastBackupJobInfo LastBackupJobInfo { get; set; }
        /// <summary>Gives the reason for the last backup job failing, if the last backup job fails.</summary>
        string LastBackupJobInfoFailureReason { get; set; }
        /// <summary>Returns the job id of the last backup job performed.</summary>
        int? LastBackupJobInfoJobId { get; set; }
        /// <summary>Status of the last backup job performed.</summary>
        string LastBackupJobInfoStatus { get; set; }
        /// <summary>
        /// Shows the time when the last back up job was carried out. The time is provided in unix time format.
        /// </summary>
        long? LastBackupJobInfoTime { get; set; }
        /// <summary>This specifies the last backup time (in unix timestamp)</summary>
        int? LastBackupTime { get; set; }
        /// <summary>name of the laptop client</summary>
        string Name { get; set; }
        /// <summary>This species the timestamp (in unix timestamp) of the next scheduled backup</summary>
        int? NextBackupTime { get; set; }
        /// <summary>reason for the current sla status</summary>
        string SlaReason { get; set; }
        /// <summary>Provides the SLA status.</summary>
        string SlaStatus { get; set; }
        /// <summary>This specifies the total backup size (in bytes)</summary>
        int? TotalBackupSize { get; set; }

    }
}