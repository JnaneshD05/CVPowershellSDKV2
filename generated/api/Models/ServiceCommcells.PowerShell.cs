// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Returns a list of service commcells</summary>
    [System.ComponentModel.TypeConverter(typeof(ServiceCommcellsTypeConverter))]
    public partial class ServiceCommcells
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.ServiceCommcells"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IServiceCommcells" />.</returns>
        public static Commvault.Powershell.Models.IServiceCommcells DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServiceCommcells(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.ServiceCommcells"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IServiceCommcells" />.</returns>
        public static Commvault.Powershell.Models.IServiceCommcells DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServiceCommcells(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServiceCommcells" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IServiceCommcells FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.ServiceCommcells"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServiceCommcells(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatus = (Commvault.Powershell.Models.ISyncStatus1) content.GetValueForProperty("SyncStatus",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatus, Commvault.Powershell.Models.SyncStatus1TypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Hostname, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Role = (string) content.GetValueForProperty("Role",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Role, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).UseUniversalCommandCenter = (bool?) content.GetValueForProperty("UseUniversalCommandCenter",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).UseUniversalCommandCenter, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatusErrorMessage = (Commvault.Powershell.Models.INameMessage[]) content.GetValueForProperty("SyncStatusErrorMessage",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatusErrorMessage, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.INameMessage>(__y, Commvault.Powershell.Models.NameMessageTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatusStatus = (string) content.GetValueForProperty("SyncStatusStatus",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatusStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatusLastSyncedWithIdp = (int?) content.GetValueForProperty("SyncStatusLastSyncedWithIdp",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatusLastSyncedWithIdp, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.ServiceCommcells"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServiceCommcells(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatus = (Commvault.Powershell.Models.ISyncStatus1) content.GetValueForProperty("SyncStatus",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatus, Commvault.Powershell.Models.SyncStatus1TypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Hostname, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Role = (string) content.GetValueForProperty("Role",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).Role, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).UseUniversalCommandCenter = (bool?) content.GetValueForProperty("UseUniversalCommandCenter",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).UseUniversalCommandCenter, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatusErrorMessage = (Commvault.Powershell.Models.INameMessage[]) content.GetValueForProperty("SyncStatusErrorMessage",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatusErrorMessage, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.INameMessage>(__y, Commvault.Powershell.Models.NameMessageTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatusStatus = (string) content.GetValueForProperty("SyncStatusStatus",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatusStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatusLastSyncedWithIdp = (int?) content.GetValueForProperty("SyncStatusLastSyncedWithIdp",((Commvault.Powershell.Models.IServiceCommcellsInternal)this).SyncStatusLastSyncedWithIdp, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Returns a list of service commcells
    [System.ComponentModel.TypeConverter(typeof(ServiceCommcellsTypeConverter))]
    public partial interface IServiceCommcells

    {

    }
}