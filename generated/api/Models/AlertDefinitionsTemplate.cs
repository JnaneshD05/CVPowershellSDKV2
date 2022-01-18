// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>AlertDefinitionsTemplate</summary>
    public partial class AlertDefinitionsTemplate :
        Commvault.Powershell.Models.IAlertDefinitionsTemplate,
        Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal
    {

        /// <summary>Internal Acessors for Locale</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal.Locale { get => (this._locale = this._locale ?? new Commvault.Powershell.Models.IdName()); set { {_locale = value;} } }

        /// <summary>Backing field for <see cref="ConsoleMessage" /> property.</summary>
        private string _consoleMessage;

        /// <summary>the message template for the console notification</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ConsoleMessage { get => this._consoleMessage; set => this._consoleMessage = value; }

        /// <summary>Backing field for <see cref="EmailMessage" /> property.</summary>
        private string _emailMessage;

        /// <summary>
        /// the message template for the email notification. Contains both email subject as well as body
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string EmailMessage { get => this._emailMessage; set => this._emailMessage = value; }

        /// <summary>Backing field for <see cref="EventViewerMessage" /> property.</summary>
        private string _eventViewerMessage;

        /// <summary>the message template for the event viewer notification</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string EventViewerMessage { get => this._eventViewerMessage; set => this._eventViewerMessage = value; }

        /// <summary>Backing field for <see cref="Locale" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _locale;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Locale { get => (this._locale = this._locale ?? new Commvault.Powershell.Models.IdName()); set => this._locale = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? LocaleId { get => ((Commvault.Powershell.Models.IIdNameInternal)Locale).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Locale).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string LocaleName { get => ((Commvault.Powershell.Models.IIdNameInternal)Locale).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Locale).Name = value ?? null; }

        /// <summary>Backing field for <see cref="WebhookMessage" /> property.</summary>
        private string _webhookMessage;

        /// <summary>the message template for the webhook notification</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string WebhookMessage { get => this._webhookMessage; set => this._webhookMessage = value; }

        /// <summary>Creates an new <see cref="AlertDefinitionsTemplate" /> instance.</summary>
        public AlertDefinitionsTemplate()
        {

        }
    }
    /// AlertDefinitionsTemplate
    public partial interface IAlertDefinitionsTemplate :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>the message template for the console notification</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the message template for the console notification",
        SerializedName = @"consoleMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ConsoleMessage { get; set; }
        /// <summary>
        /// the message template for the email notification. Contains both email subject as well as body
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the message template for the email notification. Contains both email subject as well as body",
        SerializedName = @"emailMessage",
        PossibleTypes = new [] { typeof(string) })]
        string EmailMessage { get; set; }
        /// <summary>the message template for the event viewer notification</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the message template for the event viewer notification",
        SerializedName = @"eventViewerMessage",
        PossibleTypes = new [] { typeof(string) })]
        string EventViewerMessage { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? LocaleId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string LocaleName { get; set; }
        /// <summary>the message template for the webhook notification</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the message template for the webhook notification",
        SerializedName = @"webhookMessage",
        PossibleTypes = new [] { typeof(string) })]
        string WebhookMessage { get; set; }

    }
    /// AlertDefinitionsTemplate
    internal partial interface IAlertDefinitionsTemplateInternal

    {
        /// <summary>the message template for the console notification</summary>
        string ConsoleMessage { get; set; }
        /// <summary>
        /// the message template for the email notification. Contains both email subject as well as body
        /// </summary>
        string EmailMessage { get; set; }
        /// <summary>the message template for the event viewer notification</summary>
        string EventViewerMessage { get; set; }

        Commvault.Powershell.Models.IIdName Locale { get; set; }

        int? LocaleId { get; set; }

        string LocaleName { get; set; }
        /// <summary>the message template for the webhook notification</summary>
        string WebhookMessage { get; set; }

    }
}