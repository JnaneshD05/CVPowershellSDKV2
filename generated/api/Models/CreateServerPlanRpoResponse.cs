// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class CreateServerPlanRpoResponse :
        Commvault.Powershell.Models.ICreateServerPlanRpoResponse,
        Commvault.Powershell.Models.ICreateServerPlanRpoResponseInternal
    {

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IPlanSchedule[] BackupFrequencySchedules { get => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).BackupFrequencySchedules; set => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).BackupFrequencySchedules = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Error</summary>
        Commvault.Powershell.Models.IGenericResp Commvault.Powershell.Models.ICreateServerPlanRpoResponseInternal.Error { get => (this._error = this._error ?? new Commvault.Powershell.Models.GenericResp()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Rpo</summary>
        Commvault.Powershell.Models.IServerBackupPlanRpo Commvault.Powershell.Models.ICreateServerPlanRpoResponseInternal.Rpo { get => (this._rpo = this._rpo ?? new Commvault.Powershell.Models.ServerBackupPlanRpo()); set { {_rpo = value;} } }

        /// <summary>Internal Acessors for RpoBackupFrequency</summary>
        Commvault.Powershell.Models.IPlanSchedules Commvault.Powershell.Models.ICreateServerPlanRpoResponseInternal.RpoBackupFrequency { get => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).BackupFrequency; set => ((Commvault.Powershell.Models.IServerBackupPlanRpoInternal)Rpo).BackupFrequency = value; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Commvault.Powershell.Models.IGenericResp _error;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IGenericResp Error { get => (this._error = this._error ?? new Commvault.Powershell.Models.GenericResp()); set => this._error = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ErrorCode { get => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorCode; set => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorCode = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ErrorMessage { get => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorMessage; set => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorMessage = value ?? null; }

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

        /// <summary>Creates an new <see cref="CreateServerPlanRpoResponse" /> instance.</summary>
        public CreateServerPlanRpoResponse()
        {

        }
    }
    public partial interface ICreateServerPlanRpoResponse :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"schedules",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IPlanSchedule) })]
        Commvault.Powershell.Models.IPlanSchedule[] BackupFrequencySchedules { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"errorCode",
        PossibleTypes = new [] { typeof(int) })]
        int? ErrorCode { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"errorMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorMessage { get; set; }
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

    }
    internal partial interface ICreateServerPlanRpoResponseInternal

    {
        Commvault.Powershell.Models.IPlanSchedule[] BackupFrequencySchedules { get; set; }

        Commvault.Powershell.Models.IGenericResp Error { get; set; }

        int? ErrorCode { get; set; }

        string ErrorMessage { get; set; }
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

    }
}