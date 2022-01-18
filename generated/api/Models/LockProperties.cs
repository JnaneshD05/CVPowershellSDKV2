// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class LockProperties :
        Commvault.Powershell.Models.ILockProperties,
        Commvault.Powershell.Models.ILockPropertiesInternal
    {

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private int? _endTime;

        /// <summary>If the user is locked, it returns user lock end time in unix time format.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? EndTime { get => this._endTime; set => this._endTime = value; }

        /// <summary>Backing field for <see cref="IsLocked" /> property.</summary>
        private bool? _isLocked;

        /// <summary>Returns if the user is locked or unlocked.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? IsLocked { get => this._isLocked; set => this._isLocked = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private int? _startTime;

        /// <summary>If the user is locked, it returns user lock start time in unix time format.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>Creates an new <see cref="LockProperties" /> instance.</summary>
        public LockProperties()
        {

        }
    }
    public partial interface ILockProperties :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>If the user is locked, it returns user lock end time in unix time format.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If the user is locked, it returns user lock end time in unix time format.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(int) })]
        int? EndTime { get; set; }
        /// <summary>Returns if the user is locked or unlocked.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Returns if the user is locked or unlocked.",
        SerializedName = @"isLocked",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsLocked { get; set; }
        /// <summary>If the user is locked, it returns user lock start time in unix time format.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If the user is locked, it returns user lock start time in unix time format.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(int) })]
        int? StartTime { get; set; }

    }
    internal partial interface ILockPropertiesInternal

    {
        /// <summary>If the user is locked, it returns user lock end time in unix time format.</summary>
        int? EndTime { get; set; }
        /// <summary>Returns if the user is locked or unlocked.</summary>
        bool? IsLocked { get; set; }
        /// <summary>If the user is locked, it returns user lock start time in unix time format.</summary>
        int? StartTime { get; set; }

    }
}