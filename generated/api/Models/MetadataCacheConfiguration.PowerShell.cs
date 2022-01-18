// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>MetadataCacheConfiguration</summary>
    [System.ComponentModel.TypeConverter(typeof(MetadataCacheConfigurationTypeConverter))]
    public partial class MetadataCacheConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.MetadataCacheConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IMetadataCacheConfiguration" />.
        /// </returns>
        public static Commvault.Powershell.Models.IMetadataCacheConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MetadataCacheConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.MetadataCacheConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IMetadataCacheConfiguration" />.
        /// </returns>
        public static Commvault.Powershell.Models.IMetadataCacheConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MetadataCacheConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MetadataCacheConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IMetadataCacheConfiguration FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.MetadataCacheConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MetadataCacheConfiguration(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MediaAgent = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("MediaAgent",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MediaAgent, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).Credentials = (Commvault.Powershell.Models.IUserNamePassword) content.GetValueForProperty("Credentials",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).Credentials, Commvault.Powershell.Models.UserNamePasswordTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).SavedCredentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SavedCredentials",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).SavedCredentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).Path = (string) content.GetValueForProperty("Path",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).Path, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MetadataCache = (Commvault.Powershell.Models.IMetadataCache[]) content.GetValueForProperty("MetadataCache",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MetadataCache, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IMetadataCache>(__y, Commvault.Powershell.Models.MetadataCacheTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MediaAgentId = (int?) content.GetValueForProperty("MediaAgentId",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MediaAgentId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MediaAgentName = (string) content.GetValueForProperty("MediaAgentName",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MediaAgentName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).CredentialsName = (string) content.GetValueForProperty("CredentialsName",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).CredentialsName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).CredentialsPassword = (string) content.GetValueForProperty("CredentialsPassword",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).CredentialsPassword, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).SavedCredentialsId = (int?) content.GetValueForProperty("SavedCredentialsId",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).SavedCredentialsId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).SavedCredentialsName = (string) content.GetValueForProperty("SavedCredentialsName",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).SavedCredentialsName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.MetadataCacheConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MetadataCacheConfiguration(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MediaAgent = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("MediaAgent",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MediaAgent, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).Credentials = (Commvault.Powershell.Models.IUserNamePassword) content.GetValueForProperty("Credentials",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).Credentials, Commvault.Powershell.Models.UserNamePasswordTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).SavedCredentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SavedCredentials",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).SavedCredentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).Path = (string) content.GetValueForProperty("Path",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).Path, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MetadataCache = (Commvault.Powershell.Models.IMetadataCache[]) content.GetValueForProperty("MetadataCache",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MetadataCache, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IMetadataCache>(__y, Commvault.Powershell.Models.MetadataCacheTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MediaAgentId = (int?) content.GetValueForProperty("MediaAgentId",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MediaAgentId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MediaAgentName = (string) content.GetValueForProperty("MediaAgentName",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).MediaAgentName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).CredentialsName = (string) content.GetValueForProperty("CredentialsName",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).CredentialsName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).CredentialsPassword = (string) content.GetValueForProperty("CredentialsPassword",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).CredentialsPassword, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).SavedCredentialsId = (int?) content.GetValueForProperty("SavedCredentialsId",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).SavedCredentialsId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).SavedCredentialsName = (string) content.GetValueForProperty("SavedCredentialsName",((Commvault.Powershell.Models.IMetadataCacheConfigurationInternal)this).SavedCredentialsName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// MetadataCacheConfiguration
    [System.ComponentModel.TypeConverter(typeof(MetadataCacheConfigurationTypeConverter))]
    public partial interface IMetadataCacheConfiguration

    {

    }
}