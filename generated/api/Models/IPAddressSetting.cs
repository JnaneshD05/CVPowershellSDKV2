// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>IpAddressSetting</summary>
    public partial class IPAddressSetting :
        Commvault.Powershell.Models.IIPAddressSetting,
        Commvault.Powershell.Models.IIPAddressSettingInternal
    {

        /// <summary>Backing field for <see cref="DefaultGateway" /> property.</summary>
        private string _defaultGateway;

        /// <summary>Default gateway</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DefaultGateway { get => this._defaultGateway; set => this._defaultGateway = value; }

        /// <summary>Backing field for <see cref="DefaultGatewayNoDhcp" /> property.</summary>
        private string _defaultGatewayNoDhcp;

        /// <summary>Defaault gateway when dhcp is not selected</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DefaultGatewayNoDhcp { get => this._defaultGatewayNoDhcp; set => this._defaultGatewayNoDhcp = value; }

        /// <summary>Backing field for <see cref="DestinationIP" /> property.</summary>
        private string _destinationIP;

        /// <summary>Destination IP</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DestinationIP { get => this._destinationIP; set => this._destinationIP = value; }

        /// <summary>Backing field for <see cref="HostName" /> property.</summary>
        private string _hostName;

        /// <summary>Hostname</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string HostName { get => this._hostName; set => this._hostName = value; }

        /// <summary>Backing field for <see cref="SourceIP" /> property.</summary>
        private string _sourceIP;

        /// <summary>Source IP</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SourceIP { get => this._sourceIP; set => this._sourceIP = value; }

        /// <summary>Backing field for <see cref="SubnetMask" /> property.</summary>
        private string _subnetMask;

        /// <summary>Subnet mask</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SubnetMask { get => this._subnetMask; set => this._subnetMask = value; }

        /// <summary>Backing field for <see cref="SubnetMaskNoDhcp" /> property.</summary>
        private string _subnetMaskNoDhcp;

        /// <summary>Subnet mask when dhcp is not selected</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SubnetMaskNoDhcp { get => this._subnetMaskNoDhcp; set => this._subnetMaskNoDhcp = value; }

        /// <summary>Backing field for <see cref="UseDhcp" /> property.</summary>
        private bool? _useDhcp;

        /// <summary>Use DHCP</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? UseDhcp { get => this._useDhcp; set => this._useDhcp = value; }

        /// <summary>Creates an new <see cref="IPAddressSetting" /> instance.</summary>
        public IPAddressSetting()
        {

        }
    }
    /// IpAddressSetting
    public partial interface IIPAddressSetting :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Default gateway</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default gateway",
        SerializedName = @"defaultGateway",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultGateway { get; set; }
        /// <summary>Defaault gateway when dhcp is not selected</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Defaault gateway when dhcp is not selected",
        SerializedName = @"defaultGatewayNoDhcp",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultGatewayNoDhcp { get; set; }
        /// <summary>Destination IP</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Destination IP",
        SerializedName = @"destinationIp",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationIP { get; set; }
        /// <summary>Hostname</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Hostname",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get; set; }
        /// <summary>Source IP</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Source IP",
        SerializedName = @"sourceIp",
        PossibleTypes = new [] { typeof(string) })]
        string SourceIP { get; set; }
        /// <summary>Subnet mask</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subnet mask",
        SerializedName = @"subnetMask",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetMask { get; set; }
        /// <summary>Subnet mask when dhcp is not selected</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subnet mask when dhcp is not selected",
        SerializedName = @"SubnetMaskNoDhcp",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetMaskNoDhcp { get; set; }
        /// <summary>Use DHCP</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Use DHCP",
        SerializedName = @"useDhcp",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseDhcp { get; set; }

    }
    /// IpAddressSetting
    internal partial interface IIPAddressSettingInternal

    {
        /// <summary>Default gateway</summary>
        string DefaultGateway { get; set; }
        /// <summary>Defaault gateway when dhcp is not selected</summary>
        string DefaultGatewayNoDhcp { get; set; }
        /// <summary>Destination IP</summary>
        string DestinationIP { get; set; }
        /// <summary>Hostname</summary>
        string HostName { get; set; }
        /// <summary>Source IP</summary>
        string SourceIP { get; set; }
        /// <summary>Subnet mask</summary>
        string SubnetMask { get; set; }
        /// <summary>Subnet mask when dhcp is not selected</summary>
        string SubnetMaskNoDhcp { get; set; }
        /// <summary>Use DHCP</summary>
        bool? UseDhcp { get; set; }

    }
}