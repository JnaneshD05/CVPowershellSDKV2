// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Select the log types that you want to forward to the syslog server.</summary>
    public partial class SyslogPolicies :
        Commvault.Powershell.Models.ISyslogPolicies,
        Commvault.Powershell.Models.ISyslogPoliciesInternal
    {

        /// <summary>Backing field for <see cref="Alerts" /> property.</summary>
        private bool? _alerts;

        /// <summary>Forward the system log for alerts to the server.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Alerts { get => this._alerts; set => this._alerts = value; }

        /// <summary>Backing field for <see cref="Audit" /> property.</summary>
        private bool? _audit;

        /// <summary>Forward the system log for audit trails to the server.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Audit { get => this._audit; set => this._audit = value; }

        /// <summary>Backing field for <see cref="Events" /> property.</summary>
        private bool? _events;

        /// <summary>Forward the system log for events to the server.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Events { get => this._events; set => this._events = value; }

        /// <summary>Creates an new <see cref="SyslogPolicies" /> instance.</summary>
        public SyslogPolicies()
        {

        }
    }
    /// Select the log types that you want to forward to the syslog server.
    public partial interface ISyslogPolicies :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Forward the system log for alerts to the server.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Forward the system log for alerts to the server.",
        SerializedName = @"alerts",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Alerts { get; set; }
        /// <summary>Forward the system log for audit trails to the server.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Forward the system log for audit trails to the server.",
        SerializedName = @"audit",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Audit { get; set; }
        /// <summary>Forward the system log for events to the server.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Forward the system log for events to the server.",
        SerializedName = @"events",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Events { get; set; }

    }
    /// Select the log types that you want to forward to the syslog server.
    internal partial interface ISyslogPoliciesInternal

    {
        /// <summary>Forward the system log for alerts to the server.</summary>
        bool? Alerts { get; set; }
        /// <summary>Forward the system log for audit trails to the server.</summary>
        bool? Audit { get; set; }
        /// <summary>Forward the system log for events to the server.</summary>
        bool? Events { get; set; }

    }
}