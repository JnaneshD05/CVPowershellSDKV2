// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Nutanix Objects</summary>
    [System.ComponentModel.TypeConverter(typeof(NutanixBucketTypeConverter))]
    public partial class NutanixBucket
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.NutanixBucket"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.INutanixBucket" />.</returns>
        public static Commvault.Powershell.Models.INutanixBucket DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new NutanixBucket(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.NutanixBucket"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.INutanixBucket" />.</returns>
        public static Commvault.Powershell.Models.INutanixBucket DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new NutanixBucket(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="NutanixBucket" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.INutanixBucket FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.NutanixBucket"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal NutanixBucket(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).MediaAgent = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("MediaAgent",((Commvault.Powershell.Models.INutanixBucketInternal)this).MediaAgent, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).Credentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Credentials",((Commvault.Powershell.Models.INutanixBucketInternal)this).Credentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).CloudType = (string) content.GetValueForProperty("CloudType",((Commvault.Powershell.Models.INutanixBucketInternal)this).CloudType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).ServiceHost = (string) content.GetValueForProperty("ServiceHost",((Commvault.Powershell.Models.INutanixBucketInternal)this).ServiceHost, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).Bucket = (string) content.GetValueForProperty("Bucket",((Commvault.Powershell.Models.INutanixBucketInternal)this).Bucket, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).ProxyAddress = (string) content.GetValueForProperty("ProxyAddress",((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).ProxyAddress, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).Port = (int?) content.GetValueForProperty("Port",((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).Port, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).Username = (string) content.GetValueForProperty("Username",((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).Username, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).Password = (System.Security.SecureString) content.GetValueForProperty("Password",((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).Password, (object ss) => (System.Security.SecureString)ss);
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).MediaAgentId = (int?) content.GetValueForProperty("MediaAgentId",((Commvault.Powershell.Models.INutanixBucketInternal)this).MediaAgentId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).MediaAgentName = (string) content.GetValueForProperty("MediaAgentName",((Commvault.Powershell.Models.INutanixBucketInternal)this).MediaAgentName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).CredentialsId = (int?) content.GetValueForProperty("CredentialsId",((Commvault.Powershell.Models.INutanixBucketInternal)this).CredentialsId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).CredentialsName = (string) content.GetValueForProperty("CredentialsName",((Commvault.Powershell.Models.INutanixBucketInternal)this).CredentialsName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.NutanixBucket"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal NutanixBucket(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).MediaAgent = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("MediaAgent",((Commvault.Powershell.Models.INutanixBucketInternal)this).MediaAgent, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).Credentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Credentials",((Commvault.Powershell.Models.INutanixBucketInternal)this).Credentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).CloudType = (string) content.GetValueForProperty("CloudType",((Commvault.Powershell.Models.INutanixBucketInternal)this).CloudType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).ServiceHost = (string) content.GetValueForProperty("ServiceHost",((Commvault.Powershell.Models.INutanixBucketInternal)this).ServiceHost, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).Bucket = (string) content.GetValueForProperty("Bucket",((Commvault.Powershell.Models.INutanixBucketInternal)this).Bucket, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).ProxyAddress = (string) content.GetValueForProperty("ProxyAddress",((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).ProxyAddress, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).Port = (int?) content.GetValueForProperty("Port",((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).Port, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).Username = (string) content.GetValueForProperty("Username",((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).Username, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).Password = (System.Security.SecureString) content.GetValueForProperty("Password",((Commvault.Powershell.Models.ICloudStorageProxyInternal)this).Password, (object ss) => (System.Security.SecureString)ss);
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).MediaAgentId = (int?) content.GetValueForProperty("MediaAgentId",((Commvault.Powershell.Models.INutanixBucketInternal)this).MediaAgentId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).MediaAgentName = (string) content.GetValueForProperty("MediaAgentName",((Commvault.Powershell.Models.INutanixBucketInternal)this).MediaAgentName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).CredentialsId = (int?) content.GetValueForProperty("CredentialsId",((Commvault.Powershell.Models.INutanixBucketInternal)this).CredentialsId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.INutanixBucketInternal)this).CredentialsName = (string) content.GetValueForProperty("CredentialsName",((Commvault.Powershell.Models.INutanixBucketInternal)this).CredentialsName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Nutanix Objects
    [System.ComponentModel.TypeConverter(typeof(NutanixBucketTypeConverter))]
    public partial interface INutanixBucket

    {

    }
}