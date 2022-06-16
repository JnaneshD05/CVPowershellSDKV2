// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>EntitySettingsListItem</summary>
    public partial class EntitySettingsListItem :
        Commvault.Powershell.Models.IEntitySettingsListItem,
        Commvault.Powershell.Models.IEntitySettingsListItemInternal
    {

        /// <summary>Backing field for <see cref="AcceptableValues" /> property.</summary>
        private string[] _acceptableValues;

        /// <summary>
        /// Specifies values which are acceptable when modifying the setting value. This will only be returned if there are specific
        /// set of values which can be accepted.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string[] AcceptableValues { get => this._acceptableValues; set => this._acceptableValues = value; }

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private string _category;

        /// <summary>Category to which setting belongs</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Category { get => this._category; set => this._category = value; }

        /// <summary>Backing field for <see cref="DefaultValue" /> property.</summary>
        private string _defaultValue;

        /// <summary>Value used to get default system behaviour</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DefaultValue { get => this._defaultValue; set => this._defaultValue = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the setting</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="IsModified" /> property.</summary>
        private bool? _isModified;

        /// <summary>Specifies if the setting is already modified by the user</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? IsModified { get => this._isModified; set => this._isModified = value; }

        /// <summary>Backing field for <see cref="IsRestartRequired" /> property.</summary>
        private bool? _isRestartRequired;

        /// <summary>
        /// Specifies if it is required to restart the services for any changes to take effect
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? IsRestartRequired { get => this._isRestartRequired; set => this._isRestartRequired = value; }

        /// <summary>Backing field for <see cref="MaxValue" /> property.</summary>
        private int? _maxValue;

        /// <summary>
        /// Specifies maximum value that can be set to modify specified global setting. It is only returned if the setting type is
        /// Integer
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? MaxValue { get => this._maxValue; set => this._maxValue = value; }

        /// <summary>Backing field for <see cref="MinValue" /> property.</summary>
        private int? _minValue;

        /// <summary>
        /// Specifies minimum value that can be set to modify specified global setting. It is only returned if the setting type is
        /// Integer
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? MinValue { get => this._minValue; set => this._minValue = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the setting</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of the setting</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Values" /> property.</summary>
        private Commvault.Powershell.Models.IEntitySettingsValue[] _values;

        /// <summary>EntitySettingsValueArray</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IEntitySettingsValue[] Values { get => this._values; set => this._values = value; }

        /// <summary>Creates an new <see cref="EntitySettingsListItem" /> instance.</summary>
        public EntitySettingsListItem()
        {

        }
    }
    /// EntitySettingsListItem
    public partial interface IEntitySettingsListItem :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies values which are acceptable when modifying the setting value. This will only be returned if there are specific
        /// set of values which can be accepted.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies values which are acceptable when modifying the setting value. This will only be returned if there are specific set of values which can be accepted.",
        SerializedName = @"acceptableValues",
        PossibleTypes = new [] { typeof(string) })]
        string[] AcceptableValues { get; set; }
        /// <summary>Category to which setting belongs</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Category to which setting belongs",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string Category { get; set; }
        /// <summary>Value used to get default system behaviour</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value used to get default system behaviour",
        SerializedName = @"defaultValue",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultValue { get; set; }
        /// <summary>Description of the setting</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the setting",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Specifies if the setting is already modified by the user</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies if the setting is already modified by the user",
        SerializedName = @"isModified",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsModified { get; set; }
        /// <summary>
        /// Specifies if it is required to restart the services for any changes to take effect
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies if it is required to restart the services for any changes to take effect",
        SerializedName = @"isRestartRequired",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsRestartRequired { get; set; }
        /// <summary>
        /// Specifies maximum value that can be set to modify specified global setting. It is only returned if the setting type is
        /// Integer
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies maximum value that can be set to modify specified global setting. It is only returned if the setting type is Integer",
        SerializedName = @"maxValue",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxValue { get; set; }
        /// <summary>
        /// Specifies minimum value that can be set to modify specified global setting. It is only returned if the setting type is
        /// Integer
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies minimum value that can be set to modify specified global setting. It is only returned if the setting type is Integer",
        SerializedName = @"minValue",
        PossibleTypes = new [] { typeof(int) })]
        int? MinValue { get; set; }
        /// <summary>Name of the setting</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the setting",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Type of the setting</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the setting",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }
        /// <summary>EntitySettingsValueArray</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"EntitySettingsValueArray",
        SerializedName = @"values",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IEntitySettingsValue) })]
        Commvault.Powershell.Models.IEntitySettingsValue[] Values { get; set; }

    }
    /// EntitySettingsListItem
    internal partial interface IEntitySettingsListItemInternal

    {
        /// <summary>
        /// Specifies values which are acceptable when modifying the setting value. This will only be returned if there are specific
        /// set of values which can be accepted.
        /// </summary>
        string[] AcceptableValues { get; set; }
        /// <summary>Category to which setting belongs</summary>
        string Category { get; set; }
        /// <summary>Value used to get default system behaviour</summary>
        string DefaultValue { get; set; }
        /// <summary>Description of the setting</summary>
        string Description { get; set; }
        /// <summary>Specifies if the setting is already modified by the user</summary>
        bool? IsModified { get; set; }
        /// <summary>
        /// Specifies if it is required to restart the services for any changes to take effect
        /// </summary>
        bool? IsRestartRequired { get; set; }
        /// <summary>
        /// Specifies maximum value that can be set to modify specified global setting. It is only returned if the setting type is
        /// Integer
        /// </summary>
        int? MaxValue { get; set; }
        /// <summary>
        /// Specifies minimum value that can be set to modify specified global setting. It is only returned if the setting type is
        /// Integer
        /// </summary>
        int? MinValue { get; set; }
        /// <summary>Name of the setting</summary>
        string Name { get; set; }
        /// <summary>Type of the setting</summary>
        string Type { get; set; }
        /// <summary>EntitySettingsValueArray</summary>
        Commvault.Powershell.Models.IEntitySettingsValue[] Values { get; set; }

    }
}