// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(CreateVMGroupRespTypeConverter))]
    public partial class CreateVMGroupResp
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.CreateVMGroupResp"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CreateVMGroupResp(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).SubclientId = (int?) content.GetValueForProperty("SubclientId",((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).SubclientId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).WarningCode = (int?) content.GetValueForProperty("WarningCode",((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).WarningCode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).ErrorCode = (int?) content.GetValueForProperty("ErrorCode",((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).ErrorCode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).ErrorMessage = (string) content.GetValueForProperty("ErrorMessage",((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).ErrorMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).WarningMessage = (string) content.GetValueForProperty("WarningMessage",((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).WarningMessage, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.CreateVMGroupResp"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CreateVMGroupResp(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).SubclientId = (int?) content.GetValueForProperty("SubclientId",((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).SubclientId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).WarningCode = (int?) content.GetValueForProperty("WarningCode",((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).WarningCode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).ErrorCode = (int?) content.GetValueForProperty("ErrorCode",((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).ErrorCode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).ErrorMessage = (string) content.GetValueForProperty("ErrorMessage",((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).ErrorMessage, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).WarningMessage = (string) content.GetValueForProperty("WarningMessage",((Commvault.Powershell.Models.ICreateVMGroupRespInternal)this).WarningMessage, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.CreateVMGroupResp"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ICreateVMGroupResp" />.</returns>
        public static Commvault.Powershell.Models.ICreateVMGroupResp DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CreateVMGroupResp(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.CreateVMGroupResp"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ICreateVMGroupResp" />.</returns>
        public static Commvault.Powershell.Models.ICreateVMGroupResp DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CreateVMGroupResp(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CreateVMGroupResp" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.ICreateVMGroupResp FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(CreateVMGroupRespTypeConverter))]
    public partial interface ICreateVMGroupResp

    {

    }
}