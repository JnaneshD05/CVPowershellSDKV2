// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>
    /// Recovery Point Objective (RPO) is the maximum amount of time that data can be lost during a service disruption. Your RPO
    /// determines the frequency of your backup jobs.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ServerPlanRpoTypeConverter))]
    public partial class ServerPlanRpo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.ServerPlanRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IServerPlanRpo" />.</returns>
        public static Commvault.Powershell.Models.IServerPlanRpo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServerPlanRpo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.ServerPlanRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IServerPlanRpo" />.</returns>
        public static Commvault.Powershell.Models.IServerPlanRpo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServerPlanRpo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServerPlanRpo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IServerPlanRpo FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.ServerPlanRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServerPlanRpo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).BackupFrequency = (Commvault.Powershell.Models.IPlanSchedules) content.GetValueForProperty("BackupFrequency",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).BackupFrequency, Commvault.Powershell.Models.PlanSchedulesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).Sla = (Commvault.Powershell.Models.ISlaOptions) content.GetValueForProperty("Sla",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).Sla, Commvault.Powershell.Models.SlaOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).BackupWindow = (Commvault.Powershell.Models.IDayAndTime[]) content.GetValueForProperty("BackupWindow",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).BackupWindow, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDayAndTime>(__y, Commvault.Powershell.Models.DayAndTimeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).FullBackupWindow = (Commvault.Powershell.Models.IDayAndTime[]) content.GetValueForProperty("FullBackupWindow",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).FullBackupWindow, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDayAndTime>(__y, Commvault.Powershell.Models.DayAndTimeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).BackupFrequencySchedules = (Commvault.Powershell.Models.IPlanSchedule[]) content.GetValueForProperty("BackupFrequencySchedules",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).BackupFrequencySchedules, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IPlanSchedule>(__y, Commvault.Powershell.Models.PlanScheduleTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaUseSystemDefaultSla = (bool?) content.GetValueForProperty("SlaUseSystemDefaultSla",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaUseSystemDefaultSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaInheritedSlaPeriod = (int?) content.GetValueForProperty("SlaInheritedSlaPeriod",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaInheritedSlaPeriod, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaInheritedFrom = (string) content.GetValueForProperty("SlaInheritedFrom",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaInheritedFrom, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaPeriod = (int?) content.GetValueForProperty("SlaPeriod",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaPeriod, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaExcludeFromSla = (bool?) content.GetValueForProperty("SlaExcludeFromSla",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaExcludeFromSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaEnableAfterDelay = (int?) content.GetValueForProperty("SlaEnableAfterDelay",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaEnableAfterDelay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaExclusionReason = (string) content.GetValueForProperty("SlaExclusionReason",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaExclusionReason, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.ServerPlanRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServerPlanRpo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).BackupFrequency = (Commvault.Powershell.Models.IPlanSchedules) content.GetValueForProperty("BackupFrequency",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).BackupFrequency, Commvault.Powershell.Models.PlanSchedulesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).Sla = (Commvault.Powershell.Models.ISlaOptions) content.GetValueForProperty("Sla",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).Sla, Commvault.Powershell.Models.SlaOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).BackupWindow = (Commvault.Powershell.Models.IDayAndTime[]) content.GetValueForProperty("BackupWindow",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).BackupWindow, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDayAndTime>(__y, Commvault.Powershell.Models.DayAndTimeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).FullBackupWindow = (Commvault.Powershell.Models.IDayAndTime[]) content.GetValueForProperty("FullBackupWindow",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).FullBackupWindow, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDayAndTime>(__y, Commvault.Powershell.Models.DayAndTimeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).BackupFrequencySchedules = (Commvault.Powershell.Models.IPlanSchedule[]) content.GetValueForProperty("BackupFrequencySchedules",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).BackupFrequencySchedules, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IPlanSchedule>(__y, Commvault.Powershell.Models.PlanScheduleTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaUseSystemDefaultSla = (bool?) content.GetValueForProperty("SlaUseSystemDefaultSla",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaUseSystemDefaultSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaInheritedSlaPeriod = (int?) content.GetValueForProperty("SlaInheritedSlaPeriod",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaInheritedSlaPeriod, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaInheritedFrom = (string) content.GetValueForProperty("SlaInheritedFrom",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaInheritedFrom, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaPeriod = (int?) content.GetValueForProperty("SlaPeriod",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaPeriod, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaExcludeFromSla = (bool?) content.GetValueForProperty("SlaExcludeFromSla",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaExcludeFromSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaEnableAfterDelay = (int?) content.GetValueForProperty("SlaEnableAfterDelay",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaEnableAfterDelay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaExclusionReason = (string) content.GetValueForProperty("SlaExclusionReason",((Commvault.Powershell.Models.IServerPlanRpoInternal)this).SlaExclusionReason, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Recovery Point Objective (RPO) is the maximum amount of time that data can be lost during a service disruption. Your RPO
    /// determines the frequency of your backup jobs.
    [System.ComponentModel.TypeConverter(typeof(ServerPlanRpoTypeConverter))]
    public partial interface IServerPlanRpo

    {

    }
}