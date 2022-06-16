// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>GCPInstanceList</summary>
    public partial class GcpInstanceList :
        Commvault.Powershell.Models.IGcpInstanceList,
        Commvault.Powershell.Models.IGcpInstanceListInternal
    {

        /// <summary>Internal Acessors for Error</summary>
        Commvault.Powershell.Models.IGenericResp Commvault.Powershell.Models.IGcpInstanceListInternal.Error { get => (this._error = this._error ?? new Commvault.Powershell.Models.GenericResp()); set { {_error = value;} } }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Commvault.Powershell.Models.IGenericResp _error;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IGenericResp Error { get => (this._error = this._error ?? new Commvault.Powershell.Models.GenericResp()); set => this._error = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ErrorCode { get => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorCode; set => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorCode = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ErrorMessage { get => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorMessage; set => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorMessage = value ?? null; }

        /// <summary>Backing field for <see cref="Instances" /> property.</summary>
        private Commvault.Powershell.Models.IGcpInstances[] _instances;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IGcpInstances[] Instances { get => this._instances; set => this._instances = value; }

        /// <summary>Creates an new <see cref="GcpInstanceList" /> instance.</summary>
        public GcpInstanceList()
        {

        }
    }
    /// GCPInstanceList
    public partial interface IGcpInstanceList :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
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

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"instances",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IGcpInstances) })]
        Commvault.Powershell.Models.IGcpInstances[] Instances { get; set; }

    }
    /// GCPInstanceList
    internal partial interface IGcpInstanceListInternal

    {
        Commvault.Powershell.Models.IGenericResp Error { get; set; }

        int? ErrorCode { get; set; }

        string ErrorMessage { get; set; }

        Commvault.Powershell.Models.IGcpInstances[] Instances { get; set; }

    }
}