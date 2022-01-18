// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Replication group details pertaining to Azure</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureReplicationGroupTypeConverter))]
    public partial class AzureReplicationGroup
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.AzureReplicationGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureReplicationGroup(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).AdvancedOption = (Commvault.Powershell.Models.IReplicationGroupAdvOptionsAzure) content.GetValueForProperty("AdvancedOption",((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).AdvancedOption, Commvault.Powershell.Models.ReplicationGroupAdvOptionsAzureTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).ReplicationConfiguration = (Commvault.Powershell.Models.IReplicationConfigurationAzure[]) content.GetValueForProperty("ReplicationConfiguration",((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).ReplicationConfiguration, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IReplicationConfigurationAzure>(__y, Commvault.Powershell.Models.ReplicationConfigurationAzureTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).Vendor = (string) content.GetValueForProperty("Vendor",((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).Vendor, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryDestinationVendor = (string) content.GetValueForProperty("SummaryDestinationVendor",((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryDestinationVendor, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryReplicationType = (string) content.GetValueForProperty("SummaryReplicationType",((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryReplicationType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummarySource = (string) content.GetValueForProperty("SummarySource",((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummarySource, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryRecoveryTarget = (string) content.GetValueForProperty("SummaryRecoveryTarget",((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryRecoveryTarget, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryState = (string) content.GetValueForProperty("SummaryState",((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryState, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).RpoReplicationFrequency = (int?) content.GetValueForProperty("RpoReplicationFrequency",((Commvault.Powershell.Models.IReplicationGroupInternal)this).RpoReplicationFrequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).StorageCopies = (Commvault.Powershell.Models.IStorageCopy[]) content.GetValueForProperty("StorageCopies",((Commvault.Powershell.Models.IReplicationGroupInternal)this).StorageCopies, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IStorageCopy>(__y, Commvault.Powershell.Models.StorageCopyTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).StorageCopyForReplication = (string) content.GetValueForProperty("StorageCopyForReplication",((Commvault.Powershell.Models.IReplicationGroupInternal)this).StorageCopyForReplication, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).Summary = (Commvault.Powershell.Models.IReplicationGroupSummary) content.GetValueForProperty("Summary",((Commvault.Powershell.Models.IReplicationGroupInternal)this).Summary, Commvault.Powershell.Models.ReplicationGroupSummaryTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).Rpo = (Commvault.Powershell.Models.IRpo) content.GetValueForProperty("Rpo",((Commvault.Powershell.Models.IReplicationGroupInternal)this).Rpo, Commvault.Powershell.Models.RpoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).Storage = (Commvault.Powershell.Models.IReplicationGroupStorageList) content.GetValueForProperty("Storage",((Commvault.Powershell.Models.IReplicationGroupInternal)this).Storage, Commvault.Powershell.Models.ReplicationGroupStorageListTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IReplicationGroupInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IReplicationGroupInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).AdvancedOptionUnconditionalOverwrite = (bool?) content.GetValueForProperty("AdvancedOptionUnconditionalOverwrite",((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).AdvancedOptionUnconditionalOverwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).AdvancedOptionDeployVMOnlyDuringfailover = (bool?) content.GetValueForProperty("AdvancedOptionDeployVMOnlyDuringfailover",((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).AdvancedOptionDeployVMOnlyDuringfailover, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.AzureReplicationGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureReplicationGroup(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).AdvancedOption = (Commvault.Powershell.Models.IReplicationGroupAdvOptionsAzure) content.GetValueForProperty("AdvancedOption",((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).AdvancedOption, Commvault.Powershell.Models.ReplicationGroupAdvOptionsAzureTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).ReplicationConfiguration = (Commvault.Powershell.Models.IReplicationConfigurationAzure[]) content.GetValueForProperty("ReplicationConfiguration",((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).ReplicationConfiguration, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IReplicationConfigurationAzure>(__y, Commvault.Powershell.Models.ReplicationConfigurationAzureTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).Vendor = (string) content.GetValueForProperty("Vendor",((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).Vendor, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryDestinationVendor = (string) content.GetValueForProperty("SummaryDestinationVendor",((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryDestinationVendor, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryReplicationType = (string) content.GetValueForProperty("SummaryReplicationType",((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryReplicationType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummarySource = (string) content.GetValueForProperty("SummarySource",((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummarySource, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryRecoveryTarget = (string) content.GetValueForProperty("SummaryRecoveryTarget",((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryRecoveryTarget, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryState = (string) content.GetValueForProperty("SummaryState",((Commvault.Powershell.Models.IReplicationGroupInternal)this).SummaryState, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).RpoReplicationFrequency = (int?) content.GetValueForProperty("RpoReplicationFrequency",((Commvault.Powershell.Models.IReplicationGroupInternal)this).RpoReplicationFrequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).StorageCopies = (Commvault.Powershell.Models.IStorageCopy[]) content.GetValueForProperty("StorageCopies",((Commvault.Powershell.Models.IReplicationGroupInternal)this).StorageCopies, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IStorageCopy>(__y, Commvault.Powershell.Models.StorageCopyTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).StorageCopyForReplication = (string) content.GetValueForProperty("StorageCopyForReplication",((Commvault.Powershell.Models.IReplicationGroupInternal)this).StorageCopyForReplication, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).Summary = (Commvault.Powershell.Models.IReplicationGroupSummary) content.GetValueForProperty("Summary",((Commvault.Powershell.Models.IReplicationGroupInternal)this).Summary, Commvault.Powershell.Models.ReplicationGroupSummaryTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).Rpo = (Commvault.Powershell.Models.IRpo) content.GetValueForProperty("Rpo",((Commvault.Powershell.Models.IReplicationGroupInternal)this).Rpo, Commvault.Powershell.Models.RpoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).Storage = (Commvault.Powershell.Models.IReplicationGroupStorageList) content.GetValueForProperty("Storage",((Commvault.Powershell.Models.IReplicationGroupInternal)this).Storage, Commvault.Powershell.Models.ReplicationGroupStorageListTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IReplicationGroupInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IReplicationGroupInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IReplicationGroupInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).AdvancedOptionUnconditionalOverwrite = (bool?) content.GetValueForProperty("AdvancedOptionUnconditionalOverwrite",((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).AdvancedOptionUnconditionalOverwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).AdvancedOptionDeployVMOnlyDuringfailover = (bool?) content.GetValueForProperty("AdvancedOptionDeployVMOnlyDuringfailover",((Commvault.Powershell.Models.IAzureReplicationGroupInternal)this).AdvancedOptionDeployVMOnlyDuringfailover, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.AzureReplicationGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IAzureReplicationGroup" />.
        /// </returns>
        public static Commvault.Powershell.Models.IAzureReplicationGroup DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureReplicationGroup(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.AzureReplicationGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IAzureReplicationGroup" />.
        /// </returns>
        public static Commvault.Powershell.Models.IAzureReplicationGroup DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureReplicationGroup(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureReplicationGroup" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IAzureReplicationGroup FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Replication group details pertaining to Azure
    [System.ComponentModel.TypeConverter(typeof(AzureReplicationGroupTypeConverter))]
    public partial interface IAzureReplicationGroup

    {

    }
}