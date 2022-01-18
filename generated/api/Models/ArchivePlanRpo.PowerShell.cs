// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>
    /// Recovery Point Objective (RPO) is the maximum amount of time that data can be lost during a service disruption. Your RPO
    /// determines the frequency of your backup jobs.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ArchivePlanRpoTypeConverter))]
    public partial class ArchivePlanRpo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.ArchivePlanRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ArchivePlanRpo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequency = (Commvault.Powershell.Models.IBackupFrequencyPattern) content.GetValueForProperty("ArchiveFrequency",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequency, Commvault.Powershell.Models.BackupFrequencyPatternTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveWindow = (Commvault.Powershell.Models.IDayAndTime[]) content.GetValueForProperty("ArchiveWindow",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveWindow, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDayAndTime>(__y, Commvault.Powershell.Models.DayAndTimeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyScheduleFrequencyType = (string) content.GetValueForProperty("ArchiveFrequencyScheduleFrequencyType",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyScheduleFrequencyType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyFrequency = (int?) content.GetValueForProperty("ArchiveFrequencyFrequency",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyFrequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyWeeklyDays = (string[]) content.GetValueForProperty("ArchiveFrequencyWeeklyDays",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyWeeklyDays, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyDayOfMonth = (int?) content.GetValueForProperty("ArchiveFrequencyDayOfMonth",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyDayOfMonth, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyWeekOfMonth = (string) content.GetValueForProperty("ArchiveFrequencyWeekOfMonth",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyWeekOfMonth, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyDayOfWeek = (string) content.GetValueForProperty("ArchiveFrequencyDayOfWeek",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyDayOfWeek, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyMonthOfYear = (string) content.GetValueForProperty("ArchiveFrequencyMonthOfYear",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyMonthOfYear, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyStartTime = (int?) content.GetValueForProperty("ArchiveFrequencyStartTime",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyStartTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.ArchivePlanRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ArchivePlanRpo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequency = (Commvault.Powershell.Models.IBackupFrequencyPattern) content.GetValueForProperty("ArchiveFrequency",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequency, Commvault.Powershell.Models.BackupFrequencyPatternTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveWindow = (Commvault.Powershell.Models.IDayAndTime[]) content.GetValueForProperty("ArchiveWindow",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveWindow, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDayAndTime>(__y, Commvault.Powershell.Models.DayAndTimeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyScheduleFrequencyType = (string) content.GetValueForProperty("ArchiveFrequencyScheduleFrequencyType",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyScheduleFrequencyType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyFrequency = (int?) content.GetValueForProperty("ArchiveFrequencyFrequency",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyFrequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyWeeklyDays = (string[]) content.GetValueForProperty("ArchiveFrequencyWeeklyDays",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyWeeklyDays, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyDayOfMonth = (int?) content.GetValueForProperty("ArchiveFrequencyDayOfMonth",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyDayOfMonth, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyWeekOfMonth = (string) content.GetValueForProperty("ArchiveFrequencyWeekOfMonth",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyWeekOfMonth, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyDayOfWeek = (string) content.GetValueForProperty("ArchiveFrequencyDayOfWeek",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyDayOfWeek, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyMonthOfYear = (string) content.GetValueForProperty("ArchiveFrequencyMonthOfYear",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyMonthOfYear, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyStartTime = (int?) content.GetValueForProperty("ArchiveFrequencyStartTime",((Commvault.Powershell.Models.IArchivePlanRpoInternal)this).ArchiveFrequencyStartTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.ArchivePlanRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IArchivePlanRpo" />.</returns>
        public static Commvault.Powershell.Models.IArchivePlanRpo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ArchivePlanRpo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.ArchivePlanRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IArchivePlanRpo" />.</returns>
        public static Commvault.Powershell.Models.IArchivePlanRpo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ArchivePlanRpo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ArchivePlanRpo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IArchivePlanRpo FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Recovery Point Objective (RPO) is the maximum amount of time that data can be lost during a service disruption. Your RPO
    /// determines the frequency of your backup jobs.
    [System.ComponentModel.TypeConverter(typeof(ArchivePlanRpoTypeConverter))]
    public partial interface IArchivePlanRpo

    {

    }
}