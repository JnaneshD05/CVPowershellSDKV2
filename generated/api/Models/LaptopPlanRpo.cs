// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class LaptopPlanRpo :
        Commvault.Powershell.Models.ILaptopPlanRpo,
        Commvault.Powershell.Models.ILaptopPlanRpoInternal
    {

        /// <summary>Backing field for <see cref="BackupFrequency" /> property.</summary>
        private int? _backupFrequency;

        /// <summary>
        /// Specify incremental backup frequency in minutes. Backup operation will start as per the time zone of the associated server.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? BackupFrequency { get => this._backupFrequency; set => this._backupFrequency = value; }

        /// <summary>Internal Acessors for Sla</summary>
        Commvault.Powershell.Models.ISlaOptions Commvault.Powershell.Models.ILaptopPlanRpoInternal.Sla { get => (this._sla = this._sla ?? new Commvault.Powershell.Models.SlaOptions()); set { {_sla = value;} } }

        /// <summary>Backing field for <see cref="Sla" /> property.</summary>
        private Commvault.Powershell.Models.ISlaOptions _sla;

        /// <summary>
        /// A server meets SLA (Service Level Agreement) when all of its subclients have at least one successful backup during the
        /// number of days specified at the CommCell, Server Group or plan level.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ISlaOptions Sla { get => (this._sla = this._sla ?? new Commvault.Powershell.Models.SlaOptions()); set => this._sla = value; }

        /// <summary>Time provided in Unix format. Give 0 to reset any existing delay.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SlaEnableAfterDelay { get => ((Commvault.Powershell.Models.ISlaOptionsInternal)Sla).EnableAfterDelay; set => ((Commvault.Powershell.Models.ISlaOptionsInternal)Sla).EnableAfterDelay = value ?? default(int); }

        /// <summary>Flag to set to exclude plan from SLA</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? SlaExcludeFromSla { get => ((Commvault.Powershell.Models.ISlaOptionsInternal)Sla).ExcludeFromSla; set => ((Commvault.Powershell.Models.ISlaOptionsInternal)Sla).ExcludeFromSla = value ?? default(bool); }

        /// <summary>Reason for exclusion from SLA</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SlaExclusionReason { get => ((Commvault.Powershell.Models.ISlaOptionsInternal)Sla).ExclusionReason; set => ((Commvault.Powershell.Models.ISlaOptionsInternal)Sla).ExclusionReason = value ?? null; }

        /// <summary>Tells us from where SLA Period was inherited</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SlaInheritedFrom { get => ((Commvault.Powershell.Models.ISlaOptionsInternal)Sla).InheritedFrom; set => ((Commvault.Powershell.Models.ISlaOptionsInternal)Sla).InheritedFrom = value ?? null; }

        /// <summary>Inherited SLA Period in Days</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SlaInheritedSlaPeriod { get => ((Commvault.Powershell.Models.ISlaOptionsInternal)Sla).InheritedSlaPeriod; set => ((Commvault.Powershell.Models.ISlaOptionsInternal)Sla).InheritedSlaPeriod = value ?? default(int); }

        /// <summary>SLA Period in Days</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SlaPeriod { get => ((Commvault.Powershell.Models.ISlaOptionsInternal)Sla).SlaPeriod; set => ((Commvault.Powershell.Models.ISlaOptionsInternal)Sla).SlaPeriod = value ?? default(int); }

        /// <summary>Flag to set to use System Default Service Level Agreement</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? SlaUseSystemDefaultSla { get => ((Commvault.Powershell.Models.ISlaOptionsInternal)Sla).UseSystemDefaultSla; set => ((Commvault.Powershell.Models.ISlaOptionsInternal)Sla).UseSystemDefaultSla = value ?? default(bool); }

        /// <summary>Creates an new <see cref="LaptopPlanRpo" /> instance.</summary>
        public LaptopPlanRpo()
        {

        }
    }
    public partial interface ILaptopPlanRpo :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specify incremental backup frequency in minutes. Backup operation will start as per the time zone of the associated server.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specify incremental backup frequency in minutes. Backup operation will start as per the time zone of the associated server.",
        SerializedName = @"backupFrequency",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupFrequency { get; set; }
        /// <summary>Time provided in Unix format. Give 0 to reset any existing delay.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time provided in Unix format. Give 0 to reset any existing delay.",
        SerializedName = @"enableAfterDelay",
        PossibleTypes = new [] { typeof(int) })]
        int? SlaEnableAfterDelay { get; set; }
        /// <summary>Flag to set to exclude plan from SLA</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to set to exclude plan from SLA",
        SerializedName = @"excludeFromSLA",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SlaExcludeFromSla { get; set; }
        /// <summary>Reason for exclusion from SLA</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Reason for exclusion from SLA",
        SerializedName = @"exclusionReason",
        PossibleTypes = new [] { typeof(string) })]
        string SlaExclusionReason { get; set; }
        /// <summary>Tells us from where SLA Period was inherited</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tells us from where SLA Period was inherited",
        SerializedName = @"inheritedFrom",
        PossibleTypes = new [] { typeof(string) })]
        string SlaInheritedFrom { get; set; }
        /// <summary>Inherited SLA Period in Days</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Inherited SLA Period in Days",
        SerializedName = @"inheritedSLAPeriod",
        PossibleTypes = new [] { typeof(int) })]
        int? SlaInheritedSlaPeriod { get; set; }
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
        bool? SlaUseSystemDefaultSla { get; set; }

    }
    internal partial interface ILaptopPlanRpoInternal

    {
        /// <summary>
        /// Specify incremental backup frequency in minutes. Backup operation will start as per the time zone of the associated server.
        /// </summary>
        int? BackupFrequency { get; set; }
        /// <summary>
        /// A server meets SLA (Service Level Agreement) when all of its subclients have at least one successful backup during the
        /// number of days specified at the CommCell, Server Group or plan level.
        /// </summary>
        Commvault.Powershell.Models.ISlaOptions Sla { get; set; }
        /// <summary>Time provided in Unix format. Give 0 to reset any existing delay.</summary>
        int? SlaEnableAfterDelay { get; set; }
        /// <summary>Flag to set to exclude plan from SLA</summary>
        bool? SlaExcludeFromSla { get; set; }
        /// <summary>Reason for exclusion from SLA</summary>
        string SlaExclusionReason { get; set; }
        /// <summary>Tells us from where SLA Period was inherited</summary>
        string SlaInheritedFrom { get; set; }
        /// <summary>Inherited SLA Period in Days</summary>
        int? SlaInheritedSlaPeriod { get; set; }
        /// <summary>SLA Period in Days</summary>
        int? SlaPeriod { get; set; }
        /// <summary>Flag to set to use System Default Service Level Agreement</summary>
        bool? SlaUseSystemDefaultSla { get; set; }

    }
}