// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Sync status of the commcell</summary>
    public partial class SyncStatus1 :
        Commvault.Powershell.Models.ISyncStatus1,
        Commvault.Powershell.Models.ISyncStatus1Internal
    {

        /// <summary>Backing field for <see cref="ErrorMessage" /> property.</summary>
        private Commvault.Powershell.Models.INameMessage[] _errorMessage;

        /// <summary>errorMessage if the commcell failed to sync</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.INameMessage[] ErrorMessage { get => this._errorMessage; set => this._errorMessage = value; }

        /// <summary>Backing field for <see cref="LastSyncedWithIdp" /> property.</summary>
        private int? _lastSyncedWithIdp;

        /// <summary>returns the last synced time with IDP(unix time format)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? LastSyncedWithIdp { get => this._lastSyncedWithIdp; set => this._lastSyncedWithIdp = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>status of the commcell</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="SyncStatus1" /> instance.</summary>
        public SyncStatus1()
        {

        }
    }
    /// Sync status of the commcell
    public partial interface ISyncStatus1 :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>errorMessage if the commcell failed to sync</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"errorMessage if the commcell failed to sync",
        SerializedName = @"errorMessage",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.INameMessage) })]
        Commvault.Powershell.Models.INameMessage[] ErrorMessage { get; set; }
        /// <summary>returns the last synced time with IDP(unix time format)</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"returns the last synced time with IDP(unix time format)",
        SerializedName = @"lastSyncedWithIDP",
        PossibleTypes = new [] { typeof(int) })]
        int? LastSyncedWithIdp { get; set; }
        /// <summary>status of the commcell</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"status of the commcell",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// Sync status of the commcell
    internal partial interface ISyncStatus1Internal

    {
        /// <summary>errorMessage if the commcell failed to sync</summary>
        Commvault.Powershell.Models.INameMessage[] ErrorMessage { get; set; }
        /// <summary>returns the last synced time with IDP(unix time format)</summary>
        int? LastSyncedWithIdp { get; set; }
        /// <summary>status of the commcell</summary>
        string Status { get; set; }

    }
}