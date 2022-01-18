// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class CommvaultPowerShellIdentity
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
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="CommvaultPowerShellIdentity" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal CommvaultPowerShellIdentity(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_planId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("planId"), out var __jsonPlanId) ? (int?)__jsonPlanId : PlanId;}
            {_backupDestinationId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("BackupDestinationId"), out var __jsonBackupDestinationId) ? (int?)__jsonBackupDestinationId : BackupDestinationId;}
            {_regionList = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("regionList"), out var __jsonRegionList) ? (string)__jsonRegionList : (string)RegionList;}
            {_userId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("userId"), out var __jsonUserId) ? (int?)__jsonUserId : UserId;}
            {_companyId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("companyId"), out var __jsonCompanyId) ? (int?)__jsonCompanyId : CompanyId;}
            {_userGroupId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("userGroupId"), out var __jsonUserGroupId) ? (int?)__jsonUserGroupId : UserGroupId;}
            {_storagePoolId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("storagePoolId"), out var __jsonStoragePoolId) ? (int?)__jsonStoragePoolId : StoragePoolId;}
            {_backupLocationId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("backupLocationId"), out var __jsonBackupLocationId) ? (int?)__jsonBackupLocationId : BackupLocationId;}
            {_accessPathId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("accessPathId"), out var __jsonAccessPathId) ? (int?)__jsonAccessPathId : AccessPathId;}
            {_serverGroupId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("serverGroupId"), out var __jsonServerGroupId) ? (int?)__jsonServerGroupId : ServerGroupId;}
            {_serverId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("serverId"), out var __jsonServerId) ? (int?)__jsonServerId : ServerId;}
            {_agentId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("agentId"), out var __jsonAgentId) ? (int?)__jsonAgentId : AgentId;}
            {_subclientId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("subclientId"), out var __jsonSubclientId) ? (int?)__jsonSubclientId : SubclientId;}
            {_cloudStorageId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("cloudStorageId"), out var __jsonCloudStorageId) ? (int?)__jsonCloudStorageId : CloudStorageId;}
            {_metadataCacheId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("metadataCacheId"), out var __jsonMetadataCacheId) ? (int?)__jsonMetadataCacheId : MetadataCacheId;}
            {_bucketId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("bucketId"), out var __jsonBucketId) ? (int?)__jsonBucketId : BucketId;}
            {_hyperScaleStorageId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("hyperScaleStorageId"), out var __jsonHyperScaleStorageId) ? (int?)__jsonHyperScaleStorageId : HyperScaleStorageId;}
            {_nodeId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("nodeId"), out var __jsonNodeId) ? (int?)__jsonNodeId : NodeId;}
            {_roleId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("roleId"), out var __jsonRoleId) ? (int?)__jsonRoleId : RoleId;}
            {_instanceId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("instanceId"), out var __jsonInstanceId) ? (int?)__jsonInstanceId : InstanceId;}
            {_replicationGroupId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("replicationGroupId"), out var __jsonReplicationGroupId) ? (string)__jsonReplicationGroupId : (string)ReplicationGroupId;}
            {_vMGroupId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("VmGroupId"), out var __jsonVMGroupId) ? (int?)__jsonVMGroupId : VMGroupId;}
            {_vMUuid = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("vmUUID"), out var __jsonVMUuid) ? (string)__jsonVMUuid : (string)VMUuid;}
            {_mediaAgentId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("mediaAgentId"), out var __jsonMediaAgentId) ? (int?)__jsonMediaAgentId : MediaAgentId;}
            {_hypervisorId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("hypervisorId"), out var __jsonHypervisorId) ? (int?)__jsonHypervisorId : HypervisorId;}
            {_topologyId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("topologyId"), out var __jsonTopologyId) ? (string)__jsonTopologyId : (string)TopologyId;}
            {_regionId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("regionId"), out var __jsonRegionId) ? (string)__jsonRegionId : (string)RegionId;}
            {_ruleId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("ruleId"), out var __jsonRuleId) ? (int?)__jsonRuleId : RuleId;}
            {_entityType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("entityType"), out var __jsonEntityType) ? (string)__jsonEntityType : (string)EntityType;}
            {_entityId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("entityId"), out var __jsonEntityId) ? (int?)__jsonEntityId : EntityId;}
            {_blackoutWindowId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("blackoutWindowId"), out var __jsonBlackoutWindowId) ? (int?)__jsonBlackoutWindowId : BlackoutWindowId;}
            {_hfsShareId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("HFSShareId"), out var __jsonHfsShareId) ? (int?)__jsonHfsShareId : HfsShareId;}
            {_globalSearchEntity = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("globalSearchEntity"), out var __jsonGlobalSearchEntity) ? (string)__jsonGlobalSearchEntity : (string)GlobalSearchEntity;}
            {_rpsId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("rpsId"), out var __jsonRpsId) ? (string)__jsonRpsId : (string)RpsId;}
            {_name = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_credentialName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("credentialName"), out var __jsonCredentialName) ? (string)__jsonCredentialName : (string)CredentialName;}
            {_recoveryTargetId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("recoveryTargetId"), out var __jsonRecoveryTargetId) ? (int?)__jsonRecoveryTargetId : RecoveryTargetId;}
            {_domainId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("domainId"), out var __jsonDomainId) ? (int?)__jsonDomainId : DomainId;}
            {_requestId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("requestId"), out var __jsonRequestId) ? (int?)__jsonRequestId : RequestId;}
            {_kmsId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("kmsId"), out var __jsonKmsId) ? (int?)__jsonKmsId : KmsId;}
            {_pairId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("pairId"), out var __jsonPairId) ? (int?)__jsonPairId : PairId;}
            {_id = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("id"), out var __jsonId) ? (int?)__jsonId : Id;}
            {_schedulePolicyId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("schedulePolicyId"), out var __jsonSchedulePolicyId) ? (string)__jsonSchedulePolicyId : (string)SchedulePolicyId;}
            {_scheduleId = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("scheduleId"), out var __jsonScheduleId) ? (string)__jsonScheduleId : (string)ScheduleId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.ICommvaultPowerShellIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.ICommvaultPowerShellIdentity.</returns>
        public static Commvault.Powershell.Models.ICommvaultPowerShellIdentity FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new CommvaultPowerShellIdentity(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="CommvaultPowerShellIdentity" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CommvaultPowerShellIdentity" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._planId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._planId) : null, "planId" ,container.Add );
            AddIf( null != this._backupDestinationId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._backupDestinationId) : null, "BackupDestinationId" ,container.Add );
            AddIf( null != (((object)this._regionList)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._regionList.ToString()) : null, "regionList" ,container.Add );
            AddIf( null != this._userId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._userId) : null, "userId" ,container.Add );
            AddIf( null != this._companyId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._companyId) : null, "companyId" ,container.Add );
            AddIf( null != this._userGroupId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._userGroupId) : null, "userGroupId" ,container.Add );
            AddIf( null != this._storagePoolId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._storagePoolId) : null, "storagePoolId" ,container.Add );
            AddIf( null != this._backupLocationId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._backupLocationId) : null, "backupLocationId" ,container.Add );
            AddIf( null != this._accessPathId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._accessPathId) : null, "accessPathId" ,container.Add );
            AddIf( null != this._serverGroupId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._serverGroupId) : null, "serverGroupId" ,container.Add );
            AddIf( null != this._serverId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._serverId) : null, "serverId" ,container.Add );
            AddIf( null != this._agentId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._agentId) : null, "agentId" ,container.Add );
            AddIf( null != this._subclientId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._subclientId) : null, "subclientId" ,container.Add );
            AddIf( null != this._cloudStorageId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._cloudStorageId) : null, "cloudStorageId" ,container.Add );
            AddIf( null != this._metadataCacheId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._metadataCacheId) : null, "metadataCacheId" ,container.Add );
            AddIf( null != this._bucketId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._bucketId) : null, "bucketId" ,container.Add );
            AddIf( null != this._hyperScaleStorageId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._hyperScaleStorageId) : null, "hyperScaleStorageId" ,container.Add );
            AddIf( null != this._nodeId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._nodeId) : null, "nodeId" ,container.Add );
            AddIf( null != this._roleId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._roleId) : null, "roleId" ,container.Add );
            AddIf( null != this._instanceId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._instanceId) : null, "instanceId" ,container.Add );
            AddIf( null != (((object)this._replicationGroupId)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._replicationGroupId.ToString()) : null, "replicationGroupId" ,container.Add );
            AddIf( null != this._vMGroupId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._vMGroupId) : null, "VmGroupId" ,container.Add );
            AddIf( null != (((object)this._vMUuid)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._vMUuid.ToString()) : null, "vmUUID" ,container.Add );
            AddIf( null != this._mediaAgentId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._mediaAgentId) : null, "mediaAgentId" ,container.Add );
            AddIf( null != this._hypervisorId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._hypervisorId) : null, "hypervisorId" ,container.Add );
            AddIf( null != (((object)this._topologyId)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._topologyId.ToString()) : null, "topologyId" ,container.Add );
            AddIf( null != (((object)this._regionId)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._regionId.ToString()) : null, "regionId" ,container.Add );
            AddIf( null != this._ruleId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._ruleId) : null, "ruleId" ,container.Add );
            AddIf( null != (((object)this._entityType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._entityType.ToString()) : null, "entityType" ,container.Add );
            AddIf( null != this._entityId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._entityId) : null, "entityId" ,container.Add );
            AddIf( null != this._blackoutWindowId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._blackoutWindowId) : null, "blackoutWindowId" ,container.Add );
            AddIf( null != this._hfsShareId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._hfsShareId) : null, "HFSShareId" ,container.Add );
            AddIf( null != (((object)this._globalSearchEntity)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._globalSearchEntity.ToString()) : null, "globalSearchEntity" ,container.Add );
            AddIf( null != (((object)this._rpsId)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._rpsId.ToString()) : null, "rpsId" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._credentialName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._credentialName.ToString()) : null, "credentialName" ,container.Add );
            AddIf( null != this._recoveryTargetId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._recoveryTargetId) : null, "recoveryTargetId" ,container.Add );
            AddIf( null != this._domainId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._domainId) : null, "domainId" ,container.Add );
            AddIf( null != this._requestId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._requestId) : null, "requestId" ,container.Add );
            AddIf( null != this._kmsId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._kmsId) : null, "kmsId" ,container.Add );
            AddIf( null != this._pairId ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._pairId) : null, "pairId" ,container.Add );
            AddIf( null != this._id ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._id) : null, "id" ,container.Add );
            AddIf( null != (((object)this._schedulePolicyId)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._schedulePolicyId.ToString()) : null, "schedulePolicyId" ,container.Add );
            AddIf( null != (((object)this._scheduleId)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._scheduleId.ToString()) : null, "scheduleId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}