// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>List of entities that are will be associated to provided plan and said rule</summary>
    public partial class AssociatePlanRuleEntityList :
        Commvault.Powershell.Models.IAssociatePlanRuleEntityList,
        Commvault.Powershell.Models.IAssociatePlanRuleEntityListInternal
    {

        /// <summary>Backing field for <see cref="Entities" /> property.</summary>
        private Commvault.Powershell.Models.IAssociatePlanRuleEntity[] _entities;

        /// <summary>Details of entity that will be associated to plan and rule.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IAssociatePlanRuleEntity[] Entities { get => this._entities; set => this._entities = value; }

        /// <summary>Creates an new <see cref="AssociatePlanRuleEntityList" /> instance.</summary>
        public AssociatePlanRuleEntityList()
        {

        }
    }
    /// List of entities that are will be associated to provided plan and said rule
    public partial interface IAssociatePlanRuleEntityList :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Details of entity that will be associated to plan and rule.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Details of entity that will be associated to plan and rule.",
        SerializedName = @"entities",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAssociatePlanRuleEntity) })]
        Commvault.Powershell.Models.IAssociatePlanRuleEntity[] Entities { get; set; }

    }
    /// List of entities that are will be associated to provided plan and said rule
    internal partial interface IAssociatePlanRuleEntityListInternal

    {
        /// <summary>Details of entity that will be associated to plan and rule.</summary>
        Commvault.Powershell.Models.IAssociatePlanRuleEntity[] Entities { get; set; }

    }
}