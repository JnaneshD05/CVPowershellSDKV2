// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>
    /// Applicable only for credentials with Cloud Account, Vendor Type as Amazon Web Services and authType is Access and Secret
    /// Keys
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(AmazonCredentialInfoTypeConverter))]
    public partial class AmazonCredentialInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.AmazonCredentialInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AmazonCredentialInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IAmazonCredentialInfoInternal)this).AuthType = (string) content.GetValueForProperty("AuthType",((Commvault.Powershell.Models.IAmazonCredentialInfoInternal)this).AuthType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAmazonCredentialInfoInternal)this).AccessKeyId = (string) content.GetValueForProperty("AccessKeyId",((Commvault.Powershell.Models.IAmazonCredentialInfoInternal)this).AccessKeyId, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAmazonCredentialInfoInternal)this).SecretAccessKey = (string) content.GetValueForProperty("SecretAccessKey",((Commvault.Powershell.Models.IAmazonCredentialInfoInternal)this).SecretAccessKey, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateCredentialInternal)this).AccountType = (string) content.GetValueForProperty("AccountType",((Commvault.Powershell.Models.ICreateCredentialInternal)this).AccountType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateCredentialInternal)this).VendorType = (string) content.GetValueForProperty("VendorType",((Commvault.Powershell.Models.ICreateCredentialInternal)this).VendorType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateCredentialInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ICreateCredentialInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).SecurityOwner = (Commvault.Powershell.Models.ICredentialOwner) content.GetValueForProperty("SecurityOwner",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).SecurityOwner, Commvault.Powershell.Models.CredentialOwnerTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).SecurityAssociations = (Commvault.Powershell.Models.ICredentialSecurityAssociations[]) content.GetValueForProperty("SecurityAssociations",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).SecurityAssociations, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ICredentialSecurityAssociations>(__y, Commvault.Powershell.Models.CredentialSecurityAssociationsTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).OwnerUser = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("OwnerUser",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).OwnerUser, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).OwnerUserGroup = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("OwnerUserGroup",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).OwnerUserGroup, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserId = (int?) content.GetValueForProperty("UserId",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserName = (string) content.GetValueForProperty("UserName",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserGroupId = (int?) content.GetValueForProperty("UserGroupId",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserGroupId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserGroupName = (string) content.GetValueForProperty("UserGroupName",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserGroupName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).Security = (Commvault.Powershell.Models.ICredentialSecurity) content.GetValueForProperty("Security",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).Security, Commvault.Powershell.Models.CredentialSecurityTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).Description = (string) content.GetValueForProperty("Description",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).Description, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.AmazonCredentialInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AmazonCredentialInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IAmazonCredentialInfoInternal)this).AuthType = (string) content.GetValueForProperty("AuthType",((Commvault.Powershell.Models.IAmazonCredentialInfoInternal)this).AuthType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAmazonCredentialInfoInternal)this).AccessKeyId = (string) content.GetValueForProperty("AccessKeyId",((Commvault.Powershell.Models.IAmazonCredentialInfoInternal)this).AccessKeyId, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAmazonCredentialInfoInternal)this).SecretAccessKey = (string) content.GetValueForProperty("SecretAccessKey",((Commvault.Powershell.Models.IAmazonCredentialInfoInternal)this).SecretAccessKey, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateCredentialInternal)this).AccountType = (string) content.GetValueForProperty("AccountType",((Commvault.Powershell.Models.ICreateCredentialInternal)this).AccountType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateCredentialInternal)this).VendorType = (string) content.GetValueForProperty("VendorType",((Commvault.Powershell.Models.ICreateCredentialInternal)this).VendorType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreateCredentialInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ICreateCredentialInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).SecurityOwner = (Commvault.Powershell.Models.ICredentialOwner) content.GetValueForProperty("SecurityOwner",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).SecurityOwner, Commvault.Powershell.Models.CredentialOwnerTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).SecurityAssociations = (Commvault.Powershell.Models.ICredentialSecurityAssociations[]) content.GetValueForProperty("SecurityAssociations",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).SecurityAssociations, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ICredentialSecurityAssociations>(__y, Commvault.Powershell.Models.CredentialSecurityAssociationsTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).OwnerUser = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("OwnerUser",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).OwnerUser, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).OwnerUserGroup = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("OwnerUserGroup",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).OwnerUserGroup, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserId = (int?) content.GetValueForProperty("UserId",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserName = (string) content.GetValueForProperty("UserName",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserGroupId = (int?) content.GetValueForProperty("UserGroupId",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserGroupId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserGroupName = (string) content.GetValueForProperty("UserGroupName",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).UserGroupName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).Security = (Commvault.Powershell.Models.ICredentialSecurity) content.GetValueForProperty("Security",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).Security, Commvault.Powershell.Models.CredentialSecurityTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).Description = (string) content.GetValueForProperty("Description",((Commvault.Powershell.Models.ICommonCredentialInfoInternal)this).Description, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.AmazonCredentialInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IAmazonCredentialInfo" />.
        /// </returns>
        public static Commvault.Powershell.Models.IAmazonCredentialInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AmazonCredentialInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.AmazonCredentialInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IAmazonCredentialInfo" />.
        /// </returns>
        public static Commvault.Powershell.Models.IAmazonCredentialInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AmazonCredentialInfo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AmazonCredentialInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IAmazonCredentialInfo FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Applicable only for credentials with Cloud Account, Vendor Type as Amazon Web Services and authType is Access and Secret
    /// Keys
    [System.ComponentModel.TypeConverter(typeof(AmazonCredentialInfoTypeConverter))]
    public partial interface IAmazonCredentialInfo

    {

    }
}