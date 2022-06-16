// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>This object will hold detail for plan rule entity and its rank.</summary>
    public partial class PlanEntityRuleRank :
        Commvault.Powershell.Models.IPlanEntityRuleRank,
        Commvault.Powershell.Models.IPlanEntityRuleRankInternal
    {

        /// <summary>Internal Acessors for Rule</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IPlanEntityRuleRankInternal.Rule { get => (this._rule = this._rule ?? new Commvault.Powershell.Models.IdName()); set { {_rule = value;} } }

        /// <summary>Backing field for <see cref="Rank" /> property.</summary>
        private int? _rank;

        /// <summary>This will suggest rank/priority of the plan rule.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Rank { get => this._rank; set => this._rank = value; }

        /// <summary>Backing field for <see cref="Rule" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _rule;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Rule { get => (this._rule = this._rule ?? new Commvault.Powershell.Models.IdName()); set => this._rule = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? RuleId { get => ((Commvault.Powershell.Models.IIdNameInternal)Rule).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Rule).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RuleName { get => ((Commvault.Powershell.Models.IIdNameInternal)Rule).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Rule).Name = value ?? null; }

        /// <summary>Creates an new <see cref="PlanEntityRuleRank" /> instance.</summary>
        public PlanEntityRuleRank()
        {

        }
    }
    /// This object will hold detail for plan rule entity and its rank.
    public partial interface IPlanEntityRuleRank :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>This will suggest rank/priority of the plan rule.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This will suggest rank/priority of the plan rule.",
        SerializedName = @"rank",
        PossibleTypes = new [] { typeof(int) })]
        int? Rank { get; set; }

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

    }
    /// This object will hold detail for plan rule entity and its rank.
    internal partial interface IPlanEntityRuleRankInternal

    {
        /// <summary>This will suggest rank/priority of the plan rule.</summary>
        int? Rank { get; set; }

        Commvault.Powershell.Models.IIdName Rule { get; set; }

        int? RuleId { get; set; }

        string RuleName { get; set; }

    }
}