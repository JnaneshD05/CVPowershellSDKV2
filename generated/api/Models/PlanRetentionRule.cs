// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class PlanRetentionRule :
        Commvault.Powershell.Models.IPlanRetentionRule,
        Commvault.Powershell.Models.IPlanRetentionRuleInternal
    {

        /// <summary>Backing field for <see cref="IsInfiniteRetention" /> property.</summary>
        private bool? _isInfiniteRetention;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? IsInfiniteRetention { get => this._isInfiniteRetention; set => this._isInfiniteRetention = value; }

        /// <summary>Backing field for <see cref="RetentionPeriodDays" /> property.</summary>
        private int? _retentionPeriodDays;

        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? RetentionPeriodDays { get => this._retentionPeriodDays; set => this._retentionPeriodDays = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="PlanRetentionRule" /> instance.</summary>
        public PlanRetentionRule()
        {

        }
    }
    public partial interface IPlanRetentionRule :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isInfiniteRetention",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsInfiniteRetention { get; set; }
        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.",
        SerializedName = @"retentionPeriodDays",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionPeriodDays { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    internal partial interface IPlanRetentionRuleInternal

    {
        bool? IsInfiniteRetention { get; set; }
        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        int? RetentionPeriodDays { get; set; }

        string Type { get; set; }

    }
}