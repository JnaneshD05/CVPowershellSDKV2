// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>AlertDefinitonsCreate</summary>
    public partial class AlertDefinitonsCreate :
        Commvault.Powershell.Models.IAlertDefinitonsCreate,
        Commvault.Powershell.Models.IAlertDefinitonsCreateInternal
    {

        /// <summary>Backing field for <see cref="AlertTarget" /> property.</summary>
        private Commvault.Powershell.Models.IAlertDefinitionsTarget _alertTarget;

        /// <summary>AlertDefinitionsTarget</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IAlertDefinitionsTarget AlertTarget { get => (this._alertTarget = this._alertTarget ?? new Commvault.Powershell.Models.AlertDefinitionsTarget()); set => this._alertTarget = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] AlertTargetSendAlertTo { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).SendAlertTo; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).SendAlertTo = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="AlertType" /> property.</summary>
        private Commvault.Powershell.Models.IAlertDefinitionsCreateAlertType _alertType;

        /// <summary>AlertDefinitionsCreateAlertType</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IAlertDefinitionsCreateAlertType AlertType { get => (this._alertType = this._alertType ?? new Commvault.Powershell.Models.AlertDefinitionsCreateAlertType()); set => this._alertType = value; }

        /// <summary>Defines the category of the alert</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string AlertTypeCategory { get => ((Commvault.Powershell.Models.IAlertDefinitionsCreateAlertTypeInternal)AlertType).Category; set => ((Commvault.Powershell.Models.IAlertDefinitionsCreateAlertTypeInternal)AlertType).Category = value ?? null; }

        /// <summary>Defines the criteria of the alert</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string AlertTypeCriteria { get => ((Commvault.Powershell.Models.IAlertDefinitionsCreateAlertTypeInternal)AlertType).Criteria; set => ((Commvault.Powershell.Models.IAlertDefinitionsCreateAlertTypeInternal)AlertType).Criteria = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IAlertDefinitionsCriteriaParams[] AlertTypeParamsList { get => ((Commvault.Powershell.Models.IAlertDefinitionsCreateAlertTypeInternal)AlertType).ParamsList; set => ((Commvault.Powershell.Models.IAlertDefinitionsCreateAlertTypeInternal)AlertType).ParamsList = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Associations" /> property.</summary>
        private Commvault.Powershell.Models.IAlertAssociationIdNameType1[] _associations;

        /// <summary>AlertDefinitionsAssociations</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IAlertAssociationIdNameType1[] Associations { get => this._associations; set => this._associations = value; }

        /// <summary>Internal Acessors for AlertTarget</summary>
        Commvault.Powershell.Models.IAlertDefinitionsTarget Commvault.Powershell.Models.IAlertDefinitonsCreateInternal.AlertTarget { get => (this._alertTarget = this._alertTarget ?? new Commvault.Powershell.Models.AlertDefinitionsTarget()); set { {_alertTarget = value;} } }

        /// <summary>Internal Acessors for AlertTargetRecipients</summary>
        Commvault.Powershell.Models.IAlertDefinitionsTargetRecipients Commvault.Powershell.Models.IAlertDefinitonsCreateInternal.AlertTargetRecipients { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).Recipients; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).Recipients = value; }

        /// <summary>Internal Acessors for AlertType</summary>
        Commvault.Powershell.Models.IAlertDefinitionsCreateAlertType Commvault.Powershell.Models.IAlertDefinitonsCreateInternal.AlertType { get => (this._alertType = this._alertType ?? new Commvault.Powershell.Models.AlertDefinitionsCreateAlertType()); set { {_alertType = value;} } }

        /// <summary>Internal Acessors for TemplateLocale</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IAlertDefinitonsCreateInternal.TemplateLocale { get => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).Locale; set => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).Locale = value; }

        /// <summary>Internal Acessors for Templates</summary>
        Commvault.Powershell.Models.IAlertDefinitionsTemplate Commvault.Powershell.Models.IAlertDefinitonsCreateInternal.Templates { get => (this._templates = this._templates ?? new Commvault.Powershell.Models.AlertDefinitionsTemplate()); set { {_templates = value;} } }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? LocaleId { get => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).LocaleId; set => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).LocaleId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string LocaleName { get => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).LocaleName; set => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).LocaleName = value ?? null; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientBcc { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientBcc; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientBcc = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientCc { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientCc; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientCc = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientTo { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientTo; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientTo = value ?? null /* arrayOf */; }

        /// <summary>
        /// id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list
        /// of webhooks, use api GET Webhook
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? RecipientWebHookId { get => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientWebHookId; set => ((Commvault.Powershell.Models.IAlertDefinitionsTargetInternal)AlertTarget).RecipientWebHookId = value ?? default(int); }

        /// <summary>Backing field for <see cref="SendIndividualNotifications" /> property.</summary>
        private bool? _sendIndividualNotifications;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? SendIndividualNotifications { get => this._sendIndividualNotifications; set => this._sendIndividualNotifications = value; }

        /// <summary>the message template for the console notification</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TemplateConsoleMessage { get => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).ConsoleMessage; set => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).ConsoleMessage = value ?? null; }

        /// <summary>
        /// the message template for the email notification. Contains both email subject as well as body
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TemplateEmailMessage { get => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).EmailMessage; set => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).EmailMessage = value ?? null; }

        /// <summary>the message template for the event viewer notification</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TemplateEventViewerMessage { get => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).EventViewerMessage; set => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).EventViewerMessage = value ?? null; }

        /// <summary>the message template for the webhook notification</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TemplateWebhookMessage { get => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).WebhookMessage; set => ((Commvault.Powershell.Models.IAlertDefinitionsTemplateInternal)Templates).WebhookMessage = value ?? null; }

        /// <summary>Backing field for <see cref="Templates" /> property.</summary>
        private Commvault.Powershell.Models.IAlertDefinitionsTemplate _templates;

        /// <summary>AlertDefinitionsTemplate</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IAlertDefinitionsTemplate Templates { get => (this._templates = this._templates ?? new Commvault.Powershell.Models.AlertDefinitionsTemplate()); set => this._templates = value; }

        /// <summary>Creates an new <see cref="AlertDefinitonsCreate" /> instance.</summary>
        public AlertDefinitonsCreate()
        {

        }
    }
    /// AlertDefinitonsCreate
    public partial interface IAlertDefinitonsCreate :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sendAlertTo",
        PossibleTypes = new [] { typeof(string) })]
        string[] AlertTargetSendAlertTo { get; set; }
        /// <summary>Defines the category of the alert</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Defines the category of the alert",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string AlertTypeCategory { get; set; }
        /// <summary>Defines the criteria of the alert</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Defines the criteria of the alert",
        SerializedName = @"criteria",
        PossibleTypes = new [] { typeof(string) })]
        string AlertTypeCriteria { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"paramsList",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAlertDefinitionsCriteriaParams) })]
        Commvault.Powershell.Models.IAlertDefinitionsCriteriaParams[] AlertTypeParamsList { get; set; }
        /// <summary>AlertDefinitionsAssociations</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"AlertDefinitionsAssociations",
        SerializedName = @"associations",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAlertAssociationIdNameType1) })]
        Commvault.Powershell.Models.IAlertAssociationIdNameType1[] Associations { get; set; }

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

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"bcc",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAlertTargetIdNameType1) })]
        Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientBcc { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"cc",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAlertTargetIdNameType1) })]
        Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientCc { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"to",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IAlertTargetIdNameType1) })]
        Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientTo { get; set; }
        /// <summary>
        /// id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list
        /// of webhooks, use api GET Webhook
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list of webhooks, use api GET Webhook",
        SerializedName = @"webHookId",
        PossibleTypes = new [] { typeof(int) })]
        int? RecipientWebHookId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sendIndividualNotifications",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SendIndividualNotifications { get; set; }
        /// <summary>the message template for the console notification</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the message template for the console notification",
        SerializedName = @"consoleMessage",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateConsoleMessage { get; set; }
        /// <summary>
        /// the message template for the email notification. Contains both email subject as well as body
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the message template for the email notification. Contains both email subject as well as body",
        SerializedName = @"emailMessage",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateEmailMessage { get; set; }
        /// <summary>the message template for the event viewer notification</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the message template for the event viewer notification",
        SerializedName = @"eventViewerMessage",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateEventViewerMessage { get; set; }
        /// <summary>the message template for the webhook notification</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the message template for the webhook notification",
        SerializedName = @"webhookMessage",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateWebhookMessage { get; set; }

    }
    /// AlertDefinitonsCreate
    internal partial interface IAlertDefinitonsCreateInternal

    {
        /// <summary>AlertDefinitionsTarget</summary>
        Commvault.Powershell.Models.IAlertDefinitionsTarget AlertTarget { get; set; }
        /// <summary>AlertDefinitionsTargetRecipients</summary>
        Commvault.Powershell.Models.IAlertDefinitionsTargetRecipients AlertTargetRecipients { get; set; }

        string[] AlertTargetSendAlertTo { get; set; }
        /// <summary>AlertDefinitionsCreateAlertType</summary>
        Commvault.Powershell.Models.IAlertDefinitionsCreateAlertType AlertType { get; set; }
        /// <summary>Defines the category of the alert</summary>
        string AlertTypeCategory { get; set; }
        /// <summary>Defines the criteria of the alert</summary>
        string AlertTypeCriteria { get; set; }

        Commvault.Powershell.Models.IAlertDefinitionsCriteriaParams[] AlertTypeParamsList { get; set; }
        /// <summary>AlertDefinitionsAssociations</summary>
        Commvault.Powershell.Models.IAlertAssociationIdNameType1[] Associations { get; set; }

        int? LocaleId { get; set; }

        string LocaleName { get; set; }

        string Name { get; set; }

        Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientBcc { get; set; }

        Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientCc { get; set; }

        Commvault.Powershell.Models.IAlertTargetIdNameType1[] RecipientTo { get; set; }
        /// <summary>
        /// id of the webhook to be associated with the alert definition. Only needed incase of webhook notif selected. To get a list
        /// of webhooks, use api GET Webhook
        /// </summary>
        int? RecipientWebHookId { get; set; }

        bool? SendIndividualNotifications { get; set; }
        /// <summary>the message template for the console notification</summary>
        string TemplateConsoleMessage { get; set; }
        /// <summary>
        /// the message template for the email notification. Contains both email subject as well as body
        /// </summary>
        string TemplateEmailMessage { get; set; }
        /// <summary>the message template for the event viewer notification</summary>
        string TemplateEventViewerMessage { get; set; }

        Commvault.Powershell.Models.IIdName TemplateLocale { get; set; }
        /// <summary>the message template for the webhook notification</summary>
        string TemplateWebhookMessage { get; set; }
        /// <summary>AlertDefinitionsTemplate</summary>
        Commvault.Powershell.Models.IAlertDefinitionsTemplate Templates { get; set; }

    }
}