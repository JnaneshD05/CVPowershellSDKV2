// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class ApplicationGroupResp :
        Commvault.Powershell.Models.IApplicationGroupResp,
        Commvault.Powershell.Models.IApplicationGroupRespInternal
    {

        /// <summary>Backing field for <see cref="ApplicationGroup" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _applicationGroup;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName ApplicationGroup { get => (this._applicationGroup = this._applicationGroup ?? new Commvault.Powershell.Models.IdName()); set => this._applicationGroup = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ApplicationGroupId { get => ((Commvault.Powershell.Models.IIdNameInternal)ApplicationGroup).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)ApplicationGroup).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ApplicationGroupName { get => ((Commvault.Powershell.Models.IIdNameInternal)ApplicationGroup).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)ApplicationGroup).Name = value ?? null; }

        /// <summary>Internal Acessors for ApplicationGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IApplicationGroupRespInternal.ApplicationGroup { get => (this._applicationGroup = this._applicationGroup ?? new Commvault.Powershell.Models.IdName()); set { {_applicationGroup = value;} } }

        /// <summary>Backing field for <see cref="ErrorCode" /> property.</summary>
        private int? _errorCode;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? ErrorCode { get => this._errorCode; set => this._errorCode = value; }

        /// <summary>Backing field for <see cref="ErrorMessage" /> property.</summary>
        private string _errorMessage;

        /// <summary>Response message</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ErrorMessage { get => this._errorMessage; set => this._errorMessage = value; }

        /// <summary>Backing field for <see cref="WarningCode" /> property.</summary>
        private int? _warningCode;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? WarningCode { get => this._warningCode; set => this._warningCode = value; }

        /// <summary>Backing field for <see cref="WarningMessage" /> property.</summary>
        private string _warningMessage;

        /// <summary>Response message</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string WarningMessage { get => this._warningMessage; set => this._warningMessage = value; }

        /// <summary>Creates an new <see cref="ApplicationGroupResp" /> instance.</summary>
        public ApplicationGroupResp()
        {

        }
    }
    public partial interface IApplicationGroupResp :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? ApplicationGroupId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationGroupName { get; set; }

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
    internal partial interface IApplicationGroupRespInternal

    {
        Commvault.Powershell.Models.IIdName ApplicationGroup { get; set; }

        int? ApplicationGroupId { get; set; }

        string ApplicationGroupName { get; set; }

        int? ErrorCode { get; set; }
        /// <summary>Response message</summary>
        string ErrorMessage { get; set; }

        int? WarningCode { get; set; }
        /// <summary>Response message</summary>
        string WarningMessage { get; set; }

    }
}