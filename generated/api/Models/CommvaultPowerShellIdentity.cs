// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class CommvaultPowerShellIdentity :
        Commvault.Powershell.Models.ICommvaultPowerShellIdentity,
        Commvault.Powershell.Models.ICommvaultPowerShellIdentityInternal
    {

        /// <summary>Backing field for <see cref="AccessPathId" /> property.</summary>
        private int? _accessPathId;

        /// <summary>Id of the mount path whose access path has to be deleted</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? AccessPathId { get => this._accessPathId; set => this._accessPathId = value; }

        /// <summary>Backing field for <see cref="AgentId" /> property.</summary>
        private int? _agentId;

        /// <summary>Id of the agent to be modified</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? AgentId { get => this._agentId; set => this._agentId = value; }

        /// <summary>Backing field for <see cref="BackupDestinationId" /> property.</summary>
        private int? _backupDestinationId;

        /// <summary>Id of the backupDestination to be modified</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? BackupDestinationId { get => this._backupDestinationId; set => this._backupDestinationId = value; }

        /// <summary>Backing field for <see cref="BackupLocationId" /> property.</summary>
        private int? _backupLocationId;

        /// <summary>Id of the backup location whose details have to be fetched</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? BackupLocationId { get => this._backupLocationId; set => this._backupLocationId = value; }

        /// <summary>Backing field for <see cref="BlackoutWindowId" /> property.</summary>
        private int? _blackoutWindowId;

        /// <summary>Id of the Blackout Window whose details have to be fetched</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? BlackoutWindowId { get => this._blackoutWindowId; set => this._blackoutWindowId = value; }

        /// <summary>Backing field for <see cref="BucketId" /> property.</summary>
        private int? _bucketId;

        /// <summary>Id of Bucket</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? BucketId { get => this._bucketId; set => this._bucketId = value; }

        /// <summary>Backing field for <see cref="CloudStorageId" /> property.</summary>
        private int? _cloudStorageId;

        /// <summary>Id of cloud Storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? CloudStorageId { get => this._cloudStorageId; set => this._cloudStorageId = value; }

        /// <summary>Backing field for <see cref="CompanyId" /> property.</summary>
        private int? _companyId;

        /// <summary>Id of the Company whose details have to be fetched</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? CompanyId { get => this._companyId; set => this._companyId = value; }

        /// <summary>Backing field for <see cref="CredentialName" /> property.</summary>
        private string _credentialName;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CredentialName { get => this._credentialName; set => this._credentialName = value; }

        /// <summary>Backing field for <see cref="DomainId" /> property.</summary>
        private int? _domainId;

        /// <summary>ID of the AD/LDAP domain</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? DomainId { get => this._domainId; set => this._domainId = value; }

        /// <summary>Backing field for <see cref="EntityId" /> property.</summary>
        private int? _entityId;

        /// <summary>Unique id for the entity</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? EntityId { get => this._entityId; set => this._entityId = value; }

        /// <summary>Backing field for <see cref="EntityType" /> property.</summary>
        private int? _entityType;

        /// <summary>Type of the entity</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? EntityType { get => this._entityType; set => this._entityType = value; }

        /// <summary>Backing field for <see cref="GlobalSearchEntity" /> property.</summary>
        private string _globalSearchEntity;

        /// <summary>name of global search entity</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string GlobalSearchEntity { get => this._globalSearchEntity; set => this._globalSearchEntity = value; }

        /// <summary>Backing field for <see cref="HfsShareId" /> property.</summary>
        private int? _hfsShareId;

        /// <summary>Id of the HFS Share to fetch its status</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? HfsShareId { get => this._hfsShareId; set => this._hfsShareId = value; }

        /// <summary>Backing field for <see cref="HyperScaleStorageId" /> property.</summary>
        private int? _hyperScaleStorageId;

        /// <summary>Id of hyperscale storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? HyperScaleStorageId { get => this._hyperScaleStorageId; set => this._hyperScaleStorageId = value; }

        /// <summary>Backing field for <see cref="HypervisorId" /> property.</summary>
        private int? _hypervisorId;

        /// <summary>Id of the Hypervisor to update</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? HypervisorId { get => this._hypervisorId; set => this._hypervisorId = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="InstanceId" /> property.</summary>
        private int? _instanceId;

        /// <summary>Id of the instance to modify</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? InstanceId { get => this._instanceId; set => this._instanceId = value; }

        /// <summary>Backing field for <see cref="InventoryEntityName" /> property.</summary>
        private string _inventoryEntityName;

        /// <summary>
        /// Name of the inventory entity that needs to be browsed like ESX Host name in VCenter
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string InventoryEntityName { get => this._inventoryEntityName; set => this._inventoryEntityName = value; }

        /// <summary>Backing field for <see cref="KmsId" /> property.</summary>
        private int? _kmsId;

        /// <summary>Id of Key Management Server</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? KmsId { get => this._kmsId; set => this._kmsId = value; }

        /// <summary>Backing field for <see cref="MediaAgentId" /> property.</summary>
        private int? _mediaAgentId;

        /// <summary>Id of the Media Agent whose details have to be fetched</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? MediaAgentId { get => this._mediaAgentId; set => this._mediaAgentId = value; }

        /// <summary>Backing field for <see cref="MetadataCacheId" /> property.</summary>
        private int? _metadataCacheId;

        /// <summary>Id of metadata cache</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? MetadataCacheId { get => this._metadataCacheId; set => this._metadataCacheId = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="NodeId" /> property.</summary>
        private int? _nodeId;

        /// <summary>Id of node</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? NodeId { get => this._nodeId; set => this._nodeId = value; }

        /// <summary>Backing field for <see cref="PairId" /> property.</summary>
        private int? _pairId;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? PairId { get => this._pairId; set => this._pairId = value; }

        /// <summary>Backing field for <see cref="PlanId" /> property.</summary>
        private int? _planId;

        /// <summary>Id of the plan to fetch details</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? PlanId { get => this._planId; set => this._planId = value; }

        /// <summary>Backing field for <see cref="RecoveryTargetId" /> property.</summary>
        private int? _recoveryTargetId;

        /// <summary>id of recovery target</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? RecoveryTargetId { get => this._recoveryTargetId; set => this._recoveryTargetId = value; }

        /// <summary>Backing field for <see cref="RegionId" /> property.</summary>
        private int? _regionId;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? RegionId { get => this._regionId; set => this._regionId = value; }

        /// <summary>Backing field for <see cref="RegionList" /> property.</summary>
        private string _regionList;

        /// <summary>
        /// List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string RegionList { get => this._regionList; set => this._regionList = value; }

        /// <summary>Backing field for <see cref="ReplicationGroupId" /> property.</summary>
        private string _replicationGroupId;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ReplicationGroupId { get => this._replicationGroupId; set => this._replicationGroupId = value; }

        /// <summary>Backing field for <see cref="RequestId" /> property.</summary>
        private int? _requestId;

        /// <summary>Unique identifier for the request</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? RequestId { get => this._requestId; set => this._requestId = value; }

        /// <summary>Backing field for <see cref="RoleId" /> property.</summary>
        private int? _roleId;

        /// <summary>Role Id</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? RoleId { get => this._roleId; set => this._roleId = value; }

        /// <summary>Backing field for <see cref="RpsId" /> property.</summary>
        private string _rpsId;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string RpsId { get => this._rpsId; set => this._rpsId = value; }

        /// <summary>Backing field for <see cref="RuleId" /> property.</summary>
        private int? _ruleId;

        /// <summary>Id of the rule to update in Plan</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? RuleId { get => this._ruleId; set => this._ruleId = value; }

        /// <summary>Backing field for <see cref="ScheduleId" /> property.</summary>
        private string _scheduleId;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ScheduleId { get => this._scheduleId; set => this._scheduleId = value; }

        /// <summary>Backing field for <see cref="SchedulePolicyId" /> property.</summary>
        private string _schedulePolicyId;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SchedulePolicyId { get => this._schedulePolicyId; set => this._schedulePolicyId = value; }

        /// <summary>Backing field for <see cref="ServerGroupId" /> property.</summary>
        private int? _serverGroupId;

        /// <summary>Id of the serverGroupId whose details have to be fetched</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? ServerGroupId { get => this._serverGroupId; set => this._serverGroupId = value; }

        /// <summary>Backing field for <see cref="ServerId" /> property.</summary>
        private int? _serverId;

        /// <summary>Id of the server to modify</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? ServerId { get => this._serverId; set => this._serverId = value; }

        /// <summary>Backing field for <see cref="StoragePoolId" /> property.</summary>
        private int? _storagePoolId;

        /// <summary>Id of the disk storage pool whose details have to be fetched</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? StoragePoolId { get => this._storagePoolId; set => this._storagePoolId = value; }

        /// <summary>Backing field for <see cref="SubclientId" /> property.</summary>
        private int? _subclientId;

        /// <summary>Id of the subclient to modify</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? SubclientId { get => this._subclientId; set => this._subclientId = value; }

        /// <summary>Backing field for <see cref="TopologyId" /> property.</summary>
        private string _topologyId;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string TopologyId { get => this._topologyId; set => this._topologyId = value; }

        /// <summary>Backing field for <see cref="UserGroupId" /> property.</summary>
        private int? _userGroupId;

        /// <summary>Id of the user-group whose details have to be fetched</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? UserGroupId { get => this._userGroupId; set => this._userGroupId = value; }

        /// <summary>Backing field for <see cref="UserId" /> property.</summary>
        private int? _userId;

        /// <summary>Id of the User whose details have to be fetched</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? UserId { get => this._userId; set => this._userId = value; }

        /// <summary>Backing field for <see cref="VMGroupId" /> property.</summary>
        private int? _vMGroupId;

        /// <summary>Id of the VMgroup to update</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? VMGroupId { get => this._vMGroupId; set => this._vMGroupId = value; }

        /// <summary>Backing field for <see cref="VMUuid" /> property.</summary>
        private string _vMUuid;

        /// <summary>The vmUUID can be obtained from GET /virtualMachines UUID property</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string VMUuid { get => this._vMUuid; set => this._vMUuid = value; }

        /// <summary>Creates an new <see cref="CommvaultPowerShellIdentity" /> instance.</summary>
        public CommvaultPowerShellIdentity()
        {

        }
    }
    public partial interface ICommvaultPowerShellIdentity :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Id of the mount path whose access path has to be deleted</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the mount path whose access path has to be deleted",
        SerializedName = @"accessPathId",
        PossibleTypes = new [] { typeof(int) })]
        int? AccessPathId { get; set; }
        /// <summary>Id of the agent to be modified</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the agent to be modified",
        SerializedName = @"agentId",
        PossibleTypes = new [] { typeof(int) })]
        int? AgentId { get; set; }
        /// <summary>Id of the backupDestination to be modified</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the backupDestination to be modified",
        SerializedName = @"BackupDestinationId",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupDestinationId { get; set; }
        /// <summary>Id of the backup location whose details have to be fetched</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the backup location whose details have to be fetched",
        SerializedName = @"backupLocationId",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupLocationId { get; set; }
        /// <summary>Id of the Blackout Window whose details have to be fetched</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the Blackout Window whose details have to be fetched",
        SerializedName = @"blackoutWindowId",
        PossibleTypes = new [] { typeof(int) })]
        int? BlackoutWindowId { get; set; }
        /// <summary>Id of Bucket</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of Bucket",
        SerializedName = @"bucketId",
        PossibleTypes = new [] { typeof(int) })]
        int? BucketId { get; set; }
        /// <summary>Id of cloud Storage</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of cloud Storage",
        SerializedName = @"cloudStorageId",
        PossibleTypes = new [] { typeof(int) })]
        int? CloudStorageId { get; set; }
        /// <summary>Id of the Company whose details have to be fetched</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the Company whose details have to be fetched",
        SerializedName = @"companyId",
        PossibleTypes = new [] { typeof(int) })]
        int? CompanyId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"credentialName",
        PossibleTypes = new [] { typeof(string) })]
        string CredentialName { get; set; }
        /// <summary>ID of the AD/LDAP domain</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ID of the AD/LDAP domain",
        SerializedName = @"domainId",
        PossibleTypes = new [] { typeof(int) })]
        int? DomainId { get; set; }
        /// <summary>Unique id for the entity</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unique id for the entity",
        SerializedName = @"entityId",
        PossibleTypes = new [] { typeof(int) })]
        int? EntityId { get; set; }
        /// <summary>Type of the entity</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the entity",
        SerializedName = @"entityType",
        PossibleTypes = new [] { typeof(int) })]
        int? EntityType { get; set; }
        /// <summary>name of global search entity</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"name of global search entity",
        SerializedName = @"globalSearchEntity",
        PossibleTypes = new [] { typeof(string) })]
        string GlobalSearchEntity { get; set; }
        /// <summary>Id of the HFS Share to fetch its status</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the HFS Share to fetch its status",
        SerializedName = @"HFSShareId",
        PossibleTypes = new [] { typeof(int) })]
        int? HfsShareId { get; set; }
        /// <summary>Id of hyperscale storage</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of hyperscale storage",
        SerializedName = @"hyperScaleStorageId",
        PossibleTypes = new [] { typeof(int) })]
        int? HyperScaleStorageId { get; set; }
        /// <summary>Id of the Hypervisor to update</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the Hypervisor to update",
        SerializedName = @"hypervisorId",
        PossibleTypes = new [] { typeof(int) })]
        int? HypervisorId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }
        /// <summary>Id of the instance to modify</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the instance to modify",
        SerializedName = @"instanceId",
        PossibleTypes = new [] { typeof(int) })]
        int? InstanceId { get; set; }
        /// <summary>
        /// Name of the inventory entity that needs to be browsed like ESX Host name in VCenter
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the inventory entity that needs to be browsed like ESX Host name in VCenter",
        SerializedName = @"InventoryEntityName",
        PossibleTypes = new [] { typeof(string) })]
        string InventoryEntityName { get; set; }
        /// <summary>Id of Key Management Server</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of Key Management Server",
        SerializedName = @"kmsId",
        PossibleTypes = new [] { typeof(int) })]
        int? KmsId { get; set; }
        /// <summary>Id of the Media Agent whose details have to be fetched</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the Media Agent whose details have to be fetched",
        SerializedName = @"mediaAgentId",
        PossibleTypes = new [] { typeof(int) })]
        int? MediaAgentId { get; set; }
        /// <summary>Id of metadata cache</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of metadata cache",
        SerializedName = @"metadataCacheId",
        PossibleTypes = new [] { typeof(int) })]
        int? MetadataCacheId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Id of node</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of node",
        SerializedName = @"nodeId",
        PossibleTypes = new [] { typeof(int) })]
        int? NodeId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"pairId",
        PossibleTypes = new [] { typeof(int) })]
        int? PairId { get; set; }
        /// <summary>Id of the plan to fetch details</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the plan to fetch details",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(int) })]
        int? PlanId { get; set; }
        /// <summary>id of recovery target</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"id of recovery target",
        SerializedName = @"recoveryTargetId",
        PossibleTypes = new [] { typeof(int) })]
        int? RecoveryTargetId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"regionId",
        PossibleTypes = new [] { typeof(int) })]
        int? RegionId { get; set; }
        /// <summary>
        /// List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true",
        SerializedName = @"regionList",
        PossibleTypes = new [] { typeof(string) })]
        string RegionList { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"replicationGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicationGroupId { get; set; }
        /// <summary>Unique identifier for the request</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unique identifier for the request",
        SerializedName = @"requestId",
        PossibleTypes = new [] { typeof(int) })]
        int? RequestId { get; set; }
        /// <summary>Role Id</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Role Id",
        SerializedName = @"roleId",
        PossibleTypes = new [] { typeof(int) })]
        int? RoleId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"rpsId",
        PossibleTypes = new [] { typeof(string) })]
        string RpsId { get; set; }
        /// <summary>Id of the rule to update in Plan</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the rule to update in Plan",
        SerializedName = @"ruleId",
        PossibleTypes = new [] { typeof(int) })]
        int? RuleId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"scheduleId",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduleId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"schedulePolicyId",
        PossibleTypes = new [] { typeof(string) })]
        string SchedulePolicyId { get; set; }
        /// <summary>Id of the serverGroupId whose details have to be fetched</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the serverGroupId whose details have to be fetched",
        SerializedName = @"serverGroupId",
        PossibleTypes = new [] { typeof(int) })]
        int? ServerGroupId { get; set; }
        /// <summary>Id of the server to modify</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the server to modify",
        SerializedName = @"serverId",
        PossibleTypes = new [] { typeof(int) })]
        int? ServerId { get; set; }
        /// <summary>Id of the disk storage pool whose details have to be fetched</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the disk storage pool whose details have to be fetched",
        SerializedName = @"storagePoolId",
        PossibleTypes = new [] { typeof(int) })]
        int? StoragePoolId { get; set; }
        /// <summary>Id of the subclient to modify</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the subclient to modify",
        SerializedName = @"subclientId",
        PossibleTypes = new [] { typeof(int) })]
        int? SubclientId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"topologyId",
        PossibleTypes = new [] { typeof(string) })]
        string TopologyId { get; set; }
        /// <summary>Id of the user-group whose details have to be fetched</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the user-group whose details have to be fetched",
        SerializedName = @"userGroupId",
        PossibleTypes = new [] { typeof(int) })]
        int? UserGroupId { get; set; }
        /// <summary>Id of the User whose details have to be fetched</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the User whose details have to be fetched",
        SerializedName = @"userId",
        PossibleTypes = new [] { typeof(int) })]
        int? UserId { get; set; }
        /// <summary>Id of the VMgroup to update</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the VMgroup to update",
        SerializedName = @"VmGroupId",
        PossibleTypes = new [] { typeof(int) })]
        int? VMGroupId { get; set; }
        /// <summary>The vmUUID can be obtained from GET /virtualMachines UUID property</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The vmUUID can be obtained from GET /virtualMachines UUID property",
        SerializedName = @"vmUUID",
        PossibleTypes = new [] { typeof(string) })]
        string VMUuid { get; set; }

    }
    internal partial interface ICommvaultPowerShellIdentityInternal

    {
        /// <summary>Id of the mount path whose access path has to be deleted</summary>
        int? AccessPathId { get; set; }
        /// <summary>Id of the agent to be modified</summary>
        int? AgentId { get; set; }
        /// <summary>Id of the backupDestination to be modified</summary>
        int? BackupDestinationId { get; set; }
        /// <summary>Id of the backup location whose details have to be fetched</summary>
        int? BackupLocationId { get; set; }
        /// <summary>Id of the Blackout Window whose details have to be fetched</summary>
        int? BlackoutWindowId { get; set; }
        /// <summary>Id of Bucket</summary>
        int? BucketId { get; set; }
        /// <summary>Id of cloud Storage</summary>
        int? CloudStorageId { get; set; }
        /// <summary>Id of the Company whose details have to be fetched</summary>
        int? CompanyId { get; set; }

        string CredentialName { get; set; }
        /// <summary>ID of the AD/LDAP domain</summary>
        int? DomainId { get; set; }
        /// <summary>Unique id for the entity</summary>
        int? EntityId { get; set; }
        /// <summary>Type of the entity</summary>
        int? EntityType { get; set; }
        /// <summary>name of global search entity</summary>
        string GlobalSearchEntity { get; set; }
        /// <summary>Id of the HFS Share to fetch its status</summary>
        int? HfsShareId { get; set; }
        /// <summary>Id of hyperscale storage</summary>
        int? HyperScaleStorageId { get; set; }
        /// <summary>Id of the Hypervisor to update</summary>
        int? HypervisorId { get; set; }

        int? Id { get; set; }
        /// <summary>Id of the instance to modify</summary>
        int? InstanceId { get; set; }
        /// <summary>
        /// Name of the inventory entity that needs to be browsed like ESX Host name in VCenter
        /// </summary>
        string InventoryEntityName { get; set; }
        /// <summary>Id of Key Management Server</summary>
        int? KmsId { get; set; }
        /// <summary>Id of the Media Agent whose details have to be fetched</summary>
        int? MediaAgentId { get; set; }
        /// <summary>Id of metadata cache</summary>
        int? MetadataCacheId { get; set; }

        string Name { get; set; }
        /// <summary>Id of node</summary>
        int? NodeId { get; set; }

        int? PairId { get; set; }
        /// <summary>Id of the plan to fetch details</summary>
        int? PlanId { get; set; }
        /// <summary>id of recovery target</summary>
        int? RecoveryTargetId { get; set; }

        int? RegionId { get; set; }
        /// <summary>
        /// List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
        /// </summary>
        string RegionList { get; set; }

        string ReplicationGroupId { get; set; }
        /// <summary>Unique identifier for the request</summary>
        int? RequestId { get; set; }
        /// <summary>Role Id</summary>
        int? RoleId { get; set; }

        string RpsId { get; set; }
        /// <summary>Id of the rule to update in Plan</summary>
        int? RuleId { get; set; }

        string ScheduleId { get; set; }

        string SchedulePolicyId { get; set; }
        /// <summary>Id of the serverGroupId whose details have to be fetched</summary>
        int? ServerGroupId { get; set; }
        /// <summary>Id of the server to modify</summary>
        int? ServerId { get; set; }
        /// <summary>Id of the disk storage pool whose details have to be fetched</summary>
        int? StoragePoolId { get; set; }
        /// <summary>Id of the subclient to modify</summary>
        int? SubclientId { get; set; }

        string TopologyId { get; set; }
        /// <summary>Id of the user-group whose details have to be fetched</summary>
        int? UserGroupId { get; set; }
        /// <summary>Id of the User whose details have to be fetched</summary>
        int? UserId { get; set; }
        /// <summary>Id of the VMgroup to update</summary>
        int? VMGroupId { get; set; }
        /// <summary>The vmUUID can be obtained from GET /virtualMachines UUID property</summary>
        string VMUuid { get; set; }

    }
}