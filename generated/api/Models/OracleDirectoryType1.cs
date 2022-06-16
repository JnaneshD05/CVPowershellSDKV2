// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Specific properties for Oracle directory type</summary>
    public partial class OracleDirectoryType1 :
        Commvault.Powershell.Models.IOracleDirectoryType1,
        Commvault.Powershell.Models.IOracleDirectoryType1Internal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ILdapRequest" />
        /// </summary>
        private Commvault.Powershell.Models.ILdapRequest __ldapRequest = new Commvault.Powershell.Models.LdapRequest();

        /// <summary>Denotes if the domain is accessed via a proxy</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? AccessViaClient { get => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).AccessViaClient; set => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).AccessViaClient = value; }

        /// <summary>Internal Acessors for DirectoryType</summary>
        string Commvault.Powershell.Models.IOracleDirectoryType1Internal.DirectoryType { get => this._directoryType; set { {_directoryType = value;} } }

        /// <summary>Backing field for <see cref="DirectoryType" /> property.</summary>
        private string _directoryType= @"ORACLE_DIRECTORY";

        /// <summary>Oracle directory type</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DirectoryType { get => this._directoryType; }

        /// <summary>
        /// If true, the NetBIOS name will not be validated. Providing a custom name without validation may cause problems during
        /// Single Sign-On.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? DoNotValidateNetBiosName { get => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).DoNotValidateNetBiosName; set => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).DoNotValidateNetBiosName = value; }

        /// <summary>Required when configuring an existing dummy domain as LDAP/AD</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? Id { get => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).Id; set => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).Id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Domain connect name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="NetbiosName" /> property.</summary>
        private string _netbiosName;

        /// <summary>Domain shortname</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NetbiosName { get => this._netbiosName; set => this._netbiosName = value; }

        /// <summary>Password to create LDAP app, it should be base64 encoded</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Password { get => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).Password; set => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).Password = value; }

        /// <summary>
        /// List of proxies used to connect to the domain. Required if accessViaClient is true.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName[] Proxies { get => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).Proxies; set => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).Proxies = value; }

        /// <summary>Backing field for <see cref="UseSecureLdap" /> property.</summary>
        private bool? _useSecureLdap;

        /// <summary>Boolean to indicate if the app use secure LDAP</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? UseSecureLdap { get => this._useSecureLdap; set => this._useSecureLdap = value; }

        /// <summary>Username to create LDAP/AD app</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Username { get => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).Username; set => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).Username = value; }

        /// <summary>Creates an new <see cref="OracleDirectoryType1" /> instance.</summary>
        public OracleDirectoryType1()
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
            await eventListener.AssertNotNull(nameof(__ldapRequest), __ldapRequest);
            await eventListener.AssertObjectIsValid(nameof(__ldapRequest), __ldapRequest);
        }
    }
    /// Specific properties for Oracle directory type
    public partial interface IOracleDirectoryType1 :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.ILdapRequest
    {
        /// <summary>Oracle directory type</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"Oracle directory type",
        SerializedName = @"directoryType",
        PossibleTypes = new [] { typeof(string) })]
        string DirectoryType { get;  }
        /// <summary>Domain connect name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Domain connect name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Domain shortname</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Domain shortname",
        SerializedName = @"NETBIOSName",
        PossibleTypes = new [] { typeof(string) })]
        string NetbiosName { get; set; }
        /// <summary>Boolean to indicate if the app use secure LDAP</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Boolean to indicate if the app use secure LDAP",
        SerializedName = @"useSecureLDAP",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseSecureLdap { get; set; }

    }
    /// Specific properties for Oracle directory type
    internal partial interface IOracleDirectoryType1Internal :
        Commvault.Powershell.Models.ILdapRequestInternal
    {
        /// <summary>Oracle directory type</summary>
        string DirectoryType { get; set; }
        /// <summary>Domain connect name</summary>
        string Name { get; set; }
        /// <summary>Domain shortname</summary>
        string NetbiosName { get; set; }
        /// <summary>Boolean to indicate if the app use secure LDAP</summary>
        bool? UseSecureLdap { get; set; }

    }
}