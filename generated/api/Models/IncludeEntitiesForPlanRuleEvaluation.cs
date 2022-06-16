// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Entities that need to be included for plan rule evaluation</summary>
    public partial class IncludeEntitiesForPlanRuleEvaluation :
        Commvault.Powershell.Models.IIncludeEntitiesForPlanRuleEvaluation,
        Commvault.Powershell.Models.IIncludeEntitiesForPlanRuleEvaluationInternal
    {

        /// <summary>Backing field for <see cref="Subclients" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _subclients;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] Subclients { get => this._subclients; set => this._subclients = value; }

        /// <summary>Creates an new <see cref="IncludeEntitiesForPlanRuleEvaluation" /> instance.</summary>
        public IncludeEntitiesForPlanRuleEvaluation()
        {

        }
    }
    /// Entities that need to be included for plan rule evaluation
    public partial interface IIncludeEntitiesForPlanRuleEvaluation :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"subclients",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] Subclients { get; set; }

    }
    /// Entities that need to be included for plan rule evaluation
    internal partial interface IIncludeEntitiesForPlanRuleEvaluationInternal

    {
        Commvault.Powershell.Models.IIdName[] Subclients { get; set; }

    }
}