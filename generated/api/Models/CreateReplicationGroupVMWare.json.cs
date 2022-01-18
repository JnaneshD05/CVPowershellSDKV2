// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Create a replication group with VMWare as the destination vendor. SourceHypervisor is the hypervisor that has the VM's
    /// to be backed up. Recovery target contains the replication options that will be applied to the selected VM's. ID is mandatory
    /// for sourceHypervisor and recovery target. Provide both the id and the name for the storage and the vms.
    /// </summary>
    public partial class CreateReplicationGroupVMWare
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
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="CreateReplicationGroupVMWare" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal CreateReplicationGroupVMWare(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __createReplicationGroup = new Commvault.Powershell.Models.CreateReplicationGroup(json);
            {_advancedOptions = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("advancedOptions"), out var __jsonAdvancedOptions) ? Commvault.Powershell.Models.ReplicationGroupAdvOptionsVMWareCreate.FromJson(__jsonAdvancedOptions) : AdvancedOptions;}
            {_snapEngine = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("snapEngine"), out var __jsonSnapEngine) ? Commvault.Powershell.Models.IdName.FromJson(__jsonSnapEngine) : SnapEngine;}
            {_recoveryOptions = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("recoveryOptions"), out var __jsonRecoveryOptions) ? Commvault.Powershell.Models.RecoveryOptionsCreate.FromJson(__jsonRecoveryOptions) : RecoveryOptions;}
            {_destVendor = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("destVendor"), out var __jsonDestVendor) ? (string)__jsonDestVendor : (string)DestVendor;}
            {_replicationType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("replicationType"), out var __jsonReplicationType) ? (string)__jsonReplicationType : (string)ReplicationType;}
            {_overrideReplicationOptions = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("overrideReplicationOptions"), out var __jsonOverrideReplicationOptions) ? If( __jsonOverrideReplicationOptions as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareCreate[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.IOverrideReplicationOptionsVMWareCreate) (Commvault.Powershell.Models.OverrideReplicationOptionsVMWareCreate.FromJson(__u) )) ))() : null : OverrideReplicationOptions;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.ICreateReplicationGroupVMWare.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.ICreateReplicationGroupVMWare.</returns>
        public static Commvault.Powershell.Models.ICreateReplicationGroupVMWare FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new CreateReplicationGroupVMWare(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="CreateReplicationGroupVMWare" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CreateReplicationGroupVMWare" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            __createReplicationGroup?.ToJson(container, serializationMode);
            AddIf( null != this._advancedOptions ? (Commvault.Powershell.Runtime.Json.JsonNode) this._advancedOptions.ToJson(null,serializationMode) : null, "advancedOptions" ,container.Add );
            AddIf( null != this._snapEngine ? (Commvault.Powershell.Runtime.Json.JsonNode) this._snapEngine.ToJson(null,serializationMode) : null, "snapEngine" ,container.Add );
            AddIf( null != this._recoveryOptions ? (Commvault.Powershell.Runtime.Json.JsonNode) this._recoveryOptions.ToJson(null,serializationMode) : null, "recoveryOptions" ,container.Add );
            AddIf( null != (((object)this._destVendor)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._destVendor.ToString()) : null, "destVendor" ,container.Add );
            AddIf( null != (((object)this._replicationType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._replicationType.ToString()) : null, "replicationType" ,container.Add );
            if (null != this._overrideReplicationOptions)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._overrideReplicationOptions )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("overrideReplicationOptions",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}