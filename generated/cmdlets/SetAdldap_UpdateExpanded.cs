// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Cmdlets
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Update an AD/LDAP domain</summary>
    /// <remarks>
    /// [OpenAPI] UpdateAdldap=>PUT:"/V4/LDAP/{domainId}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Set, @"Adldap_UpdateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Commvault.Powershell.Models.IGenericResp))]
    [global::Commvault.Powershell.Description(@"Update an AD/LDAP domain")]
    [global::Commvault.Powershell.Generated]
    public partial class SetAdldap_UpdateExpanded : global::System.Management.Automation.PSCmdlet,
        Commvault.Powershell.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Denotes if the domain is to be accessed via a proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Denotes if the domain is to be accessed via a proxy")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Denotes if the domain is to be accessed via a proxy",
        SerializedName = @"accessViaClient",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter AccessViaClient { get => Body.AccessViaClient ?? default(global::System.Management.Automation.SwitchParameter); set => Body.AccessViaClient = value; }

        /// <summary>
        /// List of overridden attribute mappings for the LDAP domain. Valid only if the directoryType is LDAP_SERVER.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of overridden attribute mappings for the LDAP domain. Valid only if the directoryType is LDAP_SERVER.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of overridden attribute mappings for the LDAP domain. Valid only if the directoryType is LDAP_SERVER.",
        SerializedName = @"attributeMap",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ILdapAttribute) })]
        public Commvault.Powershell.Models.ILdapAttribute[] AttributeMap { get => Body.AttributeMap ?? null /* arrayOf */; set => Body.AttributeMap = value; }

        /// <summary>Base DN for card users</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Base DN for card users")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Base DN for card users",
        SerializedName = @"baseDNForCardUsers",
        PossibleTypes = new [] { typeof(string) })]
        public string BaseDnForCardUsers { get => Body.BaseDnForCardUsers ?? null; set => Body.BaseDnForCardUsers = value; }

        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private Commvault.Powershell.Models.IUpdateAdldap _body= new Commvault.Powershell.Models.UpdateAdldap();

        /// <summary>Update the properties of an AD/LDAP</summary>
        private Commvault.Powershell.Models.IUpdateAdldap Body { get => this._body; set => this._body = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Commvault.Powershell.CommvaultPowerShell Client => Commvault.Powershell.Module.Instance.ClientAPI;

        /// <summary>Directory type of an AD/LDAP domain</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Directory type of an AD/LDAP domain")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Directory type of an AD/LDAP domain",
        SerializedName = @"directoryType",
        PossibleTypes = new [] { typeof(string) })]
        public string DirectoryType { get => Body.DirectoryType ?? null; set => Body.DirectoryType = value; }

        /// <summary>Backing field for <see cref="DomainId" /> property.</summary>
        private int _domainId;

        /// <summary>ID of the AD/LDAP domain</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "ID of the AD/LDAP domain")]
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"ID of the AD/LDAP domain",
        SerializedName = @"domainId",
        PossibleTypes = new [] { typeof(int) })]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Path)]
        public int DomainId { get => this._domainId; set => this._domainId = value; }

        /// <summary>
        /// Denotes if SSO should be enabled for the domain. Valid only for ACTIVE_DIRECTORY.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Denotes if SSO should be enabled for the domain. Valid only for ACTIVE_DIRECTORY.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Denotes if SSO should be enabled for the domain. Valid only for ACTIVE_DIRECTORY.",
        SerializedName = @"enableSSO",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter EnableSso { get => Body.EnableSso ?? default(global::System.Management.Automation.SwitchParameter); set => Body.EnableSso = value; }

        /// <summary>
        /// The fully qualified domain name that you use to identify this network resource. Required only if directoryType is LDAP_SERVER
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The fully qualified domain name that you use to identify this network resource. Required only if directoryType is LDAP_SERVER")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The fully qualified domain name that you use to identify this network resource. Required only if directoryType is LDAP_SERVER",
        SerializedName = @"host",
        PossibleTypes = new [] { typeof(string) })]
        public string Host1 { get => Body.Host ?? null; set => Body.Host = value; }

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

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// List of overridden query parameters for the LDAP domain. Valid only if the directory type is LDAP_SERVER
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of overridden query parameters for the LDAP domain. Valid only if the directory type is LDAP_SERVER")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of overridden query parameters for the LDAP domain. Valid only if the directory type is LDAP_SERVER",
        SerializedName = @"LDAPQueryParameters",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ILdapAttribute) })]
        public Commvault.Powershell.Models.ILdapAttribute[] LdapQueryParameters { get => Body.LdapQueryParameters ?? null /* arrayOf */; set => Body.LdapQueryParameters = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Commvault.Powershell.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Commvault.Powershell.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>The fully qualified domain name, for example, my.domain.example.com</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The fully qualified domain name, for example, my.domain.example.com")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The fully qualified domain name, for example, my.domain.example.com",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        public string Name { get => Body.Name ?? null; set => Body.Name = value; }

        /// <summary>
        /// The fully qualified domain name that you use to identify this network resource. Required only if directoryType is ACTIVE_DIRECTORY,
        /// OPEN_LDAP or ORACLE_DIRECTORY
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The fully qualified domain name that you use to identify this network resource. Required only if directoryType is ACTIVE_DIRECTORY, OPEN_LDAP or ORACLE_DIRECTORY ")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The fully qualified domain name that you use to identify this network resource. Required only if directoryType is ACTIVE_DIRECTORY, OPEN_LDAP or ORACLE_DIRECTORY ",
        SerializedName = @"NETBIOSName",
        PossibleTypes = new [] { typeof(string) })]
        public string NetbiosName { get => Body.NetbiosName ?? null; set => Body.NetbiosName = value; }

        /// <summary>
        /// The fully qualified domain name that you use to identify this network resource. Required only if directoryType is APPLE_DIRECTORY_SERVICE
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The fully qualified domain name that you use to identify this network resource. Required only if directoryType is APPLE_DIRECTORY_SERVICE")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The fully qualified domain name that you use to identify this network resource. Required only if directoryType is APPLE_DIRECTORY_SERVICE",
        SerializedName = @"OSXServerName",
        PossibleTypes = new [] { typeof(string) })]
        public string OsxServerName { get => Body.OsxServerName ?? null; set => Body.OsxServerName = value; }

        /// <summary>
        /// When specified, forces the cmdlet return a 'bool' given that there isn't a return type by default.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Returns true when the command succeeds")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter PassThru { get; set; }

        /// <summary>Password for the domain user. Should be in Base64 encoded format.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Password for the domain user. Should be in Base64 encoded format.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Password for the domain user. Should be in Base64 encoded format.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        public string Password { get => Body.Password ?? null; set => Body.Password = value; }

        /// <summary>
        /// The instance of the <see cref="Commvault.Powershell.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Commvault.Powershell.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>
        /// List of proxies used to connect to the domain. Available only if accessViaClient is true.
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of proxies used to connect to the domain. Available only if accessViaClient is true.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of proxies used to connect to the domain. Available only if accessViaClient is true.",
        SerializedName = @"proxies",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        public Commvault.Powershell.Models.IIdName[] Proxies { get => Body.Proxies ?? null /* arrayOf */; set => Body.Proxies = value; }

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

        /// <summary>
        /// Boolean to indicate if the app use secure LDAP. Valid only for directory types - ACTIVE_DIRECTORY, ORACLE_DIRECTORY and
        /// LDAP_SERVER.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Boolean to indicate if the app use secure LDAP. Valid only for directory types - ACTIVE_DIRECTORY, ORACLE_DIRECTORY and LDAP_SERVER.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Boolean to indicate if the app use secure LDAP. Valid only for directory types - ACTIVE_DIRECTORY, ORACLE_DIRECTORY and LDAP_SERVER.",
        SerializedName = @"useSecureLDAP",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter UseSecureLdap { get => Body.UseSecureLdap ?? default(global::System.Management.Automation.SwitchParameter); set => Body.UseSecureLdap = value; }

        /// <summary>The username for a user who has at least read permission for the domain</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The username for a user who has at least read permission for the domain")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The username for a user who has at least read permission for the domain",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        public string Username { get => Body.Username ?? null; set => Body.Username = value; }

        /// <summary>
        /// <c>overrideOnBadRequest</c> will be called before the regular onBadRequest has been processed, allowing customization
        /// of what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onBadRequest method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnBadRequest(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

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
                if (ShouldProcess($"Call remote 'UpdateAdldap' operation"))
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
                    await this.Client.UpdateAdldap(DomainId, Body, onOk, onBadRequest, this, Pipeline);
                    await ((Commvault.Powershell.Runtime.IEventListener)this).Signal(Commvault.Powershell.Runtime.Events.CmdletAfterAPICall); if( ((Commvault.Powershell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Commvault.Powershell.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  DomainId=DomainId,body=Body})
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
        /// Intializes a new instance of the <see cref="SetAdldap_UpdateExpanded" /> cmdlet class.
        /// </summary>
        public SetAdldap_UpdateExpanded()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Commvault.Powershell.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 400 (BadRequest).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onBadRequest(global::System.Net.Http.HttpResponseMessage responseMessage)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnBadRequest(responseMessage, ref _returnNow);
                // if overrideOnBadRequest has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onBadRequest - response for 400 /
                if (true == MyInvocation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
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