// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class InstantClonesListResp :
        Commvault.Powershell.Models.IInstantClonesListResp,
        Commvault.Powershell.Models.IInstantClonesListRespInternal
    {

        /// <summary>Backing field for <see cref="InstantClones" /> property.</summary>
        private Commvault.Powershell.Models.IInstantClonesSummary[] _instantClones;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IInstantClonesSummary[] InstantClones { get => this._instantClones; set => this._instantClones = value; }

        /// <summary>Creates an new <see cref="InstantClonesListResp" /> instance.</summary>
        public InstantClonesListResp()
        {

        }
    }
    public partial interface IInstantClonesListResp :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"instantClones",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IInstantClonesSummary) })]
        Commvault.Powershell.Models.IInstantClonesSummary[] InstantClones { get; set; }

    }
    internal partial interface IInstantClonesListRespInternal

    {
        Commvault.Powershell.Models.IInstantClonesSummary[] InstantClones { get; set; }

    }
}