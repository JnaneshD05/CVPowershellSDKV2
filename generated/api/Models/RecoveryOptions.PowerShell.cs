// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Recovery options to be specified for a continuous replication group</summary>
    [System.ComponentModel.TypeConverter(typeof(RecoveryOptionsTypeConverter))]
    public partial class RecoveryOptions
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.RecoveryOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IRecoveryOptions" />.</returns>
        public static Commvault.Powershell.Models.IRecoveryOptions DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RecoveryOptions(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.RecoveryOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IRecoveryOptions" />.</returns>
        public static Commvault.Powershell.Models.IRecoveryOptions DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RecoveryOptions(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RecoveryOptions" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IRecoveryOptions FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.RecoveryOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RecoveryOptions(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RecoveryType = (string) content.GetValueForProperty("RecoveryType",((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RecoveryType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RecoveryPointStore = (string) content.GetValueForProperty("RecoveryPointStore",((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RecoveryPointStore, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).CrashConsistentRpInterval = (int?) content.GetValueForProperty("CrashConsistentRpInterval",((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).CrashConsistentRpInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).MergeRecoveryPointsOlderThan = (int?) content.GetValueForProperty("MergeRecoveryPointsOlderThan",((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).MergeRecoveryPointsOlderThan, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RetainRecoveryPointsFor = (int?) content.GetValueForProperty("RetainRecoveryPointsFor",((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RetainRecoveryPointsFor, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RecoveryPointInterval = (int?) content.GetValueForProperty("RecoveryPointInterval",((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RecoveryPointInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).PruneAndMergeRecoveryPoints = (bool?) content.GetValueForProperty("PruneAndMergeRecoveryPoints",((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).PruneAndMergeRecoveryPoints, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.RecoveryOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RecoveryOptions(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RecoveryType = (string) content.GetValueForProperty("RecoveryType",((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RecoveryType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RecoveryPointStore = (string) content.GetValueForProperty("RecoveryPointStore",((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RecoveryPointStore, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).CrashConsistentRpInterval = (int?) content.GetValueForProperty("CrashConsistentRpInterval",((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).CrashConsistentRpInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).MergeRecoveryPointsOlderThan = (int?) content.GetValueForProperty("MergeRecoveryPointsOlderThan",((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).MergeRecoveryPointsOlderThan, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RetainRecoveryPointsFor = (int?) content.GetValueForProperty("RetainRecoveryPointsFor",((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RetainRecoveryPointsFor, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RecoveryPointInterval = (int?) content.GetValueForProperty("RecoveryPointInterval",((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).RecoveryPointInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).PruneAndMergeRecoveryPoints = (bool?) content.GetValueForProperty("PruneAndMergeRecoveryPoints",((Commvault.Powershell.Models.IRecoveryOptionsInternal)this).PruneAndMergeRecoveryPoints, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Recovery options to be specified for a continuous replication group
    [System.ComponentModel.TypeConverter(typeof(RecoveryOptionsTypeConverter))]
    public partial interface IRecoveryOptions

    {

    }
}