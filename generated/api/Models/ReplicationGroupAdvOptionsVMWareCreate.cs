// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Advanced options for VMWare replication group</summary>
    public partial class ReplicationGroupAdvOptionsVMWareCreate :
        Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreate,
        Commvault.Powershell.Models.IReplicationGroupAdvOptionsVMWareCreateInternal
    {

        /// <summary>Backing field for <see cref="DiskProvisioning" /> property.</summary>
        private string _diskProvisioning;

        /// <summary>The disk provisioning type for the destination VM.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DiskProvisioning { get => this._diskProvisioning; set => this._diskProvisioning = value; }

        /// <summary>Backing field for <see cref="SnapshotsToRetain" /> property.</summary>
        private int? _snapshotsToRetain;

        /// <summary>
        /// Number of snapshots to retain on destination VM. This is only applicable if snap engine is provided
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? SnapshotsToRetain { get => this._snapshotsToRetain; set => this._snapshotsToRetain = value; }

        /// <summary>Backing field for <see cref="TransportMode" /> property.</summary>
        private string _transportMode;

        /// <summary>The transport mode based on environment.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string TransportMode { get => this._transportMode; set => this._transportMode = value; }

        /// <summary>Backing field for <see cref="UnconditionalOverwrite" /> property.</summary>
        private bool? _unconditionalOverwrite;

        /// <summary>
        /// This will replace the instance at the destination if the instance with the same name already exists.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? UnconditionalOverwrite { get => this._unconditionalOverwrite; set => this._unconditionalOverwrite = value; }

        /// <summary>Backing field for <see cref="ValidateDestinationVM" /> property.</summary>
        private bool? _validateDestinationVM;

        /// <summary>
        /// Validates that the destination VM is bootable by powering it on and then powering off
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? ValidateDestinationVM { get => this._validateDestinationVM; set => this._validateDestinationVM = value; }

        /// <summary>Creates an new <see cref="ReplicationGroupAdvOptionsVMWareCreate" /> instance.</summary>
        public ReplicationGroupAdvOptionsVMWareCreate()
        {

        }
    }
    /// Advanced options for VMWare replication group
    public partial interface IReplicationGroupAdvOptionsVMWareCreate :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>The disk provisioning type for the destination VM.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk provisioning type for the destination VM.",
        SerializedName = @"diskProvisioning",
        PossibleTypes = new [] { typeof(string) })]
        string DiskProvisioning { get; set; }
        /// <summary>
        /// Number of snapshots to retain on destination VM. This is only applicable if snap engine is provided
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of snapshots to retain on destination VM. This is only applicable if snap engine is provided",
        SerializedName = @"SnapshotsToRetain",
        PossibleTypes = new [] { typeof(int) })]
        int? SnapshotsToRetain { get; set; }
        /// <summary>The transport mode based on environment.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The transport mode based on environment.",
        SerializedName = @"transportMode",
        PossibleTypes = new [] { typeof(string) })]
        string TransportMode { get; set; }
        /// <summary>
        /// This will replace the instance at the destination if the instance with the same name already exists.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This will replace the instance at the destination if the instance with the same name already exists.",
        SerializedName = @"unconditionalOverwrite",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UnconditionalOverwrite { get; set; }
        /// <summary>
        /// Validates that the destination VM is bootable by powering it on and then powering off
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Validates that the destination VM is bootable by powering it on and then powering off",
        SerializedName = @"validateDestinationVM",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ValidateDestinationVM { get; set; }

    }
    /// Advanced options for VMWare replication group
    internal partial interface IReplicationGroupAdvOptionsVMWareCreateInternal

    {
        /// <summary>The disk provisioning type for the destination VM.</summary>
        string DiskProvisioning { get; set; }
        /// <summary>
        /// Number of snapshots to retain on destination VM. This is only applicable if snap engine is provided
        /// </summary>
        int? SnapshotsToRetain { get; set; }
        /// <summary>The transport mode based on environment.</summary>
        string TransportMode { get; set; }
        /// <summary>
        /// This will replace the instance at the destination if the instance with the same name already exists.
        /// </summary>
        bool? UnconditionalOverwrite { get; set; }
        /// <summary>
        /// Validates that the destination VM is bootable by powering it on and then powering off
        /// </summary>
        bool? ValidateDestinationVM { get; set; }

    }
}