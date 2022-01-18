// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(BlackoutWindowDetailsTypeConverter))]
    public partial class BlackoutWindowDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.BlackoutWindowDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BlackoutWindowDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperations = (Commvault.Powershell.Models.IBackupOperationsList) content.GetValueForProperty("BackupOperations",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperations, Commvault.Powershell.Models.BackupOperationsListTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).DoNotRunJob = (Commvault.Powershell.Models.IDoNotRunJobDetails[]) content.GetValueForProperty("DoNotRunJob",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).DoNotRunJob, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDoNotRunJobDetails>(__y, Commvault.Powershell.Models.DoNotRunJobDetailsTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BetweenDates = (bool?) content.GetValueForProperty("BetweenDates",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BetweenDates, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).StartDate = (int?) content.GetValueForProperty("StartDate",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).StartDate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).EndDate = (int?) content.GetValueForProperty("EndDate",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).EndDate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).DoNotSubmitJob = (bool?) content.GetValueForProperty("DoNotSubmitJob",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).DoNotSubmitJob, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationFull = (bool?) content.GetValueForProperty("BackupOperationFull",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationFull, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationSyntheticFull = (bool?) content.GetValueForProperty("BackupOperationSyntheticFull",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationSyntheticFull, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationTransactionLog = (bool?) content.GetValueForProperty("BackupOperationTransactionLog",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationTransactionLog, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationIncrementalAndDifferential = (bool?) content.GetValueForProperty("BackupOperationIncrementalAndDifferential",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationIncrementalAndDifferential, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.BlackoutWindowDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BlackoutWindowDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperations = (Commvault.Powershell.Models.IBackupOperationsList) content.GetValueForProperty("BackupOperations",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperations, Commvault.Powershell.Models.BackupOperationsListTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).DoNotRunJob = (Commvault.Powershell.Models.IDoNotRunJobDetails[]) content.GetValueForProperty("DoNotRunJob",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).DoNotRunJob, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IDoNotRunJobDetails>(__y, Commvault.Powershell.Models.DoNotRunJobDetailsTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BetweenDates = (bool?) content.GetValueForProperty("BetweenDates",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BetweenDates, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).StartDate = (int?) content.GetValueForProperty("StartDate",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).StartDate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).EndDate = (int?) content.GetValueForProperty("EndDate",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).EndDate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).DoNotSubmitJob = (bool?) content.GetValueForProperty("DoNotSubmitJob",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).DoNotSubmitJob, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationFull = (bool?) content.GetValueForProperty("BackupOperationFull",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationFull, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationSyntheticFull = (bool?) content.GetValueForProperty("BackupOperationSyntheticFull",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationSyntheticFull, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationTransactionLog = (bool?) content.GetValueForProperty("BackupOperationTransactionLog",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationTransactionLog, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationIncrementalAndDifferential = (bool?) content.GetValueForProperty("BackupOperationIncrementalAndDifferential",((Commvault.Powershell.Models.IBlackoutWindowDetailsInternal)this).BackupOperationIncrementalAndDifferential, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.BlackoutWindowDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IBlackoutWindowDetails" />.
        /// </returns>
        public static Commvault.Powershell.Models.IBlackoutWindowDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BlackoutWindowDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.BlackoutWindowDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IBlackoutWindowDetails" />.
        /// </returns>
        public static Commvault.Powershell.Models.IBlackoutWindowDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BlackoutWindowDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BlackoutWindowDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IBlackoutWindowDetails FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(BlackoutWindowDetailsTypeConverter))]
    public partial interface IBlackoutWindowDetails

    {

    }
}