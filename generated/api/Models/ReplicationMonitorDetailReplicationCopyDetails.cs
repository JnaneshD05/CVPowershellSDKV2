// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Gives copy details information for replication group</summary>
    public partial class ReplicationMonitorDetailReplicationCopyDetails :
        Commvault.Powershell.Models.IReplicationMonitorDetailReplicationCopyDetails,
        Commvault.Powershell.Models.IReplicationMonitorDetailReplicationCopyDetailsInternal
    {

        /// <summary>Backing field for <see cref="CreationTime" /> property.</summary>
        private int? _creationTime;

        /// <summary>Creation time (Unix Time)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? CreationTime { get => this._creationTime; set => this._creationTime = value; }

        /// <summary>Backing field for <see cref="ExpirationTime" /> property.</summary>
        private int? _expirationTime;

        /// <summary>Expiration time</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? ExpirationTime { get => this._expirationTime; set => this._expirationTime = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of replication copy</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Status of replication copy</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="StatusDescription" /> property.</summary>
        private string _statusDescription;

        /// <summary>Status description</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string StatusDescription { get => this._statusDescription; set => this._statusDescription = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of replication copy</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Uuid" /> property.</summary>
        private string _uuid;

        /// <summary>UUID of replication copy</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Uuid { get => this._uuid; set => this._uuid = value; }

        /// <summary>
        /// Creates an new <see cref="ReplicationMonitorDetailReplicationCopyDetails" /> instance.
        /// </summary>
        public ReplicationMonitorDetailReplicationCopyDetails()
        {

        }
    }
    /// Gives copy details information for replication group
    public partial interface IReplicationMonitorDetailReplicationCopyDetails :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Creation time (Unix Time)</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Creation time (Unix Time)",
        SerializedName = @"creationTime",
        PossibleTypes = new [] { typeof(int) })]
        int? CreationTime { get; set; }
        /// <summary>Expiration time</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Expiration time",
        SerializedName = @"expirationTime",
        PossibleTypes = new [] { typeof(int) })]
        int? ExpirationTime { get; set; }
        /// <summary>Name of replication copy</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of replication copy",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Status of replication copy</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status of replication copy",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>Status description</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status description",
        SerializedName = @"statusDescription",
        PossibleTypes = new [] { typeof(string) })]
        string StatusDescription { get; set; }
        /// <summary>Type of replication copy</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of replication copy",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }
        /// <summary>UUID of replication copy</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"UUID of replication copy",
        SerializedName = @"UUID",
        PossibleTypes = new [] { typeof(string) })]
        string Uuid { get; set; }

    }
    /// Gives copy details information for replication group
    internal partial interface IReplicationMonitorDetailReplicationCopyDetailsInternal

    {
        /// <summary>Creation time (Unix Time)</summary>
        int? CreationTime { get; set; }
        /// <summary>Expiration time</summary>
        int? ExpirationTime { get; set; }
        /// <summary>Name of replication copy</summary>
        string Name { get; set; }
        /// <summary>Status of replication copy</summary>
        string Status { get; set; }
        /// <summary>Status description</summary>
        string StatusDescription { get; set; }
        /// <summary>Type of replication copy</summary>
        string Type { get; set; }
        /// <summary>UUID of replication copy</summary>
        string Uuid { get; set; }

    }
}