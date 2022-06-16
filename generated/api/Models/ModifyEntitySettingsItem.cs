// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Id and Type of the entity is required in entity property to which the entity setting is to be applied. Type of entity
    /// can be Server or Server group.
    /// </summary>
    public partial class ModifyEntitySettingsItem :
        Commvault.Powershell.Models.IModifyEntitySettingsItem,
        Commvault.Powershell.Models.IModifyEntitySettingsItemInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.IModifyAdditionalSetting" />
        /// </summary>
        private Commvault.Powershell.Models.IModifyAdditionalSetting __modifyAdditionalSetting = new Commvault.Powershell.Models.ModifyAdditionalSetting();

        /// <summary>
        /// Category of the setting to be modified. This cannot be modified but is required to identify the setting for which the
        /// new value is to be set.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Category { get => ((Commvault.Powershell.Models.IModifyAdditionalSettingInternal)__modifyAdditionalSetting).Category; set => ((Commvault.Powershell.Models.IModifyAdditionalSettingInternal)__modifyAdditionalSetting).Category = value; }

        /// <summary>Comment to specify why this value was set for the specified setting</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Comment { get => ((Commvault.Powershell.Models.IModifyAdditionalSettingInternal)__modifyAdditionalSetting).Comment; set => ((Commvault.Powershell.Models.IModifyAdditionalSettingInternal)__modifyAdditionalSetting).Comment = value; }

        /// <summary>Internal Acessors for Entity</summary>
        Commvault.Powershell.Models.IIdType Commvault.Powershell.Models.IModifyEntitySettingsItemInternal.Entity { get => (this._entity = this._entity ?? new Commvault.Powershell.Models.IdType()); set { {_entity = value;} } }

        /// <summary>Backing field for <see cref="Entity" /> property.</summary>
        private Commvault.Powershell.Models.IIdType _entity;

        /// <summary>IdType</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdType Entity { get => (this._entity = this._entity ?? new Commvault.Powershell.Models.IdType()); set => this._entity = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? EntityId { get => ((Commvault.Powershell.Models.IIdTypeInternal)Entity).Id; set => ((Commvault.Powershell.Models.IIdTypeInternal)Entity).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string EntityType { get => ((Commvault.Powershell.Models.IIdTypeInternal)Entity).Type; set => ((Commvault.Powershell.Models.IIdTypeInternal)Entity).Type = value ?? null; }

        /// <summary>
        /// Name of the setting to be modified. This cannot be modified but is required to identify the setting for which the new
        /// value is to be set.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Name { get => ((Commvault.Powershell.Models.IModifyAdditionalSettingInternal)__modifyAdditionalSetting).Name; set => ((Commvault.Powershell.Models.IModifyAdditionalSettingInternal)__modifyAdditionalSetting).Name = value; }

        /// <summary>
        /// New value which will be set for the specified setting, there can be fixed acceptables values for some settings. To get
        /// more details about what are acceptable value for a setting, use GET GlobalSettings or GET EntitySettings.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string NewValue { get => ((Commvault.Powershell.Models.IModifyAdditionalSettingInternal)__modifyAdditionalSetting).NewValue; set => ((Commvault.Powershell.Models.IModifyAdditionalSettingInternal)__modifyAdditionalSetting).NewValue = value; }

        /// <summary>
        /// To reset the value of any already modified setting, set this to true to reset the value and regain default behaviour
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? Reset { get => ((Commvault.Powershell.Models.IModifyAdditionalSettingInternal)__modifyAdditionalSetting).Reset; set => ((Commvault.Powershell.Models.IModifyAdditionalSettingInternal)__modifyAdditionalSetting).Reset = value; }

        /// <summary>
        /// Type of the setting to be modified. This cannot be modified but is required to identify the setting for which the new
        /// value is to be set.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Type { get => ((Commvault.Powershell.Models.IModifyAdditionalSettingInternal)__modifyAdditionalSetting).Type; set => ((Commvault.Powershell.Models.IModifyAdditionalSettingInternal)__modifyAdditionalSetting).Type = value; }

        /// <summary>Creates an new <see cref="ModifyEntitySettingsItem" /> instance.</summary>
        public ModifyEntitySettingsItem()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Commvault.Powershell.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Commvault.Powershell.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__modifyAdditionalSetting), __modifyAdditionalSetting);
            await eventListener.AssertObjectIsValid(nameof(__modifyAdditionalSetting), __modifyAdditionalSetting);
        }
    }
    /// Id and Type of the entity is required in entity property to which the entity setting is to be applied. Type of entity
    /// can be Server or Server group.
    public partial interface IModifyEntitySettingsItem :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.IModifyAdditionalSetting
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? EntityId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string EntityType { get; set; }

    }
    /// Id and Type of the entity is required in entity property to which the entity setting is to be applied. Type of entity
    /// can be Server or Server group.
    internal partial interface IModifyEntitySettingsItemInternal :
        Commvault.Powershell.Models.IModifyAdditionalSettingInternal
    {
        /// <summary>IdType</summary>
        Commvault.Powershell.Models.IIdType Entity { get; set; }

        int? EntityId { get; set; }

        string EntityType { get; set; }

    }
}