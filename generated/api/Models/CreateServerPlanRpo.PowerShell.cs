// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(CreateServerPlanRpoTypeConverter))]
    public partial class CreateServerPlanRpo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.CreateServerPlanRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CreateServerPlanRpo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).Rpo = (Commvault.Powershell.Models.IServerBackupPlanRpo) content.GetValueForProperty("Rpo",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).Rpo, Commvault.Powershell.Models.ServerBackupPlanRpoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptions = (Commvault.Powershell.Models.IServerPlanDatabaseOptions) content.GetValueForProperty("DatabaseOptions",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptions, Commvault.Powershell.Models.ServerPlanDatabaseOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).RpoBackupFrequency = (Commvault.Powershell.Models.IPlanSchedules) content.GetValueForProperty("RpoBackupFrequency",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).RpoBackupFrequency, Commvault.Powershell.Models.PlanSchedulesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).RpoBackupWindow = (Commvault.Powershell.Models.IDayAndTime[]) content.GetValueForProperty("RpoBackupWindow",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).RpoBackupWindow, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDayAndTime>(__y, Commvault.Powershell.Models.DayAndTimeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).RpoFullBackupWindow = (Commvault.Powershell.Models.IDayAndTime[]) content.GetValueForProperty("RpoFullBackupWindow",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).RpoFullBackupWindow, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDayAndTime>(__y, Commvault.Powershell.Models.DayAndTimeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptionLogBackupRpoMins = (int?) content.GetValueForProperty("DatabaseOptionLogBackupRpoMins",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptionLogBackupRpoMins, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptionUseDiskCacheForLogBackups = (bool?) content.GetValueForProperty("DatabaseOptionUseDiskCacheForLogBackups",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptionUseDiskCacheForLogBackups, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptionCommitFrequencyInHours = (int?) content.GetValueForProperty("DatabaseOptionCommitFrequencyInHours",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptionCommitFrequencyInHours, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).BackupFrequencySchedules = (Commvault.Powershell.Models.IPlanSchedule[]) content.GetValueForProperty("BackupFrequencySchedules",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).BackupFrequencySchedules, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IPlanSchedule>(__y, Commvault.Powershell.Models.PlanScheduleTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.CreateServerPlanRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CreateServerPlanRpo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).Rpo = (Commvault.Powershell.Models.IServerBackupPlanRpo) content.GetValueForProperty("Rpo",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).Rpo, Commvault.Powershell.Models.ServerBackupPlanRpoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptions = (Commvault.Powershell.Models.IServerPlanDatabaseOptions) content.GetValueForProperty("DatabaseOptions",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptions, Commvault.Powershell.Models.ServerPlanDatabaseOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).RpoBackupFrequency = (Commvault.Powershell.Models.IPlanSchedules) content.GetValueForProperty("RpoBackupFrequency",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).RpoBackupFrequency, Commvault.Powershell.Models.PlanSchedulesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).RpoBackupWindow = (Commvault.Powershell.Models.IDayAndTime[]) content.GetValueForProperty("RpoBackupWindow",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).RpoBackupWindow, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDayAndTime>(__y, Commvault.Powershell.Models.DayAndTimeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).RpoFullBackupWindow = (Commvault.Powershell.Models.IDayAndTime[]) content.GetValueForProperty("RpoFullBackupWindow",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).RpoFullBackupWindow, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDayAndTime>(__y, Commvault.Powershell.Models.DayAndTimeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptionLogBackupRpoMins = (int?) content.GetValueForProperty("DatabaseOptionLogBackupRpoMins",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptionLogBackupRpoMins, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptionUseDiskCacheForLogBackups = (bool?) content.GetValueForProperty("DatabaseOptionUseDiskCacheForLogBackups",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptionUseDiskCacheForLogBackups, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptionCommitFrequencyInHours = (int?) content.GetValueForProperty("DatabaseOptionCommitFrequencyInHours",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).DatabaseOptionCommitFrequencyInHours, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).BackupFrequencySchedules = (Commvault.Powershell.Models.IPlanSchedule[]) content.GetValueForProperty("BackupFrequencySchedules",((Commvault.Powershell.Models.ICreateServerPlanRpoInternal)this).BackupFrequencySchedules, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IPlanSchedule>(__y, Commvault.Powershell.Models.PlanScheduleTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.CreateServerPlanRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ICreateServerPlanRpo" />.</returns>
        public static Commvault.Powershell.Models.ICreateServerPlanRpo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CreateServerPlanRpo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.CreateServerPlanRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ICreateServerPlanRpo" />.</returns>
        public static Commvault.Powershell.Models.ICreateServerPlanRpo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CreateServerPlanRpo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CreateServerPlanRpo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.ICreateServerPlanRpo FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(CreateServerPlanRpoTypeConverter))]
    public partial interface ICreateServerPlanRpo

    {

    }
}