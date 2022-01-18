// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// This feature applies to derived plans when inherit mode is optional.Provides user to set entity preference between parent
    /// and derived plan.
    /// </summary>
    public partial class PlanOverrideInheritSetting :
        Commvault.Powershell.Models.IPlanOverrideInheritSetting,
        Commvault.Powershell.Models.IPlanOverrideInheritSettingInternal
    {

        /// <summary>Backing field for <see cref="BackupContent" /> property.</summary>
        private bool? _backupContent;

        /// <summary>
        /// Flag to specify if parent or derived plan backupContent should be used when inherit mode is optional. True - derived,
        /// False - Base.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? BackupContent { get => this._backupContent; set => this._backupContent = value; }

        /// <summary>Backing field for <see cref="BackupDestination" /> property.</summary>
        private bool? _backupDestination;

        /// <summary>
        /// Flag to specify if parent or derived plan backupDestination should be used when inherit mode is optional. True - derived,
        /// False - Base.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? BackupDestination { get => this._backupDestination; set => this._backupDestination = value; }

        /// <summary>Backing field for <see cref="Rpo" /> property.</summary>
        private bool? _rpo;

        /// <summary>
        /// Flag to specify if parent or derived plan rpo should be used when inherit mode is optional. True - derived, False - Base.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Rpo { get => this._rpo; set => this._rpo = value; }

        /// <summary>Creates an new <see cref="PlanOverrideInheritSetting" /> instance.</summary>
        public PlanOverrideInheritSetting()
        {

        }
    }
    /// This feature applies to derived plans when inherit mode is optional.Provides user to set entity preference between parent
    /// and derived plan.
    public partial interface IPlanOverrideInheritSetting :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Flag to specify if parent or derived plan backupContent should be used when inherit mode is optional. True - derived,
        /// False - Base.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to specify if parent or derived plan backupContent should be used when inherit mode is optional. True - derived, False - Base.",
        SerializedName = @"backupContent",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BackupContent { get; set; }
        /// <summary>
        /// Flag to specify if parent or derived plan backupDestination should be used when inherit mode is optional. True - derived,
        /// False - Base.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to specify if parent or derived plan backupDestination should be used when inherit mode is optional. True - derived, False - Base.",
        SerializedName = @"backupDestination",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BackupDestination { get; set; }
        /// <summary>
        /// Flag to specify if parent or derived plan rpo should be used when inherit mode is optional. True - derived, False - Base.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to specify if parent or derived plan rpo should be used when inherit mode is optional. True - derived, False - Base.",
        SerializedName = @"rpo",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Rpo { get; set; }

    }
    /// This feature applies to derived plans when inherit mode is optional.Provides user to set entity preference between parent
    /// and derived plan.
    internal partial interface IPlanOverrideInheritSettingInternal

    {
        /// <summary>
        /// Flag to specify if parent or derived plan backupContent should be used when inherit mode is optional. True - derived,
        /// False - Base.
        /// </summary>
        bool? BackupContent { get; set; }
        /// <summary>
        /// Flag to specify if parent or derived plan backupDestination should be used when inherit mode is optional. True - derived,
        /// False - Base.
        /// </summary>
        bool? BackupDestination { get; set; }
        /// <summary>
        /// Flag to specify if parent or derived plan rpo should be used when inherit mode is optional. True - derived, False - Base.
        /// </summary>
        bool? Rpo { get; set; }

    }
}