// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>CacheConfigurations</summary>
    public partial class CacheConfigurations :
        Commvault.Powershell.Models.ICacheConfigurations,
        Commvault.Powershell.Models.ICacheConfigurationsInternal
    {

        /// <summary>Backing field for <see cref="Enable" /> property.</summary>
        private bool? _enable;

        /// <summary>Tells if cache configuration is enabled for this storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Enable { get => this._enable; set => this._enable = value; }

        /// <summary>Backing field for <see cref="MetadataCache" /> property.</summary>
        private Commvault.Powershell.Models.IMetadataCache[] _metadataCache;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IMetadataCache[] MetadataCache { get => this._metadataCache; set => this._metadataCache = value; }

        /// <summary>Creates an new <see cref="CacheConfigurations" /> instance.</summary>
        public CacheConfigurations()
        {

        }
    }
    /// CacheConfigurations
    public partial interface ICacheConfigurations :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Tells if cache configuration is enabled for this storage</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tells if cache configuration is enabled for this storage",
        SerializedName = @"enable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enable { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"metadataCache",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IMetadataCache) })]
        Commvault.Powershell.Models.IMetadataCache[] MetadataCache { get; set; }

    }
    /// CacheConfigurations
    internal partial interface ICacheConfigurationsInternal

    {
        /// <summary>Tells if cache configuration is enabled for this storage</summary>
        bool? Enable { get; set; }

        Commvault.Powershell.Models.IMetadataCache[] MetadataCache { get; set; }

    }
}