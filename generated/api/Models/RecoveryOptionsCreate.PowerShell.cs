// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>
    /// Recovery options for a continuous replication group. recoveryPointStore is an intermediate storage for recovery points.
    /// Provide both the id and the name of the recoveryPointStore. Either crash consistent or application consistent RP interval
    /// is mandatory.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(RecoveryOptionsCreateTypeConverter))]
    public partial class RecoveryOptionsCreate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.RecoveryOptionsCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IRecoveryOptionsCreate" />.
        /// </returns>
        public static Commvault.Powershell.Models.IRecoveryOptionsCreate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RecoveryOptionsCreate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.RecoveryOptionsCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IRecoveryOptionsCreate" />.
        /// </returns>
        public static Commvault.Powershell.Models.IRecoveryOptionsCreate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RecoveryOptionsCreate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RecoveryOptionsCreate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IRecoveryOptionsCreate FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.RecoveryOptionsCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RecoveryOptionsCreate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointStore = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("RecoveryPointStore",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointStore, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointInterval = (Commvault.Powershell.Models.IRecoveryPointIntervalCreate) content.GetValueForProperty("RecoveryPointInterval",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointInterval, Commvault.Powershell.Models.RecoveryPointIntervalCreateTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetention = (Commvault.Powershell.Models.IRecoveryPointRetentionCreate) content.GetValueForProperty("RecoveryPointRetention",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetention, Commvault.Powershell.Models.RecoveryPointRetentionCreateTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryType = (string) content.GetValueForProperty("RecoveryType",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointStoreId = (int?) content.GetValueForProperty("RecoveryPointStoreId",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointStoreId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointStoreName = (string) content.GetValueForProperty("RecoveryPointStoreName",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointStoreName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointIntervalCrashConsistentRpInterval = (int?) content.GetValueForProperty("RecoveryPointIntervalCrashConsistentRpInterval",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointIntervalCrashConsistentRpInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointIntervalApplicationConsistentRpInterval = (int?) content.GetValueForProperty("RecoveryPointIntervalApplicationConsistentRpInterval",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointIntervalApplicationConsistentRpInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionRetainRecoveryPointsFor = (int) content.GetValueForProperty("RecoveryPointRetentionRetainRecoveryPointsFor",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionRetainRecoveryPointsFor, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionMergeRecoveryPoints = (bool?) content.GetValueForProperty("RecoveryPointRetentionMergeRecoveryPoints",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionMergeRecoveryPoints, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionMergeRecoveryPointsOlderThan = (int?) content.GetValueForProperty("RecoveryPointRetentionMergeRecoveryPointsOlderThan",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionMergeRecoveryPointsOlderThan, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionRecoveryPointIntervalAtEndofRetention = (int?) content.GetValueForProperty("RecoveryPointRetentionRecoveryPointIntervalAtEndofRetention",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionRecoveryPointIntervalAtEndofRetention, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionRpStoreOfflineFor = (int?) content.GetValueForProperty("RecoveryPointRetentionRpStoreOfflineFor",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionRpStoreOfflineFor, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionPruneAndMergeDuringOffPeak = (bool?) content.GetValueForProperty("RecoveryPointRetentionPruneAndMergeDuringOffPeak",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionPruneAndMergeDuringOffPeak, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.RecoveryOptionsCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RecoveryOptionsCreate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointStore = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("RecoveryPointStore",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointStore, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointInterval = (Commvault.Powershell.Models.IRecoveryPointIntervalCreate) content.GetValueForProperty("RecoveryPointInterval",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointInterval, Commvault.Powershell.Models.RecoveryPointIntervalCreateTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetention = (Commvault.Powershell.Models.IRecoveryPointRetentionCreate) content.GetValueForProperty("RecoveryPointRetention",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetention, Commvault.Powershell.Models.RecoveryPointRetentionCreateTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryType = (string) content.GetValueForProperty("RecoveryType",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointStoreId = (int?) content.GetValueForProperty("RecoveryPointStoreId",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointStoreId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointStoreName = (string) content.GetValueForProperty("RecoveryPointStoreName",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointStoreName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointIntervalCrashConsistentRpInterval = (int?) content.GetValueForProperty("RecoveryPointIntervalCrashConsistentRpInterval",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointIntervalCrashConsistentRpInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointIntervalApplicationConsistentRpInterval = (int?) content.GetValueForProperty("RecoveryPointIntervalApplicationConsistentRpInterval",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointIntervalApplicationConsistentRpInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionRetainRecoveryPointsFor = (int) content.GetValueForProperty("RecoveryPointRetentionRetainRecoveryPointsFor",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionRetainRecoveryPointsFor, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionMergeRecoveryPoints = (bool?) content.GetValueForProperty("RecoveryPointRetentionMergeRecoveryPoints",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionMergeRecoveryPoints, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionMergeRecoveryPointsOlderThan = (int?) content.GetValueForProperty("RecoveryPointRetentionMergeRecoveryPointsOlderThan",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionMergeRecoveryPointsOlderThan, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionRecoveryPointIntervalAtEndofRetention = (int?) content.GetValueForProperty("RecoveryPointRetentionRecoveryPointIntervalAtEndofRetention",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionRecoveryPointIntervalAtEndofRetention, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionRpStoreOfflineFor = (int?) content.GetValueForProperty("RecoveryPointRetentionRpStoreOfflineFor",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionRpStoreOfflineFor, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionPruneAndMergeDuringOffPeak = (bool?) content.GetValueForProperty("RecoveryPointRetentionPruneAndMergeDuringOffPeak",((Commvault.Powershell.Models.IRecoveryOptionsCreateInternal)this).RecoveryPointRetentionPruneAndMergeDuringOffPeak, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Recovery options for a continuous replication group. recoveryPointStore is an intermediate storage for recovery points.
    /// Provide both the id and the name of the recoveryPointStore. Either crash consistent or application consistent RP interval
    /// is mandatory.
    [System.ComponentModel.TypeConverter(typeof(RecoveryOptionsCreateTypeConverter))]
    public partial interface IRecoveryOptionsCreate

    {

    }
}