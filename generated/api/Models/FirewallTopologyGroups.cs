// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class FirewallTopologyGroups :
        Commvault.Powershell.Models.IFirewallTopologyGroups,
        Commvault.Powershell.Models.IFirewallTopologyGroupsInternal
    {

        /// <summary>
        /// The interval in seconds for sending keep-alive packets, to maintain the session if backup traffic has an extended pause.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? AdvancedOptionKeepAliveInterval { get => ((Commvault.Powershell.Models.IFirewallGroupAdvancedOptionsInternal)AdvancedOptions).KeepAliveInterval; set => ((Commvault.Powershell.Models.IFirewallGroupAdvancedOptionsInternal)AdvancedOptions).KeepAliveInterval = value ?? default(int); }

        /// <summary>The port defined for communications</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? AdvancedOptionTunnelPort { get => ((Commvault.Powershell.Models.IFirewallGroupAdvancedOptionsInternal)AdvancedOptions).TunnelPort; set => ((Commvault.Powershell.Models.IFirewallGroupAdvancedOptionsInternal)AdvancedOptions).TunnelPort = value ?? default(int); }

        /// <summary>Backing field for <see cref="AdvancedOptions" /> property.</summary>
        private Commvault.Powershell.Models.IFirewallGroupAdvancedOptions _advancedOptions;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IFirewallGroupAdvancedOptions AdvancedOptions { get => (this._advancedOptions = this._advancedOptions ?? new Commvault.Powershell.Models.FirewallGroupAdvancedOptions()); set => this._advancedOptions = value; }

        /// <summary>Backing field for <see cref="ClientGroupId" /> property.</summary>
        private int? _clientGroupId;

        /// <summary>The id of the client group</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? ClientGroupId { get => this._clientGroupId; set => this._clientGroupId = value; }

        /// <summary>Internal Acessors for AdvancedOptions</summary>
        Commvault.Powershell.Models.IFirewallGroupAdvancedOptions Commvault.Powershell.Models.IFirewallTopologyGroupsInternal.AdvancedOptions { get => (this._advancedOptions = this._advancedOptions ?? new Commvault.Powershell.Models.FirewallGroupAdvancedOptions()); set { {_advancedOptions = value;} } }

        /// <summary>Backing field for <see cref="GroupType" /> property.</summary>
        private string _groupType;

        /// <summary>FirewallFwGroupType</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string GroupType { get => this._groupType; set => this._groupType = value; }

        /// <summary>Backing field for <see cref="Mnemonic" /> property.</summary>
        private string _mnemonic;

        /// <summary>Custom names(mnemonics) given to pre-defined smart client groups</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Mnemonic { get => this._mnemonic; set => this._mnemonic = value; }

        /// <summary>Creates an new <see cref="FirewallTopologyGroups" /> instance.</summary>
        public FirewallTopologyGroups()
        {

        }
    }
    public partial interface IFirewallTopologyGroups :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The interval in seconds for sending keep-alive packets, to maintain the session if backup traffic has an extended pause.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The interval in seconds for sending keep-alive packets, to maintain the session if backup traffic has an extended pause.",
        SerializedName = @"keepAliveInterval",
        PossibleTypes = new [] { typeof(int) })]
        int? AdvancedOptionKeepAliveInterval { get; set; }
        /// <summary>The port defined for communications</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The port defined for communications",
        SerializedName = @"tunnelPort",
        PossibleTypes = new [] { typeof(int) })]
        int? AdvancedOptionTunnelPort { get; set; }
        /// <summary>The id of the client group</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The id of the client group",
        SerializedName = @"clientGroupId",
        PossibleTypes = new [] { typeof(int) })]
        int? ClientGroupId { get; set; }
        /// <summary>FirewallFwGroupType</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"FirewallFwGroupType",
        SerializedName = @"groupType",
        PossibleTypes = new [] { typeof(string) })]
        string GroupType { get; set; }
        /// <summary>Custom names(mnemonics) given to pre-defined smart client groups</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Custom names(mnemonics) given to pre-defined smart client groups",
        SerializedName = @"mnemonic",
        PossibleTypes = new [] { typeof(string) })]
        string Mnemonic { get; set; }

    }
    internal partial interface IFirewallTopologyGroupsInternal

    {
        /// <summary>
        /// The interval in seconds for sending keep-alive packets, to maintain the session if backup traffic has an extended pause.
        /// </summary>
        int? AdvancedOptionKeepAliveInterval { get; set; }
        /// <summary>The port defined for communications</summary>
        int? AdvancedOptionTunnelPort { get; set; }

        Commvault.Powershell.Models.IFirewallGroupAdvancedOptions AdvancedOptions { get; set; }
        /// <summary>The id of the client group</summary>
        int? ClientGroupId { get; set; }
        /// <summary>FirewallFwGroupType</summary>
        string GroupType { get; set; }
        /// <summary>Custom names(mnemonics) given to pre-defined smart client groups</summary>
        string Mnemonic { get; set; }

    }
}