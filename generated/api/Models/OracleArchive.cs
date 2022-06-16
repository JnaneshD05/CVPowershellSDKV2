// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Oracle Cloud Infrastructure Archive Storage</summary>
    public partial class OracleArchive :
        Commvault.Powershell.Models.IOracleArchive,
        Commvault.Powershell.Models.IOracleArchiveInternal,
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
        private string _cloudType= @"Oracle Cloud Infrastructure Archive Storage";

        /// <summary>Name of cloud vendor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CloudType { get => this._cloudType; }

        /// <summary>Internal Acessors for CloudType</summary>
        string Commvault.Powershell.Models.IOracleArchiveInternal.CloudType { get => this._cloudType; set { {_cloudType = value;} } }

        /// <summary>Backing field for <see cref="CompartmentName" /> property.</summary>
        private string _compartmentName;

        /// <summary>OCI compartment name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CompartmentName { get => this._compartmentName; set => this._compartmentName = value; }

        /// <summary>
        /// A list of dedupe locations can be provided for the storage pool being created. This provides an efficient way to save/store
        /// data by eliminating duplicate blocks of data during backups
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IDedupePath[] DeduplicationDbLocation { get => ((Commvault.Powershell.Models.IDedupeStorageListInternal)__dedupeStorageList).DeduplicationDbLocation; set => ((Commvault.Powershell.Models.IDedupeStorageListInternal)__dedupeStorageList).DeduplicationDbLocation = value; }

        /// <summary>Backing field for <see cref="KeyFingerprint" /> property.</summary>
        private string _keyFingerprint;

        /// <summary>PEM key's fingerprint</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string KeyFingerprint { get => this._keyFingerprint; set => this._keyFingerprint = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName MediaAgent { get => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgent; set => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgent = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? MediaAgentId { get => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgentId; set => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgentId = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string MediaAgentName { get => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgentName; set => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).MediaAgentName = value; }

        /// <summary>Name of the cloud storage library</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Name { get => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).Name; set => ((Commvault.Powershell.Models.ICloudStorageInternal)__cloudStorage).Name = value; }

        /// <summary>Backing field for <see cref="PemKeyFilename" /> property.</summary>
        private string _pemKeyFilename;

        /// <summary>PEM filename containing the private-key</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string PemKeyFilename { get => this._pemKeyFilename; set => this._pemKeyFilename = value; }

        /// <summary>Backing field for <see cref="PrivateKeyPassword" /> property.</summary>
        private string _privateKeyPassword;

        /// <summary>Password for the private key</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string PrivateKeyPassword { get => this._privateKeyPassword; set => this._privateKeyPassword = value; }

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

        /// <summary>Enables or disables deduplication on the storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? UseDeduplication { get => ((Commvault.Powershell.Models.IDedupeStorageListInternal)__dedupeStorageList).UseDeduplication; set => ((Commvault.Powershell.Models.IDedupeStorageListInternal)__dedupeStorageList).UseDeduplication = value; }

        /// <summary>Backing field for <see cref="UserOcid" /> property.</summary>
        private string _userOcid;

        /// <summary>User name for the Oracle Cloud ID</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UserOcid { get => this._userOcid; set => this._userOcid = value; }

        /// <summary>Creates an new <see cref="OracleArchive" /> instance.</summary>
        public OracleArchive()
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
    /// Oracle Cloud Infrastructure Archive Storage
    public partial interface IOracleArchive :
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
        /// <summary>OCI compartment name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"OCI compartment name",
        SerializedName = @"compartmentName",
        PossibleTypes = new [] { typeof(string) })]
        string CompartmentName { get; set; }
        /// <summary>PEM key's fingerprint</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"PEM key's fingerprint",
        SerializedName = @"keyFingerprint",
        PossibleTypes = new [] { typeof(string) })]
        string KeyFingerprint { get; set; }
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
    internal partial interface IOracleArchiveInternal :
        Commvault.Powershell.Models.ICloudStorageInternal,
        Commvault.Powershell.Models.IDedupeStorageListInternal
    {
        /// <summary>Name of bucket</summary>
        string Bucket { get; set; }
        /// <summary>Name of cloud vendor</summary>
        string CloudType { get; set; }
        /// <summary>OCI compartment name</summary>
        string CompartmentName { get; set; }
        /// <summary>PEM key's fingerprint</summary>
        string KeyFingerprint { get; set; }
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