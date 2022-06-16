// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class ArchivePlanBackupDestination :
        Commvault.Powershell.Models.IArchivePlanBackupDestination,
        Commvault.Powershell.Models.IArchivePlanBackupDestinationInternal
    {

        /// <summary>Internal Acessors for PlanBackupDestination</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IArchivePlanBackupDestinationInternal.PlanBackupDestination { get => (this._planBackupDestination = this._planBackupDestination ?? new Commvault.Powershell.Models.IdName()); set { {_planBackupDestination = value;} } }

        /// <summary>Internal Acessors for Region</summary>
        Commvault.Powershell.Models.IIdNameDisplayName Commvault.Powershell.Models.IArchivePlanBackupDestinationInternal.Region { get => (this._region = this._region ?? new Commvault.Powershell.Models.IdNameDisplayName()); set { {_region = value;} } }

        /// <summary>Internal Acessors for SourceCopy</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IArchivePlanBackupDestinationInternal.SourceCopy { get => (this._sourceCopy = this._sourceCopy ?? new Commvault.Powershell.Models.IdName()); set { {_sourceCopy = value;} } }

        /// <summary>Internal Acessors for StoragePool</summary>
        Commvault.Powershell.Models.IStoragePool Commvault.Powershell.Models.IArchivePlanBackupDestinationInternal.StoragePool { get => (this._storagePool = this._storagePool ?? new Commvault.Powershell.Models.StoragePool()); set { {_storagePool = value;} } }

        /// <summary>Backing field for <see cref="CopyType" /> property.</summary>
        private string _copyType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CopyType { get => this._copyType; set => this._copyType = value; }

        /// <summary>Backing field for <see cref="CopyTypeName" /> property.</summary>
        private string _copyTypeName;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CopyTypeName { get => this._copyTypeName; set => this._copyTypeName = value; }

        /// <summary>Backing field for <see cref="IsDefault" /> property.</summary>
        private bool? _isDefault;

        /// <summary>Is this a default backup destination?</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? IsDefault { get => this._isDefault; set => this._isDefault = value; }

        /// <summary>Backing field for <see cref="PlanBackupDestination" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _planBackupDestination;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName PlanBackupDestination { get => (this._planBackupDestination = this._planBackupDestination ?? new Commvault.Powershell.Models.IdName()); set => this._planBackupDestination = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? PlanBackupDestinationId { get => ((Commvault.Powershell.Models.IIdNameInternal)PlanBackupDestination).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)PlanBackupDestination).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PlanBackupDestinationName { get => ((Commvault.Powershell.Models.IIdNameInternal)PlanBackupDestination).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)PlanBackupDestination).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private Commvault.Powershell.Models.IIdNameDisplayName _region;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdNameDisplayName Region { get => (this._region = this._region ?? new Commvault.Powershell.Models.IdNameDisplayName()); set => this._region = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RegionDisplayName { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).DisplayName; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).DisplayName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? RegionId { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).Id; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RegionName { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).Name; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Region).Name = value ?? null; }

        /// <summary>Backing field for <see cref="RetentionPeriodDays" /> property.</summary>
        private int? _retentionPeriodDays;

        /// <summary>Retention period in days</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public int? RetentionPeriodDays { get => this._retentionPeriodDays; set => this._retentionPeriodDays = value; }

        /// <summary>Backing field for <see cref="SourceCopy" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _sourceCopy;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName SourceCopy { get => (this._sourceCopy = this._sourceCopy ?? new Commvault.Powershell.Models.IdName()); set => this._sourceCopy = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? SourceCopyId { get => ((Commvault.Powershell.Models.IIdNameInternal)SourceCopy).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)SourceCopy).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SourceCopyName { get => ((Commvault.Powershell.Models.IIdNameInternal)SourceCopy).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)SourceCopy).Name = value ?? null; }

        /// <summary>Backing field for <see cref="StoragePool" /> property.</summary>
        private Commvault.Powershell.Models.IStoragePool _storagePool;

        /// <summary>StoragePool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IStoragePool StoragePool { get => (this._storagePool = this._storagePool ?? new Commvault.Powershell.Models.StoragePool()); set => this._storagePool = value; }

        /// <summary>Id of Storage Pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? StoragePoolId { get => ((Commvault.Powershell.Models.IStoragePoolInternal)StoragePool).Id; set => ((Commvault.Powershell.Models.IStoragePoolInternal)StoragePool).Id = value ?? default(int); }

        /// <summary>Name of Storage Pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string StoragePoolName { get => ((Commvault.Powershell.Models.IStoragePoolInternal)StoragePool).Name; set => ((Commvault.Powershell.Models.IStoragePoolInternal)StoragePool).Name = value ?? null; }

        /// <summary>Type of Storage Pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string StoragePoolType { get => ((Commvault.Powershell.Models.IStoragePoolInternal)StoragePool).Type; set => ((Commvault.Powershell.Models.IStoragePoolInternal)StoragePool).Type = value ?? null; }

        /// <summary>Backing field for <see cref="StorageType" /> property.</summary>
        private string _storageType;

        /// <summary>StorageType</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string StorageType { get => this._storageType; set => this._storageType = value; }

        /// <summary>Creates an new <see cref="ArchivePlanBackupDestination" /> instance.</summary>
        public ArchivePlanBackupDestination()
        {

        }
    }
    public partial interface IArchivePlanBackupDestination :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"copyType",
        PossibleTypes = new [] { typeof(string) })]
        string CopyType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"copyTypeName",
        PossibleTypes = new [] { typeof(string) })]
        string CopyTypeName { get; set; }
        /// <summary>Is this a default backup destination?</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is this a default backup destination?",
        SerializedName = @"isDefault",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDefault { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? PlanBackupDestinationId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string PlanBackupDestinationName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string RegionDisplayName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? RegionId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string RegionName { get; set; }
        /// <summary>Retention period in days</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Retention period in days",
        SerializedName = @"retentionPeriodDays",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionPeriodDays { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? SourceCopyId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SourceCopyName { get; set; }
        /// <summary>Id of Storage Pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of Storage Pool",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? StoragePoolId { get; set; }
        /// <summary>Name of Storage Pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of Storage Pool",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string StoragePoolName { get; set; }
        /// <summary>Type of Storage Pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of Storage Pool",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string StoragePoolType { get; set; }
        /// <summary>StorageType</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"StorageType",
        SerializedName = @"storageType",
        PossibleTypes = new [] { typeof(string) })]
        string StorageType { get; set; }

    }
    internal partial interface IArchivePlanBackupDestinationInternal

    {
        string CopyType { get; set; }

        string CopyTypeName { get; set; }
        /// <summary>Is this a default backup destination?</summary>
        bool? IsDefault { get; set; }

        Commvault.Powershell.Models.IIdName PlanBackupDestination { get; set; }

        int? PlanBackupDestinationId { get; set; }

        string PlanBackupDestinationName { get; set; }

        Commvault.Powershell.Models.IIdNameDisplayName Region { get; set; }

        string RegionDisplayName { get; set; }

        int? RegionId { get; set; }

        string RegionName { get; set; }
        /// <summary>Retention period in days</summary>
        int? RetentionPeriodDays { get; set; }

        Commvault.Powershell.Models.IIdName SourceCopy { get; set; }

        int? SourceCopyId { get; set; }

        string SourceCopyName { get; set; }
        /// <summary>StoragePool</summary>
        Commvault.Powershell.Models.IStoragePool StoragePool { get; set; }
        /// <summary>Id of Storage Pool</summary>
        int? StoragePoolId { get; set; }
        /// <summary>Name of Storage Pool</summary>
        string StoragePoolName { get; set; }
        /// <summary>Type of Storage Pool</summary>
        string StoragePoolType { get; set; }
        /// <summary>StorageType</summary>
        string StorageType { get; set; }

    }
}