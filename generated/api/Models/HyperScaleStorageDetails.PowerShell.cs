// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>HyperScaleStorageDetails</summary>
    [System.ComponentModel.TypeConverter(typeof(HyperScaleStorageDetailsTypeConverter))]
    public partial class HyperScaleStorageDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.HyperScaleStorageDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IHyperScaleStorageDetails" />.
        /// </returns>
        public static Commvault.Powershell.Models.IHyperScaleStorageDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HyperScaleStorageDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.HyperScaleStorageDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IHyperScaleStorageDetails" />.
        /// </returns>
        public static Commvault.Powershell.Models.IHyperScaleStorageDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HyperScaleStorageDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HyperScaleStorageDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IHyperScaleStorageDetails FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.HyperScaleStorageDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HyperScaleStorageDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).General = (Commvault.Powershell.Models.IHyperScaleStorageGeneralInfo) content.GetValueForProperty("General",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).General, Commvault.Powershell.Models.HyperScaleStorageGeneralInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).Encryption = (Commvault.Powershell.Models.IEncryption) content.GetValueForProperty("Encryption",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).Encryption, Commvault.Powershell.Models.EncryptionTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).Nodes = (Commvault.Powershell.Models.IIdNameStatus[]) content.GetValueForProperty("Nodes",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).Nodes, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdNameStatus>(__y, Commvault.Powershell.Models.IdNameStatusTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).Security = (Commvault.Powershell.Models.ISecurityAssoc[]) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).Security, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ISecurityAssoc>(__y, Commvault.Powershell.Models.SecurityAssocTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).AssociatedPlans = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("AssociatedPlans",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).AssociatedPlans, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IIdNameInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IIdNameInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IIdNameInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IIdNameInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralLibraryName = (string) content.GetValueForProperty("GeneralLibraryName",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralLibraryName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralDevicePath = (string) content.GetValueForProperty("GeneralDevicePath",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralDevicePath, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralTotalCapacity = (int?) content.GetValueForProperty("GeneralTotalCapacity",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralTotalCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralTotalFreeSpace = (int?) content.GetValueForProperty("GeneralTotalFreeSpace",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralTotalFreeSpace, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralSizeOndisk = (int?) content.GetValueForProperty("GeneralSizeOndisk",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralSizeOndisk, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralResiliency = (string) content.GetValueForProperty("GeneralResiliency",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralResiliency, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralDeduplicationSavings = (string) content.GetValueForProperty("GeneralDeduplicationSavings",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralDeduplicationSavings, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralStatus = (string) content.GetValueForProperty("GeneralStatus",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionKeyProvider = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("EncryptionKeyProvider",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionKeyProvider, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionEncrypt = (bool?) content.GetValueForProperty("EncryptionEncrypt",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionEncrypt, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionKeyLength = (int?) content.GetValueForProperty("EncryptionKeyLength",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionKeyLength, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionCipher = (string) content.GetValueForProperty("EncryptionCipher",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionCipher, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).KeyProviderId = (int?) content.GetValueForProperty("KeyProviderId",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).KeyProviderId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).KeyProviderName = (string) content.GetValueForProperty("KeyProviderName",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).KeyProviderName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.HyperScaleStorageDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HyperScaleStorageDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).General = (Commvault.Powershell.Models.IHyperScaleStorageGeneralInfo) content.GetValueForProperty("General",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).General, Commvault.Powershell.Models.HyperScaleStorageGeneralInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).Encryption = (Commvault.Powershell.Models.IEncryption) content.GetValueForProperty("Encryption",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).Encryption, Commvault.Powershell.Models.EncryptionTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).Nodes = (Commvault.Powershell.Models.IIdNameStatus[]) content.GetValueForProperty("Nodes",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).Nodes, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdNameStatus>(__y, Commvault.Powershell.Models.IdNameStatusTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).Security = (Commvault.Powershell.Models.ISecurityAssoc[]) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).Security, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ISecurityAssoc>(__y, Commvault.Powershell.Models.SecurityAssocTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).AssociatedPlans = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("AssociatedPlans",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).AssociatedPlans, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IIdNameInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IIdNameInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IIdNameInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IIdNameInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralLibraryName = (string) content.GetValueForProperty("GeneralLibraryName",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralLibraryName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralDevicePath = (string) content.GetValueForProperty("GeneralDevicePath",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralDevicePath, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralTotalCapacity = (int?) content.GetValueForProperty("GeneralTotalCapacity",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralTotalCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralTotalFreeSpace = (int?) content.GetValueForProperty("GeneralTotalFreeSpace",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralTotalFreeSpace, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralSizeOndisk = (int?) content.GetValueForProperty("GeneralSizeOndisk",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralSizeOndisk, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralResiliency = (string) content.GetValueForProperty("GeneralResiliency",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralResiliency, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralDeduplicationSavings = (string) content.GetValueForProperty("GeneralDeduplicationSavings",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralDeduplicationSavings, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralStatus = (string) content.GetValueForProperty("GeneralStatus",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).GeneralStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionKeyProvider = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("EncryptionKeyProvider",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionKeyProvider, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionEncrypt = (bool?) content.GetValueForProperty("EncryptionEncrypt",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionEncrypt, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionKeyLength = (int?) content.GetValueForProperty("EncryptionKeyLength",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionKeyLength, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionCipher = (string) content.GetValueForProperty("EncryptionCipher",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).EncryptionCipher, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).KeyProviderId = (int?) content.GetValueForProperty("KeyProviderId",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).KeyProviderId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).KeyProviderName = (string) content.GetValueForProperty("KeyProviderName",((Commvault.Powershell.Models.IHyperScaleStorageDetailsInternal)this).KeyProviderName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// HyperScaleStorageDetails
    [System.ComponentModel.TypeConverter(typeof(HyperScaleStorageDetailsTypeConverter))]
    public partial interface IHyperScaleStorageDetails

    {

    }
}