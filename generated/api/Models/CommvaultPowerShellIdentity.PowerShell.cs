// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(CommvaultPowerShellIdentityTypeConverter))]
    public partial class CommvaultPowerShellIdentity
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.CommvaultPowerShellIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CommvaultPowerShellIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).PlanId = (int?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).PlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BackupDestinationId = (int?) content.GetValueForProperty("BackupDestinationId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BackupDestinationId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RegionList = (string) content.GetValueForProperty("RegionList",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RegionList, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).UserId = (int?) content.GetValueForProperty("UserId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).UserId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).CompanyId = (int?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).CompanyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).UserGroupId = (int?) content.GetValueForProperty("UserGroupId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).UserGroupId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).StoragePoolId = (int?) content.GetValueForProperty("StoragePoolId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).StoragePoolId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BackupLocationId = (int?) content.GetValueForProperty("BackupLocationId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BackupLocationId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).AccessPathId = (int?) content.GetValueForProperty("AccessPathId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).AccessPathId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ServerGroupId = (int?) content.GetValueForProperty("ServerGroupId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ServerGroupId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ServerId = (int?) content.GetValueForProperty("ServerId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ServerId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).AgentId = (int?) content.GetValueForProperty("AgentId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).AgentId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).SubclientId = (int?) content.GetValueForProperty("SubclientId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).SubclientId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).CloudStorageId = (int?) content.GetValueForProperty("CloudStorageId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).CloudStorageId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).MetadataCacheId = (int?) content.GetValueForProperty("MetadataCacheId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).MetadataCacheId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BucketId = (int?) content.GetValueForProperty("BucketId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BucketId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).HyperScaleStorageId = (int?) content.GetValueForProperty("HyperScaleStorageId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).HyperScaleStorageId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).NodeId = (int?) content.GetValueForProperty("NodeId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).NodeId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RoleId = (int?) content.GetValueForProperty("RoleId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RoleId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).InstanceId = (int?) content.GetValueForProperty("InstanceId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).InstanceId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ReplicationGroupId = (string) content.GetValueForProperty("ReplicationGroupId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ReplicationGroupId, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).VMGroupId = (int?) content.GetValueForProperty("VMGroupId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).VMGroupId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).VMUuid = (string) content.GetValueForProperty("VMUuid",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).VMUuid, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).MediaAgentId = (int?) content.GetValueForProperty("MediaAgentId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).MediaAgentId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).HypervisorId = (int?) content.GetValueForProperty("HypervisorId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).HypervisorId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).InventoryEntityName = (string) content.GetValueForProperty("InventoryEntityName",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).InventoryEntityName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).TopologyId = (string) content.GetValueForProperty("TopologyId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).TopologyId, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RegionId = (int?) content.GetValueForProperty("RegionId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RegionId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RuleId = (int?) content.GetValueForProperty("RuleId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RuleId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).EntityType = (int?) content.GetValueForProperty("EntityType",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).EntityType, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).EntityId = (int?) content.GetValueForProperty("EntityId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).EntityId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BlackoutWindowId = (int?) content.GetValueForProperty("BlackoutWindowId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BlackoutWindowId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).HfsShareId = (int?) content.GetValueForProperty("HfsShareId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).HfsShareId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).GlobalSearchEntity = (string) content.GetValueForProperty("GlobalSearchEntity",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).GlobalSearchEntity, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RpsId = (string) content.GetValueForProperty("RpsId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RpsId, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).CredentialName = (string) content.GetValueForProperty("CredentialName",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).CredentialName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RecoveryTargetId = (int?) content.GetValueForProperty("RecoveryTargetId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RecoveryTargetId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).DomainId = (int?) content.GetValueForProperty("DomainId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).DomainId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RequestId = (int?) content.GetValueForProperty("RequestId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RequestId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).KmsId = (int?) content.GetValueForProperty("KmsId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).KmsId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).PairId = (int?) content.GetValueForProperty("PairId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).PairId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).SchedulePolicyId = (string) content.GetValueForProperty("SchedulePolicyId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).SchedulePolicyId, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ScheduleId = (string) content.GetValueForProperty("ScheduleId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ScheduleId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.CommvaultPowerShellIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CommvaultPowerShellIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).PlanId = (int?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).PlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BackupDestinationId = (int?) content.GetValueForProperty("BackupDestinationId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BackupDestinationId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RegionList = (string) content.GetValueForProperty("RegionList",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RegionList, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).UserId = (int?) content.GetValueForProperty("UserId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).UserId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).CompanyId = (int?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).CompanyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).UserGroupId = (int?) content.GetValueForProperty("UserGroupId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).UserGroupId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).StoragePoolId = (int?) content.GetValueForProperty("StoragePoolId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).StoragePoolId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BackupLocationId = (int?) content.GetValueForProperty("BackupLocationId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BackupLocationId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).AccessPathId = (int?) content.GetValueForProperty("AccessPathId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).AccessPathId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ServerGroupId = (int?) content.GetValueForProperty("ServerGroupId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ServerGroupId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ServerId = (int?) content.GetValueForProperty("ServerId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ServerId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).AgentId = (int?) content.GetValueForProperty("AgentId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).AgentId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).SubclientId = (int?) content.GetValueForProperty("SubclientId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).SubclientId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).CloudStorageId = (int?) content.GetValueForProperty("CloudStorageId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).CloudStorageId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).MetadataCacheId = (int?) content.GetValueForProperty("MetadataCacheId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).MetadataCacheId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BucketId = (int?) content.GetValueForProperty("BucketId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BucketId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).HyperScaleStorageId = (int?) content.GetValueForProperty("HyperScaleStorageId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).HyperScaleStorageId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).NodeId = (int?) content.GetValueForProperty("NodeId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).NodeId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RoleId = (int?) content.GetValueForProperty("RoleId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RoleId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).InstanceId = (int?) content.GetValueForProperty("InstanceId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).InstanceId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ReplicationGroupId = (string) content.GetValueForProperty("ReplicationGroupId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ReplicationGroupId, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).VMGroupId = (int?) content.GetValueForProperty("VMGroupId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).VMGroupId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).VMUuid = (string) content.GetValueForProperty("VMUuid",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).VMUuid, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).MediaAgentId = (int?) content.GetValueForProperty("MediaAgentId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).MediaAgentId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).HypervisorId = (int?) content.GetValueForProperty("HypervisorId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).HypervisorId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).InventoryEntityName = (string) content.GetValueForProperty("InventoryEntityName",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).InventoryEntityName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).TopologyId = (string) content.GetValueForProperty("TopologyId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).TopologyId, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RegionId = (int?) content.GetValueForProperty("RegionId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RegionId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RuleId = (int?) content.GetValueForProperty("RuleId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RuleId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).EntityType = (int?) content.GetValueForProperty("EntityType",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).EntityType, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).EntityId = (int?) content.GetValueForProperty("EntityId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).EntityId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BlackoutWindowId = (int?) content.GetValueForProperty("BlackoutWindowId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).BlackoutWindowId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).HfsShareId = (int?) content.GetValueForProperty("HfsShareId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).HfsShareId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).GlobalSearchEntity = (string) content.GetValueForProperty("GlobalSearchEntity",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).GlobalSearchEntity, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RpsId = (string) content.GetValueForProperty("RpsId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RpsId, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).CredentialName = (string) content.GetValueForProperty("CredentialName",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).CredentialName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RecoveryTargetId = (int?) content.GetValueForProperty("RecoveryTargetId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RecoveryTargetId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).DomainId = (int?) content.GetValueForProperty("DomainId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).DomainId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RequestId = (int?) content.GetValueForProperty("RequestId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).RequestId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).KmsId = (int?) content.GetValueForProperty("KmsId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).KmsId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).PairId = (int?) content.GetValueForProperty("PairId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).PairId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).SchedulePolicyId = (string) content.GetValueForProperty("SchedulePolicyId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).SchedulePolicyId, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ScheduleId = (string) content.GetValueForProperty("ScheduleId",((Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal)this).ScheduleId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.CommvaultPowerShellIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.ICommvaultPowerShellIdentity" />.
        /// </returns>
        public static Commvault.Powershell.Models.ICommvaultPowerShellIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CommvaultPowerShellIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.CommvaultPowerShellIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.ICommvaultPowerShellIdentity" />.
        /// </returns>
        public static Commvault.Powershell.Models.ICommvaultPowerShellIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CommvaultPowerShellIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CommvaultPowerShellIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.ICommvaultPowerShellIdentity FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(CommvaultPowerShellIdentityTypeConverter))]
    public partial interface ICommvaultPowerShellIdentity

    {

    }
}