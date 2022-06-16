// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(ServerDetailsTypeConverter))]
    public partial class ServerDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.ServerDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IServerDetails" />.</returns>
        public static Commvault.Powershell.Models.IServerDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServerDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.ServerDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IServerDetails" />.</returns>
        public static Commvault.Powershell.Models.IServerDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServerDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServerDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IServerDetails FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.ServerDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServerDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IServerDetailsInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IServerDetailsInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IServerDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IServerDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServerDetailsInternal)this).Agent = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("Agent",((Commvault.Powershell.Models.IServerDetailsInternal)this).Agent, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IServerDetailsInternal)this).Version = (string) content.GetValueForProperty("Version",((Commvault.Powershell.Models.IServerDetailsInternal)this).Version, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServerDetailsInternal)this).OS = (string) content.GetValueForProperty("OS",((Commvault.Powershell.Models.IServerDetailsInternal)this).OS, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServerDetailsInternal)this).UpdateStatus = (string) content.GetValueForProperty("UpdateStatus",((Commvault.Powershell.Models.IServerDetailsInternal)this).UpdateStatus, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.ServerDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServerDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IServerDetailsInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IServerDetailsInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IServerDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IServerDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServerDetailsInternal)this).Agent = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("Agent",((Commvault.Powershell.Models.IServerDetailsInternal)this).Agent, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IServerDetailsInternal)this).Version = (string) content.GetValueForProperty("Version",((Commvault.Powershell.Models.IServerDetailsInternal)this).Version, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServerDetailsInternal)this).OS = (string) content.GetValueForProperty("OS",((Commvault.Powershell.Models.IServerDetailsInternal)this).OS, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServerDetailsInternal)this).UpdateStatus = (string) content.GetValueForProperty("UpdateStatus",((Commvault.Powershell.Models.IServerDetailsInternal)this).UpdateStatus, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ServerDetailsTypeConverter))]
    public partial interface IServerDetails

    {

    }
}