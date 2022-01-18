// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>FirewallTopologyDetails</summary>
    [System.ComponentModel.TypeConverter(typeof(FirewallTopologyDetailsTypeConverter))]
    public partial class FirewallTopologyDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.FirewallTopologyDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IFirewallTopologyDetails" />.
        /// </returns>
        public static Commvault.Powershell.Models.IFirewallTopologyDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FirewallTopologyDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.FirewallTopologyDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IFirewallTopologyDetails" />.
        /// </returns>
        public static Commvault.Powershell.Models.IFirewallTopologyDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FirewallTopologyDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.FirewallTopologyDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FirewallTopologyDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).Topology = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Topology",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).Topology, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TopologyType = (string) content.GetValueForProperty("TopologyType",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TopologyType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).ClientType = (string) content.GetValueForProperty("ClientType",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).ClientType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).UseWildCardProxy = (bool?) content.GetValueForProperty("UseWildCardProxy",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).UseWildCardProxy, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).FirewallGroups = (Commvault.Powershell.Models.IFirewallTopologyGroups[]) content.GetValueForProperty("FirewallGroups",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).FirewallGroups, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IFirewallTopologyGroups>(__y, Commvault.Powershell.Models.FirewallTopologyGroupsTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).EncryptTraffic = (bool?) content.GetValueForProperty("EncryptTraffic",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).EncryptTraffic, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TunnelProtocol = (string) content.GetValueForProperty("TunnelProtocol",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TunnelProtocol, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TunnelsPerRoute = (int?) content.GetValueForProperty("TunnelsPerRoute",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TunnelsPerRoute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TopologyId = (int?) content.GetValueForProperty("TopologyId",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TopologyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TopologyName = (string) content.GetValueForProperty("TopologyName",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TopologyName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.FirewallTopologyDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FirewallTopologyDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).Topology = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Topology",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).Topology, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TopologyType = (string) content.GetValueForProperty("TopologyType",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TopologyType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).ClientType = (string) content.GetValueForProperty("ClientType",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).ClientType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).UseWildCardProxy = (bool?) content.GetValueForProperty("UseWildCardProxy",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).UseWildCardProxy, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).FirewallGroups = (Commvault.Powershell.Models.IFirewallTopologyGroups[]) content.GetValueForProperty("FirewallGroups",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).FirewallGroups, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IFirewallTopologyGroups>(__y, Commvault.Powershell.Models.FirewallTopologyGroupsTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).EncryptTraffic = (bool?) content.GetValueForProperty("EncryptTraffic",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).EncryptTraffic, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TunnelProtocol = (string) content.GetValueForProperty("TunnelProtocol",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TunnelProtocol, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TunnelsPerRoute = (int?) content.GetValueForProperty("TunnelsPerRoute",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TunnelsPerRoute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TopologyId = (int?) content.GetValueForProperty("TopologyId",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TopologyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TopologyName = (string) content.GetValueForProperty("TopologyName",((Commvault.Powershell.Models.IFirewallTopologyDetailsInternal)this).TopologyName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FirewallTopologyDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IFirewallTopologyDetails FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FirewallTopologyDetails
    [System.ComponentModel.TypeConverter(typeof(FirewallTopologyDetailsTypeConverter))]
    public partial interface IFirewallTopologyDetails

    {

    }
}