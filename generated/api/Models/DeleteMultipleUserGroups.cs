// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class DeleteMultipleUserGroups :
        Commvault.Powershell.Models.IDeleteMultipleUserGroups,
        Commvault.Powershell.Models.IDeleteMultipleUserGroupsInternal
    {

        /// <summary>Backing field for <see cref="UserGroups" /> property.</summary>
        private Commvault.Powershell.Models.IDeleteUserGroups[] _userGroups;

        /// <summary>
        /// List of userGroups that have to be deleted. Either name or id can be provided. If name and id are both provided, id will
        /// be taken into consideration.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IDeleteUserGroups[] UserGroups { get => this._userGroups; set => this._userGroups = value; }

        /// <summary>Creates an new <see cref="DeleteMultipleUserGroups" /> instance.</summary>
        public DeleteMultipleUserGroups()
        {

        }
    }
    public partial interface IDeleteMultipleUserGroups :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// List of userGroups that have to be deleted. Either name or id can be provided. If name and id are both provided, id will
        /// be taken into consideration.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of userGroups that have to be deleted. Either name or id can be provided. If name and id are both provided, id will be taken into consideration.",
        SerializedName = @"userGroups",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IDeleteUserGroups) })]
        Commvault.Powershell.Models.IDeleteUserGroups[] UserGroups { get; set; }

    }
    internal partial interface IDeleteMultipleUserGroupsInternal

    {
        /// <summary>
        /// List of userGroups that have to be deleted. Either name or id can be provided. If name and id are both provided, id will
        /// be taken into consideration.
        /// </summary>
        Commvault.Powershell.Models.IDeleteUserGroups[] UserGroups { get; set; }

    }
}