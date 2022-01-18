// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Update a hypervisor group with VMWare as the destination vendor</summary>
    [System.ComponentModel.TypeConverter(typeof(UpdateHypervisorGroupVMWareTypeConverter))]
    public partial class UpdateHypervisorGroupVMWare
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.UpdateHypervisorGroupVMWare"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IUpdateHypervisorGroupVMWare" />.
        /// </returns>
        public static Commvault.Powershell.Models.IUpdateHypervisorGroupVMWare DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UpdateHypervisorGroupVMWare(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.UpdateHypervisorGroupVMWare"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IUpdateHypervisorGroupVMWare" />.
        /// </returns>
        public static Commvault.Powershell.Models.IUpdateHypervisorGroupVMWare DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UpdateHypervisorGroupVMWare(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UpdateHypervisorGroupVMWare" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IUpdateHypervisorGroupVMWare FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.UpdateHypervisorGroupVMWare"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UpdateHypervisorGroupVMWare(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).HypervisorType = (string) content.GetValueForProperty("HypervisorType",((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).HypervisorType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).VcenterHostName = (string) content.GetValueForProperty("VcenterHostName",((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).VcenterHostName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).UserName = (string) content.GetValueForProperty("UserName",((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).UserName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).Password = (string) content.GetValueForProperty("Password",((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).Password, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentId = (int?) content.GetValueForProperty("FbrUnixMediaAgentId",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentName = (string) content.GetValueForProperty("FbrUnixMediaAgentName",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableBackup = (bool?) content.GetValueForProperty("ActivityControlEnableBackup",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableBackup, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableRestore = (bool?) content.GetValueForProperty("ActivityControlEnableRestore",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableRestore, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityClientOwners = (string) content.GetValueForProperty("SecurityClientOwners",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityClientOwners, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityAssociatedUserGroups = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("SecurityAssociatedUserGroups",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityAssociatedUserGroups, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgent = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("FbrUnixMediaAgent",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgent, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControl = (Commvault.Powershell.Models.IActivityControlOptions) content.GetValueForProperty("ActivityControl",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControl, Commvault.Powershell.Models.ActivityControlOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).Security = (Commvault.Powershell.Models.IVMHypervisorSecurityProp) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).Security, Commvault.Powershell.Models.VMHypervisorSecurityPropTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).AccessNodes = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("AccessNodes",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).AccessNodes, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).NewName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SkipCredentialValidation = (bool?) content.GetValueForProperty("SkipCredentialValidation",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SkipCredentialValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.UpdateHypervisorGroupVMWare"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UpdateHypervisorGroupVMWare(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).HypervisorType = (string) content.GetValueForProperty("HypervisorType",((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).HypervisorType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).VcenterHostName = (string) content.GetValueForProperty("VcenterHostName",((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).VcenterHostName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).UserName = (string) content.GetValueForProperty("UserName",((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).UserName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).Password = (string) content.GetValueForProperty("Password",((Commvault.Powershell.Models.IUpdateHypervisorGroupVMWareInternal)this).Password, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentId = (int?) content.GetValueForProperty("FbrUnixMediaAgentId",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentName = (string) content.GetValueForProperty("FbrUnixMediaAgentName",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgentName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableBackup = (bool?) content.GetValueForProperty("ActivityControlEnableBackup",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableBackup, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableRestore = (bool?) content.GetValueForProperty("ActivityControlEnableRestore",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControlEnableRestore, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityClientOwners = (string) content.GetValueForProperty("SecurityClientOwners",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityClientOwners, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityAssociatedUserGroups = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("SecurityAssociatedUserGroups",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SecurityAssociatedUserGroups, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgent = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("FbrUnixMediaAgent",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).FbrUnixMediaAgent, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControl = (Commvault.Powershell.Models.IActivityControlOptions) content.GetValueForProperty("ActivityControl",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).ActivityControl, Commvault.Powershell.Models.ActivityControlOptionsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).Security = (Commvault.Powershell.Models.IVMHypervisorSecurityProp) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).Security, Commvault.Powershell.Models.VMHypervisorSecurityPropTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).AccessNodes = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("AccessNodes",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).AccessNodes, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).NewName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SkipCredentialValidation = (bool?) content.GetValueForProperty("SkipCredentialValidation",((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)this).SkipCredentialValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }
    }
    /// Update a hypervisor group with VMWare as the destination vendor
    [System.ComponentModel.TypeConverter(typeof(UpdateHypervisorGroupVMWareTypeConverter))]
    public partial interface IUpdateHypervisorGroupVMWare

    {

    }
}