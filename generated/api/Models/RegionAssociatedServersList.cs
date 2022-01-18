// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>List of servers associated to a region</summary>
    public partial class RegionAssociatedServersList :
        Commvault.Powershell.Models.IRegionAssociatedServersList,
        Commvault.Powershell.Models.IRegionAssociatedServersListInternal
    {

        /// <summary>Internal Acessors for Server</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IRegionAssociatedServersListInternal.Server { get => (this._server = this._server ?? new Commvault.Powershell.Models.IdName()); set { {_server = value;} } }

        /// <summary>Backing field for <see cref="Latitude" /> property.</summary>
        private double? _latitude;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public double? Latitude { get => this._latitude; set => this._latitude = value; }

        /// <summary>Backing field for <see cref="Longitude" /> property.</summary>
        private double? _longitude;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public double? Longitude { get => this._longitude; set => this._longitude = value; }

        /// <summary>Backing field for <see cref="Server" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _server;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Server { get => (this._server = this._server ?? new Commvault.Powershell.Models.IdName()); set => this._server = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ServerId { get => ((Commvault.Powershell.Models.IIdNameInternal)Server).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Server).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ServerName { get => ((Commvault.Powershell.Models.IIdNameInternal)Server).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Server).Name = value ?? null; }

        /// <summary>Creates an new <see cref="RegionAssociatedServersList" /> instance.</summary>
        public RegionAssociatedServersList()
        {

        }
    }
    /// List of servers associated to a region
    public partial interface IRegionAssociatedServersList :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"latitude",
        PossibleTypes = new [] { typeof(double) })]
        double? Latitude { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"longitude",
        PossibleTypes = new [] { typeof(double) })]
        double? Longitude { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? ServerId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ServerName { get; set; }

    }
    /// List of servers associated to a region
    internal partial interface IRegionAssociatedServersListInternal

    {
        double? Latitude { get; set; }

        double? Longitude { get; set; }

        Commvault.Powershell.Models.IIdName Server { get; set; }

        int? ServerId { get; set; }

        string ServerName { get; set; }

    }
}