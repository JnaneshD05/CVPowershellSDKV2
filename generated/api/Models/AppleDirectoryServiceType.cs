// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Specific properties for apple directory service type</summary>
    public partial class AppleDirectoryServiceType :
        Commvault.Powershell.Models.IAppleDirectoryServiceType,
        Commvault.Powershell.Models.IAppleDirectoryServiceTypeInternal,
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
        string Commvault.Powershell.Models.IAppleDirectoryServiceTypeInternal.DirectoryType { get => this._directoryType; set { {_directoryType = value;} } }

        /// <summary>Backing field for <see cref="DirectoryType" /> property.</summary>
        private string _directoryType= @"APPLE_DIRECTORY_SERVICE";

        /// <summary>Apple directory service type</summary>
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

        /// <summary>Backing field for <see cref="OsxServerName" /> property.</summary>
        private string _osxServerName;

        /// <summary>Domain shortname to create apple directory type app</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string OsxServerName { get => this._osxServerName; set => this._osxServerName = value; }

        /// <summary>Password to create LDAP app, it should be base64 encoded</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Password { get => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).Password; set => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).Password = value; }

        /// <summary>
        /// List of proxies used to connect to the domain. Required if accessViaClient is true.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName[] Proxies { get => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).Proxies; set => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).Proxies = value; }

        /// <summary>Username to create LDAP/AD app</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Username { get => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).Username; set => ((Commvault.Powershell.Models.ILdapRequestInternal)__ldapRequest).Username = value; }

        /// <summary>Creates an new <see cref="AppleDirectoryServiceType" /> instance.</summary>
        public AppleDirectoryServiceType()
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
    /// Specific properties for apple directory service type
    public partial interface IAppleDirectoryServiceType :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.ILdapRequest
    {
        /// <summary>Apple directory service type</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"Apple directory service type",
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
        /// <summary>Domain shortname to create apple directory type app</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Domain shortname to create apple directory type app",
        SerializedName = @"OSXServerName",
        PossibleTypes = new [] { typeof(string) })]
        string OsxServerName { get; set; }

    }
    /// Specific properties for apple directory service type
    internal partial interface IAppleDirectoryServiceTypeInternal :
        Commvault.Powershell.Models.ILdapRequestInternal
    {
        /// <summary>Apple directory service type</summary>
        string DirectoryType { get; set; }
        /// <summary>Domain connect name</summary>
        string Name { get; set; }
        /// <summary>Domain shortname to create apple directory type app</summary>
        string OsxServerName { get; set; }

    }
}