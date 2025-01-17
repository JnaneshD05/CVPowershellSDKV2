// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Different ways in which data can be encrypted.</summary>
    public partial class Encryption :
        Commvault.Powershell.Models.IEncryption,
        Commvault.Powershell.Models.IEncryptionInternal
    {

        /// <summary>Backing field for <see cref="Cipher" /> property.</summary>
        private string _cipher;

        /// <summary>
        /// The different types of encryption keys that can be used for encrypting the data. The values are case sensitive
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Cipher { get => this._cipher; set => this._cipher = value; }

        /// <summary>Internal Acessors for KeyProvider</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IEncryptionInternal.KeyProvider { get => (this._keyProvider = this._keyProvider ?? new Commvault.Powershell.Models.IdName()); set { {_keyProvider = value;} } }

        /// <summary>Backing field for <see cref="Encrypt" /> property.</summary>
        private bool? _encrypt;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Encrypt { get => this._encrypt; set => this._encrypt = value; }

        /// <summary>Backing field for <see cref="KeyLength" /> property.</summary>
        private int? _keyLength;

        /// <summary>
        /// Different keylengths are present for different kinds of ciphers. Blowfish,Twofish,AES and Serpent all accept both 128
        /// and 256. DES3 accepts only 192. GOST accepts only 256.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? KeyLength { get => this._keyLength; set => this._keyLength = value; }

        /// <summary>Backing field for <see cref="KeyProvider" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _keyProvider;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName KeyProvider { get => (this._keyProvider = this._keyProvider ?? new Commvault.Powershell.Models.IdName()); set => this._keyProvider = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? KeyProviderId { get => ((Commvault.Powershell.Models.IIdNameInternal)KeyProvider).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)KeyProvider).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string KeyProviderName { get => ((Commvault.Powershell.Models.IIdNameInternal)KeyProvider).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)KeyProvider).Name = value ?? null; }

        /// <summary>Creates an new <see cref="Encryption" /> instance.</summary>
        public Encryption()
        {

        }
    }
    /// Different ways in which data can be encrypted.
    public partial interface IEncryption :
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
        string Cipher { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"encrypt",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Encrypt { get; set; }
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
        int? KeyLength { get; set; }

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

    }
    /// Different ways in which data can be encrypted.
    internal partial interface IEncryptionInternal

    {
        /// <summary>
        /// The different types of encryption keys that can be used for encrypting the data. The values are case sensitive
        /// </summary>
        string Cipher { get; set; }

        bool? Encrypt { get; set; }
        /// <summary>
        /// Different keylengths are present for different kinds of ciphers. Blowfish,Twofish,AES and Serpent all accept both 128
        /// and 256. DES3 accepts only 192. GOST accepts only 256.
        /// </summary>
        int? KeyLength { get; set; }

        Commvault.Powershell.Models.IIdName KeyProvider { get; set; }

        int? KeyProviderId { get; set; }

        string KeyProviderName { get; set; }

    }
}