// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Recovery Point Objective (RPO) is the maximum amount of time that data can be lost during a service disruption. Your RPO
    /// determines the frequency of your backup jobs.
    /// </summary>
    public partial class ArchivePlanRpoDetails :
        Commvault.Powershell.Models.IArchivePlanRpoDetails,
        Commvault.Powershell.Models.IArchivePlanRpoDetailsInternal
    {

        /// <summary>Backing field for <see cref="BackupFrequency" /> property.</summary>
        private Commvault.Powershell.Models.IBackupFrequencyPattern _backupFrequency;

        /// <summary>Used to describe the frequency of backup</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IBackupFrequencyPattern BackupFrequency { get => (this._backupFrequency = this._backupFrequency ?? new Commvault.Powershell.Models.BackupFrequencyPattern()); set => this._backupFrequency = value; }

        /// <summary>Day on which to run the schedule, applicable for monthly, yearly</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? BackupFrequencyDayOfMonth { get => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).DayOfMonth; set => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).DayOfMonth = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string BackupFrequencyDayOfWeek { get => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).DayOfWeek; set => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).DayOfWeek = value ?? null; }

        /// <summary>
        /// Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes,
        /// for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? BackupFrequencyFrequency { get => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).Frequency; set => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).Frequency = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string BackupFrequencyMonthOfYear { get => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).MonthOfYear; set => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).MonthOfYear = value ?? null; }

        /// <summary>schedule frequency type</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string BackupFrequencyScheduleFrequencyType { get => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).ScheduleFrequencyType; set => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).ScheduleFrequencyType = value ?? null; }

        /// <summary>start time of schedule in seconds for daily, weekly, monthly, yearly frequency</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? BackupFrequencyStartTime { get => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).StartTime; set => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).StartTime = value ?? default(int); }

        /// <summary>Specific week of a month</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string BackupFrequencyWeekOfMonth { get => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).WeekOfMonth; set => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).WeekOfMonth = value ?? null; }

        /// <summary>Days of the week for weekly frequency</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] BackupFrequencyWeeklyDays { get => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).WeeklyDays; set => ((Commvault.Powershell.Models.IBackupFrequencyPatternInternal)BackupFrequency).WeeklyDays = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="BackupWindow" /> property.</summary>
        private Commvault.Powershell.Models.IDayAndTime[] _backupWindow;

        /// <summary>Archive job will run only in the specified archive window</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IDayAndTime[] BackupWindow { get => this._backupWindow; set => this._backupWindow = value; }

        /// <summary>Internal Acessors for BackupFrequency</summary>
        Commvault.Powershell.Models.IBackupFrequencyPattern Commvault.Powershell.Models.IArchivePlanRpoDetailsInternal.BackupFrequency { get => (this._backupFrequency = this._backupFrequency ?? new Commvault.Powershell.Models.BackupFrequencyPattern()); set { {_backupFrequency = value;} } }

        /// <summary>Internal Acessors for Sla</summary>
        Commvault.Powershell.Models.ISlaOptions Commvault.Powershell.Models.IArchivePlanRpoDetailsInternal.Sla { get => (this._sla = this._sla ?? new Commvault.Powershell.Models.SlaOptions()); set { {_sla = value;} } }

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

        /// <summary>Creates an new <see cref="ArchivePlanRpoDetails" /> instance.</summary>
        public ArchivePlanRpoDetails()
        {

        }
    }
    /// Recovery Point Objective (RPO) is the maximum amount of time that data can be lost during a service disruption. Your RPO
    /// determines the frequency of your backup jobs.
    public partial interface IArchivePlanRpoDetails :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Day on which to run the schedule, applicable for monthly, yearly</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Day on which to run the schedule, applicable for monthly, yearly",
        SerializedName = @"dayOfMonth",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupFrequencyDayOfMonth { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"dayOfWeek",
        PossibleTypes = new [] { typeof(string) })]
        string BackupFrequencyDayOfWeek { get; set; }
        /// <summary>
        /// Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes,
        /// for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes, for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months",
        SerializedName = @"frequency",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupFrequencyFrequency { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"monthOfYear",
        PossibleTypes = new [] { typeof(string) })]
        string BackupFrequencyMonthOfYear { get; set; }
        /// <summary>schedule frequency type</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"schedule frequency type",
        SerializedName = @"scheduleFrequencyType",
        PossibleTypes = new [] { typeof(string) })]
        string BackupFrequencyScheduleFrequencyType { get; set; }
        /// <summary>start time of schedule in seconds for daily, weekly, monthly, yearly frequency</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"start time of schedule in seconds for daily, weekly, monthly, yearly frequency",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupFrequencyStartTime { get; set; }
        /// <summary>Specific week of a month</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specific week of a month",
        SerializedName = @"weekOfMonth",
        PossibleTypes = new [] { typeof(string) })]
        string BackupFrequencyWeekOfMonth { get; set; }
        /// <summary>Days of the week for weekly frequency</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Days of the week for weekly frequency",
        SerializedName = @"weeklyDays",
        PossibleTypes = new [] { typeof(string) })]
        string[] BackupFrequencyWeeklyDays { get; set; }
        /// <summary>Archive job will run only in the specified archive window</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Archive job will run only in the specified archive window",
        SerializedName = @"backupWindow",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IDayAndTime) })]
        Commvault.Powershell.Models.IDayAndTime[] BackupWindow { get; set; }
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
    /// Recovery Point Objective (RPO) is the maximum amount of time that data can be lost during a service disruption. Your RPO
    /// determines the frequency of your backup jobs.
    internal partial interface IArchivePlanRpoDetailsInternal

    {
        /// <summary>Used to describe the frequency of backup</summary>
        Commvault.Powershell.Models.IBackupFrequencyPattern BackupFrequency { get; set; }
        /// <summary>Day on which to run the schedule, applicable for monthly, yearly</summary>
        int? BackupFrequencyDayOfMonth { get; set; }

        string BackupFrequencyDayOfWeek { get; set; }
        /// <summary>
        /// Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes,
        /// for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
        /// </summary>
        int? BackupFrequencyFrequency { get; set; }

        string BackupFrequencyMonthOfYear { get; set; }
        /// <summary>schedule frequency type</summary>
        string BackupFrequencyScheduleFrequencyType { get; set; }
        /// <summary>start time of schedule in seconds for daily, weekly, monthly, yearly frequency</summary>
        int? BackupFrequencyStartTime { get; set; }
        /// <summary>Specific week of a month</summary>
        string BackupFrequencyWeekOfMonth { get; set; }
        /// <summary>Days of the week for weekly frequency</summary>
        string[] BackupFrequencyWeeklyDays { get; set; }
        /// <summary>Archive job will run only in the specified archive window</summary>
        Commvault.Powershell.Models.IDayAndTime[] BackupWindow { get; set; }
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