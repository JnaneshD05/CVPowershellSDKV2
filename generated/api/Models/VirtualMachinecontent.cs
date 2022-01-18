// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>VirtualMachinecontent</summary>
    public partial class VirtualMachinecontent :
        Commvault.Powershell.Models.IVirtualMachinecontent,
        Commvault.Powershell.Models.IVirtualMachinecontentInternal
    {

        /// <summary>Backing field for <see cref="Guid" /> property.</summary>
        private string _guid;

        /// <summary>GUID of the VM to be added as content</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Guid { get => this._guid; set => this._guid = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>name of the VM to be added as content</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="VirtualMachinecontent" /> instance.</summary>
        public VirtualMachinecontent()
        {

        }
    }
    /// VirtualMachinecontent
    public partial interface IVirtualMachinecontent :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>GUID of the VM to be added as content</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"GUID of the VM to be added as content",
        SerializedName = @"GUID",
        PossibleTypes = new [] { typeof(string) })]
        string Guid { get; set; }
        /// <summary>name of the VM to be added as content</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"name of the VM to be added as content",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// VirtualMachinecontent
    internal partial interface IVirtualMachinecontentInternal

    {
        /// <summary>GUID of the VM to be added as content</summary>
        string Guid { get; set; }
        /// <summary>name of the VM to be added as content</summary>
        string Name { get; set; }

        string Type { get; set; }

    }
}