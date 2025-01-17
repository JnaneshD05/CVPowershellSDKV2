// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Gives the summary of the virtual machines.</summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineSummaryTypeConverter))]
    public partial class VirtualMachineSummary
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.VirtualMachineSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IVirtualMachineSummary" />.
        /// </returns>
        public static Commvault.Powershell.Models.IVirtualMachineSummary DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualMachineSummary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.VirtualMachineSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IVirtualMachineSummary" />.
        /// </returns>
        public static Commvault.Powershell.Models.IVirtualMachineSummary DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualMachineSummary(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualMachineSummary" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IVirtualMachineSummary FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.VirtualMachineSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualMachineSummary(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Hypervisor = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Hypervisor",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Hypervisor, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMGroup = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("VMGroup",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMGroup, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackup = (Commvault.Powershell.Models.ILastBackup) content.GetValueForProperty("LastBackup",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackup, Commvault.Powershell.Models.LastBackupTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Plan = (Commvault.Powershell.Models.IPlanIdNameType) content.GetValueForProperty("Plan",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Plan, Commvault.Powershell.Models.PlanIdNameTypeTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Sla = (Commvault.Powershell.Models.IVMSla) content.GetValueForProperty("Sla",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Sla, Commvault.Powershell.Models.VMSlaTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Company = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Company",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Company, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Commcell = (Commvault.Powershell.Models.ICommcellInfo) content.GetValueForProperty("Commcell",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Commcell, Commvault.Powershell.Models.CommcellInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Vendor = (string) content.GetValueForProperty("Vendor",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Vendor, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).OS = (string) content.GetValueForProperty("OS",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).OS, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Host = (string) content.GetValueForProperty("Host",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Host, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMSize = (int?) content.GetValueForProperty("VMSize",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Status = (string) content.GetValueForProperty("Status",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Status, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Uuid = (string) content.GetValueForProperty("Uuid",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Uuid, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CommcellName = (string) content.GetValueForProperty("CommcellName",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CommcellName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).ApplicationSize = (int?) content.GetValueForProperty("ApplicationSize",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).ApplicationSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Tags = (Commvault.Powershell.Models.IIdNameValue[]) content.GetValueForProperty("Tags",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdNameValue>(__y, Commvault.Powershell.Models.IdNameValueTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupTime = (int?) content.GetValueForProperty("LastBackupTime",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupJobId = (int?) content.GetValueForProperty("LastBackupJobId",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupJobId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupFailureReason = (string) content.GetValueForProperty("LastBackupFailureReason",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupFailureReason, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).HypervisorId = (int?) content.GetValueForProperty("HypervisorId",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).HypervisorId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).HypervisorName = (string) content.GetValueForProperty("HypervisorName",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).HypervisorName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMGroupId = (int?) content.GetValueForProperty("VMGroupId",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMGroupId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMGroupName = (string) content.GetValueForProperty("VMGroupName",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMGroupName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupStatus = (string) content.GetValueForProperty("LastBackupStatus",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupLastSuccessfulBackupTime = (int?) content.GetValueForProperty("LastBackupLastSuccessfulBackupTime",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupLastSuccessfulBackupTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).PlanId = (int?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).PlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).PlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).PlanSubType = (string) content.GetValueForProperty("PlanSubType",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).PlanSubType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).SlaStatus = (string) content.GetValueForProperty("SlaStatus",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).SlaStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).SlaReason = (string) content.GetValueForProperty("SlaReason",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).SlaReason, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CompanyId = (int?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CompanyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CompanyName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CommcellInfoName = (string) content.GetValueForProperty("CommcellInfoName",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CommcellInfoName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.VirtualMachineSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualMachineSummary(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Hypervisor = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Hypervisor",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Hypervisor, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMGroup = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("VMGroup",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMGroup, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackup = (Commvault.Powershell.Models.ILastBackup) content.GetValueForProperty("LastBackup",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackup, Commvault.Powershell.Models.LastBackupTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Plan = (Commvault.Powershell.Models.IPlanIdNameType) content.GetValueForProperty("Plan",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Plan, Commvault.Powershell.Models.PlanIdNameTypeTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Sla = (Commvault.Powershell.Models.IVMSla) content.GetValueForProperty("Sla",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Sla, Commvault.Powershell.Models.VMSlaTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Company = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Company",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Company, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Commcell = (Commvault.Powershell.Models.ICommcellInfo) content.GetValueForProperty("Commcell",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Commcell, Commvault.Powershell.Models.CommcellInfoTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Vendor = (string) content.GetValueForProperty("Vendor",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Vendor, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).OS = (string) content.GetValueForProperty("OS",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).OS, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Host = (string) content.GetValueForProperty("Host",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Host, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMSize = (int?) content.GetValueForProperty("VMSize",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Status = (string) content.GetValueForProperty("Status",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Status, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Uuid = (string) content.GetValueForProperty("Uuid",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Uuid, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CommcellName = (string) content.GetValueForProperty("CommcellName",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CommcellName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).ApplicationSize = (int?) content.GetValueForProperty("ApplicationSize",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).ApplicationSize, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Tags = (Commvault.Powershell.Models.IIdNameValue[]) content.GetValueForProperty("Tags",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdNameValue>(__y, Commvault.Powershell.Models.IdNameValueTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupTime = (int?) content.GetValueForProperty("LastBackupTime",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupJobId = (int?) content.GetValueForProperty("LastBackupJobId",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupJobId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupFailureReason = (string) content.GetValueForProperty("LastBackupFailureReason",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupFailureReason, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).HypervisorId = (int?) content.GetValueForProperty("HypervisorId",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).HypervisorId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).HypervisorName = (string) content.GetValueForProperty("HypervisorName",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).HypervisorName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMGroupId = (int?) content.GetValueForProperty("VMGroupId",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMGroupId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMGroupName = (string) content.GetValueForProperty("VMGroupName",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).VMGroupName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupStatus = (string) content.GetValueForProperty("LastBackupStatus",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupLastSuccessfulBackupTime = (int?) content.GetValueForProperty("LastBackupLastSuccessfulBackupTime",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).LastBackupLastSuccessfulBackupTime, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).PlanId = (int?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).PlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).PlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).PlanSubType = (string) content.GetValueForProperty("PlanSubType",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).PlanSubType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).SlaStatus = (string) content.GetValueForProperty("SlaStatus",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).SlaStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).SlaReason = (string) content.GetValueForProperty("SlaReason",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).SlaReason, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CompanyId = (int?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CompanyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CompanyName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CommcellInfoName = (string) content.GetValueForProperty("CommcellInfoName",((Commvault.Powershell.Models.IVirtualMachineSummaryInternal)this).CommcellInfoName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// Gives the summary of the virtual machines.
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineSummaryTypeConverter))]
    public partial interface IVirtualMachineSummary

    {

    }
}