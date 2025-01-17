// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>VMAppsDiscovered</summary>
    public partial class VMAppsDiscovered :
        Commvault.Powershell.Models.IVMAppsDiscovered,
        Commvault.Powershell.Models.IVMAppsDiscoveredInternal
    {

        /// <summary>Backing field for <see cref="FailureReason" /> property.</summary>
        private string _failureReason;

        /// <summary>reason for failure of validation of app</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string FailureReason { get => this._failureReason; set => this._failureReason = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>name of the VM apps discovered for validation</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ScriptStatus" /> property.</summary>
        private bool? _scriptStatus;

        /// <summary>true if validation status is true</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? ScriptStatus { get => this._scriptStatus; set => this._scriptStatus = value; }

        /// <summary>Creates an new <see cref="VMAppsDiscovered" /> instance.</summary>
        public VMAppsDiscovered()
        {

        }
    }
    /// VMAppsDiscovered
    public partial interface IVMAppsDiscovered :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>reason for failure of validation of app</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"reason for failure of validation of app",
        SerializedName = @"failureReason",
        PossibleTypes = new [] { typeof(string) })]
        string FailureReason { get; set; }
        /// <summary>name of the VM apps discovered for validation</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"name of the VM apps discovered for validation",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>true if validation status is true</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"true if validation status is true",
        SerializedName = @"scriptStatus",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ScriptStatus { get; set; }

    }
    /// VMAppsDiscovered
    internal partial interface IVMAppsDiscoveredInternal

    {
        /// <summary>reason for failure of validation of app</summary>
        string FailureReason { get; set; }
        /// <summary>name of the VM apps discovered for validation</summary>
        string Name { get; set; }
        /// <summary>true if validation status is true</summary>
        bool? ScriptStatus { get; set; }

    }
}