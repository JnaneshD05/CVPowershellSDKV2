// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>List of storage configured for a replication group</summary>
    public partial class ReplicationGroupStorageList :
        Commvault.Powershell.Models.IReplicationGroupStorageList,
        Commvault.Powershell.Models.IReplicationGroupStorageListInternal
    {

        /// <summary>Backing field for <see cref="Copies" /> property.</summary>
        private Commvault.Powershell.Models.IStorageCopy[] _copies;

        /// <summary>List of all storages which are configured for that replication group</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IStorageCopy[] Copies { get => this._copies; set => this._copies = value; }

        /// <summary>Backing field for <see cref="CopyForReplication" /> property.</summary>
        private string _copyForReplication;

        /// <summary>Main storage which is used for replication</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CopyForReplication { get => this._copyForReplication; set => this._copyForReplication = value; }

        /// <summary>Creates an new <see cref="ReplicationGroupStorageList" /> instance.</summary>
        public ReplicationGroupStorageList()
        {

        }
    }
    /// List of storage configured for a replication group
    public partial interface IReplicationGroupStorageList :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>List of all storages which are configured for that replication group</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of all storages which are configured for that replication group",
        SerializedName = @"copies",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IStorageCopy) })]
        Commvault.Powershell.Models.IStorageCopy[] Copies { get; set; }
        /// <summary>Main storage which is used for replication</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Main storage which is used for replication",
        SerializedName = @"copyForReplication",
        PossibleTypes = new [] { typeof(string) })]
        string CopyForReplication { get; set; }

    }
    /// List of storage configured for a replication group
    internal partial interface IReplicationGroupStorageListInternal

    {
        /// <summary>List of all storages which are configured for that replication group</summary>
        Commvault.Powershell.Models.IStorageCopy[] Copies { get; set; }
        /// <summary>Main storage which is used for replication</summary>
        string CopyForReplication { get; set; }

    }
}