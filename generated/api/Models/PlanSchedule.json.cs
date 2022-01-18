// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Used to describe single plan schedule information</summary>
    public partial class PlanSchedule
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IPlanSchedule.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IPlanSchedule.</returns>
        public static Commvault.Powershell.Models.IPlanSchedule FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new PlanSchedule(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="PlanSchedule" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal PlanSchedule(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_schedulePattern = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("schedulePattern"), out var __jsonSchedulePattern) ? Commvault.Powershell.Models.SchedulePattern.FromJson(__jsonSchedulePattern) : SchedulePattern;}
            {_scheduleId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("scheduleId"), out var __jsonScheduleId) ? (int?)__jsonScheduleId : ScheduleId;}
            {_scheduleName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("scheduleName"), out var __jsonScheduleName) ? (string)__jsonScheduleName : (string)ScheduleName;}
            {_policyId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("policyId"), out var __jsonPolicyId) ? (int?)__jsonPolicyId : PolicyId;}
            {_scheduleOperation = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("scheduleOperation"), out var __jsonScheduleOperation) ? (string)__jsonScheduleOperation : (string)ScheduleOperation;}
            {_backupType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("backupType"), out var __jsonBackupType) ? (string)__jsonBackupType : (string)BackupType;}
            {_forDatabasesOnly = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("forDatabasesOnly"), out var __jsonForDatabasesOnly) ? (bool)__jsonForDatabasesOnly : ForDatabasesOnly;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="PlanSchedule" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="PlanSchedule" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._schedulePattern ? (Commvault.Powershell.Runtime.Json.JsonNode) this._schedulePattern.ToJson(null,serializationMode) : null, "schedulePattern" ,container.Add );
            AddIf( null != this._scheduleId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._scheduleId) : null, "scheduleId" ,container.Add );
            AddIf( null != (((object)this._scheduleName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._scheduleName.ToString()) : null, "scheduleName" ,container.Add );
            AddIf( null != this._policyId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._policyId) : null, "policyId" ,container.Add );
            AddIf( null != (((object)this._scheduleOperation)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._scheduleOperation.ToString()) : null, "scheduleOperation" ,container.Add );
            AddIf( null != (((object)this._backupType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._backupType.ToString()) : null, "backupType" ,container.Add );
            AddIf( (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean(this._forDatabasesOnly), "forDatabasesOnly" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}