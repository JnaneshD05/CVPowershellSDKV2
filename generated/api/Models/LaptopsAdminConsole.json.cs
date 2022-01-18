// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class LaptopsAdminConsole
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.ILaptopsAdminConsole.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.ILaptopsAdminConsole.</returns>
        public static Commvault.Powershell.Models.ILaptopsAdminConsole FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new LaptopsAdminConsole(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="LaptopsAdminConsole" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal LaptopsAdminConsole(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_lastBackupJobInfo = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("lastBackupJobInfo"), out var __jsonLastBackupJobInfo) ? Commvault.Powershell.Models.LastBackupJobInfo.FromJson(__jsonLastBackupJobInfo) : LastBackupJobInfo;}
            {_plan = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("plan"), out var __jsonPlan) ? Commvault.Powershell.Models.IdName.FromJson(__jsonPlan) : Plan;}
            {_sla = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("sla"), out var __jsonSla) ? Commvault.Powershell.Models.SlaDetails.FromJson(__jsonSla) : Sla;}
            {_id = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("id"), out var __jsonId) ? (int?)__jsonId : Id;}
            {_name = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_owners = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("owners"), out var __jsonOwners) ? If( __jsonOwners as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Commvault.Powershell.Models.IIdName[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.IIdName) (Commvault.Powershell.Models.IdName.FromJson(__u) )) ))() : null : Owners;}
            {_username = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("username"), out var __jsonUsername) ? (string)__jsonUsername : (string)Username;}
            {_email = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("email"), out var __jsonEmail) ? (string)__jsonEmail : (string)Email;}
            {_configured = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("configured"), out var __jsonConfigured) ? (bool?)__jsonConfigured : Configured;}
            {_totalBackupSize = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("totalBackupSize"), out var __jsonTotalBackupSize) ? (int?)__jsonTotalBackupSize : TotalBackupSize;}
            {_slaReason = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("slaReason"), out var __jsonSlaReason) ? (string)__jsonSlaReason : (string)SlaReason;}
            {_lastSuccessfulBackup = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("lastSuccessfulBackup"), out var __jsonLastSuccessfulBackup) ? (int?)__jsonLastSuccessfulBackup : LastSuccessfulBackup;}
            {_tags = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("tags"), out var __jsonTags) ? If( __jsonTags as Commvault.Powershell.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Commvault.Powershell.Models.IIdNameType[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Commvault.Powershell.Models.IIdNameType) (Commvault.Powershell.Models.IdNameType.FromJson(__p) )) ))() : null : Tags;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="LaptopsAdminConsole" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="LaptopsAdminConsole" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._lastBackupJobInfo ? (Commvault.Powershell.Runtime.Json.JsonNode) this._lastBackupJobInfo.ToJson(null,serializationMode) : null, "lastBackupJobInfo" ,container.Add );
            AddIf( null != this._plan ? (Commvault.Powershell.Runtime.Json.JsonNode) this._plan.ToJson(null,serializationMode) : null, "plan" ,container.Add );
            AddIf( null != this._sla ? (Commvault.Powershell.Runtime.Json.JsonNode) this._sla.ToJson(null,serializationMode) : null, "sla" ,container.Add );
            AddIf( null != this._id ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._id) : null, "id" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            if (null != this._owners)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._owners )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("owners",__w);
            }
            AddIf( null != (((object)this._username)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._username.ToString()) : null, "username" ,container.Add );
            AddIf( null != (((object)this._email)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._email.ToString()) : null, "email" ,container.Add );
            AddIf( null != this._configured ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._configured) : null, "configured" ,container.Add );
            AddIf( null != this._totalBackupSize ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._totalBackupSize) : null, "totalBackupSize" ,container.Add );
            AddIf( null != (((object)this._slaReason)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._slaReason.ToString()) : null, "slaReason" ,container.Add );
            AddIf( null != this._lastSuccessfulBackup ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._lastSuccessfulBackup) : null, "lastSuccessfulBackup" ,container.Add );
            if (null != this._tags)
            {
                var __r = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __s in this._tags )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("tags",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}