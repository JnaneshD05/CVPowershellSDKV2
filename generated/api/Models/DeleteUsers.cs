// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class DeleteUsers :
        Commvault.Powershell.Models.IDeleteUsers,
        Commvault.Powershell.Models.IDeleteUsersInternal
    {

        /// <summary>Internal Acessors for NewUser</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IDeleteUsersInternal.NewUser { get => (this._newUser = this._newUser ?? new Commvault.Powershell.Models.IdName()); set { {_newUser = value;} } }

        /// <summary>Internal Acessors for NewUserGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IDeleteUsersInternal.NewUserGroup { get => (this._newUserGroup = this._newUserGroup ?? new Commvault.Powershell.Models.IdName()); set { {_newUserGroup = value;} } }

        /// <summary>Internal Acessors for User</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IDeleteUsersInternal.User { get => (this._user = this._user ?? new Commvault.Powershell.Models.IdName()); set { {_user = value;} } }

        /// <summary>Backing field for <see cref="NewUser" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _newUser;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName NewUser { get => (this._newUser = this._newUser ?? new Commvault.Powershell.Models.IdName()); set => this._newUser = value; }

        /// <summary>Backing field for <see cref="NewUserGroup" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _newUserGroup;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName NewUserGroup { get => (this._newUserGroup = this._newUserGroup ?? new Commvault.Powershell.Models.IdName()); set => this._newUserGroup = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? NewUserGroupId { get => ((Commvault.Powershell.Models.IIdNameInternal)NewUserGroup).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)NewUserGroup).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string NewUserGroupName { get => ((Commvault.Powershell.Models.IIdNameInternal)NewUserGroup).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)NewUserGroup).Name = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? NewUserId { get => ((Commvault.Powershell.Models.IIdNameInternal)NewUser).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)NewUser).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string NewUserName { get => ((Commvault.Powershell.Models.IIdNameInternal)NewUser).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)NewUser).Name = value ?? null; }

        /// <summary>Backing field for <see cref="SkipOwnerTransfer" /> property.</summary>
        private bool? _skipOwnerTransfer;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? SkipOwnerTransfer { get => this._skipOwnerTransfer; set => this._skipOwnerTransfer = value; }

        /// <summary>Backing field for <see cref="User" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _user;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName User { get => (this._user = this._user ?? new Commvault.Powershell.Models.IdName()); set => this._user = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? UserId { get => ((Commvault.Powershell.Models.IIdNameInternal)User).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)User).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserName { get => ((Commvault.Powershell.Models.IIdNameInternal)User).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)User).Name = value ?? null; }

        /// <summary>Creates an new <see cref="DeleteUsers" /> instance.</summary>
        public DeleteUsers()
        {

        }
    }
    public partial interface IDeleteUsers :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? NewUserGroupId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string NewUserGroupName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? NewUserId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string NewUserName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"skipOwnerTransfer",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SkipOwnerTransfer { get; set; }

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
    internal partial interface IDeleteUsersInternal

    {
        Commvault.Powershell.Models.IIdName NewUser { get; set; }

        Commvault.Powershell.Models.IIdName NewUserGroup { get; set; }

        int? NewUserGroupId { get; set; }

        string NewUserGroupName { get; set; }

        int? NewUserId { get; set; }

        string NewUserName { get; set; }

        bool? SkipOwnerTransfer { get; set; }

        Commvault.Powershell.Models.IIdName User { get; set; }

        int? UserId { get; set; }

        string UserName { get; set; }

    }
}