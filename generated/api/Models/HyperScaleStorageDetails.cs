// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>HyperScaleStorageDetails</summary>
    public partial class HyperScaleStorageDetails :
        Commvault.Powershell.Models.IHyperScaleStorageDetails,
        Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.IIdName" />
        /// </summary>
        private Commvault.Powershell.Models.IIdName __idName = new Commvault.Powershell.Models.IdName();

        /// <summary>Backing field for <see cref="AssociatedPlans" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _associatedPlans;

        /// <summary>List of plans associated with this HyperScale storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] AssociatedPlans { get => this._associatedPlans; set => this._associatedPlans = value; }

        /// <summary>Internal Acessors for Encryption</summary>
        Commvault.Powershell.Models.IEncryption Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal.Encryption { get => (this._encryption = this._encryption ?? new Commvault.Powershell.Models.Encryption()); set { {_encryption = value;} } }

        /// <summary>Internal Acessors for EncryptionKeyProvider</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal.EncryptionKeyProvider { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProvider; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProvider = value; }

        /// <summary>Internal Acessors for General</summary>
        Commvault.Powershell.Models.IHyperScaleStorageGeneralInfo Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal.General { get => (this._general = this._general ?? new Commvault.Powershell.Models.HyperScaleStorageGeneralInfo()); set { {_general = value;} } }

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
        private Commvault.Powershell.Models.IHyperScaleStorageGeneralInfo _general;

        /// <summary>HyperScaleStorageGeneralInfo</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IHyperScaleStorageGeneralInfo General { get => (this._general = this._general ?? new Commvault.Powershell.Models.HyperScaleStorageGeneralInfo()); set => this._general = value; }

        /// <summary>Specifies the savings in percentage that occurred due to deduplication.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GeneralDeduplicationSavings { get => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).DeduplicationSavings; set => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).DeduplicationSavings = value ?? null; }

        /// <summary>The path of the disk storage area in which the data will be stored.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GeneralDevicePath { get => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).DevicePath; set => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).DevicePath = value ?? null; }

        /// <summary>Library Name of HyperScale Storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GeneralLibraryName { get => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).LibraryName; set => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).LibraryName = value ?? null; }

        /// <summary>Resiliency or redundancy of this HyperScale storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GeneralResiliency { get => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).Resiliency; set => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).Resiliency = value ?? null; }

        /// <summary>The total amount of data stored on the disk after deduplication and compression</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? GeneralSizeOndisk { get => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).SizeOndisk; set => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).SizeOndisk = value ?? default(int); }

        /// <summary>
        /// The status of the hyperscale storage pool - whether the storage pool is online or offline
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GeneralStatus { get => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).Status; set => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).Status = value ?? null; }

        /// <summary>The total storage capacity of the selected HyperScale Storage Pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? GeneralTotalCapacity { get => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).TotalCapacity; set => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).TotalCapacity = value ?? default(int); }

        /// <summary>The total free space available in the HyperScale storage pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? GeneralTotalFreeSpace { get => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).TotalFreeSpace; set => ((Commvault.Powershell.Models.IHyperScaleStorageGeneralInfoInternal)General).TotalFreeSpace = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? Id { get => ((Commvault.Powershell.Models.IIdNameInternal)__idName).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)__idName).Id = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? KeyProviderId { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderId; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string KeyProviderName { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderName; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Name { get => ((Commvault.Powershell.Models.IIdNameInternal)__idName).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)__idName).Name = value; }

        /// <summary>Backing field for <see cref="Nodes" /> property.</summary>
        private Commvault.Powershell.Models.IIdNameStatus[] _nodes;

        /// <summary>List of disks with the Linux MediaAgent</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdNameStatus[] Nodes { get => this._nodes; set => this._nodes = value; }

        /// <summary>Backing field for <see cref="Security" /> property.</summary>
        private Commvault.Powershell.Models.ISecurityAssoc[] _security;

        /// <summary>
        /// List of users or user groups each having a specific set of roles that determine the kind of operations they can perform
        /// on hyperscale storage
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.ISecurityAssoc[] Security { get => this._security; set => this._security = value; }

        /// <summary>Creates an new <see cref="HyperScaleStorageDetails" /> instance.</summary>
        public HyperScaleStorageDetails()
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
    /// HyperScaleStorageDetails
    public partial interface IHyperScaleStorageDetails :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.IIdName
    {
        /// <summary>List of plans associated with this HyperScale storage</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of plans associated with this HyperScale storage",
        SerializedName = @"associatedPlans",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] AssociatedPlans { get; set; }
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
        /// <summary>Specifies the savings in percentage that occurred due to deduplication.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the savings in percentage that occurred due to deduplication.",
        SerializedName = @"deduplicationSavings",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralDeduplicationSavings { get; set; }
        /// <summary>The path of the disk storage area in which the data will be stored.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The path of the disk storage area in which the data will be stored.",
        SerializedName = @"devicePath",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralDevicePath { get; set; }
        /// <summary>Library Name of HyperScale Storage</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Library Name of HyperScale Storage",
        SerializedName = @"libraryName",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralLibraryName { get; set; }
        /// <summary>Resiliency or redundancy of this HyperScale storage</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resiliency or redundancy of this HyperScale storage",
        SerializedName = @"resiliency",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralResiliency { get; set; }
        /// <summary>The total amount of data stored on the disk after deduplication and compression</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total amount of data stored on the disk after deduplication and compression",
        SerializedName = @"sizeOndisk",
        PossibleTypes = new [] { typeof(int) })]
        int? GeneralSizeOndisk { get; set; }
        /// <summary>
        /// The status of the hyperscale storage pool - whether the storage pool is online or offline
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the hyperscale storage pool - whether the storage pool is online or offline",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralStatus { get; set; }
        /// <summary>The total storage capacity of the selected HyperScale Storage Pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total storage capacity of the selected HyperScale Storage Pool",
        SerializedName = @"totalCapacity",
        PossibleTypes = new [] { typeof(int) })]
        int? GeneralTotalCapacity { get; set; }
        /// <summary>The total free space available in the HyperScale storage pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total free space available in the HyperScale storage pool",
        SerializedName = @"totalFreeSpace",
        PossibleTypes = new [] { typeof(int) })]
        int? GeneralTotalFreeSpace { get; set; }

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
        /// <summary>List of disks with the Linux MediaAgent</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of disks with the Linux MediaAgent",
        SerializedName = @"nodes",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdNameStatus) })]
        Commvault.Powershell.Models.IIdNameStatus[] Nodes { get; set; }
        /// <summary>
        /// List of users or user groups each having a specific set of roles that determine the kind of operations they can perform
        /// on hyperscale storage
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of users or user groups each having a specific set of roles that determine the kind of operations they can perform on hyperscale storage",
        SerializedName = @"security",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ISecurityAssoc) })]
        Commvault.Powershell.Models.ISecurityAssoc[] Security { get; set; }

    }
    /// HyperScaleStorageDetails
    internal partial interface IHyperScaleStorageDetailsInternal :
        Commvault.Powershell.Models.IIdNameInternal
    {
        /// <summary>List of plans associated with this HyperScale storage</summary>
        Commvault.Powershell.Models.IIdName[] AssociatedPlans { get; set; }
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
        /// <summary>HyperScaleStorageGeneralInfo</summary>
        Commvault.Powershell.Models.IHyperScaleStorageGeneralInfo General { get; set; }
        /// <summary>Specifies the savings in percentage that occurred due to deduplication.</summary>
        string GeneralDeduplicationSavings { get; set; }
        /// <summary>The path of the disk storage area in which the data will be stored.</summary>
        string GeneralDevicePath { get; set; }
        /// <summary>Library Name of HyperScale Storage</summary>
        string GeneralLibraryName { get; set; }
        /// <summary>Resiliency or redundancy of this HyperScale storage</summary>
        string GeneralResiliency { get; set; }
        /// <summary>The total amount of data stored on the disk after deduplication and compression</summary>
        int? GeneralSizeOndisk { get; set; }
        /// <summary>
        /// The status of the hyperscale storage pool - whether the storage pool is online or offline
        /// </summary>
        string GeneralStatus { get; set; }
        /// <summary>The total storage capacity of the selected HyperScale Storage Pool</summary>
        int? GeneralTotalCapacity { get; set; }
        /// <summary>The total free space available in the HyperScale storage pool</summary>
        int? GeneralTotalFreeSpace { get; set; }

        int? KeyProviderId { get; set; }

        string KeyProviderName { get; set; }
        /// <summary>List of disks with the Linux MediaAgent</summary>
        Commvault.Powershell.Models.IIdNameStatus[] Nodes { get; set; }
        /// <summary>
        /// List of users or user groups each having a specific set of roles that determine the kind of operations they can perform
        /// on hyperscale storage
        /// </summary>
        Commvault.Powershell.Models.ISecurityAssoc[] Security { get; set; }

    }
}