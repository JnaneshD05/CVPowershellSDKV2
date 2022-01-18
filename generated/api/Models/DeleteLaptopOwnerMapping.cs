// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>This model accepts the list of laptop owner mapping to be deleted</summary>
    public partial class DeleteLaptopOwnerMapping :
        Commvault.Powershell.Models.IDeleteLaptopOwnerMapping,
        Commvault.Powershell.Models.IDeleteLaptopOwnerMappingInternal
    {

        /// <summary>Backing field for <see cref="LaptopOwnerMapping" /> property.</summary>
        private int[] _laptopOwnerMapping;

        /// <summary>Accepts list of laptop owner mapping ids to be deleted</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int[] LaptopOwnerMapping { get => this._laptopOwnerMapping; set => this._laptopOwnerMapping = value; }

        /// <summary>Creates an new <see cref="DeleteLaptopOwnerMapping" /> instance.</summary>
        public DeleteLaptopOwnerMapping()
        {

        }
    }
    /// This model accepts the list of laptop owner mapping to be deleted
    public partial interface IDeleteLaptopOwnerMapping :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Accepts list of laptop owner mapping ids to be deleted</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Accepts list of laptop owner mapping ids to be deleted",
        SerializedName = @"laptopOwnerMapping",
        PossibleTypes = new [] { typeof(int) })]
        int[] LaptopOwnerMapping { get; set; }

    }
    /// This model accepts the list of laptop owner mapping to be deleted
    internal partial interface IDeleteLaptopOwnerMappingInternal

    {
        /// <summary>Accepts list of laptop owner mapping ids to be deleted</summary>
        int[] LaptopOwnerMapping { get; set; }

    }
}