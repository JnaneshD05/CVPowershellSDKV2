// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(SnapCopyInfoTypeConverter))]
    public partial class SnapCopyInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.SnapCopyInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ISnapCopyInfo" />.</returns>
        public static Commvault.Powershell.Models.ISnapCopyInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SnapCopyInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.SnapCopyInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ISnapCopyInfo" />.</returns>
        public static Commvault.Powershell.Models.ISnapCopyInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SnapCopyInfo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SnapCopyInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.ISnapCopyInfo FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.SnapCopyInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SnapCopyInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapEngine = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SnapEngine",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapEngine, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).CrossAccountCopyDestinationClient = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("CrossAccountCopyDestinationClient",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).CrossAccountCopyDestinationClient, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountProxy = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SnapMountProxy",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountProxy, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).EnableHardwareSnapshot = (bool?) content.GetValueForProperty("EnableHardwareSnapshot",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).EnableHardwareSnapshot, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountEsxHost = (string) content.GetValueForProperty("SnapMountEsxHost",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountEsxHost, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsIndependentDisksEnabled = (bool?) content.GetValueForProperty("IsIndependentDisksEnabled",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsIndependentDisksEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsRawDeviceMapsEnabled = (bool?) content.GetValueForProperty("IsRawDeviceMapsEnabled",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsRawDeviceMapsEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).UseSeparateProxyForSnapToTape = (bool?) content.GetValueForProperty("UseSeparateProxyForSnapToTape",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).UseSeparateProxyForSnapToTape, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsCrossAccountEnabled = (bool?) content.GetValueForProperty("IsCrossAccountEnabled",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsCrossAccountEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsCrossAccountCopyEnabled = (bool?) content.GetValueForProperty("IsCrossAccountCopyEnabled",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsCrossAccountCopyEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).VMApplicationUserName = (string) content.GetValueForProperty("VMApplicationUserName",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).VMApplicationUserName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).BackupCopyInterface = (string) content.GetValueForProperty("BackupCopyInterface",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).BackupCopyInterface, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapEngineId = (int?) content.GetValueForProperty("SnapEngineId",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapEngineId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapEngineName = (string) content.GetValueForProperty("SnapEngineName",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapEngineName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).CrossAccountCopyDestinationClientId = (int?) content.GetValueForProperty("CrossAccountCopyDestinationClientId",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).CrossAccountCopyDestinationClientId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).CrossAccountCopyDestinationClientName = (string) content.GetValueForProperty("CrossAccountCopyDestinationClientName",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).CrossAccountCopyDestinationClientName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountProxyId = (int?) content.GetValueForProperty("SnapMountProxyId",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountProxyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountProxyName = (string) content.GetValueForProperty("SnapMountProxyName",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountProxyName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.SnapCopyInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SnapCopyInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapEngine = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SnapEngine",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapEngine, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).CrossAccountCopyDestinationClient = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("CrossAccountCopyDestinationClient",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).CrossAccountCopyDestinationClient, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountProxy = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SnapMountProxy",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountProxy, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).EnableHardwareSnapshot = (bool?) content.GetValueForProperty("EnableHardwareSnapshot",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).EnableHardwareSnapshot, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountEsxHost = (string) content.GetValueForProperty("SnapMountEsxHost",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountEsxHost, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsIndependentDisksEnabled = (bool?) content.GetValueForProperty("IsIndependentDisksEnabled",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsIndependentDisksEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsRawDeviceMapsEnabled = (bool?) content.GetValueForProperty("IsRawDeviceMapsEnabled",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsRawDeviceMapsEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).UseSeparateProxyForSnapToTape = (bool?) content.GetValueForProperty("UseSeparateProxyForSnapToTape",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).UseSeparateProxyForSnapToTape, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsCrossAccountEnabled = (bool?) content.GetValueForProperty("IsCrossAccountEnabled",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsCrossAccountEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsCrossAccountCopyEnabled = (bool?) content.GetValueForProperty("IsCrossAccountCopyEnabled",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).IsCrossAccountCopyEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).VMApplicationUserName = (string) content.GetValueForProperty("VMApplicationUserName",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).VMApplicationUserName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).BackupCopyInterface = (string) content.GetValueForProperty("BackupCopyInterface",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).BackupCopyInterface, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapEngineId = (int?) content.GetValueForProperty("SnapEngineId",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapEngineId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapEngineName = (string) content.GetValueForProperty("SnapEngineName",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapEngineName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).CrossAccountCopyDestinationClientId = (int?) content.GetValueForProperty("CrossAccountCopyDestinationClientId",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).CrossAccountCopyDestinationClientId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).CrossAccountCopyDestinationClientName = (string) content.GetValueForProperty("CrossAccountCopyDestinationClientName",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).CrossAccountCopyDestinationClientName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountProxyId = (int?) content.GetValueForProperty("SnapMountProxyId",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountProxyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountProxyName = (string) content.GetValueForProperty("SnapMountProxyName",((Commvault.Powershell.Models.ISnapCopyInfoInternal)this).SnapMountProxyName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(SnapCopyInfoTypeConverter))]
    public partial interface ISnapCopyInfo

    {

    }
}