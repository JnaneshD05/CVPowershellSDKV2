// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>ModifyEntitySettings</summary>
    public partial class ModifyEntitySettings :
        Commvault.Powershell.Models.IModifyEntitySettings,
        Commvault.Powershell.Models.IModifyEntitySettingsInternal
    {

        /// <summary>Backing field for <see cref="EntitySettings" /> property.</summary>
        private Commvault.Powershell.Models.IModifyEntitySettingsItem[] _entitySettings;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IModifyEntitySettingsItem[] EntitySettings { get => this._entitySettings; set => this._entitySettings = value; }

        /// <summary>Creates an new <see cref="ModifyEntitySettings" /> instance.</summary>
        public ModifyEntitySettings()
        {

        }
    }
    /// ModifyEntitySettings
    public partial interface IModifyEntitySettings :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"entitySettings",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IModifyEntitySettingsItem) })]
        Commvault.Powershell.Models.IModifyEntitySettingsItem[] EntitySettings { get; set; }

    }
    /// ModifyEntitySettings
    internal partial interface IModifyEntitySettingsInternal

    {
        Commvault.Powershell.Models.IModifyEntitySettingsItem[] EntitySettings { get; set; }

    }
}