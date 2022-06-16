// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Replication configuration for Azure</summary>
    [System.ComponentModel.TypeConverter(typeof(ReplicationConfigurationAzureTypeConverter))]
    public partial class ReplicationConfigurationAzure
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.ReplicationConfigurationAzure"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IReplicationConfigurationAzure" />.
        /// </returns>
        public static Commvault.Powershell.Models.IReplicationConfigurationAzure DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReplicationConfigurationAzure(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.ReplicationConfigurationAzure"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IReplicationConfigurationAzure" />.
        /// </returns>
        public static Commvault.Powershell.Models.IReplicationConfigurationAzure DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReplicationConfigurationAzure(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReplicationConfigurationAzure" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IReplicationConfigurationAzure FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.ReplicationConfigurationAzure"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReplicationConfigurationAzure(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).OverrideReplicationOptions = (Commvault.Powershell.Models.IOverrideReplicationOptionsAzure) content.GetValueForProperty("OverrideReplicationOptions",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).OverrideReplicationOptions, Commvault.Powershell.Models.OverrideReplicationOptionsAzureTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).SourceVM = (string) content.GetValueForProperty("SourceVM",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).SourceVM, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).DestinationVM = (string) content.GetValueForProperty("DestinationVM",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).DestinationVM, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).ResourceGroup = (string) content.GetValueForProperty("ResourceGroup",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).ResourceGroup, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).StorageAccount = (string) content.GetValueForProperty("StorageAccount",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).StorageAccount, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).VMSize = (string) content.GetValueForProperty("VMSize",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).VMSize, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).CreatePublicIP = (bool?) content.GetValueForProperty("CreatePublicIP",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).CreatePublicIP, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).RestoreAsManagedVM = (bool?) content.GetValueForProperty("RestoreAsManagedVM",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).RestoreAsManagedVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).OverrideReplicationOptionVMDisplayName = (string) content.GetValueForProperty("OverrideReplicationOptionVMDisplayName",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).OverrideReplicationOptionVMDisplayName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.ReplicationConfigurationAzure"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReplicationConfigurationAzure(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).OverrideReplicationOptions = (Commvault.Powershell.Models.IOverrideReplicationOptionsAzure) content.GetValueForProperty("OverrideReplicationOptions",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).OverrideReplicationOptions, Commvault.Powershell.Models.OverrideReplicationOptionsAzureTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).SourceVM = (string) content.GetValueForProperty("SourceVM",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).SourceVM, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).DestinationVM = (string) content.GetValueForProperty("DestinationVM",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).DestinationVM, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).ResourceGroup = (string) content.GetValueForProperty("ResourceGroup",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).ResourceGroup, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).StorageAccount = (string) content.GetValueForProperty("StorageAccount",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).StorageAccount, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).VMSize = (string) content.GetValueForProperty("VMSize",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).VMSize, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).CreatePublicIP = (bool?) content.GetValueForProperty("CreatePublicIP",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).CreatePublicIP, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).RestoreAsManagedVM = (bool?) content.GetValueForProperty("RestoreAsManagedVM",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).RestoreAsManagedVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).OverrideReplicationOptionVMDisplayName = (string) content.GetValueForProperty("OverrideReplicationOptionVMDisplayName",((Commvault.Powershell.Models.IReplicationConfigurationAzureInternal)this).OverrideReplicationOptionVMDisplayName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Replication configuration for Azure
    [System.ComponentModel.TypeConverter(typeof(ReplicationConfigurationAzureTypeConverter))]
    public partial interface IReplicationConfigurationAzure

    {

    }
}