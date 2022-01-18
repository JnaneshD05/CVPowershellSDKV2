// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class SnapshotCopyMapping :
        Commvault.Powershell.Models.ISnapshotCopyMapping,
        Commvault.Powershell.Models.ISnapshotCopyMappingInternal
    {

        /// <summary>Internal Acessors for Source</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ISnapshotCopyMappingInternal.Source { get => (this._source = this._source ?? new Commvault.Powershell.Models.IdName()); set { {_source = value;} } }

        /// <summary>Internal Acessors for Target</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ISnapshotCopyMappingInternal.Target { get => (this._target = this._target ?? new Commvault.Powershell.Models.IdName()); set { {_target = value;} } }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _source;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Source { get => (this._source = this._source ?? new Commvault.Powershell.Models.IdName()); set => this._source = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SourceId { get => ((Commvault.Powershell.Models.IIdNameInternal)Source).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Source).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SourceName { get => ((Commvault.Powershell.Models.IIdNameInternal)Source).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Source).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _target;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Target { get => (this._target = this._target ?? new Commvault.Powershell.Models.IdName()); set => this._target = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? TargetId { get => ((Commvault.Powershell.Models.IIdNameInternal)Target).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Target).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TargetName { get => ((Commvault.Powershell.Models.IIdNameInternal)Target).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Target).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Vendor" /> property.</summary>
        private string _vendor;

        /// <summary>Snapshot vendors available for Snap Copy mappings</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Vendor { get => this._vendor; set => this._vendor = value; }

        /// <summary>Creates an new <see cref="SnapshotCopyMapping" /> instance.</summary>
        public SnapshotCopyMapping()
        {

        }
    }
    public partial interface ISnapshotCopyMapping :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? SourceId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SourceName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? TargetId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string TargetName { get; set; }
        /// <summary>Snapshot vendors available for Snap Copy mappings</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Snapshot vendors available for Snap Copy mappings",
        SerializedName = @"vendor",
        PossibleTypes = new [] { typeof(string) })]
        string Vendor { get; set; }

    }
    internal partial interface ISnapshotCopyMappingInternal

    {
        Commvault.Powershell.Models.IIdName Source { get; set; }

        int? SourceId { get; set; }

        string SourceName { get; set; }

        Commvault.Powershell.Models.IIdName Target { get; set; }

        int? TargetId { get; set; }

        string TargetName { get; set; }
        /// <summary>Snapshot vendors available for Snap Copy mappings</summary>
        string Vendor { get; set; }

    }
}