// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class StartEnd :
        Commvault.Powershell.Models.IStartEnd,
        Commvault.Powershell.Models.IStartEndInternal
    {

        /// <summary>Backing field for <see cref="End" /> property.</summary>
        private long? _end;

        /// <summary>the blackout window is no longer in effect from this point on.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? End { get => this._end; set => this._end = value; }

        /// <summary>Backing field for <see cref="Start" /> property.</summary>
        private long? _start;

        /// <summary>the blackout window comes into effect at this point.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? Start { get => this._start; set => this._start = value; }

        /// <summary>Creates an new <see cref="StartEnd" /> instance.</summary>
        public StartEnd()
        {

        }
    }
    public partial interface IStartEnd :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>the blackout window is no longer in effect from this point on.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the blackout window is no longer in effect from this point on.",
        SerializedName = @"end",
        PossibleTypes = new [] { typeof(long) })]
        long? End { get; set; }
        /// <summary>the blackout window comes into effect at this point.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"the blackout window comes into effect at this point.",
        SerializedName = @"start",
        PossibleTypes = new [] { typeof(long) })]
        long? Start { get; set; }

    }
    internal partial interface IStartEndInternal

    {
        /// <summary>the blackout window is no longer in effect from this point on.</summary>
        long? End { get; set; }
        /// <summary>the blackout window comes into effect at this point.</summary>
        long? Start { get; set; }

    }
}