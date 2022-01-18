// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class PlanBackupDestinationResp :
        Commvault.Powershell.Models.IPlanBackupDestinationResp,
        Commvault.Powershell.Models.IPlanBackupDestinationRespInternal
    {

        /// <summary>Internal Acessors for Error</summary>
        Commvault.Powershell.Models.IGenericResp Commvault.Powershell.Models.IPlanBackupDestinationRespInternal.Error { get => (this._error = this._error ?? new Commvault.Powershell.Models.GenericResp()); set { {_error = value;} } }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Commvault.Powershell.Models.IGenericResp _error;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IGenericResp Error { get => (this._error = this._error ?? new Commvault.Powershell.Models.GenericResp()); set => this._error = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ErrorCode { get => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorCode; set => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorCode = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ErrorMessage { get => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorMessage; set => ((Commvault.Powershell.Models.IGenericRespInternal)Error).ErrorMessage = value ?? null; }

        /// <summary>Backing field for <see cref="FailedDestinations" /> property.</summary>
        private string[] _failedDestinations;

        /// <summary>List of destinations for which the operation failed</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string[] FailedDestinations { get => this._failedDestinations; set => this._failedDestinations = value; }

        /// <summary>Backing field for <see cref="PlanBackupDestination" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _planBackupDestination;

        /// <summary>List of destinations effected or created</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] PlanBackupDestination { get => this._planBackupDestination; set => this._planBackupDestination = value; }

        /// <summary>Creates an new <see cref="PlanBackupDestinationResp" /> instance.</summary>
        public PlanBackupDestinationResp()
        {

        }
    }
    public partial interface IPlanBackupDestinationResp :
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
        /// <summary>List of destinations for which the operation failed</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of destinations for which the operation failed",
        SerializedName = @"failedDestinations",
        PossibleTypes = new [] { typeof(string) })]
        string[] FailedDestinations { get; set; }
        /// <summary>List of destinations effected or created</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of destinations effected or created",
        SerializedName = @"planBackupDestination",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] PlanBackupDestination { get; set; }

    }
    internal partial interface IPlanBackupDestinationRespInternal

    {
        Commvault.Powershell.Models.IGenericResp Error { get; set; }

        int? ErrorCode { get; set; }

        string ErrorMessage { get; set; }
        /// <summary>List of destinations for which the operation failed</summary>
        string[] FailedDestinations { get; set; }
        /// <summary>List of destinations effected or created</summary>
        Commvault.Powershell.Models.IIdName[] PlanBackupDestination { get; set; }

    }
}