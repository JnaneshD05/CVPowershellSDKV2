// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Recovery Point Objective (RPO) is the maximum amount of time that data can be lost during a service disruption. Your RPO
    /// determines the frequency of your backup jobs.
    /// </summary>
    public partial class ArchivePlanUpdateRpo
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
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="ArchivePlanUpdateRpo" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ArchivePlanUpdateRpo(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_backupFrequency = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("backupFrequency"), out var __jsonBackupFrequency) ? Commvault.Powershell.Models.BackupFrequencyPattern.FromJson(__jsonBackupFrequency) : BackupFrequency;}
            {_sla = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("SLA"), out var __jsonSla) ? Commvault.Powershell.Models.SlaUpdateOptions.FromJson(__jsonSla) : Sla;}
            {_backupWindow = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("backupWindow"), out var __jsonBackupWindow) ? If( __jsonBackupWindow as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Commvault.Powershell.Models.IDayAndTime[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.IDayAndTime) (Commvault.Powershell.Models.DayAndTime.FromJson(__u) )) ))() : null : BackupWindow;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IArchivePlanUpdateRpo.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IArchivePlanUpdateRpo.</returns>
        public static Commvault.Powershell.Models.IArchivePlanUpdateRpo FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new ArchivePlanUpdateRpo(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ArchivePlanUpdateRpo" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ArchivePlanUpdateRpo" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._backupFrequency ? (Commvault.Powershell.Runtime.Json.JsonNode) this._backupFrequency.ToJson(null,serializationMode) : null, "backupFrequency" ,container.Add );
            AddIf( null != this._sla ? (Commvault.Powershell.Runtime.Json.JsonNode) this._sla.ToJson(null,serializationMode) : null, "SLA" ,container.Add );
            if (null != this._backupWindow)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._backupWindow )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("backupWindow",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}