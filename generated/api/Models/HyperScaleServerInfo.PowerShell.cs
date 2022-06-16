// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>HyperScaleServerInfo</summary>
    [System.ComponentModel.TypeConverter(typeof(HyperScaleServerInfoTypeConverter))]
    public partial class HyperScaleServerInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.HyperScaleServerInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IHyperScaleServerInfo" />.
        /// </returns>
        public static Commvault.Powershell.Models.IHyperScaleServerInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HyperScaleServerInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.HyperScaleServerInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IHyperScaleServerInfo" />.
        /// </returns>
        public static Commvault.Powershell.Models.IHyperScaleServerInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HyperScaleServerInfo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HyperScaleServerInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IHyperScaleServerInfo FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.HyperScaleServerInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HyperScaleServerInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).Cpu = (string) content.GetValueForProperty("Cpu",((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).Cpu, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).Fan = (string) content.GetValueForProperty("Fan",((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).Fan, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).PowerSupply = (string) content.GetValueForProperty("PowerSupply",((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).PowerSupply, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).CacheDrive = (string) content.GetValueForProperty("CacheDrive",((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).CacheDrive, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).NicStatus = (string) content.GetValueForProperty("NicStatus",((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).NicStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).CpuUsage = (string) content.GetValueForProperty("CpuUsage",((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).CpuUsage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).MemoryUsage = (string) content.GetValueForProperty("MemoryUsage",((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).MemoryUsage, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.HyperScaleServerInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HyperScaleServerInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).Cpu = (string) content.GetValueForProperty("Cpu",((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).Cpu, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).Fan = (string) content.GetValueForProperty("Fan",((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).Fan, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).PowerSupply = (string) content.GetValueForProperty("PowerSupply",((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).PowerSupply, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).CacheDrive = (string) content.GetValueForProperty("CacheDrive",((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).CacheDrive, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).NicStatus = (string) content.GetValueForProperty("NicStatus",((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).NicStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).CpuUsage = (string) content.GetValueForProperty("CpuUsage",((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).CpuUsage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).MemoryUsage = (string) content.GetValueForProperty("MemoryUsage",((Commvault.Powershell.Models.IHyperScaleServerInfoInternal)this).MemoryUsage, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// HyperScaleServerInfo
    [System.ComponentModel.TypeConverter(typeof(HyperScaleServerInfoTypeConverter))]
    public partial interface IHyperScaleServerInfo

    {

    }
}