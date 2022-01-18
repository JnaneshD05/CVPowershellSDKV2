// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class UserGroupSummary :
        Commvault.Powershell.Models.IUserGroupSummary,
        Commvault.Powershell.Models.IUserGroupSummaryInternal
    {

        /// <summary>Backing field for <see cref="Commcell" /> property.</summary>
        private Commvault.Powershell.Models.ICommcellInfo _commcell;

        /// <summary>CommcellInfo</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ICommcellInfo Commcell { get => (this._commcell = this._commcell ?? new Commvault.Powershell.Models.CommcellInfo()); set => this._commcell = value; }

        /// <summary>Name of the commcell the entity belongs to.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CommcellName { get => ((Commvault.Powershell.Models.ICommcellInfoInternal)Commcell).Name; set => ((Commvault.Powershell.Models.ICommcellInfoInternal)Commcell).Name = value ?? null; }

        /// <summary>Internal Acessors for Commcell</summary>
        Commvault.Powershell.Models.ICommcellInfo Commvault.Powershell.Models.IUserGroupSummaryInternal.Commcell { get => (this._commcell = this._commcell ?? new Commvault.Powershell.Models.CommcellInfo()); set { {_commcell = value;} } }

        /// <summary>Internal Acessors for Company</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IUserGroupSummaryInternal.Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set { {_company = value;} } }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _company;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set => this._company = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? CompanyId { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>returns if the user group is enabled or disabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="Guid" /> property.</summary>
        private string _guid;

        /// <summary>globally unique identifier for user group</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Guid { get => this._guid; set => this._guid = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        /// <summary>User group id</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>user group name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ServiceType" /> property.</summary>
        private string _serviceType;

        /// <summary>
        /// The values that are returned by serviceType are- 0(unknown),1(commserver users),2(Active directory users),3(domino directory
        /// service users),4(hosted exchange users),5(company users),12(dummy domain users)
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ServiceType { get => this._serviceType; set => this._serviceType = value; }

        /// <summary>Creates an new <see cref="UserGroupSummary" /> instance.</summary>
        public UserGroupSummary()
        {

        }
    }
    public partial interface IUserGroupSummary :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Name of the commcell the entity belongs to.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the commcell the entity belongs to.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CommcellName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? CompanyId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>returns if the user group is enabled or disabled</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"returns if the user group is enabled or disabled",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>globally unique identifier for user group</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"globally unique identifier for user group",
        SerializedName = @"GUID",
        PossibleTypes = new [] { typeof(string) })]
        string Guid { get; set; }
        /// <summary>User group id</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User group id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }
        /// <summary>user group name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"user group name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The values that are returned by serviceType are- 0(unknown),1(commserver users),2(Active directory users),3(domino directory
        /// service users),4(hosted exchange users),5(company users),12(dummy domain users)
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The values that are returned by serviceType are- 0(unknown),1(commserver users),2(Active directory users),3(domino directory service users),4(hosted exchange users),5(company users),12(dummy domain users)",
        SerializedName = @"serviceType",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceType { get; set; }

    }
    internal partial interface IUserGroupSummaryInternal

    {
        /// <summary>CommcellInfo</summary>
        Commvault.Powershell.Models.ICommcellInfo Commcell { get; set; }
        /// <summary>Name of the commcell the entity belongs to.</summary>
        string CommcellName { get; set; }

        Commvault.Powershell.Models.IIdName Company { get; set; }

        int? CompanyId { get; set; }

        string CompanyName { get; set; }

        string Description { get; set; }
        /// <summary>returns if the user group is enabled or disabled</summary>
        bool? Enabled { get; set; }
        /// <summary>globally unique identifier for user group</summary>
        string Guid { get; set; }
        /// <summary>User group id</summary>
        int? Id { get; set; }
        /// <summary>user group name</summary>
        string Name { get; set; }
        /// <summary>
        /// The values that are returned by serviceType are- 0(unknown),1(commserver users),2(Active directory users),3(domino directory
        /// service users),4(hosted exchange users),5(company users),12(dummy domain users)
        /// </summary>
        string ServiceType { get; set; }

    }
}