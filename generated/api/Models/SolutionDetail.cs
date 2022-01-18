// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Consist of workload solution details.</summary>
    public partial class SolutionDetail :
        Commvault.Powershell.Models.ISolutionDetail,
        Commvault.Powershell.Models.ISolutionDetailInternal
    {

        /// <summary>Backing field for <see cref="CommandCenterState" /> property.</summary>
        private string _commandCenterState;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CommandCenterState { get => this._commandCenterState; set => this._commandCenterState = value; }

        /// <summary>Backing field for <see cref="CommandCenterStateValue" /> property.</summary>
        private int? _commandCenterStateValue;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? CommandCenterStateValue { get => this._commandCenterStateValue; set => this._commandCenterStateValue = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private long? _id;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="SolutionDetail" /> instance.</summary>
        public SolutionDetail()
        {

        }
    }
    /// Consist of workload solution details.
    public partial interface ISolutionDetail :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"commandCenterState",
        PossibleTypes = new [] { typeof(string) })]
        string CommandCenterState { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"commandCenterStateValue",
        PossibleTypes = new [] { typeof(int) })]
        int? CommandCenterStateValue { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? Id { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Consist of workload solution details.
    internal partial interface ISolutionDetailInternal

    {
        string CommandCenterState { get; set; }

        int? CommandCenterStateValue { get; set; }

        long? Id { get; set; }

        string Name { get; set; }

    }
}