
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
Api to create plan rules.
Request body will suggest plan against which rule need to be created and type of entities(workloads type, server groups, regions and all) that need to be referenced for applying that rule against a workload.
.Description
Api to create plan rules.
Request body will suggest plan against which rule need to be created and type of entities(workloads type, server groups, regions and all) that need to be referenced for applying that rule against a workload.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Commvault.Powershell.Models.IGenericResp
.Outputs
Commvault.Powershell.Models.IIdName
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

REGIONS <IIdName[]>: This will include list of regions that should be evaluated against workload region for plan association.
  [Id <Int32?>]: 
  [Name <String>]: 

SERVERGROUPS <IIdName[]>: This will include list of Server groups that should be evaluated against workload server group for plan association.
  [Id <Int32?>]: 
  [Name <String>]: 

SOLUTIONS <IIdName[]>: This will include list of solutions that should be evaluated against workload for plan association
  [Id <Int32?>]: 
  [Name <String>]: 

TAGS <IPlanEntityRuleTag[]>: This will include list of tags that should be evaluated against workload for plan association
  [Id <Int32?>]: Id for the tag
  [Name <String>]: Name for the plan rule tag which need to be matched against tag of the workload.
  [Value <String>]: Possible value that need to matched against value of tag associated to workload.

WORKLOADS <IIdName[]>: This will include list of apptypes that should be evaluated against workload apptype for plan association.
  [Id <Int32?>]: 
  [Name <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-planrule
#>
function New-PlanRule {
[OutputType([Commvault.Powershell.Models.IIdName], [Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${CompanyId},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${CompanyName},

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
    [System.Int32]
    # Optional field to suggest priority/rank of the rule.
    # If not present, we will process rule in the same order they are created.
    ${Rank},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # This will include list of regions that should be evaluated against workload region for plan association.
    # To construct, see NOTES section for REGIONS properties and create a hash table.
    ${Regions},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # This will include list of Server groups that should be evaluated against workload server group for plan association.
    # To construct, see NOTES section for SERVERGROUPS properties and create a hash table.
    ${ServerGroups},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # This will include list of solutions that should be evaluated against workload for plan association
    # To construct, see NOTES section for SOLUTIONS properties and create a hash table.
    ${Solutions},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IPlanEntityRuleTag[]]
    # This will include list of tags that should be evaluated against workload for plan association
    # To construct, see NOTES section for TAGS properties and create a hash table.
    ${Tags},

    [Parameter()]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # This will include list of apptypes that should be evaluated against workload apptype for plan association.
    # To construct, see NOTES section for WORKLOADS properties and create a hash table.
    ${Workloads},

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
            CreateExpanded = 'CommvaultPowerShell.private\New-PlanRule_CreateExpanded';
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
