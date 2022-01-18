// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Details of automatic laptop ownership assignment</summary>
    public partial class LaptopOwnership :
        Commvault.Powershell.Models.ILaptopOwnership,
        Commvault.Powershell.Models.ILaptopOwnershipInternal
    {

        /// <summary>Backing field for <see cref="AssignLaptopOwnerAutomatically" /> property.</summary>
        private bool? _assignLaptopOwnerAutomatically;

        /// <summary>Whether the laptop ownership assignment is automatic or not</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? AssignLaptopOwnerAutomatically { get => this._assignLaptopOwnerAutomatically; set => this._assignLaptopOwnerAutomatically = value; }

        /// <summary>Backing field for <see cref="LaptopOwnerOption" /> property.</summary>
        private string _laptopOwnerOption;

        /// <summary>Options to automatically assign laptop owners</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string LaptopOwnerOption { get => this._laptopOwnerOption; set => this._laptopOwnerOption = value; }

        /// <summary>Backing field for <see cref="UserGroups" /> property.</summary>
        private string _userGroups;

        /// <summary>
        /// Comma seperated usergroups to add users from, when the laptopOwnerOption is 'ALL_USERS_OF_USERGROUPS'
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UserGroups { get => this._userGroups; set => this._userGroups = value; }

        /// <summary>Creates an new <see cref="LaptopOwnership" /> instance.</summary>
        public LaptopOwnership()
        {

        }
    }
    /// Details of automatic laptop ownership assignment
    public partial interface ILaptopOwnership :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Whether the laptop ownership assignment is automatic or not</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether the laptop ownership assignment is automatic or not",
        SerializedName = @"assignLaptopOwnerAutomatically",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AssignLaptopOwnerAutomatically { get; set; }
        /// <summary>Options to automatically assign laptop owners</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Options to automatically assign laptop owners",
        SerializedName = @"laptopOwnerOption",
        PossibleTypes = new [] { typeof(string) })]
        string LaptopOwnerOption { get; set; }
        /// <summary>
        /// Comma seperated usergroups to add users from, when the laptopOwnerOption is 'ALL_USERS_OF_USERGROUPS'
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Comma seperated usergroups to add users from, when the laptopOwnerOption is 'ALL_USERS_OF_USERGROUPS'",
        SerializedName = @"userGroups",
        PossibleTypes = new [] { typeof(string) })]
        string UserGroups { get; set; }

    }
    /// Details of automatic laptop ownership assignment
    internal partial interface ILaptopOwnershipInternal

    {
        /// <summary>Whether the laptop ownership assignment is automatic or not</summary>
        bool? AssignLaptopOwnerAutomatically { get; set; }
        /// <summary>Options to automatically assign laptop owners</summary>
        string LaptopOwnerOption { get; set; }
        /// <summary>
        /// Comma seperated usergroups to add users from, when the laptopOwnerOption is 'ALL_USERS_OF_USERGROUPS'
        /// </summary>
        string UserGroups { get; set; }

    }
}