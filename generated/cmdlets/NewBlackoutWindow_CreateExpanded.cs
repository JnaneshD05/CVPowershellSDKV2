// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Cmdlets
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Create a Blackout Window</summary>
    /// <remarks>
    /// [OpenAPI] CreateBlackoutWindow=>POST:"/V4/BlackoutWindow"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"BlackoutWindow_CreateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Commvault.Powershell.Models.IIdName))]
    [global::Commvault.Powershell.Description(@"Create a Blackout Window")]
    [global::Commvault.Powershell.Generated]
    public partial class NewBlackoutWindow_CreateExpanded : global::System.Management.Automation.PSCmdlet,
        Commvault.Powershell.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Refers to backup types to include in the blackout window</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Refers to backup types to include in the blackout window")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Refers to backup types to include in the blackout window",
        SerializedName = @"backupOperations",
        PossibleTypes = new [] { typeof(string) })]
        public string[] BackupOperations { get => Body.BackupOperations ?? null /* arrayOf */; set => Body.BackupOperations = value; }

        /// <summary>the blackout window is no longer in effect from this point on.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "the blackout window is no longer in effect from this point on.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the blackout window is no longer in effect from this point on.",
        SerializedName = @"end",
        PossibleTypes = new [] { typeof(long) })]
        public long BetweenDateEnd { get => Body.BetweenDateEnd ?? default(long); set => Body.BetweenDateEnd = value; }

        /// <summary>the blackout window comes into effect at this point.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "the blackout window comes into effect at this point.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the blackout window comes into effect at this point.",
        SerializedName = @"start",
        PossibleTypes = new [] { typeof(long) })]
        public long BetweenDateStart { get => Body.BetweenDateStart ?? default(long); set => Body.BetweenDateStart = value; }

        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private Commvault.Powershell.Models.ICreateBlackoutWindow _body= new Commvault.Powershell.Models.CreateBlackoutWindow();

        /// <summary>
        /// betweenDates refers to the dates where the blackout window will be in effect. Dates have to be given in unix time format.
        /// time has to be provided in seconds. company refers to company to which the blackout window is associated.Id is given first
        /// preference if both are id and name are provided.
        /// </summary>
        private Commvault.Powershell.Models.ICreateBlackoutWindow Body { get => this._body; set => this._body = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Commvault.Powershell.CommvaultPowerShell Client => Commvault.Powershell.Module.Instance.ClientAPI;

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        public int CompanyId { get => Body.CompanyId ?? default(int); set => Body.CompanyId = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        public string CompanyName { get => Body.CompanyName ?? null; set => Body.CompanyName = value; }

        /// <summary>Days of the week when the blackout window will be in effect.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Days of the week when the blackout window will be in effect.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Days of the week when the blackout window will be in effect.",
        SerializedName = @"days",
        PossibleTypes = new [] { typeof(string) })]
        public string[] Days { get => Body.Days ?? null /* arrayOf */; set => Body.Days = value; }

        /// <summary>
        /// Allows or Denies submitting a job when the blackout window is in effect. If set to false, the job is submitted and resumed
        /// once the blackout window ends.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Allows or Denies submitting a job when the blackout window is in effect. If set to false, the job is submitted and resumed once the blackout window ends.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Allows or Denies submitting a job when the blackout window is in effect. If set to false, the job is submitted and resumed once the blackout window ends.",
        SerializedName = @"doNotSubmitJob",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter DoNotSubmitJob { get => Body.DoNotSubmitJob ?? default(global::System.Management.Automation.SwitchParameter); set => Body.DoNotSubmitJob = value; }

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
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Commvault.Powershell.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Commvault.Powershell.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Name of the blackout window to be created.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of the blackout window to be created.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the blackout window to be created.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        public string Name { get => Body.Name ?? null; set => Body.Name = value; }

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

        /// <summary>
        /// Refers to the time between which the blackout window will be in effect. It has to be provided in seconds
        /// </summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Refers to the time between which the blackout window will be in effect. It has to be provided in seconds")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Refers to the time between which the blackout window will be in effect. It has to be provided in seconds",
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IStartEnd) })]
        public Commvault.Powershell.Models.IStartEnd[] Time { get => Body.Time ?? null /* arrayOf */; set => Body.Time = value; }

        /// <summary>Refers to the weeks of the month that the blackout window will be in effect.</summary>
        [global::System.Management.Automation.AllowEmptyCollection]
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Refers to the weeks of the month that the blackout window will be in effect.")]
        [global::Commvault.Powershell.Category(global::Commvault.Powershell.ParameterCategory.Body)]
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Refers to the weeks of the month that the blackout window will be in effect.",
        SerializedName = @"weeks",
        PossibleTypes = new [] { typeof(string) })]
        public string[] Weeks { get => Body.Weeks ?? null /* arrayOf */; set => Body.Weeks = value; }

        /// <summary>
        /// <c>overrideOnBadRequest</c> will be called before the regular onBadRequest has been processed, allowing customization
        /// of what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onBadRequest method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnBadRequest(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnInternalServerError</c> will be called before the regular onInternalServerError has been processed, allowing
        /// customization of what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onInternalServerError method should be processed, or if the
        /// method should return immediately (set to true to skip further processing )</param>

        partial void overrideOnInternalServerError(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Commvault.Powershell.Models.IIdName" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Commvault.Powershell.Models.IIdName> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

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

        /// <summary>
        /// Intializes a new instance of the <see cref="NewBlackoutWindow_CreateExpanded" /> cmdlet class.
        /// </summary>
        public NewBlackoutWindow_CreateExpanded()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Commvault.Powershell.Runtime.IEventListener)this).Signal(Commvault.Powershell.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Commvault.Powershell.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                if (ShouldProcess($"Call remote 'CreateBlackoutWindow' operation"))
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
                    await this.Client.CreateBlackoutWindow(Body, onOk, onBadRequest, onInternalServerError, this, Pipeline);
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

        /// <summary>
        /// a delegate that is called when the remote service returns 500 (InternalServerError).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onInternalServerError(global::System.Net.Http.HttpResponseMessage responseMessage)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnInternalServerError(responseMessage, ref _returnNow);
                // if overrideOnInternalServerError has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onInternalServerError - response for 500 /
                if (true == MyInvocation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Commvault.Powershell.Models.IIdName" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Commvault.Powershell.Models.IIdName> response)
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
                // (await response) // should be Commvault.Powershell.Models.IIdName
                WriteObject((await response));
            }
        }
    }
}