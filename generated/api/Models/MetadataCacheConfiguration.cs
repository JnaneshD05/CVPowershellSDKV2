// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>MetadataCacheConfiguration</summary>
    public partial class MetadataCacheConfiguration :
        Commvault.Powershell.Models.IMetadataCacheConfiguration,
        Commvault.Powershell.Models.IMetadataCacheConfigurationInternal
    {

        /// <summary>Internal Acessors for Credentials</summary>
        Commvault.Powershell.Models.IUserNamePassword Commvault.Powershell.Models.IMetadataCacheConfigurationInternal.Credentials { get => (this._credentials = this._credentials ?? new Commvault.Powershell.Models.UserNamePassword()); set { {_credentials = value;} } }

        /// <summary>Internal Acessors for MediaAgent</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IMetadataCacheConfigurationInternal.MediaAgent { get => (this._mediaAgent = this._mediaAgent ?? new Commvault.Powershell.Models.IdName()); set { {_mediaAgent = value;} } }

        /// <summary>Internal Acessors for SavedCredentials</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IMetadataCacheConfigurationInternal.SavedCredentials { get => (this._savedCredentials = this._savedCredentials ?? new Commvault.Powershell.Models.IdName()); set { {_savedCredentials = value;} } }

        /// <summary>Backing field for <see cref="Credentials" /> property.</summary>
        private Commvault.Powershell.Models.IUserNamePassword _credentials;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IUserNamePassword Credentials { get => (this._credentials = this._credentials ?? new Commvault.Powershell.Models.UserNamePassword()); set => this._credentials = value; }

        /// <summary>username to access the network path</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CredentialsName { get => ((Commvault.Powershell.Models.IUserNamePasswordInternal)Credentials).Name; set => ((Commvault.Powershell.Models.IUserNamePasswordInternal)Credentials).Name = value ?? null; }

        /// <summary>password to access the network path</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CredentialsPassword { get => ((Commvault.Powershell.Models.IUserNamePasswordInternal)Credentials).Password; set => ((Commvault.Powershell.Models.IUserNamePasswordInternal)Credentials).Password = value ?? null; }

        /// <summary>Backing field for <see cref="MediaAgent" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _mediaAgent;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName MediaAgent { get => (this._mediaAgent = this._mediaAgent ?? new Commvault.Powershell.Models.IdName()); set => this._mediaAgent = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? MediaAgentId { get => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string MediaAgentName { get => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Name = value ?? null; }

        /// <summary>Backing field for <see cref="MetadataCache" /> property.</summary>
        private Commvault.Powershell.Models.IMetadataCache[] _metadataCache;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IMetadataCache[] MetadataCache { get => this._metadataCache; set => this._metadataCache = value; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        /// <summary>Metadata cache will be stored on this path</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Backing field for <see cref="SavedCredentials" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _savedCredentials;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName SavedCredentials { get => (this._savedCredentials = this._savedCredentials ?? new Commvault.Powershell.Models.IdName()); set => this._savedCredentials = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SavedCredentialsId { get => ((Commvault.Powershell.Models.IIdNameInternal)SavedCredentials).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)SavedCredentials).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SavedCredentialsName { get => ((Commvault.Powershell.Models.IIdNameInternal)SavedCredentials).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)SavedCredentials).Name = value ?? null; }

        /// <summary>Creates an new <see cref="MetadataCacheConfiguration" /> instance.</summary>
        public MetadataCacheConfiguration()
        {

        }
    }
    /// MetadataCacheConfiguration
    public partial interface IMetadataCacheConfiguration :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>username to access the network path</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"username to access the network path",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CredentialsName { get; set; }
        /// <summary>password to access the network path</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"password to access the network path",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string CredentialsPassword { get; set; }

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

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"metadataCache",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IMetadataCache) })]
        Commvault.Powershell.Models.IMetadataCache[] MetadataCache { get; set; }
        /// <summary>Metadata cache will be stored on this path</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metadata cache will be stored on this path",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? SavedCredentialsId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SavedCredentialsName { get; set; }

    }
    /// MetadataCacheConfiguration
    internal partial interface IMetadataCacheConfigurationInternal

    {
        Commvault.Powershell.Models.IUserNamePassword Credentials { get; set; }
        /// <summary>username to access the network path</summary>
        string CredentialsName { get; set; }
        /// <summary>password to access the network path</summary>
        string CredentialsPassword { get; set; }

        Commvault.Powershell.Models.IIdName MediaAgent { get; set; }

        int? MediaAgentId { get; set; }

        string MediaAgentName { get; set; }

        Commvault.Powershell.Models.IMetadataCache[] MetadataCache { get; set; }
        /// <summary>Metadata cache will be stored on this path</summary>
        string Path { get; set; }

        Commvault.Powershell.Models.IIdName SavedCredentials { get; set; }

        int? SavedCredentialsId { get; set; }

        string SavedCredentialsName { get; set; }

    }
}