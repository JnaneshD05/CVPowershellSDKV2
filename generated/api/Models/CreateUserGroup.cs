// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class CreateUserGroup :
        Commvault.Powershell.Models.ICreateUserGroup,
        Commvault.Powershell.Models.ICreateUserGroupInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="EnforceFsQuota" /> property.</summary>
        private bool? _enforceFsQuota;

        /// <summary>
        /// Used to determine if a backup data limit will be set for the user group being created
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? EnforceFsQuota { get => this._enforceFsQuota; set => this._enforceFsQuota = value; }

        /// <summary>Backing field for <see cref="LocalUserGroups" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _localUserGroups;

        /// <summary>
        /// This option is for AD user groups being created. Local user groups can be added to the active directory user groups.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] LocalUserGroups { get => this._localUserGroups; set => this._localUserGroups = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// To create an active directory usergroup, the domain name should be mentioned along with the usergroup name (domainName\\usergroupName)
        /// and localUserGroup value must be given.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="QuotaLimitInGb" /> property.</summary>
        private int? _quotaLimitInGb;

        /// <summary>if enforceFSQuota is set to true, the quota limit can be set in GBs</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? QuotaLimitInGb { get => this._quotaLimitInGb; set => this._quotaLimitInGb = value; }

        /// <summary>Creates an new <see cref="CreateUserGroup" /> instance.</summary>
        public CreateUserGroup()
        {

        }
    }
    public partial interface ICreateUserGroup :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>
        /// Used to determine if a backup data limit will be set for the user group being created
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Used to determine if a backup data limit will be set for the user group being created",
        SerializedName = @"enforceFSQuota",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnforceFsQuota { get; set; }
        /// <summary>
        /// This option is for AD user groups being created. Local user groups can be added to the active directory user groups.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This option is for AD user groups being created. Local user groups can be added to the active directory user groups.",
        SerializedName = @"localUserGroups",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] LocalUserGroups { get; set; }
        /// <summary>
        /// To create an active directory usergroup, the domain name should be mentioned along with the usergroup name (domainName\\usergroupName)
        /// and localUserGroup value must be given.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"To create an active directory usergroup, the domain name should be mentioned along with the usergroup name (domainName\\usergroupName) and localUserGroup value must be given.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>if enforceFSQuota is set to true, the quota limit can be set in GBs</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"if enforceFSQuota is set to true, the quota limit can be set in GBs",
        SerializedName = @"quotaLimitInGB",
        PossibleTypes = new [] { typeof(int) })]
        int? QuotaLimitInGb { get; set; }

    }
    internal partial interface ICreateUserGroupInternal

    {
        string Description { get; set; }
        /// <summary>
        /// Used to determine if a backup data limit will be set for the user group being created
        /// </summary>
        bool? EnforceFsQuota { get; set; }
        /// <summary>
        /// This option is for AD user groups being created. Local user groups can be added to the active directory user groups.
        /// </summary>
        Commvault.Powershell.Models.IIdName[] LocalUserGroups { get; set; }
        /// <summary>
        /// To create an active directory usergroup, the domain name should be mentioned along with the usergroup name (domainName\\usergroupName)
        /// and localUserGroup value must be given.
        /// </summary>
        string Name { get; set; }
        /// <summary>if enforceFSQuota is set to true, the quota limit can be set in GBs</summary>
        int? QuotaLimitInGb { get; set; }

    }
}