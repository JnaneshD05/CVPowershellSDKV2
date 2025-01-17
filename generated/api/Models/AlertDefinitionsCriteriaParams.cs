// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>AlertDefinitionsCriteriaParams</summary>
    public partial class AlertDefinitionsCriteriaParams :
        Commvault.Powershell.Models.IAlertDefinitionsCriteriaParams,
        Commvault.Powershell.Models.IAlertDefinitionsCriteriaParamsInternal
    {

        /// <summary>Backing field for <see cref="ParamIndex" /> property.</summary>
        private int? _paramIndex;

        /// <summary>Param order index</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? ParamIndex { get => this._paramIndex; set => this._paramIndex = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private int? _type;

        /// <summary>Input value type (default 0 = no input required)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Unit" /> property.</summary>
        private int? _unit;

        /// <summary>Unit of the criteria(For eg. :Hrs,min)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Unit { get => this._unit; set => this._unit = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private int? _value;

        /// <summary>Value of the criteria (deefault 0 : if no value required)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="AlertDefinitionsCriteriaParams" /> instance.</summary>
        public AlertDefinitionsCriteriaParams()
        {

        }
    }
    /// AlertDefinitionsCriteriaParams
    public partial interface IAlertDefinitionsCriteriaParams :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Param order index</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Param order index",
        SerializedName = @"paramIndex",
        PossibleTypes = new [] { typeof(int) })]
        int? ParamIndex { get; set; }
        /// <summary>Input value type (default 0 = no input required)</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Input value type (default 0 = no input required)",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(int) })]
        int? Type { get; set; }
        /// <summary>Unit of the criteria(For eg. :Hrs,min)</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Unit of the criteria(For eg. :Hrs,min)",
        SerializedName = @"unit",
        PossibleTypes = new [] { typeof(int) })]
        int? Unit { get; set; }
        /// <summary>Value of the criteria (deefault 0 : if no value required)</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value of the criteria (deefault 0 : if no value required)",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(int) })]
        int? Value { get; set; }

    }
    /// AlertDefinitionsCriteriaParams
    internal partial interface IAlertDefinitionsCriteriaParamsInternal

    {
        /// <summary>Param order index</summary>
        int? ParamIndex { get; set; }
        /// <summary>Input value type (default 0 = no input required)</summary>
        int? Type { get; set; }
        /// <summary>Unit of the criteria(For eg. :Hrs,min)</summary>
        int? Unit { get; set; }
        /// <summary>Value of the criteria (deefault 0 : if no value required)</summary>
        int? Value { get; set; }

    }
}