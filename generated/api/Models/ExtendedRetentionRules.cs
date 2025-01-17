// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// If you want to update, specify the whole object. Extended retention rules should be bigger than retention period.
    /// </summary>
    public partial class ExtendedRetentionRules :
        Commvault.Powershell.Models.IExtendedRetentionRules,
        Commvault.Powershell.Models.IExtendedRetentionRulesInternal
    {

        /// <summary>Internal Acessors for FirstExtendedRetentionRule</summary>
        Commvault.Powershell.Models.IPlanRetentionRule Commvault.Powershell.Models.IExtendedRetentionRulesInternal.FirstExtendedRetentionRule { get => (this._firstExtendedRetentionRule = this._firstExtendedRetentionRule ?? new Commvault.Powershell.Models.PlanRetentionRule()); set { {_firstExtendedRetentionRule = value;} } }

        /// <summary>Internal Acessors for SecondExtendedRetentionRule</summary>
        Commvault.Powershell.Models.IPlanRetentionRule Commvault.Powershell.Models.IExtendedRetentionRulesInternal.SecondExtendedRetentionRule { get => (this._secondExtendedRetentionRule = this._secondExtendedRetentionRule ?? new Commvault.Powershell.Models.PlanRetentionRule()); set { {_secondExtendedRetentionRule = value;} } }

        /// <summary>Internal Acessors for ThirdExtendedRetentionRule</summary>
        Commvault.Powershell.Models.IPlanRetentionRule Commvault.Powershell.Models.IExtendedRetentionRulesInternal.ThirdExtendedRetentionRule { get => (this._thirdExtendedRetentionRule = this._thirdExtendedRetentionRule ?? new Commvault.Powershell.Models.PlanRetentionRule()); set { {_thirdExtendedRetentionRule = value;} } }

        /// <summary>Backing field for <see cref="FirstExtendedRetentionRule" /> property.</summary>
        private Commvault.Powershell.Models.IPlanRetentionRule _firstExtendedRetentionRule;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IPlanRetentionRule FirstExtendedRetentionRule { get => (this._firstExtendedRetentionRule = this._firstExtendedRetentionRule ?? new Commvault.Powershell.Models.PlanRetentionRule()); set => this._firstExtendedRetentionRule = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? FirstExtendedRetentionRuleIsInfiniteRetention { get => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)FirstExtendedRetentionRule).IsInfiniteRetention; set => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)FirstExtendedRetentionRule).IsInfiniteRetention = value ?? default(bool); }

        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? FirstExtendedRetentionRuleRetentionPeriodDays { get => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)FirstExtendedRetentionRule).RetentionPeriodDays; set => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)FirstExtendedRetentionRule).RetentionPeriodDays = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string FirstExtendedRetentionRuleType { get => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)FirstExtendedRetentionRule).Type; set => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)FirstExtendedRetentionRule).Type = value ?? null; }

        /// <summary>Backing field for <see cref="SecondExtendedRetentionRule" /> property.</summary>
        private Commvault.Powershell.Models.IPlanRetentionRule _secondExtendedRetentionRule;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IPlanRetentionRule SecondExtendedRetentionRule { get => (this._secondExtendedRetentionRule = this._secondExtendedRetentionRule ?? new Commvault.Powershell.Models.PlanRetentionRule()); set => this._secondExtendedRetentionRule = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? SecondExtendedRetentionRuleIsInfiniteRetention { get => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)SecondExtendedRetentionRule).IsInfiniteRetention; set => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)SecondExtendedRetentionRule).IsInfiniteRetention = value ?? default(bool); }

        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SecondExtendedRetentionRuleRetentionPeriodDays { get => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)SecondExtendedRetentionRule).RetentionPeriodDays; set => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)SecondExtendedRetentionRule).RetentionPeriodDays = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SecondExtendedRetentionRuleType { get => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)SecondExtendedRetentionRule).Type; set => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)SecondExtendedRetentionRule).Type = value ?? null; }

        /// <summary>Backing field for <see cref="ThirdExtendedRetentionRule" /> property.</summary>
        private Commvault.Powershell.Models.IPlanRetentionRule _thirdExtendedRetentionRule;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IPlanRetentionRule ThirdExtendedRetentionRule { get => (this._thirdExtendedRetentionRule = this._thirdExtendedRetentionRule ?? new Commvault.Powershell.Models.PlanRetentionRule()); set => this._thirdExtendedRetentionRule = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ThirdExtendedRetentionRuleIsInfiniteRetention { get => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)ThirdExtendedRetentionRule).IsInfiniteRetention; set => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)ThirdExtendedRetentionRule).IsInfiniteRetention = value ?? default(bool); }

        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? ThirdExtendedRetentionRuleRetentionPeriodDays { get => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)ThirdExtendedRetentionRule).RetentionPeriodDays; set => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)ThirdExtendedRetentionRule).RetentionPeriodDays = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ThirdExtendedRetentionRuleType { get => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)ThirdExtendedRetentionRule).Type; set => ((Commvault.Powershell.Models.IPlanRetentionRuleInternal)ThirdExtendedRetentionRule).Type = value ?? null; }

        /// <summary>Creates an new <see cref="ExtendedRetentionRules" /> instance.</summary>
        public ExtendedRetentionRules()
        {

        }
    }
    /// If you want to update, specify the whole object. Extended retention rules should be bigger than retention period.
    public partial interface IExtendedRetentionRules :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isInfiniteRetention",
        PossibleTypes = new [] { typeof(bool) })]
        bool? FirstExtendedRetentionRuleIsInfiniteRetention { get; set; }
        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.",
        SerializedName = @"retentionPeriodDays",
        PossibleTypes = new [] { typeof(int) })]
        int? FirstExtendedRetentionRuleRetentionPeriodDays { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string FirstExtendedRetentionRuleType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isInfiniteRetention",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SecondExtendedRetentionRuleIsInfiniteRetention { get; set; }
        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.",
        SerializedName = @"retentionPeriodDays",
        PossibleTypes = new [] { typeof(int) })]
        int? SecondExtendedRetentionRuleRetentionPeriodDays { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string SecondExtendedRetentionRuleType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isInfiniteRetention",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ThirdExtendedRetentionRuleIsInfiniteRetention { get; set; }
        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.",
        SerializedName = @"retentionPeriodDays",
        PossibleTypes = new [] { typeof(int) })]
        int? ThirdExtendedRetentionRuleRetentionPeriodDays { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string ThirdExtendedRetentionRuleType { get; set; }

    }
    /// If you want to update, specify the whole object. Extended retention rules should be bigger than retention period.
    internal partial interface IExtendedRetentionRulesInternal

    {
        Commvault.Powershell.Models.IPlanRetentionRule FirstExtendedRetentionRule { get; set; }

        bool? FirstExtendedRetentionRuleIsInfiniteRetention { get; set; }
        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        int? FirstExtendedRetentionRuleRetentionPeriodDays { get; set; }

        string FirstExtendedRetentionRuleType { get; set; }

        Commvault.Powershell.Models.IPlanRetentionRule SecondExtendedRetentionRule { get; set; }

        bool? SecondExtendedRetentionRuleIsInfiniteRetention { get; set; }
        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        int? SecondExtendedRetentionRuleRetentionPeriodDays { get; set; }

        string SecondExtendedRetentionRuleType { get; set; }

        Commvault.Powershell.Models.IPlanRetentionRule ThirdExtendedRetentionRule { get; set; }

        bool? ThirdExtendedRetentionRuleIsInfiniteRetention { get; set; }
        /// <summary>
        /// Default value is 30 days. Infinite retention takes precedence over retentionPeriodDays.
        /// </summary>
        int? ThirdExtendedRetentionRuleRetentionPeriodDays { get; set; }

        string ThirdExtendedRetentionRuleType { get; set; }

    }
}