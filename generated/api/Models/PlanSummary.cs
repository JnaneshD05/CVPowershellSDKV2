// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class PlanSummary :
        Commvault.Powershell.Models.IPlanSummary,
        Commvault.Powershell.Models.IPlanSummaryInternal
    {

        /// <summary>Backing field for <see cref="AssociatedEntities" /> property.</summary>
        private int? _associatedEntities;

        /// <summary>Count of associated entities for the plan</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? AssociatedEntities { get => this._associatedEntities; set => this._associatedEntities = value; }

        /// <summary>Internal Acessors for Company</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IPlanSummaryInternal.Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set { {_company = value;} } }

        /// <summary>Internal Acessors for Plan</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IPlanSummaryInternal.Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.IdName()); set { {_plan = value;} } }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _company;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set => this._company = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? CompanyId { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name = value ?? null; }

        /// <summary>Backing field for <see cref="MissingEntities" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _missingEntities;

        /// <summary>For plans in incomplete state contains list of entities missing from the plan</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] MissingEntities { get => this._missingEntities; set => this._missingEntities = value; }

        /// <summary>Backing field for <see cref="NumberOfCopies" /> property.</summary>
        private int? _numberOfCopies;

        /// <summary>Number of copies for the plan</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? NumberOfCopies { get => this._numberOfCopies; set => this._numberOfCopies = value; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _plan;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.IdName()); set => this._plan = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? PlanId { get => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PlanName { get => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Name = value ?? null; }

        /// <summary>Backing field for <see cref="PlanType" /> property.</summary>
        private string _planType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string PlanType { get => this._planType; set => this._planType = value; }

        /// <summary>Backing field for <see cref="Rpo" /> property.</summary>
        private int? _rpo;

        /// <summary>RPO in minutes for the plan</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Rpo { get => this._rpo; set => this._rpo = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="PlanSummary" /> instance.</summary>
        public PlanSummary()
        {

        }
    }
    public partial interface IPlanSummary :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Count of associated entities for the plan</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Count of associated entities for the plan",
        SerializedName = @"associatedEntities",
        PossibleTypes = new [] { typeof(int) })]
        int? AssociatedEntities { get; set; }

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
        /// <summary>For plans in incomplete state contains list of entities missing from the plan</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"For plans in incomplete state contains list of entities missing from the plan",
        SerializedName = @"missingEntities",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] MissingEntities { get; set; }
        /// <summary>Number of copies for the plan</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of copies for the plan",
        SerializedName = @"numberOfCopies",
        PossibleTypes = new [] { typeof(int) })]
        int? NumberOfCopies { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? PlanId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string PlanName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"planType",
        PossibleTypes = new [] { typeof(string) })]
        string PlanType { get; set; }
        /// <summary>RPO in minutes for the plan</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"RPO in minutes for the plan",
        SerializedName = @"RPO",
        PossibleTypes = new [] { typeof(int) })]
        int? Rpo { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    internal partial interface IPlanSummaryInternal

    {
        /// <summary>Count of associated entities for the plan</summary>
        int? AssociatedEntities { get; set; }

        Commvault.Powershell.Models.IIdName Company { get; set; }

        int? CompanyId { get; set; }

        string CompanyName { get; set; }
        /// <summary>For plans in incomplete state contains list of entities missing from the plan</summary>
        Commvault.Powershell.Models.IIdName[] MissingEntities { get; set; }
        /// <summary>Number of copies for the plan</summary>
        int? NumberOfCopies { get; set; }

        Commvault.Powershell.Models.IIdName Plan { get; set; }

        int? PlanId { get; set; }

        string PlanName { get; set; }

        string PlanType { get; set; }
        /// <summary>RPO in minutes for the plan</summary>
        int? Rpo { get; set; }

        string Status { get; set; }

    }
}