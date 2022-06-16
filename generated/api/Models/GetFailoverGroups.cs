// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Get failover groups</summary>
    public partial class GetFailoverGroups :
        Commvault.Powershell.Models.IGetFailoverGroups,
        Commvault.Powershell.Models.IGetFailoverGroupsInternal
    {

        /// <summary>Backing field for <see cref="FailoverGroups" /> property.</summary>
        private Commvault.Powershell.Models.IFailoverGroup[] _failoverGroups;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IFailoverGroup[] FailoverGroups { get => this._failoverGroups; set => this._failoverGroups = value; }

        /// <summary>Creates an new <see cref="GetFailoverGroups" /> instance.</summary>
        public GetFailoverGroups()
        {

        }
    }
    /// Get failover groups
    public partial interface IGetFailoverGroups :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"failoverGroups",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IFailoverGroup) })]
        Commvault.Powershell.Models.IFailoverGroup[] FailoverGroups { get; set; }

    }
    /// Get failover groups
    internal partial interface IGetFailoverGroupsInternal

    {
        Commvault.Powershell.Models.IFailoverGroup[] FailoverGroups { get; set; }

    }
}