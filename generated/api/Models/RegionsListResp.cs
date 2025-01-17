// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>List of regions</summary>
    public partial class RegionsListResp :
        Commvault.Powershell.Models.IRegionsListResp,
        Commvault.Powershell.Models.IRegionsListRespInternal
    {

        /// <summary>Backing field for <see cref="Regions" /> property.</summary>
        private Commvault.Powershell.Models.IRegionSummary[] _regions;

        /// <summary>Regions list</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IRegionSummary[] Regions { get => this._regions; set => this._regions = value; }

        /// <summary>Creates an new <see cref="RegionsListResp" /> instance.</summary>
        public RegionsListResp()
        {

        }
    }
    /// List of regions
    public partial interface IRegionsListResp :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Regions list</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Regions list",
        SerializedName = @"regions",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IRegionSummary) })]
        Commvault.Powershell.Models.IRegionSummary[] Regions { get; set; }

    }
    /// List of regions
    internal partial interface IRegionsListRespInternal

    {
        /// <summary>Regions list</summary>
        Commvault.Powershell.Models.IRegionSummary[] Regions { get; set; }

    }
}