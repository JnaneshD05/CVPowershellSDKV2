// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class CreateServerPlanBackupContentResponse :
        Commvault.Powershell.Models.ICreateServerPlanBackupContentResponse,
        Commvault.Powershell.Models.ICreateServerPlanBackupContentResponseInternal
    {

        /// <summary>Backing field for <see cref="BackupContent" /> property.</summary>
        private Commvault.Powershell.Models.IPlanContent _backupContent;

        /// <summary>This feature applies only to file system agents</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IPlanContent BackupContent { get => (this._backupContent = this._backupContent ?? new Commvault.Powershell.Models.PlanContent()); set => this._backupContent = value; }

        /// <summary>Do you want to back up the system state? Applicable only for Windows</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? BackupContentBackupSystemState { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).BackupSystemState; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).BackupSystemState = value ?? default(bool); }

        /// <summary>
        /// Do you want to back up system state only with full backup? Applicable only if the value of backupSystemState is true
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? BackupContentBackupSystemStateOnlyWithFullBackup { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).BackupSystemStateOnlyWithFullBackup; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).BackupSystemStateOnlyWithFullBackup = value ?? default(bool); }

        /// <summary>Paths to exclude for Mac</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] BackupContentMacExcludedPaths { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).MacExcludedPaths; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).MacExcludedPaths = value ?? null /* arrayOf */; }

        /// <summary>Paths to include for Mac</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] BackupContentMacIncludedPaths { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).MacIncludedPaths; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).MacIncludedPaths = value ?? null /* arrayOf */; }

        /// <summary>Paths to exclude for UNIX</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] BackupContentUnixExcludedPaths { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).UnixExcludedPaths; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).UnixExcludedPaths = value ?? null /* arrayOf */; }

        /// <summary>Paths to include for UNIX</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] BackupContentUnixIncludedPaths { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).UnixIncludedPaths; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).UnixIncludedPaths = value ?? null /* arrayOf */; }

        /// <summary>
        /// Do you want to back up system state with VSS? Applicable only if the value of backupSystemState is true
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? BackupContentUseVssForSystemState { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).UseVssForSystemState; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).UseVssForSystemState = value ?? default(bool); }

        /// <summary>Paths to exclude for Windows</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] BackupContentWindowsExcludedPaths { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).WindowsExcludedPaths; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).WindowsExcludedPaths = value ?? null /* arrayOf */; }

        /// <summary>Paths to include for Windows</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] BackupContentWindowsIncludedPaths { get => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).WindowsIncludedPaths; set => ((Commvault.Powershell.Models.IPlanContentInternal)BackupContent).WindowsIncludedPaths = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for BackupContent</summary>
        Commvault.Powershell.Models.IPlanContent Commvault.Powershell.Models.ICreateServerPlanBackupContentResponseInternal.BackupContent { get => (this._backupContent = this._backupContent ?? new Commvault.Powershell.Models.PlanContent()); set { {_backupContent = value;} } }

        /// <summary>Internal Acessors for Error</summary>
        Commvault.Powershell.Models.IGenericResp Commvault.Powershell.Models.ICreateServerPlanBackupContentResponseInternal.Error { get => (this._error = this._error ?? new Commvault.Powershell.Models.GenericResp()); set { {_error = value;} } }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Commvault.Powershell.Models.IGenericResp _error;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IGenericResp Error { get => (this._error = this._error ?? new Commvault.Powershell.Models.GenericResp()); set => this._error = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ErrorCode { get => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorCode; set => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorCode = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ErrorMessage { get => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorMessage; set => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorMessage = value ?? null; }

        /// <summary>Creates an new <see cref="CreateServerPlanBackupContentResponse" /> instance.</summary>
        public CreateServerPlanBackupContentResponse()
        {

        }
    }
    public partial interface ICreateServerPlanBackupContentResponse :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Do you want to back up the system state? Applicable only for Windows</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Do you want to back up the system state? Applicable only for Windows",
        SerializedName = @"backupSystemState",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BackupContentBackupSystemState { get; set; }
        /// <summary>
        /// Do you want to back up system state only with full backup? Applicable only if the value of backupSystemState is true
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Do you want to back up system state only with full backup? Applicable only if the value of backupSystemState is true",
        SerializedName = @"backupSystemStateOnlyWithFullBackup",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BackupContentBackupSystemStateOnlyWithFullBackup { get; set; }
        /// <summary>Paths to exclude for Mac</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Paths to exclude for Mac",
        SerializedName = @"macExcludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] BackupContentMacExcludedPaths { get; set; }
        /// <summary>Paths to include for Mac</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Paths to include for Mac",
        SerializedName = @"macIncludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] BackupContentMacIncludedPaths { get; set; }
        /// <summary>Paths to exclude for UNIX</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Paths to exclude for UNIX",
        SerializedName = @"unixExcludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] BackupContentUnixExcludedPaths { get; set; }
        /// <summary>Paths to include for UNIX</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Paths to include for UNIX",
        SerializedName = @"unixIncludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] BackupContentUnixIncludedPaths { get; set; }
        /// <summary>
        /// Do you want to back up system state with VSS? Applicable only if the value of backupSystemState is true
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Do you want to back up system state with VSS? Applicable only if the value of backupSystemState is true",
        SerializedName = @"useVSSForSystemState",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BackupContentUseVssForSystemState { get; set; }
        /// <summary>Paths to exclude for Windows</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Paths to exclude for Windows",
        SerializedName = @"windowsExcludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] BackupContentWindowsExcludedPaths { get; set; }
        /// <summary>Paths to include for Windows</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Paths to include for Windows",
        SerializedName = @"windowsIncludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        string[] BackupContentWindowsIncludedPaths { get; set; }

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

    }
    internal partial interface ICreateServerPlanBackupContentResponseInternal

    {
        /// <summary>This feature applies only to file system agents</summary>
        Commvault.Powershell.Models.IPlanContent BackupContent { get; set; }
        /// <summary>Do you want to back up the system state? Applicable only for Windows</summary>
        bool? BackupContentBackupSystemState { get; set; }
        /// <summary>
        /// Do you want to back up system state only with full backup? Applicable only if the value of backupSystemState is true
        /// </summary>
        bool? BackupContentBackupSystemStateOnlyWithFullBackup { get; set; }
        /// <summary>Paths to exclude for Mac</summary>
        string[] BackupContentMacExcludedPaths { get; set; }
        /// <summary>Paths to include for Mac</summary>
        string[] BackupContentMacIncludedPaths { get; set; }
        /// <summary>Paths to exclude for UNIX</summary>
        string[] BackupContentUnixExcludedPaths { get; set; }
        /// <summary>Paths to include for UNIX</summary>
        string[] BackupContentUnixIncludedPaths { get; set; }
        /// <summary>
        /// Do you want to back up system state with VSS? Applicable only if the value of backupSystemState is true
        /// </summary>
        bool? BackupContentUseVssForSystemState { get; set; }
        /// <summary>Paths to exclude for Windows</summary>
        string[] BackupContentWindowsExcludedPaths { get; set; }
        /// <summary>Paths to include for Windows</summary>
        string[] BackupContentWindowsIncludedPaths { get; set; }

        Commvault.Powershell.Models.IGenericResp Error { get; set; }

        int? ErrorCode { get; set; }

        string ErrorMessage { get; set; }

    }
}