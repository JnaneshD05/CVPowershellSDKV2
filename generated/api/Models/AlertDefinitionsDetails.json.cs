// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>AlertDefinitionsDetails</summary>
    public partial class AlertDefinitionsDetails
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
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="AlertDefinitionsDetails" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AlertDefinitionsDetails(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_alertSummary = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("alertSummary"), out var __jsonAlertSummary) ? Commvault.Powershell.Models.AlertDetailsSummary.FromJson(__jsonAlertSummary) : AlertSummary;}
            {_alertTarget = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("alertTarget"), out var __jsonAlertTarget) ? Commvault.Powershell.Models.AlertDefinitionsTarget.FromJson(__jsonAlertTarget) : AlertTarget;}
            {_template = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("template"), out var __jsonTemplate) ? Commvault.Powershell.Models.AlertDefinitionsTemplate.FromJson(__jsonTemplate) : Template;}
            {_id = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("id"), out var __jsonId) ? (int?)__jsonId : Id;}
            {_name = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_sendIndividualNotifications = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("sendIndividualNotifications"), out var __jsonSendIndividualNotifications) ? (bool?)__jsonSendIndividualNotifications : SendIndividualNotifications;}
            {_associations = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("associations"), out var __jsonAssociations) ? If( __jsonAssociations as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Commvault.Powershell.Models.IAlertAssociationIdNameType1[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.IAlertAssociationIdNameType1) (Commvault.Powershell.Models.AlertAssociationIdNameType1.FromJson(__u) )) ))() : null : Associations;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IAlertDefinitionsDetails.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IAlertDefinitionsDetails.</returns>
        public static Commvault.Powershell.Models.IAlertDefinitionsDetails FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new AlertDefinitionsDetails(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AlertDefinitionsDetails" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AlertDefinitionsDetails" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._alertSummary ? (Commvault.Powershell.Runtime.Json.JsonNode) this._alertSummary.ToJson(null,serializationMode) : null, "alertSummary" ,container.Add );
            AddIf( null != this._alertTarget ? (Commvault.Powershell.Runtime.Json.JsonNode) this._alertTarget.ToJson(null,serializationMode) : null, "alertTarget" ,container.Add );
            AddIf( null != this._template ? (Commvault.Powershell.Runtime.Json.JsonNode) this._template.ToJson(null,serializationMode) : null, "template" ,container.Add );
            AddIf( null != this._id ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._id) : null, "id" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != this._sendIndividualNotifications ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._sendIndividualNotifications) : null, "sendIndividualNotifications" ,container.Add );
            if (null != this._associations)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._associations )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("associations",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}