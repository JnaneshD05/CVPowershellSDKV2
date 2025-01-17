// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>ModifyGlobalSettings</summary>
    public partial class ModifyGlobalSettings :
        Commvault.Powershell.Models.IModifyGlobalSettings,
        Commvault.Powershell.Models.IModifyGlobalSettingsInternal
    {

        /// <summary>Backing field for <see cref="GlobalSettings" /> property.</summary>
        private Commvault.Powershell.Models.IModifyAdditionalSetting[] _globalSettings;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IModifyAdditionalSetting[] GlobalSettings { get => this._globalSettings; set => this._globalSettings = value; }

        /// <summary>Creates an new <see cref="ModifyGlobalSettings" /> instance.</summary>
        public ModifyGlobalSettings()
        {

        }
    }
    /// ModifyGlobalSettings
    public partial interface IModifyGlobalSettings :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"globalSettings",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IModifyAdditionalSetting) })]
        Commvault.Powershell.Models.IModifyAdditionalSetting[] GlobalSettings { get; set; }

    }
    /// ModifyGlobalSettings
    internal partial interface IModifyGlobalSettingsInternal

    {
        Commvault.Powershell.Models.IModifyAdditionalSetting[] GlobalSettings { get; set; }

    }
}