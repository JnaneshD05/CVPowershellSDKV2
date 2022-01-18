
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
Create Kubernetes cluster
.Description
Create Kubernetes cluster
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Commvault.Powershell.Models.ICreateKubernetesCluster
.Outputs
Commvault.Powershell.Models.ICreateClusterResp
.Outputs
Commvault.Powershell.Models.IGenericResp
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ACCESSNODES <IIdName[]>: .
  [Id <Int32?>]: 
  [Name <String>]: 

BODY <ICreateKubernetesCluster>: .
  AccessNodes <IIdName[]>: 
    [Id <Int32?>]: 
    [Name <String>]: 
  Name <String>: The name of the hypervisor group being created
  Endpointurl <String>: Endpoint url to connect
  [CredentialsId <Int32?>]: 
  [CredentialsName <String>]: 
  [SkipCredentialValidation <Boolean?>]: if credential validation has to be skipped.
  [Password <String>]: Username to connect in case authentication mode is Username and password
  [SecretKey <String>]: SecretKey to connect in case authentication mode is service account
  [ServiceName <String>]: Service Name to connect in case authentication mode is service account
  [UserName <String>]: Username to connect in case authentication mode is Username and password
.Link
https://docs.microsoft.com/en-us/powershell/module/commvaultpowershell/new-kubernetescluster
#>
function New-Kubernetescluster {
[OutputType([Commvault.Powershell.Models.ICreateClusterResp], [Commvault.Powershell.Models.IGenericResp])]
[CmdletBinding(DefaultParameterSetName='Create', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.ICreateKubernetesCluster]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [Commvault.Powershell.Models.IIdName[]]
    # .
    # To construct, see NOTES section for ACCESSNODES properties and create a hash table.
    ${AccessNodes},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # .
    ${CredentialsName},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Endpoint url to connect
    ${Endpointurl},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # The name of the hypervisor group being created
    ${Name},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Int32]
    # .
    ${CredentialsId},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Username to connect in case authentication mode is Username and password
    ${Password},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # SecretKey to connect in case authentication mode is service account
    ${SecretKey},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Service Name to connect in case authentication mode is service account
    ${ServiceName},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # if credential validation has to be skipped.
    ${SkipCredentialValidation},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Commvault.Powershell.Category('Body')]
    [System.String]
    # Username to connect in case authentication mode is Username and password
    ${UserName},

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
            Create = 'CommvaultPowerShell.private\New-Kubernetescluster_Create';
            CreateExpanded = 'CommvaultPowerShell.private\New-Kubernetescluster_CreateExpanded';
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
