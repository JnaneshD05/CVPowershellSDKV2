// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Owner permissions and laptop ownership details</summary>
    public partial class AccessControl :
        Commvault.Powershell.Models.IAccessControl,
        Commvault.Powershell.Models.IAccessControlInternal
    {

        /// <summary>Backing field for <see cref="AutomaticLaptopOwnershipAssignment" /> property.</summary>
        private Commvault.Powershell.Models.ILaptopOwnership _automaticLaptopOwnershipAssignment;

        /// <summary>Details of automatic laptop ownership assignment</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ILaptopOwnership AutomaticLaptopOwnershipAssignment { get => (this._automaticLaptopOwnershipAssignment = this._automaticLaptopOwnershipAssignment ?? new Commvault.Powershell.Models.LaptopOwnership()); set => this._automaticLaptopOwnershipAssignment = value; }

        /// <summary>Whether the laptop ownership assignment is automatic or not</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? AutomaticLaptopOwnershipAssignmentAssignLaptopOwnerAutomatically { get => ((Commvault.Powershell.Models.ILaptopOwnershipInternal)AutomaticLaptopOwnershipAssignment).AssignLaptopOwnerAutomatically; set => ((Commvault.Powershell.Models.ILaptopOwnershipInternal)AutomaticLaptopOwnershipAssignment).AssignLaptopOwnerAutomatically = value ?? default(bool); }

        /// <summary>Options to automatically assign laptop owners</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string AutomaticLaptopOwnershipAssignmentLaptopOwnerOption { get => ((Commvault.Powershell.Models.ILaptopOwnershipInternal)AutomaticLaptopOwnershipAssignment).LaptopOwnerOption; set => ((Commvault.Powershell.Models.ILaptopOwnershipInternal)AutomaticLaptopOwnershipAssignment).LaptopOwnerOption = value ?? null; }

        /// <summary>
        /// Comma seperated usergroups to add users from, when the laptopOwnerOption is 'ALL_USERS_OF_USERGROUPS'
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string AutomaticLaptopOwnershipAssignmentUserGroups { get => ((Commvault.Powershell.Models.ILaptopOwnershipInternal)AutomaticLaptopOwnershipAssignment).UserGroups; set => ((Commvault.Powershell.Models.ILaptopOwnershipInternal)AutomaticLaptopOwnershipAssignment).UserGroups = value ?? null; }

        /// <summary>Internal Acessors for AutomaticLaptopOwnershipAssignment</summary>
        Commvault.Powershell.Models.ILaptopOwnership Commvault.Powershell.Models.IAccessControlInternal.AutomaticLaptopOwnershipAssignment { get => (this._automaticLaptopOwnershipAssignment = this._automaticLaptopOwnershipAssignment ?? new Commvault.Powershell.Models.LaptopOwnership()); set { {_automaticLaptopOwnershipAssignment = value;} } }

        /// <summary>Backing field for <see cref="OwnerPermissions" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _ownerPermissions;

        /// <summary>List of owner permissions</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] OwnerPermissions { get => this._ownerPermissions; set => this._ownerPermissions = value; }

        /// <summary>Creates an new <see cref="AccessControl" /> instance.</summary>
        public AccessControl()
        {

        }
    }
    /// Owner permissions and laptop ownership details
    public partial interface IAccessControl :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Whether the laptop ownership assignment is automatic or not</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether the laptop ownership assignment is automatic or not",
        SerializedName = @"assignLaptopOwnerAutomatically",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AutomaticLaptopOwnershipAssignmentAssignLaptopOwnerAutomatically { get; set; }
        /// <summary>Options to automatically assign laptop owners</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Options to automatically assign laptop owners",
        SerializedName = @"laptopOwnerOption",
        PossibleTypes = new [] { typeof(string) })]
        string AutomaticLaptopOwnershipAssignmentLaptopOwnerOption { get; set; }
        /// <summary>
        /// Comma seperated usergroups to add users from, when the laptopOwnerOption is 'ALL_USERS_OF_USERGROUPS'
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Comma seperated usergroups to add users from, when the laptopOwnerOption is 'ALL_USERS_OF_USERGROUPS'",
        SerializedName = @"userGroups",
        PossibleTypes = new [] { typeof(string) })]
        string AutomaticLaptopOwnershipAssignmentUserGroups { get; set; }
        /// <summary>List of owner permissions</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of owner permissions",
        SerializedName = @"ownerPermissions",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] OwnerPermissions { get; set; }

    }
    /// Owner permissions and laptop ownership details
    internal partial interface IAccessControlInternal

    {
        /// <summary>Details of automatic laptop ownership assignment</summary>
        Commvault.Powershell.Models.ILaptopOwnership AutomaticLaptopOwnershipAssignment { get; set; }
        /// <summary>Whether the laptop ownership assignment is automatic or not</summary>
        bool? AutomaticLaptopOwnershipAssignmentAssignLaptopOwnerAutomatically { get; set; }
        /// <summary>Options to automatically assign laptop owners</summary>
        string AutomaticLaptopOwnershipAssignmentLaptopOwnerOption { get; set; }
        /// <summary>
        /// Comma seperated usergroups to add users from, when the laptopOwnerOption is 'ALL_USERS_OF_USERGROUPS'
        /// </summary>
        string AutomaticLaptopOwnershipAssignmentUserGroups { get; set; }
        /// <summary>List of owner permissions</summary>
        Commvault.Powershell.Models.IIdName[] OwnerPermissions { get; set; }

    }
}