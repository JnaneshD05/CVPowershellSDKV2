// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Advanced options for VMWare replication group</summary>
    [System.ComponentModel.TypeConverter(typeof(ReplicationGroupAdvOptionsVMWareCreateTypeConverter))]
    public partial class ReplicationGroupAdvOptionsVMWareCreate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.ReplicationGroupAdvOptionsVMWareCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreate" />.
        /// </returns>
        public static Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReplicationGroupAdvOptionsVMWareCreate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.ReplicationGroupAdvOptionsVMWareCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreate" />.
        /// </returns>
        public static Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReplicationGroupAdvOptionsVMWareCreate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReplicationGroupAdvOptionsVMWareCreate" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreate FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.ReplicationGroupAdvOptionsVMWareCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReplicationGroupAdvOptionsVMWareCreate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).ValidateDestinationVM = (bool?) content.GetValueForProperty("ValidateDestinationVM",((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).ValidateDestinationVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).DiskProvisioning = (string) content.GetValueForProperty("DiskProvisioning",((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).DiskProvisioning, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).TransportMode = (string) content.GetValueForProperty("TransportMode",((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).TransportMode, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).UnconditionalOverwrite = (bool?) content.GetValueForProperty("UnconditionalOverwrite",((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).UnconditionalOverwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).SnapshotsToRetain = (int?) content.GetValueForProperty("SnapshotsToRetain",((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).SnapshotsToRetain, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.ReplicationGroupAdvOptionsVMWareCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReplicationGroupAdvOptionsVMWareCreate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).ValidateDestinationVM = (bool?) content.GetValueForProperty("ValidateDestinationVM",((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).ValidateDestinationVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).DiskProvisioning = (string) content.GetValueForProperty("DiskProvisioning",((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).DiskProvisioning, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).TransportMode = (string) content.GetValueForProperty("TransportMode",((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).TransportMode, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).UnconditionalOverwrite = (bool?) content.GetValueForProperty("UnconditionalOverwrite",((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).UnconditionalOverwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).SnapshotsToRetain = (int?) content.GetValueForProperty("SnapshotsToRetain",((Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal)this).SnapshotsToRetain, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Advanced options for VMWare replication group
    [System.ComponentModel.TypeConverter(typeof(ReplicationGroupAdvOptionsVMWareCreateTypeConverter))]
    public partial interface IReplicationGroupAdvOptionsVMWareCreate

    {

    }
}