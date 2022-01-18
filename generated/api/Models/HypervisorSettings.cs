// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>hypervisorSettings</summary>
    public partial class HypervisorSettings :
        Commvault.Powershell.Models.IHypervisorSettings,
        Commvault.Powershell.Models.IHypervisorSettingsInternal
    {

        /// <summary>Internal Acessors for MetricsMonitoringPolicy</summary>
        Commvault.Powershell.Models.IHypervisorMonitoringPolicy Commvault.Powershell.Models.IHypervisorSettingsInternal.MetricsMonitoringPolicy { get => (this._metricsMonitoringPolicy = this._metricsMonitoringPolicy ?? new Commvault.Powershell.Models.HypervisorMonitoringPolicy()); set { {_metricsMonitoringPolicy = value;} } }

        /// <summary>Internal Acessors for RegionInfo</summary>
        Commvault.Powershell.Models.IRegionInfo Commvault.Powershell.Models.IHypervisorSettingsInternal.RegionInfo { get => (this._regionInfo = this._regionInfo ?? new Commvault.Powershell.Models.RegionInfo()); set { {_regionInfo = value;} } }

        /// <summary>Internal Acessors for TimeZone</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IHypervisorSettingsInternal.TimeZone { get => (this._timeZone = this._timeZone ?? new Commvault.Powershell.Models.IdName()); set { {_timeZone = value;} } }

        /// <summary>Metrics Moitoring PolicyId</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? MetricMonitoringPolicyId { get => ((Commvault.Powershell.Models.IHypervisorMonitoringPolicyInternal)MetricsMonitoringPolicy).Id; set => ((Commvault.Powershell.Models.IHypervisorMonitoringPolicyInternal)MetricsMonitoringPolicy).Id = value ?? default(int); }

        /// <summary>True if Metrics Monioring policy is enabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? MetricMonitoringPolicyIsEnabled { get => ((Commvault.Powershell.Models.IHypervisorMonitoringPolicyInternal)MetricsMonitoringPolicy).IsEnabled; set => ((Commvault.Powershell.Models.IHypervisorMonitoringPolicyInternal)MetricsMonitoringPolicy).IsEnabled = value ?? default(bool); }

        /// <summary>Metrics Moitoring Policy Name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string MetricMonitoringPolicyName { get => ((Commvault.Powershell.Models.IHypervisorMonitoringPolicyInternal)MetricsMonitoringPolicy).Name; set => ((Commvault.Powershell.Models.IHypervisorMonitoringPolicyInternal)MetricsMonitoringPolicy).Name = value ?? null; }

        /// <summary>Backing field for <see cref="MetricsMonitoringPolicy" /> property.</summary>
        private Commvault.Powershell.Models.IHypervisorMonitoringPolicy _metricsMonitoringPolicy;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IHypervisorMonitoringPolicy MetricsMonitoringPolicy { get => (this._metricsMonitoringPolicy = this._metricsMonitoringPolicy ?? new Commvault.Powershell.Models.HypervisorMonitoringPolicy()); set => this._metricsMonitoringPolicy = value; }

        /// <summary>Backing field for <see cref="RegionInfo" /> property.</summary>
        private Commvault.Powershell.Models.IRegionInfo _regionInfo;

        /// <summary>RegionInfo</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IRegionInfo RegionInfo { get => (this._regionInfo = this._regionInfo ?? new Commvault.Powershell.Models.RegionInfo()); set => this._regionInfo = value; }

        /// <summary>Display Name of Region</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RegionInfoDisplayName { get => ((Commvault.Powershell.Models.IRegionInfoInternal)RegionInfo).DisplayName; set => ((Commvault.Powershell.Models.IRegionInfoInternal)RegionInfo).DisplayName = value ?? null; }

        /// <summary>Region Id</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? RegionInfoId { get => ((Commvault.Powershell.Models.IRegionInfoInternal)RegionInfo).Id; set => ((Commvault.Powershell.Models.IRegionInfoInternal)RegionInfo).Id = value ?? default(int); }

        /// <summary>Geolocation Latitude</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RegionInfoLatitude { get => ((Commvault.Powershell.Models.IRegionInfoInternal)RegionInfo).Latitude; set => ((Commvault.Powershell.Models.IRegionInfoInternal)RegionInfo).Latitude = value ?? null; }

        /// <summary>Geolocation Longitude</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RegionInfoLongitude { get => ((Commvault.Powershell.Models.IRegionInfoInternal)RegionInfo).Longitude; set => ((Commvault.Powershell.Models.IRegionInfoInternal)RegionInfo).Longitude = value ?? null; }

        /// <summary>Region Name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RegionInfoName { get => ((Commvault.Powershell.Models.IRegionInfoInternal)RegionInfo).Name; set => ((Commvault.Powershell.Models.IRegionInfoInternal)RegionInfo).Name = value ?? null; }

        /// <summary>Backing field for <see cref="TimeZone" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _timeZone;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName TimeZone { get => (this._timeZone = this._timeZone ?? new Commvault.Powershell.Models.IdName()); set => this._timeZone = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public int? TimeZoneId { get => ((Commvault.Powershell.Models.IIdNameInternal)TimeZone).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)TimeZone).Id = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TimeZoneName { get => ((Commvault.Powershell.Models.IIdNameInternal)TimeZone).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)TimeZone).Name = value ?? null; }

        /// <summary>Creates an new <see cref="HypervisorSettings" /> instance.</summary>
        public HypervisorSettings()
        {

        }
    }
    /// hypervisorSettings
    public partial interface IHypervisorSettings :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Metrics Moitoring PolicyId</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metrics Moitoring PolicyId",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? MetricMonitoringPolicyId { get; set; }
        /// <summary>True if Metrics Monioring policy is enabled</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if Metrics Monioring policy is enabled",
        SerializedName = @"isEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MetricMonitoringPolicyIsEnabled { get; set; }
        /// <summary>Metrics Moitoring Policy Name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metrics Moitoring Policy Name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string MetricMonitoringPolicyName { get; set; }
        /// <summary>Display Name of Region</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display Name of Region",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string RegionInfoDisplayName { get; set; }
        /// <summary>Region Id</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Region Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? RegionInfoId { get; set; }
        /// <summary>Geolocation Latitude</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Geolocation Latitude",
        SerializedName = @"latitude",
        PossibleTypes = new [] { typeof(string) })]
        string RegionInfoLatitude { get; set; }
        /// <summary>Geolocation Longitude</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Geolocation Longitude",
        SerializedName = @"longitude",
        PossibleTypes = new [] { typeof(string) })]
        string RegionInfoLongitude { get; set; }
        /// <summary>Region Name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Region Name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string RegionInfoName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(int) })]
        int? TimeZoneId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string TimeZoneName { get; set; }

    }
    /// hypervisorSettings
    internal partial interface IHypervisorSettingsInternal

    {
        /// <summary>Metrics Moitoring PolicyId</summary>
        int? MetricMonitoringPolicyId { get; set; }
        /// <summary>True if Metrics Monioring policy is enabled</summary>
        bool? MetricMonitoringPolicyIsEnabled { get; set; }
        /// <summary>Metrics Moitoring Policy Name</summary>
        string MetricMonitoringPolicyName { get; set; }

        Commvault.Powershell.Models.IHypervisorMonitoringPolicy MetricsMonitoringPolicy { get; set; }
        /// <summary>RegionInfo</summary>
        Commvault.Powershell.Models.IRegionInfo RegionInfo { get; set; }
        /// <summary>Display Name of Region</summary>
        string RegionInfoDisplayName { get; set; }
        /// <summary>Region Id</summary>
        int? RegionInfoId { get; set; }
        /// <summary>Geolocation Latitude</summary>
        string RegionInfoLatitude { get; set; }
        /// <summary>Geolocation Longitude</summary>
        string RegionInfoLongitude { get; set; }
        /// <summary>Region Name</summary>
        string RegionInfoName { get; set; }

        Commvault.Powershell.Models.IIdName TimeZone { get; set; }

        int? TimeZoneId { get; set; }

        string TimeZoneName { get; set; }

    }
}