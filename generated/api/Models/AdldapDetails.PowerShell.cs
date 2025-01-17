// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Details of an AD/LDAP domain</summary>
    [System.ComponentModel.TypeConverter(typeof(AdldapDetailsTypeConverter))]
    public partial class AdldapDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.AdldapDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AdldapDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Company = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Company",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Company, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).DomainName = (string) content.GetValueForProperty("DomainName",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).DomainName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).DirectoryType = (string) content.GetValueForProperty("DirectoryType",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).DirectoryType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Credentials = (string) content.GetValueForProperty("Credentials",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Credentials, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Users = (int?) content.GetValueForProperty("Users",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Users, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).UserGroups = (int?) content.GetValueForProperty("UserGroups",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).UserGroups, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).BaseDnForCardUsers = (string) content.GetValueForProperty("BaseDnForCardUsers",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).BaseDnForCardUsers, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).UseSecureLdap = (bool?) content.GetValueForProperty("UseSecureLdap",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).UseSecureLdap, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).EnableSso = (bool?) content.GetValueForProperty("EnableSso",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).EnableSso, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).AccessViaClient = (bool?) content.GetValueForProperty("AccessViaClient",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).AccessViaClient, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Proxies = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("Proxies",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Proxies, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).LdapQueryParameters = (Commvault.Powershell.Models.ILdapAttribute[]) content.GetValueForProperty("LdapQueryParameters",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).LdapQueryParameters, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ILdapAttribute>(__y, Commvault.Powershell.Models.LdapAttributeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).AttributeMap = (Commvault.Powershell.Models.ILdapAttribute[]) content.GetValueForProperty("AttributeMap",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).AttributeMap, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ILdapAttribute>(__y, Commvault.Powershell.Models.LdapAttributeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).CompanyId = (int?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).CompanyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).CompanyName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.AdldapDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AdldapDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Company = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Company",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Company, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Id = (int?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Id, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).DomainName = (string) content.GetValueForProperty("DomainName",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).DomainName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).DirectoryType = (string) content.GetValueForProperty("DirectoryType",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).DirectoryType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Credentials = (string) content.GetValueForProperty("Credentials",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Credentials, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Users = (int?) content.GetValueForProperty("Users",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Users, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).UserGroups = (int?) content.GetValueForProperty("UserGroups",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).UserGroups, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).BaseDnForCardUsers = (string) content.GetValueForProperty("BaseDnForCardUsers",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).BaseDnForCardUsers, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).UseSecureLdap = (bool?) content.GetValueForProperty("UseSecureLdap",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).UseSecureLdap, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).EnableSso = (bool?) content.GetValueForProperty("EnableSso",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).EnableSso, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).AccessViaClient = (bool?) content.GetValueForProperty("AccessViaClient",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).AccessViaClient, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Proxies = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("Proxies",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).Proxies, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).LdapQueryParameters = (Commvault.Powershell.Models.ILdapAttribute[]) content.GetValueForProperty("LdapQueryParameters",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).LdapQueryParameters, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ILdapAttribute>(__y, Commvault.Powershell.Models.LdapAttributeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).AttributeMap = (Commvault.Powershell.Models.ILdapAttribute[]) content.GetValueForProperty("AttributeMap",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).AttributeMap, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ILdapAttribute>(__y, Commvault.Powershell.Models.LdapAttributeTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).CompanyId = (int?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).CompanyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAdldapDetailsInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IAdldapDetailsInternal)this).CompanyName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.AdldapDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IAdldapDetails" />.</returns>
        public static Commvault.Powershell.Models.IAdldapDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AdldapDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.AdldapDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IAdldapDetails" />.</returns>
        public static Commvault.Powershell.Models.IAdldapDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AdldapDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AdldapDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IAdldapDetails FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Details of an AD/LDAP domain
    [System.ComponentModel.TypeConverter(typeof(AdldapDetailsTypeConverter))]
    public partial interface IAdldapDetails

    {

    }
}