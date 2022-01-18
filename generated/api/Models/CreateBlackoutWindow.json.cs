// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// betweenDates refers to the dates where the blackout window will be in effect. Dates have to be given in unix time format.
    /// time has to be provided in seconds. company refers to company to which the blackout window is associated.Id is given first
    /// preference if both are id and name are provided.
    /// </summary>
    public partial class CreateBlackoutWindow
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
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="CreateBlackoutWindow" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal CreateBlackoutWindow(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_company = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("company"), out var __jsonCompany) ? Commvault.Powershell.Models.IdName.FromJson(__jsonCompany) : Company;}
            {_betweenDates = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("betweenDates"), out var __jsonBetweenDates) ? Commvault.Powershell.Models.StartEnd.FromJson(__jsonBetweenDates) : BetweenDates;}
            {_name = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_backupOperations = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("backupOperations"), out var __jsonBackupOperations) ? If( __jsonBackupOperations as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Commvault.Powershell.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : BackupOperations;}
            {_days = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("days"), out var __jsonDays) ? If( __jsonDays as Commvault.Powershell.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Commvault.Powershell.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : Days;}
            {_weeks = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("weeks"), out var __jsonWeeks) ? If( __jsonWeeks as Commvault.Powershell.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is Commvault.Powershell.Runtime.Json.JsonString __j ? (string)(__j.ToString()) : null)) ))() : null : Weeks;}
            {_time = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("time"), out var __jsonTime) ? If( __jsonTime as Commvault.Powershell.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Commvault.Powershell.Models.IStartEnd[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Commvault.Powershell.Models.IStartEnd) (Commvault.Powershell.Models.StartEnd.FromJson(__f) )) ))() : null : Time;}
            {_doNotSubmitJob = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("doNotSubmitJob"), out var __jsonDoNotSubmitJob) ? (bool?)__jsonDoNotSubmitJob : DoNotSubmitJob;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.ICreateBlackoutWindow.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.ICreateBlackoutWindow.</returns>
        public static Commvault.Powershell.Models.ICreateBlackoutWindow FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new CreateBlackoutWindow(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="CreateBlackoutWindow" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CreateBlackoutWindow" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._company ? (Commvault.Powershell.Runtime.Json.JsonNode) this._company.ToJson(null,serializationMode) : null, "company" ,container.Add );
            AddIf( null != this._betweenDates ? (Commvault.Powershell.Runtime.Json.JsonNode) this._betweenDates.ToJson(null,serializationMode) : null, "betweenDates" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            if (null != this._backupOperations)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._backupOperations )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("backupOperations",__w);
            }
            if (null != this._days)
            {
                var __r = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __s in this._days )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("days",__r);
            }
            if (null != this._weeks)
            {
                var __m = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __n in this._weeks )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("weeks",__m);
            }
            if (null != this._time)
            {
                var __h = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __i in this._time )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("time",__h);
            }
            AddIf( null != this._doNotSubmitJob ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._doNotSubmitJob) : null, "doNotSubmitJob" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}