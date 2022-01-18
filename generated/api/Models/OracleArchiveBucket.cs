// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Oracle Cloud Infrastructure Archive Storage</summary>
    public partial class OracleArchiveBucket :
        Commvault.Powershell.Models.IOracleArchiveBucket,
        Commvault.Powershell.Models.IOracleArchiveBucketInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ICloudStorageProxy" />
        /// </summary>
        private Commvault.Powershell.Models.ICloudStorageProxy __cloudStorageProxy = new Commvault.Powershell.Models.CloudStorageProxy();

        /// <summary>Backing field for <see cref="Bucket" /> property.</summary>
        private string _bucket;

        /// <summary>Name of bucket</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Bucket { get => this._bucket; set => this._bucket = value; }

        /// <summary>Backing field for <see cref="CloudType" /> property.</summary>
        private string _cloudType= @"Oracle Cloud Infrastructure Archive Storage";

        /// <summary>Name of cloud vendor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CloudType { get => this._cloudType; }

        /// <summary>Internal Acessors for CloudType</summary>
        string Commvault.Powershell.Models.IOracleArchiveBucketInternal.CloudType { get => this._cloudType; set { {_cloudType = value;} } }

        /// <summary>Internal Acessors for MediaAgent</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IOracleArchiveBucketInternal.MediaAgent { get => (this._mediaAgent = this._mediaAgent ?? new Commvault.Powershell.Models.IdName()); set { {_mediaAgent = value;} } }

        /// <summary>Backing field for <see cref="CompartmentName" /> property.</summary>
        private string _compartmentName;

        /// <summary>OCI compartment name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CompartmentName { get => this._compartmentName; set => this._compartmentName = value; }

        /// <summary>Backing field for <see cref="DeduplicationDbLocation" /> property.</summary>
        private string _deduplicationDbLocation;

        /// <summary>
        /// To enable deduplication on this storage, provide path of the Deduplication database (DDB)
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DeduplicationDbLocation { get => this._deduplicationDbLocation; set => this._deduplicationDbLocation = value; }

        /// <summary>Backing field for <see cref="KeyFingerprint" /> property.</summary>
        private string _keyFingerprint;

        /// <summary>PEM key's fingerprint</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string KeyFingerprint { get => this._keyFingerprint; set => this._keyFingerprint = value; }

        /// <summary>Backing field for <see cref="MediaAgent" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _mediaAgent;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName MediaAgent { get => (this._mediaAgent = this._mediaAgent ?? new Commvault.Powershell.Models.IdName()); set => this._mediaAgent = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? MediaAgentId { get => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string MediaAgentName { get => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Name = value ?? null; }

        /// <summary>Password for proxy configuration (Should be in Base64 format)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public System.Security.SecureString Password { get => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Password; set => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Password = value ?? null; }

        /// <summary>Backing field for <see cref="PemKeyFilename" /> property.</summary>
        private string _pemKeyFilename;

        /// <summary>PEM filename containing the private-key</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string PemKeyFilename { get => this._pemKeyFilename; set => this._pemKeyFilename = value; }

        /// <summary>Port for proxy configuration</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? Port { get => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Port; set => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Port = value ?? default(int); }

        /// <summary>Backing field for <see cref="PrivateKeyPassword" /> property.</summary>
        private string _privateKeyPassword;

        /// <summary>Password for the private key</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string PrivateKeyPassword { get => this._privateKeyPassword; set => this._privateKeyPassword = value; }

        /// <summary>
        /// If the MediaAgent accesses the mount path using a proxy then proxy server address needs to be provided. If you want to
        /// remove proxy information, pass empty string in proxyAddress.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string ProxyAddress { get => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).ProxyAddress; set => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).ProxyAddress = value ?? null; }

        /// <summary>Backing field for <see cref="ServiceHost" /> property.</summary>
        private string _serviceHost;

        /// <summary>
        /// IP address or fully qualified domain name or URL for the cloud library based on cloud vendor
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ServiceHost { get => this._serviceHost; set => this._serviceHost = value; }

        /// <summary>Backing field for <see cref="TenancyOcid" /> property.</summary>
        private string _tenancyOcid;

        /// <summary>Oracle Cloud ID</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string TenancyOcid { get => this._tenancyOcid; set => this._tenancyOcid = value; }

        /// <summary>Backing field for <see cref="UserOcid" /> property.</summary>
        private string _userOcid;

        /// <summary>User name for the Oracle Cloud ID</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UserOcid { get => this._userOcid; set => this._userOcid = value; }

        /// <summary>Username for proxy configuration</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Username { get => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Username; set => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Username = value ?? null; }

        /// <summary>Creates an new <see cref="OracleArchiveBucket" /> instance.</summary>
        public OracleArchiveBucket()
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
            await eventListener.AssertNotNull(nameof(__cloudStorageProxy), __cloudStorageProxy);
            await eventListener.AssertObjectIsValid(nameof(__cloudStorageProxy), __cloudStorageProxy);
        }
    }
    /// Oracle Cloud Infrastructure Archive Storage
    public partial interface IOracleArchiveBucket :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.ICloudStorageProxy
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
        /// <summary>OCI compartment name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"OCI compartment name",
        SerializedName = @"compartmentName",
        PossibleTypes = new [] { typeof(string) })]
        string CompartmentName { get; set; }
        /// <summary>
        /// To enable deduplication on this storage, provide path of the Deduplication database (DDB)
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"To enable deduplication on this storage, provide path of the Deduplication database (DDB)",
        SerializedName = @"deduplicationDBLocation",
        PossibleTypes = new [] { typeof(string) })]
        string DeduplicationDbLocation { get; set; }
        /// <summary>PEM key's fingerprint</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"PEM key's fingerprint",
        SerializedName = @"keyFingerprint",
        PossibleTypes = new [] { typeof(string) })]
        string KeyFingerprint { get; set; }

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
        /// <summary>PEM filename containing the private-key</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"PEM filename containing the private-key",
        SerializedName = @"pemKeyFilename",
        PossibleTypes = new [] { typeof(string) })]
        string PemKeyFilename { get; set; }
        /// <summary>Password for the private key</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Password for the private key",
        SerializedName = @"privateKeyPassword",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateKeyPassword { get; set; }
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
        /// <summary>Oracle Cloud ID</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Oracle Cloud ID",
        SerializedName = @"tenancyOCID",
        PossibleTypes = new [] { typeof(string) })]
        string TenancyOcid { get; set; }
        /// <summary>User name for the Oracle Cloud ID</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"User name for the Oracle Cloud ID",
        SerializedName = @"userOCID",
        PossibleTypes = new [] { typeof(string) })]
        string UserOcid { get; set; }

    }
    /// Oracle Cloud Infrastructure Archive Storage
    internal partial interface IOracleArchiveBucketInternal :
        Commvault.Powershell.Models.ICloudStorageProxyInternal
    {
        /// <summary>Name of bucket</summary>
        string Bucket { get; set; }
        /// <summary>Name of cloud vendor</summary>
        string CloudType { get; set; }
        /// <summary>OCI compartment name</summary>
        string CompartmentName { get; set; }
        /// <summary>
        /// To enable deduplication on this storage, provide path of the Deduplication database (DDB)
        /// </summary>
        string DeduplicationDbLocation { get; set; }
        /// <summary>PEM key's fingerprint</summary>
        string KeyFingerprint { get; set; }

        Commvault.Powershell.Models.IIdName MediaAgent { get; set; }

        int? MediaAgentId { get; set; }

        string MediaAgentName { get; set; }
        /// <summary>PEM filename containing the private-key</summary>
        string PemKeyFilename { get; set; }
        /// <summary>Password for the private key</summary>
        string PrivateKeyPassword { get; set; }
        /// <summary>
        /// IP address or fully qualified domain name or URL for the cloud library based on cloud vendor
        /// </summary>
        string ServiceHost { get; set; }
        /// <summary>Oracle Cloud ID</summary>
        string TenancyOcid { get; set; }
        /// <summary>User name for the Oracle Cloud ID</summary>
        string UserOcid { get; set; }

    }
}