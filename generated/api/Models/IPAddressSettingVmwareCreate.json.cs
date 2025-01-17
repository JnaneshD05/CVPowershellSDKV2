// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// A mapping of IP between the source and the destination VM with an option to configure either a dynamic or a static IP.
    /// </summary>
    public partial class IPAddressSettingVmwareCreate
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IIPAddressSettingVmwareCreate.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IIPAddressSettingVmwareCreate.</returns>
        public static Commvault.Powershell.Models.IIPAddressSettingVmwareCreate FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new IPAddressSettingVmwareCreate(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="IPAddressSettingVmwareCreate" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal IPAddressSettingVmwareCreate(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_sourceIP = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("sourceIP"), out var __jsonSourceIP) ? (string)__jsonSourceIP : (string)SourceIP;}
            {_sourceSubnetMask = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("sourceSubnetMask"), out var __jsonSourceSubnetMask) ? (string)__jsonSourceSubnetMask : (string)SourceSubnetMask;}
            {_sourceDefaultGateway = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("sourceDefaultGateway"), out var __jsonSourceDefaultGateway) ? (string)__jsonSourceDefaultGateway : (string)SourceDefaultGateway;}
            {_useDhcp = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("useDhcp"), out var __jsonUseDhcp) ? (bool?)__jsonUseDhcp : UseDhcp;}
            {_destinationIP = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("destinationIP"), out var __jsonDestinationIP) ? (string)__jsonDestinationIP : (string)DestinationIP;}
            {_destinationSubnetMask = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("destinationSubnetMask"), out var __jsonDestinationSubnetMask) ? (string)__jsonDestinationSubnetMask : (string)DestinationSubnetMask;}
            {_destinationdefaultGateway = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("destinationdefaultGateway"), out var __jsonDestinationdefaultGateway) ? (string)__jsonDestinationdefaultGateway : (string)DestinationdefaultGateway;}
            {_destinationPreferredDns = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("destinationPreferredDNS"), out var __jsonDestinationPreferredDns) ? (string)__jsonDestinationPreferredDns : (string)DestinationPreferredDns;}
            {_destinationAlternateDns = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("destinationAlternateDNS"), out var __jsonDestinationAlternateDns) ? (string)__jsonDestinationAlternateDns : (string)DestinationAlternateDns;}
            {_destinationPreferredWins = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("destinationPreferredWINS"), out var __jsonDestinationPreferredWins) ? (string)__jsonDestinationPreferredWins : (string)DestinationPreferredWins;}
            {_destinationAlternateWins = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("destinationAlternateWINS"), out var __jsonDestinationAlternateWins) ? (string)__jsonDestinationAlternateWins : (string)DestinationAlternateWins;}
            {_hostname = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("hostname"), out var __jsonHostname) ? (string)__jsonHostname : (string)Hostname;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="IPAddressSettingVmwareCreate" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="IPAddressSettingVmwareCreate" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._sourceIP)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._sourceIP.ToString()) : null, "sourceIP" ,container.Add );
            AddIf( null != (((object)this._sourceSubnetMask)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._sourceSubnetMask.ToString()) : null, "sourceSubnetMask" ,container.Add );
            AddIf( null != (((object)this._sourceDefaultGateway)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._sourceDefaultGateway.ToString()) : null, "sourceDefaultGateway" ,container.Add );
            AddIf( null != this._useDhcp ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._useDhcp) : null, "useDhcp" ,container.Add );
            AddIf( null != (((object)this._destinationIP)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._destinationIP.ToString()) : null, "destinationIP" ,container.Add );
            AddIf( null != (((object)this._destinationSubnetMask)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._destinationSubnetMask.ToString()) : null, "destinationSubnetMask" ,container.Add );
            AddIf( null != (((object)this._destinationdefaultGateway)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._destinationdefaultGateway.ToString()) : null, "destinationdefaultGateway" ,container.Add );
            AddIf( null != (((object)this._destinationPreferredDns)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._destinationPreferredDns.ToString()) : null, "destinationPreferredDNS" ,container.Add );
            AddIf( null != (((object)this._destinationAlternateDns)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._destinationAlternateDns.ToString()) : null, "destinationAlternateDNS" ,container.Add );
            AddIf( null != (((object)this._destinationPreferredWins)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._destinationPreferredWins.ToString()) : null, "destinationPreferredWINS" ,container.Add );
            AddIf( null != (((object)this._destinationAlternateWins)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._destinationAlternateWins.ToString()) : null, "destinationAlternateWINS" ,container.Add );
            AddIf( null != (((object)this._hostname)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._hostname.ToString()) : null, "hostname" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}