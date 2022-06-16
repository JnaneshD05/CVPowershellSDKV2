// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>This will return list of supported workload solutions for a command center user</summary>
    public partial class SolutionsList :
        Commvault.Powershell.Models.ISolutionsList,
        Commvault.Powershell.Models.ISolutionsListInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private Commvault.Powershell.Models.ISolutionDetail[] _id;

        /// <summary>Detail of the workload solution that is supported for the user</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.ISolutionDetail[] Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="SolutionsList" /> instance.</summary>
        public SolutionsList()
        {

        }
    }
    /// This will return list of supported workload solutions for a command center user
    public partial interface ISolutionsList :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Detail of the workload solution that is supported for the user</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Detail of the workload solution that is supported for the user",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ISolutionDetail) })]
        Commvault.Powershell.Models.ISolutionDetail[] Id { get; set; }

    }
    /// This will return list of supported workload solutions for a command center user
    internal partial interface ISolutionsListInternal

    {
        /// <summary>Detail of the workload solution that is supported for the user</summary>
        Commvault.Powershell.Models.ISolutionDetail[] Id { get; set; }

    }
}