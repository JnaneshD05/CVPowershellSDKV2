// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Inventory response of hypervisor for resource pool entity</summary>
    public partial class ResourcepoolentityResponse :
        Commvault.Powershell.Models.IResourcepoolentityResponse,
        Commvault.Powershell.Models.IResourcepoolentityResponseInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>name of the resource pool.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ResourcePoolPath" /> property.</summary>
        private string _resourcePoolPath;

        /// <summary>path of the resource pool.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ResourcePoolPath { get => this._resourcePoolPath; set => this._resourcePoolPath = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>type of the resource pool.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ResourcepoolentityResponse" /> instance.</summary>
        public ResourcepoolentityResponse()
        {

        }
    }
    /// Inventory response of hypervisor for resource pool entity
    public partial interface IResourcepoolentityResponse :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>name of the resource pool.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"name  of the resource pool.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>path of the resource pool.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"path  of the resource pool.",
        SerializedName = @"resourcePoolPath",
        PossibleTypes = new [] { typeof(string) })]
        string ResourcePoolPath { get; set; }
        /// <summary>type of the resource pool.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"type  of the resource pool.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Inventory response of hypervisor for resource pool entity
    internal partial interface IResourcepoolentityResponseInternal

    {
        /// <summary>name of the resource pool.</summary>
        string Name { get; set; }
        /// <summary>path of the resource pool.</summary>
        string ResourcePoolPath { get; set; }
        /// <summary>type of the resource pool.</summary>
        string Type { get; set; }

    }
}