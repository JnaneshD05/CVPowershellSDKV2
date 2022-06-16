// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(HypervisorListRespTypeConverter))]
    public partial class HypervisorListResp
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.HypervisorListResp"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IHypervisorListResp" />.</returns>
        public static Commvault.Powershell.Models.IHypervisorListResp DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HypervisorListResp(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.HypervisorListResp"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IHypervisorListResp" />.</returns>
        public static Commvault.Powershell.Models.IHypervisorListResp DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HypervisorListResp(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HypervisorListResp" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IHypervisorListResp FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.HypervisorListResp"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HypervisorListResp(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Instance = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Instance",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Instance, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControl = (Commvault.Powershell.Models.IActivityControlOptionsProp) content.GetValueForProperty("ClientActivityControl",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControl, Commvault.Powershell.Models.ActivityControlOptionsPropTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Commcell = (Commvault.Powershell.Models.ICommcellInfo) content.GetValueForProperty("Commcell",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Commcell, Commvault.Powershell.Models.CommcellInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DisplayName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).HostName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).HypervisorType = (string) content.GetValueForProperty("HypervisorType",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).HypervisorType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Status = (string) content.GetValueForProperty("Status",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Status, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Version = (string) content.GetValueForProperty("Version",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Version, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Tags = (Commvault.Powershell.Models.IIdNameValue[]) content.GetValueForProperty("Tags",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdNameValue>(__y, Commvault.Powershell.Models.IdNameValueTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).InstanceId = (int?) content.GetValueForProperty("InstanceId",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).InstanceId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).InstanceName = (string) content.GetValueForProperty("InstanceName",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).InstanceName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlDelayTime = (Commvault.Powershell.Models.IActivityControlTileDelayTime) content.GetValueForProperty("ClientActivityControlDelayTime",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlDelayTime, Commvault.Powershell.Models.ActivityControlTileDelayTimeTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlActivityType = (string) content.GetValueForProperty("ClientActivityControlActivityType",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlActivityType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlEnableAfterADelay = (bool?) content.GetValueForProperty("ClientActivityControlEnableAfterADelay",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlEnableAfterADelay, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlEnableActivityType = (bool?) content.GetValueForProperty("ClientActivityControlEnableActivityType",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlEnableActivityType, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).CommcellName = (string) content.GetValueForProperty("CommcellName",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).CommcellName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DelayTimeZone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("DelayTimeZone",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DelayTimeZone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DelayTime = (int?) content.GetValueForProperty("DelayTime",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DelayTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DelayTimeValue = (string) content.GetValueForProperty("DelayTimeValue",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DelayTimeValue, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).TimeZoneId = (int?) content.GetValueForProperty("TimeZoneId",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).TimeZoneId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).TimeZoneName = (string) content.GetValueForProperty("TimeZoneName",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).TimeZoneName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.HypervisorListResp"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HypervisorListResp(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Instance = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Instance",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Instance, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControl = (Commvault.Powershell.Models.IActivityControlOptionsProp) content.GetValueForProperty("ClientActivityControl",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControl, Commvault.Powershell.Models.ActivityControlOptionsPropTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Commcell = (Commvault.Powershell.Models.ICommcellInfo) content.GetValueForProperty("Commcell",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Commcell, Commvault.Powershell.Models.CommcellInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DisplayName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).HostName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).HypervisorType = (string) content.GetValueForProperty("HypervisorType",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).HypervisorType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Status = (string) content.GetValueForProperty("Status",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Status, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Version = (string) content.GetValueForProperty("Version",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Version, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Tags = (Commvault.Powershell.Models.IIdNameValue[]) content.GetValueForProperty("Tags",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdNameValue>(__y, Commvault.Powershell.Models.IdNameValueTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).InstanceId = (int?) content.GetValueForProperty("InstanceId",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).InstanceId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).InstanceName = (string) content.GetValueForProperty("InstanceName",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).InstanceName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlDelayTime = (Commvault.Powershell.Models.IActivityControlTileDelayTime) content.GetValueForProperty("ClientActivityControlDelayTime",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlDelayTime, Commvault.Powershell.Models.ActivityControlTileDelayTimeTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlActivityType = (string) content.GetValueForProperty("ClientActivityControlActivityType",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlActivityType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlEnableAfterADelay = (bool?) content.GetValueForProperty("ClientActivityControlEnableAfterADelay",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlEnableAfterADelay, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlEnableActivityType = (bool?) content.GetValueForProperty("ClientActivityControlEnableActivityType",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).ClientActivityControlEnableActivityType, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).CommcellName = (string) content.GetValueForProperty("CommcellName",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).CommcellName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DelayTimeZone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("DelayTimeZone",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DelayTimeZone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DelayTime = (int?) content.GetValueForProperty("DelayTime",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DelayTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DelayTimeValue = (string) content.GetValueForProperty("DelayTimeValue",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).DelayTimeValue, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).TimeZoneId = (int?) content.GetValueForProperty("TimeZoneId",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).TimeZoneId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorListRespInternal)this).TimeZoneName = (string) content.GetValueForProperty("TimeZoneName",((Commvault.Powershell.Models.IHypervisorListRespInternal)this).TimeZoneName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(HypervisorListRespTypeConverter))]
    public partial interface IHypervisorListResp

    {

    }
}