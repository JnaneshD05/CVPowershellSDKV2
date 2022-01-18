// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Details of continuous replication group</summary>
    [System.ComponentModel.TypeConverter(typeof(ReplicationMonitorDetailTypeConverter))]
    public partial class ReplicationMonitorDetail
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.ReplicationMonitorDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IReplicationMonitorDetail" />.
        /// </returns>
        public static Commvault.Powershell.Models.IReplicationMonitorDetail DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReplicationMonitorDetail(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.ReplicationMonitorDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IReplicationMonitorDetail" />.
        /// </returns>
        public static Commvault.Powershell.Models.IReplicationMonitorDetail DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReplicationMonitorDetail(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReplicationMonitorDetail" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IReplicationMonitorDetail FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.ReplicationMonitorDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReplicationMonitorDetail(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).Summary = (Commvault.Powershell.Models.IReplicationMonitorDetailSummary) content.GetValueForProperty("Summary",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).Summary, Commvault.Powershell.Models.ReplicationMonitorDetailSummaryTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptions = (Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptions) content.GetValueForProperty("RecoveryOptions",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptions, Commvault.Powershell.Models.ReplicationMonitorDetailRecoveryOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).ReplicationCopyDetails = (Commvault.Powershell.Models.IReplicationMonitorDetailReplicationCopyDetails[]) content.GetValueForProperty("ReplicationCopyDetails",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).ReplicationCopyDetails, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IReplicationMonitorDetailReplicationCopyDetails>(__y, Commvault.Powershell.Models.ReplicationMonitorDetailReplicationCopyDetailsTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).Statistics = (Commvault.Powershell.Models.IReplicationMonitorDetailStats[]) content.GetValueForProperty("Statistics",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).Statistics, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IReplicationMonitorDetailStats>(__y, Commvault.Powershell.Models.ReplicationMonitorDetailStatsTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummarySource = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SummarySource",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummarySource, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummaryDestination = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SummaryDestination",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummaryDestination, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummaryRecoveryType = (string) content.GetValueForProperty("SummaryRecoveryType",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummaryRecoveryType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummarySynchronizationStatus = (string) content.GetValueForProperty("SummarySynchronizationStatus",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummarySynchronizationStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummaryReplicationLag = (int?) content.GetValueForProperty("SummaryReplicationLag",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummaryReplicationLag, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionRecoverypointStore = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("RecoveryOptionRecoverypointStore",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionRecoverypointStore, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionCcrpInterval = (int?) content.GetValueForProperty("RecoveryOptionCcrpInterval",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionCcrpInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionMergeRecoveryPointsOlderThan = (int?) content.GetValueForProperty("RecoveryOptionMergeRecoveryPointsOlderThan",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionMergeRecoveryPointsOlderThan, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionRetainRecoveryPointsFor = (int?) content.GetValueForProperty("RecoveryOptionRetainRecoveryPointsFor",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionRetainRecoveryPointsFor, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionRpIntervalAfterRetention = (int?) content.GetValueForProperty("RecoveryOptionRpIntervalAfterRetention",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionRpIntervalAfterRetention, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionPruneAndMergeOffPeakOnly = (bool?) content.GetValueForProperty("RecoveryOptionPruneAndMergeOffPeakOnly",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionPruneAndMergeOffPeakOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionAcrpInterval = (int?) content.GetValueForProperty("RecoveryOptionAcrpInterval",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionAcrpInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionSwitchToLatestIfStoreOfflineFor = (int?) content.GetValueForProperty("RecoveryOptionSwitchToLatestIfStoreOfflineFor",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionSwitchToLatestIfStoreOfflineFor, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SourceId = (int?) content.GetValueForProperty("SourceId",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SourceId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SourceName = (string) content.GetValueForProperty("SourceName",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SourceName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).DestinationId = (int?) content.GetValueForProperty("DestinationId",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).DestinationId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).DestinationName = (string) content.GetValueForProperty("DestinationName",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).DestinationName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoverypointStoreId = (int?) content.GetValueForProperty("RecoverypointStoreId",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoverypointStoreId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoverypointStoreName = (string) content.GetValueForProperty("RecoverypointStoreName",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoverypointStoreName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.ReplicationMonitorDetail"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReplicationMonitorDetail(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).Summary = (Commvault.Powershell.Models.IReplicationMonitorDetailSummary) content.GetValueForProperty("Summary",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).Summary, Commvault.Powershell.Models.ReplicationMonitorDetailSummaryTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptions = (Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptions) content.GetValueForProperty("RecoveryOptions",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptions, Commvault.Powershell.Models.ReplicationMonitorDetailRecoveryOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).ReplicationCopyDetails = (Commvault.Powershell.Models.IReplicationMonitorDetailReplicationCopyDetails[]) content.GetValueForProperty("ReplicationCopyDetails",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).ReplicationCopyDetails, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IReplicationMonitorDetailReplicationCopyDetails>(__y, Commvault.Powershell.Models.ReplicationMonitorDetailReplicationCopyDetailsTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).Statistics = (Commvault.Powershell.Models.IReplicationMonitorDetailStats[]) content.GetValueForProperty("Statistics",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).Statistics, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IReplicationMonitorDetailStats>(__y, Commvault.Powershell.Models.ReplicationMonitorDetailStatsTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummarySource = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SummarySource",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummarySource, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummaryDestination = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SummaryDestination",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummaryDestination, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummaryRecoveryType = (string) content.GetValueForProperty("SummaryRecoveryType",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummaryRecoveryType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummarySynchronizationStatus = (string) content.GetValueForProperty("SummarySynchronizationStatus",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummarySynchronizationStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummaryReplicationLag = (int?) content.GetValueForProperty("SummaryReplicationLag",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SummaryReplicationLag, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionRecoverypointStore = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("RecoveryOptionRecoverypointStore",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionRecoverypointStore, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionCcrpInterval = (int?) content.GetValueForProperty("RecoveryOptionCcrpInterval",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionCcrpInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionMergeRecoveryPointsOlderThan = (int?) content.GetValueForProperty("RecoveryOptionMergeRecoveryPointsOlderThan",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionMergeRecoveryPointsOlderThan, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionRetainRecoveryPointsFor = (int?) content.GetValueForProperty("RecoveryOptionRetainRecoveryPointsFor",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionRetainRecoveryPointsFor, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionRpIntervalAfterRetention = (int?) content.GetValueForProperty("RecoveryOptionRpIntervalAfterRetention",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionRpIntervalAfterRetention, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionPruneAndMergeOffPeakOnly = (bool?) content.GetValueForProperty("RecoveryOptionPruneAndMergeOffPeakOnly",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionPruneAndMergeOffPeakOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionAcrpInterval = (int?) content.GetValueForProperty("RecoveryOptionAcrpInterval",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionAcrpInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionSwitchToLatestIfStoreOfflineFor = (int?) content.GetValueForProperty("RecoveryOptionSwitchToLatestIfStoreOfflineFor",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoveryOptionSwitchToLatestIfStoreOfflineFor, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SourceId = (int?) content.GetValueForProperty("SourceId",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SourceId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SourceName = (string) content.GetValueForProperty("SourceName",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).SourceName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).DestinationId = (int?) content.GetValueForProperty("DestinationId",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).DestinationId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).DestinationName = (string) content.GetValueForProperty("DestinationName",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).DestinationName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoverypointStoreId = (int?) content.GetValueForProperty("RecoverypointStoreId",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoverypointStoreId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoverypointStoreName = (string) content.GetValueForProperty("RecoverypointStoreName",((Commvault.Powershell.Models.IReplicationMonitorDetailInternal)this).RecoverypointStoreName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Details of continuous replication group
    [System.ComponentModel.TypeConverter(typeof(ReplicationMonitorDetailTypeConverter))]
    public partial interface IReplicationMonitorDetail

    {

    }
}