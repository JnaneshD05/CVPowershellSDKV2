// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Custom validation script to be used during VM backup validation</summary>
    [System.ComponentModel.TypeConverter(typeof(AppValidationScriptTypeConverter))]
    public partial class AppValidationScript
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.AppValidationScript"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AppValidationScript(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).Windows = (Commvault.Powershell.Models.IValidationScript) content.GetValueForProperty("Windows",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).Windows, Commvault.Powershell.Models.ValidationScriptTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).Unix = (Commvault.Powershell.Models.IValidationScript) content.GetValueForProperty("Unix",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).Unix, Commvault.Powershell.Models.ValidationScriptTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowUncCredentials = (Commvault.Powershell.Models.IUserNamePassword) content.GetValueForProperty("WindowUncCredentials",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowUncCredentials, Commvault.Powershell.Models.UserNamePasswordTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowUncSavedCredentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("WindowUncSavedCredentials",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowUncSavedCredentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowPath = (string) content.GetValueForProperty("WindowPath",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowPath, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowArguments = (string) content.GetValueForProperty("WindowArguments",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowArguments, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowIsDisabled = (bool?) content.GetValueForProperty("WindowIsDisabled",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowIsDisabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowIsUnc = (bool?) content.GetValueForProperty("WindowIsUnc",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowIsUnc, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUncCredentials = (Commvault.Powershell.Models.IUserNamePassword) content.GetValueForProperty("UnixUncCredentials",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUncCredentials, Commvault.Powershell.Models.UserNamePasswordTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUncSavedCredentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("UnixUncSavedCredentials",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUncSavedCredentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixPath = (string) content.GetValueForProperty("UnixPath",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixPath, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixArguments = (string) content.GetValueForProperty("UnixArguments",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixArguments, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixIsDisabled = (bool?) content.GetValueForProperty("UnixIsDisabled",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixIsDisabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixIsUnc = (bool?) content.GetValueForProperty("UnixIsUnc",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixIsUnc, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCCredentialsName = (string) content.GetValueForProperty("WindowsUNCCredentialsName",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCCredentialsName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCCredentialsPassword = (string) content.GetValueForProperty("WindowsUNCCredentialsPassword",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCCredentialsPassword, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCSavedCredentialsId = (int?) content.GetValueForProperty("WindowsUNCSavedCredentialsId",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCSavedCredentialsId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCSavedCredentialsName = (string) content.GetValueForProperty("WindowsUNCSavedCredentialsName",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCSavedCredentialsName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCCredentialsName = (string) content.GetValueForProperty("UnixUNCCredentialsName",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCCredentialsName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCCredentialsPassword = (string) content.GetValueForProperty("UnixUNCCredentialsPassword",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCCredentialsPassword, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCSavedCredentialsId = (int?) content.GetValueForProperty("UnixUNCSavedCredentialsId",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCSavedCredentialsId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCSavedCredentialsName = (string) content.GetValueForProperty("UnixUNCSavedCredentialsName",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCSavedCredentialsName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.AppValidationScript"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AppValidationScript(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).Windows = (Commvault.Powershell.Models.IValidationScript) content.GetValueForProperty("Windows",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).Windows, Commvault.Powershell.Models.ValidationScriptTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).Unix = (Commvault.Powershell.Models.IValidationScript) content.GetValueForProperty("Unix",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).Unix, Commvault.Powershell.Models.ValidationScriptTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowUncCredentials = (Commvault.Powershell.Models.IUserNamePassword) content.GetValueForProperty("WindowUncCredentials",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowUncCredentials, Commvault.Powershell.Models.UserNamePasswordTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowUncSavedCredentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("WindowUncSavedCredentials",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowUncSavedCredentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowPath = (string) content.GetValueForProperty("WindowPath",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowPath, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowArguments = (string) content.GetValueForProperty("WindowArguments",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowArguments, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowIsDisabled = (bool?) content.GetValueForProperty("WindowIsDisabled",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowIsDisabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowIsUnc = (bool?) content.GetValueForProperty("WindowIsUnc",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowIsUnc, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUncCredentials = (Commvault.Powershell.Models.IUserNamePassword) content.GetValueForProperty("UnixUncCredentials",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUncCredentials, Commvault.Powershell.Models.UserNamePasswordTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUncSavedCredentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("UnixUncSavedCredentials",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUncSavedCredentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixPath = (string) content.GetValueForProperty("UnixPath",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixPath, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixArguments = (string) content.GetValueForProperty("UnixArguments",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixArguments, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixIsDisabled = (bool?) content.GetValueForProperty("UnixIsDisabled",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixIsDisabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixIsUnc = (bool?) content.GetValueForProperty("UnixIsUnc",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixIsUnc, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCCredentialsName = (string) content.GetValueForProperty("WindowsUNCCredentialsName",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCCredentialsName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCCredentialsPassword = (string) content.GetValueForProperty("WindowsUNCCredentialsPassword",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCCredentialsPassword, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCSavedCredentialsId = (int?) content.GetValueForProperty("WindowsUNCSavedCredentialsId",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCSavedCredentialsId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCSavedCredentialsName = (string) content.GetValueForProperty("WindowsUNCSavedCredentialsName",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).WindowsUNCSavedCredentialsName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCCredentialsName = (string) content.GetValueForProperty("UnixUNCCredentialsName",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCCredentialsName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCCredentialsPassword = (string) content.GetValueForProperty("UnixUNCCredentialsPassword",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCCredentialsPassword, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCSavedCredentialsId = (int?) content.GetValueForProperty("UnixUNCSavedCredentialsId",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCSavedCredentialsId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCSavedCredentialsName = (string) content.GetValueForProperty("UnixUNCSavedCredentialsName",((Commvault.Powershell.Models.IAppValidationScriptInternal)this).UnixUNCSavedCredentialsName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.AppValidationScript"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IAppValidationScript" />.</returns>
        public static Commvault.Powershell.Models.IAppValidationScript DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AppValidationScript(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.AppValidationScript"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IAppValidationScript" />.</returns>
        public static Commvault.Powershell.Models.IAppValidationScript DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AppValidationScript(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AppValidationScript" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IAppValidationScript FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Custom validation script to be used during VM backup validation
    [System.ComponentModel.TypeConverter(typeof(AppValidationScriptTypeConverter))]
    public partial interface IAppValidationScript

    {

    }
}