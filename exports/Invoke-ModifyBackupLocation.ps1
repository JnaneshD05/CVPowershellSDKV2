
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
Modify the properties of an existing mount path
.Description
Modify the properties of an existing mount path
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ICommvaultPowerShellIdentity
.Inputs
Commvault.Powershell.Models.IUpdateBackupLocation
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IUpdateBackupLocation>: While adding network access path, please add credentials or saved credentials. If both are provided, credentials will be selected.
  [Access <String>]: The access type for the disk access path can be either read (writing to path not allowed) or read and write (writing to path allowed).
  [CredentialsName <String>]: username to access the network path
  [CredentialsPassword <String>]: password to access the network path
  [Enabled <Boolean?>]: 
  [MediaAgentId <Int32?>]: 
  [MediaAgentName <String>]: 
  [Path <String>]: Can be used to change the disk access path.
  [SavedCredentialsId <Int32?>]: 
  [SavedCredentialsName <String>]: 

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
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/invoke-modifybackuplocation
#>
function Invoke-ModifyBackupLocation {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='ModifyExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Modify', Mandatory)]
    [Parameter(ParameterSetName='ModifyExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int32]
    # Id of the backup location to update
    ${BackupLocationId},

    [Parameter(ParameterSetName='Modify', Mandatory)]
    [Parameter(ParameterSetName='ModifyExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int32]
    # Id of the disk storage to update
    ${StoragePoolId},

    [Parameter(ParameterSetName='ModifyViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Path')]
    [Commvault.Powershell.Models.ICommvaultPowerShellIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Modify', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ModifyViaIdentity', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IUpdateBackupLocation]
    # While adding network access path, please add credentials or saved credentials.
    # If both are provided, credentials will be selected.
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The access type for the disk access path can be either read (writing to path not allowed) or read and write (writing to path allowed).
    ${Access},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # username to access the network path
    ${CredentialsName},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # password to access the network path
    ${CredentialsPassword},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Enabled},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${MediaAgentId},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${MediaAgentName},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Can be used to change the disk access path.
    ${Path},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${SavedCredentialsId},

    [Parameter(ParameterSetName='ModifyExpanded')]
    [Parameter(ParameterSetName='ModifyViaIdentityExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${SavedCredentialsName},

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

    [Parameter()]
    [Commvault.Powershell.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

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
            Modify = 'CommvaultPowerShell.private\Invoke-ModifyBackupLocation_Modify';
            ModifyExpanded = 'CommvaultPowerShell.private\Invoke-ModifyBackupLocation_ModifyExpanded';
            ModifyViaIdentity = 'CommvaultPowerShell.private\Invoke-ModifyBackupLocation_ModifyViaIdentity';
            ModifyViaIdentityExpanded = 'CommvaultPowerShell.private\Invoke-ModifyBackupLocation_ModifyViaIdentityExpanded';
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
