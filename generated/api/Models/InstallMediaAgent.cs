// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class InstallMediaAgent :
        Commvault.Powershell.Models.IInstallMediaAgent,
        Commvault.Powershell.Models.IInstallMediaAgentInternal
    {

        /// <summary>Backing field for <see cref="HostNames" /> property.</summary>
        private string[] _hostNames;

        /// <summary>Host names where MediaAgent package is required to be installed</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string[] HostNames { get => this._hostNames; set => this._hostNames = value; }

        /// <summary>Backing field for <see cref="InstallLocation" /> property.</summary>
        private string _installLocation;

        /// <summary>Holds install path according to the chosen OSType</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string InstallLocation { get => this._installLocation; set => this._installLocation = value; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; set => this._oSType = value; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>
        /// password should be in base64 encoded string. password is optional only if SSHKeyFilePassphrase is specified
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="RebootIfRequired" /> property.</summary>
        private bool? _rebootIfRequired;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? RebootIfRequired { get => this._rebootIfRequired; set => this._rebootIfRequired = value; }

        /// <summary>Backing field for <see cref="SshKeyFilePassphrase" /> property.</summary>
        private string _sshKeyFilePassphrase;

        /// <summary>Applicable only for Unix OSType and should be in base64 encoded string</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SshKeyFilePassphrase { get => this._sshKeyFilePassphrase; set => this._sshKeyFilePassphrase = value; }

        /// <summary>Backing field for <see cref="SshKeyPath" /> property.</summary>
        private string _sshKeyPath;

        /// <summary>
        /// Applicable only for Unix OSType. Path provided should be valid on the CommServ Client
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SshKeyPath { get => this._sshKeyPath; set => this._sshKeyPath = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        /// <summary>Username to access hostnames</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="InstallMediaAgent" /> instance.</summary>
        public InstallMediaAgent()
        {

        }
    }
    public partial interface IInstallMediaAgent :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Host names where MediaAgent package is required to be installed</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Host names where MediaAgent package is required to be installed",
        SerializedName = @"hostNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] HostNames { get; set; }
        /// <summary>Holds install path according to the chosen OSType</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Holds install path according to the chosen OSType",
        SerializedName = @"installLocation",
        PossibleTypes = new [] { typeof(string) })]
        string InstallLocation { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"OSType",
        PossibleTypes = new [] { typeof(string) })]
        string OSType { get; set; }
        /// <summary>
        /// password should be in base64 encoded string. password is optional only if SSHKeyFilePassphrase is specified
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"password should be in base64 encoded string. password is optional only if SSHKeyFilePassphrase is specified",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"rebootIfRequired",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RebootIfRequired { get; set; }
        /// <summary>Applicable only for Unix OSType and should be in base64 encoded string</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Applicable only for Unix OSType and should be in base64 encoded string",
        SerializedName = @"SSHKeyFilePassphrase",
        PossibleTypes = new [] { typeof(string) })]
        string SshKeyFilePassphrase { get; set; }
        /// <summary>
        /// Applicable only for Unix OSType. Path provided should be valid on the CommServ Client
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Applicable only for Unix OSType. Path provided should be valid on the CommServ Client",
        SerializedName = @"SSHKeyPath",
        PossibleTypes = new [] { typeof(string) })]
        string SshKeyPath { get; set; }
        /// <summary>Username to access hostnames</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Username to access hostnames",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    internal partial interface IInstallMediaAgentInternal

    {
        /// <summary>Host names where MediaAgent package is required to be installed</summary>
        string[] HostNames { get; set; }
        /// <summary>Holds install path according to the chosen OSType</summary>
        string InstallLocation { get; set; }

        string OSType { get; set; }
        /// <summary>
        /// password should be in base64 encoded string. password is optional only if SSHKeyFilePassphrase is specified
        /// </summary>
        string Password { get; set; }

        bool? RebootIfRequired { get; set; }
        /// <summary>Applicable only for Unix OSType and should be in base64 encoded string</summary>
        string SshKeyFilePassphrase { get; set; }
        /// <summary>
        /// Applicable only for Unix OSType. Path provided should be valid on the CommServ Client
        /// </summary>
        string SshKeyPath { get; set; }
        /// <summary>Username to access hostnames</summary>
        string Username { get; set; }

    }
}