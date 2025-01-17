// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Create a new Laptop Plan</summary>
    [System.ComponentModel.TypeConverter(typeof(LaptopPlanTypeConverter))]
    public partial class LaptopPlan
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.LaptopPlan"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ILaptopPlan" />.</returns>
        public static Commvault.Powershell.Models.ILaptopPlan DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LaptopPlan(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.LaptopPlan"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ILaptopPlan" />.</returns>
        public static Commvault.Powershell.Models.ILaptopPlan DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LaptopPlan(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LaptopPlan" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.ILaptopPlan FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.LaptopPlan"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LaptopPlan(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContent = (Commvault.Powershell.Models.ILaptopPlanBackupContent) content.GetValueForProperty("BackupContent",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContent, Commvault.Powershell.Models.LaptopPlanBackupContentTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndSchedule = (Commvault.Powershell.Models.ILaptopPlanStorageAndSchedule) content.GetValueForProperty("StorageAndSchedule",((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndSchedule, Commvault.Powershell.Models.LaptopPlanStorageAndScheduleTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).Retention = (Commvault.Powershell.Models.ILaptopPlanRetention) content.GetValueForProperty("Retention",((Commvault.Powershell.Models.ILaptopPlanInternal)this).Retention, Commvault.Powershell.Models.LaptopPlanRetentionTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).NetworkResources = (Commvault.Powershell.Models.ILaptopPlanNetworkResources) content.GetValueForProperty("NetworkResources",((Commvault.Powershell.Models.ILaptopPlanInternal)this).NetworkResources, Commvault.Powershell.Models.LaptopPlanNetworkResourcesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictions = (Commvault.Powershell.Models.ILaptopPlanOverrideSettings) content.GetValueForProperty("OverrideRestrictions",((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictions, Commvault.Powershell.Models.LaptopPlanOverrideSettingsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).ParentPlan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("ParentPlan",((Commvault.Powershell.Models.ILaptopPlanInternal)this).ParentPlan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.ILaptopPlanInternal)this).PlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).Alerts = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("Alerts",((Commvault.Powershell.Models.ILaptopPlanInternal)this).Alerts, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).AllowPlanOverride = (bool?) content.GetValueForProperty("AllowPlanOverride",((Commvault.Powershell.Models.ILaptopPlanInternal)this).AllowPlanOverride, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).InviteUsersOrGroups = (Commvault.Powershell.Models.IPlanUserOrGroups[]) content.GetValueForProperty("InviteUsersOrGroups",((Commvault.Powershell.Models.ILaptopPlanInternal)this).InviteUsersOrGroups, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IPlanUserOrGroups>(__y, Commvault.Powershell.Models.PlanUserOrGroupsTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).AllowedFeatures = (Commvault.Powershell.Models.ILaptopPlanAllowedFeatures) content.GetValueForProperty("AllowedFeatures",((Commvault.Powershell.Models.ILaptopPlanInternal)this).AllowedFeatures, Commvault.Powershell.Models.LaptopPlanAllowedFeaturesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentWindowsIncludedPaths = (string[]) content.GetValueForProperty("BackupContentWindowsIncludedPaths",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentWindowsIncludedPaths, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentWindowsExcludedPaths = (string[]) content.GetValueForProperty("BackupContentWindowsExcludedPaths",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentWindowsExcludedPaths, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentMacIncludedPaths = (string[]) content.GetValueForProperty("BackupContentMacIncludedPaths",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentMacIncludedPaths, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentMacExcludedPaths = (string[]) content.GetValueForProperty("BackupContentMacExcludedPaths",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentMacExcludedPaths, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentUnixIncludedPaths = (string[]) content.GetValueForProperty("BackupContentUnixIncludedPaths",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentUnixIncludedPaths, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentUnixExcludedPaths = (string[]) content.GetValueForProperty("BackupContentUnixExcludedPaths",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentUnixExcludedPaths, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentFileSystemQuota = (int?) content.GetValueForProperty("BackupContentFileSystemQuota",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentFileSystemQuota, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndSchedulePrimaryStorage = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("StorageAndSchedulePrimaryStorage",((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndSchedulePrimaryStorage, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndScheduleSecondaryStorage = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("StorageAndScheduleSecondaryStorage",((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndScheduleSecondaryStorage, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndScheduleBackupFrequency = (int?) content.GetValueForProperty("StorageAndScheduleBackupFrequency",((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndScheduleBackupFrequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).RetentionFileVersions = (Commvault.Powershell.Models.ILaptopPlanRetentionFileVersions) content.GetValueForProperty("RetentionFileVersions",((Commvault.Powershell.Models.ILaptopPlanInternal)this).RetentionFileVersions, Commvault.Powershell.Models.LaptopPlanRetentionFileVersionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).RetentionDeletedItemRetention = (int?) content.GetValueForProperty("RetentionDeletedItemRetention",((Commvault.Powershell.Models.ILaptopPlanInternal)this).RetentionDeletedItemRetention, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).NetworkResourceThrottleSend = (int?) content.GetValueForProperty("NetworkResourceThrottleSend",((Commvault.Powershell.Models.ILaptopPlanInternal)this).NetworkResourceThrottleSend, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).NetworkResourceThrottleReceive = (int?) content.GetValueForProperty("NetworkResourceThrottleReceive",((Commvault.Powershell.Models.ILaptopPlanInternal)this).NetworkResourceThrottleReceive, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionStoragePool = (string) content.GetValueForProperty("OverrideRestrictionStoragePool",((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionStoragePool, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionRpo = (string) content.GetValueForProperty("OverrideRestrictionRpo",((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionRpo, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionBackupContent = (string) content.GetValueForProperty("OverrideRestrictionBackupContent",((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionBackupContent, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionRetention = (string) content.GetValueForProperty("OverrideRestrictionRetention",((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionRetention, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).ParentPlanId = (int?) content.GetValueForProperty("ParentPlanId",((Commvault.Powershell.Models.ILaptopPlanInternal)this).ParentPlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).ParentPlanName = (string) content.GetValueForProperty("ParentPlanName",((Commvault.Powershell.Models.ILaptopPlanInternal)this).ParentPlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).PrimaryStorageId = (int?) content.GetValueForProperty("PrimaryStorageId",((Commvault.Powershell.Models.ILaptopPlanInternal)this).PrimaryStorageId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).PrimaryStorageName = (string) content.GetValueForProperty("PrimaryStorageName",((Commvault.Powershell.Models.ILaptopPlanInternal)this).PrimaryStorageName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).SecondaryStorageId = (int?) content.GetValueForProperty("SecondaryStorageId",((Commvault.Powershell.Models.ILaptopPlanInternal)this).SecondaryStorageId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).SecondaryStorageName = (string) content.GetValueForProperty("SecondaryStorageName",((Commvault.Powershell.Models.ILaptopPlanInternal)this).SecondaryStorageName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionDays = (int?) content.GetValueForProperty("FileVersionDays",((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionVersions = (int?) content.GetValueForProperty("FileVersionVersions",((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionVersions, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionDailyVersions = (int?) content.GetValueForProperty("FileVersionDailyVersions",((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionDailyVersions, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionWeeklyVersions = (int?) content.GetValueForProperty("FileVersionWeeklyVersions",((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionWeeklyVersions, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionMonthlyVersions = (int?) content.GetValueForProperty("FileVersionMonthlyVersions",((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionMonthlyVersions, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.LaptopPlan"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LaptopPlan(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContent = (Commvault.Powershell.Models.ILaptopPlanBackupContent) content.GetValueForProperty("BackupContent",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContent, Commvault.Powershell.Models.LaptopPlanBackupContentTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndSchedule = (Commvault.Powershell.Models.ILaptopPlanStorageAndSchedule) content.GetValueForProperty("StorageAndSchedule",((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndSchedule, Commvault.Powershell.Models.LaptopPlanStorageAndScheduleTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).Retention = (Commvault.Powershell.Models.ILaptopPlanRetention) content.GetValueForProperty("Retention",((Commvault.Powershell.Models.ILaptopPlanInternal)this).Retention, Commvault.Powershell.Models.LaptopPlanRetentionTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).NetworkResources = (Commvault.Powershell.Models.ILaptopPlanNetworkResources) content.GetValueForProperty("NetworkResources",((Commvault.Powershell.Models.ILaptopPlanInternal)this).NetworkResources, Commvault.Powershell.Models.LaptopPlanNetworkResourcesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictions = (Commvault.Powershell.Models.ILaptopPlanOverrideSettings) content.GetValueForProperty("OverrideRestrictions",((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictions, Commvault.Powershell.Models.LaptopPlanOverrideSettingsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).ParentPlan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("ParentPlan",((Commvault.Powershell.Models.ILaptopPlanInternal)this).ParentPlan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.ILaptopPlanInternal)this).PlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).Alerts = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("Alerts",((Commvault.Powershell.Models.ILaptopPlanInternal)this).Alerts, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).AllowPlanOverride = (bool?) content.GetValueForProperty("AllowPlanOverride",((Commvault.Powershell.Models.ILaptopPlanInternal)this).AllowPlanOverride, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).InviteUsersOrGroups = (Commvault.Powershell.Models.IPlanUserOrGroups[]) content.GetValueForProperty("InviteUsersOrGroups",((Commvault.Powershell.Models.ILaptopPlanInternal)this).InviteUsersOrGroups, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IPlanUserOrGroups>(__y, Commvault.Powershell.Models.PlanUserOrGroupsTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).AllowedFeatures = (Commvault.Powershell.Models.ILaptopPlanAllowedFeatures) content.GetValueForProperty("AllowedFeatures",((Commvault.Powershell.Models.ILaptopPlanInternal)this).AllowedFeatures, Commvault.Powershell.Models.LaptopPlanAllowedFeaturesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentWindowsIncludedPaths = (string[]) content.GetValueForProperty("BackupContentWindowsIncludedPaths",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentWindowsIncludedPaths, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentWindowsExcludedPaths = (string[]) content.GetValueForProperty("BackupContentWindowsExcludedPaths",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentWindowsExcludedPaths, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentMacIncludedPaths = (string[]) content.GetValueForProperty("BackupContentMacIncludedPaths",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentMacIncludedPaths, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentMacExcludedPaths = (string[]) content.GetValueForProperty("BackupContentMacExcludedPaths",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentMacExcludedPaths, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentUnixIncludedPaths = (string[]) content.GetValueForProperty("BackupContentUnixIncludedPaths",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentUnixIncludedPaths, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentUnixExcludedPaths = (string[]) content.GetValueForProperty("BackupContentUnixExcludedPaths",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentUnixExcludedPaths, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentFileSystemQuota = (int?) content.GetValueForProperty("BackupContentFileSystemQuota",((Commvault.Powershell.Models.ILaptopPlanInternal)this).BackupContentFileSystemQuota, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndSchedulePrimaryStorage = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("StorageAndSchedulePrimaryStorage",((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndSchedulePrimaryStorage, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndScheduleSecondaryStorage = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("StorageAndScheduleSecondaryStorage",((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndScheduleSecondaryStorage, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndScheduleBackupFrequency = (int?) content.GetValueForProperty("StorageAndScheduleBackupFrequency",((Commvault.Powershell.Models.ILaptopPlanInternal)this).StorageAndScheduleBackupFrequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).RetentionFileVersions = (Commvault.Powershell.Models.ILaptopPlanRetentionFileVersions) content.GetValueForProperty("RetentionFileVersions",((Commvault.Powershell.Models.ILaptopPlanInternal)this).RetentionFileVersions, Commvault.Powershell.Models.LaptopPlanRetentionFileVersionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).RetentionDeletedItemRetention = (int?) content.GetValueForProperty("RetentionDeletedItemRetention",((Commvault.Powershell.Models.ILaptopPlanInternal)this).RetentionDeletedItemRetention, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).NetworkResourceThrottleSend = (int?) content.GetValueForProperty("NetworkResourceThrottleSend",((Commvault.Powershell.Models.ILaptopPlanInternal)this).NetworkResourceThrottleSend, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).NetworkResourceThrottleReceive = (int?) content.GetValueForProperty("NetworkResourceThrottleReceive",((Commvault.Powershell.Models.ILaptopPlanInternal)this).NetworkResourceThrottleReceive, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionStoragePool = (string) content.GetValueForProperty("OverrideRestrictionStoragePool",((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionStoragePool, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionRpo = (string) content.GetValueForProperty("OverrideRestrictionRpo",((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionRpo, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionBackupContent = (string) content.GetValueForProperty("OverrideRestrictionBackupContent",((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionBackupContent, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionRetention = (string) content.GetValueForProperty("OverrideRestrictionRetention",((Commvault.Powershell.Models.ILaptopPlanInternal)this).OverrideRestrictionRetention, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).ParentPlanId = (int?) content.GetValueForProperty("ParentPlanId",((Commvault.Powershell.Models.ILaptopPlanInternal)this).ParentPlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).ParentPlanName = (string) content.GetValueForProperty("ParentPlanName",((Commvault.Powershell.Models.ILaptopPlanInternal)this).ParentPlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).PrimaryStorageId = (int?) content.GetValueForProperty("PrimaryStorageId",((Commvault.Powershell.Models.ILaptopPlanInternal)this).PrimaryStorageId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).PrimaryStorageName = (string) content.GetValueForProperty("PrimaryStorageName",((Commvault.Powershell.Models.ILaptopPlanInternal)this).PrimaryStorageName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).SecondaryStorageId = (int?) content.GetValueForProperty("SecondaryStorageId",((Commvault.Powershell.Models.ILaptopPlanInternal)this).SecondaryStorageId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).SecondaryStorageName = (string) content.GetValueForProperty("SecondaryStorageName",((Commvault.Powershell.Models.ILaptopPlanInternal)this).SecondaryStorageName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionDays = (int?) content.GetValueForProperty("FileVersionDays",((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionDays, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionVersions = (int?) content.GetValueForProperty("FileVersionVersions",((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionVersions, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionDailyVersions = (int?) content.GetValueForProperty("FileVersionDailyVersions",((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionDailyVersions, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionWeeklyVersions = (int?) content.GetValueForProperty("FileVersionWeeklyVersions",((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionWeeklyVersions, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionMonthlyVersions = (int?) content.GetValueForProperty("FileVersionMonthlyVersions",((Commvault.Powershell.Models.ILaptopPlanInternal)this).FileVersionMonthlyVersions, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Create a new Laptop Plan
    [System.ComponentModel.TypeConverter(typeof(LaptopPlanTypeConverter))]
    public partial interface ILaptopPlan

    {

    }
}