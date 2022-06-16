// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Used to return a list of file servers.</summary>
    public partial class FileServerListResp :
        Commvault.Powershell.Models.IFileServerListResp,
        Commvault.Powershell.Models.IFileServerListRespInternal
    {

        /// <summary>Backing field for <see cref="FileServerCount" /> property.</summary>
        private int? _fileServerCount;

        /// <summary>This returns the total number of file servers.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? FileServerCount { get => this._fileServerCount; set => this._fileServerCount = value; }

        /// <summary>Backing field for <see cref="FileServers" /> property.</summary>
        private Commvault.Powershell.Models.IFileServerSummary[] _fileServers;

        /// <summary>This returns the file server list.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IFileServerSummary[] FileServers { get => this._fileServers; set => this._fileServers = value; }

        /// <summary>Creates an new <see cref="FileServerListResp" /> instance.</summary>
        public FileServerListResp()
        {

        }
    }
    /// Used to return a list of file servers.
    public partial interface IFileServerListResp :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>This returns the total number of file servers.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This returns the total number of file servers.",
        SerializedName = @"fileServerCount",
        PossibleTypes = new [] { typeof(int) })]
        int? FileServerCount { get; set; }
        /// <summary>This returns the file server list.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This returns the file server list.",
        SerializedName = @"fileServers",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IFileServerSummary) })]
        Commvault.Powershell.Models.IFileServerSummary[] FileServers { get; set; }

    }
    /// Used to return a list of file servers.
    internal partial interface IFileServerListRespInternal

    {
        /// <summary>This returns the total number of file servers.</summary>
        int? FileServerCount { get; set; }
        /// <summary>This returns the file server list.</summary>
        Commvault.Powershell.Models.IFileServerSummary[] FileServers { get; set; }

    }
}