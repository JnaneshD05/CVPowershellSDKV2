// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Cloud Storage Details</summary>
    public partial class CloudStorageDetails :
        Commvault.Powershell.Models.ICloudStorageDetails,
        Commvault.Powershell.Models.ICloudStorageDetailsInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.IIdName" />
        /// </summary>
        private Commvault.Powershell.Models.IIdName __idName = new Commvault.Powershell.Models.IdName();

        /// <summary>Backing field for <see cref="AssociatedPlans" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _associatedPlans;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] AssociatedPlans { get => this._associatedPlans; set => this._associatedPlans = value; }

        /// <summary>Backing field for <see cref="Bucket" /> property.</summary>
        private Commvault.Powershell.Models.IIdNameStatus[] _bucket;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdNameStatus[] Bucket { get => this._bucket; set => this._bucket = value; }

        /// <summary>Tells if cache configuration is enabled for this storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? CacheConfigurationEnable { get => ((Commvault.Powershell.Models.ICacheConfigurationsInternal)CacheConfigurations).Enable; set => ((Commvault.Powershell.Models.ICacheConfigurationsInternal)CacheConfigurations).Enable = value ?? default(bool); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IMetadataCache[] CacheConfigurationMetadataCache { get => ((Commvault.Powershell.Models.ICacheConfigurationsInternal)CacheConfigurations).MetadataCache; set => ((Commvault.Powershell.Models.ICacheConfigurationsInternal)CacheConfigurations).MetadataCache = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="CacheConfigurations" /> property.</summary>
        private Commvault.Powershell.Models.ICacheConfigurations _cacheConfigurations;

        /// <summary>CacheConfigurations</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ICacheConfigurations CacheConfigurations { get => (this._cacheConfigurations = this._cacheConfigurations ?? new Commvault.Powershell.Models.CacheConfigurations()); set => this._cacheConfigurations = value; }

        /// <summary>Internal Acessors for CacheConfigurations</summary>
        Commvault.Powershell.Models.ICacheConfigurations Commvault.Powershell.Models.ICloudStorageDetailsInternal.CacheConfigurations { get => (this._cacheConfigurations = this._cacheConfigurations ?? new Commvault.Powershell.Models.CacheConfigurations()); set { {_cacheConfigurations = value;} } }

        /// <summary>Internal Acessors for Encryption</summary>
        Commvault.Powershell.Models.IEncryption Commvault.Powershell.Models.ICloudStorageDetailsInternal.Encryption { get => (this._encryption = this._encryption ?? new Commvault.Powershell.Models.Encryption()); set { {_encryption = value;} } }

        /// <summary>Internal Acessors for EncryptionKeyProvider</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICloudStorageDetailsInternal.EncryptionKeyProvider { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProvider; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProvider = value; }

        /// <summary>Internal Acessors for General</summary>
        Commvault.Powershell.Models.ICloudStorageGeneralInfo Commvault.Powershell.Models.ICloudStorageDetailsInternal.General { get => (this._general = this._general ?? new Commvault.Powershell.Models.CloudStorageGeneralInfo()); set { {_general = value;} } }

        /// <summary>Backing field for <see cref="Encryption" /> property.</summary>
        private Commvault.Powershell.Models.IEncryption _encryption;

        /// <summary>Different ways in which data can be encrypted.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IEncryption Encryption { get => (this._encryption = this._encryption ?? new Commvault.Powershell.Models.Encryption()); set => this._encryption = value; }

        /// <summary>
        /// The different types of encryption keys that can be used for encrypting the data. The values are case sensitive
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string EncryptionCipher { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).Cipher; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).Cipher = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? EncryptionEncrypt { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).Encrypt; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).Encrypt = value ?? default(bool); }

        /// <summary>
        /// Different keylengths are present for different kinds of ciphers. Blowfish,Twofish,AES and Serpent all accept both 128
        /// and 256. DES3 accepts only 192. GOST accepts only 256.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? EncryptionKeyLength { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyLength; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyLength = value ?? default(int); }

        /// <summary>Backing field for <see cref="General" /> property.</summary>
        private Commvault.Powershell.Models.ICloudStorageGeneralInfo _general;

        /// <summary>CloudStorageGeneralInfo</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ICloudStorageGeneralInfo General { get => (this._general = this._general ?? new Commvault.Powershell.Models.CloudStorageGeneralInfo()); set => this._general = value; }

        /// <summary>
        /// Specifies the savings in percentage that occurred due to deduplication. Only available for dedupe cloud storage pools
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GeneralDeduplicationSavings { get => ((Commvault.Powershell.Models.ICloudStorageGeneralInfoInternal)General).DeduplicationSavings; set => ((Commvault.Powershell.Models.ICloudStorageGeneralInfoInternal)General).DeduplicationSavings = value ?? null; }

        /// <summary>Free space available on this cloud storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? GeneralFreeSpace { get => ((Commvault.Powershell.Models.ICloudStorageGeneralInfoInternal)General).FreeSpace; set => ((Commvault.Powershell.Models.ICloudStorageGeneralInfoInternal)General).FreeSpace = value ?? default(int); }

        /// <summary>Amount of space consumed</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? GeneralSizeOnDisk { get => ((Commvault.Powershell.Models.ICloudStorageGeneralInfoInternal)General).SizeOnDisk; set => ((Commvault.Powershell.Models.ICloudStorageGeneralInfoInternal)General).SizeOnDisk = value ?? default(int); }

        /// <summary>Total capacity of this cloud storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? GeneralTotalCapacity { get => ((Commvault.Powershell.Models.ICloudStorageGeneralInfoInternal)General).TotalCapacity; set => ((Commvault.Powershell.Models.ICloudStorageGeneralInfoInternal)General).TotalCapacity = value ?? default(int); }

        /// <summary>Type of the cloud storage server</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GeneralType { get => ((Commvault.Powershell.Models.ICloudStorageGeneralInfoInternal)General).Type; set => ((Commvault.Powershell.Models.ICloudStorageGeneralInfoInternal)General).Type = value ?? null; }

        /// <summary>Cloud server type</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GeneralVendorType { get => ((Commvault.Powershell.Models.ICloudStorageGeneralInfoInternal)General).VendorType; set => ((Commvault.Powershell.Models.ICloudStorageGeneralInfoInternal)General).VendorType = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? Id { get => ((Commvault.Powershell.Models.IIdNameInternal)__idName).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)__idName).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? KeyProviderId { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderId; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string KeyProviderName { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderName; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Name { get => ((Commvault.Powershell.Models.IIdNameInternal)__idName).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)__idName).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Security" /> property.</summary>
        private Commvault.Powershell.Models.ISecurityAssoc[] _security;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.ISecurityAssoc[] Security { get => this._security; set => this._security = value; }

        /// <summary>Creates an new <see cref="CloudStorageDetails" /> instance.</summary>
        public CloudStorageDetails()
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
            await eventListener.AssertNotNull(nameof(__idName), __idName);
            await eventListener.AssertObjectIsValid(nameof(__idName), __idName);
        }
    }
    /// Cloud Storage Details
    public partial interface ICloudStorageDetails :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.IIdName
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"associatedPlans",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] AssociatedPlans { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"bucket",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdNameStatus) })]
        Commvault.Powershell.Models.IIdNameStatus[] Bucket { get; set; }
        /// <summary>Tells if cache configuration is enabled for this storage</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tells if cache configuration is enabled for this storage",
        SerializedName = @"enable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CacheConfigurationEnable { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"metadataCache",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IMetadataCache) })]
        Commvault.Powershell.Models.IMetadataCache[] CacheConfigurationMetadataCache { get; set; }
        /// <summary>
        /// The different types of encryption keys that can be used for encrypting the data. The values are case sensitive
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The different types of encryption keys that can be used for encrypting the data. The values are case sensitive",
        SerializedName = @"cipher",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionCipher { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"encrypt",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EncryptionEncrypt { get; set; }
        /// <summary>
        /// Different keylengths are present for different kinds of ciphers. Blowfish,Twofish,AES and Serpent all accept both 128
        /// and 256. DES3 accepts only 192. GOST accepts only 256.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Different keylengths are present for different kinds of ciphers. Blowfish,Twofish,AES and Serpent all accept both 128 and 256. DES3 accepts only 192. GOST accepts only 256. ",
        SerializedName = @"keyLength",
        PossibleTypes = new [] { typeof(int) })]
        int? EncryptionKeyLength { get; set; }
        /// <summary>
        /// Specifies the savings in percentage that occurred due to deduplication. Only available for dedupe cloud storage pools
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the savings in percentage that occurred due to deduplication. Only available for dedupe cloud storage pools",
        SerializedName = @"deduplicationSavings",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralDeduplicationSavings { get; set; }
        /// <summary>Free space available on this cloud storage</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Free space available on this cloud storage",
        SerializedName = @"freeSpace",
        PossibleTypes = new [] { typeof(int) })]
        int? GeneralFreeSpace { get; set; }
        /// <summary>Amount of space consumed</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Amount of space consumed",
        SerializedName = @"sizeOnDisk",
        PossibleTypes = new [] { typeof(int) })]
        int? GeneralSizeOnDisk { get; set; }
        /// <summary>Total capacity of this cloud storage</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Total capacity of this cloud storage",
        SerializedName = @"totalCapacity",
        PossibleTypes = new [] { typeof(int) })]
        int? GeneralTotalCapacity { get; set; }
        /// <summary>Type of the cloud storage server</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the cloud storage server",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralType { get; set; }
        /// <summary>Cloud server type</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Cloud server type",
        SerializedName = @"vendorType",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralVendorType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? KeyProviderId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string KeyProviderName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"security",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ISecurityAssoc) })]
        Commvault.Powershell.Models.ISecurityAssoc[] Security { get; set; }

    }
    /// Cloud Storage Details
    internal partial interface ICloudStorageDetailsInternal :
        Commvault.Powershell.Models.IIdNameInternal
    {
        Commvault.Powershell.Models.IIdName[] AssociatedPlans { get; set; }

        Commvault.Powershell.Models.IIdNameStatus[] Bucket { get; set; }
        /// <summary>Tells if cache configuration is enabled for this storage</summary>
        bool? CacheConfigurationEnable { get; set; }

        Commvault.Powershell.Models.IMetadataCache[] CacheConfigurationMetadataCache { get; set; }
        /// <summary>CacheConfigurations</summary>
        Commvault.Powershell.Models.ICacheConfigurations CacheConfigurations { get; set; }
        /// <summary>Different ways in which data can be encrypted.</summary>
        Commvault.Powershell.Models.IEncryption Encryption { get; set; }
        /// <summary>
        /// The different types of encryption keys that can be used for encrypting the data. The values are case sensitive
        /// </summary>
        string EncryptionCipher { get; set; }

        bool? EncryptionEncrypt { get; set; }
        /// <summary>
        /// Different keylengths are present for different kinds of ciphers. Blowfish,Twofish,AES and Serpent all accept both 128
        /// and 256. DES3 accepts only 192. GOST accepts only 256.
        /// </summary>
        int? EncryptionKeyLength { get; set; }

        Commvault.Powershell.Models.IIdName EncryptionKeyProvider { get; set; }
        /// <summary>CloudStorageGeneralInfo</summary>
        Commvault.Powershell.Models.ICloudStorageGeneralInfo General { get; set; }
        /// <summary>
        /// Specifies the savings in percentage that occurred due to deduplication. Only available for dedupe cloud storage pools
        /// </summary>
        string GeneralDeduplicationSavings { get; set; }
        /// <summary>Free space available on this cloud storage</summary>
        int? GeneralFreeSpace { get; set; }
        /// <summary>Amount of space consumed</summary>
        int? GeneralSizeOnDisk { get; set; }
        /// <summary>Total capacity of this cloud storage</summary>
        int? GeneralTotalCapacity { get; set; }
        /// <summary>Type of the cloud storage server</summary>
        string GeneralType { get; set; }
        /// <summary>Cloud server type</summary>
        string GeneralVendorType { get; set; }

        int? KeyProviderId { get; set; }

        string KeyProviderName { get; set; }

        Commvault.Powershell.Models.ISecurityAssoc[] Security { get; set; }

    }
}