// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class PathsZz45HxV4SnmpGetResponses200ContentApplicationJsonSchema :
        Commvault.Powershell.Models.IPathsZz45HxV4SnmpGetResponses200ContentApplicationJsonSchema,
        Commvault.Powershell.Models.IPathsZz45HxV4SnmpGetResponses200ContentApplicationJsonSchemaInternal
    {

        /// <summary>Backing field for <see cref="SnmpHosts" /> property.</summary>
        private Commvault.Powershell.Models.ISnmpConfigurationSummary[] _snmpHosts;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.ISnmpConfigurationSummary[] SnmpHosts { get => this._snmpHosts; set => this._snmpHosts = value; }

        /// <summary>
        /// Creates an new <see cref="PathsZz45HxV4SnmpGetResponses200ContentApplicationJsonSchema" /> instance.
        /// </summary>
        public PathsZz45HxV4SnmpGetResponses200ContentApplicationJsonSchema()
        {

        }
    }
    public partial interface IPathsZz45HxV4SnmpGetResponses200ContentApplicationJsonSchema :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"SNMPHosts",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ISnmpConfigurationSummary) })]
        Commvault.Powershell.Models.ISnmpConfigurationSummary[] SnmpHosts { get; set; }

    }
    internal partial interface IPathsZz45HxV4SnmpGetResponses200ContentApplicationJsonSchemaInternal

    {
        Commvault.Powershell.Models.ISnmpConfigurationSummary[] SnmpHosts { get; set; }

    }
}