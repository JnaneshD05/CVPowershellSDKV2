// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>metadataCache</summary>
    public partial class MetadataCache :
        Commvault.Powershell.Models.IMetadataCache,
        Commvault.Powershell.Models.IMetadataCacheInternal
    {

        /// <summary>Internal Acessors for MediaAgent</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IMetadataCacheInternal.MediaAgent { get => (this._mediaAgent = this._mediaAgent ?? new Commvault.Powershell.Models.IdName()); set { {_mediaAgent = value;} } }

        /// <summary>Backing field for <see cref="MediaAgent" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _mediaAgent;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName MediaAgent { get => (this._mediaAgent = this._mediaAgent ?? new Commvault.Powershell.Models.IdName()); set => this._mediaAgent = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? MediaAgentId { get => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string MediaAgentName { get => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        /// <summary>Path of cache</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Creates an new <see cref="MetadataCache" /> instance.</summary>
        public MetadataCache()
        {

        }
    }
    /// metadataCache
    public partial interface IMetadataCache :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? MediaAgentId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string MediaAgentName { get; set; }
        /// <summary>Path of cache</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path of cache",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get; set; }

    }
    /// metadataCache
    internal partial interface IMetadataCacheInternal

    {
        Commvault.Powershell.Models.IIdName MediaAgent { get; set; }

        int? MediaAgentId { get; set; }

        string MediaAgentName { get; set; }
        /// <summary>Path of cache</summary>
        string Path { get; set; }

    }
}