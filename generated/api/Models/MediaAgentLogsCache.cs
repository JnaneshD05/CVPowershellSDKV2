// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class MediaAgentLogsCache :
        Commvault.Powershell.Models.IMediaAgentLogsCache,
        Commvault.Powershell.Models.IMediaAgentLogsCacheInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>This tag determines if the logs cache has been enabled or not.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        /// <summary>If the logs cache is enabled, this tag gives the path to store the logs cache.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Creates an new <see cref="MediaAgentLogsCache" /> instance.</summary>
        public MediaAgentLogsCache()
        {

        }
    }
    public partial interface IMediaAgentLogsCache :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>This tag determines if the logs cache has been enabled or not.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This tag determines if the logs cache has been enabled or not. ",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>If the logs cache is enabled, this tag gives the path to store the logs cache.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If the logs cache is enabled, this tag gives the path to store the logs cache.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get; set; }

    }
    internal partial interface IMediaAgentLogsCacheInternal

    {
        /// <summary>This tag determines if the logs cache has been enabled or not.</summary>
        bool? Enabled { get; set; }
        /// <summary>If the logs cache is enabled, this tag gives the path to store the logs cache.</summary>
        string Path { get; set; }

    }
}