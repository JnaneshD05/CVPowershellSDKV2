// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>
    /// If adding a network access path, Please add credentials or saved credentials. If both are provided, credentials will be
    /// taken into consideration.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(CreateBackupLocationTypeConverter))]
    public partial class CreateBackupLocation
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.CreateBackupLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CreateBackupLocation(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).MediaAgent = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("MediaAgent",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).MediaAgent, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).Credentials = (Commvault.Powershell.Models.IUserNamePassword) content.GetValueForProperty("Credentials",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).Credentials, Commvault.Powershell.Models.UserNamePasswordTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).SavedCredentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SavedCredentials",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).SavedCredentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).BackupLocation = (string) content.GetValueForProperty("BackupLocation",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).BackupLocation, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).MediaAgentId = (int?) content.GetValueForProperty("MediaAgentId",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).MediaAgentId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).MediaAgentName = (string) content.GetValueForProperty("MediaAgentName",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).MediaAgentName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).CredentialsName = (string) content.GetValueForProperty("CredentialsName",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).CredentialsName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).CredentialsPassword = (string) content.GetValueForProperty("CredentialsPassword",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).CredentialsPassword, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).SavedCredentialsId = (int?) content.GetValueForProperty("SavedCredentialsId",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).SavedCredentialsId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).SavedCredentialsName = (string) content.GetValueForProperty("SavedCredentialsName",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).SavedCredentialsName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.CreateBackupLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CreateBackupLocation(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).MediaAgent = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("MediaAgent",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).MediaAgent, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).Credentials = (Commvault.Powershell.Models.IUserNamePassword) content.GetValueForProperty("Credentials",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).Credentials, Commvault.Powershell.Models.UserNamePasswordTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).SavedCredentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SavedCredentials",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).SavedCredentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).BackupLocation = (string) content.GetValueForProperty("BackupLocation",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).BackupLocation, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).MediaAgentId = (int?) content.GetValueForProperty("MediaAgentId",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).MediaAgentId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).MediaAgentName = (string) content.GetValueForProperty("MediaAgentName",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).MediaAgentName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).CredentialsName = (string) content.GetValueForProperty("CredentialsName",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).CredentialsName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).CredentialsPassword = (string) content.GetValueForProperty("CredentialsPassword",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).CredentialsPassword, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).SavedCredentialsId = (int?) content.GetValueForProperty("SavedCredentialsId",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).SavedCredentialsId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).SavedCredentialsName = (string) content.GetValueForProperty("SavedCredentialsName",((Commvault.Powershell.Models.ICreateBackupLocationInternal)this).SavedCredentialsName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.CreateBackupLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.ICreateBackupLocation" />.
        /// </returns>
        public static Commvault.Powershell.Models.ICreateBackupLocation DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CreateBackupLocation(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.CreateBackupLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.ICreateBackupLocation" />.
        /// </returns>
        public static Commvault.Powershell.Models.ICreateBackupLocation DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CreateBackupLocation(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CreateBackupLocation" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.ICreateBackupLocation FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// If adding a network access path, Please add credentials or saved credentials. If both are provided, credentials will be
    /// taken into consideration.
    [System.ComponentModel.TypeConverter(typeof(CreateBackupLocationTypeConverter))]
    public partial interface ICreateBackupLocation

    {

    }
}