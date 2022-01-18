// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(LaptopsWebConsoleTypeConverter))]
    public partial class LaptopsWebConsole
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.LaptopsWebConsole"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ILaptopsWebConsole" />.</returns>
        public static Commvault.Powershell.Models.ILaptopsWebConsole DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LaptopsWebConsole(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.LaptopsWebConsole"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ILaptopsWebConsole" />.</returns>
        public static Commvault.Powershell.Models.ILaptopsWebConsole DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LaptopsWebConsole(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LaptopsWebConsole" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.ILaptopsWebConsole FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.LaptopsWebConsole"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LaptopsWebConsole(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfo = (Commvault.Powershell.Models.ILastBackupJobInfo) content.GetValueForProperty("LastBackupJobInfo",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfo, Commvault.Powershell.Models.LastBackupJobInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupTime = (int?) content.GetValueForProperty("LastBackupTime",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).TotalBackupSize = (int?) content.GetValueForProperty("TotalBackupSize",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).TotalBackupSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).NextBackupTime = (int?) content.GetValueForProperty("NextBackupTime",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).NextBackupTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).SlaStatus = (string) content.GetValueForProperty("SlaStatus",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).SlaStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).SlaReason = (string) content.GetValueForProperty("SlaReason",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).SlaReason, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoFailureReason = (string) content.GetValueForProperty("LastBackupJobInfoFailureReason",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoFailureReason, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoJobId = (int?) content.GetValueForProperty("LastBackupJobInfoJobId",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoJobId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoStatus = (string) content.GetValueForProperty("LastBackupJobInfoStatus",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoTime = (long?) content.GetValueForProperty("LastBackupJobInfoTime",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.LaptopsWebConsole"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LaptopsWebConsole(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfo = (Commvault.Powershell.Models.ILastBackupJobInfo) content.GetValueForProperty("LastBackupJobInfo",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfo, Commvault.Powershell.Models.LastBackupJobInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupTime = (int?) content.GetValueForProperty("LastBackupTime",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).TotalBackupSize = (int?) content.GetValueForProperty("TotalBackupSize",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).TotalBackupSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).NextBackupTime = (int?) content.GetValueForProperty("NextBackupTime",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).NextBackupTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).SlaStatus = (string) content.GetValueForProperty("SlaStatus",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).SlaStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).SlaReason = (string) content.GetValueForProperty("SlaReason",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).SlaReason, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoFailureReason = (string) content.GetValueForProperty("LastBackupJobInfoFailureReason",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoFailureReason, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoJobId = (int?) content.GetValueForProperty("LastBackupJobInfoJobId",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoJobId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoStatus = (string) content.GetValueForProperty("LastBackupJobInfoStatus",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoTime = (long?) content.GetValueForProperty("LastBackupJobInfoTime",((Commvault.Powershell.Models.ILaptopsWebConsoleInternal)this).LastBackupJobInfoTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(LaptopsWebConsoleTypeConverter))]
    public partial interface ILaptopsWebConsole

    {

    }
}