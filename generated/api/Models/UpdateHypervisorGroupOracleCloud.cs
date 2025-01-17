// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Update a hypervisor group with oracleCloud as the destination vendor</summary>
    public partial class UpdateHypervisorGroupOracleCloud :
        Commvault.Powershell.Models.IUpdateHypervisorGroupOracleCloud,
        Commvault.Powershell.Models.IUpdateHypervisorGroupOracleCloudInternal,
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

        /// <summary>Backing field for <see cref="FingerPrint" /> property.</summary>
        private string _fingerPrint;

        /// <summary>Finger print for the private key</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string FingerPrint { get => this._fingerPrint; set => this._fingerPrint = value; }

        /// <summary>Backing field for <see cref="HypervisorType" /> property.</summary>
        private string _hypervisorType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string HypervisorType { get => this._hypervisorType; set => this._hypervisorType = value; }

        /// <summary>The name of the hypervisor that has to be changed</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string NewName { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).NewName; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).NewName = value; }

        /// <summary>Backing field for <see cref="PrivateKeyFileName" /> property.</summary>
        private string _privateKeyFileName;

        /// <summary>File Name for the private key</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string PrivateKeyFileName { get => this._privateKeyFileName; set => this._privateKeyFileName = value; }

        /// <summary>Backing field for <see cref="PrivateKeyPassword" /> property.</summary>
        private string _privateKeyPassword;

        /// <summary>
        /// password for the private key.This is the passphrase that was used to encrypt the private key.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string PrivateKeyPassword { get => this._privateKeyPassword; set => this._privateKeyPassword = value; }

        /// <summary>Backing field for <see cref="RegionName" /> property.</summary>
        private string _regionName;

        /// <summary>home region for the tenant</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string RegionName { get => this._regionName; set => this._regionName = value; }

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

        /// <summary>Backing field for <see cref="TenancyOcId" /> property.</summary>
        private string _tenancyOcId;

        /// <summary>OCID for the tenant.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string TenancyOcId { get => this._tenancyOcId; set => this._tenancyOcId = value; }

        /// <summary>Backing field for <see cref="UserOcId" /> property.</summary>
        private string _userOcId;

        /// <summary>OCID for the admin user for the hypervisor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UserOcId { get => this._userOcId; set => this._userOcId = value; }

        /// <summary>Creates an new <see cref="UpdateHypervisorGroupOracleCloud" /> instance.</summary>
        public UpdateHypervisorGroupOracleCloud()
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
    /// Update a hypervisor group with oracleCloud as the destination vendor
    public partial interface IUpdateHypervisorGroupOracleCloud :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.IUpdateHypervisorGroupReq
    {
        /// <summary>Finger print for the private key</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Finger print for the private key",
        SerializedName = @"fingerPrint",
        PossibleTypes = new [] { typeof(string) })]
        string FingerPrint { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hypervisorType",
        PossibleTypes = new [] { typeof(string) })]
        string HypervisorType { get; set; }
        /// <summary>File Name for the private key</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"File Name for the private key",
        SerializedName = @"privateKeyFileName",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateKeyFileName { get; set; }
        /// <summary>
        /// password for the private key.This is the passphrase that was used to encrypt the private key.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"password for the private key.This is the passphrase that was used to encrypt the private key.",
        SerializedName = @"privateKeyPassword",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateKeyPassword { get; set; }
        /// <summary>home region for the tenant</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"home region for the tenant",
        SerializedName = @"regionName",
        PossibleTypes = new [] { typeof(string) })]
        string RegionName { get; set; }
        /// <summary>OCID for the tenant.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"OCID for the tenant.",
        SerializedName = @"tenancyOCId",
        PossibleTypes = new [] { typeof(string) })]
        string TenancyOcId { get; set; }
        /// <summary>OCID for the admin user for the hypervisor</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"OCID for the admin user for the hypervisor",
        SerializedName = @"userOCId",
        PossibleTypes = new [] { typeof(string) })]
        string UserOcId { get; set; }

    }
    /// Update a hypervisor group with oracleCloud as the destination vendor
    internal partial interface IUpdateHypervisorGroupOracleCloudInternal :
        Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal
    {
        /// <summary>Finger print for the private key</summary>
        string FingerPrint { get; set; }

        string HypervisorType { get; set; }
        /// <summary>File Name for the private key</summary>
        string PrivateKeyFileName { get; set; }
        /// <summary>
        /// password for the private key.This is the passphrase that was used to encrypt the private key.
        /// </summary>
        string PrivateKeyPassword { get; set; }
        /// <summary>home region for the tenant</summary>
        string RegionName { get; set; }
        /// <summary>OCID for the tenant.</summary>
        string TenancyOcId { get; set; }
        /// <summary>OCID for the admin user for the hypervisor</summary>
        string UserOcId { get; set; }

    }
}