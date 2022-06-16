// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Plan entity rule update rank object. Fields in this object need to be populated to suggest what rank need to be set for
    /// the said rule.
    /// </summary>
    public partial class UpdatePlanEntityRuleRanks :
        Commvault.Powershell.Models.IUpdatePlanEntityRuleRanks,
        Commvault.Powershell.Models.IUpdatePlanEntityRuleRanksInternal
    {

        /// <summary>Backing field for <see cref="Rules" /> property.</summary>
        private Commvault.Powershell.Models.IPlanEntityRuleRank[] _rules;

        /// <summary>Lits of plan entity rule object suggesting their ranks.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IPlanEntityRuleRank[] Rules { get => this._rules; set => this._rules = value; }

        /// <summary>Creates an new <see cref="UpdatePlanEntityRuleRanks" /> instance.</summary>
        public UpdatePlanEntityRuleRanks()
        {

        }
    }
    /// Plan entity rule update rank object. Fields in this object need to be populated to suggest what rank need to be set for
    /// the said rule.
    public partial interface IUpdatePlanEntityRuleRanks :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Lits of plan entity rule object suggesting their ranks.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Lits of plan entity rule object suggesting their ranks.",
        SerializedName = @"rules",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IPlanEntityRuleRank) })]
        Commvault.Powershell.Models.IPlanEntityRuleRank[] Rules { get; set; }

    }
    /// Plan entity rule update rank object. Fields in this object need to be populated to suggest what rank need to be set for
    /// the said rule.
    internal partial interface IUpdatePlanEntityRuleRanksInternal

    {
        /// <summary>Lits of plan entity rule object suggesting their ranks.</summary>
        Commvault.Powershell.Models.IPlanEntityRuleRank[] Rules { get; set; }

    }
}