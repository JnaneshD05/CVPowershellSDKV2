// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Returns a list of service commcells</summary>
    public partial class ServiceCommcells :
        Commvault.Powershell.Models.IServiceCommcells,
        Commvault.Powershell.Models.IServiceCommcellsInternal
    {

        /// <summary>Internal Acessors for SyncStatus</summary>
        Commvault.Powershell.Models.ISyncStatus1 Commvault.Powershell.Models.IServiceCommcellsInternal.SyncStatus { get => (this._syncStatus = this._syncStatus ?? new Commvault.Powershell.Models.SyncStatus1()); set { {_syncStatus = value;} } }

        /// <summary>Backing field for <see cref="Hostname" /> property.</summary>
        private string _hostname;

        /// <summary>hostname of the Commcell</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Hostname { get => this._hostname; set => this._hostname = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        /// <summary>Id of the commcell</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the commcell entity</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Role" /> property.</summary>
        private string _role;

        /// <summary>Role of the commcell</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Role { get => this._role; set => this._role = value; }

        /// <summary>Backing field for <see cref="SyncStatus" /> property.</summary>
        private Commvault.Powershell.Models.ISyncStatus1 _syncStatus;

        /// <summary>Sync status of the commcell</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ISyncStatus1 SyncStatus { get => (this._syncStatus = this._syncStatus ?? new Commvault.Powershell.Models.SyncStatus1()); set => this._syncStatus = value; }

        /// <summary>errorMessage if the commcell failed to sync</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.INameMessage[] SyncStatusErrorMessage { get => ((Commvault.Powershell.Models.ISyncStatus1Internal)SyncStatus).ErrorMessage; set => ((Commvault.Powershell.Models.ISyncStatus1Internal)SyncStatus).ErrorMessage = value ?? null /* arrayOf */; }

        /// <summary>returns the last synced time with IDP(unix time format)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SyncStatusLastSyncedWithIdp { get => ((Commvault.Powershell.Models.ISyncStatus1Internal)SyncStatus).LastSyncedWithIdp; set => ((Commvault.Powershell.Models.ISyncStatus1Internal)SyncStatus).LastSyncedWithIdp = value ?? default(int); }

        /// <summary>status of the commcell</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SyncStatusStatus { get => ((Commvault.Powershell.Models.ISyncStatus1Internal)SyncStatus).Status; set => ((Commvault.Powershell.Models.ISyncStatus1Internal)SyncStatus).Status = value ?? null; }

        /// <summary>Backing field for <see cref="UseUniversalCommandCenter" /> property.</summary>
        private bool? _useUniversalCommandCenter;

        /// <summary>if enabled the Command Center of the commcell belong to the primary CommCell</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? UseUniversalCommandCenter { get => this._useUniversalCommandCenter; set => this._useUniversalCommandCenter = value; }

        /// <summary>Creates an new <see cref="ServiceCommcells" /> instance.</summary>
        public ServiceCommcells()
        {

        }
    }
    /// Returns a list of service commcells
    public partial interface IServiceCommcells :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>hostname of the Commcell</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"hostname of the Commcell",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string Hostname { get; set; }
        /// <summary>Id of the commcell</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the commcell",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }
        /// <summary>Name of the commcell entity</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the commcell entity",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Role of the commcell</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Role of the commcell",
        SerializedName = @"role",
        PossibleTypes = new [] { typeof(string) })]
        string Role { get; set; }
        /// <summary>errorMessage if the commcell failed to sync</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"errorMessage if the commcell failed to sync",
        SerializedName = @"errorMessage",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.INameMessage) })]
        Commvault.Powershell.Models.INameMessage[] SyncStatusErrorMessage { get; set; }
        /// <summary>returns the last synced time with IDP(unix time format)</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"returns the last synced time with IDP(unix time format)",
        SerializedName = @"lastSyncedWithIDP",
        PossibleTypes = new [] { typeof(int) })]
        int? SyncStatusLastSyncedWithIdp { get; set; }
        /// <summary>status of the commcell</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"status of the commcell",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string SyncStatusStatus { get; set; }
        /// <summary>if enabled the Command Center of the commcell belong to the primary CommCell</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"if enabled the Command Center of the commcell belong to the primary CommCell",
        SerializedName = @"useUniversalCommandCenter",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseUniversalCommandCenter { get; set; }

    }
    /// Returns a list of service commcells
    internal partial interface IServiceCommcellsInternal

    {
        /// <summary>hostname of the Commcell</summary>
        string Hostname { get; set; }
        /// <summary>Id of the commcell</summary>
        int? Id { get; set; }
        /// <summary>Name of the commcell entity</summary>
        string Name { get; set; }
        /// <summary>Role of the commcell</summary>
        string Role { get; set; }
        /// <summary>Sync status of the commcell</summary>
        Commvault.Powershell.Models.ISyncStatus1 SyncStatus { get; set; }
        /// <summary>errorMessage if the commcell failed to sync</summary>
        Commvault.Powershell.Models.INameMessage[] SyncStatusErrorMessage { get; set; }
        /// <summary>returns the last synced time with IDP(unix time format)</summary>
        int? SyncStatusLastSyncedWithIdp { get; set; }
        /// <summary>status of the commcell</summary>
        string SyncStatusStatus { get; set; }
        /// <summary>if enabled the Command Center of the commcell belong to the primary CommCell</summary>
        bool? UseUniversalCommandCenter { get; set; }

    }
}