// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Message object to hold information of entities to which selected plan and plan rule need to be associated
    /// </summary>
    public partial class AssociatePlanRuleEntity :
        Commvault.Powershell.Models.IAssociatePlanRuleEntity,
        Commvault.Powershell.Models.IAssociatePlanRuleEntityInternal
    {

        /// <summary>Internal Acessors for Plan</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IAssociatePlanRuleEntityInternal.Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.IdName()); set { {_plan = value;} } }

        /// <summary>Internal Acessors for Rule</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IAssociatePlanRuleEntityInternal.Rule { get => (this._rule = this._rule ?? new Commvault.Powershell.Models.IdName()); set { {_rule = value;} } }

        /// <summary>Internal Acessors for Subclient</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IAssociatePlanRuleEntityInternal.Subclient { get => (this._subclient = this._subclient ?? new Commvault.Powershell.Models.IdName()); set { {_subclient = value;} } }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _plan;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.IdName()); set => this._plan = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? PlanId { get => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PlanName { get => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Rule" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _rule;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Rule { get => (this._rule = this._rule ?? new Commvault.Powershell.Models.IdName()); set => this._rule = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? RuleId { get => ((Commvault.Powershell.Models.IIdNameInternal)Rule).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Rule).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RuleName { get => ((Commvault.Powershell.Models.IIdNameInternal)Rule).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Rule).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Subclient" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _subclient;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Subclient { get => (this._subclient = this._subclient ?? new Commvault.Powershell.Models.IdName()); set => this._subclient = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SubclientId { get => ((Commvault.Powershell.Models.IIdNameInternal)Subclient).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Subclient).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SubclientName { get => ((Commvault.Powershell.Models.IIdNameInternal)Subclient).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Subclient).Name = value ?? null; }

        /// <summary>Creates an new <see cref="AssociatePlanRuleEntity" /> instance.</summary>
        public AssociatePlanRuleEntity()
        {

        }
    }
    /// Message object to hold information of entities to which selected plan and plan rule need to be associated
    public partial interface IAssociatePlanRuleEntity :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
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
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? RuleId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string RuleName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? SubclientId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SubclientName { get; set; }

    }
    /// Message object to hold information of entities to which selected plan and plan rule need to be associated
    internal partial interface IAssociatePlanRuleEntityInternal

    {
        Commvault.Powershell.Models.IIdName Plan { get; set; }

        int? PlanId { get; set; }

        string PlanName { get; set; }

        Commvault.Powershell.Models.IIdName Rule { get; set; }

        int? RuleId { get; set; }

        string RuleName { get; set; }

        Commvault.Powershell.Models.IIdName Subclient { get; set; }

        int? SubclientId { get; set; }

        string SubclientName { get; set; }

    }
}