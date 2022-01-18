// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Summary of the Alert Triggered</summary>
    public partial class AlertTriggeredSummary
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
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="AlertTriggeredSummary" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AlertTriggeredSummary(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_client = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("client"), out var __jsonClient) ? Commvault.Powershell.Models.IdName.FromJson(__jsonClient) : Client;}
            {_company = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("company"), out var __jsonCompany) ? Commvault.Powershell.Models.IdName.FromJson(__jsonCompany) : Company;}
            {_id = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("id"), out var __jsonId) ? (int?)__jsonId : Id;}
            {_severity = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("severity"), out var __jsonSeverity) ? (string)__jsonSeverity : (string)Severity;}
            {_detectedCriterion = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("detectedCriterion"), out var __jsonDetectedCriterion) ? (string)__jsonDetectedCriterion : (string)DetectedCriterion;}
            {_info = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("info"), out var __jsonInfo) ? (string)__jsonInfo : (string)Info;}
            {_notes = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("notes"), out var __jsonNotes) ? (string)__jsonNotes : (string)Notes;}
            {_type = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            {_detectedTime = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("detectedTime"), out var __jsonDetectedTime) ? (int?)__jsonDetectedTime : DetectedTime;}
            {_readStatus = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("readStatus"), out var __jsonReadStatus) ? (bool?)__jsonReadStatus : ReadStatus;}
            {_jobId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("jobId"), out var __jsonJobId) ? (int?)__jsonJobId : JobId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IAlertTriggeredSummary.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IAlertTriggeredSummary.</returns>
        public static Commvault.Powershell.Models.IAlertTriggeredSummary FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new AlertTriggeredSummary(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AlertTriggeredSummary" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AlertTriggeredSummary" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._client ? (Commvault.Powershell.Runtime.Json.JsonNode) this._client.ToJson(null,serializationMode) : null, "client" ,container.Add );
            AddIf( null != this._company ? (Commvault.Powershell.Runtime.Json.JsonNode) this._company.ToJson(null,serializationMode) : null, "company" ,container.Add );
            AddIf( null != this._id ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._id) : null, "id" ,container.Add );
            AddIf( null != (((object)this._severity)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._severity.ToString()) : null, "severity" ,container.Add );
            AddIf( null != (((object)this._detectedCriterion)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._detectedCriterion.ToString()) : null, "detectedCriterion" ,container.Add );
            AddIf( null != (((object)this._info)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._info.ToString()) : null, "info" ,container.Add );
            AddIf( null != (((object)this._notes)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._notes.ToString()) : null, "notes" ,container.Add );
            AddIf( null != (((object)this._type)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AddIf( null != this._detectedTime ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._detectedTime) : null, "detectedTime" ,container.Add );
            AddIf( null != this._readStatus ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._readStatus) : null, "readStatus" ,container.Add );
            AddIf( null != this._jobId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._jobId) : null, "jobId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}