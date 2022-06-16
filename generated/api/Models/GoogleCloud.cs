// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Google Cloud Storage</summary>
    public partial class GoogleCloud :
        Commvault.Powershell.Models.IGoogleCloud,
        Commvault.Powershell.Models.IGoogleCloudInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ICloudStorage" />
        /// </summary>
        private Commvault.Powershell.Models.ICloudStorage __cloudStorage = new Commvault.Powershell.Models.CloudStorage();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.IDedupeStorageList" />
        /// </summary>
        private Commvault.Powershell.Models.IDedupeStorageList __dedupeStorageList = new Commvault.Powershell.Models.DedupeStorageList();

        /// <summary>Backing field for <see cref="Bucket" /> property.</summary>
        private string _bucket;

        /// <summary>Name of bucket</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Bucket { get => this._bucket; set => this._bucket = value; }

        /// <summary>Backing field for <see cref="CloudType" /> property.</summary>
        private string _cloudType= @"Google Cloud Storage";

        /// <summary>Name of cloud vendor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CloudType { get => this._cloudType; }

        /// <summary>Internal Acessors for CloudType</summary>
        string Commvault.Powershell.Models.IGoogleCloudInternal.CloudType { get => this._cloudType; set { {_cloudType = value;} } }

        /// <summary>Internal Acessors for Credentials</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IGoogleCloudInternal.Credentials { get => (this._credentials = this._credentials ?? new Commvault.Powershell.Models.IdName()); set { {_credentials = value;} } }

        /// <summary>Backing field for <see cref="Credentials" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _credentials;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Credentials { get => (this._credentials = this._credentials ?? new Commvault.Powershell.Models.IdName()); set => this._credentials = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? CredentialsId { get => ((Commvault.Powershell.Models.IIdNameInternal)Credentials).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Credentials).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CredentialsName { get => ((Commvault.Powershell.Models.IIdNameInternal)Credentials).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Credentials).Name = value ?? null; }

        /// <summary>
        /// A list of dedupe locations can be provided for the storage pool being created. This provides an efficient way to save/store
        /// data by eliminating duplicate blocks of data during backups
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IDedupePath[] DeduplicationDbLocation { get => ((Commvault.Powershell.Models.IDedupeStorageListInternal)__dedupeStorageList).DeduplicationDbLocation; set => ((Commvault.Powershell.Models.IDedupeStorageListInternal)__dedupeStorageList).DeduplicationDbLocation = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName MediaAgent { get => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgent; set => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgent = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? MediaAgentId { get => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgentId; set => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgentId = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string MediaAgentName { get => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgentName; set => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgentName = value; }

        /// <summary>Name of the cloud storage library</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Name { get => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).Name; set => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).Name = value; }

        /// <summary>Backing field for <see cref="ServiceHost" /> property.</summary>
        private string _serviceHost;

        /// <summary>
        /// IP address or fully qualified domain name or URL for the cloud library based on cloud vendor
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ServiceHost { get => this._serviceHost; set => this._serviceHost = value; }

        /// <summary>Enables or disables deduplication on the storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? UseDeduplication { get => ((Commvault.Powershell.Models.IDedupeStorageListInternal)__dedupeStorageList).UseDeduplication; set => ((Commvault.Powershell.Models.IDedupeStorageListInternal)__dedupeStorageList).UseDeduplication = value; }

        /// <summary>Creates an new <see cref="GoogleCloud" /> instance.</summary>
        public GoogleCloud()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Commvault.Powershell.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Commvault.Powershell.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__cloudStorage), __cloudStorage);
            await eventListener.AssertObjectIsValid(nameof(__cloudStorage), __cloudStorage);
            await eventListener.AssertNotNull(nameof(__dedupeStorageList), __dedupeStorageList);
            await eventListener.AssertObjectIsValid(nameof(__dedupeStorageList), __dedupeStorageList);
        }
    }
    /// Google Cloud Storage
    public partial interface IGoogleCloud :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.ICloudStorage,
        Commvault.Powershell.Models.IDedupeStorageList
    {
        /// <summary>Name of bucket</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of bucket",
        SerializedName = @"bucket",
        PossibleTypes = new [] { typeof(string) })]
        string Bucket { get; set; }
        /// <summary>Name of cloud vendor</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"Name of cloud vendor",
        SerializedName = @"cloudType",
        PossibleTypes = new [] { typeof(string) })]
        string CloudType { get;  }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? CredentialsId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CredentialsName { get; set; }
        /// <summary>
        /// IP address or fully qualified domain name or URL for the cloud library based on cloud vendor
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"IP address or fully qualified domain name or URL for the cloud library based on cloud vendor",
        SerializedName = @"serviceHost",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceHost { get; set; }

    }
    /// Google Cloud Storage
    internal partial interface IGoogleCloudInternal :
        Commvault.Powershell.Models.ICloudStorageInternal,
        Commvault.Powershell.Models.IDedupeStorageListInternal
    {
        /// <summary>Name of bucket</summary>
        string Bucket { get; set; }
        /// <summary>Name of cloud vendor</summary>
        string CloudType { get; set; }

        Commvault.Powershell.Models.IIdName Credentials { get; set; }

        int? CredentialsId { get; set; }

        string CredentialsName { get; set; }
        /// <summary>
        /// IP address or fully qualified domain name or URL for the cloud library based on cloud vendor
        /// </summary>
        string ServiceHost { get; set; }

    }
}