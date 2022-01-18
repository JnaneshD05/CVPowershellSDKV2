// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Applicable only for credentials with Cloud Account and Vendor Type as IBM Cloud Object Storage, OpenStack Object Storage
    /// or Rackspace Cloud Files
    /// </summary>
    public partial class CloudCredentialInfoWithApiKey :
        Commvault.Powershell.Models.ICloudCredentialInfoWithApiKey,
        Commvault.Powershell.Models.ICloudCredentialInfoWithApiKeyInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ICommonCredentialInfo" />
        /// </summary>
        private Commvault.Powershell.Models.ICommonCredentialInfo __commonCredentialInfo = new Commvault.Powershell.Models.CommonCredentialInfo();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ICreateCredential" />
        /// </summary>
        private Commvault.Powershell.Models.ICreateCredential __createCredential = new Commvault.Powershell.Models.CreateCredential();

        /// <summary>CredentialAccountType</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string AccountType { get => ((Commvault.Powershell.Models.ICreateCredentialInternal)__createCredential).AccountType; set => ((Commvault.Powershell.Models.ICreateCredentialInternal)__createCredential).AccountType = value ; }

        /// <summary>Backing field for <see cref="ApiKey" /> property.</summary>
        private string _apiKey;

        /// <summary>API Key of Credential and must be in base64 encoded format.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ApiKey { get => this._apiKey; set => this._apiKey = value; }

        /// <summary>Description of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Description { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).Description; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).Description = value ?? null; }

        /// <summary>Name of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Name { get => ((Commvault.Powershell.Models.ICreateCredentialInternal)__createCredential).Name; set => ((Commvault.Powershell.Models.ICreateCredentialInternal)__createCredential).Name = value ; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName OwnerUser { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).OwnerUser; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).OwnerUser = value ?? null /* model class */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName OwnerUserGroup { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).OwnerUserGroup; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).OwnerUserGroup = value ?? null /* model class */; }

        /// <summary>Security association of a list of users and user groups</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.ICredentialSecurity Security { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).Security; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).Security = value ?? null /* model class */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.ICredentialSecurityAssociations[] SecurityAssociations { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).SecurityAssociations; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).SecurityAssociations = value ?? null /* arrayOf */; }

        /// <summary>Owner of a credential can be a user or user group</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.ICredentialOwner SecurityOwner { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).SecurityOwner; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).SecurityOwner = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="UserAccount" /> property.</summary>
        private string _userAccount;

        /// <summary>User account of Credential</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UserAccount { get => this._userAccount; set => this._userAccount = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? UserGroupId { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserGroupId; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserGroupId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string UserGroupName { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserGroupName; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserGroupName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? UserId { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserId; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string UserName { get => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserName; set => ((Commvault.Powershell.Models.ICommonCredentialInfoInternal)__commonCredentialInfo).UserName = value ?? null; }

        /// <summary>Cloud vendor types appilcable only for Cloud Account type</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string VendorType { get => ((Commvault.Powershell.Models.ICreateCredentialInternal)__createCredential).VendorType; set => ((Commvault.Powershell.Models.ICreateCredentialInternal)__createCredential).VendorType = value ?? null; }

        /// <summary>Creates an new <see cref="CloudCredentialInfoWithApiKey" /> instance.</summary>
        public CloudCredentialInfoWithApiKey()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Commvault.Powershell.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Commvault.Powershell.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__createCredential), __createCredential);
            await eventListener.AssertObjectIsValid(nameof(__createCredential), __createCredential);
            await eventListener.AssertNotNull(nameof(__commonCredentialInfo), __commonCredentialInfo);
            await eventListener.AssertObjectIsValid(nameof(__commonCredentialInfo), __commonCredentialInfo);
        }
    }
    /// Applicable only for credentials with Cloud Account and Vendor Type as IBM Cloud Object Storage, OpenStack Object Storage
    /// or Rackspace Cloud Files
    public partial interface ICloudCredentialInfoWithApiKey :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.ICreateCredential,
        Commvault.Powershell.Models.ICommonCredentialInfo
    {
        /// <summary>API Key of Credential and must be in base64 encoded format.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"API Key of Credential and must be in base64 encoded format.",
        SerializedName = @"apiKey",
        PossibleTypes = new [] { typeof(string) })]
        string ApiKey { get; set; }
        /// <summary>User account of Credential</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"User account of Credential",
        SerializedName = @"userAccount",
        PossibleTypes = new [] { typeof(string) })]
        string UserAccount { get; set; }

    }
    /// Applicable only for credentials with Cloud Account and Vendor Type as IBM Cloud Object Storage, OpenStack Object Storage
    /// or Rackspace Cloud Files
    internal partial interface ICloudCredentialInfoWithApiKeyInternal :
        Commvault.Powershell.Models.ICreateCredentialInternal,
        Commvault.Powershell.Models.ICommonCredentialInfoInternal
    {
        /// <summary>API Key of Credential and must be in base64 encoded format.</summary>
        string ApiKey { get; set; }
        /// <summary>User account of Credential</summary>
        string UserAccount { get; set; }

    }
}