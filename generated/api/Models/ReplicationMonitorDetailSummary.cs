// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Gives summary of replication group.</summary>
    public partial class ReplicationMonitorDetailSummary :
        Commvault.Powershell.Models.IReplicationMonitorDetailSummary,
        Commvault.Powershell.Models.IReplicationMonitorDetailSummaryInternal
    {

        /// <summary>Internal Acessors for Destination</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IReplicationMonitorDetailSummaryInternal.Destination { get => (this._destination = this._destination ?? new Commvault.Powershell.Models.IdName()); set { {_destination = value;} } }

        /// <summary>Internal Acessors for Source</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IReplicationMonitorDetailSummaryInternal.Source { get => (this._source = this._source ?? new Commvault.Powershell.Models.IdName()); set { {_source = value;} } }

        /// <summary>Backing field for <see cref="Destination" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _destination;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Destination { get => (this._destination = this._destination ?? new Commvault.Powershell.Models.IdName()); set => this._destination = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? DestinationId { get => ((Commvault.Powershell.Models.IIdNameInternal)Destination).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Destination).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string DestinationName { get => ((Commvault.Powershell.Models.IIdNameInternal)Destination).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Destination).Name = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryType" /> property.</summary>
        private string _recoveryType;

        /// <summary>Gives information about the recovery type of replication group</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string RecoveryType { get => this._recoveryType; set => this._recoveryType = value; }

        /// <summary>Backing field for <see cref="ReplicationLag" /> property.</summary>
        private int? _replicationLag;

        /// <summary>Lag time in seconds</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? ReplicationLag { get => this._replicationLag; set => this._replicationLag = value; }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _source;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Source { get => (this._source = this._source ?? new Commvault.Powershell.Models.IdName()); set => this._source = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SourceId { get => ((Commvault.Powershell.Models.IIdNameInternal)Source).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Source).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SourceName { get => ((Commvault.Powershell.Models.IIdNameInternal)Source).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Source).Name = value ?? null; }

        /// <summary>Backing field for <see cref="SynchronizationStatus" /> property.</summary>
        private string _synchronizationStatus;

        /// <summary>Gives information about the synchronization status</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SynchronizationStatus { get => this._synchronizationStatus; set => this._synchronizationStatus = value; }

        /// <summary>Creates an new <see cref="ReplicationMonitorDetailSummary" /> instance.</summary>
        public ReplicationMonitorDetailSummary()
        {

        }
    }
    /// Gives summary of replication group.
    public partial interface IReplicationMonitorDetailSummary :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? DestinationId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationName { get; set; }
        /// <summary>Gives information about the recovery type of replication group</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gives information about the recovery type of replication group",
        SerializedName = @"recoveryType",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryType { get; set; }
        /// <summary>Lag time in seconds</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Lag time in seconds",
        SerializedName = @"replicationLag",
        PossibleTypes = new [] { typeof(int) })]
        int? ReplicationLag { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? SourceId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SourceName { get; set; }
        /// <summary>Gives information about the synchronization status</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gives information about the synchronization status",
        SerializedName = @"synchronizationStatus",
        PossibleTypes = new [] { typeof(string) })]
        string SynchronizationStatus { get; set; }

    }
    /// Gives summary of replication group.
    internal partial interface IReplicationMonitorDetailSummaryInternal

    {
        Commvault.Powershell.Models.IIdName Destination { get; set; }

        int? DestinationId { get; set; }

        string DestinationName { get; set; }
        /// <summary>Gives information about the recovery type of replication group</summary>
        string RecoveryType { get; set; }
        /// <summary>Lag time in seconds</summary>
        int? ReplicationLag { get; set; }

        Commvault.Powershell.Models.IIdName Source { get; set; }

        int? SourceId { get; set; }

        string SourceName { get; set; }
        /// <summary>Gives information about the synchronization status</summary>
        string SynchronizationStatus { get; set; }

    }
}