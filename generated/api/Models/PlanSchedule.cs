// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Used to describe single plan schedule information</summary>
    public partial class PlanSchedule :
        Commvault.Powershell.Models.IPlanSchedule,
        Commvault.Powershell.Models.IPlanScheduleInternal
    {

        /// <summary>Backing field for <see cref="BackupType" /> property.</summary>
        private string _backupType;

        /// <summary>Schedule Backup level</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string BackupType { get => this._backupType; set => this._backupType = value; }

        /// <summary>Internal Acessors for SchedulePattern</summary>
        Commvault.Powershell.Models.ISchedulePattern Commvault.Powershell.Models.IPlanScheduleInternal.SchedulePattern { get => (this._schedulePattern = this._schedulePattern ?? new Commvault.Powershell.Models.SchedulePattern()); set { {_schedulePattern = value;} } }

        /// <summary>Internal Acessors for SchedulePatternTimezone</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IPlanScheduleInternal.SchedulePatternTimezone { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).Timezone; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).Timezone = value; }

        /// <summary>Backing field for <see cref="ForDatabasesOnly" /> property.</summary>
        private bool _forDatabasesOnly;

        /// <summary>Boolean to indicate if schedule is for database agents</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool ForDatabasesOnly { get => this._forDatabasesOnly; set => this._forDatabasesOnly = value; }

        /// <summary>Backing field for <see cref="PolicyId" /> property.</summary>
        private int? _policyId;

        /// <summary>Schedule policy Id to which the schedule belongs</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? PolicyId { get => this._policyId; set => this._policyId = value; }

        /// <summary>Backing field for <see cref="ScheduleId" /> property.</summary>
        private int? _scheduleId;

        /// <summary>Id of the schedule if available, required for modifying, deleting schedule</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? ScheduleId { get => this._scheduleId; set => this._scheduleId = value; }

        /// <summary>Backing field for <see cref="ScheduleName" /> property.</summary>
        private string _scheduleName;

        /// <summary>Name of the schedule, for modify</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ScheduleName { get => this._scheduleName; set => this._scheduleName = value; }

        /// <summary>Backing field for <see cref="ScheduleOperation" /> property.</summary>
        private string _scheduleOperation;

        /// <summary>Operation being performed on schedule</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ScheduleOperation { get => this._scheduleOperation; set => this._scheduleOperation = value; }

        /// <summary>Backing field for <see cref="SchedulePattern" /> property.</summary>
        private Commvault.Powershell.Models.ISchedulePattern _schedulePattern;

        /// <summary>Used to describe when the schedule runs</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ISchedulePattern SchedulePattern { get => (this._schedulePattern = this._schedulePattern ?? new Commvault.Powershell.Models.SchedulePattern()); set => this._schedulePattern = value; }

        /// <summary>Day on which to run the schedule, applicable for monthly, yearly</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SchedulePatternDayOfMonth { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).DayOfMonth; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).DayOfMonth = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SchedulePatternDayOfWeek { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).DayOfWeek; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).DayOfWeek = value ?? null; }

        /// <summary>No of days between two synthetic full jobs</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SchedulePatternDaysBetweenSyntheticFulls { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).DaysBetweenSyntheticFulls; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).DaysBetweenSyntheticFulls = value ?? default(int); }

        /// <summary>Schedule end date in epoch format</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SchedulePatternEndDate { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).EndDate; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).EndDate = value ?? default(int); }

        /// <summary>
        /// Exceptions to when a schedule should not run, either in dates or week of month and days
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IScheduleRunException[] SchedulePatternExceptions { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).Exceptions; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).Exceptions = value ?? null /* arrayOf */; }

        /// <summary>
        /// Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes,
        /// for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SchedulePatternFrequency { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).Frequency; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).Frequency = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SchedulePatternMonthOfYear { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).MonthOfYear; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).MonthOfYear = value ?? null; }

        /// <summary>The number of times you want the schedule to run.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SchedulePatternNoOfTimes { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).NoOfTimes; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).NoOfTimes = value ?? default(int); }

        /// <summary>
        /// How often in minutes in a day the schedule runs, applicable for daily, weekly, monthly and yearly frequency types.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SchedulePatternRepeatIntervalInMinutes { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).RepeatIntervalInMinutes; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).RepeatIntervalInMinutes = value ?? default(int); }

        /// <summary>
        /// Until what time to repeat the schedule in a day, requires repeatIntervalInMinutes
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SchedulePatternRepeatUntilTime { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).RepeatUntilTime; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).RepeatUntilTime = value ?? default(int); }

        /// <summary>schedule frequency type</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SchedulePatternScheduleFrequencyType { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).ScheduleFrequencyType; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).ScheduleFrequencyType = value ; }

        /// <summary>start date of schedule in epoch format</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SchedulePatternStartDate { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).StartDate; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).StartDate = value ?? default(int); }

        /// <summary>start time of schedule in seconds</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SchedulePatternStartTime { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).StartTime; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).StartTime = value ?? default(int); }

        /// <summary>Specific week of a month</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SchedulePatternWeekOfMonth { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).WeekOfMonth; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).WeekOfMonth = value ?? null; }

        /// <summary>Days of the week for weekly frequency</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string[] SchedulePatternWeeklyDays { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).WeeklyDays; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).WeeklyDays = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? TimezoneId { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).TimezoneId; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).TimezoneId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TimezoneName { get => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).TimezoneName; set => ((Commvault.Powershell.Models.ISchedulePatternInternal)SchedulePattern).TimezoneName = value ?? null; }

        /// <summary>Creates an new <see cref="PlanSchedule" /> instance.</summary>
        public PlanSchedule()
        {

        }
    }
    /// Used to describe single plan schedule information
    public partial interface IPlanSchedule :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Schedule Backup level</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Schedule Backup level",
        SerializedName = @"backupType",
        PossibleTypes = new [] { typeof(string) })]
        string BackupType { get; set; }
        /// <summary>Boolean to indicate if schedule is for database agents</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Boolean to indicate if schedule is for database agents",
        SerializedName = @"forDatabasesOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool ForDatabasesOnly { get; set; }
        /// <summary>Schedule policy Id to which the schedule belongs</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Schedule policy Id to which the schedule belongs",
        SerializedName = @"policyId",
        PossibleTypes = new [] { typeof(int) })]
        int? PolicyId { get; set; }
        /// <summary>Id of the schedule if available, required for modifying, deleting schedule</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the schedule if available, required for modifying, deleting schedule",
        SerializedName = @"scheduleId",
        PossibleTypes = new [] { typeof(int) })]
        int? ScheduleId { get; set; }
        /// <summary>Name of the schedule, for modify</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the schedule, for modify",
        SerializedName = @"scheduleName",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduleName { get; set; }
        /// <summary>Operation being performed on schedule</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Operation being performed on schedule",
        SerializedName = @"scheduleOperation",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduleOperation { get; set; }
        /// <summary>Day on which to run the schedule, applicable for monthly, yearly</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Day on which to run the schedule, applicable for monthly, yearly",
        SerializedName = @"dayOfMonth",
        PossibleTypes = new [] { typeof(int) })]
        int? SchedulePatternDayOfMonth { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"dayOfWeek",
        PossibleTypes = new [] { typeof(string) })]
        string SchedulePatternDayOfWeek { get; set; }
        /// <summary>No of days between two synthetic full jobs</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"No of days between two synthetic full jobs",
        SerializedName = @"daysBetweenSyntheticFulls",
        PossibleTypes = new [] { typeof(int) })]
        int? SchedulePatternDaysBetweenSyntheticFulls { get; set; }
        /// <summary>Schedule end date in epoch format</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Schedule end date in epoch format",
        SerializedName = @"endDate",
        PossibleTypes = new [] { typeof(int) })]
        int? SchedulePatternEndDate { get; set; }
        /// <summary>
        /// Exceptions to when a schedule should not run, either in dates or week of month and days
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Exceptions to when a schedule should not run, either in dates or week of month and days",
        SerializedName = @"exceptions",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IScheduleRunException) })]
        Commvault.Powershell.Models.IScheduleRunException[] SchedulePatternExceptions { get; set; }
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
        int? SchedulePatternFrequency { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"monthOfYear",
        PossibleTypes = new [] { typeof(string) })]
        string SchedulePatternMonthOfYear { get; set; }
        /// <summary>The number of times you want the schedule to run.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of times you want the schedule to run.",
        SerializedName = @"noOfTimes",
        PossibleTypes = new [] { typeof(int) })]
        int? SchedulePatternNoOfTimes { get; set; }
        /// <summary>
        /// How often in minutes in a day the schedule runs, applicable for daily, weekly, monthly and yearly frequency types.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"How often in minutes in a day the schedule runs, applicable for daily, weekly, monthly and yearly frequency types.",
        SerializedName = @"repeatIntervalInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? SchedulePatternRepeatIntervalInMinutes { get; set; }
        /// <summary>
        /// Until what time to repeat the schedule in a day, requires repeatIntervalInMinutes
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Until what time to repeat the schedule in a day, requires repeatIntervalInMinutes",
        SerializedName = @"repeatUntilTime",
        PossibleTypes = new [] { typeof(int) })]
        int? SchedulePatternRepeatUntilTime { get; set; }
        /// <summary>schedule frequency type</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"schedule frequency type",
        SerializedName = @"scheduleFrequencyType",
        PossibleTypes = new [] { typeof(string) })]
        string SchedulePatternScheduleFrequencyType { get; set; }
        /// <summary>start date of schedule in epoch format</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"start date of schedule in epoch format",
        SerializedName = @"startDate",
        PossibleTypes = new [] { typeof(int) })]
        int? SchedulePatternStartDate { get; set; }
        /// <summary>start time of schedule in seconds</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"start time of schedule in seconds",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(int) })]
        int? SchedulePatternStartTime { get; set; }
        /// <summary>Specific week of a month</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specific week of a month",
        SerializedName = @"weekOfMonth",
        PossibleTypes = new [] { typeof(string) })]
        string SchedulePatternWeekOfMonth { get; set; }
        /// <summary>Days of the week for weekly frequency</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Days of the week for weekly frequency",
        SerializedName = @"weeklyDays",
        PossibleTypes = new [] { typeof(string) })]
        string[] SchedulePatternWeeklyDays { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? TimezoneId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string TimezoneName { get; set; }

    }
    /// Used to describe single plan schedule information
    internal partial interface IPlanScheduleInternal

    {
        /// <summary>Schedule Backup level</summary>
        string BackupType { get; set; }
        /// <summary>Boolean to indicate if schedule is for database agents</summary>
        bool ForDatabasesOnly { get; set; }
        /// <summary>Schedule policy Id to which the schedule belongs</summary>
        int? PolicyId { get; set; }
        /// <summary>Id of the schedule if available, required for modifying, deleting schedule</summary>
        int? ScheduleId { get; set; }
        /// <summary>Name of the schedule, for modify</summary>
        string ScheduleName { get; set; }
        /// <summary>Operation being performed on schedule</summary>
        string ScheduleOperation { get; set; }
        /// <summary>Used to describe when the schedule runs</summary>
        Commvault.Powershell.Models.ISchedulePattern SchedulePattern { get; set; }
        /// <summary>Day on which to run the schedule, applicable for monthly, yearly</summary>
        int? SchedulePatternDayOfMonth { get; set; }

        string SchedulePatternDayOfWeek { get; set; }
        /// <summary>No of days between two synthetic full jobs</summary>
        int? SchedulePatternDaysBetweenSyntheticFulls { get; set; }
        /// <summary>Schedule end date in epoch format</summary>
        int? SchedulePatternEndDate { get; set; }
        /// <summary>
        /// Exceptions to when a schedule should not run, either in dates or week of month and days
        /// </summary>
        Commvault.Powershell.Models.IScheduleRunException[] SchedulePatternExceptions { get; set; }
        /// <summary>
        /// Frequency of the schedule based on schedule frequency type eg. for Hours, value 2 is 2 hours, for Minutes, 30 is 30 minutes,
        /// for Daily, 2 is 2 days. for Monthly 2 is it repeats every 2 months
        /// </summary>
        int? SchedulePatternFrequency { get; set; }

        string SchedulePatternMonthOfYear { get; set; }
        /// <summary>The number of times you want the schedule to run.</summary>
        int? SchedulePatternNoOfTimes { get; set; }
        /// <summary>
        /// How often in minutes in a day the schedule runs, applicable for daily, weekly, monthly and yearly frequency types.
        /// </summary>
        int? SchedulePatternRepeatIntervalInMinutes { get; set; }
        /// <summary>
        /// Until what time to repeat the schedule in a day, requires repeatIntervalInMinutes
        /// </summary>
        int? SchedulePatternRepeatUntilTime { get; set; }
        /// <summary>schedule frequency type</summary>
        string SchedulePatternScheduleFrequencyType { get; set; }
        /// <summary>start date of schedule in epoch format</summary>
        int? SchedulePatternStartDate { get; set; }
        /// <summary>start time of schedule in seconds</summary>
        int? SchedulePatternStartTime { get; set; }

        Commvault.Powershell.Models.IIdName SchedulePatternTimezone { get; set; }
        /// <summary>Specific week of a month</summary>
        string SchedulePatternWeekOfMonth { get; set; }
        /// <summary>Days of the week for weekly frequency</summary>
        string[] SchedulePatternWeeklyDays { get; set; }

        int? TimezoneId { get; set; }

        string TimezoneName { get; set; }

    }
}