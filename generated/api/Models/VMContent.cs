// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>RuleContent</summary>
    public partial class VMContent :
        Commvault.Powershell.Models.IVMContent,
        Commvault.Powershell.Models.IVMContentInternal
    {

        /// <summary>Backing field for <see cref="Overwrite" /> property.</summary>
        private bool? _overwrite;

        /// <summary>
        /// True if content in vmgroup has to be overwritten, by default it will append the content
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? Overwrite { get => this._overwrite; set => this._overwrite = value; }

        /// <summary>Backing field for <see cref="RuleGroups" /> property.</summary>
        private Commvault.Powershell.Models.IRuleGroupContent[] _ruleGroups;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IRuleGroupContent[] RuleGroups { get => this._ruleGroups; set => this._ruleGroups = value; }

        /// <summary>Backing field for <see cref="VirtualMachines" /> property.</summary>
        private Commvault.Powershell.Models.IVirtualMachinecontent[] _virtualMachines;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IVirtualMachinecontent[] VirtualMachines { get => this._virtualMachines; set => this._virtualMachines = value; }

        /// <summary>Creates an new <see cref="VMContent" /> instance.</summary>
        public VMContent()
        {

        }
    }
    /// RuleContent
    public partial interface IVMContent :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// True if content in vmgroup has to be overwritten, by default it will append the content
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if content in vmgroup has to be overwritten, by default it will append the content",
        SerializedName = @"overwrite",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Overwrite { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"ruleGroups",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IRuleGroupContent) })]
        Commvault.Powershell.Models.IRuleGroupContent[] RuleGroups { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"virtualMachines",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IVirtualMachinecontent) })]
        Commvault.Powershell.Models.IVirtualMachinecontent[] VirtualMachines { get; set; }

    }
    /// RuleContent
    internal partial interface IVMContentInternal

    {
        /// <summary>
        /// True if content in vmgroup has to be overwritten, by default it will append the content
        /// </summary>
        bool? Overwrite { get; set; }

        Commvault.Powershell.Models.IRuleGroupContent[] RuleGroups { get; set; }

        Commvault.Powershell.Models.IVirtualMachinecontent[] VirtualMachines { get; set; }

    }
}