// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>RMRequestSummary</summary>
    public partial class RmRequestSummary :
        Commvault.Powershell.Models.IRmRequestSummary,
        Commvault.Powershell.Models.IRmRequestSummaryInternal
    {

        /// <summary>Backing field for <see cref="Application" /> property.</summary>
        private string _application;

        /// <summary>Enum to signify the source application of the request</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Application { get => this._application; set => this._application = value; }

        /// <summary>Backing field for <see cref="Approvers" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _approvers;

        /// <summary>List of the request approvers</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] Approvers { get => this._approvers; set => this._approvers = value; }

        /// <summary>Internal Acessors for Owner</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IRmRequestSummaryInternal.Owner { get => (this._owner = this._owner ?? new Commvault.Powershell.Models.IdName()); set { {_owner = value;} } }

        /// <summary>Backing field for <see cref="CreatedOn" /> property.</summary>
        private long? _createdOn;

        /// <summary>Request creation time in unix epoch format</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? CreatedOn { get => this._createdOn; set => this._createdOn = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        /// <summary>Request id</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Request name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Owner" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _owner;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Owner { get => (this._owner = this._owner ?? new Commvault.Powershell.Models.IdName()); set => this._owner = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? OwnerId { get => ((Commvault.Powershell.Models.IIdNameInternal)Owner).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Owner).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string OwnerName { get => ((Commvault.Powershell.Models.IIdNameInternal)Owner).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Owner).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Requestor" /> property.</summary>
        private string _requestor;

        /// <summary>Email of the requestor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Requestor { get => this._requestor; set => this._requestor = value; }

        /// <summary>Backing field for <see cref="Reviewers" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _reviewers;

        /// <summary>List of request reviewers</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] Reviewers { get => this._reviewers; set => this._reviewers = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Signifies the progress of the request</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>RMRequestType</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="RmRequestSummary" /> instance.</summary>
        public RmRequestSummary()
        {

        }
    }
    /// RMRequestSummary
    public partial interface IRmRequestSummary :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Enum to signify the source application of the request</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enum to signify the source application of the request",
        SerializedName = @"application",
        PossibleTypes = new [] { typeof(string) })]
        string Application { get; set; }
        /// <summary>List of the request approvers</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the request approvers",
        SerializedName = @"approvers",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] Approvers { get; set; }
        /// <summary>Request creation time in unix epoch format</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Request creation time in unix epoch format",
        SerializedName = @"createdOn",
        PossibleTypes = new [] { typeof(long) })]
        long? CreatedOn { get; set; }
        /// <summary>Request id</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Request id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }
        /// <summary>Request name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Request name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? OwnerId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string OwnerName { get; set; }
        /// <summary>Email of the requestor</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email of the requestor",
        SerializedName = @"requestor",
        PossibleTypes = new [] { typeof(string) })]
        string Requestor { get; set; }
        /// <summary>List of request reviewers</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of request reviewers",
        SerializedName = @"reviewers",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] Reviewers { get; set; }
        /// <summary>Signifies the progress of the request</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Signifies the progress of the request",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>RMRequestType</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"RMRequestType",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// RMRequestSummary
    internal partial interface IRmRequestSummaryInternal

    {
        /// <summary>Enum to signify the source application of the request</summary>
        string Application { get; set; }
        /// <summary>List of the request approvers</summary>
        Commvault.Powershell.Models.IIdName[] Approvers { get; set; }
        /// <summary>Request creation time in unix epoch format</summary>
        long? CreatedOn { get; set; }
        /// <summary>Request id</summary>
        int? Id { get; set; }
        /// <summary>Request name</summary>
        string Name { get; set; }

        Commvault.Powershell.Models.IIdName Owner { get; set; }

        int? OwnerId { get; set; }

        string OwnerName { get; set; }
        /// <summary>Email of the requestor</summary>
        string Requestor { get; set; }
        /// <summary>List of request reviewers</summary>
        Commvault.Powershell.Models.IIdName[] Reviewers { get; set; }
        /// <summary>Signifies the progress of the request</summary>
        string Status { get; set; }
        /// <summary>RMRequestType</summary>
        string Type { get; set; }

    }
}