
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
Delete multiple userGroups
.Description
Delete multiple userGroups
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.IDeleteMultipleUserGroups
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IDeleteMultipleUserGroups>: .
  [UserGroups <IDeleteUserGroups[]>]: List of userGroups that have to be deleted. Either name or id can be provided. If name and id are both provided, id will be taken into consideration.
    [NewUserGroupId <Int32?>]: 
    [NewUserGroupName <String>]: 
    [NewUserId <Int32?>]: 
    [NewUserName <String>]: 
    [SkipOwnerTransfer <Boolean?>]: 
    [UserGroupId <Int32?>]: 
    [UserGroupName <String>]: 

USERGROUPS <IDeleteUserGroups[]>: List of userGroups that have to be deleted. Either name or id can be provided. If name and id are both provided, id will be taken into consideration.
  [NewUserGroupId <Int32?>]: 
  [NewUserGroupName <String>]: 
  [NewUserId <Int32?>]: 
  [NewUserName <String>]: 
  [SkipOwnerTransfer <Boolean?>]: 
  [UserGroupId <Int32?>]: 
  [UserGroupName <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/remove-multipleusergroup
#>
function Remove-MultipleUserGroup {
[OutputType([Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='DeleteExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IDeleteMultipleUserGroups]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='DeleteExpanded')]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IDeleteUserGroups[]]
    # List of userGroups that have to be deleted.
    # Either name or id can be provided.
    # If name and id are both provided, id will be taken into consideration.
    # To construct, see NOTES section for USERGROUPS properties and create a hash table.
    ${UserGroups},

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
            Delete = 'CommvaultPowerShell.private\Remove-MultipleUserGroup_Delete';
            DeleteExpanded = 'CommvaultPowerShell.private\Remove-MultipleUserGroup_DeleteExpanded';
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
