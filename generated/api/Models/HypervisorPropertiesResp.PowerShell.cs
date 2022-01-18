// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(HypervisorPropertiesRespTypeConverter))]
    public partial class HypervisorPropertiesResp
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.HypervisorPropertiesResp"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IHypervisorPropertiesResp" />.
        /// </returns>
        public static Commvault.Powershell.Models.IHypervisorPropertiesResp DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HypervisorPropertiesResp(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.HypervisorPropertiesResp"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IHypervisorPropertiesResp" />.
        /// </returns>
        public static Commvault.Powershell.Models.IHypervisorPropertiesResp DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HypervisorPropertiesResp(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HypervisorPropertiesResp" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IHypervisorPropertiesResp FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.HypervisorPropertiesResp"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HypervisorPropertiesResp(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Instance = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Instance",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Instance, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).General = (Commvault.Powershell.Models.IHypervisorGeneralProperties) content.GetValueForProperty("General",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).General, Commvault.Powershell.Models.HypervisorGeneralPropertiesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).AccountDetails = (Commvault.Powershell.Models.IHypervisorAccountDetails) content.GetValueForProperty("AccountDetails",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).AccountDetails, Commvault.Powershell.Models.HypervisorAccountDetailsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).ActivityControl = (Commvault.Powershell.Models.IActivityControlOptions) content.GetValueForProperty("ActivityControl",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).ActivityControl, Commvault.Powershell.Models.ActivityControlOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Settings = (Commvault.Powershell.Models.IHypervisorSettings) content.GetValueForProperty("Settings",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Settings, Commvault.Powershell.Models.HypervisorSettingsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonProperties = (Commvault.Powershell.Models.IHypervisorCommonProps) content.GetValueForProperty("HypervisorCommonProperties",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonProperties, Commvault.Powershell.Models.HypervisorCommonPropsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).DisplayName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).AccessNodes = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("AccessNodes",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).AccessNodes, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).SettingRegionInfo = (Commvault.Powershell.Models.IRegionInfo) content.GetValueForProperty("SettingRegionInfo",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).SettingRegionInfo, Commvault.Powershell.Models.RegionInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).InstanceId = (int?) content.GetValueForProperty("InstanceId",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).InstanceId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).InstanceName = (string) content.GetValueForProperty("InstanceName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).InstanceName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).GeneralVMBackupInfo = (Commvault.Powershell.Models.IVMBackupInfo) content.GetValueForProperty("GeneralVMBackupInfo",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).GeneralVMBackupInfo, Commvault.Powershell.Models.VMBackupInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).GeneralVendor = (string) content.GetValueForProperty("GeneralVendor",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).GeneralVendor, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).GeneralVersion = (string) content.GetValueForProperty("GeneralVersion",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).GeneralVersion, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).AccountDetailHostName = (string) content.GetValueForProperty("AccountDetailHostName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).AccountDetailHostName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).ActivityControlEnableBackup = (bool?) content.GetValueForProperty("ActivityControlEnableBackup",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).ActivityControlEnableBackup, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).ActivityControlEnableRestore = (bool?) content.GetValueForProperty("ActivityControlEnableRestore",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).ActivityControlEnableRestore, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).SettingTimeZone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SettingTimeZone",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).SettingTimeZone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).SettingMetricsMonitoringPolicy = (Commvault.Powershell.Models.IHypervisorMonitoringPolicy) content.GetValueForProperty("SettingMetricsMonitoringPolicy",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).SettingMetricsMonitoringPolicy, Commvault.Powershell.Models.HypervisorMonitoringPolicyTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoName = (string) content.GetValueForProperty("RegionInfoName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoDisplayName = (string) content.GetValueForProperty("RegionInfoDisplayName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoDisplayName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoLatitude = (string) content.GetValueForProperty("RegionInfoLatitude",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoLatitude, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoLongitude = (string) content.GetValueForProperty("RegionInfoLongitude",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoLongitude, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyCompany = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("HypervisorCommonPropertyCompany",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyCompany, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyIsIndexingV2 = (bool?) content.GetValueForProperty("HypervisorCommonPropertyIsIndexingV2",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyIsIndexingV2, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyIsDeconfigured = (bool?) content.GetValueForProperty("HypervisorCommonPropertyIsDeconfigured",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyIsDeconfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyRetirePhase = (string) content.GetValueForProperty("HypervisorCommonPropertyRetirePhase",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyRetirePhase, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmpendingCount = (int?) content.GetValueForProperty("VMBackupInfoVmpendingCount",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmpendingCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmprotectedCount = (int?) content.GetValueForProperty("VMBackupInfoVmprotectedCount",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmprotectedCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmnotProtectedCount = (int?) content.GetValueForProperty("VMBackupInfoVmnotProtectedCount",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmnotProtectedCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmneverBackedUpCount = (int?) content.GetValueForProperty("VMBackupInfoVmneverBackedUpCount",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmneverBackedUpCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmbackedUpWithErrorCount = (int?) content.GetValueForProperty("VMBackupInfoVmbackedUpWithErrorCount",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmbackedUpWithErrorCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmtotalCount = (int?) content.GetValueForProperty("VMBackupInfoVmtotalCount",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmtotalCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoId = (int?) content.GetValueForProperty("RegionInfoId",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).TimeZoneId = (int?) content.GetValueForProperty("TimeZoneId",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).TimeZoneId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).TimeZoneName = (string) content.GetValueForProperty("TimeZoneName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).TimeZoneName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).MetricMonitoringPolicyId = (int?) content.GetValueForProperty("MetricMonitoringPolicyId",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).MetricMonitoringPolicyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).MetricMonitoringPolicyName = (string) content.GetValueForProperty("MetricMonitoringPolicyName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).MetricMonitoringPolicyName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).MetricMonitoringPolicyIsEnabled = (bool?) content.GetValueForProperty("MetricMonitoringPolicyIsEnabled",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).MetricMonitoringPolicyIsEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).CompanyId = (int?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).CompanyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).CompanyName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.HypervisorPropertiesResp"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HypervisorPropertiesResp(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Instance = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Instance",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Instance, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).General = (Commvault.Powershell.Models.IHypervisorGeneralProperties) content.GetValueForProperty("General",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).General, Commvault.Powershell.Models.HypervisorGeneralPropertiesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).AccountDetails = (Commvault.Powershell.Models.IHypervisorAccountDetails) content.GetValueForProperty("AccountDetails",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).AccountDetails, Commvault.Powershell.Models.HypervisorAccountDetailsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).ActivityControl = (Commvault.Powershell.Models.IActivityControlOptions) content.GetValueForProperty("ActivityControl",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).ActivityControl, Commvault.Powershell.Models.ActivityControlOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Settings = (Commvault.Powershell.Models.IHypervisorSettings) content.GetValueForProperty("Settings",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Settings, Commvault.Powershell.Models.HypervisorSettingsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonProperties = (Commvault.Powershell.Models.IHypervisorCommonProps) content.GetValueForProperty("HypervisorCommonProperties",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonProperties, Commvault.Powershell.Models.HypervisorCommonPropsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).DisplayName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).AccessNodes = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("AccessNodes",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).AccessNodes, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).SettingRegionInfo = (Commvault.Powershell.Models.IRegionInfo) content.GetValueForProperty("SettingRegionInfo",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).SettingRegionInfo, Commvault.Powershell.Models.RegionInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).InstanceId = (int?) content.GetValueForProperty("InstanceId",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).InstanceId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).InstanceName = (string) content.GetValueForProperty("InstanceName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).InstanceName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).GeneralVMBackupInfo = (Commvault.Powershell.Models.IVMBackupInfo) content.GetValueForProperty("GeneralVMBackupInfo",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).GeneralVMBackupInfo, Commvault.Powershell.Models.VMBackupInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).GeneralVendor = (string) content.GetValueForProperty("GeneralVendor",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).GeneralVendor, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).GeneralVersion = (string) content.GetValueForProperty("GeneralVersion",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).GeneralVersion, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).AccountDetailHostName = (string) content.GetValueForProperty("AccountDetailHostName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).AccountDetailHostName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).ActivityControlEnableBackup = (bool?) content.GetValueForProperty("ActivityControlEnableBackup",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).ActivityControlEnableBackup, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).ActivityControlEnableRestore = (bool?) content.GetValueForProperty("ActivityControlEnableRestore",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).ActivityControlEnableRestore, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).SettingTimeZone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SettingTimeZone",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).SettingTimeZone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).SettingMetricsMonitoringPolicy = (Commvault.Powershell.Models.IHypervisorMonitoringPolicy) content.GetValueForProperty("SettingMetricsMonitoringPolicy",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).SettingMetricsMonitoringPolicy, Commvault.Powershell.Models.HypervisorMonitoringPolicyTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoName = (string) content.GetValueForProperty("RegionInfoName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoDisplayName = (string) content.GetValueForProperty("RegionInfoDisplayName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoDisplayName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoLatitude = (string) content.GetValueForProperty("RegionInfoLatitude",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoLatitude, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoLongitude = (string) content.GetValueForProperty("RegionInfoLongitude",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoLongitude, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyCompany = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("HypervisorCommonPropertyCompany",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyCompany, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyIsIndexingV2 = (bool?) content.GetValueForProperty("HypervisorCommonPropertyIsIndexingV2",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyIsIndexingV2, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyIsDeconfigured = (bool?) content.GetValueForProperty("HypervisorCommonPropertyIsDeconfigured",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyIsDeconfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyRetirePhase = (string) content.GetValueForProperty("HypervisorCommonPropertyRetirePhase",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).HypervisorCommonPropertyRetirePhase, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmpendingCount = (int?) content.GetValueForProperty("VMBackupInfoVmpendingCount",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmpendingCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmprotectedCount = (int?) content.GetValueForProperty("VMBackupInfoVmprotectedCount",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmprotectedCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmnotProtectedCount = (int?) content.GetValueForProperty("VMBackupInfoVmnotProtectedCount",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmnotProtectedCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmneverBackedUpCount = (int?) content.GetValueForProperty("VMBackupInfoVmneverBackedUpCount",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmneverBackedUpCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmbackedUpWithErrorCount = (int?) content.GetValueForProperty("VMBackupInfoVmbackedUpWithErrorCount",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmbackedUpWithErrorCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmtotalCount = (int?) content.GetValueForProperty("VMBackupInfoVmtotalCount",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).VMBackupInfoVmtotalCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoId = (int?) content.GetValueForProperty("RegionInfoId",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).RegionInfoId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).TimeZoneId = (int?) content.GetValueForProperty("TimeZoneId",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).TimeZoneId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).TimeZoneName = (string) content.GetValueForProperty("TimeZoneName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).TimeZoneName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).MetricMonitoringPolicyId = (int?) content.GetValueForProperty("MetricMonitoringPolicyId",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).MetricMonitoringPolicyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).MetricMonitoringPolicyName = (string) content.GetValueForProperty("MetricMonitoringPolicyName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).MetricMonitoringPolicyName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).MetricMonitoringPolicyIsEnabled = (bool?) content.GetValueForProperty("MetricMonitoringPolicyIsEnabled",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).MetricMonitoringPolicyIsEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).CompanyId = (int?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).CompanyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IHypervisorPropertiesRespInternal)this).CompanyName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(HypervisorPropertiesRespTypeConverter))]
    public partial interface IHypervisorPropertiesResp

    {

    }
}