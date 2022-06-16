// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// solutionType is the solution used to create resource pool. It cannot be changed once the resource pool has been created.
    /// indexServer is a server that stores, amalgamates, and processes indexes that contain metadata corresponding to the data
    /// protection jobs. The list of index servers is populated with clients that are installed with the index store package.
    /// storage refers to the Storage Pool to associate to resource pool. accessNodes is the list of access nodes associated to
    /// the resource pool.
    /// </summary>
    public partial class ResourcePoolSummary :
        Commvault.Powershell.Models.IResourcePoolSummary,
        Commvault.Powershell.Models.IResourcePoolSummaryInternal
    {

        /// <summary>Backing field for <see cref="AccessNodes" /> property.</summary>
        private Commvault.Powershell.Models.IAccessNodes[] _accessNodes;

        /// <summary>List of access nodes associated to the resource pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IAccessNodes[] AccessNodes { get => this._accessNodes; set => this._accessNodes = value; }

        /// <summary>Backing field for <see cref="AssociatedPlans" /> property.</summary>
        private int? _associatedPlans;

        /// <summary>Refers to the number of plans associated to the resource pool.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? AssociatedPlans { get => this._associatedPlans; set => this._associatedPlans = value; }

        /// <summary>Internal Acessors for IndexServer</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IResourcePoolSummaryInternal.IndexServer { get => (this._indexServer = this._indexServer ?? new Commvault.Powershell.Models.IdName()); set { {_indexServer = value;} } }

        /// <summary>Internal Acessors for Storage</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IResourcePoolSummaryInternal.Storage { get => (this._storage = this._storage ?? new Commvault.Powershell.Models.IdName()); set { {_storage = value;} } }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        /// <summary>Resource Pool id</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="IndexServer" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _indexServer;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName IndexServer { get => (this._indexServer = this._indexServer ?? new Commvault.Powershell.Models.IdName()); set => this._indexServer = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? IndexServerId { get => ((Commvault.Powershell.Models.IIdNameInternal)IndexServer).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)IndexServer).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string IndexServerName { get => ((Commvault.Powershell.Models.IIdNameInternal)IndexServer).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)IndexServer).Name = value ?? null; }

        /// <summary>Backing field for <see cref="IsIndexingEnabledOnAnyPlan" /> property.</summary>
        private bool? _isIndexingEnabledOnAnyPlan;

        /// <summary>Denotes if the resource pool is associated to any plan with indexing enabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? IsIndexingEnabledOnAnyPlan { get => this._isIndexingEnabledOnAnyPlan; set => this._isIndexingEnabledOnAnyPlan = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Resource Pool name.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="SolutionType" /> property.</summary>
        private string _solutionType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SolutionType { get => this._solutionType; set => this._solutionType = value; }

        /// <summary>Backing field for <see cref="Storage" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _storage;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Storage { get => (this._storage = this._storage ?? new Commvault.Powershell.Models.IdName()); set => this._storage = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? StorageId { get => ((Commvault.Powershell.Models.IIdNameInternal)Storage).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Storage).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string StorageName { get => ((Commvault.Powershell.Models.IIdNameInternal)Storage).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Storage).Name = value ?? null; }

        /// <summary>Creates an new <see cref="ResourcePoolSummary" /> instance.</summary>
        public ResourcePoolSummary()
        {

        }
    }
    /// solutionType is the solution used to create resource pool. It cannot be changed once the resource pool has been created.
    /// indexServer is a server that stores, amalgamates, and processes indexes that contain metadata corresponding to the data
    /// protection jobs. The list of index servers is populated with clients that are installed with the index store package.
    /// storage refers to the Storage Pool to associate to resource pool. accessNodes is the list of access nodes associated to
    /// the resource pool.
    public partial interface IResourcePoolSummary :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>List of access nodes associated to the resource pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of access nodes associated to the resource pool",
        SerializedName = @"accessNodes",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAccessNodes) })]
        Commvault.Powershell.Models.IAccessNodes[] AccessNodes { get; set; }
        /// <summary>Refers to the number of plans associated to the resource pool.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Refers to the number of plans associated to the resource pool.",
        SerializedName = @"associatedPlans",
        PossibleTypes = new [] { typeof(int) })]
        int? AssociatedPlans { get; set; }
        /// <summary>Resource Pool id</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Pool id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }

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
        /// <summary>Denotes if the resource pool is associated to any plan with indexing enabled</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Denotes if the resource pool is associated to any plan with indexing enabled",
        SerializedName = @"isIndexingEnabledOnAnyPlan",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsIndexingEnabledOnAnyPlan { get; set; }
        /// <summary>Resource Pool name.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Pool name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"solutionType",
        PossibleTypes = new [] { typeof(string) })]
        string SolutionType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? StorageId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string StorageName { get; set; }

    }
    /// solutionType is the solution used to create resource pool. It cannot be changed once the resource pool has been created.
    /// indexServer is a server that stores, amalgamates, and processes indexes that contain metadata corresponding to the data
    /// protection jobs. The list of index servers is populated with clients that are installed with the index store package.
    /// storage refers to the Storage Pool to associate to resource pool. accessNodes is the list of access nodes associated to
    /// the resource pool.
    internal partial interface IResourcePoolSummaryInternal

    {
        /// <summary>List of access nodes associated to the resource pool</summary>
        Commvault.Powershell.Models.IAccessNodes[] AccessNodes { get; set; }
        /// <summary>Refers to the number of plans associated to the resource pool.</summary>
        int? AssociatedPlans { get; set; }
        /// <summary>Resource Pool id</summary>
        int? Id { get; set; }

        Commvault.Powershell.Models.IIdName IndexServer { get; set; }

        int? IndexServerId { get; set; }

        string IndexServerName { get; set; }
        /// <summary>Denotes if the resource pool is associated to any plan with indexing enabled</summary>
        bool? IsIndexingEnabledOnAnyPlan { get; set; }
        /// <summary>Resource Pool name.</summary>
        string Name { get; set; }

        string SolutionType { get; set; }

        Commvault.Powershell.Models.IIdName Storage { get; set; }

        int? StorageId { get; set; }

        string StorageName { get; set; }

    }
}