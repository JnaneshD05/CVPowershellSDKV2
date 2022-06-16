// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class VMGroupCommonProperties
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IVMGroupCommonProperties.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IVMGroupCommonProperties.</returns>
        public static Commvault.Powershell.Models.IVMGroupCommonProperties FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new VMGroupCommonProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VMGroupCommonProperties" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VMGroupCommonProperties" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._indexingInfo ? (Commvault.Powershell.Runtime.Json.JsonNode) this._indexingInfo.ToJson(null,serializationMode) : null, "indexingInfo" ,container.Add );
            AddIf( null != this._hypervisor ? (Commvault.Powershell.Runtime.Json.JsonNode) this._hypervisor.ToJson(null,serializationMode) : null, "hypervisor" ,container.Add );
            AddIf( null != this._instance ? (Commvault.Powershell.Runtime.Json.JsonNode) this._instance.ToJson(null,serializationMode) : null, "instance" ,container.Add );
            AddIf( null != this._backupset ? (Commvault.Powershell.Runtime.Json.JsonNode) this._backupset.ToJson(null,serializationMode) : null, "backupset" ,container.Add );
            AddIf( null != this._dataBackupStoragePolicy ? (Commvault.Powershell.Runtime.Json.JsonNode) this._dataBackupStoragePolicy.ToJson(null,serializationMode) : null, "dataBackupStoragePolicy" ,container.Add );
            AddIf( null != this._isIndexingV2 ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._isIndexingV2) : null, "isIndexingV2" ,container.Add );
            AddIf( null != this._isDeletedHypervisor ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._isDeletedHypervisor) : null, "isDeletedHypervisor" ,container.Add );
            AddIf( null != this._isEtcdSubclient ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._isEtcdSubclient) : null, "isETCDSubclient" ,container.Add );
            AddIf( null != this._showFullBackupLevel ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._showFullBackupLevel) : null, "showFullBackupLevel" ,container.Add );
            AddIf( null != this._isHypervisorDeconfigured ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._isHypervisorDeconfigured) : null, "isHypervisorDeconfigured" ,container.Add );
            AddIf( null != (((object)this._hypervisorType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._hypervisorType.ToString()) : null, "hypervisorType" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="VMGroupCommonProperties" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VMGroupCommonProperties(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_indexingInfo = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("indexingInfo"), out var __jsonIndexingInfo) ? Commvault.Powershell.Models.IndexingInfo.FromJson(__jsonIndexingInfo) : IndexingInfo;}
            {_hypervisor = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("hypervisor"), out var __jsonHypervisor) ? Commvault.Powershell.Models.IdName.FromJson(__jsonHypervisor) : Hypervisor;}
            {_instance = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("instance"), out var __jsonInstance) ? Commvault.Powershell.Models.IdName.FromJson(__jsonInstance) : Instance;}
            {_backupset = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("backupset"), out var __jsonBackupset) ? Commvault.Powershell.Models.IdName.FromJson(__jsonBackupset) : Backupset;}
            {_dataBackupStoragePolicy = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("dataBackupStoragePolicy"), out var __jsonDataBackupStoragePolicy) ? Commvault.Powershell.Models.IdName.FromJson(__jsonDataBackupStoragePolicy) : DataBackupStoragePolicy;}
            {_isIndexingV2 = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("isIndexingV2"), out var __jsonIsIndexingV2) ? (bool?)__jsonIsIndexingV2 : IsIndexingV2;}
            {_isDeletedHypervisor = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("isDeletedHypervisor"), out var __jsonIsDeletedHypervisor) ? (bool?)__jsonIsDeletedHypervisor : IsDeletedHypervisor;}
            {_isEtcdSubclient = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("isETCDSubclient"), out var __jsonIsEtcdSubclient) ? (bool?)__jsonIsEtcdSubclient : IsEtcdSubclient;}
            {_showFullBackupLevel = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("showFullBackupLevel"), out var __jsonShowFullBackupLevel) ? (bool?)__jsonShowFullBackupLevel : ShowFullBackupLevel;}
            {_isHypervisorDeconfigured = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("isHypervisorDeconfigured"), out var __jsonIsHypervisorDeconfigured) ? (bool?)__jsonIsHypervisorDeconfigured : IsHypervisorDeconfigured;}
            {_hypervisorType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("hypervisorType"), out var __jsonHypervisorType) ? (string)__jsonHypervisorType : (string)HypervisorType;}
            AfterFromJson(json);
        }
    }
}