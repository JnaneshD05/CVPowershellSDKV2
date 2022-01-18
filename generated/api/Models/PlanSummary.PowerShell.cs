// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(PlanSummaryTypeConverter))]
    public partial class PlanSummary
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.PlanSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IPlanSummary" />.</returns>
        public static Commvault.Powershell.Models.IPlanSummary DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PlanSummary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.PlanSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IPlanSummary" />.</returns>
        public static Commvault.Powershell.Models.IPlanSummary DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PlanSummary(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PlanSummary" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IPlanSummary FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.PlanSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PlanSummary(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).Plan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Plan",((Commvault.Powershell.Models.IPlanSummaryInternal)this).Plan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).Company = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Company",((Commvault.Powershell.Models.IPlanSummaryInternal)this).Company, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).PlanType = (string) content.GetValueForProperty("PlanType",((Commvault.Powershell.Models.IPlanSummaryInternal)this).PlanType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).AssociatedEntities = (int?) content.GetValueForProperty("AssociatedEntities",((Commvault.Powershell.Models.IPlanSummaryInternal)this).AssociatedEntities, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).Rpo = (int?) content.GetValueForProperty("Rpo",((Commvault.Powershell.Models.IPlanSummaryInternal)this).Rpo, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).NumberOfCopies = (int?) content.GetValueForProperty("NumberOfCopies",((Commvault.Powershell.Models.IPlanSummaryInternal)this).NumberOfCopies, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).Status = (string) content.GetValueForProperty("Status",((Commvault.Powershell.Models.IPlanSummaryInternal)this).Status, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).MissingEntities = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("MissingEntities",((Commvault.Powershell.Models.IPlanSummaryInternal)this).MissingEntities, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).PlanId = (int?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.IPlanSummaryInternal)this).PlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IPlanSummaryInternal)this).PlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).CompanyId = (int?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IPlanSummaryInternal)this).CompanyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IPlanSummaryInternal)this).CompanyName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.PlanSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PlanSummary(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).Plan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Plan",((Commvault.Powershell.Models.IPlanSummaryInternal)this).Plan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).Company = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Company",((Commvault.Powershell.Models.IPlanSummaryInternal)this).Company, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).PlanType = (string) content.GetValueForProperty("PlanType",((Commvault.Powershell.Models.IPlanSummaryInternal)this).PlanType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).AssociatedEntities = (int?) content.GetValueForProperty("AssociatedEntities",((Commvault.Powershell.Models.IPlanSummaryInternal)this).AssociatedEntities, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).Rpo = (int?) content.GetValueForProperty("Rpo",((Commvault.Powershell.Models.IPlanSummaryInternal)this).Rpo, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).NumberOfCopies = (int?) content.GetValueForProperty("NumberOfCopies",((Commvault.Powershell.Models.IPlanSummaryInternal)this).NumberOfCopies, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).Status = (string) content.GetValueForProperty("Status",((Commvault.Powershell.Models.IPlanSummaryInternal)this).Status, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).MissingEntities = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("MissingEntities",((Commvault.Powershell.Models.IPlanSummaryInternal)this).MissingEntities, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).PlanId = (int?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.IPlanSummaryInternal)this).PlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IPlanSummaryInternal)this).PlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).CompanyId = (int?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IPlanSummaryInternal)this).CompanyId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IPlanSummaryInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IPlanSummaryInternal)this).CompanyName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(PlanSummaryTypeConverter))]
    public partial interface IPlanSummary

    {

    }
}