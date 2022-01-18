// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>AlertDefinitionsDetails</summary>
    [System.ComponentModel.TypeConverter(typeof(AlertDefinitionsDetailsTypeConverter))]
    public partial class AlertDefinitionsDetails
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.AlertDefinitionsDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AlertDefinitionsDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummary = (Commvault.Powershell.Models.IAlertDetailsSummary) content.GetValueForProperty("AlertSummary",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummary, Commvault.Powershell.Models.AlertDetailsSummaryTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertTarget = (Commvault.Powershell.Models.IAlertDefinitionsTarget) content.GetValueForProperty("AlertTarget",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertTarget, Commvault.Powershell.Models.AlertDefinitionsTargetTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Template = (Commvault.Powershell.Models.IAlertDefinitionsTemplate) content.GetValueForProperty("Template",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Template, Commvault.Powershell.Models.AlertDefinitionsTemplateTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).SendIndividualNotifications = (bool?) content.GetValueForProperty("SendIndividualNotifications",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).SendIndividualNotifications, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Associations = (Commvault.Powershell.Models.IAlertAssociationIdNameType1[]) content.GetValueForProperty("Associations",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Associations, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertAssociationIdNameType1>(__y, Commvault.Powershell.Models.AlertAssociationIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummaryType = (Commvault.Powershell.Models.IAlertTypeIdName1) content.GetValueForProperty("AlertSummaryType",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummaryType, Commvault.Powershell.Models.AlertTypeIdName1TypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummaryCategory = (Commvault.Powershell.Models.IAlertCategoryIdName1) content.GetValueForProperty("AlertSummaryCategory",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummaryCategory, Commvault.Powershell.Models.AlertCategoryIdName1TypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummaryCriteria = (Commvault.Powershell.Models.IAlertCriteriaIdName1) content.GetValueForProperty("AlertSummaryCriteria",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummaryCriteria, Commvault.Powershell.Models.AlertCriteriaIdName1TypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertTargetRecipients = (Commvault.Powershell.Models.IAlertDefinitionsTargetRecipients) content.GetValueForProperty("AlertTargetRecipients",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertTargetRecipients, Commvault.Powershell.Models.AlertDefinitionsTargetRecipientsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertTargetSendAlertTo = (string[]) content.GetValueForProperty("AlertTargetSendAlertTo",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertTargetSendAlertTo, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateLocale = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("TemplateLocale",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateLocale, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateEmailMessage = (string) content.GetValueForProperty("TemplateEmailMessage",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateEmailMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateConsoleMessage = (string) content.GetValueForProperty("TemplateConsoleMessage",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateConsoleMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateEventViewerMessage = (string) content.GetValueForProperty("TemplateEventViewerMessage",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateEventViewerMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateWebhookMessage = (string) content.GetValueForProperty("TemplateWebhookMessage",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateWebhookMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TypeId = (int?) content.GetValueForProperty("TypeId",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TypeId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TypeName = (string) content.GetValueForProperty("TypeName",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TypeName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CategoryId = (int?) content.GetValueForProperty("CategoryId",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CategoryId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CategoryName = (string) content.GetValueForProperty("CategoryName",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CategoryName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CriterionId = (int?) content.GetValueForProperty("CriterionId",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CriterionId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CriterionName = (string) content.GetValueForProperty("CriterionName",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CriterionName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientTo = (Commvault.Powershell.Models.IAlertTargetIdNameType1[]) content.GetValueForProperty("RecipientTo",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientTo, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertTargetIdNameType1>(__y, Commvault.Powershell.Models.AlertTargetIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientCc = (Commvault.Powershell.Models.IAlertTargetIdNameType1[]) content.GetValueForProperty("RecipientCc",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientCc, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertTargetIdNameType1>(__y, Commvault.Powershell.Models.AlertTargetIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientBcc = (Commvault.Powershell.Models.IAlertTargetIdNameType1[]) content.GetValueForProperty("RecipientBcc",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientBcc, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertTargetIdNameType1>(__y, Commvault.Powershell.Models.AlertTargetIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientWebHookId = (int?) content.GetValueForProperty("RecipientWebHookId",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientWebHookId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).LocaleId = (int?) content.GetValueForProperty("LocaleId",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).LocaleId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).LocaleName = (string) content.GetValueForProperty("LocaleName",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).LocaleName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.AlertDefinitionsDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AlertDefinitionsDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummary = (Commvault.Powershell.Models.IAlertDetailsSummary) content.GetValueForProperty("AlertSummary",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummary, Commvault.Powershell.Models.AlertDetailsSummaryTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertTarget = (Commvault.Powershell.Models.IAlertDefinitionsTarget) content.GetValueForProperty("AlertTarget",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertTarget, Commvault.Powershell.Models.AlertDefinitionsTargetTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Template = (Commvault.Powershell.Models.IAlertDefinitionsTemplate) content.GetValueForProperty("Template",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Template, Commvault.Powershell.Models.AlertDefinitionsTemplateTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).SendIndividualNotifications = (bool?) content.GetValueForProperty("SendIndividualNotifications",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).SendIndividualNotifications, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Associations = (Commvault.Powershell.Models.IAlertAssociationIdNameType1[]) content.GetValueForProperty("Associations",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).Associations, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertAssociationIdNameType1>(__y, Commvault.Powershell.Models.AlertAssociationIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummaryType = (Commvault.Powershell.Models.IAlertTypeIdName1) content.GetValueForProperty("AlertSummaryType",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummaryType, Commvault.Powershell.Models.AlertTypeIdName1TypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummaryCategory = (Commvault.Powershell.Models.IAlertCategoryIdName1) content.GetValueForProperty("AlertSummaryCategory",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummaryCategory, Commvault.Powershell.Models.AlertCategoryIdName1TypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummaryCriteria = (Commvault.Powershell.Models.IAlertCriteriaIdName1) content.GetValueForProperty("AlertSummaryCriteria",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertSummaryCriteria, Commvault.Powershell.Models.AlertCriteriaIdName1TypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertTargetRecipients = (Commvault.Powershell.Models.IAlertDefinitionsTargetRecipients) content.GetValueForProperty("AlertTargetRecipients",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertTargetRecipients, Commvault.Powershell.Models.AlertDefinitionsTargetRecipientsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertTargetSendAlertTo = (string[]) content.GetValueForProperty("AlertTargetSendAlertTo",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).AlertTargetSendAlertTo, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateLocale = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("TemplateLocale",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateLocale, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateEmailMessage = (string) content.GetValueForProperty("TemplateEmailMessage",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateEmailMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateConsoleMessage = (string) content.GetValueForProperty("TemplateConsoleMessage",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateConsoleMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateEventViewerMessage = (string) content.GetValueForProperty("TemplateEventViewerMessage",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateEventViewerMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateWebhookMessage = (string) content.GetValueForProperty("TemplateWebhookMessage",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TemplateWebhookMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TypeId = (int?) content.GetValueForProperty("TypeId",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TypeId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TypeName = (string) content.GetValueForProperty("TypeName",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).TypeName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CategoryId = (int?) content.GetValueForProperty("CategoryId",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CategoryId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CategoryName = (string) content.GetValueForProperty("CategoryName",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CategoryName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CriterionId = (int?) content.GetValueForProperty("CriterionId",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CriterionId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CriterionName = (string) content.GetValueForProperty("CriterionName",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).CriterionName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientTo = (Commvault.Powershell.Models.IAlertTargetIdNameType1[]) content.GetValueForProperty("RecipientTo",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientTo, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertTargetIdNameType1>(__y, Commvault.Powershell.Models.AlertTargetIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientCc = (Commvault.Powershell.Models.IAlertTargetIdNameType1[]) content.GetValueForProperty("RecipientCc",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientCc, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertTargetIdNameType1>(__y, Commvault.Powershell.Models.AlertTargetIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientBcc = (Commvault.Powershell.Models.IAlertTargetIdNameType1[]) content.GetValueForProperty("RecipientBcc",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientBcc, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IAlertTargetIdNameType1>(__y, Commvault.Powershell.Models.AlertTargetIdNameType1TypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientWebHookId = (int?) content.GetValueForProperty("RecipientWebHookId",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).RecipientWebHookId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).LocaleId = (int?) content.GetValueForProperty("LocaleId",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).LocaleId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).LocaleName = (string) content.GetValueForProperty("LocaleName",((Commvault.Powershell.Models.IAlertDefinitionsDetailsInternal)this).LocaleName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.AlertDefinitionsDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IAlertDefinitionsDetails" />.
        /// </returns>
        public static Commvault.Powershell.Models.IAlertDefinitionsDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AlertDefinitionsDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.AlertDefinitionsDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IAlertDefinitionsDetails" />.
        /// </returns>
        public static Commvault.Powershell.Models.IAlertDefinitionsDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AlertDefinitionsDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AlertDefinitionsDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IAlertDefinitionsDetails FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// AlertDefinitionsDetails
    [System.ComponentModel.TypeConverter(typeof(AlertDefinitionsDetailsTypeConverter))]
    public partial interface IAlertDefinitionsDetails

    {

    }
}