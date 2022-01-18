// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Owner of a credential can be a user or user group</summary>
    public partial class CredentialOwner :
        Commvault.Powershell.Models.ICredentialOwner,
        Commvault.Powershell.Models.ICredentialOwnerInternal
    {

        /// <summary>Internal Acessors for User</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICredentialOwnerInternal.User { get => (this._user = this._user ?? new Commvault.Powershell.Models.IdName()); set { {_user = value;} } }

        /// <summary>Internal Acessors for UserGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICredentialOwnerInternal.UserGroup { get => (this._userGroup = this._userGroup ?? new Commvault.Powershell.Models.IdName()); set { {_userGroup = value;} } }

        /// <summary>Backing field for <see cref="User" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _user;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName User { get => (this._user = this._user ?? new Commvault.Powershell.Models.IdName()); set => this._user = value; }

        /// <summary>Backing field for <see cref="UserGroup" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _userGroup;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName UserGroup { get => (this._userGroup = this._userGroup ?? new Commvault.Powershell.Models.IdName()); set => this._userGroup = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? UserGroupId { get => ((Commvault.Powershell.Models.IIdNameInternal)UserGroup).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)UserGroup).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserGroupName { get => ((Commvault.Powershell.Models.IIdNameInternal)UserGroup).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)UserGroup).Name = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? UserId { get => ((Commvault.Powershell.Models.IIdNameInternal)User).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)User).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserName { get => ((Commvault.Powershell.Models.IIdNameInternal)User).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)User).Name = value ?? null; }

        /// <summary>Creates an new <see cref="CredentialOwner" /> instance.</summary>
        public CredentialOwner()
        {

        }
    }
    /// Owner of a credential can be a user or user group
    public partial interface ICredentialOwner :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? UserGroupId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string UserGroupName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? UserId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }

    }
    /// Owner of a credential can be a user or user group
    internal partial interface ICredentialOwnerInternal

    {
        Commvault.Powershell.Models.IIdName User { get; set; }

        Commvault.Powershell.Models.IIdName UserGroup { get; set; }

        int? UserGroupId { get; set; }

        string UserGroupName { get; set; }

        int? UserId { get; set; }

        string UserName { get; set; }

    }
}