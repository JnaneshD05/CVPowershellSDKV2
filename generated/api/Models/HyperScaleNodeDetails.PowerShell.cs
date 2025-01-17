// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>HyperScaleNodeDetails</summary>
    [System.ComponentModel.TypeConverter(typeof(HyperScaleNodeDetailsTypeConverter))]
    public partial class HyperScaleNodeDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.HyperScaleNodeDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IHyperScaleNodeDetails" />.
        /// </returns>
        public static Commvault.Powershell.Models.IHyperScaleNodeDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HyperScaleNodeDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.HyperScaleNodeDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IHyperScaleNodeDetails" />.
        /// </returns>
        public static Commvault.Powershell.Models.IHyperScaleNodeDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HyperScaleNodeDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HyperScaleNodeDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IHyperScaleNodeDetails FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.HyperScaleNodeDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HyperScaleNodeDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).Node = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Node",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).Node, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformation = (Commvault.Powershell.Models.IHyperScaleDiskInfo) content.GetValueForProperty("DiskInformation",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformation, Commvault.Powershell.Models.HyperScaleDiskInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformation = (Commvault.Powershell.Models.IHyperScaleServerInfo) content.GetValueForProperty("ServerInformation",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformation, Commvault.Powershell.Models.HyperScaleServerInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).Disks = (Commvault.Powershell.Models.IHyperScaleNodeDisk[]) content.GetValueForProperty("Disks",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).Disks, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IHyperScaleNodeDisk>(__y, Commvault.Powershell.Models.HyperScaleNodeDiskTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).NodeId = (int?) content.GetValueForProperty("NodeId",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).NodeId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).NodeName = (string) content.GetValueForProperty("NodeName",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).NodeName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationVendor = (string) content.GetValueForProperty("DiskInformationVendor",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationVendor, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationProduct = (string) content.GetValueForProperty("DiskInformationProduct",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationProduct, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationFileSystem = (string) content.GetValueForProperty("DiskInformationFileSystem",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationFileSystem, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationStatus = (string) content.GetValueForProperty("DiskInformationStatus",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationCpu = (string) content.GetValueForProperty("ServerInformationCpu",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationCpu, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationFan = (string) content.GetValueForProperty("ServerInformationFan",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationFan, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationPowerSupply = (string) content.GetValueForProperty("ServerInformationPowerSupply",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationPowerSupply, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationCacheDrive = (string) content.GetValueForProperty("ServerInformationCacheDrive",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationCacheDrive, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationNicStatus = (string) content.GetValueForProperty("ServerInformationNicStatus",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationNicStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationCpuUsage = (string) content.GetValueForProperty("ServerInformationCpuUsage",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationCpuUsage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationMemoryUsage = (string) content.GetValueForProperty("ServerInformationMemoryUsage",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationMemoryUsage, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.HyperScaleNodeDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HyperScaleNodeDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).Node = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Node",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).Node, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformation = (Commvault.Powershell.Models.IHyperScaleDiskInfo) content.GetValueForProperty("DiskInformation",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformation, Commvault.Powershell.Models.HyperScaleDiskInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformation = (Commvault.Powershell.Models.IHyperScaleServerInfo) content.GetValueForProperty("ServerInformation",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformation, Commvault.Powershell.Models.HyperScaleServerInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).Disks = (Commvault.Powershell.Models.IHyperScaleNodeDisk[]) content.GetValueForProperty("Disks",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).Disks, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IHyperScaleNodeDisk>(__y, Commvault.Powershell.Models.HyperScaleNodeDiskTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).NodeId = (int?) content.GetValueForProperty("NodeId",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).NodeId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).NodeName = (string) content.GetValueForProperty("NodeName",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).NodeName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationVendor = (string) content.GetValueForProperty("DiskInformationVendor",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationVendor, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationProduct = (string) content.GetValueForProperty("DiskInformationProduct",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationProduct, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationFileSystem = (string) content.GetValueForProperty("DiskInformationFileSystem",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationFileSystem, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationStatus = (string) content.GetValueForProperty("DiskInformationStatus",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).DiskInformationStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationCpu = (string) content.GetValueForProperty("ServerInformationCpu",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationCpu, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationFan = (string) content.GetValueForProperty("ServerInformationFan",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationFan, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationPowerSupply = (string) content.GetValueForProperty("ServerInformationPowerSupply",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationPowerSupply, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationCacheDrive = (string) content.GetValueForProperty("ServerInformationCacheDrive",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationCacheDrive, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationNicStatus = (string) content.GetValueForProperty("ServerInformationNicStatus",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationNicStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationCpuUsage = (string) content.GetValueForProperty("ServerInformationCpuUsage",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationCpuUsage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationMemoryUsage = (string) content.GetValueForProperty("ServerInformationMemoryUsage",((Commvault.Powershell.Models.IHyperScaleNodeDetailsInternal)this).ServerInformationMemoryUsage, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// HyperScaleNodeDetails
    [System.ComponentModel.TypeConverter(typeof(HyperScaleNodeDetailsTypeConverter))]
    public partial interface IHyperScaleNodeDetails

    {

    }
}