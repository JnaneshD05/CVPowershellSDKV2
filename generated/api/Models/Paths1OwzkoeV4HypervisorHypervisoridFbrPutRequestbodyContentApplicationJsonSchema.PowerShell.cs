// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaTypeConverter))]
    public partial class Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema"
        /// />.
        /// </returns>
        public static Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema"
        /// />.
        /// </returns>
        public static Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema"
        /// />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal)this).Fbrma = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Fbrma",((Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal)this).Fbrma, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal)this).FbrmaId = (int?) content.GetValueForProperty("FbrmaId",((Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal)this).FbrmaId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal)this).FbrmaName = (string) content.GetValueForProperty("FbrmaName",((Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal)this).FbrmaName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal)this).Fbrma = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Fbrma",((Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal)this).Fbrma, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal)this).FbrmaId = (int?) content.GetValueForProperty("FbrmaId",((Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal)this).FbrmaId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal)this).FbrmaName = (string) content.GetValueForProperty("FbrmaName",((Commvault.Powershell.Models.IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaInternal)this).FbrmaName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(Paths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchemaTypeConverter))]
    public partial interface IPaths1OwzkoeV4HypervisorHypervisoridFbrPutRequestbodyContentApplicationJsonSchema

    {

    }
}