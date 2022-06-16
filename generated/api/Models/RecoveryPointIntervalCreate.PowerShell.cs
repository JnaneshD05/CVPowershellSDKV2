// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>
    /// Recovery point interval inputs for continuous replication group. Provide atleast one of crash consistent and application
    /// consistent interval.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(RecoveryPointIntervalCreateTypeConverter))]
    public partial class RecoveryPointIntervalCreate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.RecoveryPointIntervalCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IRecoveryPointIntervalCreate" />.
        /// </returns>
        public static Commvault.Powershell.Models.IRecoveryPointIntervalCreate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RecoveryPointIntervalCreate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.RecoveryPointIntervalCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IRecoveryPointIntervalCreate" />.
        /// </returns>
        public static Commvault.Powershell.Models.IRecoveryPointIntervalCreate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RecoveryPointIntervalCreate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RecoveryPointIntervalCreate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IRecoveryPointIntervalCreate FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.RecoveryPointIntervalCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RecoveryPointIntervalCreate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IRecoveryPointIntervalCreateInternal)this).CrashConsistentRpInterval = (int?) content.GetValueForProperty("CrashConsistentRpInterval",((Commvault.Powershell.Models.IRecoveryPointIntervalCreateInternal)this).CrashConsistentRpInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryPointIntervalCreateInternal)this).ApplicationConsistentRpInterval = (int?) content.GetValueForProperty("ApplicationConsistentRpInterval",((Commvault.Powershell.Models.IRecoveryPointIntervalCreateInternal)this).ApplicationConsistentRpInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.RecoveryPointIntervalCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RecoveryPointIntervalCreate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IRecoveryPointIntervalCreateInternal)this).CrashConsistentRpInterval = (int?) content.GetValueForProperty("CrashConsistentRpInterval",((Commvault.Powershell.Models.IRecoveryPointIntervalCreateInternal)this).CrashConsistentRpInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IRecoveryPointIntervalCreateInternal)this).ApplicationConsistentRpInterval = (int?) content.GetValueForProperty("ApplicationConsistentRpInterval",((Commvault.Powershell.Models.IRecoveryPointIntervalCreateInternal)this).ApplicationConsistentRpInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Recovery point interval inputs for continuous replication group. Provide atleast one of crash consistent and application
    /// consistent interval.
    [System.ComponentModel.TypeConverter(typeof(RecoveryPointIntervalCreateTypeConverter))]
    public partial interface IRecoveryPointIntervalCreate

    {

    }
}