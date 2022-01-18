// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// A server meets SLA (Service Level Agreement) when all of its subclients have at least one successful backup during the
    /// number of days specified at the CommCell, Server Group or plan level.
    /// </summary>
    public partial class SlaUpdateOptions :
        Commvault.Powershell.Models.ISlaUpdateOptions,
        Commvault.Powershell.Models.ISlaUpdateOptionsInternal
    {

        /// <summary>Backing field for <see cref="EnableAfterDelay" /> property.</summary>
        private int? _enableAfterDelay;

        /// <summary>Time provided in Unix format. Give 0 to reset any existing delay.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? EnableAfterDelay { get => this._enableAfterDelay; set => this._enableAfterDelay = value; }

        /// <summary>Backing field for <see cref="ExcludeFromSla" /> property.</summary>
        private bool? _excludeFromSla;

        /// <summary>Flag to set to exclude plan from SLA</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? ExcludeFromSla { get => this._excludeFromSla; set => this._excludeFromSla = value; }

        /// <summary>Backing field for <see cref="ExclusionReason" /> property.</summary>
        private string _exclusionReason;

        /// <summary>Reason for exclusion from SLA</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ExclusionReason { get => this._exclusionReason; set => this._exclusionReason = value; }

        /// <summary>Backing field for <see cref="SlaPeriod" /> property.</summary>
        private int? _slaPeriod;

        /// <summary>SLA Period in Days</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? SlaPeriod { get => this._slaPeriod; set => this._slaPeriod = value; }

        /// <summary>Backing field for <see cref="UseSystemDefaultSla" /> property.</summary>
        private bool? _useSystemDefaultSla;

        /// <summary>Flag to set to use System Default Service Level Agreement</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? UseSystemDefaultSla { get => this._useSystemDefaultSla; set => this._useSystemDefaultSla = value; }

        /// <summary>Creates an new <see cref="SlaUpdateOptions" /> instance.</summary>
        public SlaUpdateOptions()
        {

        }
    }
    /// A server meets SLA (Service Level Agreement) when all of its subclients have at least one successful backup during the
    /// number of days specified at the CommCell, Server Group or plan level.
    public partial interface ISlaUpdateOptions :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Time provided in Unix format. Give 0 to reset any existing delay.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time provided in Unix format. Give 0 to reset any existing delay.",
        SerializedName = @"enableAfterDelay",
        PossibleTypes = new [] { typeof(int) })]
        int? EnableAfterDelay { get; set; }
        /// <summary>Flag to set to exclude plan from SLA</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to set to exclude plan from SLA",
        SerializedName = @"excludeFromSLA",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ExcludeFromSla { get; set; }
        /// <summary>Reason for exclusion from SLA</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Reason for exclusion from SLA",
        SerializedName = @"exclusionReason",
        PossibleTypes = new [] { typeof(string) })]
        string ExclusionReason { get; set; }
        /// <summary>SLA Period in Days</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SLA Period in Days",
        SerializedName = @"SLAPeriod",
        PossibleTypes = new [] { typeof(int) })]
        int? SlaPeriod { get; set; }
        /// <summary>Flag to set to use System Default Service Level Agreement</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to set to use System Default Service Level Agreement",
        SerializedName = @"useSystemDefaultSLA",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseSystemDefaultSla { get; set; }

    }
    /// A server meets SLA (Service Level Agreement) when all of its subclients have at least one successful backup during the
    /// number of days specified at the CommCell, Server Group or plan level.
    internal partial interface ISlaUpdateOptionsInternal

    {
        /// <summary>Time provided in Unix format. Give 0 to reset any existing delay.</summary>
        int? EnableAfterDelay { get; set; }
        /// <summary>Flag to set to exclude plan from SLA</summary>
        bool? ExcludeFromSla { get; set; }
        /// <summary>Reason for exclusion from SLA</summary>
        string ExclusionReason { get; set; }
        /// <summary>SLA Period in Days</summary>
        int? SlaPeriod { get; set; }
        /// <summary>Flag to set to use System Default Service Level Agreement</summary>
        bool? UseSystemDefaultSla { get; set; }

    }
}