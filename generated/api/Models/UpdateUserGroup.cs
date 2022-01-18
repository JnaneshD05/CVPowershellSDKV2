// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class UpdateUserGroup :
        Commvault.Powershell.Models.IUpdateUserGroup,
        Commvault.Powershell.Models.IUpdateUserGroupInternal
    {

        /// <summary>Backing field for <see cref="AllowMultipleCompanyMembers" /> property.</summary>
        private bool? _allowMultipleCompanyMembers;

        /// <summary>
        /// This property can be used to allow addition of users/groups from child companies. Only applicable for commcell and reseller
        /// company group.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? AllowMultipleCompanyMembers { get => this._allowMultipleCompanyMembers; set => this._allowMultipleCompanyMembers = value; }

        /// <summary>Backing field for <see cref="AssociatedExternalGroups" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _associatedExternalGroups;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] AssociatedExternalGroups { get => this._associatedExternalGroups; set => this._associatedExternalGroups = value; }

        /// <summary>Backing field for <see cref="AssociatedLocalGroups" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _associatedLocalGroups;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] AssociatedLocalGroups { get => this._associatedLocalGroups; set => this._associatedLocalGroups = value; }

        /// <summary>Internal Acessors for LaptopPlan</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IUpdateUserGroupInternal.LaptopPlan { get => (this._laptopPlan = this._laptopPlan ?? new Commvault.Powershell.Models.IdName()); set { {_laptopPlan = value;} } }

        /// <summary>Backing field for <see cref="ConsoleType" /> property.</summary>
        private string[] _consoleType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string[] ConsoleType { get => this._consoleType; set => this._consoleType = value; }

        /// <summary>Backing field for <see cref="ConsoleTypeOperationType" /> property.</summary>
        private string _consoleTypeOperationType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ConsoleTypeOperationType { get => this._consoleTypeOperationType; set => this._consoleTypeOperationType = value; }

        /// <summary>Backing field for <see cref="EnableTwoFactorAuthentication" /> property.</summary>
        private string _enableTwoFactorAuthentication;

        /// <summary>
        /// Allows two-factor authentication to be enabled for the specific types of usergroups. it can be turned on or off based
        /// on user preferences. There will be usergroups that will not have this option.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string EnableTwoFactorAuthentication { get => this._enableTwoFactorAuthentication; set => this._enableTwoFactorAuthentication = value; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>allows the enabling/disabling of the user group.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="EnforceFsQuota" /> property.</summary>
        private bool? _enforceFsQuota;

        /// <summary>determines if a data limit will be set for the user group.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? EnforceFsQuota { get => this._enforceFsQuota; set => this._enforceFsQuota = value; }

        /// <summary>Backing field for <see cref="ExternalUserGroupsOperationType" /> property.</summary>
        private string _externalUserGroupsOperationType;

        /// <summary>
        /// Allows adding, deleting or overwriting associated external user groups of a user group. Default is adding associated external
        /// user groups
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ExternalUserGroupsOperationType { get => this._externalUserGroupsOperationType; set => this._externalUserGroupsOperationType = value; }

        /// <summary>Backing field for <see cref="LaptopAdmins" /> property.</summary>
        private bool? _laptopAdmins;

        /// <summary>When set to true, users in this group cannot activate or be set as server owner</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? LaptopAdmins { get => this._laptopAdmins; set => this._laptopAdmins = value; }

        /// <summary>Backing field for <see cref="LaptopPlan" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _laptopPlan;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName LaptopPlan { get => (this._laptopPlan = this._laptopPlan ?? new Commvault.Powershell.Models.IdName()); set => this._laptopPlan = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? LaptopPlanId { get => ((Commvault.Powershell.Models.IIdNameInternal)LaptopPlan).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)LaptopPlan).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string LaptopPlanName { get => ((Commvault.Powershell.Models.IIdNameInternal)LaptopPlan).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)LaptopPlan).Name = value ?? null; }

        /// <summary>Backing field for <see cref="LocalUserGroupsOperationType" /> property.</summary>
        private string _localUserGroupsOperationType;

        /// <summary>
        /// Allows adding, deleting or overwriting associated local user groups of a user group. Default is adding associated local
        /// user groups
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string LocalUserGroupsOperationType { get => this._localUserGroupsOperationType; set => this._localUserGroupsOperationType = value; }

        /// <summary>Backing field for <see cref="NewDescription" /> property.</summary>
        private string _newDescription;

        /// <summary>gives a new description to the user group.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NewDescription { get => this._newDescription; set => this._newDescription = value; }

        /// <summary>Backing field for <see cref="NewName" /> property.</summary>
        private string _newName;

        /// <summary>gives a new name to the user group.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NewName { get => this._newName; set => this._newName = value; }

        /// <summary>Backing field for <see cref="PlanOperationType" /> property.</summary>
        private string _planOperationType;

        /// <summary>
        /// determines if an existing user has to be added to the user group or removed from the user group
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string PlanOperationType { get => this._planOperationType; set => this._planOperationType = value; }

        /// <summary>Backing field for <see cref="QuotaLimitInGb" /> property.</summary>
        private int? _quotaLimitInGb;

        /// <summary>if enforceFSquota is enabled, the quota limit can be provided in GBs</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? QuotaLimitInGb { get => this._quotaLimitInGb; set => this._quotaLimitInGb = value; }

        /// <summary>Backing field for <see cref="UserOperationType" /> property.</summary>
        private string _userOperationType;

        /// <summary>
        /// determines if an existing user has to be added to the user group or removed from the user group
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UserOperationType { get => this._userOperationType; set => this._userOperationType = value; }

        /// <summary>Backing field for <see cref="Users" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _users;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] Users { get => this._users; set => this._users = value; }

        /// <summary>Creates an new <see cref="UpdateUserGroup" /> instance.</summary>
        public UpdateUserGroup()
        {

        }
    }
    public partial interface IUpdateUserGroup :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// This property can be used to allow addition of users/groups from child companies. Only applicable for commcell and reseller
        /// company group.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This property can be used to allow addition of users/groups from child companies. Only applicable for commcell and reseller company group.",
        SerializedName = @"allowMultipleCompanyMembers",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowMultipleCompanyMembers { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"associatedExternalGroups",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] AssociatedExternalGroups { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"associatedLocalGroups",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] AssociatedLocalGroups { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"consoleType",
        PossibleTypes = new [] { typeof(string) })]
        string[] ConsoleType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"consoleTypeOperationType",
        PossibleTypes = new [] { typeof(string) })]
        string ConsoleTypeOperationType { get; set; }
        /// <summary>
        /// Allows two-factor authentication to be enabled for the specific types of usergroups. it can be turned on or off based
        /// on user preferences. There will be usergroups that will not have this option.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Allows two-factor authentication to be enabled for the specific types of usergroups. it can be turned on or off based on user preferences. There will be usergroups that will not have this option.",
        SerializedName = @"enableTwoFactorAuthentication",
        PossibleTypes = new [] { typeof(string) })]
        string EnableTwoFactorAuthentication { get; set; }
        /// <summary>allows the enabling/disabling of the user group.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"allows the enabling/disabling of the user group.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>determines if a data limit will be set for the user group.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"determines if a data limit will be set for the user group.",
        SerializedName = @"enforceFSQuota",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnforceFsQuota { get; set; }
        /// <summary>
        /// Allows adding, deleting or overwriting associated external user groups of a user group. Default is adding associated external
        /// user groups
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Allows adding, deleting or overwriting associated external user groups of a user group. Default is adding associated external user groups",
        SerializedName = @"externalUserGroupsOperationType",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalUserGroupsOperationType { get; set; }
        /// <summary>When set to true, users in this group cannot activate or be set as server owner</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When set to true, users in this group cannot activate or be set as server owner",
        SerializedName = @"laptopAdmins",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LaptopAdmins { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? LaptopPlanId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string LaptopPlanName { get; set; }
        /// <summary>
        /// Allows adding, deleting or overwriting associated local user groups of a user group. Default is adding associated local
        /// user groups
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Allows adding, deleting or overwriting associated local user groups of a user group. Default is adding associated local user groups",
        SerializedName = @"localUserGroupsOperationType",
        PossibleTypes = new [] { typeof(string) })]
        string LocalUserGroupsOperationType { get; set; }
        /// <summary>gives a new description to the user group.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"gives a new description to the user group.",
        SerializedName = @"newDescription",
        PossibleTypes = new [] { typeof(string) })]
        string NewDescription { get; set; }
        /// <summary>gives a new name to the user group.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"gives a new name to the user group.",
        SerializedName = @"newName",
        PossibleTypes = new [] { typeof(string) })]
        string NewName { get; set; }
        /// <summary>
        /// determines if an existing user has to be added to the user group or removed from the user group
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"determines if an existing user has to be added to the user group or removed from the user group",
        SerializedName = @"planOperationType",
        PossibleTypes = new [] { typeof(string) })]
        string PlanOperationType { get; set; }
        /// <summary>if enforceFSquota is enabled, the quota limit can be provided in GBs</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"if enforceFSquota is enabled, the quota limit can be provided in GBs",
        SerializedName = @"quotaLimitInGB",
        PossibleTypes = new [] { typeof(int) })]
        int? QuotaLimitInGb { get; set; }
        /// <summary>
        /// determines if an existing user has to be added to the user group or removed from the user group
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"determines if an existing user has to be added to the user group or removed from the user group",
        SerializedName = @"userOperationType",
        PossibleTypes = new [] { typeof(string) })]
        string UserOperationType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"users",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] Users { get; set; }

    }
    internal partial interface IUpdateUserGroupInternal

    {
        /// <summary>
        /// This property can be used to allow addition of users/groups from child companies. Only applicable for commcell and reseller
        /// company group.
        /// </summary>
        bool? AllowMultipleCompanyMembers { get; set; }

        Commvault.Powershell.Models.IIdName[] AssociatedExternalGroups { get; set; }

        Commvault.Powershell.Models.IIdName[] AssociatedLocalGroups { get; set; }

        string[] ConsoleType { get; set; }

        string ConsoleTypeOperationType { get; set; }
        /// <summary>
        /// Allows two-factor authentication to be enabled for the specific types of usergroups. it can be turned on or off based
        /// on user preferences. There will be usergroups that will not have this option.
        /// </summary>
        string EnableTwoFactorAuthentication { get; set; }
        /// <summary>allows the enabling/disabling of the user group.</summary>
        bool? Enabled { get; set; }
        /// <summary>determines if a data limit will be set for the user group.</summary>
        bool? EnforceFsQuota { get; set; }
        /// <summary>
        /// Allows adding, deleting or overwriting associated external user groups of a user group. Default is adding associated external
        /// user groups
        /// </summary>
        string ExternalUserGroupsOperationType { get; set; }
        /// <summary>When set to true, users in this group cannot activate or be set as server owner</summary>
        bool? LaptopAdmins { get; set; }

        Commvault.Powershell.Models.IIdName LaptopPlan { get; set; }

        int? LaptopPlanId { get; set; }

        string LaptopPlanName { get; set; }
        /// <summary>
        /// Allows adding, deleting or overwriting associated local user groups of a user group. Default is adding associated local
        /// user groups
        /// </summary>
        string LocalUserGroupsOperationType { get; set; }
        /// <summary>gives a new description to the user group.</summary>
        string NewDescription { get; set; }
        /// <summary>gives a new name to the user group.</summary>
        string NewName { get; set; }
        /// <summary>
        /// determines if an existing user has to be added to the user group or removed from the user group
        /// </summary>
        string PlanOperationType { get; set; }
        /// <summary>if enforceFSquota is enabled, the quota limit can be provided in GBs</summary>
        int? QuotaLimitInGb { get; set; }
        /// <summary>
        /// determines if an existing user has to be added to the user group or removed from the user group
        /// </summary>
        string UserOperationType { get; set; }

        Commvault.Powershell.Models.IIdName[] Users { get; set; }

    }
}