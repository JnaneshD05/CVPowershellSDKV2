// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class ServerDetails :
        Commvault.Powershell.Models.IServerDetails,
        Commvault.Powershell.Models.IServerDetailsInternal
    {

        /// <summary>Backing field for <see cref="Agent" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _agent;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] Agent { get => this._agent; set => this._agent = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private int? _id;

        /// <summary>Id of server, which is part of server group.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of server, which is part of server group.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="OS" /> property.</summary>
        private string _oS;

        /// <summary>Operating system of server.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string OS { get => this._oS; set => this._oS = value; }

        /// <summary>Backing field for <see cref="UpdateStatus" /> property.</summary>
        private string _updateStatus;

        /// <summary>update status of server.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UpdateStatus { get => this._updateStatus; set => this._updateStatus = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Service pack version of server.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ServerDetails" /> instance.</summary>
        public ServerDetails()
        {

        }
    }
    public partial interface IServerDetails :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"agent",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] Agent { get; set; }
        /// <summary>Id of server, which is part of server group.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of server, which is part of server group.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? Id { get; set; }
        /// <summary>Name of server, which is part of server group.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of server, which is part of server group.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Operating system of server.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operating system of server.",
        SerializedName = @"os",
        PossibleTypes = new [] { typeof(string) })]
        string OS { get; set; }
        /// <summary>update status of server.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"update status of server.",
        SerializedName = @"updateStatus",
        PossibleTypes = new [] { typeof(string) })]
        string UpdateStatus { get; set; }
        /// <summary>Service pack version of server.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Service pack version of server.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    internal partial interface IServerDetailsInternal

    {
        Commvault.Powershell.Models.IIdName[] Agent { get; set; }
        /// <summary>Id of server, which is part of server group.</summary>
        int? Id { get; set; }
        /// <summary>Name of server, which is part of server group.</summary>
        string Name { get; set; }
        /// <summary>Operating system of server.</summary>
        string OS { get; set; }
        /// <summary>update status of server.</summary>
        string UpdateStatus { get; set; }
        /// <summary>Service pack version of server.</summary>
        string Version { get; set; }

    }
}