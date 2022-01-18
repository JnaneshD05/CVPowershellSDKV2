// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>UpdateAuthRestore</summary>
    public partial class UpdateAuthRestore :
        Commvault.Powershell.Models.IUpdateAuthRestore,
        Commvault.Powershell.Models.IUpdateAuthRestoreInternal
    {

        /// <summary>Backing field for <see cref="AuthOpType" /> property.</summary>
        private bool? _authOpType;

        /// <summary>The type of authorize for restore operation</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? AuthOpType { get => this._authOpType; set => this._authOpType = value; }

        /// <summary>Backing field for <see cref="ExpirationTime" /> property.</summary>
        private int? _expirationTime;

        /// <summary>
        /// The duration(in unix time) for which a user can continue browsing and restoring backup data without being prompted to
        /// enter the passkey, again.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? ExpirationTime { get => this._expirationTime; set => this._expirationTime = value; }

        /// <summary>Backing field for <see cref="PassKey" /> property.</summary>
        private string _passKey;

        /// <summary>The existing passkey for restricting backup restores.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string PassKey { get => this._passKey; set => this._passKey = value; }

        /// <summary>Creates an new <see cref="UpdateAuthRestore" /> instance.</summary>
        public UpdateAuthRestore()
        {

        }
    }
    /// UpdateAuthRestore
    public partial interface IUpdateAuthRestore :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>The type of authorize for restore operation</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of authorize for restore operation",
        SerializedName = @"authOpType",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AuthOpType { get; set; }
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
        /// <summary>The existing passkey for restricting backup restores.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The existing passkey for restricting backup restores.",
        SerializedName = @"passKey",
        PossibleTypes = new [] { typeof(string) })]
        string PassKey { get; set; }

    }
    /// UpdateAuthRestore
    internal partial interface IUpdateAuthRestoreInternal

    {
        /// <summary>The type of authorize for restore operation</summary>
        bool? AuthOpType { get; set; }
        /// <summary>
        /// The duration(in unix time) for which a user can continue browsing and restoring backup data without being prompted to
        /// enter the passkey, again.
        /// </summary>
        int? ExpirationTime { get; set; }
        /// <summary>The existing passkey for restricting backup restores.</summary>
        string PassKey { get; set; }

    }
}