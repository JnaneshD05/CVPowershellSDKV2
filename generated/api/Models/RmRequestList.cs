// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>RMRequestList</summary>
    public partial class RmRequestList :
        Commvault.Powershell.Models.IRmRequestList,
        Commvault.Powershell.Models.IRmRequestListInternal
    {

        /// <summary>Backing field for <see cref="Requests" /> property.</summary>
        private Commvault.Powershell.Models.IRmRequestSummary[] _requests;

        /// <summary>List of Request Manager Requests</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IRmRequestSummary[] Requests { get => this._requests; set => this._requests = value; }

        /// <summary>Creates an new <see cref="RmRequestList" /> instance.</summary>
        public RmRequestList()
        {

        }
    }
    /// RMRequestList
    public partial interface IRmRequestList :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>List of Request Manager Requests</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of Request Manager Requests",
        SerializedName = @"requests",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IRmRequestSummary) })]
        Commvault.Powershell.Models.IRmRequestSummary[] Requests { get; set; }

    }
    /// RMRequestList
    internal partial interface IRmRequestListInternal

    {
        /// <summary>List of Request Manager Requests</summary>
        Commvault.Powershell.Models.IRmRequestSummary[] Requests { get; set; }

    }
}