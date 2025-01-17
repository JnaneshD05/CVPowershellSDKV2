// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>vmDiskFilter</summary>
    public partial class VMDiskFilter :
        Commvault.Powershell.Models.IVMDiskFilter,
        Commvault.Powershell.Models.IVMDiskFilterInternal
    {

        /// <summary>Backing field for <see cref="Condition" /> property.</summary>
        private string _condition;

        /// <summary>Operation type for VM rules/filters</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Condition { get => this._condition; set => this._condition = value; }

        /// <summary>Backing field for <see cref="FilterType" /> property.</summary>
        private string _filterType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string FilterType { get => this._filterType; set => this._filterType = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The string to be filtered</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="VMGuid" /> property.</summary>
        private string _vMGuid;

        /// <summary>
        /// VM Guid of the Virtual Machine whose disk has to be filtered . This is optional. if not given, all disks of name and type
        /// from all Vms added in content will be filtered
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string VMGuid { get => this._vMGuid; set => this._vMGuid = value; }

        /// <summary>Creates an new <see cref="VMDiskFilter" /> instance.</summary>
        public VMDiskFilter()
        {

        }
    }
    /// vmDiskFilter
    public partial interface IVMDiskFilter :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Operation type for VM rules/filters</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operation type for VM rules/filters",
        SerializedName = @"condition",
        PossibleTypes = new [] { typeof(string) })]
        string Condition { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"filterType",
        PossibleTypes = new [] { typeof(string) })]
        string FilterType { get; set; }
        /// <summary>The string to be filtered</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The string to be filtered",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// VM Guid of the Virtual Machine whose disk has to be filtered . This is optional. if not given, all disks of name and type
        /// from all Vms added in content will be filtered
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"VM Guid of the Virtual Machine whose disk has to be filtered . This is optional. if not given, all disks of name and type from all Vms added in content will be filtered",
        SerializedName = @"vmGuid",
        PossibleTypes = new [] { typeof(string) })]
        string VMGuid { get; set; }

    }
    /// vmDiskFilter
    internal partial interface IVMDiskFilterInternal

    {
        /// <summary>Operation type for VM rules/filters</summary>
        string Condition { get; set; }

        string FilterType { get; set; }
        /// <summary>The string to be filtered</summary>
        string Name { get; set; }
        /// <summary>
        /// VM Guid of the Virtual Machine whose disk has to be filtered . This is optional. if not given, all disks of name and type
        /// from all Vms added in content will be filtered
        /// </summary>
        string VMGuid { get; set; }

    }
}