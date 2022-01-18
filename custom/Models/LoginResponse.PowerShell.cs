// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6262, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>LoginResponse</summary>
    [System.ComponentModel.TypeConverter(typeof(LoginResponseTypeConverter))]
    public partial class LoginResponse
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.LoginResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ILoginResponse" />.</returns>
        public static Commvault.Powershell.Models.ILoginResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LoginResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.LoginResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ILoginResponse" />.</returns>
        public static Commvault.Powershell.Models.ILoginResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LoginResponse(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LoginResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.ILoginResponse FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.LoginResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LoginResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).AliasName = (string) content.GetValueForProperty("AliasName",((Commvault.Powershell.Models.ILoginResponseInternal)this).AliasName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).Capability = (float) content.GetValueForProperty("Capability",((Commvault.Powershell.Models.ILoginResponseInternal)this).Capability, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).Ccn = (float) content.GetValueForProperty("Ccn",((Commvault.Powershell.Models.ILoginResponseInternal)this).Ccn, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).ErrList = (string[]) content.GetValueForProperty("ErrList",((Commvault.Powershell.Models.ILoginResponseInternal)this).ErrList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).ForcePasswordChange = (bool) content.GetValueForProperty("ForcePasswordChange",((Commvault.Powershell.Models.ILoginResponseInternal)this).ForcePasswordChange, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).IsAccountLocked = (bool) content.GetValueForProperty("IsAccountLocked",((Commvault.Powershell.Models.ILoginResponseInternal)this).IsAccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).LoginAttempts = (float) content.GetValueForProperty("LoginAttempts",((Commvault.Powershell.Models.ILoginResponseInternal)this).LoginAttempts, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).ProviderType = (float) content.GetValueForProperty("ProviderType",((Commvault.Powershell.Models.ILoginResponseInternal)this).ProviderType, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).RemainingLockTime = (float) content.GetValueForProperty("RemainingLockTime",((Commvault.Powershell.Models.ILoginResponseInternal)this).RemainingLockTime, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).SmtpAddress = (string) content.GetValueForProperty("SmtpAddress",((Commvault.Powershell.Models.ILoginResponseInternal)this).SmtpAddress, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).Token = (string) content.GetValueForProperty("Token",((Commvault.Powershell.Models.ILoginResponseInternal)this).Token, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).UserGuid = (string) content.GetValueForProperty("UserGuid",((Commvault.Powershell.Models.ILoginResponseInternal)this).UserGuid, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).UserName = (string) content.GetValueForProperty("UserName",((Commvault.Powershell.Models.ILoginResponseInternal)this).UserName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.LoginResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LoginResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).AliasName = (string) content.GetValueForProperty("AliasName",((Commvault.Powershell.Models.ILoginResponseInternal)this).AliasName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).Capability = (float) content.GetValueForProperty("Capability",((Commvault.Powershell.Models.ILoginResponseInternal)this).Capability, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).Ccn = (float) content.GetValueForProperty("Ccn",((Commvault.Powershell.Models.ILoginResponseInternal)this).Ccn, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).ErrList = (string[]) content.GetValueForProperty("ErrList",((Commvault.Powershell.Models.ILoginResponseInternal)this).ErrList, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).ForcePasswordChange = (bool) content.GetValueForProperty("ForcePasswordChange",((Commvault.Powershell.Models.ILoginResponseInternal)this).ForcePasswordChange, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).IsAccountLocked = (bool) content.GetValueForProperty("IsAccountLocked",((Commvault.Powershell.Models.ILoginResponseInternal)this).IsAccountLocked, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).LoginAttempts = (float) content.GetValueForProperty("LoginAttempts",((Commvault.Powershell.Models.ILoginResponseInternal)this).LoginAttempts, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).ProviderType = (float) content.GetValueForProperty("ProviderType",((Commvault.Powershell.Models.ILoginResponseInternal)this).ProviderType, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).RemainingLockTime = (float) content.GetValueForProperty("RemainingLockTime",((Commvault.Powershell.Models.ILoginResponseInternal)this).RemainingLockTime, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).SmtpAddress = (string) content.GetValueForProperty("SmtpAddress",((Commvault.Powershell.Models.ILoginResponseInternal)this).SmtpAddress, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).Token = (string) content.GetValueForProperty("Token",((Commvault.Powershell.Models.ILoginResponseInternal)this).Token, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).UserGuid = (string) content.GetValueForProperty("UserGuid",((Commvault.Powershell.Models.ILoginResponseInternal)this).UserGuid, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ILoginResponseInternal)this).UserName = (string) content.GetValueForProperty("UserName",((Commvault.Powershell.Models.ILoginResponseInternal)this).UserName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// LoginResponse
    [System.ComponentModel.TypeConverter(typeof(LoginResponseTypeConverter))]
    public partial interface ILoginResponse

    {

    }
}