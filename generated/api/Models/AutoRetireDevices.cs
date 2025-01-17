// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class AutoRetireDevices :
        Commvault.Powershell.Models.IAutoRetireDevices,
        Commvault.Powershell.Models.IAutoRetireDevicesInternal
    {

        /// <summary>Backing field for <see cref="DeleteAfterDays" /> property.</summary>
        private int? _deleteAfterDays;

        /// <summary>
        /// The offline laptops are automatically deleted when the number of days are met. -1 means never.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? DeleteAfterDays { get => this._deleteAfterDays; set => this._deleteAfterDays = value; }

        /// <summary>Backing field for <see cref="RetireAfterDays" /> property.</summary>
        private int? _retireAfterDays;

        /// <summary>
        /// The offline laptops are retired when the number of days are met. -1 means never.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? RetireAfterDays { get => this._retireAfterDays; set => this._retireAfterDays = value; }

        /// <summary>Creates an new <see cref="AutoRetireDevices" /> instance.</summary>
        public AutoRetireDevices()
        {

        }
    }
    public partial interface IAutoRetireDevices :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The offline laptops are automatically deleted when the number of days are met. -1 means never.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The offline laptops are automatically deleted when the number of days are met. -1 means never.",
        SerializedName = @"deleteAfterDays",
        PossibleTypes = new [] { typeof(int) })]
        int? DeleteAfterDays { get; set; }
        /// <summary>
        /// The offline laptops are retired when the number of days are met. -1 means never.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The offline laptops are retired when the number of days are met. -1 means never.",
        SerializedName = @"retireAfterDays",
        PossibleTypes = new [] { typeof(int) })]
        int? RetireAfterDays { get; set; }

    }
    internal partial interface IAutoRetireDevicesInternal

    {
        /// <summary>
        /// The offline laptops are automatically deleted when the number of days are met. -1 means never.
        /// </summary>
        int? DeleteAfterDays { get; set; }
        /// <summary>
        /// The offline laptops are retired when the number of days are met. -1 means never.
        /// </summary>
        int? RetireAfterDays { get; set; }

    }
}