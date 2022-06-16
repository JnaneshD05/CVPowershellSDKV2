// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Replication options for Azure. Provide both of the name and the guid of the source VM and provide the id and the name
    /// of the security group
    /// </summary>
    public partial class OverrideReplicationOptionsAzureCreate
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreate.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreate.
        /// </returns>
        public static Commvault.Powershell.Models.IOverrideReplicationOptionsAzureCreate FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new OverrideReplicationOptionsAzureCreate(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="OverrideReplicationOptionsAzureCreate" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OverrideReplicationOptionsAzureCreate(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_sourceVM = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("sourceVM"), out var __jsonSourceVM) ? Commvault.Powershell.Models.NameGuid.FromJson(__jsonSourceVM) : SourceVM;}
            {_securityGroup = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("securityGroup"), out var __jsonSecurityGroup) ? Commvault.Powershell.Models.SecurityGroup.FromJson(__jsonSecurityGroup) : SecurityGroup;}
            {_vMDisplayName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("vmDisplayName"), out var __jsonVMDisplayName) ? (string)__jsonVMDisplayName : (string)VMDisplayName;}
            {_resourceGroup = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("resourceGroup"), out var __jsonResourceGroup) ? (string)__jsonResourceGroup : (string)ResourceGroup;}
            {_region = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("region"), out var __jsonRegion) ? (string)__jsonRegion : (string)Region;}
            {_storageAccount = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("storageAccount"), out var __jsonStorageAccount) ? (string)__jsonStorageAccount : (string)StorageAccount;}
            {_vMSizeId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("vmSizeId"), out var __jsonVMSizeId) ? (string)__jsonVMSizeId : (string)VMSizeId;}
            {_diskTypeId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("diskTypeId"), out var __jsonDiskTypeId) ? (string)__jsonDiskTypeId : (string)DiskTypeId;}
            {_virtualNetwork = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("virtualNetwork"), out var __jsonVirtualNetwork) ? If( __jsonVirtualNetwork as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Commvault.Powershell.Models.INetworkSubnet[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.INetworkSubnet) (Commvault.Powershell.Models.NetworkSubnet.FromJson(__u) )) ))() : null : VirtualNetwork;}
            {_createPublicIP = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("createPublicIP"), out var __jsonCreatePublicIP) ? (bool?)__jsonCreatePublicIP : CreatePublicIP;}
            {_restoreAsManagedVM = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("restoreAsManagedVM"), out var __jsonRestoreAsManagedVM) ? (bool?)__jsonRestoreAsManagedVM : RestoreAsManagedVM;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OverrideReplicationOptionsAzureCreate" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OverrideReplicationOptionsAzureCreate" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._sourceVM ? (Commvault.Powershell.Runtime.Json.JsonNode) this._sourceVM.ToJson(null,serializationMode) : null, "sourceVM" ,container.Add );
            AddIf( null != this._securityGroup ? (Commvault.Powershell.Runtime.Json.JsonNode) this._securityGroup.ToJson(null,serializationMode) : null, "securityGroup" ,container.Add );
            AddIf( null != (((object)this._vMDisplayName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._vMDisplayName.ToString()) : null, "vmDisplayName" ,container.Add );
            AddIf( null != (((object)this._resourceGroup)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._resourceGroup.ToString()) : null, "resourceGroup" ,container.Add );
            AddIf( null != (((object)this._region)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._region.ToString()) : null, "region" ,container.Add );
            AddIf( null != (((object)this._storageAccount)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._storageAccount.ToString()) : null, "storageAccount" ,container.Add );
            AddIf( null != (((object)this._vMSizeId)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._vMSizeId.ToString()) : null, "vmSizeId" ,container.Add );
            AddIf( null != (((object)this._diskTypeId)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._diskTypeId.ToString()) : null, "diskTypeId" ,container.Add );
            if (null != this._virtualNetwork)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._virtualNetwork )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("virtualNetwork",__w);
            }
            AddIf( null != this._createPublicIP ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._createPublicIP) : null, "createPublicIP" ,container.Add );
            AddIf( null != this._restoreAsManagedVM ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._restoreAsManagedVM) : null, "restoreAsManagedVM" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}