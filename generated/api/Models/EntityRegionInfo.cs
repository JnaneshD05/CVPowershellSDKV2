// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class EntityRegionInfo :
        Commvault.Powershell.Models.IEntityRegionInfo,
        Commvault.Powershell.Models.IEntityRegionInfoInternal
    {

        /// <summary>Internal Acessors for Region</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IEntityRegionInfoInternal.Region { get => (this._region = this._region ?? new Commvault.Powershell.Models.IdName()); set { {_region = value;} } }

        /// <summary>Backing field for <see cref="EntityRegionType" /> property.</summary>
        private string _entityRegionType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string EntityRegionType { get => this._entityRegionType; set => this._entityRegionType = value; }

        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _region;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Region { get => (this._region = this._region ?? new Commvault.Powershell.Models.IdName()); set => this._region = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? RegionId { get => ((Commvault.Powershell.Models.IIdNameInternal)Region).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Region).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RegionName { get => ((Commvault.Powershell.Models.IIdNameInternal)Region).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Region).Name = value ?? null; }

        /// <summary>Creates an new <see cref="EntityRegionInfo" /> instance.</summary>
        public EntityRegionInfo()
        {

        }
    }
    public partial interface IEntityRegionInfo :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"entityRegionType",
        PossibleTypes = new [] { typeof(string) })]
        string EntityRegionType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? RegionId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string RegionName { get; set; }

    }
    internal partial interface IEntityRegionInfoInternal

    {
        string EntityRegionType { get; set; }

        Commvault.Powershell.Models.IIdName Region { get; set; }

        int? RegionId { get; set; }

        string RegionName { get; set; }

    }
}