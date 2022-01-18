// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>accessNodeInfo</summary>
    public partial class AccessNodeInfo :
        Commvault.Powershell.Models.IAccessNodeInfo,
        Commvault.Powershell.Models.IAccessNodeInfoInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Guid" /> property.</summary>
        private string _guid;

        /// <summary>client GUID of the Access Node</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Guid { get => this._guid; set => this._guid = value; }

        /// <summary>Backing field for <see cref="HostName" /> property.</summary>
        private string _hostName;

        /// <summary>client Host Name of the Access Node</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string HostName { get => this._hostName; set => this._hostName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="AccessNodeInfo" /> instance.</summary>
        public AccessNodeInfo()
        {

        }
    }
    /// accessNodeInfo
    public partial interface IAccessNodeInfo :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>client GUID of the Access Node</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"client GUID of the Access Node",
        SerializedName = @"GUID",
        PossibleTypes = new [] { typeof(string) })]
        string Guid { get; set; }
        /// <summary>client Host Name of the Access Node</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"client Host Name of the Access Node",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get; set; }

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

    }
    /// accessNodeInfo
    internal partial interface IAccessNodeInfoInternal

    {
        string DisplayName { get; set; }
        /// <summary>client GUID of the Access Node</summary>
        string Guid { get; set; }
        /// <summary>client Host Name of the Access Node</summary>
        string HostName { get; set; }

        int? Id { get; set; }

        string Name { get; set; }

    }
}