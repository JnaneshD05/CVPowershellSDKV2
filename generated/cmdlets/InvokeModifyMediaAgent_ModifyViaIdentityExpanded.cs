// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Cmdlets
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Modify the properties of an existing media agent</summary>
    /// <remarks>
    /// [OpenAPI] ModifyMediaAgent=>PUT:"/V4/mediaAgent/{mediaAgentId}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsLifecycle.Invoke, @"ModifyMediaAgent_ModifyViaIdentityExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Commvault.Powershell.Models.IGenericResp))]
    [global::Commvault.Powershell.Description(@"Modify the properties of an existing media agent")]
    [global::Commvault.Powershell.Generated]
    public partial class InvokeModifyMediaAgent_ModifyViaIdentityExpanded : global::System.Management.Automation.PSCmdlet,
        Commvault.Powershell.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private Commvault.Powershell.Models.IUpdateMediaAgent _body= new Commvault.Powershell.Models.UpdateMediaAgent();

        private Commvault.Powershell.Models.IUpdateMediaAgent Body { get => this._body; set => this._body = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Commvault.Powershell.CommvaultPowerShell Client => Commvault.Powershell.Module.Instance.ClientAPI;

        /// <summary>Determines if the media agent is currently enabled or disabled.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Determines if the media agent is currently enabled or disabled.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Determines if the media agent is currently enabled or disabled.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter ControlEnabled { get => Body.ControlEnabled ?? default(global::System.Management.Automation.SwitchParameter); set => Body.ControlEnabled = value; }

        /// <summary>
        /// Specifies whether the MediaAgent is available for data protection, data recovery and auxiliary copy operations.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies whether the MediaAgent is available for data protection, data recovery and auxiliary copy operations.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies whether the MediaAgent is available for data protection, data recovery and auxiliary copy operations.",
        SerializedName = @"maintenanceMode",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter ControlMaintenanceMode { get => Body.ControlMaintenanceMode ?? default(global::System.Management.Automation.SwitchParameter); set => Body.ControlMaintenanceMode = value; }

        /// <summary>
        /// Allows optimization for concurrent LAN backups. If set to true, default value for parallel data transfer operations will
        /// be 100. If set to false, default value of parallel data transfer operations will be set to 25.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Allows optimization for concurrent LAN backups. If set to true, default value for parallel data transfer operations will be 100. If set to false, default value of parallel data transfer operations will be set to 25.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Allows optimization for concurrent LAN backups. If set to true, default value for parallel data transfer operations will be 100. If set to false, default value of parallel data transfer operations will be set to 25.",
        SerializedName = @"optimizeForConcurrentLANBackups",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter ControlOptimizeForConcurrentLanBackups { get => Body.ControlOptimizeForConcurrentLanBackups ?? default(global::System.Management.Automation.SwitchParameter); set => Body.ControlOptimizeForConcurrentLanBackups = value; }

        /// <summary>Specifies the number of parallel data operations that can take place.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Specifies the number of parallel data operations that can take place. ")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the number of parallel data operations that can take place. ",
        SerializedName = @"parallelDataTransferOperations",
        PossibleTypes = new [] { typeof(int) })]
        public int ControlParallelDataTransferOperations { get => Body.ControlParallelDataTransferOperations ?? default(int); set => Body.ControlParallelDataTransferOperations = value; }

        /// <summary>
        /// If set to true, ransomware protection against the media agent is enabled. If set to false, ransomware protection against
        /// media agent is disabled.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "If set to true, ransomware protection against the media agent is enabled. If set to false, ransomware protection against media agent is disabled.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If set to true, ransomware protection against the media agent is enabled. If set to false, ransomware protection against media agent is disabled.",
        SerializedName = @"ransomwareProtection",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter ControlRansomwareProtection { get => Body.ControlRansomwareProtection ?? default(global::System.Management.Automation.SwitchParameter); set => Body.ControlRansomwareProtection = value; }

        /// <summary>Provides the media agent with a new description.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Provides the media agent with a new description.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provides the media agent with a new description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        public string Description { get => Body.Description ?? null; set => Body.Description = value; }

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

        /// <summary>Path where the index cache is maintained.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Path where the index cache is maintained.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path where the index cache is maintained.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        public string IndexCachePath { get => Body.IndexCachePath ?? null; set => Body.IndexCachePath = value; }

        /// <summary>Backing field for <see cref="InputObject" /> property.</summary>
        private Commvault.Powershell.Models.ICommvaultPowerShellIdentity _inputObject;

        /// <summary>Identity Parameter</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Path)]
        public Commvault.Powershell.Models.ICommvaultPowerShellIdentity InputObject { get => this._inputObject; set => this._inputObject = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>This tag determines if the logs cache has been enabled or not.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "This tag determines if the logs cache has been enabled or not. ")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This tag determines if the logs cache has been enabled or not. ",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter LogCacheEnabled { get => Body.LogCacheEnabled ?? default(global::System.Management.Automation.SwitchParameter); set => Body.LogCacheEnabled = value; }

        /// <summary>If the logs cache is enabled, this tag gives the path to store the logs cache.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "If the logs cache is enabled, this tag gives the path to store the logs cache.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If the logs cache is enabled, this tag gives the path to store the logs cache.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        public string LogCachePath { get => Body.LogCachePath ?? null; set => Body.LogCachePath = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Commvault.Powershell.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Commvault.Powershell.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// When specified, forces the cmdlet return a 'bool' given that there isn't a return type by default.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Returns true when the command succeeds")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter PassThru { get; set; }

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

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        public int RoleId { get => Body.RoleId ?? default(int); set => Body.RoleId = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        public string RoleName { get => Body.RoleName ?? null; set => Body.RoleName = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        public int UserGroupId { get => Body.UserGroupId ?? default(int); set => Body.UserGroupId = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        public string UserGroupName { get => Body.UserGroupName ?? null; set => Body.UserGroupName = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        public int UserId { get => Body.UserId ?? default(int); set => Body.UserId = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        public string UserName { get => Body.UserName ?? null; set => Body.UserName = value; }

        /// <summary>
        /// <c>overrideOnBadRequest</c> will be called before the regular onBadRequest has been processed, allowing customization
        /// of what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onBadRequest method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnBadRequest(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnNotFound</c> will be called before the regular onNotFound has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onNotFound method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnNotFound(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

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

        /// <summary>
        /// Intializes a new instance of the <see cref="InvokeModifyMediaAgent_ModifyViaIdentityExpanded" /> cmdlet class.
        /// </summary>
        public InvokeModifyMediaAgent_ModifyViaIdentityExpanded()
        {

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
                if (ShouldProcess($"Call remote 'ModifyMediaAgent' operation"))
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
                    if (null == InputObject.MediaAgentId)
                    {
                        ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.MediaAgentId"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                    }
                    await this.Client.ModifyMediaAgent(InputObject.MediaAgentId ?? default(int), Body, onOk, onBadRequest, onNotFound, this, Pipeline);
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

        /// <summary>a delegate that is called when the remote service returns 404 (NotFound).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onNotFound(global::System.Net.Http.HttpResponseMessage responseMessage)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnNotFound(responseMessage, ref _returnNow);
                // if overrideOnNotFound has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onNotFound - response for 404 /
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