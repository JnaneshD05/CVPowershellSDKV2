// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Create a hypervisor group with Ali Baba as the destination vendor</summary>
    [System.ComponentModel.TypeConverter(typeof(CreateHypervisorGroupAliCloudTypeConverter))]
    public partial class CreateHypervisorGroupAliCloud
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.CreateHypervisorGroupAliCloud"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CreateHypervisorGroupAliCloud(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ICreateHypervisorGroupAliCloudInternal)this).HypervisorType = (string) content.GetValueForProperty("HypervisorType",((Commvault.Powershell.Models.ICreateHypervisorGroupAliCloudInternal)this).HypervisorType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateHypervisorGroupAliCloudInternal)this).AccessKey = (string) content.GetValueForProperty("AccessKey",((Commvault.Powershell.Models.ICreateHypervisorGroupAliCloudInternal)this).AccessKey, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateHypervisorGroupAliCloudInternal)this).SecretKey = (string) content.GetValueForProperty("SecretKey",((Commvault.Powershell.Models.ICreateHypervisorGroupAliCloudInternal)this).SecretKey, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsId = (int?) content.GetValueForProperty("CredentialsId",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsName = (string) content.GetValueForProperty("CredentialsName",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Credentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Credentials",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Credentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).SkipCredentialValidation = (bool?) content.GetValueForProperty("SkipCredentialValidation",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).SkipCredentialValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).AccessNodes = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("AccessNodes",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).AccessNodes, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.CreateHypervisorGroupAliCloud"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CreateHypervisorGroupAliCloud(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ICreateHypervisorGroupAliCloudInternal)this).HypervisorType = (string) content.GetValueForProperty("HypervisorType",((Commvault.Powershell.Models.ICreateHypervisorGroupAliCloudInternal)this).HypervisorType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateHypervisorGroupAliCloudInternal)this).AccessKey = (string) content.GetValueForProperty("AccessKey",((Commvault.Powershell.Models.ICreateHypervisorGroupAliCloudInternal)this).AccessKey, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateHypervisorGroupAliCloudInternal)this).SecretKey = (string) content.GetValueForProperty("SecretKey",((Commvault.Powershell.Models.ICreateHypervisorGroupAliCloudInternal)this).SecretKey, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsId = (int?) content.GetValueForProperty("CredentialsId",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsName = (string) content.GetValueForProperty("CredentialsName",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).CredentialsName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Credentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Credentials",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Credentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).SkipCredentialValidation = (bool?) content.GetValueForProperty("SkipCredentialValidation",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).SkipCredentialValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).AccessNodes = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("AccessNodes",((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)this).AccessNodes, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.CreateHypervisorGroupAliCloud"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.ICreateHypervisorGroupAliCloud" />.
        /// </returns>
        public static Commvault.Powershell.Models.ICreateHypervisorGroupAliCloud DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CreateHypervisorGroupAliCloud(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.CreateHypervisorGroupAliCloud"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.ICreateHypervisorGroupAliCloud" />.
        /// </returns>
        public static Commvault.Powershell.Models.ICreateHypervisorGroupAliCloud DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CreateHypervisorGroupAliCloud(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CreateHypervisorGroupAliCloud" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.ICreateHypervisorGroupAliCloud FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Create a hypervisor group with Ali Baba as the destination vendor
    [System.ComponentModel.TypeConverter(typeof(CreateHypervisorGroupAliCloudTypeConverter))]
    public partial interface ICreateHypervisorGroupAliCloud

    {

    }
}