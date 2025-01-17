// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class LaptopPlanUpdateGeneralInfo :
        Commvault.Powershell.Models.ILaptopPlanUpdateGeneralInfo,
        Commvault.Powershell.Models.ILaptopPlanUpdateGeneralInfoInternal
    {

        /// <summary>Backing field for <see cref="OptimizedForCloudBackups" /> property.</summary>
        private bool? _optimizedForCloudBackups;

        /// <summary>
        /// This feature allows laptops to write backup directly to the cloud storage. It helps to optimize scale by reducing server
        /// dependency and extra data hops. Once the feature is enabled, the existing and the newly-added laptops use optimized backups.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? OptimizedForCloudBackups { get => this._optimizedForCloudBackups; set => this._optimizedForCloudBackups = value; }

        /// <summary>Creates an new <see cref="LaptopPlanUpdateGeneralInfo" /> instance.</summary>
        public LaptopPlanUpdateGeneralInfo()
        {

        }
    }
    public partial interface ILaptopPlanUpdateGeneralInfo :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// This feature allows laptops to write backup directly to the cloud storage. It helps to optimize scale by reducing server
        /// dependency and extra data hops. Once the feature is enabled, the existing and the newly-added laptops use optimized backups.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This feature allows laptops to write backup directly to the cloud storage. It helps to optimize scale by reducing server dependency and extra data hops. Once the feature is enabled, the existing and the newly-added laptops use optimized backups.",
        SerializedName = @"optimizedForCloudBackups",
        PossibleTypes = new [] { typeof(bool) })]
        bool? OptimizedForCloudBackups { get; set; }

    }
    internal partial interface ILaptopPlanUpdateGeneralInfoInternal

    {
        /// <summary>
        /// This feature allows laptops to write backup directly to the cloud storage. It helps to optimize scale by reducing server
        /// dependency and extra data hops. Once the feature is enabled, the existing and the newly-added laptops use optimized backups.
        /// </summary>
        bool? OptimizedForCloudBackups { get; set; }

    }
}