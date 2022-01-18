// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Microsoft Azure Storage</summary>
    public partial class MicrosoftAzure :
        Commvault.Powershell.Models.IMicrosoftAzure,
        Commvault.Powershell.Models.IMicrosoftAzureInternal,
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

        /// <summary>Backing field for <see cref="AccountName" /> property.</summary>
        private string _accountName;

        /// <summary>Only for IAM VM and IAM AD</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string AccountName { get => this._accountName; set => this._accountName = value; }

        /// <summary>Backing field for <see cref="Authentication" /> property.</summary>
        private string _authentication;

        /// <summary>
        /// Authentication type for the cloud storage server. Only Access & Account Name and IAM AD require credentials.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Authentication { get => this._authentication; set => this._authentication = value; }

        /// <summary>Backing field for <see cref="CloudType" /> property.</summary>
        private string _cloudType= @"Microsoft Azure Storage";

        /// <summary>Name of cloud vendor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CloudType { get => this._cloudType; }

        /// <summary>Internal Acessors for CloudType</summary>
        string Commvault.Powershell.Models.IMicrosoftAzureInternal.CloudType { get => this._cloudType; set { {_cloudType = value;} } }

        /// <summary>Internal Acessors for Credentials</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IMicrosoftAzureInternal.Credentials { get => (this._credentials = this._credentials ?? new Commvault.Powershell.Models.IdName()); set { {_credentials = value;} } }

        /// <summary>Backing field for <see cref="Container" /> property.</summary>
        private string _container;

        /// <summary>Name of container</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Container { get => this._container; set => this._container = value; }

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
        public Commvault.Powershell.Models.IDedupePath[] DeduplicationDbLocation { get => ((Commvault.Powershell.Models.IDedupeStorageListInternal)__dedupeStorageList).DeduplicationDbLocation; set => ((Commvault.Powershell.Models.IDedupeStorageListInternal)__dedupeStorageList).DeduplicationDbLocation = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName MediaAgent { get => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgent; set => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgent = value ; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? MediaAgentId { get => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgentId; set => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgentId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string MediaAgentName { get => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgentName; set => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgentName = value ; }

        /// <summary>Name of the cloud storage library</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Name { get => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).Name; set => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).Name = value ; }

        /// <summary>Backing field for <see cref="ServiceHost" /> property.</summary>
        private string _serviceHost;

        /// <summary>
        /// IP address or fully qualified domain name or URL for the cloud library based on cloud vendor
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ServiceHost { get => this._serviceHost; set => this._serviceHost = value; }

        /// <summary>Backing field for <see cref="StorageClass" /> property.</summary>
        private string _storageClass;

        /// <summary>Appropriate storage class for your account</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string StorageClass { get => this._storageClass; set => this._storageClass = value; }

        /// <summary>Enables or disables deduplication on the storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? UseDeduplication { get => ((Commvault.Powershell.Models.IDedupeStorageListInternal)__dedupeStorageList).UseDeduplication; set => ((Commvault.Powershell.Models.IDedupeStorageListInternal)__dedupeStorageList).UseDeduplication = value ?? default(bool); }

        /// <summary>Creates an new <see cref="MicrosoftAzure" /> instance.</summary>
        public MicrosoftAzure()
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
    /// Microsoft Azure Storage
    public partial interface IMicrosoftAzure :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.ICloudStorage,
        Commvault.Powershell.Models.IDedupeStorageList
    {
        /// <summary>Only for IAM VM and IAM AD</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Only for IAM VM and IAM AD",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string AccountName { get; set; }
        /// <summary>
        /// Authentication type for the cloud storage server. Only Access & Account Name and IAM AD require credentials.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Authentication type for the cloud storage server. Only Access & Account Name and IAM AD require credentials.",
        SerializedName = @"authentication",
        PossibleTypes = new [] { typeof(string) })]
        string Authentication { get; set; }
        /// <summary>Name of cloud vendor</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"Name of cloud vendor",
        SerializedName = @"cloudType",
        PossibleTypes = new [] { typeof(string) })]
        string CloudType { get;  }
        /// <summary>Name of container</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of container",
        SerializedName = @"container",
        PossibleTypes = new [] { typeof(string) })]
        string Container { get; set; }

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
        /// <summary>Appropriate storage class for your account</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Appropriate storage class for your account",
        SerializedName = @"storageClass",
        PossibleTypes = new [] { typeof(string) })]
        string StorageClass { get; set; }

    }
    /// Microsoft Azure Storage
    internal partial interface IMicrosoftAzureInternal :
        Commvault.Powershell.Models.ICloudStorageInternal,
        Commvault.Powershell.Models.IDedupeStorageListInternal
    {
        /// <summary>Only for IAM VM and IAM AD</summary>
        string AccountName { get; set; }
        /// <summary>
        /// Authentication type for the cloud storage server. Only Access & Account Name and IAM AD require credentials.
        /// </summary>
        string Authentication { get; set; }
        /// <summary>Name of cloud vendor</summary>
        string CloudType { get; set; }
        /// <summary>Name of container</summary>
        string Container { get; set; }

        Commvault.Powershell.Models.IIdName Credentials { get; set; }

        int? CredentialsId { get; set; }

        string CredentialsName { get; set; }
        /// <summary>
        /// IP address or fully qualified domain name or URL for the cloud library based on cloud vendor
        /// </summary>
        string ServiceHost { get; set; }
        /// <summary>Appropriate storage class for your account</summary>
        string StorageClass { get; set; }

    }
}