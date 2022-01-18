// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Used to describe when the schedule runs</summary>
    [System.ComponentModel.TypeConverter(typeof(SchedulePatternTypeConverter))]
    public partial class SchedulePattern
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.SchedulePattern"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ISchedulePattern" />.</returns>
        public static Commvault.Powershell.Models.ISchedulePattern DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SchedulePattern(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.SchedulePattern"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ISchedulePattern" />.</returns>
        public static Commvault.Powershell.Models.ISchedulePattern DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SchedulePattern(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SchedulePattern" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.ISchedulePattern FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.SchedulePattern"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SchedulePattern(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).Timezone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Timezone",((Commvault.Powershell.Models.ISchedulePatternInternal)this).Timezone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).ScheduleFrequencyType = (string) content.GetValueForProperty("ScheduleFrequencyType",((Commvault.Powershell.Models.ISchedulePatternInternal)this).ScheduleFrequencyType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).Frequency = (int?) content.GetValueForProperty("Frequency",((Commvault.Powershell.Models.ISchedulePatternInternal)this).Frequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeeklyDays = (string[]) content.GetValueForProperty("WeeklyDays",((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeeklyDays, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfMonth = (int?) content.GetValueForProperty("DayOfMonth",((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfMonth, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeekOfMonth = (string) content.GetValueForProperty("WeekOfMonth",((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeekOfMonth, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfWeek = (string) content.GetValueForProperty("DayOfWeek",((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfWeek, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).MonthOfYear = (string) content.GetValueForProperty("MonthOfYear",((Commvault.Powershell.Models.ISchedulePatternInternal)this).MonthOfYear, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatIntervalInMinutes = (int?) content.GetValueForProperty("RepeatIntervalInMinutes",((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatIntervalInMinutes, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatUntilTime = (int?) content.GetValueForProperty("RepeatUntilTime",((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatUntilTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartTime = (int?) content.GetValueForProperty("StartTime",((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartDate = (int?) content.GetValueForProperty("StartDate",((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartDate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).EndDate = (int?) content.GetValueForProperty("EndDate",((Commvault.Powershell.Models.ISchedulePatternInternal)this).EndDate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).NoOfTimes = (int?) content.GetValueForProperty("NoOfTimes",((Commvault.Powershell.Models.ISchedulePatternInternal)this).NoOfTimes, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).Exceptions = (Commvault.Powershell.Models.IScheduleRunException[]) content.GetValueForProperty("Exceptions",((Commvault.Powershell.Models.ISchedulePatternInternal)this).Exceptions, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IScheduleRunException>(__y, Commvault.Powershell.Models.ScheduleRunExceptionTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).DaysBetweenSyntheticFulls = (int?) content.GetValueForProperty("DaysBetweenSyntheticFulls",((Commvault.Powershell.Models.ISchedulePatternInternal)this).DaysBetweenSyntheticFulls, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneId = (int?) content.GetValueForProperty("TimezoneId",((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneName = (string) content.GetValueForProperty("TimezoneName",((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.SchedulePattern"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SchedulePattern(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).Timezone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Timezone",((Commvault.Powershell.Models.ISchedulePatternInternal)this).Timezone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).ScheduleFrequencyType = (string) content.GetValueForProperty("ScheduleFrequencyType",((Commvault.Powershell.Models.ISchedulePatternInternal)this).ScheduleFrequencyType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).Frequency = (int?) content.GetValueForProperty("Frequency",((Commvault.Powershell.Models.ISchedulePatternInternal)this).Frequency, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeeklyDays = (string[]) content.GetValueForProperty("WeeklyDays",((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeeklyDays, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfMonth = (int?) content.GetValueForProperty("DayOfMonth",((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfMonth, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeekOfMonth = (string) content.GetValueForProperty("WeekOfMonth",((Commvault.Powershell.Models.ISchedulePatternInternal)this).WeekOfMonth, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfWeek = (string) content.GetValueForProperty("DayOfWeek",((Commvault.Powershell.Models.ISchedulePatternInternal)this).DayOfWeek, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).MonthOfYear = (string) content.GetValueForProperty("MonthOfYear",((Commvault.Powershell.Models.ISchedulePatternInternal)this).MonthOfYear, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatIntervalInMinutes = (int?) content.GetValueForProperty("RepeatIntervalInMinutes",((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatIntervalInMinutes, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatUntilTime = (int?) content.GetValueForProperty("RepeatUntilTime",((Commvault.Powershell.Models.ISchedulePatternInternal)this).RepeatUntilTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartTime = (int?) content.GetValueForProperty("StartTime",((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartDate = (int?) content.GetValueForProperty("StartDate",((Commvault.Powershell.Models.ISchedulePatternInternal)this).StartDate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).EndDate = (int?) content.GetValueForProperty("EndDate",((Commvault.Powershell.Models.ISchedulePatternInternal)this).EndDate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).NoOfTimes = (int?) content.GetValueForProperty("NoOfTimes",((Commvault.Powershell.Models.ISchedulePatternInternal)this).NoOfTimes, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).Exceptions = (Commvault.Powershell.Models.IScheduleRunException[]) content.GetValueForProperty("Exceptions",((Commvault.Powershell.Models.ISchedulePatternInternal)this).Exceptions, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IScheduleRunException>(__y, Commvault.Powershell.Models.ScheduleRunExceptionTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).DaysBetweenSyntheticFulls = (int?) content.GetValueForProperty("DaysBetweenSyntheticFulls",((Commvault.Powershell.Models.ISchedulePatternInternal)this).DaysBetweenSyntheticFulls, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneId = (int?) content.GetValueForProperty("TimezoneId",((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneName = (string) content.GetValueForProperty("TimezoneName",((Commvault.Powershell.Models.ISchedulePatternInternal)this).TimezoneName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Used to describe when the schedule runs
    [System.ComponentModel.TypeConverter(typeof(SchedulePatternTypeConverter))]
    public partial interface ISchedulePattern

    {

    }
}