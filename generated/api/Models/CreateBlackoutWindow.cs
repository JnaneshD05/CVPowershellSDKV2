// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// betweenDates refers to the dates where the blackout window will be in effect. Dates have to be given in unix time format.
    /// time has to be provided in seconds. company refers to company to which the blackout window is associated.Id is given first
    /// preference if both are id and name are provided.
    /// </summary>
    public partial class CreateBlackoutWindow :
        Commvault.Powershell.Models.ICreateBlackoutWindow,
        Commvault.Powershell.Models.ICreateBlackoutWindowInternal
    {

        /// <summary>Backing field for <see cref="BackupOperations" /> property.</summary>
        private string[] _backupOperations;

        /// <summary>Refers to backup types to include in the blackout window</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string[] BackupOperations { get => this._backupOperations; set => this._backupOperations = value; }

        /// <summary>the blackout window is no longer in effect from this point on.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? BetweenDateEnd { get => ((Commvault.Powershell.Models.IStartEndInternal)BetweenDates).End; set => ((Commvault.Powershell.Models.IStartEndInternal)BetweenDates).End = value ?? default(long); }

        /// <summary>the blackout window comes into effect at this point.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? BetweenDateStart { get => ((Commvault.Powershell.Models.IStartEndInternal)BetweenDates).Start; set => ((Commvault.Powershell.Models.IStartEndInternal)BetweenDates).Start = value ?? default(long); }

        /// <summary>Backing field for <see cref="BetweenDates" /> property.</summary>
        private Commvault.Powershell.Models.IStartEnd _betweenDates;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IStartEnd BetweenDates { get => (this._betweenDates = this._betweenDates ?? new Commvault.Powershell.Models.StartEnd()); set => this._betweenDates = value; }

        /// <summary>Internal Acessors for BetweenDates</summary>
        Commvault.Powershell.Models.IStartEnd Commvault.Powershell.Models.ICreateBlackoutWindowInternal.BetweenDates { get => (this._betweenDates = this._betweenDates ?? new Commvault.Powershell.Models.StartEnd()); set { {_betweenDates = value;} } }

        /// <summary>Internal Acessors for Company</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICreateBlackoutWindowInternal.Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set { {_company = value;} } }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _company;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.IdName()); set => this._company = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? CompanyId { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Company).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Days" /> property.</summary>
        private string[] _days;

        /// <summary>Days of the week when the blackout window will be in effect.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string[] Days { get => this._days; set => this._days = value; }

        /// <summary>Backing field for <see cref="DoNotSubmitJob" /> property.</summary>
        private bool? _doNotSubmitJob;

        /// <summary>
        /// Allows or Denies submitting a job when the blackout window is in effect. If set to false, the job is submitted and resumed
        /// once the blackout window ends.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? DoNotSubmitJob { get => this._doNotSubmitJob; set => this._doNotSubmitJob = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the blackout window to be created.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Time" /> property.</summary>
        private Commvault.Powershell.Models.IStartEnd[] _time;

        /// <summary>
        /// Refers to the time between which the blackout window will be in effect. It has to be provided in seconds
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IStartEnd[] Time { get => this._time; set => this._time = value; }

        /// <summary>Backing field for <see cref="Weeks" /> property.</summary>
        private string[] _weeks;

        /// <summary>Refers to the weeks of the month that the blackout window will be in effect.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string[] Weeks { get => this._weeks; set => this._weeks = value; }

        /// <summary>Creates an new <see cref="CreateBlackoutWindow" /> instance.</summary>
        public CreateBlackoutWindow()
        {

        }
    }
    /// betweenDates refers to the dates where the blackout window will be in effect. Dates have to be given in unix time format.
    /// time has to be provided in seconds. company refers to company to which the blackout window is associated.Id is given first
    /// preference if both are id and name are provided.
    public partial interface ICreateBlackoutWindow :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Refers to backup types to include in the blackout window</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Refers to backup types to include in the blackout window",
        SerializedName = @"backupOperations",
        PossibleTypes = new [] { typeof(string) })]
        string[] BackupOperations { get; set; }
        /// <summary>the blackout window is no longer in effect from this point on.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the blackout window is no longer in effect from this point on.",
        SerializedName = @"end",
        PossibleTypes = new [] { typeof(long) })]
        long? BetweenDateEnd { get; set; }
        /// <summary>the blackout window comes into effect at this point.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the blackout window comes into effect at this point.",
        SerializedName = @"start",
        PossibleTypes = new [] { typeof(long) })]
        long? BetweenDateStart { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? CompanyId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyName { get; set; }
        /// <summary>Days of the week when the blackout window will be in effect.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Days of the week when the blackout window will be in effect.",
        SerializedName = @"days",
        PossibleTypes = new [] { typeof(string) })]
        string[] Days { get; set; }
        /// <summary>
        /// Allows or Denies submitting a job when the blackout window is in effect. If set to false, the job is submitted and resumed
        /// once the blackout window ends.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Allows or Denies submitting a job when the blackout window is in effect. If set to false, the job is submitted and resumed once the blackout window ends.",
        SerializedName = @"doNotSubmitJob",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DoNotSubmitJob { get; set; }
        /// <summary>Name of the blackout window to be created.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of the blackout window to be created.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// Refers to the time between which the blackout window will be in effect. It has to be provided in seconds
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Refers to the time between which the blackout window will be in effect. It has to be provided in seconds",
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IStartEnd) })]
        Commvault.Powershell.Models.IStartEnd[] Time { get; set; }
        /// <summary>Refers to the weeks of the month that the blackout window will be in effect.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Refers to the weeks of the month that the blackout window will be in effect.",
        SerializedName = @"weeks",
        PossibleTypes = new [] { typeof(string) })]
        string[] Weeks { get; set; }

    }
    /// betweenDates refers to the dates where the blackout window will be in effect. Dates have to be given in unix time format.
    /// time has to be provided in seconds. company refers to company to which the blackout window is associated.Id is given first
    /// preference if both are id and name are provided.
    internal partial interface ICreateBlackoutWindowInternal

    {
        /// <summary>Refers to backup types to include in the blackout window</summary>
        string[] BackupOperations { get; set; }
        /// <summary>the blackout window is no longer in effect from this point on.</summary>
        long? BetweenDateEnd { get; set; }
        /// <summary>the blackout window comes into effect at this point.</summary>
        long? BetweenDateStart { get; set; }

        Commvault.Powershell.Models.IStartEnd BetweenDates { get; set; }

        Commvault.Powershell.Models.IIdName Company { get; set; }

        int? CompanyId { get; set; }

        string CompanyName { get; set; }
        /// <summary>Days of the week when the blackout window will be in effect.</summary>
        string[] Days { get; set; }
        /// <summary>
        /// Allows or Denies submitting a job when the blackout window is in effect. If set to false, the job is submitted and resumed
        /// once the blackout window ends.
        /// </summary>
        bool? DoNotSubmitJob { get; set; }
        /// <summary>Name of the blackout window to be created.</summary>
        string Name { get; set; }
        /// <summary>
        /// Refers to the time between which the blackout window will be in effect. It has to be provided in seconds
        /// </summary>
        Commvault.Powershell.Models.IStartEnd[] Time { get; set; }
        /// <summary>Refers to the weeks of the month that the blackout window will be in effect.</summary>
        string[] Weeks { get; set; }

    }
}