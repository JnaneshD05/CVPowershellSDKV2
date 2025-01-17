// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class PlanIdNameType :
        Commvault.Powershell.Models.IPlanIdNameType,
        Commvault.Powershell.Models.IPlanIdNameTypeInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="SubType" /> property.</summary>
        private string _subType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SubType { get => this._subType; set => this._subType = value; }

        /// <summary>Creates an new <see cref="PlanIdNameType" /> instance.</summary>
        public PlanIdNameType()
        {

        }
    }
    public partial interface IPlanIdNameType :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"subType",
        PossibleTypes = new [] { typeof(string) })]
        string SubType { get; set; }

    }
    internal partial interface IPlanIdNameTypeInternal

    {
        int? Id { get; set; }

        string Name { get; set; }

        string SubType { get; set; }

    }
}