// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>VMSLA</summary>
    public partial class VMSla :
        Commvault.Powershell.Models.IVMSla,
        Commvault.Powershell.Models.IVMSlaInternal
    {

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private string _reason;

        /// <summary>The reason for the current SLA status of the VM client</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Reason { get => this._reason; set => this._reason = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Provides the SLA status.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="VMSla" /> instance.</summary>
        public VMSla()
        {

        }
    }
    /// VMSLA
    public partial interface IVMSla :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>The reason for the current SLA status of the VM client</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reason for the current SLA status of the VM client",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        string Reason { get; set; }
        /// <summary>Provides the SLA status.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provides the SLA status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// VMSLA
    internal partial interface IVMSlaInternal

    {
        /// <summary>The reason for the current SLA status of the VM client</summary>
        string Reason { get; set; }
        /// <summary>Provides the SLA status.</summary>
        string Status { get; set; }

    }
}