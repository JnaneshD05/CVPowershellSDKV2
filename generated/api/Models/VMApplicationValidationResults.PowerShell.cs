// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>VMApplicationValidationResults</summary>
    [System.ComponentModel.TypeConverter(typeof(VMApplicationValidationResultsTypeConverter))]
    public partial class VMApplicationValidationResults
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.VMApplicationValidationResults"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IVMApplicationValidationResults" />.
        /// </returns>
        public static Commvault.Powershell.Models.IVMApplicationValidationResults DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VMApplicationValidationResults(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.VMApplicationValidationResults"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IVMApplicationValidationResults" />.
        /// </returns>
        public static Commvault.Powershell.Models.IVMApplicationValidationResults DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VMApplicationValidationResults(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VMApplicationValidationResults" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IVMApplicationValidationResults FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.VMApplicationValidationResults"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VMApplicationValidationResults(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).BootStatus = (bool?) content.GetValueForProperty("BootStatus",((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).BootStatus, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).LastValidationJobId = (int?) content.GetValueForProperty("LastValidationJobId",((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).LastValidationJobId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).BackupValidated = (int?) content.GetValueForProperty("BackupValidated",((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).BackupValidated, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).BackupCompletionDate = (int?) content.GetValueForProperty("BackupCompletionDate",((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).BackupCompletionDate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).AppsDiscovered = (Commvault.Powershell.Models.IVMAppsDiscovered[]) content.GetValueForProperty("AppsDiscovered",((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).AppsDiscovered, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IVMAppsDiscovered>(__y, Commvault.Powershell.Models.VMAppsDiscoveredTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.VMApplicationValidationResults"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VMApplicationValidationResults(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).BootStatus = (bool?) content.GetValueForProperty("BootStatus",((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).BootStatus, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).LastValidationJobId = (int?) content.GetValueForProperty("LastValidationJobId",((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).LastValidationJobId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).BackupValidated = (int?) content.GetValueForProperty("BackupValidated",((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).BackupValidated, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).BackupCompletionDate = (int?) content.GetValueForProperty("BackupCompletionDate",((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).BackupCompletionDate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).AppsDiscovered = (Commvault.Powershell.Models.IVMAppsDiscovered[]) content.GetValueForProperty("AppsDiscovered",((Commvault.Powershell.Models.IVMApplicationValidationResultsInternal)this).AppsDiscovered, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IVMAppsDiscovered>(__y, Commvault.Powershell.Models.VMAppsDiscoveredTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }
    }
    /// VMApplicationValidationResults
    [System.ComponentModel.TypeConverter(typeof(VMApplicationValidationResultsTypeConverter))]
    public partial interface IVMApplicationValidationResults

    {

    }
}