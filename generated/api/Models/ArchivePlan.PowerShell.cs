// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(ArchivePlanTypeConverter))]
    public partial class ArchivePlan
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.ArchivePlan"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ArchivePlan(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).Rpo = (Commvault.Powershell.Models.IArchivePlanRpo) content.GetValueForProperty("Rpo",((Commvault.Powershell.Models.IArchivePlanInternal)this).Rpo, Commvault.Powershell.Models.ArchivePlanRpoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRules = (Commvault.Powershell.Models.IArchivePlanArchivingRules) content.GetValueForProperty("ArchivingRules",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRules, Commvault.Powershell.Models.ArchivePlanArchivingRulesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictions = (Commvault.Powershell.Models.IArchivePlanOverrideSettings) content.GetValueForProperty("OverrideRestrictions",((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictions, Commvault.Powershell.Models.ArchivePlanOverrideSettingsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ParentPlan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("ParentPlan",((Commvault.Powershell.Models.IArchivePlanInternal)this).ParentPlan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IArchivePlanInternal)this).PlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).BackupDestinations = (Commvault.Powershell.Models.ICreateArchivePlanBackupDestination[]) content.GetValueForProperty("BackupDestinations",((Commvault.Powershell.Models.IArchivePlanInternal)this).BackupDestinations, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ICreateArchivePlanBackupDestination>(__y, Commvault.Powershell.Models.CreateArchivePlanBackupDestinationTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).AllowPlanOverride = (bool?) content.GetValueForProperty("AllowPlanOverride",((Commvault.Powershell.Models.IArchivePlanInternal)this).AllowPlanOverride, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).RpoArchiveFrequency = (Commvault.Powershell.Models.IBackupFrequencyPattern) content.GetValueForProperty("RpoArchiveFrequency",((Commvault.Powershell.Models.IArchivePlanInternal)this).RpoArchiveFrequency, Commvault.Powershell.Models.BackupFrequencyPatternTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).RpoArchiveWindow = (Commvault.Powershell.Models.IDayAndTime[]) content.GetValueForProperty("RpoArchiveWindow",((Commvault.Powershell.Models.IArchivePlanInternal)this).RpoArchiveWindow, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDayAndTime>(__y, Commvault.Powershell.Models.DayAndTimeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleFileTimestampMethod = (string) content.GetValueForProperty("ArchivingRuleFileTimestampMethod",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleFileTimestampMethod, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleFileTimestamp = (int?) content.GetValueForProperty("ArchivingRuleFileTimestamp",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleFileTimestamp, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleFileSize = (int?) content.GetValueForProperty("ArchivingRuleFileSize",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleFileSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleAfterArchiving = (string) content.GetValueForProperty("ArchivingRuleAfterArchiving",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleAfterArchiving, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictionStoragePool = (string) content.GetValueForProperty("OverrideRestrictionStoragePool",((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictionStoragePool, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictionRpo = (string) content.GetValueForProperty("OverrideRestrictionRpo",((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictionRpo, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictionArchivingRules = (string) content.GetValueForProperty("OverrideRestrictionArchivingRules",((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictionArchivingRules, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ParentPlanId = (int?) content.GetValueForProperty("ParentPlanId",((Commvault.Powershell.Models.IArchivePlanInternal)this).ParentPlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ParentPlanName = (string) content.GetValueForProperty("ParentPlanName",((Commvault.Powershell.Models.IArchivePlanInternal)this).ParentPlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyScheduleFrequencyType = (string) content.GetValueForProperty("ArchiveFrequencyScheduleFrequencyType",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyScheduleFrequencyType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequency = (int?) content.GetValueForProperty("ArchiveFrequency",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyWeeklyDays = (string[]) content.GetValueForProperty("ArchiveFrequencyWeeklyDays",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyWeeklyDays, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyDayOfMonth = (int?) content.GetValueForProperty("ArchiveFrequencyDayOfMonth",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyDayOfMonth, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyWeekOfMonth = (string) content.GetValueForProperty("ArchiveFrequencyWeekOfMonth",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyWeekOfMonth, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyDayOfWeek = (string) content.GetValueForProperty("ArchiveFrequencyDayOfWeek",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyDayOfWeek, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyMonthOfYear = (string) content.GetValueForProperty("ArchiveFrequencyMonthOfYear",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyMonthOfYear, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyStartTime = (int?) content.GetValueForProperty("ArchiveFrequencyStartTime",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyStartTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.ArchivePlan"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ArchivePlan(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).Rpo = (Commvault.Powershell.Models.IArchivePlanRpo) content.GetValueForProperty("Rpo",((Commvault.Powershell.Models.IArchivePlanInternal)this).Rpo, Commvault.Powershell.Models.ArchivePlanRpoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRules = (Commvault.Powershell.Models.IArchivePlanArchivingRules) content.GetValueForProperty("ArchivingRules",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRules, Commvault.Powershell.Models.ArchivePlanArchivingRulesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictions = (Commvault.Powershell.Models.IArchivePlanOverrideSettings) content.GetValueForProperty("OverrideRestrictions",((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictions, Commvault.Powershell.Models.ArchivePlanOverrideSettingsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ParentPlan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("ParentPlan",((Commvault.Powershell.Models.IArchivePlanInternal)this).ParentPlan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IArchivePlanInternal)this).PlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).BackupDestinations = (Commvault.Powershell.Models.ICreateArchivePlanBackupDestination[]) content.GetValueForProperty("BackupDestinations",((Commvault.Powershell.Models.IArchivePlanInternal)this).BackupDestinations, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ICreateArchivePlanBackupDestination>(__y, Commvault.Powershell.Models.CreateArchivePlanBackupDestinationTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).AllowPlanOverride = (bool?) content.GetValueForProperty("AllowPlanOverride",((Commvault.Powershell.Models.IArchivePlanInternal)this).AllowPlanOverride, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).RpoArchiveFrequency = (Commvault.Powershell.Models.IBackupFrequencyPattern) content.GetValueForProperty("RpoArchiveFrequency",((Commvault.Powershell.Models.IArchivePlanInternal)this).RpoArchiveFrequency, Commvault.Powershell.Models.BackupFrequencyPatternTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).RpoArchiveWindow = (Commvault.Powershell.Models.IDayAndTime[]) content.GetValueForProperty("RpoArchiveWindow",((Commvault.Powershell.Models.IArchivePlanInternal)this).RpoArchiveWindow, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDayAndTime>(__y, Commvault.Powershell.Models.DayAndTimeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleFileTimestampMethod = (string) content.GetValueForProperty("ArchivingRuleFileTimestampMethod",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleFileTimestampMethod, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleFileTimestamp = (int?) content.GetValueForProperty("ArchivingRuleFileTimestamp",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleFileTimestamp, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleFileSize = (int?) content.GetValueForProperty("ArchivingRuleFileSize",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleFileSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleAfterArchiving = (string) content.GetValueForProperty("ArchivingRuleAfterArchiving",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchivingRuleAfterArchiving, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictionStoragePool = (string) content.GetValueForProperty("OverrideRestrictionStoragePool",((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictionStoragePool, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictionRpo = (string) content.GetValueForProperty("OverrideRestrictionRpo",((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictionRpo, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictionArchivingRules = (string) content.GetValueForProperty("OverrideRestrictionArchivingRules",((Commvault.Powershell.Models.IArchivePlanInternal)this).OverrideRestrictionArchivingRules, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ParentPlanId = (int?) content.GetValueForProperty("ParentPlanId",((Commvault.Powershell.Models.IArchivePlanInternal)this).ParentPlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ParentPlanName = (string) content.GetValueForProperty("ParentPlanName",((Commvault.Powershell.Models.IArchivePlanInternal)this).ParentPlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyScheduleFrequencyType = (string) content.GetValueForProperty("ArchiveFrequencyScheduleFrequencyType",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyScheduleFrequencyType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequency = (int?) content.GetValueForProperty("ArchiveFrequency",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyWeeklyDays = (string[]) content.GetValueForProperty("ArchiveFrequencyWeeklyDays",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyWeeklyDays, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyDayOfMonth = (int?) content.GetValueForProperty("ArchiveFrequencyDayOfMonth",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyDayOfMonth, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyWeekOfMonth = (string) content.GetValueForProperty("ArchiveFrequencyWeekOfMonth",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyWeekOfMonth, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyDayOfWeek = (string) content.GetValueForProperty("ArchiveFrequencyDayOfWeek",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyDayOfWeek, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyMonthOfYear = (string) content.GetValueForProperty("ArchiveFrequencyMonthOfYear",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyMonthOfYear, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyStartTime = (int?) content.GetValueForProperty("ArchiveFrequencyStartTime",((Commvault.Powershell.Models.IArchivePlanInternal)this).ArchiveFrequencyStartTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.ArchivePlan"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IArchivePlan" />.</returns>
        public static Commvault.Powershell.Models.IArchivePlan DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ArchivePlan(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.ArchivePlan"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IArchivePlan" />.</returns>
        public static Commvault.Powershell.Models.IArchivePlan DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ArchivePlan(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ArchivePlan" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IArchivePlan FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ArchivePlanTypeConverter))]
    public partial interface IArchivePlan

    {

    }
}