// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>VMPasskey</summary>
    public partial class VMPasskey :
        Commvault.Powershell.Models.IVMPasskey,
        Commvault.Powershell.Models.IVMPasskeyInternal
    {

        /// <summary>Backing field for <see cref="AuthType" /> property.</summary>
        private string _authType;

        /// <summary>The authentication type set for browse and restore</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string AuthType { get => this._authType; set => this._authType = value; }

        /// <summary>Backing field for <see cref="EnableAuthorizeForRestore" /> property.</summary>
        private bool? _enableAuthorizeForRestore;

        /// <summary>To tell if user is authorized for restore</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? EnableAuthorizeForRestore { get => this._enableAuthorizeForRestore; set => this._enableAuthorizeForRestore = value; }

        /// <summary>Backing field for <see cref="ExpirationTime" /> property.</summary>
        private int? _expirationTime;

        /// <summary>
        /// The duration(in unix time) for which a user can continue browsing and restoring backup data without being prompted to
        /// enter the passkey, again.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? ExpirationTime { get => this._expirationTime; set => this._expirationTime = value; }

        /// <summary>Backing field for <see cref="PassKeyRequiredForRestore" /> property.</summary>
        private bool? _passKeyRequiredForRestore;

        /// <summary>To tell if passkey is required for browse and restore</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? PassKeyRequiredForRestore { get => this._passKeyRequiredForRestore; set => this._passKeyRequiredForRestore = value; }

        /// <summary>Creates an new <see cref="VMPasskey" /> instance.</summary>
        public VMPasskey()
        {

        }
    }
    /// VMPasskey
    public partial interface IVMPasskey :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>The authentication type set for browse and restore</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The authentication type set for browse and restore",
        SerializedName = @"authType",
        PossibleTypes = new [] { typeof(string) })]
        string AuthType { get; set; }
        /// <summary>To tell if user is authorized for restore</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"To tell if user is authorized for restore",
        SerializedName = @"enableAuthorizeForRestore",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAuthorizeForRestore { get; set; }
        /// <summary>
        /// The duration(in unix time) for which a user can continue browsing and restoring backup data without being prompted to
        /// enter the passkey, again.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The duration(in unix time) for which a user can continue browsing and restoring backup data without being prompted to enter the passkey, again.",
        SerializedName = @"expirationTime",
        PossibleTypes = new [] { typeof(int) })]
        int? ExpirationTime { get; set; }
        /// <summary>To tell if passkey is required for browse and restore</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"To tell if passkey is required for browse and restore",
        SerializedName = @"passKeyRequiredForRestore",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PassKeyRequiredForRestore { get; set; }

    }
    /// VMPasskey
    internal partial interface IVMPasskeyInternal

    {
        /// <summary>The authentication type set for browse and restore</summary>
        string AuthType { get; set; }
        /// <summary>To tell if user is authorized for restore</summary>
        bool? EnableAuthorizeForRestore { get; set; }
        /// <summary>
        /// The duration(in unix time) for which a user can continue browsing and restoring backup data without being prompted to
        /// enter the passkey, again.
        /// </summary>
        int? ExpirationTime { get; set; }
        /// <summary>To tell if passkey is required for browse and restore</summary>
        bool? PassKeyRequiredForRestore { get; set; }

    }
}