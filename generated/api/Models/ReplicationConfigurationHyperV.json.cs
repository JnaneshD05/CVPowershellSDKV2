// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Replication configuration for HyperV</summary>
    public partial class ReplicationConfigurationHyperV
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Commvault.Powershell.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Commvault.Powershell.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Commvault.Powershell.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Commvault.Powershell.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Commvault.Powershell.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IReplicationConfigurationHyperV.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IReplicationConfigurationHyperV.</returns>
        public static Commvault.Powershell.Models.IReplicationConfigurationHyperV FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new ReplicationConfigurationHyperV(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="ReplicationConfigurationHyperV" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ReplicationConfigurationHyperV(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_overrideReplicationOptions = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("overrideReplicationOptions"), out var __jsonOverrideReplicationOptions) ? Commvault.Powershell.Models.OverrideReplicationOptionsHyperV.FromJson(__jsonOverrideReplicationOptions) : OverrideReplicationOptions;}
            {_sourceVM = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("sourceVM"), out var __jsonSourceVM) ? (string)__jsonSourceVM : (string)SourceVM;}
            {_destinationVM = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("destinationVM"), out var __jsonDestinationVM) ? (string)__jsonDestinationVM : (string)DestinationVM;}
            {_hypervHost = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("hypervHost"), out var __jsonHypervHost) ? (string)__jsonHypervHost : (string)HypervHost;}
            {_destinationVolume = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("destinationVolume"), out var __jsonDestinationVolume) ? (string)__jsonDestinationVolume : (string)DestinationVolume;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ReplicationConfigurationHyperV" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ReplicationConfigurationHyperV" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </returns>
        public Commvault.Powershell.Runtime.Json.JsonNode ToJson(Commvault.Powershell.Runtime.Json.JsonObject container, Commvault.Powershell.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Commvault.Powershell.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._overrideReplicationOptions ? (Commvault.Powershell.Runtime.Json.JsonNode) this._overrideReplicationOptions.ToJson(null,serializationMode) : null, "overrideReplicationOptions" ,container.Add );
            AddIf( null != (((object)this._sourceVM)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._sourceVM.ToString()) : null, "sourceVM" ,container.Add );
            AddIf( null != (((object)this._destinationVM)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._destinationVM.ToString()) : null, "destinationVM" ,container.Add );
            AddIf( null != (((object)this._hypervHost)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._hypervHost.ToString()) : null, "hypervHost" ,container.Add );
            AddIf( null != (((object)this._destinationVolume)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._destinationVolume.ToString()) : null, "destinationVolume" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}