// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>hypervisorGeneralProperties</summary>
    public partial class HypervisorGeneralProperties :
        Commvault.Powershell.Models.IHypervisorGeneralProperties,
        Commvault.Powershell.Models.IHypervisorGeneralPropertiesInternal
    {

        /// <summary>Internal Acessors for VMBackupInfo</summary>
        Commvault.Powershell.Models.IVMBackupInfo Commvault.Powershell.Models.IHypervisorGeneralPropertiesInternal.VMBackupInfo { get => (this._vMBackupInfo = this._vMBackupInfo ?? new Commvault.Powershell.Models.VMBackupInfo()); set { {_vMBackupInfo = value;} } }

        /// <summary>Backing field for <see cref="VMBackupInfo" /> property.</summary>
        private Commvault.Powershell.Models.IVMBackupInfo _vMBackupInfo;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IVMBackupInfo VMBackupInfo { get => (this._vMBackupInfo = this._vMBackupInfo ?? new Commvault.Powershell.Models.VMBackupInfo()); set => this._vMBackupInfo = value; }

        /// <summary>VM Backed up with error count</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? VMBackupInfoVmbackedUpWithErrorCount { get => ((Commvault.Powershell.Models.IVMBackupInfoInternal)VMBackupInfo).VMBackedUpWithErrorCount; set => ((Commvault.Powershell.Models.IVMBackupInfoInternal)VMBackupInfo).VMBackedUpWithErrorCount = value ?? default(int); }

        /// <summary>vm never Backed up count</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? VMBackupInfoVmneverBackedUpCount { get => ((Commvault.Powershell.Models.IVMBackupInfoInternal)VMBackupInfo).VMNeverBackedUpCount; set => ((Commvault.Powershell.Models.IVMBackupInfoInternal)VMBackupInfo).VMNeverBackedUpCount = value ?? default(int); }

        /// <summary>VM Missed to protect count</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? VMBackupInfoVmnotProtectedCount { get => ((Commvault.Powershell.Models.IVMBackupInfoInternal)VMBackupInfo).VMNotProtectedCount; set => ((Commvault.Powershell.Models.IVMBackupInfoInternal)VMBackupInfo).VMNotProtectedCount = value ?? default(int); }

        /// <summary>VMs pending for Backup</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? VMBackupInfoVmpendingCount { get => ((Commvault.Powershell.Models.IVMBackupInfoInternal)VMBackupInfo).VMPendingCount; set => ((Commvault.Powershell.Models.IVMBackupInfoInternal)VMBackupInfo).VMPendingCount = value ?? default(int); }

        /// <summary>Protected vm Count</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? VMBackupInfoVmprotectedCount { get => ((Commvault.Powershell.Models.IVMBackupInfoInternal)VMBackupInfo).VMProtectedCount; set => ((Commvault.Powershell.Models.IVMBackupInfoInternal)VMBackupInfo).VMProtectedCount = value ?? default(int); }

        /// <summary>Total vm Count</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? VMBackupInfoVmtotalCount { get => ((Commvault.Powershell.Models.IVMBackupInfoInternal)VMBackupInfo).VMTotalCount; set => ((Commvault.Powershell.Models.IVMBackupInfoInternal)VMBackupInfo).VMTotalCount = value ?? default(int); }

        /// <summary>Backing field for <see cref="Vendor" /> property.</summary>
        private string _vendor;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Vendor { get => this._vendor; set => this._vendor = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Hypervisor OS version</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="HypervisorGeneralProperties" /> instance.</summary>
        public HypervisorGeneralProperties()
        {

        }
    }
    /// hypervisorGeneralProperties
    public partial interface IHypervisorGeneralProperties :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>VM Backed up with error count</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"VM Backed up with error count",
        SerializedName = @"vmBackedUpWithErrorCount",
        PossibleTypes = new [] { typeof(int) })]
        int? VMBackupInfoVmbackedUpWithErrorCount { get; set; }
        /// <summary>vm never Backed up count</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"vm never Backed up count",
        SerializedName = @"vmNeverBackedUpCount",
        PossibleTypes = new [] { typeof(int) })]
        int? VMBackupInfoVmneverBackedUpCount { get; set; }
        /// <summary>VM Missed to protect count</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"VM Missed to protect count",
        SerializedName = @"vmNotProtectedCount",
        PossibleTypes = new [] { typeof(int) })]
        int? VMBackupInfoVmnotProtectedCount { get; set; }
        /// <summary>VMs pending for Backup</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"VMs pending for Backup",
        SerializedName = @"vmPendingCount",
        PossibleTypes = new [] { typeof(int) })]
        int? VMBackupInfoVmpendingCount { get; set; }
        /// <summary>Protected vm Count</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Protected vm Count",
        SerializedName = @"vmProtectedCount",
        PossibleTypes = new [] { typeof(int) })]
        int? VMBackupInfoVmprotectedCount { get; set; }
        /// <summary>Total vm Count</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @" Total vm Count",
        SerializedName = @"vmTotalCount",
        PossibleTypes = new [] { typeof(int) })]
        int? VMBackupInfoVmtotalCount { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"vendor",
        PossibleTypes = new [] { typeof(string) })]
        string Vendor { get; set; }
        /// <summary>Hypervisor OS version</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Hypervisor OS version",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// hypervisorGeneralProperties
    internal partial interface IHypervisorGeneralPropertiesInternal

    {
        Commvault.Powershell.Models.IVMBackupInfo VMBackupInfo { get; set; }
        /// <summary>VM Backed up with error count</summary>
        int? VMBackupInfoVmbackedUpWithErrorCount { get; set; }
        /// <summary>vm never Backed up count</summary>
        int? VMBackupInfoVmneverBackedUpCount { get; set; }
        /// <summary>VM Missed to protect count</summary>
        int? VMBackupInfoVmnotProtectedCount { get; set; }
        /// <summary>VMs pending for Backup</summary>
        int? VMBackupInfoVmpendingCount { get; set; }
        /// <summary>Protected vm Count</summary>
        int? VMBackupInfoVmprotectedCount { get; set; }
        /// <summary>Total vm Count</summary>
        int? VMBackupInfoVmtotalCount { get; set; }

        string Vendor { get; set; }
        /// <summary>Hypervisor OS version</summary>
        string Version { get; set; }

    }
}