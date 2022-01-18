// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Gives statistics information for Replication performance and Journal retention</summary>
    [System.ComponentModel.TypeConverter(typeof(ReplicationMonitorDetailStatsTypeConverter))]
    public partial class ReplicationMonitorDetailStats
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.ReplicationMonitorDetailStats"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IReplicationMonitorDetailStats" />.
        /// </returns>
        public static Commvault.Powershell.Models.IReplicationMonitorDetailStats DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReplicationMonitorDetailStats(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.ReplicationMonitorDetailStats"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IReplicationMonitorDetailStats" />.
        /// </returns>
        public static Commvault.Powershell.Models.IReplicationMonitorDetailStats DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReplicationMonitorDetailStats(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReplicationMonitorDetailStats" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IReplicationMonitorDetailStats FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.ReplicationMonitorDetailStats"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReplicationMonitorDetailStats(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).RepDataDeltaActual = (int?) content.GetValueForProperty("RepDataDeltaActual",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).RepDataDeltaActual, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).IoDelta = (int?) content.GetValueForProperty("IoDelta",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).IoDelta, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).RepSetSize = (int?) content.GetValueForProperty("RepSetSize",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).RepSetSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).IopsDelta = (int?) content.GetValueForProperty("IopsDelta",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).IopsDelta, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).SizeInRpStore = (int?) content.GetValueForProperty("SizeInRpStore",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).SizeInRpStore, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).RepDataDeltaComp = (int?) content.GetValueForProperty("RepDataDeltaComp",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).RepDataDeltaComp, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).Retention = (int?) content.GetValueForProperty("Retention",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).Retention, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).TimeStamp = (int?) content.GetValueForProperty("TimeStamp",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).TimeStamp, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.ReplicationMonitorDetailStats"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReplicationMonitorDetailStats(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).RepDataDeltaActual = (int?) content.GetValueForProperty("RepDataDeltaActual",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).RepDataDeltaActual, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).IoDelta = (int?) content.GetValueForProperty("IoDelta",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).IoDelta, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).RepSetSize = (int?) content.GetValueForProperty("RepSetSize",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).RepSetSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).IopsDelta = (int?) content.GetValueForProperty("IopsDelta",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).IopsDelta, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).SizeInRpStore = (int?) content.GetValueForProperty("SizeInRpStore",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).SizeInRpStore, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).RepDataDeltaComp = (int?) content.GetValueForProperty("RepDataDeltaComp",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).RepDataDeltaComp, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).Retention = (int?) content.GetValueForProperty("Retention",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).Retention, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).TimeStamp = (int?) content.GetValueForProperty("TimeStamp",((Commvault.Powershell.Models.IReplicationMonitorDetailStatsInternal)this).TimeStamp, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Gives statistics information for Replication performance and Journal retention
    [System.ComponentModel.TypeConverter(typeof(ReplicationMonitorDetailStatsTypeConverter))]
    public partial interface IReplicationMonitorDetailStats

    {

    }
}