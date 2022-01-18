// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>This operation configures a syslog server.</summary>
    [System.ComponentModel.TypeConverter(typeof(SyslogConfigureTypeConverter))]
    public partial class SyslogConfigure
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.SyslogConfigure"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ISyslogConfigure" />.</returns>
        public static Commvault.Powershell.Models.ISyslogConfigure DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SyslogConfigure(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.SyslogConfigure"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ISyslogConfigure" />.</returns>
        public static Commvault.Powershell.Models.ISyslogConfigure DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SyslogConfigure(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SyslogConfigure" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.ISyslogConfigure FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.SyslogConfigure"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SyslogConfigure(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslog = (Commvault.Powershell.Models.ISyslogPolicies) content.GetValueForProperty("ForwardToSyslog",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslog, Commvault.Powershell.Models.SyslogPoliciesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).Hostname, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).Port = (int?) content.GetValueForProperty("Port",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).Port, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).SecureMessaging = (bool?) content.GetValueForProperty("SecureMessaging",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).SecureMessaging, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).CertificateAuthorityName = (string) content.GetValueForProperty("CertificateAuthorityName",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).CertificateAuthorityName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).CertificateAuthorityContent = (string) content.GetValueForProperty("CertificateAuthorityContent",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).CertificateAuthorityContent, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslogAlerts = (bool?) content.GetValueForProperty("ForwardToSyslogAlerts",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslogAlerts, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslogAudit = (bool?) content.GetValueForProperty("ForwardToSyslogAudit",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslogAudit, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslogEvents = (bool?) content.GetValueForProperty("ForwardToSyslogEvents",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslogEvents, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.SyslogConfigure"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SyslogConfigure(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslog = (Commvault.Powershell.Models.ISyslogPolicies) content.GetValueForProperty("ForwardToSyslog",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslog, Commvault.Powershell.Models.SyslogPoliciesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).Hostname, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).Port = (int?) content.GetValueForProperty("Port",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).Port, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).SecureMessaging = (bool?) content.GetValueForProperty("SecureMessaging",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).SecureMessaging, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).CertificateAuthorityName = (string) content.GetValueForProperty("CertificateAuthorityName",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).CertificateAuthorityName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).CertificateAuthorityContent = (string) content.GetValueForProperty("CertificateAuthorityContent",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).CertificateAuthorityContent, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslogAlerts = (bool?) content.GetValueForProperty("ForwardToSyslogAlerts",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslogAlerts, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslogAudit = (bool?) content.GetValueForProperty("ForwardToSyslogAudit",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslogAudit, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslogEvents = (bool?) content.GetValueForProperty("ForwardToSyslogEvents",((Commvault.Powershell.Models.ISyslogConfigureInternal)this).ForwardToSyslogEvents, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// This operation configures a syslog server.
    [System.ComponentModel.TypeConverter(typeof(SyslogConfigureTypeConverter))]
    public partial interface ISyslogConfigure

    {

    }
}