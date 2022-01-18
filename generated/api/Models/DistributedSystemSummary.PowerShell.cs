// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>This returns the distributed system summary.</summary>
    [System.ComponentModel.TypeConverter(typeof(DistributedSystemSummaryTypeConverter))]
    public partial class DistributedSystemSummary
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.DistributedSystemSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IDistributedSystemSummary" />.
        /// </returns>
        public static Commvault.Powershell.Models.IDistributedSystemSummary DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DistributedSystemSummary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.DistributedSystemSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IDistributedSystemSummary" />.
        /// </returns>
        public static Commvault.Powershell.Models.IDistributedSystemSummary DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DistributedSystemSummary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.DistributedSystemSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DistributedSystemSummary(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IDistributedSystemSummaryInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IDistributedSystemSummaryInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IDistributedSystemSummaryInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IDistributedSystemSummaryInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IDistributedSystemSummaryInternal)this).Components = (Commvault.Powershell.Models.IDistributedSystemComponent[]) content.GetValueForProperty("Components",((Commvault.Powershell.Models.IDistributedSystemSummaryInternal)this).Components, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDistributedSystemComponent>(__y, Commvault.Powershell.Models.DistributedSystemComponentTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.DistributedSystemSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DistributedSystemSummary(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IDistributedSystemSummaryInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IDistributedSystemSummaryInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IDistributedSystemSummaryInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IDistributedSystemSummaryInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IDistributedSystemSummaryInternal)this).Components = (Commvault.Powershell.Models.IDistributedSystemComponent[]) content.GetValueForProperty("Components",((Commvault.Powershell.Models.IDistributedSystemSummaryInternal)this).Components, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDistributedSystemComponent>(__y, Commvault.Powershell.Models.DistributedSystemComponentTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DistributedSystemSummary" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IDistributedSystemSummary FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// This returns the distributed system summary.
    [System.ComponentModel.TypeConverter(typeof(DistributedSystemSummaryTypeConverter))]
    public partial interface IDistributedSystemSummary

    {

    }
}