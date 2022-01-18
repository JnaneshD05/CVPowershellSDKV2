// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>AlertDefinitionsList</summary>
    public partial class AlertDefinitionsList :
        Commvault.Powershell.Models.IAlertDefinitionsList,
        Commvault.Powershell.Models.IAlertDefinitionsListInternal
    {

        /// <summary>Backing field for <see cref="AlertDefinitions" /> property.</summary>
        private Commvault.Powershell.Models.IAlertDefinition[] _alertDefinitions;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IAlertDefinition[] AlertDefinitions { get => this._alertDefinitions; set => this._alertDefinitions = value; }

        /// <summary>Creates an new <see cref="AlertDefinitionsList" /> instance.</summary>
        public AlertDefinitionsList()
        {

        }
    }
    /// AlertDefinitionsList
    public partial interface IAlertDefinitionsList :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"alertDefinitions",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAlertDefinition) })]
        Commvault.Powershell.Models.IAlertDefinition[] AlertDefinitions { get; set; }

    }
    /// AlertDefinitionsList
    internal partial interface IAlertDefinitionsListInternal

    {
        Commvault.Powershell.Models.IAlertDefinition[] AlertDefinitions { get; set; }

    }
}