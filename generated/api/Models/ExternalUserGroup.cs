// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>External User Group Entity</summary>
    public partial class ExternalUserGroup :
        Commvault.Powershell.Models.IExternalUserGroup,
        Commvault.Powershell.Models.IExternalUserGroupInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        /// <summary>User Group Id</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>External Group Name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ProviderId" /> property.</summary>
        private int? _providerId;

        /// <summary>Provider id</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? ProviderId { get => this._providerId; set => this._providerId = value; }

        /// <summary>Backing field for <see cref="ProviderName" /> property.</summary>
        private string _providerName;

        /// <summary>Provider Name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ProviderName { get => this._providerName; set => this._providerName = value; }

        /// <summary>Creates an new <see cref="ExternalUserGroup" /> instance.</summary>
        public ExternalUserGroup()
        {

        }
    }
    /// External User Group Entity
    public partial interface IExternalUserGroup :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>User Group Id</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User Group Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }
        /// <summary>External Group Name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"External Group Name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Provider id</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provider id",
        SerializedName = @"providerId",
        PossibleTypes = new [] { typeof(int) })]
        int? ProviderId { get; set; }
        /// <summary>Provider Name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provider Name",
        SerializedName = @"providerName",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderName { get; set; }

    }
    /// External User Group Entity
    internal partial interface IExternalUserGroupInternal

    {
        /// <summary>User Group Id</summary>
        int? Id { get; set; }
        /// <summary>External Group Name</summary>
        string Name { get; set; }
        /// <summary>Provider id</summary>
        int? ProviderId { get; set; }
        /// <summary>Provider Name</summary>
        string ProviderName { get; set; }

    }
}