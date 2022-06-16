// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Recovery point retention inputs for continuous replication group.</summary>
    public partial class RecoveryPointRetentionCreate :
        Commvault.Powershell.Models.IRecoveryPointRetentionCreate,
        Commvault.Powershell.Models.IRecoveryPointRetentionCreateInternal
    {

        /// <summary>Backing field for <see cref="MergeRecoveryPoints" /> property.</summary>
        private bool? _mergeRecoveryPoints;

        /// <summary>
        /// Merge the recovery points beyond the time provided in mergeRecoveryPointsOlderThan
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? MergeRecoveryPoints { get => this._mergeRecoveryPoints; set => this._mergeRecoveryPoints = value; }

        /// <summary>Backing field for <see cref="MergeRecoveryPointsOlderThan" /> property.</summary>
        private int? _mergeRecoveryPointsOlderThan;

        /// <summary>
        /// Applicable only if mergeRecoveryPoints is set to true. Beyond this period(in seconds), older recovery points will be merged
        /// into progressively coarser intervals going back in time. Applicable only for Point in time recovery. The value cannot
        /// exceed the value of retainRecoveryPointsFor.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? MergeRecoveryPointsOlderThan { get => this._mergeRecoveryPointsOlderThan; set => this._mergeRecoveryPointsOlderThan = value; }

        /// <summary>Backing field for <see cref="PruneAndMergeDuringOffPeak" /> property.</summary>
        private bool? _pruneAndMergeDuringOffPeak;

        /// <summary>
        /// Transfers the updates of the oldest recovery points to destination VM only during off-peak hours. The peak interval time
        /// should be configured in the RP store. Applicable only for Point in time recovery.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? PruneAndMergeDuringOffPeak { get => this._pruneAndMergeDuringOffPeak; set => this._pruneAndMergeDuringOffPeak = value; }

        /// <summary>
        /// Backing field for <see cref="RecoveryPointIntervalAtEndofRetention" /> property.
        /// </summary>
        private int? _recoveryPointIntervalAtEndofRetention;

        /// <summary>
        /// Applicable only if mergeRecoveryPoints is set to true. Time interval(in seconds) between the older recovery points. Applicable
        /// only if mergeRecoveryPointsOlderThan and Point in time recovery is selected. The value cannot exceed the value of retainRecoveryPointsFor
        /// or 86400 seconds(1 day).
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? RecoveryPointIntervalAtEndofRetention { get => this._recoveryPointIntervalAtEndofRetention; set => this._recoveryPointIntervalAtEndofRetention = value; }

        /// <summary>Backing field for <see cref="RetainRecoveryPointsFor" /> property.</summary>
        private int _retainRecoveryPointsFor;

        /// <summary>
        /// The lengh of time(in seconds) to a retain the recovery point entries. Applicable only for Point in time recovery.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int RetainRecoveryPointsFor { get => this._retainRecoveryPointsFor; set => this._retainRecoveryPointsFor = value; }

        /// <summary>Backing field for <see cref="RpStoreOfflineFor" /> property.</summary>
        private int? _rpStoreOfflineFor;

        /// <summary>
        /// Time(in seconds) after which the recovery type is switched to 'Latest recovery' if RP store is offline. Applicable only
        /// for Point in time recovery.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? RpStoreOfflineFor { get => this._rpStoreOfflineFor; set => this._rpStoreOfflineFor = value; }

        /// <summary>Creates an new <see cref="RecoveryPointRetentionCreate" /> instance.</summary>
        public RecoveryPointRetentionCreate()
        {

        }
    }
    /// Recovery point retention inputs for continuous replication group.
    public partial interface IRecoveryPointRetentionCreate :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Merge the recovery points beyond the time provided in mergeRecoveryPointsOlderThan
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Merge the recovery points beyond the time provided in mergeRecoveryPointsOlderThan",
        SerializedName = @"mergeRecoveryPoints",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MergeRecoveryPoints { get; set; }
        /// <summary>
        /// Applicable only if mergeRecoveryPoints is set to true. Beyond this period(in seconds), older recovery points will be merged
        /// into progressively coarser intervals going back in time. Applicable only for Point in time recovery. The value cannot
        /// exceed the value of retainRecoveryPointsFor.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Applicable only if mergeRecoveryPoints is set to true. Beyond this period(in seconds), older recovery points will be merged into progressively coarser intervals going back in time. Applicable only for Point in time recovery. The value cannot exceed the value of retainRecoveryPointsFor.",
        SerializedName = @"mergeRecoveryPointsOlderThan",
        PossibleTypes = new [] { typeof(int) })]
        int? MergeRecoveryPointsOlderThan { get; set; }
        /// <summary>
        /// Transfers the updates of the oldest recovery points to destination VM only during off-peak hours. The peak interval time
        /// should be configured in the RP store. Applicable only for Point in time recovery.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Transfers the updates of the oldest recovery points to destination VM only during off-peak hours. The peak interval time should be configured in the RP store.  Applicable only for Point in time recovery.",
        SerializedName = @"pruneAndMergeDuringOffPeak",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PruneAndMergeDuringOffPeak { get; set; }
        /// <summary>
        /// Applicable only if mergeRecoveryPoints is set to true. Time interval(in seconds) between the older recovery points. Applicable
        /// only if mergeRecoveryPointsOlderThan and Point in time recovery is selected. The value cannot exceed the value of retainRecoveryPointsFor
        /// or 86400 seconds(1 day).
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Applicable only if mergeRecoveryPoints is set to true.  Time interval(in seconds) between the older recovery points. Applicable only if mergeRecoveryPointsOlderThan and Point in time recovery is selected. The value cannot exceed the value of retainRecoveryPointsFor or 86400 seconds(1 day).",
        SerializedName = @"recoveryPointIntervalAtEndofRetention",
        PossibleTypes = new [] { typeof(int) })]
        int? RecoveryPointIntervalAtEndofRetention { get; set; }
        /// <summary>
        /// The lengh of time(in seconds) to a retain the recovery point entries. Applicable only for Point in time recovery.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The lengh of time(in seconds) to a retain the recovery point entries. Applicable only for Point in time recovery.",
        SerializedName = @"retainRecoveryPointsFor",
        PossibleTypes = new [] { typeof(int) })]
        int RetainRecoveryPointsFor { get; set; }
        /// <summary>
        /// Time(in seconds) after which the recovery type is switched to 'Latest recovery' if RP store is offline. Applicable only
        /// for Point in time recovery.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time(in seconds) after which the recovery type is switched to 'Latest recovery' if RP store is offline. Applicable only for Point in time recovery.",
        SerializedName = @"rpStoreOfflineFor",
        PossibleTypes = new [] { typeof(int) })]
        int? RpStoreOfflineFor { get; set; }

    }
    /// Recovery point retention inputs for continuous replication group.
    internal partial interface IRecoveryPointRetentionCreateInternal

    {
        /// <summary>
        /// Merge the recovery points beyond the time provided in mergeRecoveryPointsOlderThan
        /// </summary>
        bool? MergeRecoveryPoints { get; set; }
        /// <summary>
        /// Applicable only if mergeRecoveryPoints is set to true. Beyond this period(in seconds), older recovery points will be merged
        /// into progressively coarser intervals going back in time. Applicable only for Point in time recovery. The value cannot
        /// exceed the value of retainRecoveryPointsFor.
        /// </summary>
        int? MergeRecoveryPointsOlderThan { get; set; }
        /// <summary>
        /// Transfers the updates of the oldest recovery points to destination VM only during off-peak hours. The peak interval time
        /// should be configured in the RP store. Applicable only for Point in time recovery.
        /// </summary>
        bool? PruneAndMergeDuringOffPeak { get; set; }
        /// <summary>
        /// Applicable only if mergeRecoveryPoints is set to true. Time interval(in seconds) between the older recovery points. Applicable
        /// only if mergeRecoveryPointsOlderThan and Point in time recovery is selected. The value cannot exceed the value of retainRecoveryPointsFor
        /// or 86400 seconds(1 day).
        /// </summary>
        int? RecoveryPointIntervalAtEndofRetention { get; set; }
        /// <summary>
        /// The lengh of time(in seconds) to a retain the recovery point entries. Applicable only for Point in time recovery.
        /// </summary>
        int RetainRecoveryPointsFor { get; set; }
        /// <summary>
        /// Time(in seconds) after which the recovery type is switched to 'Latest recovery' if RP store is offline. Applicable only
        /// for Point in time recovery.
        /// </summary>
        int? RpStoreOfflineFor { get; set; }

    }
}