// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(ActivityControlOptionsTypeConverter))]
    public partial class ActivityControlOptions
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.ActivityControlOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ActivityControlOptions(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptions = (Commvault.Powershell.Models.IBackupActivityControlOptionsProp) content.GetValueForProperty("BackupActivityControlOptions",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptions, Commvault.Powershell.Models.BackupActivityControlOptionsPropTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptions = (Commvault.Powershell.Models.IBackupActivityControlOptionsProp) content.GetValueForProperty("RestoreActivityControlOptions",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptions, Commvault.Powershell.Models.BackupActivityControlOptionsPropTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).EnableBackup = (bool?) content.GetValueForProperty("EnableBackup",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).EnableBackup, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).EnableRestore = (bool?) content.GetValueForProperty("EnableRestore",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).EnableRestore, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionTimeZone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("BackupActivityControlOptionTimeZone",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionTimeZone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionEnableAfterDelay = (bool?) content.GetValueForProperty("BackupActivityControlOptionEnableAfterDelay",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionEnableAfterDelay, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionDelayTime = (string) content.GetValueForProperty("BackupActivityControlOptionDelayTime",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionDelayTime, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionTimeZone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("RestoreActivityControlOptionTimeZone",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionTimeZone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionEnableAfterDelay = (bool?) content.GetValueForProperty("RestoreActivityControlOptionEnableAfterDelay",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionEnableAfterDelay, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionDelayTime = (string) content.GetValueForProperty("RestoreActivityControlOptionDelayTime",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionDelayTime, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionsTimeZoneId = (int?) content.GetValueForProperty("BackupActivityControlOptionsTimeZoneId",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionsTimeZoneId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionsTimeZoneName = (string) content.GetValueForProperty("BackupActivityControlOptionsTimeZoneName",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionsTimeZoneName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionsTimeZoneId = (int?) content.GetValueForProperty("RestoreActivityControlOptionsTimeZoneId",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionsTimeZoneId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionsTimeZoneName = (string) content.GetValueForProperty("RestoreActivityControlOptionsTimeZoneName",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionsTimeZoneName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.ActivityControlOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ActivityControlOptions(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptions = (Commvault.Powershell.Models.IBackupActivityControlOptionsProp) content.GetValueForProperty("BackupActivityControlOptions",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptions, Commvault.Powershell.Models.BackupActivityControlOptionsPropTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptions = (Commvault.Powershell.Models.IBackupActivityControlOptionsProp) content.GetValueForProperty("RestoreActivityControlOptions",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptions, Commvault.Powershell.Models.BackupActivityControlOptionsPropTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).EnableBackup = (bool?) content.GetValueForProperty("EnableBackup",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).EnableBackup, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).EnableRestore = (bool?) content.GetValueForProperty("EnableRestore",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).EnableRestore, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionTimeZone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("BackupActivityControlOptionTimeZone",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionTimeZone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionEnableAfterDelay = (bool?) content.GetValueForProperty("BackupActivityControlOptionEnableAfterDelay",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionEnableAfterDelay, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionDelayTime = (string) content.GetValueForProperty("BackupActivityControlOptionDelayTime",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionDelayTime, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionTimeZone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("RestoreActivityControlOptionTimeZone",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionTimeZone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionEnableAfterDelay = (bool?) content.GetValueForProperty("RestoreActivityControlOptionEnableAfterDelay",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionEnableAfterDelay, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionDelayTime = (string) content.GetValueForProperty("RestoreActivityControlOptionDelayTime",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionDelayTime, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionsTimeZoneId = (int?) content.GetValueForProperty("BackupActivityControlOptionsTimeZoneId",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionsTimeZoneId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionsTimeZoneName = (string) content.GetValueForProperty("BackupActivityControlOptionsTimeZoneName",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).BackupActivityControlOptionsTimeZoneName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionsTimeZoneId = (int?) content.GetValueForProperty("RestoreActivityControlOptionsTimeZoneId",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionsTimeZoneId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionsTimeZoneName = (string) content.GetValueForProperty("RestoreActivityControlOptionsTimeZoneName",((Commvault.Powershell.Models.IActivityControlOptionsInternal)this).RestoreActivityControlOptionsTimeZoneName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.ActivityControlOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IActivityControlOptions" />.
        /// </returns>
        public static Commvault.Powershell.Models.IActivityControlOptions DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ActivityControlOptions(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.ActivityControlOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IActivityControlOptions" />.
        /// </returns>
        public static Commvault.Powershell.Models.IActivityControlOptions DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ActivityControlOptions(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ActivityControlOptions" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IActivityControlOptions FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ActivityControlOptionsTypeConverter))]
    public partial interface IActivityControlOptions

    {

    }
}