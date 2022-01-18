// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>
    /// Applicable only for credentials with Cloud Account, Vendor Type as Amazon Web Services and authType is STS Assume Role
    /// with IAM Role Policy
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(AmazonCredentialContentWithRoleArnTypeConverter))]
    public partial class AmazonCredentialContentWithRoleArn
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.AmazonCredentialContentWithRoleArn"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AmazonCredentialContentWithRoleArn(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).Security = (Commvault.Powershell.Models.IUpdateCredentialSecurity) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).Security, Commvault.Powershell.Models.UpdateCredentialSecurityTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).NewName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).RoleArn = (string) content.GetValueForProperty("RoleArn",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).RoleArn, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).Description = (string) content.GetValueForProperty("Description",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).Description, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).SecurityOwner = (Commvault.Powershell.Models.ICredentialOwner) content.GetValueForProperty("SecurityOwner",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).SecurityOwner, Commvault.Powershell.Models.CredentialOwnerTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).SecurityAssociations = (Commvault.Powershell.Models.ICredentialSecurityAssociations[]) content.GetValueForProperty("SecurityAssociations",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).SecurityAssociations, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ICredentialSecurityAssociations>(__y, Commvault.Powershell.Models.CredentialSecurityAssociationsTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).OwnerUser = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("OwnerUser",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).OwnerUser, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).OwnerUserGroup = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("OwnerUserGroup",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).OwnerUserGroup, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserId = (int?) content.GetValueForProperty("UserId",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserName = (string) content.GetValueForProperty("UserName",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserGroupId = (int?) content.GetValueForProperty("UserGroupId",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserGroupId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserGroupName = (string) content.GetValueForProperty("UserGroupName",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserGroupName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.AmazonCredentialContentWithRoleArn"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AmazonCredentialContentWithRoleArn(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).Security = (Commvault.Powershell.Models.IUpdateCredentialSecurity) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).Security, Commvault.Powershell.Models.UpdateCredentialSecurityTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).NewName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).RoleArn = (string) content.GetValueForProperty("RoleArn",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).RoleArn, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).Description = (string) content.GetValueForProperty("Description",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).Description, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).SecurityOwner = (Commvault.Powershell.Models.ICredentialOwner) content.GetValueForProperty("SecurityOwner",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).SecurityOwner, Commvault.Powershell.Models.CredentialOwnerTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).SecurityAssociations = (Commvault.Powershell.Models.ICredentialSecurityAssociations[]) content.GetValueForProperty("SecurityAssociations",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).SecurityAssociations, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ICredentialSecurityAssociations>(__y, Commvault.Powershell.Models.CredentialSecurityAssociationsTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).OwnerUser = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("OwnerUser",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).OwnerUser, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).OwnerUserGroup = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("OwnerUserGroup",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).OwnerUserGroup, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserId = (int?) content.GetValueForProperty("UserId",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserName = (string) content.GetValueForProperty("UserName",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserGroupId = (int?) content.GetValueForProperty("UserGroupId",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserGroupId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserGroupName = (string) content.GetValueForProperty("UserGroupName",((Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArnInternal)this).UserGroupName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.AmazonCredentialContentWithRoleArn"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArn" />.
        /// </returns>
        public static Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArn DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AmazonCredentialContentWithRoleArn(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.AmazonCredentialContentWithRoleArn"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArn" />.
        /// </returns>
        public static Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArn DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AmazonCredentialContentWithRoleArn(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AmazonCredentialContentWithRoleArn" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IAmazonCredentialContentWithRoleArn FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Applicable only for credentials with Cloud Account, Vendor Type as Amazon Web Services and authType is STS Assume Role
    /// with IAM Role Policy
    [System.ComponentModel.TypeConverter(typeof(AmazonCredentialContentWithRoleArnTypeConverter))]
    public partial interface IAmazonCredentialContentWithRoleArn

    {

    }
}