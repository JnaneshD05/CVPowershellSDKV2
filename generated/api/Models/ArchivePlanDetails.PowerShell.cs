// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(ArchivePlanDetailsTypeConverter))]
    public partial class ArchivePlanDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.ArchivePlanDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ArchivePlanDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).Plan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Plan",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).Plan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRules = (Commvault.Powershell.Models.IArchivePlanArchivingRules) content.GetValueForProperty("ArchivingRules",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRules, Commvault.Powershell.Models.ArchivePlanArchivingRulesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).Rpo = (Commvault.Powershell.Models.IArchivePlanRpoDetails) content.GetValueForProperty("Rpo",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).Rpo, Commvault.Powershell.Models.ArchivePlanRpoDetailsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictions = (Commvault.Powershell.Models.IArchivePlanOverrideSettings) content.GetValueForProperty("OverrideRestrictions",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictions, Commvault.Powershell.Models.ArchivePlanOverrideSettingsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettings = (Commvault.Powershell.Models.IArchivePlanInheritSettings) content.GetValueForProperty("InheritSettings",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettings, Commvault.Powershell.Models.ArchivePlanInheritSettingsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RegionsConfigured = (bool?) content.GetValueForProperty("RegionsConfigured",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RegionsConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupDestinations = (Commvault.Powershell.Models.IArchivePlanBackupDestination[]) content.GetValueForProperty("BackupDestinations",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupDestinations, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IArchivePlanBackupDestination>(__y, Commvault.Powershell.Models.ArchivePlanBackupDestinationTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).AllowPlanOverride = (bool?) content.GetValueForProperty("AllowPlanOverride",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).AllowPlanOverride, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).AssociatedEntities = (Commvault.Powershell.Models.IIdNameCount[]) content.GetValueForProperty("AssociatedEntities",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).AssociatedEntities, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdNameCount>(__y, Commvault.Powershell.Models.IdNameCountTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).Permissions = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("Permissions",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).Permissions, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).PlanId = (int?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).PlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).PlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleFileTimestampMethod = (string) content.GetValueForProperty("ArchivingRuleFileTimestampMethod",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleFileTimestampMethod, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleFileTimestamp = (int?) content.GetValueForProperty("ArchivingRuleFileTimestamp",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleFileTimestamp, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleFileSize = (int?) content.GetValueForProperty("ArchivingRuleFileSize",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleFileSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleAfterArchiving = (string) content.GetValueForProperty("ArchivingRuleAfterArchiving",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleAfterArchiving, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoBackupFrequency = (Commvault.Powershell.Models.IBackupFrequencyPattern) content.GetValueForProperty("RpoBackupFrequency",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoBackupFrequency, Commvault.Powershell.Models.BackupFrequencyPatternTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoSla = (Commvault.Powershell.Models.ISlaOptions) content.GetValueForProperty("RpoSla",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoSla, Commvault.Powershell.Models.SlaOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoBackupWindow = (Commvault.Powershell.Models.IDayAndTime[]) content.GetValueForProperty("RpoBackupWindow",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoBackupWindow, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDayAndTime>(__y, Commvault.Powershell.Models.DayAndTimeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictionStoragePool = (string) content.GetValueForProperty("OverrideRestrictionStoragePool",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictionStoragePool, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictionRpo = (string) content.GetValueForProperty("OverrideRestrictionRpo",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictionRpo, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictionArchivingRules = (string) content.GetValueForProperty("OverrideRestrictionArchivingRules",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictionArchivingRules, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingBasePlan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("InheritSettingBasePlan",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingBasePlan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingStoragePool = (Commvault.Powershell.Models.IPlanOverridenOptions) content.GetValueForProperty("InheritSettingStoragePool",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingStoragePool, Commvault.Powershell.Models.PlanOverridenOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingRpo = (Commvault.Powershell.Models.IPlanOverridenOptions) content.GetValueForProperty("InheritSettingRpo",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingRpo, Commvault.Powershell.Models.PlanOverridenOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingArchivingRules = (Commvault.Powershell.Models.IPlanOverridenOptions) content.GetValueForProperty("InheritSettingArchivingRules",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingArchivingRules, Commvault.Powershell.Models.PlanOverridenOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyScheduleFrequencyType = (string) content.GetValueForProperty("BackupFrequencyScheduleFrequencyType",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyScheduleFrequencyType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequency = (int?) content.GetValueForProperty("BackupFrequency",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyWeeklyDays = (string[]) content.GetValueForProperty("BackupFrequencyWeeklyDays",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyWeeklyDays, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyDayOfMonth = (int?) content.GetValueForProperty("BackupFrequencyDayOfMonth",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyDayOfMonth, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyWeekOfMonth = (string) content.GetValueForProperty("BackupFrequencyWeekOfMonth",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyWeekOfMonth, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyDayOfWeek = (string) content.GetValueForProperty("BackupFrequencyDayOfWeek",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyDayOfWeek, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyMonthOfYear = (string) content.GetValueForProperty("BackupFrequencyMonthOfYear",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyMonthOfYear, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyStartTime = (int?) content.GetValueForProperty("BackupFrequencyStartTime",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyStartTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaUseSystemDefaultSla = (bool?) content.GetValueForProperty("SlaUseSystemDefaultSla",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaUseSystemDefaultSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaInheritedSlaPeriod = (int?) content.GetValueForProperty("SlaInheritedSlaPeriod",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaInheritedSlaPeriod, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaInheritedFrom = (string) content.GetValueForProperty("SlaInheritedFrom",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaInheritedFrom, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaPeriod = (int?) content.GetValueForProperty("SlaPeriod",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaPeriod, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaExcludeFromSla = (bool?) content.GetValueForProperty("SlaExcludeFromSla",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaExcludeFromSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaEnableAfterDelay = (int?) content.GetValueForProperty("SlaEnableAfterDelay",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaEnableAfterDelay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaExclusionReason = (string) content.GetValueForProperty("SlaExclusionReason",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaExclusionReason, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BasePlanId = (int?) content.GetValueForProperty("BasePlanId",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BasePlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BasePlanName = (string) content.GetValueForProperty("BasePlanName",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BasePlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).StoragePoolOverrideBase = (string) content.GetValueForProperty("StoragePoolOverrideBase",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).StoragePoolOverrideBase, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).StoragePoolOverridden = (bool?) content.GetValueForProperty("StoragePoolOverridden",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).StoragePoolOverridden, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoOverrideBase = (string) content.GetValueForProperty("RpoOverrideBase",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoOverrideBase, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoOverridden = (bool?) content.GetValueForProperty("RpoOverridden",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoOverridden, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleOverrideBase = (string) content.GetValueForProperty("ArchivingRuleOverrideBase",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleOverrideBase, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleOverridden = (bool?) content.GetValueForProperty("ArchivingRuleOverridden",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleOverridden, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.ArchivePlanDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ArchivePlanDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).Plan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Plan",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).Plan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRules = (Commvault.Powershell.Models.IArchivePlanArchivingRules) content.GetValueForProperty("ArchivingRules",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRules, Commvault.Powershell.Models.ArchivePlanArchivingRulesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).Rpo = (Commvault.Powershell.Models.IArchivePlanRpoDetails) content.GetValueForProperty("Rpo",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).Rpo, Commvault.Powershell.Models.ArchivePlanRpoDetailsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictions = (Commvault.Powershell.Models.IArchivePlanOverrideSettings) content.GetValueForProperty("OverrideRestrictions",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictions, Commvault.Powershell.Models.ArchivePlanOverrideSettingsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettings = (Commvault.Powershell.Models.IArchivePlanInheritSettings) content.GetValueForProperty("InheritSettings",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettings, Commvault.Powershell.Models.ArchivePlanInheritSettingsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RegionsConfigured = (bool?) content.GetValueForProperty("RegionsConfigured",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RegionsConfigured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupDestinations = (Commvault.Powershell.Models.IArchivePlanBackupDestination[]) content.GetValueForProperty("BackupDestinations",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupDestinations, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IArchivePlanBackupDestination>(__y, Commvault.Powershell.Models.ArchivePlanBackupDestinationTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).AllowPlanOverride = (bool?) content.GetValueForProperty("AllowPlanOverride",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).AllowPlanOverride, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).AssociatedEntities = (Commvault.Powershell.Models.IIdNameCount[]) content.GetValueForProperty("AssociatedEntities",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).AssociatedEntities, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdNameCount>(__y, Commvault.Powershell.Models.IdNameCountTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).Permissions = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("Permissions",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).Permissions, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).PlanId = (int?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).PlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).PlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleFileTimestampMethod = (string) content.GetValueForProperty("ArchivingRuleFileTimestampMethod",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleFileTimestampMethod, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleFileTimestamp = (int?) content.GetValueForProperty("ArchivingRuleFileTimestamp",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleFileTimestamp, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleFileSize = (int?) content.GetValueForProperty("ArchivingRuleFileSize",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleFileSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleAfterArchiving = (string) content.GetValueForProperty("ArchivingRuleAfterArchiving",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleAfterArchiving, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoBackupFrequency = (Commvault.Powershell.Models.IBackupFrequencyPattern) content.GetValueForProperty("RpoBackupFrequency",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoBackupFrequency, Commvault.Powershell.Models.BackupFrequencyPatternTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoSla = (Commvault.Powershell.Models.ISlaOptions) content.GetValueForProperty("RpoSla",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoSla, Commvault.Powershell.Models.SlaOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoBackupWindow = (Commvault.Powershell.Models.IDayAndTime[]) content.GetValueForProperty("RpoBackupWindow",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoBackupWindow, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDayAndTime>(__y, Commvault.Powershell.Models.DayAndTimeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictionStoragePool = (string) content.GetValueForProperty("OverrideRestrictionStoragePool",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictionStoragePool, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictionRpo = (string) content.GetValueForProperty("OverrideRestrictionRpo",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictionRpo, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictionArchivingRules = (string) content.GetValueForProperty("OverrideRestrictionArchivingRules",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).OverrideRestrictionArchivingRules, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingBasePlan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("InheritSettingBasePlan",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingBasePlan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingStoragePool = (Commvault.Powershell.Models.IPlanOverridenOptions) content.GetValueForProperty("InheritSettingStoragePool",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingStoragePool, Commvault.Powershell.Models.PlanOverridenOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingRpo = (Commvault.Powershell.Models.IPlanOverridenOptions) content.GetValueForProperty("InheritSettingRpo",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingRpo, Commvault.Powershell.Models.PlanOverridenOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingArchivingRules = (Commvault.Powershell.Models.IPlanOverridenOptions) content.GetValueForProperty("InheritSettingArchivingRules",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).InheritSettingArchivingRules, Commvault.Powershell.Models.PlanOverridenOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyScheduleFrequencyType = (string) content.GetValueForProperty("BackupFrequencyScheduleFrequencyType",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyScheduleFrequencyType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequency = (int?) content.GetValueForProperty("BackupFrequency",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyWeeklyDays = (string[]) content.GetValueForProperty("BackupFrequencyWeeklyDays",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyWeeklyDays, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyDayOfMonth = (int?) content.GetValueForProperty("BackupFrequencyDayOfMonth",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyDayOfMonth, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyWeekOfMonth = (string) content.GetValueForProperty("BackupFrequencyWeekOfMonth",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyWeekOfMonth, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyDayOfWeek = (string) content.GetValueForProperty("BackupFrequencyDayOfWeek",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyDayOfWeek, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyMonthOfYear = (string) content.GetValueForProperty("BackupFrequencyMonthOfYear",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyMonthOfYear, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyStartTime = (int?) content.GetValueForProperty("BackupFrequencyStartTime",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BackupFrequencyStartTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaUseSystemDefaultSla = (bool?) content.GetValueForProperty("SlaUseSystemDefaultSla",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaUseSystemDefaultSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaInheritedSlaPeriod = (int?) content.GetValueForProperty("SlaInheritedSlaPeriod",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaInheritedSlaPeriod, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaInheritedFrom = (string) content.GetValueForProperty("SlaInheritedFrom",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaInheritedFrom, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaPeriod = (int?) content.GetValueForProperty("SlaPeriod",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaPeriod, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaExcludeFromSla = (bool?) content.GetValueForProperty("SlaExcludeFromSla",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaExcludeFromSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaEnableAfterDelay = (int?) content.GetValueForProperty("SlaEnableAfterDelay",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaEnableAfterDelay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaExclusionReason = (string) content.GetValueForProperty("SlaExclusionReason",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).SlaExclusionReason, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BasePlanId = (int?) content.GetValueForProperty("BasePlanId",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BasePlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BasePlanName = (string) content.GetValueForProperty("BasePlanName",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).BasePlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).StoragePoolOverrideBase = (string) content.GetValueForProperty("StoragePoolOverrideBase",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).StoragePoolOverrideBase, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).StoragePoolOverridden = (bool?) content.GetValueForProperty("StoragePoolOverridden",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).StoragePoolOverridden, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoOverrideBase = (string) content.GetValueForProperty("RpoOverrideBase",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoOverrideBase, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoOverridden = (bool?) content.GetValueForProperty("RpoOverridden",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).RpoOverridden, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleOverrideBase = (string) content.GetValueForProperty("ArchivingRuleOverrideBase",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleOverrideBase, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleOverridden = (bool?) content.GetValueForProperty("ArchivingRuleOverridden",((Commvault.Powershell.Models.IArchivePlanDetailsInternal)this).ArchivingRuleOverridden, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.ArchivePlanDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IArchivePlanDetails" />.</returns>
        public static Commvault.Powershell.Models.IArchivePlanDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ArchivePlanDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.ArchivePlanDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IArchivePlanDetails" />.</returns>
        public static Commvault.Powershell.Models.IArchivePlanDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ArchivePlanDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ArchivePlanDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IArchivePlanDetails FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ArchivePlanDetailsTypeConverter))]
    public partial interface IArchivePlanDetails

    {

    }
}