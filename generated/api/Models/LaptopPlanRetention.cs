// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class LaptopPlanRetention :
        Commvault.Powershell.Models.ILaptopPlanRetention,
        Commvault.Powershell.Models.ILaptopPlanRetentionInternal
    {

        /// <summary>Internal Acessors for FileVersions</summary>
        Commvault.Powershell.Models.ILaptopPlanRetentionFileVersions Commvault.Powershell.Models.ILaptopPlanRetentionInternal.FileVersions { get => (this._fileVersions = this._fileVersions ?? new Commvault.Powershell.Models.LaptopPlanRetentionFileVersions()); set { {_fileVersions = value;} } }

        /// <summary>Backing field for <see cref="DeletedItemRetention" /> property.</summary>
        private int? _deletedItemRetention;

        /// <summary>
        /// Amount of days after deletion of files to keep the items. Giving value as -1 means to retain files indefinitely.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? DeletedItemRetention { get => this._deletedItemRetention; set => this._deletedItemRetention = value; }

        /// <summary>Custom version rule: Retain daily versions for this many day(s)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? FileVersionDailyVersions { get => ((Commvault.Powershell.Models.ILaptopPlanRetentionFileVersionsInternal)FileVersions).DailyVersions; set => ((Commvault.Powershell.Models.ILaptopPlanRetentionFileVersionsInternal)FileVersions).DailyVersions = value ?? default(int); }

        /// <summary>
        /// Retain files for this many days. Year(s) or month(s) need to be converted to day(s)
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? FileVersionDays { get => ((Commvault.Powershell.Models.ILaptopPlanRetentionFileVersionsInternal)FileVersions).Days; set => ((Commvault.Powershell.Models.ILaptopPlanRetentionFileVersionsInternal)FileVersions).Days = value ?? default(int); }

        /// <summary>Custom version rule: Retain monthly versions for this many month(s)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? FileVersionMonthlyVersions { get => ((Commvault.Powershell.Models.ILaptopPlanRetentionFileVersionsInternal)FileVersions).MonthlyVersions; set => ((Commvault.Powershell.Models.ILaptopPlanRetentionFileVersionsInternal)FileVersions).MonthlyVersions = value ?? default(int); }

        /// <summary>
        /// Retain this many file versions. This is considered as default if no file retention rule is specified.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? FileVersionVersions { get => ((Commvault.Powershell.Models.ILaptopPlanRetentionFileVersionsInternal)FileVersions).Versions; set => ((Commvault.Powershell.Models.ILaptopPlanRetentionFileVersionsInternal)FileVersions).Versions = value ?? default(int); }

        /// <summary>Custom version rule: Retain weekly versions for this many week(s)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? FileVersionWeeklyVersions { get => ((Commvault.Powershell.Models.ILaptopPlanRetentionFileVersionsInternal)FileVersions).WeeklyVersions; set => ((Commvault.Powershell.Models.ILaptopPlanRetentionFileVersionsInternal)FileVersions).WeeklyVersions = value ?? default(int); }

        /// <summary>Backing field for <see cref="FileVersions" /> property.</summary>
        private Commvault.Powershell.Models.ILaptopPlanRetentionFileVersions _fileVersions;

        /// <summary>
        /// Can retain file versions for one of following three cases:<br>days<br>versions<br>custom versions (daily, weekly monthly)<br>If
        /// not defined then, 5 versions are considered the default setting.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ILaptopPlanRetentionFileVersions FileVersions { get => (this._fileVersions = this._fileVersions ?? new Commvault.Powershell.Models.LaptopPlanRetentionFileVersions()); set => this._fileVersions = value; }

        /// <summary>Creates an new <see cref="LaptopPlanRetention" /> instance.</summary>
        public LaptopPlanRetention()
        {

        }
    }
    public partial interface ILaptopPlanRetention :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Amount of days after deletion of files to keep the items. Giving value as -1 means to retain files indefinitely.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Amount of days after deletion of files to keep the items. Giving value as -1 means to retain files indefinitely.",
        SerializedName = @"deletedItemRetention",
        PossibleTypes = new [] { typeof(int) })]
        int? DeletedItemRetention { get; set; }
        /// <summary>Custom version rule: Retain daily versions for this many day(s)</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Custom version rule: Retain daily versions for this many day(s)",
        SerializedName = @"dailyVersions",
        PossibleTypes = new [] { typeof(int) })]
        int? FileVersionDailyVersions { get; set; }
        /// <summary>
        /// Retain files for this many days. Year(s) or month(s) need to be converted to day(s)
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Retain files for this many days. Year(s) or month(s) need to be converted to day(s)",
        SerializedName = @"days",
        PossibleTypes = new [] { typeof(int) })]
        int? FileVersionDays { get; set; }
        /// <summary>Custom version rule: Retain monthly versions for this many month(s)</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Custom version rule: Retain monthly versions for this many month(s)",
        SerializedName = @"monthlyVersions",
        PossibleTypes = new [] { typeof(int) })]
        int? FileVersionMonthlyVersions { get; set; }
        /// <summary>
        /// Retain this many file versions. This is considered as default if no file retention rule is specified.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Retain this many file versions. This is considered as default if no file retention rule is specified.",
        SerializedName = @"versions",
        PossibleTypes = new [] { typeof(int) })]
        int? FileVersionVersions { get; set; }
        /// <summary>Custom version rule: Retain weekly versions for this many week(s)</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Custom version rule: Retain weekly versions for this many week(s)",
        SerializedName = @"weeklyVersions",
        PossibleTypes = new [] { typeof(int) })]
        int? FileVersionWeeklyVersions { get; set; }

    }
    internal partial interface ILaptopPlanRetentionInternal

    {
        /// <summary>
        /// Amount of days after deletion of files to keep the items. Giving value as -1 means to retain files indefinitely.
        /// </summary>
        int? DeletedItemRetention { get; set; }
        /// <summary>Custom version rule: Retain daily versions for this many day(s)</summary>
        int? FileVersionDailyVersions { get; set; }
        /// <summary>
        /// Retain files for this many days. Year(s) or month(s) need to be converted to day(s)
        /// </summary>
        int? FileVersionDays { get; set; }
        /// <summary>Custom version rule: Retain monthly versions for this many month(s)</summary>
        int? FileVersionMonthlyVersions { get; set; }
        /// <summary>
        /// Retain this many file versions. This is considered as default if no file retention rule is specified.
        /// </summary>
        int? FileVersionVersions { get; set; }
        /// <summary>Custom version rule: Retain weekly versions for this many week(s)</summary>
        int? FileVersionWeeklyVersions { get; set; }
        /// <summary>
        /// Can retain file versions for one of following three cases:<br>days<br>versions<br>custom versions (daily, weekly monthly)<br>If
        /// not defined then, 5 versions are considered the default setting.
        /// </summary>
        Commvault.Powershell.Models.ILaptopPlanRetentionFileVersions FileVersions { get; set; }

    }
}