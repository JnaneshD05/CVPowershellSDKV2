
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
API to modify RPO schedules on server plan
.Description
API to modify RPO schedules on server plan
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
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BACKUPFREQUENCYSCHEDULES <IPlanSchedule[]>: .
  BackupType <String>: Schedule Backup level
  ForDatabasesOnly <Boolean>: Boolean to indicate if schedule is for database agents
  ScheduleOperation <String>: Operation being performed on schedule
  SchedulePatternScheduleFrequencyType <String>: schedule frequency type
  [PolicyId <Int32?>]: Schedule policy Id to which the schedule belongs
  [ScheduleId <Int32?>]: Id of the schedule if available, required for modifying, deleting schedule
  [ScheduleName <String>]: Name of the schedule, for modify
  [SchedulePatternDayOfMonth <Int32?>]: Day on which to run the schedule, applicable for monthly, yearly
  [SchedulePatternDayOfWeek <String>]: 
  [SchedulePatternDaysBetweenSyntheticFulls <Int32?>]: No of days between two synthetic full jobs
  [SchedulePatternEndDate <Int32?>]: Schedule end date in epoch format
  [SchedulePatternExceptions <IScheduleRunException[]>]: Exceptions to when a schedule should not run, either in dates or week of month and days
    [OnDates <Int32[]>]: list of dates in a month. For ex: 1, 20
    [OnDayOfTheWeek <String[]>]: On which days, for ex: MONDAY, FRIDAY
    [OnWeekOfTheMonth <String[]>]: On which week of month, for ex: FIRST, LAST
  [SchedulePatternFrequency <Int32?>]: Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
  [SchedulePatternMonthOfYear <String>]: 
  [SchedulePatternNoOfTimes <Int32?>]: The number of times you want the schedule to run.
  [SchedulePatternRepeatIntervalInMinutes <Int32?>]: How often in minutes in a day the schedule runs, applicable for daily, weekly, monthly and yearly frequency types.
  [SchedulePatternRepeatUntilTime <Int32?>]: Until what time to repeat the schedule in a day, requires repeatIntervalInMinutes
  [SchedulePatternStartDate <Int32?>]: start date of schedule in epoch format
  [SchedulePatternStartTime <Int32?>]: start time of schedule in seconds
  [SchedulePatternWeekOfMonth <String>]: Specific week of a month
  [SchedulePatternWeeklyDays <String[]>]: Days of the week for weekly frequency
  [TimezoneId <Int32?>]: 
  [TimezoneName <String>]: 

BACKUPWINDOW <IDayAndTime[]>: Backup window for incremental backup
  [DayOfWeek <String[]>]: 
  [EndTime <Int64?>]: Time in seconds since the beginning of the day
  [StartTime <Int64?>]: Time in seconds since the beginning of the day

FULLBACKUPWINDOW <IDayAndTime[]>: Backup window for full backup
  [DayOfWeek <String[]>]: 
  [EndTime <Int64?>]: Time in seconds since the beginning of the day
  [StartTime <Int64?>]: Time in seconds since the beginning of the day

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
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/set-serverplanrpo
#>
function Set-ServerPlanRpo {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Path')]
    [System.Int32]
    # Id of the Server Plan
    ${PlanId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Path')]
    [Commvault.Powershell.Models.ICommvaultPowerShellIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IPlanSchedule[]]
    # .
    # To construct, see NOTES section for BACKUPFREQUENCYSCHEDULES properties and create a hash table.
    ${BackupFrequencySchedules},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IDayAndTime[]]
    # Backup window for incremental backup
    # To construct, see NOTES section for BACKUPWINDOW properties and create a hash table.
    ${BackupWindow},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IDayAndTime[]]
    # Backup window for full backup
    # To construct, see NOTES section for FULLBACKUPWINDOW properties and create a hash table.
    ${FullBackupWindow},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # Time provided in Unix format.
    # Give 0 to reset any existing delay.
    ${SlaEnableAfterDelay},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to set to exclude plan from SLA
    ${SlaExcludeFromSla},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Reason for exclusion from SLA
    ${SlaExclusionReason},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # SLA Period in Days
    ${SlaPeriod},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Flag to set to use System Default Service Level Agreement
    ${SlaUseSystemDefaultSla},

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
            UpdateExpanded = 'CommvaultPowerShell.private\Set-ServerPlanRpo_UpdateExpanded';
            UpdateViaIdentityExpanded = 'CommvaultPowerShell.private\Set-ServerPlanRpo_UpdateViaIdentityExpanded';
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
