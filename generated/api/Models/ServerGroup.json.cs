// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class ServerGroup
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IServerGroup.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IServerGroup.</returns>
        public static Commvault.Powershell.Models.IServerGroup FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new ServerGroup(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="ServerGroup" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ServerGroup(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_serverGroup1 = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("serverGroup"), out var __jsonServerGroup) ? Commvault.Powershell.Models.IdName.FromJson(__jsonServerGroup) : ServerGroup1;}
            {_general = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("general"), out var __jsonGeneral) ? Commvault.Powershell.Models.GeneralInfoServerGroup.FromJson(__jsonGeneral) : General;}
            {_activityControl = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("activityControl"), out var __jsonActivityControl) ? Commvault.Powershell.Models.ActivityControl.FromJson(__jsonActivityControl) : ActivityControl;}
            {_powerManagement = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("powerManagement"), out var __jsonPowerManagement) ? Commvault.Powershell.Models.IdName.FromJson(__jsonPowerManagement) : PowerManagement;}
            {_fileExceptions = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("fileExceptions"), out var __jsonFileExceptions) ? Commvault.Powershell.Models.FileExceptionsDetail.FromJson(__jsonFileExceptions) : FileExceptions;}
            {_security = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("security"), out var __jsonSecurity) ? If( __jsonSecurity as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Commvault.Powershell.Models.ISecurityAssoc[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.ISecurityAssoc) (Commvault.Powershell.Models.SecurityAssoc.FromJson(__u) )) ))() : null : Security;}
            {_associatedServers = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("associatedServers"), out var __jsonAssociatedServers) ? If( __jsonAssociatedServers as Commvault.Powershell.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Commvault.Powershell.Models.IServerDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Commvault.Powershell.Models.IServerDetails) (Commvault.Powershell.Models.ServerDetails.FromJson(__p) )) ))() : null : AssociatedServers;}
            {_blackoutWindow = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("blackoutWindow"), out var __jsonBlackoutWindow) ? If( __jsonBlackoutWindow as Commvault.Powershell.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Commvault.Powershell.Models.IBlackoutWindowDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Commvault.Powershell.Models.IBlackoutWindowDetails) (Commvault.Powershell.Models.BlackoutWindowDetails.FromJson(__k) )) ))() : null : BlackoutWindow;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ServerGroup" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ServerGroup" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._serverGroup1 ? (Commvault.Powershell.Runtime.Json.JsonNode) this._serverGroup1.ToJson(null,serializationMode) : null, "serverGroup" ,container.Add );
            AddIf( null != this._general ? (Commvault.Powershell.Runtime.Json.JsonNode) this._general.ToJson(null,serializationMode) : null, "general" ,container.Add );
            AddIf( null != this._activityControl ? (Commvault.Powershell.Runtime.Json.JsonNode) this._activityControl.ToJson(null,serializationMode) : null, "activityControl" ,container.Add );
            AddIf( null != this._powerManagement ? (Commvault.Powershell.Runtime.Json.JsonNode) this._powerManagement.ToJson(null,serializationMode) : null, "powerManagement" ,container.Add );
            AddIf( null != this._fileExceptions ? (Commvault.Powershell.Runtime.Json.JsonNode) this._fileExceptions.ToJson(null,serializationMode) : null, "fileExceptions" ,container.Add );
            if (null != this._security)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._security )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("security",__w);
            }
            if (null != this._associatedServers)
            {
                var __r = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __s in this._associatedServers )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("associatedServers",__r);
            }
            if (null != this._blackoutWindow)
            {
                var __m = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __n in this._blackoutWindow )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("blackoutWindow",__m);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}