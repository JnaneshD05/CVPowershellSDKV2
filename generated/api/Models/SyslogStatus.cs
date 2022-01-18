// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Get status of a syslog server.</summary>
    public partial class SyslogStatus :
        Commvault.Powershell.Models.ISyslogStatus,
        Commvault.Powershell.Models.ISyslogStatusInternal
    {

        /// <summary>Backing field for <see cref="CertificateAuthorityName" /> property.</summary>
        private string _certificateAuthorityName;

        /// <summary>File name of the uploaded certificate authority file</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CertificateAuthorityName { get => this._certificateAuthorityName; set => this._certificateAuthorityName = value; }

        /// <summary>Internal Acessors for ForwardToSyslog</summary>
        Commvault.Powershell.Models.ISyslogPolicies Commvault.Powershell.Models.ISyslogStatusInternal.ForwardToSyslog { get => (this._forwardToSyslog = this._forwardToSyslog ?? new Commvault.Powershell.Models.SyslogPolicies()); set { {_forwardToSyslog = value;} } }

        /// <summary>Backing field for <see cref="ForwardToSyslog" /> property.</summary>
        private Commvault.Powershell.Models.ISyslogPolicies _forwardToSyslog;

        /// <summary>Select the log types that you want to forward to the syslog server.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ISyslogPolicies ForwardToSyslog { get => (this._forwardToSyslog = this._forwardToSyslog ?? new Commvault.Powershell.Models.SyslogPolicies()); set => this._forwardToSyslog = value; }

        /// <summary>Forward the system log for alerts to the server.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ForwardToSyslogAlerts { get => ((Commvault.Powershell.Models.ISyslogPoliciesInternal)ForwardToSyslog).Alerts; set => ((Commvault.Powershell.Models.ISyslogPoliciesInternal)ForwardToSyslog).Alerts = value ?? default(bool); }

        /// <summary>Forward the system log for audit trails to the server.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ForwardToSyslogAudit { get => ((Commvault.Powershell.Models.ISyslogPoliciesInternal)ForwardToSyslog).Audit; set => ((Commvault.Powershell.Models.ISyslogPoliciesInternal)ForwardToSyslog).Audit = value ?? default(bool); }

        /// <summary>Forward the system log for events to the server.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ForwardToSyslogEvents { get => ((Commvault.Powershell.Models.ISyslogPoliciesInternal)ForwardToSyslog).Events; set => ((Commvault.Powershell.Models.ISyslogPoliciesInternal)ForwardToSyslog).Events = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Hostname" /> property.</summary>
        private string _hostname;

        /// <summary>The hostname or the IP address of the syslog server.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Hostname { get => this._hostname; set => this._hostname = value; }

        /// <summary>Backing field for <see cref="Port" /> property.</summary>
        private int? _port;

        /// <summary>The port on which the syslog server accepts the logs.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Port { get => this._port; set => this._port = value; }

        /// <summary>Backing field for <see cref="SecureMessaging" /> property.</summary>
        private bool? _secureMessaging;

        /// <summary>
        /// When false UDP port will be used, when true TLS encryption will be used to connect to Syslog Server. To upload Certificate
        /// Authority file it should be enabled.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? SecureMessaging { get => this._secureMessaging; set => this._secureMessaging = value; }

        /// <summary>Creates an new <see cref="SyslogStatus" /> instance.</summary>
        public SyslogStatus()
        {

        }
    }
    /// Get status of a syslog server.
    public partial interface ISyslogStatus :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>File name of the uploaded certificate authority file</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"File name of the uploaded certificate authority file",
        SerializedName = @"certificateAuthorityName",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateAuthorityName { get; set; }
        /// <summary>Forward the system log for alerts to the server.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Forward the system log for alerts to the server.",
        SerializedName = @"alerts",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ForwardToSyslogAlerts { get; set; }
        /// <summary>Forward the system log for audit trails to the server.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Forward the system log for audit trails to the server.",
        SerializedName = @"audit",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ForwardToSyslogAudit { get; set; }
        /// <summary>Forward the system log for events to the server.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Forward the system log for events to the server.",
        SerializedName = @"events",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ForwardToSyslogEvents { get; set; }
        /// <summary>The hostname or the IP address of the syslog server.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The hostname or the IP address of the syslog server.",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string Hostname { get; set; }
        /// <summary>The port on which the syslog server accepts the logs.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The port on which the syslog server accepts the logs.",
        SerializedName = @"port",
        PossibleTypes = new [] { typeof(int) })]
        int? Port { get; set; }
        /// <summary>
        /// When false UDP port will be used, when true TLS encryption will be used to connect to Syslog Server. To upload Certificate
        /// Authority file it should be enabled.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When false UDP port will be used, when true TLS encryption will be used to connect to Syslog Server. To upload Certificate Authority file it should be enabled.",
        SerializedName = @"secureMessaging",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SecureMessaging { get; set; }

    }
    /// Get status of a syslog server.
    internal partial interface ISyslogStatusInternal

    {
        /// <summary>File name of the uploaded certificate authority file</summary>
        string CertificateAuthorityName { get; set; }
        /// <summary>Select the log types that you want to forward to the syslog server.</summary>
        Commvault.Powershell.Models.ISyslogPolicies ForwardToSyslog { get; set; }
        /// <summary>Forward the system log for alerts to the server.</summary>
        bool? ForwardToSyslogAlerts { get; set; }
        /// <summary>Forward the system log for audit trails to the server.</summary>
        bool? ForwardToSyslogAudit { get; set; }
        /// <summary>Forward the system log for events to the server.</summary>
        bool? ForwardToSyslogEvents { get; set; }
        /// <summary>The hostname or the IP address of the syslog server.</summary>
        string Hostname { get; set; }
        /// <summary>The port on which the syslog server accepts the logs.</summary>
        int? Port { get; set; }
        /// <summary>
        /// When false UDP port will be used, when true TLS encryption will be used to connect to Syslog Server. To upload Certificate
        /// Authority file it should be enabled.
        /// </summary>
        bool? SecureMessaging { get; set; }

    }
}