// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// To allow the derived plans that use this plan as the base plan to override the settings, property allowPlanOverride must
    /// be true, and then select one of the options for Storage pool, RPO and Archiving rules.
    /// </summary>
    public partial class ArchivePlanOverrideSettings :
        Commvault.Powershell.Models.IArchivePlanOverrideSettings,
        Commvault.Powershell.Models.IArchivePlanOverrideSettingsInternal
    {

        /// <summary>Backing field for <see cref="ArchivingRules" /> property.</summary>
        private string _archivingRules;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ArchivingRules { get => this._archivingRules; set => this._archivingRules = value; }

        /// <summary>Backing field for <see cref="Rpo" /> property.</summary>
        private string _rpo;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Rpo { get => this._rpo; set => this._rpo = value; }

        /// <summary>Backing field for <see cref="StoragePool" /> property.</summary>
        private string _storagePool;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string StoragePool { get => this._storagePool; set => this._storagePool = value; }

        /// <summary>Creates an new <see cref="ArchivePlanOverrideSettings" /> instance.</summary>
        public ArchivePlanOverrideSettings()
        {

        }
    }
    /// To allow the derived plans that use this plan as the base plan to override the settings, property allowPlanOverride must
    /// be true, and then select one of the options for Storage pool, RPO and Archiving rules.
    public partial interface IArchivePlanOverrideSettings :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"archivingRules",
        PossibleTypes = new [] { typeof(string) })]
        string ArchivingRules { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"RPO",
        PossibleTypes = new [] { typeof(string) })]
        string Rpo { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"storagePool",
        PossibleTypes = new [] { typeof(string) })]
        string StoragePool { get; set; }

    }
    /// To allow the derived plans that use this plan as the base plan to override the settings, property allowPlanOverride must
    /// be true, and then select one of the options for Storage pool, RPO and Archiving rules.
    internal partial interface IArchivePlanOverrideSettingsInternal

    {
        string ArchivingRules { get; set; }

        string Rpo { get; set; }

        string StoragePool { get; set; }

    }
}