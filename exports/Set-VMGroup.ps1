
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Updates the VM Group
.Description
Updates the VM Group
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ICommvaultPowerShellIdentity
.Outputs
Commvault.Powershell.Models.IGenericResp
.Outputs
Commvault.Powershell.Models.IGetVMGroupResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ACCESSNODE <IIdName[]>: .
  [Id <Int32?>]: 
  [Name <String>]: 

APPLICATIONVALIDATION <IVMAppValidation>: vmAppValidation
  [CopyId <Int32?>]: 
  [CopyName <String>]: 
  [CredentialsName <String>]: username to access the network path
  [CredentialsPassword <String>]: password to access the network path
  [KeepValidatedVMSRunning <Boolean?>]: If true then validated VMs will be available until expiration time set on the recovery target
  [MaximumNoOfThreads <Int32?>]: Number of backup Validation Threads
  [RecoveryTarget <String>]: Recovery Target for Application Validation
  [SavedCredentialsId <Int32?>]: 
  [SavedCredentialsName <String>]: 
  [ScheduleDescription <String>]: Description for validation schedule
  [ScheduleId <Int32?>]: 
  [ScheduleIsScheduleEnabled <Boolean?>]: True if application validation schedule is enabled
  [ScheduleTaskId <Int32?>]: Job Id for the application validation task. 0 if schedule is disabled
  [UnixArguments <String>]: Arguments for the script
  [UnixIsDisabled <Boolean?>]: Is the script disabled
  [UnixIsUnc <Boolean?>]: True if the script is a UNC script, False if it is a local script
  [UnixPath <String>]: Path for the validation script
  [UnixUncCredentialsName <String>]: username to access the network path
  [UnixUncCredentialsPassword <String>]: password to access the network path
  [UnixUncSavedCredentialsId <Int32?>]: 
  [UnixUncSavedCredentialsName <String>]: 
  [UseSourceVMEsxToMount <Boolean?>]: Use Source VM ESX To Mount
  [ValidateVMBackups <Boolean?>]: True if VM Backup validation is enabled
  [WindowArguments <String>]: Arguments for the script
  [WindowIsDisabled <Boolean?>]: Is the script disabled
  [WindowIsUnc <Boolean?>]: True if the script is a UNC script, False if it is a local script
  [WindowPath <String>]: Path for the validation script
  [WindowsUncCredentialsName <String>]: username to access the network path
  [WindowsUncCredentialsPassword <String>]: password to access the network path
  [WindowsUncSavedCredentialsId <Int32?>]: 
  [WindowsUncSavedCredentialsName <String>]: 

CONTENTRULEGROUPS <IRuleGroupContent[]>: .
  [MatchRule <String>]: Enum which specifies the whether to match all rules or any of the rules
  [Rules <IRuleContent[]>]: 
    [Condition <String>]: Operation type for VM rules/filters
    [DisplayName <String>]: The display name of the entity to be added
    [Guid <String>]: GUID of the entity to be added as content
    [Name <String>]: name of the VM to be added as content
    [Type <String>]: 
    [Value <String>]: value for the few type of VM Content like powerstate

CONTENTVIRTUALMACHINES <IVirtualMachinecontent[]>: .
  [Guid <String>]: GUID of the VM to be added as content
  [Name <String>]: name of the VM to be added as content
  [Type <String>]: 

DISKFILTERS <IVMDiskFilter[]>: .
  [Condition <String>]: Operation type for VM rules/filters
  [FilterType <String>]: 
  [Name <String>]: The string to be filtered
  [VMGuid <String>]: VM Guid of the Virtual Machine whose disk has to be filtered . This is optional. if not given, all disks of name and type from all Vms added in content will be filtered

FILTERRULEGROUPS <IRuleGroupContent[]>: .
  [MatchRule <String>]: Enum which specifies the whether to match all rules or any of the rules
  [Rules <IRuleContent[]>]: 
    [Condition <String>]: Operation type for VM rules/filters
    [DisplayName <String>]: The display name of the entity to be added
    [Guid <String>]: GUID of the entity to be added as content
    [Name <String>]: name of the VM to be added as content
    [Type <String>]: 
    [Value <String>]: value for the few type of VM Content like powerstate

FILTERVIRTUALMACHINES <IVirtualMachinecontent[]>: .
  [Guid <String>]: GUID of the VM to be added as content
  [Name <String>]: name of the VM to be added as content
  [Type <String>]: 

INPUTOBJECT <ICommvaultPowerShellIdentity>: Identity Parameter
  [AccessPathId <Int32?>]: Id of the mount path whose access path has to be deleted
  [AgentId <Int32?>]: Id of the agent to be modified
  [BackupDestinationId <Int32?>]: Id of the backupDestination to be modified
  [BackupLocationId <Int32?>]: Id of the backup location whose details have to be fetched
  [BlackoutWindowId <Int32?>]: Id of the Blackout Window whose details have to be fetched
  [BucketId <Int32?>]: Id of Bucket
  [CloudStorageId <Int32?>]: Id of cloud Storage
  [CompanyId <Int32?>]: Id of the Company whose details have to be fetched
  [CredentialName <String>]: 
  [DomainId <Int32?>]: ID of the AD/LDAP domain
  [EntityId <Int32?>]: Unique id for the entity
  [EntityType <Int32?>]: Type of the entity
  [GlobalSearchEntity <String>]: name of global search entity
  [HfsShareId <Int32?>]: Id of the HFS Share to fetch its status
  [HyperScaleStorageId <Int32?>]: Id of hyperscale storage
  [HypervisorId <Int32?>]: Id of the Hypervisor to update
  [Id <Int32?>]: 
  [InstanceId <Int32?>]: Id of the instance to modify
  [InventoryEntityName <String>]: Name of the inventory entity that needs to be browsed like ESX Host name in VCenter
  [KmsId <Int32?>]: Id of Key Management Server
  [MediaAgentId <Int32?>]: Id of the Media Agent whose details have to be fetched
  [MetadataCacheId <Int32?>]: Id of metadata cache
  [Name <String>]: 
  [NodeId <Int32?>]: Id of node
  [PairId <Int32?>]: 
  [PlanId <Int32?>]: Id of the plan to fetch details
  [RecoveryTargetId <Int32?>]: id of recovery target
  [RegionId <Int32?>]: 
  [RegionList <String>]: List of region names/ids to be deleted. If region ids are passed, set isRegionIdList=true
  [ReplicationGroupId <String>]: 
  [RequestId <Int32?>]: Unique identifier for the request
  [RoleId <Int32?>]: Role Id
  [RpsId <String>]: 
  [RuleId <Int32?>]: Id of the rule to update in Plan
  [ScheduleId <String>]: 
  [SchedulePolicyId <String>]: 
  [ServerGroupId <Int32?>]: Id of the serverGroupId whose details have to be fetched
  [ServerId <Int32?>]: Id of the server to modify
  [StoragePoolId <Int32?>]: Id of the disk storage pool whose details have to be fetched
  [SubclientId <Int32?>]: Id of the subclient to modify
  [TopologyId <String>]: 
  [UserGroupId <Int32?>]: Id of the user-group whose details have to be fetched
  [UserId <Int32?>]: Id of the User whose details have to be fetched
  [VMGroupId <Int32?>]: Id of the VMgroup to update
  [VMUuid <String>]: The vmUUID can be obtained from GET /virtualMachines UUID property

SECURITYASSOCIATIONS <ISecurityAssoc[]>: .
  [ExternalUserGroupId <Int32?>]: User Group Id
  [ExternalUserGroupName <String>]: External Group Name
  [ExternalUserGroupProviderId <Int32?>]: Provider id
  [ExternalUserGroupProviderName <String>]: Provider Name
  [IsCreatorAssociation <Boolean?>]: 
  [PermissionList <IPermissionResp[]>]: 
    [CategoryId <Int32?>]: 
    [CategoryName <String>]: 
    [PermissionId <Int32?>]: 
    [PermissionName <String>]: 
    [Type <String>]: Returns the type of association.
  [RoleId <Int32?>]: 
  [RoleName <String>]: 
  [UserGroupId <Int32?>]: 
  [UserGroupName <String>]: 
  [UserId <Int32?>]: 
  [UserName <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-vmgroup
#>
function Set-VMGroup {
[OutputType([Commvault.Powershell.Models.IGetVMGroupResp], [Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int32]
    # Id of the VMgroup to update
    ${VMGroupId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Path')]
    [Commvault.Powershell.Models.ICommvaultPowerShellIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # .
    # To construct, see NOTES section for ACCESSNODE properties and create a hash table.
    ${AccessNode},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # true if Backup is enabled
    ${ActivityControlEnableBackup},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # true if Restore is enabled
    ${ActivityControlEnableRestore},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IVMAppValidation]
    # vmAppValidation
    # To construct, see NOTES section for APPLICATIONVALIDATION properties and create a hash table.
    ${ApplicationValidation},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Delayed by n Hrs
    ${BackupActivityControlOptionDelayTime},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if the activity will be enabled after a delay time interval
    ${BackupActivityControlOptionEnableAfterDelay},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${BackupActivityControlOptionsTimeZoneId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${BackupActivityControlOptionsTimeZoneName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if content in vmgroup has to be overwritten, by default it will append the content
    ${ContentOverwrite},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IRuleGroupContent[]]
    # .
    # To construct, see NOTES section for CONTENTRULEGROUPS properties and create a hash table.
    ${ContentRuleGroups},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IVirtualMachinecontent[]]
    # .
    # To construct, see NOTES section for CONTENTVIRTUALMACHINES properties and create a hash table.
    ${ContentVirtualMachines},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # username to access the network path
    ${CredentialsName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # password to access the network path
    ${CredentialsPassword},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${CrossAccountCopyDestinationClientId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${CrossAccountCopyDestinationClientName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IVMDiskFilter[]]
    # .
    # To construct, see NOTES section for DISKFILTERS properties and create a hash table.
    ${DiskFilters},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if file indexing needs to be enabled
    ${EnableFileIndexing},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if content in vmgroup has to be overwritten, by default it will append the content
    ${FilterOverwrite},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IRuleGroupContent[]]
    # .
    # To construct, see NOTES section for FILTERRULEGROUPS properties and create a hash table.
    ${FilterRuleGroups},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IVirtualMachinecontent[]]
    # .
    # To construct, see NOTES section for FILTERVIRTUALMACHINES properties and create a hash table.
    ${FilterVirtualMachines},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # subclient name
    ${NewName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${PlanId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${PlanName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Delayed by n Hrs
    ${RestoreActivityControlOptionDelayTime},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if the activity will be enabled after a delay time interval
    ${RestoreActivityControlOptionEnableAfterDelay},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${RestoreActivityControlOptionsTimeZoneId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${RestoreActivityControlOptionsTimeZoneName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${SavedCredentialsId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${SavedCredentialsName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ISecurityAssoc[]]
    # .
    # To construct, see NOTES section for SECURITYASSOCIATIONS properties and create a hash table.
    ${SecurityAssociations},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if auto detect VM Owner enabled
    ${SettingAutoDetectVMOwner},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if metadata collection is enabled for intellisnap jobs.
    # Only applicable for Indexing v1
    ${SettingCollectFileDetailsFromSnapshotCopy},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if metadata collection is enabled.
    # Only applicable for Indexing v1
    ${SettingCollectFileDetailsforGranularRecovery},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Custom snapshot resource group GUID for Azure
    ${SettingCustomSnapshotResourceGroup},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if Datastore Free space check is enabled
    ${SettingDatastoreFreespaceCheck},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # precentage of datastore free space check value
    ${SettingDatastoreFreespaceRequired},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Is the VM App Aware
    ${SettingIsApplicationAware},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Start Time for the VM Group Job
    ${SettingJobStartTime},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Number of readers for backup
    ${SettingNoOfReaders},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # transport mode based on environment.
    # Values are case sensitive
    ${SettingTransportMode},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if Changed Block Tracking is enabled
    ${SettingUseChangedBlockTrackingOnVM},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if use VM CheckPoint setting is enabled
    ${SettingUseVMCheckpointSetting},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${SettingVMBackupType},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${SnapEngineId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${SnapEngineName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${SnapMountProxyId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${SnapMountProxyName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${SnapshotManagementBackupCopyInterface},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if hardware snapshot is enabled
    ${SnapshotManagementEnableHardwareSnapshot},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if full copy of amazon snapshot to different amazon account is enabled
    ${SnapshotManagementIsCrossAccountCopyEnabled},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if replicate and copy or sharing of amazon snapshot to different amazon account in same or different geographic location is enabled
    ${SnapshotManagementIsCrossAccountEnabled},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if independent disk option is enabled
    ${SnapshotManagementIsIndependentDisksEnabled},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if raw device maps option is enabled
    ${SnapshotManagementIsRawDeviceMapsEnabled},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Name of ESX Host
    ${SnapshotManagementSnapMountEsxHost},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # True if separate proxy client is used for snap to tape
    ${SnapshotManagementUseSeparateProxyForSnapToTape},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Virtual machine application user name
    ${SnapshotManagementVMApplicationUserName},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${StorageId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${StorageName},

    [Parameter(DontShow)]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Commvault.Powershell.Category('Runtime')]
    [Commvault.Powershell.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Commvault.Powershell.Category('Runtime')]
    [Commvault.Powershell.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Commvault.Powershell.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            UpdateExpanded = 'CommvaultPowerShell.private\Set-VMGroup_UpdateExpanded';
            UpdateViaIdentityExpanded = 'CommvaultPowerShell.private\Set-VMGroup_UpdateViaIdentityExpanded';
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
