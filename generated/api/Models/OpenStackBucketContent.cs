// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>OpenStack Object Storage</summary>
    public partial class OpenStackBucketContent :
        Commvault.Powershell.Models.IOpenStackBucketContent,
        Commvault.Powershell.Models.IOpenStackBucketContentInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ICloudStorageAdvanced" />
        /// </summary>
        private Commvault.Powershell.Models.ICloudStorageAdvanced __cloudStorageAdvanced = new Commvault.Powershell.Models.CloudStorageAdvanced();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ICloudStorageProxy" />
        /// </summary>
        private Commvault.Powershell.Models.ICloudStorageProxy __cloudStorageProxy = new Commvault.Powershell.Models.CloudStorageProxy();

        /// <summary>
        /// The access type for the cloud access path can be either read (writing to path not allowed) or read and write (writing
        /// to path allowed)
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Access { get => ((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)__cloudStorageAdvanced).Access; set => ((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)__cloudStorageAdvanced).Access = value ?? null; }

        /// <summary>Backing field for <see cref="CloudType" /> property.</summary>
        private string _cloudType= @"OpenStack Object Storage";

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CloudType { get => this._cloudType; }

        /// <summary>Internal Acessors for CloudType</summary>
        string Commvault.Powershell.Models.IOpenStackBucketContentInternal.CloudType { get => this._cloudType; set { {_cloudType = value;} } }

        /// <summary>Internal Acessors for Credentials</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IOpenStackBucketContentInternal.Credentials { get => (this._credentials = this._credentials ?? new Commvault.Powershell.Models.IdName()); set { {_credentials = value;} } }

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

        /// <summary>Enable/Disable access of bucket to a media Agent</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? Enable { get => ((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)__cloudStorageAdvanced).Enable; set => ((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)__cloudStorageAdvanced).Enable = value ?? default(bool); }

        /// <summary>Password for proxy configuration (Should be in Base64 format)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public System.Security.SecureString Password { get => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Password; set => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Password = value ?? null; }

        /// <summary>Port for proxy configuration</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? Port { get => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Port; set => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Port = value ?? default(int); }

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

        /// <summary>Username for proxy configuration</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Username { get => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Username; set => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Username = value ?? null; }

        /// <summary>Creates an new <see cref="OpenStackBucketContent" /> instance.</summary>
        public OpenStackBucketContent()
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
            await eventListener.AssertNotNull(nameof(__cloudStorageAdvanced), __cloudStorageAdvanced);
            await eventListener.AssertObjectIsValid(nameof(__cloudStorageAdvanced), __cloudStorageAdvanced);
        }
    }
    /// OpenStack Object Storage
    public partial interface IOpenStackBucketContent :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.ICloudStorageProxy,
        Commvault.Powershell.Models.ICloudStorageAdvanced
    {
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"cloudType",
        PossibleTypes = new [] { typeof(string) })]
        string CloudType { get;  }
        /// <summary>Name of container</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
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

    }
    /// OpenStack Object Storage
    internal partial interface IOpenStackBucketContentInternal :
        Commvault.Powershell.Models.ICloudStorageProxyInternal,
        Commvault.Powershell.Models.ICloudStorageAdvancedInternal
    {
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

    }
}