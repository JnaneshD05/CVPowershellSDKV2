// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class CreateVMGroupResp :
        Commvault.Powershell.Models.ICreateVMGroupResp,
        Commvault.Powershell.Models.ICreateVMGroupRespInternal
    {

        /// <summary>Backing field for <see cref="ErrorCode" /> property.</summary>
        private int? _errorCode;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? ErrorCode { get => this._errorCode; set => this._errorCode = value; }

        /// <summary>Backing field for <see cref="ErrorMessage" /> property.</summary>
        private string _errorMessage;

        /// <summary>Response message</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ErrorMessage { get => this._errorMessage; set => this._errorMessage = value; }

        /// <summary>Backing field for <see cref="SubclientId" /> property.</summary>
        private int? _subclientId;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? SubclientId { get => this._subclientId; set => this._subclientId = value; }

        /// <summary>Backing field for <see cref="WarningCode" /> property.</summary>
        private int? _warningCode;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? WarningCode { get => this._warningCode; set => this._warningCode = value; }

        /// <summary>Backing field for <see cref="WarningMessage" /> property.</summary>
        private string _warningMessage;

        /// <summary>Response message</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string WarningMessage { get => this._warningMessage; set => this._warningMessage = value; }

        /// <summary>Creates an new <see cref="CreateVMGroupResp" /> instance.</summary>
        public CreateVMGroupResp()
        {

        }
    }
    public partial interface ICreateVMGroupResp :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"errorCode",
        PossibleTypes = new [] { typeof(int) })]
        int? ErrorCode { get; set; }
        /// <summary>Response message</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Response message",
        SerializedName = @"errorMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorMessage { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"subclientId",
        PossibleTypes = new [] { typeof(int) })]
        int? SubclientId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"warningCode",
        PossibleTypes = new [] { typeof(int) })]
        int? WarningCode { get; set; }
        /// <summary>Response message</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Response message",
        SerializedName = @"warningMessage",
        PossibleTypes = new [] { typeof(string) })]
        string WarningMessage { get; set; }

    }
    internal partial interface ICreateVMGroupRespInternal

    {
        int? ErrorCode { get; set; }
        /// <summary>Response message</summary>
        string ErrorMessage { get; set; }

        int? SubclientId { get; set; }

        int? WarningCode { get; set; }
        /// <summary>Response message</summary>
        string WarningMessage { get; set; }

    }
}