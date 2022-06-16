// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Advanced options for HyperV replication group</summary>
    public partial class ReplicationGroupAdvOptionsHyperV :
        Commvault.Powershell.Models.IReplicationGroupAdvOptionsHyperV,
        Commvault.Powershell.Models.IReplicationGroupAdvOptionsHyperVInternal
    {

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

        /// <summary>Creates an new <see cref="ReplicationGroupAdvOptionsHyperV" /> instance.</summary>
        public ReplicationGroupAdvOptionsHyperV()
        {

        }
    }
    /// Advanced options for HyperV replication group
    public partial interface IReplicationGroupAdvOptionsHyperV :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
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
    /// Advanced options for HyperV replication group
    internal partial interface IReplicationGroupAdvOptionsHyperVInternal

    {
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