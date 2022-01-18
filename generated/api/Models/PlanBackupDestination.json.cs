// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class PlanBackupDestination
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IPlanBackupDestination.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IPlanBackupDestination.</returns>
        public static Commvault.Powershell.Models.IPlanBackupDestination FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new PlanBackupDestination(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="PlanBackupDestination" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal PlanBackupDestination(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_planBackupDestinationPlanBackupDestination = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("planBackupDestination"), out var __jsonPlanBackupDestination) ? Commvault.Powershell.Models.IdName.FromJson(__jsonPlanBackupDestination) : PlanBackupDestinationPlanBackupDestination;}
            {_storagePool = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("storagePool"), out var __jsonStoragePool) ? Commvault.Powershell.Models.StoragePool.FromJson(__jsonStoragePool) : StoragePool;}
            {_sourceCopy = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("sourceCopy"), out var __jsonSourceCopy) ? Commvault.Powershell.Models.IdName.FromJson(__jsonSourceCopy) : SourceCopy;}
            {_region = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("region"), out var __jsonRegion) ? Commvault.Powershell.Models.IdNameDisplayName.FromJson(__jsonRegion) : Region;}
            {_extendedRetentionRules = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("extendedRetentionRules"), out var __jsonExtendedRetentionRules) ? Commvault.Powershell.Models.ExtendedRetentionRules.FromJson(__jsonExtendedRetentionRules) : ExtendedRetentionRules;}
            {_netAppCloudTarget = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("netAppCloudTarget"), out var __jsonNetAppCloudTarget) ? (bool?)__jsonNetAppCloudTarget : NetAppCloudTarget;}
            {_isDefault = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("isDefault"), out var __jsonIsDefault) ? (bool?)__jsonIsDefault : IsDefault;}
            {_isSnapCopy = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("isSnapCopy"), out var __jsonIsSnapCopy) ? (bool?)__jsonIsSnapCopy : IsSnapCopy;}
            {_isMirrorCopy = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("isMirrorCopy"), out var __jsonIsMirrorCopy) ? (bool?)__jsonIsMirrorCopy : IsMirrorCopy;}
            {_copyType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("copyType"), out var __jsonCopyType) ? (string)__jsonCopyType : (string)CopyType;}
            {_copyTypeName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("copyTypeName"), out var __jsonCopyTypeName) ? (string)__jsonCopyTypeName : (string)CopyTypeName;}
            {_storageType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("storageType"), out var __jsonStorageType) ? (string)__jsonStorageType : (string)StorageType;}
            {_backupsToCopy = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("backupsToCopy"), out var __jsonBackupsToCopy) ? (string)__jsonBackupsToCopy : (string)BackupsToCopy;}
            {_backupStartTime = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("backupStartTime"), out var __jsonBackupStartTime) ? (int?)__jsonBackupStartTime : BackupStartTime;}
            {_retentionRuleType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("retentionRuleType"), out var __jsonRetentionRuleType) ? (string)__jsonRetentionRuleType : (string)RetentionRuleType;}
            {_retentionPeriodDays = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("retentionPeriodDays"), out var __jsonRetentionPeriodDays) ? (int?)__jsonRetentionPeriodDays : RetentionPeriodDays;}
            {_snapRecoveryPoints = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("snapRecoveryPoints"), out var __jsonSnapRecoveryPoints) ? (int?)__jsonSnapRecoveryPoints : SnapRecoveryPoints;}
            {_useExtendedRetentionRules = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("useExtendedRetentionRules"), out var __jsonUseExtendedRetentionRules) ? (bool?)__jsonUseExtendedRetentionRules : UseExtendedRetentionRules;}
            {_mappings = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("mappings"), out var __jsonMappings) ? If( __jsonMappings as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Commvault.Powershell.Models.ISnapshotCopyMapping[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.ISnapshotCopyMapping) (Commvault.Powershell.Models.SnapshotCopyMapping.FromJson(__u) )) ))() : null : Mappings;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="PlanBackupDestination" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="PlanBackupDestination" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._planBackupDestinationPlanBackupDestination ? (Commvault.Powershell.Runtime.Json.JsonNode) this._planBackupDestinationPlanBackupDestination.ToJson(null,serializationMode) : null, "planBackupDestination" ,container.Add );
            AddIf( null != this._storagePool ? (Commvault.Powershell.Runtime.Json.JsonNode) this._storagePool.ToJson(null,serializationMode) : null, "storagePool" ,container.Add );
            AddIf( null != this._sourceCopy ? (Commvault.Powershell.Runtime.Json.JsonNode) this._sourceCopy.ToJson(null,serializationMode) : null, "sourceCopy" ,container.Add );
            AddIf( null != this._region ? (Commvault.Powershell.Runtime.Json.JsonNode) this._region.ToJson(null,serializationMode) : null, "region" ,container.Add );
            AddIf( null != this._extendedRetentionRules ? (Commvault.Powershell.Runtime.Json.JsonNode) this._extendedRetentionRules.ToJson(null,serializationMode) : null, "extendedRetentionRules" ,container.Add );
            AddIf( null != this._netAppCloudTarget ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._netAppCloudTarget) : null, "netAppCloudTarget" ,container.Add );
            AddIf( null != this._isDefault ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._isDefault) : null, "isDefault" ,container.Add );
            AddIf( null != this._isSnapCopy ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._isSnapCopy) : null, "isSnapCopy" ,container.Add );
            AddIf( null != this._isMirrorCopy ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._isMirrorCopy) : null, "isMirrorCopy" ,container.Add );
            AddIf( null != (((object)this._copyType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._copyType.ToString()) : null, "copyType" ,container.Add );
            AddIf( null != (((object)this._copyTypeName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._copyTypeName.ToString()) : null, "copyTypeName" ,container.Add );
            AddIf( null != (((object)this._storageType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._storageType.ToString()) : null, "storageType" ,container.Add );
            AddIf( null != (((object)this._backupsToCopy)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._backupsToCopy.ToString()) : null, "backupsToCopy" ,container.Add );
            AddIf( null != this._backupStartTime ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._backupStartTime) : null, "backupStartTime" ,container.Add );
            AddIf( null != (((object)this._retentionRuleType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._retentionRuleType.ToString()) : null, "retentionRuleType" ,container.Add );
            AddIf( null != this._retentionPeriodDays ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._retentionPeriodDays) : null, "retentionPeriodDays" ,container.Add );
            AddIf( null != this._snapRecoveryPoints ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._snapRecoveryPoints) : null, "snapRecoveryPoints" ,container.Add );
            AddIf( null != this._useExtendedRetentionRules ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._useExtendedRetentionRules) : null, "useExtendedRetentionRules" ,container.Add );
            if (null != this._mappings)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._mappings )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("mappings",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}