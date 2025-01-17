// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Replication options for VMware</summary>
    public partial class OverrideReplicationOptionsVMWare
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IOverrideReplicationOptionsVMWare.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IOverrideReplicationOptionsVMWare.</returns>
        public static Commvault.Powershell.Models.IOverrideReplicationOptionsVMWare FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new OverrideReplicationOptionsVMWare(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="OverrideReplicationOptionsVMWare" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OverrideReplicationOptionsVMWare(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_vMDisplayName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("vmDisplayName"), out var __jsonVMDisplayName) ? (string)__jsonVMDisplayName : (string)VMDisplayName;}
            {_destinationHost = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("destinationHost"), out var __jsonDestinationHost) ? (string)__jsonDestinationHost : (string)DestinationHost;}
            {_datastore = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("datastore"), out var __jsonDatastore) ? (string)__jsonDatastore : (string)Datastore;}
            {_resourcePool = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("resourcePool"), out var __jsonResourcePool) ? (string)__jsonResourcePool : (string)ResourcePool;}
            {_vMFolder = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("vmFolder"), out var __jsonVMFolder) ? (string)__jsonVMFolder : (string)VMFolder;}
            {_networkSettings = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("networkSettings"), out var __jsonNetworkSettings) ? If( __jsonNetworkSettings as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Commvault.Powershell.Models.INetworkSetting[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.INetworkSetting) (Commvault.Powershell.Models.NetworkSetting.FromJson(__u) )) ))() : null : NetworkSettings;}
            {_iPAddressSettings = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("ipAddressSettings"), out var __jsonIPAddressSettings) ? If( __jsonIPAddressSettings as Commvault.Powershell.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Commvault.Powershell.Models.IIPAddressSetting[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Commvault.Powershell.Models.IIPAddressSetting) (Commvault.Powershell.Models.IPAddressSetting.FromJson(__p) )) ))() : null : IPAddressSettings;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OverrideReplicationOptionsVMWare" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OverrideReplicationOptionsVMWare" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._vMDisplayName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._vMDisplayName.ToString()) : null, "vmDisplayName" ,container.Add );
            AddIf( null != (((object)this._destinationHost)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._destinationHost.ToString()) : null, "destinationHost" ,container.Add );
            AddIf( null != (((object)this._datastore)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._datastore.ToString()) : null, "datastore" ,container.Add );
            AddIf( null != (((object)this._resourcePool)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._resourcePool.ToString()) : null, "resourcePool" ,container.Add );
            AddIf( null != (((object)this._vMFolder)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._vMFolder.ToString()) : null, "vmFolder" ,container.Add );
            if (null != this._networkSettings)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._networkSettings )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("networkSettings",__w);
            }
            if (null != this._iPAddressSettings)
            {
                var __r = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __s in this._iPAddressSettings )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("ipAddressSettings",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}