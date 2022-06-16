// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Update a hypervisor group with OpenStack as the destination vendor</summary>
    public partial class UpdateHypervisorGroupOpenstack
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IUpdateHypervisorGroupOpenstack.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IUpdateHypervisorGroupOpenstack.</returns>
        public static Commvault.Powershell.Models.IUpdateHypervisorGroupOpenstack FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new UpdateHypervisorGroupOpenstack(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="UpdateHypervisorGroupOpenstack" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UpdateHypervisorGroupOpenstack" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            __updateHypervisorGroupReq?.ToJson(container, serializationMode);
            AddIf( null != (((object)this._hypervisorType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._hypervisorType.ToString()) : null, "hypervisorType" ,container.Add );
            AddIf( null != (((object)this._keynoteAddress)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._keynoteAddress.ToString()) : null, "keynoteAddress" ,container.Add );
            AddIf( null != (((object)this._userName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._userName.ToString()) : null, "userName" ,container.Add );
            AddIf( null != (((object)this._password)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._password.ToString()) : null, "password" ,container.Add );
            AddIf( null != (((object)this._openstackDomain)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._openstackDomain.ToString()) : null, "openstackDomain" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="UpdateHypervisorGroupOpenstack" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal UpdateHypervisorGroupOpenstack(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __updateHypervisorGroupReq = new Commvault.Powershell.Models.UpdateHypervisorGroupReq(json);
            {_hypervisorType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("hypervisorType"), out var __jsonHypervisorType) ? (string)__jsonHypervisorType : (string)HypervisorType;}
            {_keynoteAddress = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("keynoteAddress"), out var __jsonKeynoteAddress) ? (string)__jsonKeynoteAddress : (string)KeynoteAddress;}
            {_userName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("userName"), out var __jsonUserName) ? (string)__jsonUserName : (string)UserName;}
            {_password = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("password"), out var __jsonPassword) ? (string)__jsonPassword : (string)Password;}
            {_openstackDomain = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("openstackDomain"), out var __jsonOpenstackDomain) ? (string)__jsonOpenstackDomain : (string)OpenstackDomain;}
            AfterFromJson(json);
        }
    }
}