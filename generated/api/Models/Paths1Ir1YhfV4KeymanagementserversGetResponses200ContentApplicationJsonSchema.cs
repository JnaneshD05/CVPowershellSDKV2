// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class Paths1Ir1YhfV4KeymanagementserversGetResponses200ContentApplicationJsonSchema :
        Commvault.Powershell.Models.IPaths1Ir1YhfV4KeymanagementserversGetResponses200ContentApplicationJsonSchema,
        Commvault.Powershell.Models.IPaths1Ir1YhfV4KeymanagementserversGetResponses200ContentApplicationJsonSchemaInternal
    {

        /// <summary>Backing field for <see cref="KeyManagementServers" /> property.</summary>
        private Commvault.Powershell.Models.IKeyManagementServer[] _keyManagementServers;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IKeyManagementServer[] KeyManagementServers { get => this._keyManagementServers; set => this._keyManagementServers = value; }

        /// <summary>
        /// Creates an new <see cref="Paths1Ir1YhfV4KeymanagementserversGetResponses200ContentApplicationJsonSchema" /> instance.
        /// </summary>
        public Paths1Ir1YhfV4KeymanagementserversGetResponses200ContentApplicationJsonSchema()
        {

        }
    }
    public partial interface IPaths1Ir1YhfV4KeymanagementserversGetResponses200ContentApplicationJsonSchema :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"KeyManagementServers",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IKeyManagementServer) })]
        Commvault.Powershell.Models.IKeyManagementServer[] KeyManagementServers { get; set; }

    }
    internal partial interface IPaths1Ir1YhfV4KeymanagementserversGetResponses200ContentApplicationJsonSchemaInternal

    {
        Commvault.Powershell.Models.IKeyManagementServer[] KeyManagementServers { get; set; }

    }
}