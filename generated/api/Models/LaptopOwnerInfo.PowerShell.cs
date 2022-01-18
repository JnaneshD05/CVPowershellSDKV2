// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Model used for laptop owner mapping</summary>
    [System.ComponentModel.TypeConverter(typeof(LaptopOwnerInfoTypeConverter))]
    public partial class LaptopOwnerInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.LaptopOwnerInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ILaptopOwnerInfo" />.</returns>
        public static Commvault.Powershell.Models.ILaptopOwnerInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LaptopOwnerInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.LaptopOwnerInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ILaptopOwnerInfo" />.</returns>
        public static Commvault.Powershell.Models.ILaptopOwnerInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LaptopOwnerInfo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LaptopOwnerInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.ILaptopOwnerInfo FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.LaptopOwnerInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LaptopOwnerInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).Company = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Company",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).Company, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).Id = (int) content.GetValueForProperty("Id",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).SerialNumber = (string) content.GetValueForProperty("SerialNumber",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).SerialNumber, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).LaptopName = (string) content.GetValueForProperty("LaptopName",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).LaptopName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).Host = (string) content.GetValueForProperty("Host",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).Host, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).OwnerEmail = (string) content.GetValueForProperty("OwnerEmail",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).OwnerEmail, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).OwnerUpn = (string) content.GetValueForProperty("OwnerUpn",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).OwnerUpn, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).OSType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).CompanyId = (int?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).CompanyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).CompanyName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.LaptopOwnerInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LaptopOwnerInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).Company = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Company",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).Company, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).Id = (int) content.GetValueForProperty("Id",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).SerialNumber = (string) content.GetValueForProperty("SerialNumber",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).SerialNumber, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).LaptopName = (string) content.GetValueForProperty("LaptopName",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).LaptopName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).Host = (string) content.GetValueForProperty("Host",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).Host, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).OwnerEmail = (string) content.GetValueForProperty("OwnerEmail",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).OwnerEmail, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).OwnerUpn = (string) content.GetValueForProperty("OwnerUpn",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).OwnerUpn, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).OSType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).CompanyId = (int?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).CompanyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.ILaptopOwnerInfoInternal)this).CompanyName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Model used for laptop owner mapping
    [System.ComponentModel.TypeConverter(typeof(LaptopOwnerInfoTypeConverter))]
    public partial interface ILaptopOwnerInfo

    {

    }
}