// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Update a hypervisor group with Ali Baba as the destination vendor</summary>
    [System.ComponentModel.TypeConverter(typeof(UpdateHypervisorGroupAliCloudTypeConverter))]
    public partial class UpdateHypervisorGroupAliCloud
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.UpdateHypervisorGroupAliCloud"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloud" />.
        /// </returns>
        public static Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloud DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UpdateHypervisorGroupAliCloud(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.UpdateHypervisorGroupAliCloud"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloud" />.
        /// </returns>
        public static Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloud DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UpdateHypervisorGroupAliCloud(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UpdateHypervisorGroupAliCloud" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloud FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.UpdateHypervisorGroupAliCloud"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UpdateHypervisorGroupAliCloud(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).HypervisorType = (string) content.GetValueForProperty("HypervisorType",((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).HypervisorType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).AccessKey = (string) content.GetValueForProperty("AccessKey",((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).AccessKey, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).SecretKey = (string) content.GetValueForProperty("SecretKey",((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).SecretKey, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).HostUrl = (string) content.GetValueForProperty("HostUrl",((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).HostUrl, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentId = (int?) content.GetValueForProperty("FbrUnixMediaAgentId",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentName = (string) content.GetValueForProperty("FbrUnixMediaAgentName",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlBackupActivityControlOptions = (Commvault.Powershell.Models.IBackupActivityControlOptionsProp) content.GetValueForProperty("ActivityControlBackupActivityControlOptions",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlBackupActivityControlOptions, Commvault.Powershell.Models.BackupActivityControlOptionsPropTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlRestoreActivityControlOptions = (Commvault.Powershell.Models.IBackupActivityControlOptionsProp) content.GetValueForProperty("ActivityControlRestoreActivityControlOptions",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlRestoreActivityControlOptions, Commvault.Powershell.Models.BackupActivityControlOptionsPropTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableBackup = (bool?) content.GetValueForProperty("ActivityControlEnableBackup",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableBackup, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableRestore = (bool?) content.GetValueForProperty("ActivityControlEnableRestore",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableRestore, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityClientOwners = (string) content.GetValueForProperty("SecurityClientOwners",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityClientOwners, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityAssociatedUserGroups = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("SecurityAssociatedUserGroups",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityAssociatedUserGroups, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionTimeZone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("BackupActivityControlOptionTimeZone",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionTimeZone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionEnableAfterDelay = (bool?) content.GetValueForProperty("BackupActivityControlOptionEnableAfterDelay",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionEnableAfterDelay, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionDelayTime = (string) content.GetValueForProperty("BackupActivityControlOptionDelayTime",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionDelayTime, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionTimeZone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("RestoreActivityControlOptionTimeZone",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionTimeZone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionEnableAfterDelay = (bool?) content.GetValueForProperty("RestoreActivityControlOptionEnableAfterDelay",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionEnableAfterDelay, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionDelayTime = (string) content.GetValueForProperty("RestoreActivityControlOptionDelayTime",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionDelayTime, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionsTimeZoneId = (int?) content.GetValueForProperty("BackupActivityControlOptionsTimeZoneId",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionsTimeZoneId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionsTimeZoneName = (string) content.GetValueForProperty("BackupActivityControlOptionsTimeZoneName",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionsTimeZoneName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionsTimeZoneId = (int?) content.GetValueForProperty("RestoreActivityControlOptionsTimeZoneId",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionsTimeZoneId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionsTimeZoneName = (string) content.GetValueForProperty("RestoreActivityControlOptionsTimeZoneName",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionsTimeZoneName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgent = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("FbrUnixMediaAgent",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgent, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControl = (Commvault.Powershell.Models.IActivityControlOptions) content.GetValueForProperty("ActivityControl",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControl, Commvault.Powershell.Models.ActivityControlOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).Security = (Commvault.Powershell.Models.IVMHypervisorSecurityProp) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).Security, Commvault.Powershell.Models.VMHypervisorSecurityPropTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).AccessNodes = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("AccessNodes",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).AccessNodes, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).NewName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SkipCredentialValidation = (bool?) content.GetValueForProperty("SkipCredentialValidation",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SkipCredentialValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.UpdateHypervisorGroupAliCloud"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UpdateHypervisorGroupAliCloud(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).HypervisorType = (string) content.GetValueForProperty("HypervisorType",((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).HypervisorType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).AccessKey = (string) content.GetValueForProperty("AccessKey",((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).AccessKey, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).SecretKey = (string) content.GetValueForProperty("SecretKey",((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).SecretKey, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).HostUrl = (string) content.GetValueForProperty("HostUrl",((Commvault.Powershell.Models.IUpdateHypervisorGroupAliCloudInternal)this).HostUrl, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentId = (int?) content.GetValueForProperty("FbrUnixMediaAgentId",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentName = (string) content.GetValueForProperty("FbrUnixMediaAgentName",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlBackupActivityControlOptions = (Commvault.Powershell.Models.IBackupActivityControlOptionsProp) content.GetValueForProperty("ActivityControlBackupActivityControlOptions",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlBackupActivityControlOptions, Commvault.Powershell.Models.BackupActivityControlOptionsPropTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlRestoreActivityControlOptions = (Commvault.Powershell.Models.IBackupActivityControlOptionsProp) content.GetValueForProperty("ActivityControlRestoreActivityControlOptions",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlRestoreActivityControlOptions, Commvault.Powershell.Models.BackupActivityControlOptionsPropTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableBackup = (bool?) content.GetValueForProperty("ActivityControlEnableBackup",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableBackup, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableRestore = (bool?) content.GetValueForProperty("ActivityControlEnableRestore",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableRestore, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityClientOwners = (string) content.GetValueForProperty("SecurityClientOwners",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityClientOwners, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityAssociatedUserGroups = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("SecurityAssociatedUserGroups",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityAssociatedUserGroups, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionTimeZone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("BackupActivityControlOptionTimeZone",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionTimeZone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionEnableAfterDelay = (bool?) content.GetValueForProperty("BackupActivityControlOptionEnableAfterDelay",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionEnableAfterDelay, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionDelayTime = (string) content.GetValueForProperty("BackupActivityControlOptionDelayTime",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionDelayTime, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionTimeZone = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("RestoreActivityControlOptionTimeZone",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionTimeZone, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionEnableAfterDelay = (bool?) content.GetValueForProperty("RestoreActivityControlOptionEnableAfterDelay",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionEnableAfterDelay, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionDelayTime = (string) content.GetValueForProperty("RestoreActivityControlOptionDelayTime",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionDelayTime, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionsTimeZoneId = (int?) content.GetValueForProperty("BackupActivityControlOptionsTimeZoneId",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionsTimeZoneId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionsTimeZoneName = (string) content.GetValueForProperty("BackupActivityControlOptionsTimeZoneName",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).BackupActivityControlOptionsTimeZoneName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionsTimeZoneId = (int?) content.GetValueForProperty("RestoreActivityControlOptionsTimeZoneId",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionsTimeZoneId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionsTimeZoneName = (string) content.GetValueForProperty("RestoreActivityControlOptionsTimeZoneName",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).RestoreActivityControlOptionsTimeZoneName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgent = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("FbrUnixMediaAgent",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgent, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControl = (Commvault.Powershell.Models.IActivityControlOptions) content.GetValueForProperty("ActivityControl",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControl, Commvault.Powershell.Models.ActivityControlOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).Security = (Commvault.Powershell.Models.IVMHypervisorSecurityProp) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).Security, Commvault.Powershell.Models.VMHypervisorSecurityPropTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).AccessNodes = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("AccessNodes",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).AccessNodes, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).NewName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SkipCredentialValidation = (bool?) content.GetValueForProperty("SkipCredentialValidation",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SkipCredentialValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }
    }
    /// Update a hypervisor group with Ali Baba as the destination vendor
    [System.ComponentModel.TypeConverter(typeof(UpdateHypervisorGroupAliCloudTypeConverter))]
    public partial interface IUpdateHypervisorGroupAliCloud

    {

    }
}