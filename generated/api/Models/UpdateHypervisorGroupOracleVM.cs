// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Update a hypervisor group with Oracle VM as the destination vendor</summary>
    public partial class UpdateHypervisorGroupOracleVM :
        Commvault.Powershell.Models.IUpdateHypervisorGroupOracleVM,
        Commvault.Powershell.Models.IUpdateHypervisorGroupOracleVMInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.IUpdateHypervisorGroupReq" />
        /// </summary>
        private Commvault.Powershell.Models.IUpdateHypervisorGroupReq __updateHypervisorGroupReq = new Commvault.Powershell.Models.UpdateHypervisorGroupReq();

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName[] AccessNodes { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).AccessNodes; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).AccessNodes = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IActivityControlOptions ActivityControl { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControl; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControl = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IBackupActivityControlOptionsProp ActivityControlBackupActivityControlOptions { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControlBackupActivityControlOptions; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControlBackupActivityControlOptions = value; }

        /// <summary>true if Backup is enabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? ActivityControlEnableBackup { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControlEnableBackup; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControlEnableBackup = value; }

        /// <summary>true if Restore is enabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? ActivityControlEnableRestore { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControlEnableRestore; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControlEnableRestore = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IBackupActivityControlOptionsProp ActivityControlRestoreActivityControlOptions { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControlRestoreActivityControlOptions; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControlRestoreActivityControlOptions = value; }

        /// <summary>Delayed by n Hrs</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string BackupActivityControlOptionDelayTime { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).BackupActivityControlOptionDelayTime; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).BackupActivityControlOptionDelayTime = value; }

        /// <summary>True if the activity will be enabled after a delay time interval</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? BackupActivityControlOptionEnableAfterDelay { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).BackupActivityControlOptionEnableAfterDelay; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).BackupActivityControlOptionEnableAfterDelay = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName BackupActivityControlOptionTimeZone { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).BackupActivityControlOptionTimeZone; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).BackupActivityControlOptionTimeZone = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? BackupActivityControlOptionsTimeZoneId { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).BackupActivityControlOptionsTimeZoneId; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).BackupActivityControlOptionsTimeZoneId = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string BackupActivityControlOptionsTimeZoneName { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).BackupActivityControlOptionsTimeZoneName; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).BackupActivityControlOptionsTimeZoneName = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName FbrUnixMediaAgent { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).FbrUnixMediaAgent; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).FbrUnixMediaAgent = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? FbrUnixMediaAgentId { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).FbrUnixMediaAgentId; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).FbrUnixMediaAgentId = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string FbrUnixMediaAgentName { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).FbrUnixMediaAgentName; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).FbrUnixMediaAgentName = value; }

        /// <summary>Backing field for <see cref="HypervisorType" /> property.</summary>
        private string _hypervisorType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string HypervisorType { get => this._hypervisorType; set => this._hypervisorType = value; }

        /// <summary>The name of the hypervisor that has to be changed</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string NewName { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).NewName; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).NewName = value; }

        /// <summary>Backing field for <see cref="OracleVMManager" /> property.</summary>
        private string _oracleVMManager;

        /// <summary>oracle VM Manager</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string OracleVMManager { get => this._oracleVMManager; set => this._oracleVMManager = value; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>password of the oracle VM info</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Delayed by n Hrs</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string RestoreActivityControlOptionDelayTime { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).RestoreActivityControlOptionDelayTime; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).RestoreActivityControlOptionDelayTime = value; }

        /// <summary>True if the activity will be enabled after a delay time interval</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? RestoreActivityControlOptionEnableAfterDelay { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).RestoreActivityControlOptionEnableAfterDelay; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).RestoreActivityControlOptionEnableAfterDelay = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName RestoreActivityControlOptionTimeZone { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).RestoreActivityControlOptionTimeZone; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).RestoreActivityControlOptionTimeZone = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? RestoreActivityControlOptionsTimeZoneId { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).RestoreActivityControlOptionsTimeZoneId; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).RestoreActivityControlOptionsTimeZoneId = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string RestoreActivityControlOptionsTimeZoneName { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).RestoreActivityControlOptionsTimeZoneName; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).RestoreActivityControlOptionsTimeZoneName = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IVMHypervisorSecurityProp Security { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).Security; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).Security = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName[] SecurityAssociatedUserGroups { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SecurityAssociatedUserGroups; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SecurityAssociatedUserGroups = value; }

        /// <summary>Client owners for the Hypervisor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string SecurityClientOwners { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SecurityClientOwners; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SecurityClientOwners = value; }

        /// <summary>if credential validation has to be skipped.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? SkipCredentialValidation { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SkipCredentialValidation; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SkipCredentialValidation = value; }

        /// <summary>Backing field for <see cref="UserName" /> property.</summary>
        private string _userName;

        /// <summary>Username of the oracle VM info</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UserName { get => this._userName; set => this._userName = value; }

        /// <summary>Creates an new <see cref="UpdateHypervisorGroupOracleVM" /> instance.</summary>
        public UpdateHypervisorGroupOracleVM()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Commvault.Powershell.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Commvault.Powershell.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__updateHypervisorGroupReq), __updateHypervisorGroupReq);
            await eventListener.AssertObjectIsValid(nameof(__updateHypervisorGroupReq), __updateHypervisorGroupReq);
        }
    }
    /// Update a hypervisor group with Oracle VM as the destination vendor
    public partial interface IUpdateHypervisorGroupOracleVM :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.IUpdateHypervisorGroupReq
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hypervisorType",
        PossibleTypes = new [] { typeof(string) })]
        string HypervisorType { get; set; }
        /// <summary>oracle VM Manager</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"oracle VM Manager",
        SerializedName = @"oracleVMManager",
        PossibleTypes = new [] { typeof(string) })]
        string OracleVMManager { get; set; }
        /// <summary>password of the oracle VM info</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"password of the oracle VM info",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }
        /// <summary>Username of the oracle VM info</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Username of the oracle VM info",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }

    }
    /// Update a hypervisor group with Oracle VM as the destination vendor
    internal partial interface IUpdateHypervisorGroupOracleVMInternal :
        Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal
    {
        string HypervisorType { get; set; }
        /// <summary>oracle VM Manager</summary>
        string OracleVMManager { get; set; }
        /// <summary>password of the oracle VM info</summary>
        string Password { get; set; }
        /// <summary>Username of the oracle VM info</summary>
        string UserName { get; set; }

    }
}