// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>indexingInfo</summary>
    public partial class IndexingInfo :
        Commvault.Powershell.Models.IIndexingInfo,
        Commvault.Powershell.Models.IIndexingInfoInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Indexing Message</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Type of indexing status.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="IndexingInfo" /> instance.</summary>
        public IndexingInfo()
        {

        }
    }
    /// indexingInfo
    public partial interface IIndexingInfo :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Indexing Message</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indexing Message",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>Type of indexing status.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of indexing status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// indexingInfo
    internal partial interface IIndexingInfoInternal

    {
        /// <summary>Indexing Message</summary>
        string Message { get; set; }
        /// <summary>Type of indexing status.</summary>
        string Status { get; set; }

    }
}