// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Used to describe the frequency of backup</summary>
    [System.ComponentModel.TypeConverter(typeof(BackupFrequencyPatternTypeConverter))]
    public partial class BackupFrequencyPattern
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.BackupFrequencyPattern"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BackupFrequencyPattern(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).ScheduleFrequencyType = (string) content.GetValueForProperty("ScheduleFrequencyType",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).ScheduleFrequencyType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).Frequency = (int?) content.GetValueForProperty("Frequency",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).Frequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).WeeklyDays = (string[]) content.GetValueForProperty("WeeklyDays",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).WeeklyDays, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).DayOfMonth = (int?) content.GetValueForProperty("DayOfMonth",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).DayOfMonth, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).WeekOfMonth = (string) content.GetValueForProperty("WeekOfMonth",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).WeekOfMonth, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).DayOfWeek = (string) content.GetValueForProperty("DayOfWeek",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).DayOfWeek, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).MonthOfYear = (string) content.GetValueForProperty("MonthOfYear",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).MonthOfYear, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).StartTime = (int?) content.GetValueForProperty("StartTime",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).StartTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.BackupFrequencyPattern"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BackupFrequencyPattern(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).ScheduleFrequencyType = (string) content.GetValueForProperty("ScheduleFrequencyType",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).ScheduleFrequencyType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).Frequency = (int?) content.GetValueForProperty("Frequency",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).Frequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).WeeklyDays = (string[]) content.GetValueForProperty("WeeklyDays",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).WeeklyDays, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).DayOfMonth = (int?) content.GetValueForProperty("DayOfMonth",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).DayOfMonth, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).WeekOfMonth = (string) content.GetValueForProperty("WeekOfMonth",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).WeekOfMonth, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).DayOfWeek = (string) content.GetValueForProperty("DayOfWeek",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).DayOfWeek, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).MonthOfYear = (string) content.GetValueForProperty("MonthOfYear",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).MonthOfYear, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).StartTime = (int?) content.GetValueForProperty("StartTime",((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)this).StartTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.BackupFrequencyPattern"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IBackupFrequencyPattern" />.
        /// </returns>
        public static Commvault.Powershell.Models.IBackupFrequencyPattern DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BackupFrequencyPattern(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.BackupFrequencyPattern"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IBackupFrequencyPattern" />.
        /// </returns>
        public static Commvault.Powershell.Models.IBackupFrequencyPattern DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BackupFrequencyPattern(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BackupFrequencyPattern" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IBackupFrequencyPattern FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Used to describe the frequency of backup
    [System.ComponentModel.TypeConverter(typeof(BackupFrequencyPatternTypeConverter))]
    public partial interface IBackupFrequencyPattern

    {

    }
}