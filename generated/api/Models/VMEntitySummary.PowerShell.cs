// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Summary of VMEntity in Virtual Machine summary</summary>
    [System.ComponentModel.TypeConverter(typeof(VMEntitySummaryTypeConverter))]
    public partial class VMEntitySummary
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.VMEntitySummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IVMEntitySummary" />.</returns>
        public static Commvault.Powershell.Models.IVMEntitySummary DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VMEntitySummary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.VMEntitySummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IVMEntitySummary" />.</returns>
        public static Commvault.Powershell.Models.IVMEntitySummary DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VMEntitySummary(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VMEntitySummary" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IVMEntitySummary FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.VMEntitySummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VMEntitySummary(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).Instance = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Instance",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).Instance, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).Backupset = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Backupset",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).Backupset, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).VMGroup = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("VMGroup",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).VMGroup, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).InstanceId = (int?) content.GetValueForProperty("InstanceId",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).InstanceId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).InstanceName = (string) content.GetValueForProperty("InstanceName",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).InstanceName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).BackupsetId = (int?) content.GetValueForProperty("BackupsetId",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).BackupsetId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).BackupsetName = (string) content.GetValueForProperty("BackupsetName",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).BackupsetName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).VMGroupId = (int?) content.GetValueForProperty("VMGroupId",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).VMGroupId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).VMGroupName = (string) content.GetValueForProperty("VMGroupName",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).VMGroupName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.VMEntitySummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VMEntitySummary(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).Instance = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Instance",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).Instance, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).Backupset = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Backupset",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).Backupset, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).VMGroup = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("VMGroup",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).VMGroup, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).InstanceId = (int?) content.GetValueForProperty("InstanceId",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).InstanceId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).InstanceName = (string) content.GetValueForProperty("InstanceName",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).InstanceName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).BackupsetId = (int?) content.GetValueForProperty("BackupsetId",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).BackupsetId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).BackupsetName = (string) content.GetValueForProperty("BackupsetName",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).BackupsetName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).VMGroupId = (int?) content.GetValueForProperty("VMGroupId",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).VMGroupId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).VMGroupName = (string) content.GetValueForProperty("VMGroupName",((Commvault.Powershell.Models.IVMEntitySummaryInternal)this).VMGroupName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// Summary of VMEntity in Virtual Machine summary
    [System.ComponentModel.TypeConverter(typeof(VMEntitySummaryTypeConverter))]
    public partial interface IVMEntitySummary

    {

    }
}