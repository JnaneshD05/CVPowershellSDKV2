// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>vmGroupPreviewReq</summary>
    public partial class VMGroupPreviewReq :
        Commvault.Powershell.Models.IVMGroupPreviewReq,
        Commvault.Powershell.Models.IVMGroupPreviewReqInternal
    {

        /// <summary>Internal Acessors for Content</summary>
        Commvault.Powershell.Models.IVMContent Commvault.Powershell.Models.IVMGroupPreviewReqInternal.Content { get => (this._content = this._content ?? new Commvault.Powershell.Models.VMContent()); set { {_content = value;} } }

        /// <summary>Backing field for <see cref="Content" /> property.</summary>
        private Commvault.Powershell.Models.IVMContent _content;

        /// <summary>RuleContent</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IVMContent Content { get => (this._content = this._content ?? new Commvault.Powershell.Models.VMContent()); set => this._content = value; }

        /// <summary>
        /// True if content in vmgroup has to be overwritten, by default it will append the content
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ContentOverwrite { get => ((Commvault.Powershell.Models.IVMContentInternal)Content).Overwrite; set => ((Commvault.Powershell.Models.IVMContentInternal)Content).Overwrite = value ?? default(bool); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IRuleGroupContent[] ContentRuleGroups { get => ((Commvault.Powershell.Models.IVMContentInternal)Content).RuleGroups; set => ((Commvault.Powershell.Models.IVMContentInternal)Content).RuleGroups = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IVirtualMachinecontent[] ContentVirtualMachines { get => ((Commvault.Powershell.Models.IVMContentInternal)Content).VirtualMachines; set => ((Commvault.Powershell.Models.IVMContentInternal)Content).VirtualMachines = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="VMGroupPreviewReq" /> instance.</summary>
        public VMGroupPreviewReq()
        {

        }
    }
    /// vmGroupPreviewReq
    public partial interface IVMGroupPreviewReq :
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
        bool? ContentOverwrite { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"ruleGroups",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IRuleGroupContent) })]
        Commvault.Powershell.Models.IRuleGroupContent[] ContentRuleGroups { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"virtualMachines",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IVirtualMachinecontent) })]
        Commvault.Powershell.Models.IVirtualMachinecontent[] ContentVirtualMachines { get; set; }

    }
    /// vmGroupPreviewReq
    internal partial interface IVMGroupPreviewReqInternal

    {
        /// <summary>RuleContent</summary>
        Commvault.Powershell.Models.IVMContent Content { get; set; }
        /// <summary>
        /// True if content in vmgroup has to be overwritten, by default it will append the content
        /// </summary>
        bool? ContentOverwrite { get; set; }

        Commvault.Powershell.Models.IRuleGroupContent[] ContentRuleGroups { get; set; }

        Commvault.Powershell.Models.IVirtualMachinecontent[] ContentVirtualMachines { get; set; }

    }
}