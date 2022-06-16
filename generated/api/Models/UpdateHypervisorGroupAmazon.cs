// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Update a hypervisor group with Amazon as the destination vendor</summary>
    public partial class UpdateHypervisorGroupAmazon :
        Commvault.Powershell.Models.IUpdateHypervisorGroupAmazon,
        Commvault.Powershell.Models.IUpdateHypervisorGroupAmazonInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.IUpdateHypervisorGroupReq" />
        /// </summary>
        private Commvault.Powershell.Models.IUpdateHypervisorGroupReq __updateHypervisorGroupReq = new Commvault.Powershell.Models.UpdateHypervisorGroupReq();

        /// <summary>Backing field for <see cref="AccessKey" /> property.</summary>
        private string _accessKey;

        /// <summary>Access Key of Amazon login</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string AccessKey { get => this._accessKey; set => this._accessKey = value; }

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

        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private string _region;

        /// <summary>AWS region if Iam role is used</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Region { get => this._region; set => this._region = value; }

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

        /// <summary>Backing field for <see cref="RoleArn" /> property.</summary>
        private string _roleArn;

        /// <summary>Role ARN for STS assume role with IAM policy</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string RoleArn { get => this._roleArn; set => this._roleArn = value; }

        /// <summary>Backing field for <see cref="SecretKey" /> property.</summary>
        private string _secretKey;

        /// <summary>secret Key of Amazon login</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SecretKey { get => this._secretKey; set => this._secretKey = value; }

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

        /// <summary>Backing field for <see cref="UseIamRole" /> property.</summary>
        private bool? _useIamRole;

        /// <summary>if Iam Role is used</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? UseIamRole { get => this._useIamRole; set => this._useIamRole = value; }

        /// <summary>Backing field for <see cref="UseServiceAccount" /> property.</summary>
        private string _useServiceAccount;

        /// <summary>Clientname to be used as Admin Account</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UseServiceAccount { get => this._useServiceAccount; set => this._useServiceAccount = value; }

        /// <summary>Creates an new <see cref="UpdateHypervisorGroupAmazon" /> instance.</summary>
        public UpdateHypervisorGroupAmazon()
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
    /// Update a hypervisor group with Amazon as the destination vendor
    public partial interface IUpdateHypervisorGroupAmazon :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.IUpdateHypervisorGroupReq
    {
        /// <summary>Access Key of Amazon login</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Access Key of Amazon login",
        SerializedName = @"accessKey",
        PossibleTypes = new [] { typeof(string) })]
        string AccessKey { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hypervisorType",
        PossibleTypes = new [] { typeof(string) })]
        string HypervisorType { get; set; }
        /// <summary>AWS region if Iam role is used</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"AWS region if Iam role is used",
        SerializedName = @"Region",
        PossibleTypes = new [] { typeof(string) })]
        string Region { get; set; }
        /// <summary>Role ARN for STS assume role with IAM policy</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Role ARN for STS assume role with IAM policy",
        SerializedName = @"RoleARN",
        PossibleTypes = new [] { typeof(string) })]
        string RoleArn { get; set; }
        /// <summary>secret Key of Amazon login</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"secret Key of Amazon login",
        SerializedName = @"secretKey",
        PossibleTypes = new [] { typeof(string) })]
        string SecretKey { get; set; }
        /// <summary>if Iam Role is used</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"if Iam Role is used",
        SerializedName = @"useIamRole",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseIamRole { get; set; }
        /// <summary>Clientname to be used as Admin Account</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Clientname to be used as Admin Account",
        SerializedName = @"useServiceAccount",
        PossibleTypes = new [] { typeof(string) })]
        string UseServiceAccount { get; set; }

    }
    /// Update a hypervisor group with Amazon as the destination vendor
    internal partial interface IUpdateHypervisorGroupAmazonInternal :
        Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal
    {
        /// <summary>Access Key of Amazon login</summary>
        string AccessKey { get; set; }

        string HypervisorType { get; set; }
        /// <summary>AWS region if Iam role is used</summary>
        string Region { get; set; }
        /// <summary>Role ARN for STS assume role with IAM policy</summary>
        string RoleArn { get; set; }
        /// <summary>secret Key of Amazon login</summary>
        string SecretKey { get; set; }
        /// <summary>if Iam Role is used</summary>
        bool? UseIamRole { get; set; }
        /// <summary>Clientname to be used as Admin Account</summary>
        string UseServiceAccount { get; set; }

    }
}