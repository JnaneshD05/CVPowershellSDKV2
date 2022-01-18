// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>
    /// Create a replication group with HyperV as the destination vendor. SourceHypervisor is the hypervisor that has the VM's
    /// to be backed up. Recovery target contains the replication options that will be applied to the selected VM's. ID is mandatory
    /// for sourceHypervisor and recovery target. Provide both the id and the name for the storage and the vms.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(CreateReplicationGroupHyperVTypeConverter))]
    public partial class CreateReplicationGroupHyperV
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.CreateReplicationGroupHyperV"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CreateReplicationGroupHyperV(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).AdvancedOptions = (Commvault.Powershell.Models.IReplicationGroupAdvOptionsHyperV) content.GetValueForProperty("AdvancedOptions",((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).AdvancedOptions, Commvault.Powershell.Models.ReplicationGroupAdvOptionsHyperVTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).DestVendor = (string) content.GetValueForProperty("DestVendor",((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).DestVendor, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).OverrideReplicationOptions = (Commvault.Powershell.Models.IOverrideReplicationOptionsHyperVCreate[]) content.GetValueForProperty("OverrideReplicationOptions",((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).OverrideReplicationOptions, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IOverrideReplicationOptionsHyperVCreate>(__y, Commvault.Powershell.Models.OverrideReplicationOptionsHyperVCreateTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).SourceHypervisorId = (int?) content.GetValueForProperty("SourceHypervisorId",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).SourceHypervisorId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).SourceHypervisorName = (string) content.GetValueForProperty("SourceHypervisorName",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).SourceHypervisorName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).RecoveryTargetId = (int?) content.GetValueForProperty("RecoveryTargetId",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).RecoveryTargetId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).RecoveryTargetName = (string) content.GetValueForProperty("RecoveryTargetName",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).RecoveryTargetName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).SourceHypervisor = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SourceHypervisor",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).SourceHypervisor, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).RecoveryTarget = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("RecoveryTarget",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).RecoveryTarget, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).Vms = (Commvault.Powershell.Models.INameGuid[]) content.GetValueForProperty("Vms",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).Vms, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.INameGuid>(__y, Commvault.Powershell.Models.NameGuidTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).FrequencyInMinutes = (int?) content.GetValueForProperty("FrequencyInMinutes",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).FrequencyInMinutes, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).Storage = (Commvault.Powershell.Models.IStorageCopyCreate[]) content.GetValueForProperty("Storage",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).Storage, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IStorageCopyCreate>(__y, Commvault.Powershell.Models.StorageCopyCreateTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).AdvancedOptionValidateDestinationVM = (bool?) content.GetValueForProperty("AdvancedOptionValidateDestinationVM",((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).AdvancedOptionValidateDestinationVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).AdvancedOptionUnconditionalOverwrite = (bool?) content.GetValueForProperty("AdvancedOptionUnconditionalOverwrite",((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).AdvancedOptionUnconditionalOverwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.CreateReplicationGroupHyperV"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CreateReplicationGroupHyperV(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).AdvancedOptions = (Commvault.Powershell.Models.IReplicationGroupAdvOptionsHyperV) content.GetValueForProperty("AdvancedOptions",((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).AdvancedOptions, Commvault.Powershell.Models.ReplicationGroupAdvOptionsHyperVTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).DestVendor = (string) content.GetValueForProperty("DestVendor",((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).DestVendor, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).OverrideReplicationOptions = (Commvault.Powershell.Models.IOverrideReplicationOptionsHyperVCreate[]) content.GetValueForProperty("OverrideReplicationOptions",((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).OverrideReplicationOptions, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IOverrideReplicationOptionsHyperVCreate>(__y, Commvault.Powershell.Models.OverrideReplicationOptionsHyperVCreateTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).SourceHypervisorId = (int?) content.GetValueForProperty("SourceHypervisorId",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).SourceHypervisorId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).SourceHypervisorName = (string) content.GetValueForProperty("SourceHypervisorName",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).SourceHypervisorName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).RecoveryTargetId = (int?) content.GetValueForProperty("RecoveryTargetId",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).RecoveryTargetId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).RecoveryTargetName = (string) content.GetValueForProperty("RecoveryTargetName",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).RecoveryTargetName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).SourceHypervisor = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SourceHypervisor",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).SourceHypervisor, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).RecoveryTarget = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("RecoveryTarget",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).RecoveryTarget, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).Vms = (Commvault.Powershell.Models.INameGuid[]) content.GetValueForProperty("Vms",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).Vms, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.INameGuid>(__y, Commvault.Powershell.Models.NameGuidTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).FrequencyInMinutes = (int?) content.GetValueForProperty("FrequencyInMinutes",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).FrequencyInMinutes, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).Storage = (Commvault.Powershell.Models.IStorageCopyCreate[]) content.GetValueForProperty("Storage",((Commvault.Powershell.Models.ICreateReplicationGroupInternal)this).Storage, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IStorageCopyCreate>(__y, Commvault.Powershell.Models.StorageCopyCreateTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).AdvancedOptionValidateDestinationVM = (bool?) content.GetValueForProperty("AdvancedOptionValidateDestinationVM",((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).AdvancedOptionValidateDestinationVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).AdvancedOptionUnconditionalOverwrite = (bool?) content.GetValueForProperty("AdvancedOptionUnconditionalOverwrite",((Commvault.Powershell.Models.ICreateReplicationGroupHyperVInternal)this).AdvancedOptionUnconditionalOverwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.CreateReplicationGroupHyperV"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.ICreateReplicationGroupHyperV" />.
        /// </returns>
        public static Commvault.Powershell.Models.ICreateReplicationGroupHyperV DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CreateReplicationGroupHyperV(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.CreateReplicationGroupHyperV"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.ICreateReplicationGroupHyperV" />.
        /// </returns>
        public static Commvault.Powershell.Models.ICreateReplicationGroupHyperV DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CreateReplicationGroupHyperV(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CreateReplicationGroupHyperV" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.ICreateReplicationGroupHyperV FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Create a replication group with HyperV as the destination vendor. SourceHypervisor is the hypervisor that has the VM's
    /// to be backed up. Recovery target contains the replication options that will be applied to the selected VM's. ID is mandatory
    /// for sourceHypervisor and recovery target. Provide both the id and the name for the storage and the vms.
    [System.ComponentModel.TypeConverter(typeof(CreateReplicationGroupHyperVTypeConverter))]
    public partial interface ICreateReplicationGroupHyperV

    {

    }
}