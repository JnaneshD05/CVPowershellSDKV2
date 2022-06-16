// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>BucketResp</summary>
    public partial class BucketsResp :
        Commvault.Powershell.Models.IBucketsResp,
        Commvault.Powershell.Models.IBucketsRespInternal
    {

        /// <summary>Backing field for <see cref="Bucket" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _bucket;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Bucket { get => (this._bucket = this._bucket ?? new Commvault.Powershell.Models.IdName()); set => this._bucket = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? BucketId { get => ((Commvault.Powershell.Models.IIdNameInternal)Bucket).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Bucket).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string BucketName { get => ((Commvault.Powershell.Models.IIdNameInternal)Bucket).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Bucket).Name = value ?? null; }

        /// <summary>Backing field for <see cref="CloudAccessPaths" /> property.</summary>
        private Commvault.Powershell.Models.ICloudAccessPathsResp[] _cloudAccessPaths;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.ICloudAccessPathsResp[] CloudAccessPaths { get => this._cloudAccessPaths; set => this._cloudAccessPaths = value; }

        /// <summary>Backing field for <see cref="CloudBucket" /> property.</summary>
        private string _cloudBucket;

        /// <summary>Name of Bucket</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CloudBucket { get => this._cloudBucket; set => this._cloudBucket = value; }

        /// <summary>Internal Acessors for Bucket</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IBucketsRespInternal.Bucket { get => (this._bucket = this._bucket ?? new Commvault.Powershell.Models.IdName()); set { {_bucket = value;} } }

        /// <summary>Internal Acessors for Configuration</summary>
        Commvault.Powershell.Models.ICloudBucketConfiguration Commvault.Powershell.Models.IBucketsRespInternal.Configuration { get => (this._configuration = this._configuration ?? new Commvault.Powershell.Models.CloudBucketConfiguration()); set { {_configuration = value;} } }

        /// <summary>Internal Acessors for ConfigurationStorageAcceleratorCredentials</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IBucketsRespInternal.ConfigurationStorageAcceleratorCredentials { get => ((Commvault.Powershell.Models.ICloudBucketConfigurationInternal)Configuration).StorageAcceleratorCredentials; set => ((Commvault.Powershell.Models.ICloudBucketConfigurationInternal)Configuration).StorageAcceleratorCredentials = value; }

        /// <summary>Backing field for <see cref="Configuration" /> property.</summary>
        private Commvault.Powershell.Models.ICloudBucketConfiguration _configuration;

        /// <summary>CloudBucketConfiguration</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ICloudBucketConfiguration Configuration { get => (this._configuration = this._configuration ?? new Commvault.Powershell.Models.CloudBucketConfiguration()); set => this._configuration = value; }

        /// <summary>When true, means mount path is enabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ConfigurationEnable { get => ((Commvault.Powershell.Models.ICloudBucketConfigurationInternal)Configuration).Enable; set => ((Commvault.Powershell.Models.ICloudBucketConfigurationInternal)Configuration).Enable = value ?? default(bool); }

        /// <summary>
        /// When true, the deduplicated blocks in the mount path will not be referenced when there are multiple mount paths in the
        /// library.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ConfigurationPrepareForRetirement { get => ((Commvault.Powershell.Models.ICloudBucketConfigurationInternal)Configuration).PrepareForRetirement; set => ((Commvault.Powershell.Models.ICloudBucketConfigurationInternal)Configuration).PrepareForRetirement = value ?? default(bool); }

        /// <summary>
        /// When true, prevents new data writes to backup location by changing number of writers to zero
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ConfigurationPreventNewDataWritesToBackupLocation { get => ((Commvault.Powershell.Models.ICloudBucketConfigurationInternal)Configuration).PreventNewDataWritesToBackupLocation; set => ((Commvault.Powershell.Models.ICloudBucketConfigurationInternal)Configuration).PreventNewDataWritesToBackupLocation = value ?? default(bool); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? StorageAcceleratorCredentialsId { get => ((Commvault.Powershell.Models.ICloudBucketConfigurationInternal)Configuration).StorageAcceleratorCredentialsId; set => ((Commvault.Powershell.Models.ICloudBucketConfigurationInternal)Configuration).StorageAcceleratorCredentialsId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string StorageAcceleratorCredentialsName { get => ((Commvault.Powershell.Models.ICloudBucketConfigurationInternal)Configuration).StorageAcceleratorCredentialsName; set => ((Commvault.Powershell.Models.ICloudBucketConfigurationInternal)Configuration).StorageAcceleratorCredentialsName = value ?? null; }

        /// <summary>Creates an new <see cref="BucketsResp" /> instance.</summary>
        public BucketsResp()
        {

        }
    }
    /// BucketResp
    public partial interface IBucketsResp :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? BucketId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string BucketName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"cloudAccessPaths",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ICloudAccessPathsResp) })]
        Commvault.Powershell.Models.ICloudAccessPathsResp[] CloudAccessPaths { get; set; }
        /// <summary>Name of Bucket</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of Bucket",
        SerializedName = @"cloudBucket",
        PossibleTypes = new [] { typeof(string) })]
        string CloudBucket { get; set; }
        /// <summary>When true, means mount path is enabled</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When true, means mount path is enabled",
        SerializedName = @"enable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ConfigurationEnable { get; set; }
        /// <summary>
        /// When true, the deduplicated blocks in the mount path will not be referenced when there are multiple mount paths in the
        /// library.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When true, the deduplicated blocks in the mount path will not be referenced when there are multiple mount paths in the library.",
        SerializedName = @"prepareForRetirement",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ConfigurationPrepareForRetirement { get; set; }
        /// <summary>
        /// When true, prevents new data writes to backup location by changing number of writers to zero
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When true, prevents new data writes to backup location by changing number of writers to zero",
        SerializedName = @"preventNewDataWritesToBackupLocation",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ConfigurationPreventNewDataWritesToBackupLocation { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? StorageAcceleratorCredentialsId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAcceleratorCredentialsName { get; set; }

    }
    /// BucketResp
    internal partial interface IBucketsRespInternal

    {
        Commvault.Powershell.Models.IIdName Bucket { get; set; }

        int? BucketId { get; set; }

        string BucketName { get; set; }

        Commvault.Powershell.Models.ICloudAccessPathsResp[] CloudAccessPaths { get; set; }
        /// <summary>Name of Bucket</summary>
        string CloudBucket { get; set; }
        /// <summary>CloudBucketConfiguration</summary>
        Commvault.Powershell.Models.ICloudBucketConfiguration Configuration { get; set; }
        /// <summary>When true, means mount path is enabled</summary>
        bool? ConfigurationEnable { get; set; }
        /// <summary>
        /// When true, the deduplicated blocks in the mount path will not be referenced when there are multiple mount paths in the
        /// library.
        /// </summary>
        bool? ConfigurationPrepareForRetirement { get; set; }
        /// <summary>
        /// When true, prevents new data writes to backup location by changing number of writers to zero
        /// </summary>
        bool? ConfigurationPreventNewDataWritesToBackupLocation { get; set; }

        Commvault.Powershell.Models.IIdName ConfigurationStorageAcceleratorCredentials { get; set; }

        int? StorageAcceleratorCredentialsId { get; set; }

        string StorageAcceleratorCredentialsName { get; set; }

    }
}