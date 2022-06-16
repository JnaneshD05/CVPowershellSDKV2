// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class EdgeDriveSettingsPlan :
        Commvault.Powershell.Models.IEdgeDriveSettingsPlan,
        Commvault.Powershell.Models.IEdgeDriveSettingsPlanInternal
    {

        /// <summary>Backing field for <see cref="AuditDriveOperations" /> property.</summary>
        private bool? _auditDriveOperations;

        /// <summary>
        /// Enable auditing which logs the activities based on user interaction like creating, editing, moving, renaming, downloading
        /// or deleting files.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? AuditDriveOperations { get => this._auditDriveOperations; set => this._auditDriveOperations = value; }

        /// <summary>Backing field for <see cref="Client" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _client;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Client { get => (this._client = this._client ?? new Commvault.Powershell.Models.IdName()); set => this._client = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ClientId { get => ((Commvault.Powershell.Models.IIdNameInternal)Client).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Client).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ClientName { get => ((Commvault.Powershell.Models.IIdNameInternal)Client).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Client).Name = value ?? null; }

        /// <summary>Internal Acessors for Client</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IEdgeDriveSettingsPlanInternal.Client { get => (this._client = this._client ?? new Commvault.Powershell.Models.IdName()); set { {_client = value;} } }

        /// <summary>Internal Acessors for IndexServer</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IEdgeDriveSettingsPlanInternal.IndexServer { get => (this._indexServer = this._indexServer ?? new Commvault.Powershell.Models.IdName()); set { {_indexServer = value;} } }

        /// <summary>Backing field for <see cref="CreateNewIndexServer" /> property.</summary>
        private bool _createNewIndexServer;

        /// <summary>
        /// If set to false, uses existing edge index server and requires IndexServer IdName to be passed. If set to true, requires
        /// client IdName and indexCachePath to create a new Index Server.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool CreateNewIndexServer { get => this._createNewIndexServer; set => this._createNewIndexServer = value; }

        /// <summary>Backing field for <see cref="EdgeDriveQuota" /> property.</summary>
        private int? _edgeDriveQuota;

        /// <summary>
        /// Maximum number of gigabytes that you can store in the Edge Drive. Giving value as -1 means no quota.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? EdgeDriveQuota { get => this._edgeDriveQuota; set => this._edgeDriveQuota = value; }

        /// <summary>Backing field for <see cref="IndexCachePath" /> property.</summary>
        private string _indexCachePath;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string IndexCachePath { get => this._indexCachePath; set => this._indexCachePath = value; }

        /// <summary>Backing field for <see cref="IndexServer" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _indexServer;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName IndexServer { get => (this._indexServer = this._indexServer ?? new Commvault.Powershell.Models.IdName()); set => this._indexServer = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? IndexServerId { get => ((Commvault.Powershell.Models.IIdNameInternal)IndexServer).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)IndexServer).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string IndexServerName { get => ((Commvault.Powershell.Models.IIdNameInternal)IndexServer).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)IndexServer).Name = value ?? null; }

        /// <summary>Backing field for <see cref="NotificationsForShares" /> property.</summary>
        private bool? _notificationsForShares;

        /// <summary>
        /// Enables alert notification feature which allows the share user or share owner to subscribe for share notifications when
        /// any activities are performed on the Edge Drive or the Collaborative share. The user can receive the notifications on the
        /// Web Console or as an email notification.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? NotificationsForShares { get => this._notificationsForShares; set => this._notificationsForShares = value; }

        /// <summary>Creates an new <see cref="EdgeDriveSettingsPlan" /> instance.</summary>
        public EdgeDriveSettingsPlan()
        {

        }
    }
    public partial interface IEdgeDriveSettingsPlan :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Enable auditing which logs the activities based on user interaction like creating, editing, moving, renaming, downloading
        /// or deleting files.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable auditing which logs the activities based on user interaction like creating, editing, moving, renaming, downloading or deleting files.",
        SerializedName = @"auditDriveOperations",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AuditDriveOperations { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? ClientId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ClientName { get; set; }
        /// <summary>
        /// If set to false, uses existing edge index server and requires IndexServer IdName to be passed. If set to true, requires
        /// client IdName and indexCachePath to create a new Index Server.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"If set to false, uses existing edge index server and requires IndexServer IdName to be passed. If set to true, requires client IdName and indexCachePath to create a new Index Server.",
        SerializedName = @"createNewIndexServer",
        PossibleTypes = new [] { typeof(bool) })]
        bool CreateNewIndexServer { get; set; }
        /// <summary>
        /// Maximum number of gigabytes that you can store in the Edge Drive. Giving value as -1 means no quota.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of gigabytes that you can store in the Edge Drive. Giving value as -1 means no quota.",
        SerializedName = @"edgeDriveQuota",
        PossibleTypes = new [] { typeof(int) })]
        int? EdgeDriveQuota { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"indexCachePath",
        PossibleTypes = new [] { typeof(string) })]
        string IndexCachePath { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? IndexServerId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string IndexServerName { get; set; }
        /// <summary>
        /// Enables alert notification feature which allows the share user or share owner to subscribe for share notifications when
        /// any activities are performed on the Edge Drive or the Collaborative share. The user can receive the notifications on the
        /// Web Console or as an email notification.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enables alert notification feature which allows the share user or share owner to subscribe for share notifications when any activities are performed on the Edge Drive or the Collaborative share. The user can receive the notifications on the Web Console or as an email notification.",
        SerializedName = @"notificationsForShares",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NotificationsForShares { get; set; }

    }
    internal partial interface IEdgeDriveSettingsPlanInternal

    {
        /// <summary>
        /// Enable auditing which logs the activities based on user interaction like creating, editing, moving, renaming, downloading
        /// or deleting files.
        /// </summary>
        bool? AuditDriveOperations { get; set; }

        Commvault.Powershell.Models.IIdName Client { get; set; }

        int? ClientId { get; set; }

        string ClientName { get; set; }
        /// <summary>
        /// If set to false, uses existing edge index server and requires IndexServer IdName to be passed. If set to true, requires
        /// client IdName and indexCachePath to create a new Index Server.
        /// </summary>
        bool CreateNewIndexServer { get; set; }
        /// <summary>
        /// Maximum number of gigabytes that you can store in the Edge Drive. Giving value as -1 means no quota.
        /// </summary>
        int? EdgeDriveQuota { get; set; }

        string IndexCachePath { get; set; }

        Commvault.Powershell.Models.IIdName IndexServer { get; set; }

        int? IndexServerId { get; set; }

        string IndexServerName { get; set; }
        /// <summary>
        /// Enables alert notification feature which allows the share user or share owner to subscribe for share notifications when
        /// any activities are performed on the Edge Drive or the Collaborative share. The user can receive the notifications on the
        /// Web Console or as an email notification.
        /// </summary>
        bool? NotificationsForShares { get; set; }

    }
}