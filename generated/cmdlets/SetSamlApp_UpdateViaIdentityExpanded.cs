// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Cmdlets
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Updates details of existing SAML app</summary>
    /// <remarks>
    /// [OpenAPI] UpdateSamlApp=>PUT:"/V4/SAML/{name}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Set, @"SamlApp_UpdateViaIdentityExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Commvault.Powershell.Models.IGenericResp))]
    [global::Commvault.Powershell.Description(@"Updates details of existing SAML app")]
    [global::Commvault.Powershell.Generated]
    public partial class SetSamlApp_UpdateViaIdentityExpanded : global::System.Management.Automation.PSCmdlet,
        Commvault.Powershell.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Companies associated with SAML</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Companies associated with SAML")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Companies associated with SAML",
        SerializedName = @"companies",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        public Commvault.Powershell.Models.IIdName[] AssociationCompanies { get => Body.AssociationCompanies ?? null /* arrayOf */; set => Body.AssociationCompanies = value; }

        /// <summary>Domains associated with SAML</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Domains associated with SAML")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Domains associated with SAML",
        SerializedName = @"domains",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        public Commvault.Powershell.Models.IIdName[] AssociationDomains { get => Body.AssociationDomains ?? null /* arrayOf */; set => Body.AssociationDomains = value; }

        /// <summary>Email suffixes associated with SAML</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Email suffixes associated with SAML")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email suffixes associated with SAML",
        SerializedName = @"emailSuffixes",
        PossibleTypes = new [] { typeof(string) })]
        public string[] AssociationEmailSuffixes { get => Body.AssociationEmailSuffixes ?? null /* arrayOf */; set => Body.AssociationEmailSuffixes = value; }

        /// <summary>user groups associated with SAML</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "user groups associated with SAML")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"user groups associated with SAML",
        SerializedName = @"userGroups",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        public Commvault.Powershell.Models.IIdName[] AssociationUserGroups { get => Body.AssociationUserGroups ?? null /* arrayOf */; set => Body.AssociationUserGroups = value; }

        /// <summary>attribute mapping details</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "attribute mapping details")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"attribute mapping details",
        SerializedName = @"attributeMappings",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ISamlAttributes) })]
        public Commvault.Powershell.Models.ISamlAttributes[] AttributeMappings { get => Body.AttributeMappings ?? null /* arrayOf */; set => Body.AttributeMappings = value; }

        /// <summary>
        /// This auto-creates non-existing user if the user detail match with the identity rule.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "This auto-creates non-existing user if the user detail match with the identity rule.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This auto-creates non-existing user if the user detail match with the identity rule.",
        SerializedName = @"autoCreateUser",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter AutoCreateUser { get => Body.AutoCreateUser ?? default(global::System.Management.Automation.SwitchParameter); set => Body.AutoCreateUser = value; }

        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private Commvault.Powershell.Models.ISamlUpdate _body= new Commvault.Powershell.Models.SamlUpdate();

        /// <summary>Updates SAML details</summary>
        private Commvault.Powershell.Models.ISamlUpdate Body { get => this._body; set => this._body = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Commvault.Powershell.CommvaultPowerShell Client => Commvault.Powershell.Module.Instance.ClientAPI;

        /// <summary>SAML description</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "SAML description")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SAML description",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        public string Description { get => Body.Description ?? null; set => Body.Description = value; }

        /// <summary>Boolean to indicate whether SAML is enabled.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Boolean to indicate whether SAML is enabled.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Boolean to indicate whether SAML is enabled.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter Enabled { get => Body.Enabled ?? default(global::System.Management.Automation.SwitchParameter); set => Body.Enabled = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Runtime)]
        public Commvault.Powershell.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Runtime)]
        public Commvault.Powershell.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>IDP certificate public key</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "IDP certificate public key")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"IDP certificate public key",
        SerializedName = @"certificateData",
        PossibleTypes = new [] { typeof(string) })]
        public string IdentityProviderMetaDataCertificateData { get => Body.IdentityProviderMetaDataCertificateData ?? null; set => Body.IdentityProviderMetaDataCertificateData = value; }

        /// <summary>Identity provider entity</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Identity provider entity")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity provider entity",
        SerializedName = @"entityId",
        PossibleTypes = new [] { typeof(string) })]
        public string IdentityProviderMetaDataEntityId { get => Body.IdentityProviderMetaDataEntityId ?? null; set => Body.IdentityProviderMetaDataEntityId = value; }

        /// <summary>Identity Provider log-out URL</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Identity Provider log-out URL")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity Provider log-out URL",
        SerializedName = @"logoutUrl",
        PossibleTypes = new [] { typeof(string) })]
        public string IdentityProviderMetaDataLogoutUrl { get => Body.IdentityProviderMetaDataLogoutUrl ?? null; set => Body.IdentityProviderMetaDataLogoutUrl = value; }

        /// <summary>Identity provider redirect URL</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Identity provider redirect URL")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity provider redirect URL",
        SerializedName = @"redirectUrl",
        PossibleTypes = new [] { typeof(string) })]
        public string IdentityProviderMetaDataRedirectUrl { get => Body.IdentityProviderMetaDataRedirectUrl ?? null; set => Body.IdentityProviderMetaDataRedirectUrl = value; }

        /// <summary>SAML Protocol version</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "SAML Protocol version ")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SAML Protocol version ",
        SerializedName = @"SAMLProtocolVersion",
        PossibleTypes = new [] { typeof(string) })]
        public string IdentityProviderMetaDataSamlProtocolVersion { get => Body.IdentityProviderMetaDataSamlProtocolVersion ?? null; set => Body.IdentityProviderMetaDataSamlProtocolVersion = value; }

        /// <summary>Backing field for <see cref="InputObject" /> property.</summary>
        private Commvault.Powershell.Models.ICommvaultPowerShellIdentity _inputObject;

        /// <summary>Identity Parameter</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Path)]
        public Commvault.Powershell.Models.ICommvaultPowerShellIdentity InputObject { get => this._inputObject; set => this._inputObject = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Commvault.Powershell.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Commvault.Powershell.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>nameID in SAML assertion subject is used to perform login.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "nameID in SAML assertion subject is used to perform login.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"nameID in SAML assertion subject is used to perform login.",
        SerializedName = @"nameIDAttribute",
        PossibleTypes = new [] { typeof(string) })]
        public string NameIdAttribute { get => Body.NameIdAttribute ?? null; set => Body.NameIdAttribute = value; }

        /// <summary>
        /// The instance of the <see cref="Commvault.Powershell.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Commvault.Powershell.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>certificate alias name</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "certificate alias name")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"certificate alias name",
        SerializedName = @"aliasName",
        PossibleTypes = new [] { typeof(string) })]
        public string ServiceProviderMetaDataAliasName { get => Body.ServiceProviderMetaDataAliasName ?? null; set => Body.ServiceProviderMetaDataAliasName = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"autoGenerateSPMetaData",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter ServiceProviderMetaDataAutoGenerateSpMetaData { get => Body.ServiceProviderMetaDataAutoGenerateSpMetaData ?? default(global::System.Management.Automation.SwitchParameter); set => Body.ServiceProviderMetaDataAutoGenerateSpMetaData = value; }

        /// <summary>certificate alias name.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "certificate alias name.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"certificate alias name.",
        SerializedName = @"certificateData",
        PossibleTypes = new [] { typeof(string) })]
        public string ServiceProviderMetaDataCertificateData { get => Body.ServiceProviderMetaDataCertificateData ?? null; set => Body.ServiceProviderMetaDataCertificateData = value; }

        /// <summary>jks file contents as byte array</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "jks file contents as byte array")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"jks file contents as byte array",
        SerializedName = @"jksFileContents",
        PossibleTypes = new [] { typeof(string) })]
        public string[] ServiceProviderMetaDataJksFileContents { get => Body.ServiceProviderMetaDataJksFileContents ?? null /* arrayOf */; set => Body.ServiceProviderMetaDataJksFileContents = value; }

        /// <summary>key store password.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "key store password.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"key store password.",
        SerializedName = @"JKSPrivateKey",
        PossibleTypes = new [] { typeof(string) })]
        public string ServiceProviderMetaDataJksPrivateKey { get => Body.ServiceProviderMetaDataJksPrivateKey ?? null; set => Body.ServiceProviderMetaDataJksPrivateKey = value; }

        /// <summary>jks contents key store password.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "jks contents key store password.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"jks contents key store password.",
        SerializedName = @"keyStorePassword",
        PossibleTypes = new [] { typeof(string) })]
        public string ServiceProviderMetaDataKeyStorePassword { get => Body.ServiceProviderMetaDataKeyStorePassword ?? null; set => Body.ServiceProviderMetaDataKeyStorePassword = value; }

        /// <summary>certificate private key password</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "certificate private key password")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"certificate private key password",
        SerializedName = @"privateKeyPassword",
        PossibleTypes = new [] { typeof(string) })]
        public string ServiceProviderMetaDataPrivateKeyPassword { get => Body.ServiceProviderMetaDataPrivateKeyPassword ?? null; set => Body.ServiceProviderMetaDataPrivateKeyPassword = value; }

        /// <summary>web console URL.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "web console URL.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"web console URL.",
        SerializedName = @"serviceProviderEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        public string ServiceProviderMetaDataServiceProviderEndpoint { get => Body.ServiceProviderMetaDataServiceProviderEndpoint ?? null; set => Body.ServiceProviderMetaDataServiceProviderEndpoint = value; }

        /// <summary>web console URL list.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "web console URL list.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"web console URL list.",
        SerializedName = @"spAliases",
        PossibleTypes = new [] { typeof(string) })]
        public string[] ServiceProviderMetaDataSpAliases { get => Body.ServiceProviderMetaDataSpAliases ?? null /* arrayOf */; set => Body.ServiceProviderMetaDataSpAliases = value; }

        /// <summary>
        /// By default, auto-created users will be associated to the Tenant Users group of the company. Add mapping to override this
        /// behaviour for a company.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "By default, auto-created users will be associated to the Tenant Users group of the company. Add mapping to override this behaviour for a company.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"By default, auto-created users will be associated to the Tenant Users group of the company. Add mapping to override this behaviour for a company.",
        SerializedName = @"userGroups",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ICompanyWithUserGroupAssocDetails) })]
        public Commvault.Powershell.Models.ICompanyWithUserGroupAssocDetails[] UserGroups { get => Body.UserGroups ?? null /* arrayOf */; set => Body.UserGroups = value; }

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Commvault.Powershell.Models.IGenericResp" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Commvault.Powershell.Models.IGenericResp> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Commvault.Powershell.Runtime.AttachDebugger.Break();
            }
            ((Commvault.Powershell.Runtime.IEventListener)this).Signal(Commvault.Powershell.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Commvault.Powershell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((Commvault.Powershell.Runtime.IEventListener)this).Signal(Commvault.Powershell.Runtime.Events.CmdletEndProcessing).Wait(); if( ((Commvault.Powershell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Commvault.Powershell.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Commvault.Powershell.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Commvault.Powershell.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Commvault.Powershell.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Commvault.Powershell.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data, new[] { data.Message });
                        return ;
                    }
                    case Commvault.Powershell.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Commvault.Powershell.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                await Commvault.Powershell.Module.Instance.Signal(id, token, messageData, (i,t,m) => ((Commvault.Powershell.Runtime.IEventListener)this).Signal(i,t,()=> Commvault.Powershell.Runtime.EventDataConverter.ConvertFrom( m() ) as Commvault.Powershell.Runtime.EventData ), InvocationInformation, this.ParameterSetName, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Commvault.Powershell.Runtime.IEventListener)this).Signal(Commvault.Powershell.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Commvault.Powershell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                if (ShouldProcess($"Call remote 'UpdateSamlApp' operation"))
                {
                    using( var asyncCommandRuntime = new Commvault.Powershell.Runtime.PowerShell.AsyncCommandRuntime(this, ((Commvault.Powershell.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((Commvault.Powershell.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Commvault.Powershell.Runtime.IEventListener)this).Signal(Commvault.Powershell.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Commvault.Powershell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Commvault.Powershell.Runtime.IEventListener)this).Signal(Commvault.Powershell.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Commvault.Powershell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Commvault.Powershell.Runtime.IEventListener)this).Signal(Commvault.Powershell.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Commvault.Powershell.Runtime.IEventListener)this).Signal(Commvault.Powershell.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((Commvault.Powershell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((Commvault.Powershell.Runtime.IEventListener)this).Signal(Commvault.Powershell.Runtime.Events.CmdletGetPipeline); if( ((Commvault.Powershell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Commvault.Powershell.Module.Instance.CreatePipeline(InvocationInformation, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Commvault.Powershell.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Commvault.Powershell.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Commvault.Powershell.Runtime.IEventListener)this).Signal(Commvault.Powershell.Runtime.Events.CmdletBeforeAPICall); if( ((Commvault.Powershell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // try to call with PATH parameters from Input Object
                    if (null == InputObject.Name)
                    {
                        ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.Name"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                    }
                    await this.Client.UpdateSamlApp(InputObject.Name ?? null, Body, onOk, this, Pipeline);
                    await ((Commvault.Powershell.Runtime.IEventListener)this).Signal(Commvault.Powershell.Runtime.Events.CmdletAfterAPICall); if( ((Commvault.Powershell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Commvault.Powershell.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  body=Body})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Commvault.Powershell.Runtime.IEventListener)this).Signal(Commvault.Powershell.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="SetSamlApp_UpdateViaIdentityExpanded" /> cmdlet class.
        /// </summary>
        public SetSamlApp_UpdateViaIdentityExpanded()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Commvault.Powershell.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Commvault.Powershell.Models.IGenericResp" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Commvault.Powershell.Models.IGenericResp> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // (await response) // should be Commvault.Powershell.Models.IGenericResp
                WriteObject((await response));
            }
        }
    }
}