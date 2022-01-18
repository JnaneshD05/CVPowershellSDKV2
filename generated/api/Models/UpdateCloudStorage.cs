// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class UpdateCloudStorage :
        Commvault.Powershell.Models.IUpdateCloudStorage,
        Commvault.Powershell.Models.IUpdateCloudStorageInternal
    {

        /// <summary>Internal Acessors for Encryption</summary>
        Commvault.Powershell.Models.IEncryption Commvault.Powershell.Models.IUpdateCloudStorageInternal.Encryption { get => (this._encryption = this._encryption ?? new Commvault.Powershell.Models.Encryption()); set { {_encryption = value;} } }

        /// <summary>Internal Acessors for EncryptionKeyProvider</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IUpdateCloudStorageInternal.EncryptionKeyProvider { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProvider; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProvider = value; }

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

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? KeyProviderId { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderId; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string KeyProviderName { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderName; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderName = value ?? null; }

        /// <summary>Backing field for <see cref="NewName" /> property.</summary>
        private string _newName;

        /// <summary>change the name of the cloud storage</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NewName { get => this._newName; set => this._newName = value; }

        /// <summary>Backing field for <see cref="Security" /> property.</summary>
        private Commvault.Powershell.Models.IUpdateSecurityAssoc[] _security;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IUpdateSecurityAssoc[] Security { get => this._security; set => this._security = value; }

        /// <summary>Creates an new <see cref="UpdateCloudStorage" /> instance.</summary>
        public UpdateCloudStorage()
        {

        }
    }
    public partial interface IUpdateCloudStorage :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
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
        /// <summary>change the name of the cloud storage</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"change the name of the cloud storage",
        SerializedName = @"newName",
        PossibleTypes = new [] { typeof(string) })]
        string NewName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"security",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IUpdateSecurityAssoc) })]
        Commvault.Powershell.Models.IUpdateSecurityAssoc[] Security { get; set; }

    }
    internal partial interface IUpdateCloudStorageInternal

    {
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

        int? KeyProviderId { get; set; }

        string KeyProviderName { get; set; }
        /// <summary>change the name of the cloud storage</summary>
        string NewName { get; set; }

        Commvault.Powershell.Models.IUpdateSecurityAssoc[] Security { get; set; }

    }
}