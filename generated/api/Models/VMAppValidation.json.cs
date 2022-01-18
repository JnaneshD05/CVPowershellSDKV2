// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>vmAppValidation</summary>
    public partial class VMAppValidation
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Commvault.Powershell.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Commvault.Powershell.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Commvault.Powershell.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Commvault.Powershell.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Commvault.Powershell.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IVMAppValidation.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IVMAppValidation.</returns>
        public static Commvault.Powershell.Models.IVMAppValidation FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new VMAppValidation(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VMAppValidation" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VMAppValidation" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </returns>
        public Commvault.Powershell.Runtime.Json.JsonNode ToJson(Commvault.Powershell.Runtime.Json.JsonObject container, Commvault.Powershell.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Commvault.Powershell.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._schedule ? (Commvault.Powershell.Runtime.Json.JsonNode) this._schedule.ToJson(null,serializationMode) : null, "schedule" ,container.Add );
            AddIf( null != this._customValidationScript ? (Commvault.Powershell.Runtime.Json.JsonNode) this._customValidationScript.ToJson(null,serializationMode) : null, "customValidationScript" ,container.Add );
            AddIf( null != this._guestCredentials ? (Commvault.Powershell.Runtime.Json.JsonNode) this._guestCredentials.ToJson(null,serializationMode) : null, "guestCredentials" ,container.Add );
            AddIf( null != this._copy ? (Commvault.Powershell.Runtime.Json.JsonNode) this._copy.ToJson(null,serializationMode) : null, "copy" ,container.Add );
            AddIf( null != this._validateVMBackups ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._validateVMBackups) : null, "validateVMBackups" ,container.Add );
            AddIf( null != (((object)this._recoveryTarget)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._recoveryTarget.ToString()) : null, "recoveryTarget" ,container.Add );
            AddIf( null != this._useSourceVMEsxToMount ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._useSourceVMEsxToMount) : null, "useSourceVmESXToMount" ,container.Add );
            AddIf( null != this._keepValidatedVMSRunning ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._keepValidatedVMSRunning) : null, "keepValidatedVMsRunning" ,container.Add );
            AddIf( null != this._maximumNoOfThreads ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._maximumNoOfThreads) : null, "maximumNoOfThreads" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="VMAppValidation" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VMAppValidation(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_schedule = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("schedule"), out var __jsonSchedule) ? Commvault.Powershell.Models.ValidationScheduleObject.FromJson(__jsonSchedule) : Schedule;}
            {_customValidationScript = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("customValidationScript"), out var __jsonCustomValidationScript) ? Commvault.Powershell.Models.AppValidationScript.FromJson(__jsonCustomValidationScript) : CustomValidationScript;}
            {_guestCredentials = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("guestCredentials"), out var __jsonGuestCredentials) ? Commvault.Powershell.Models.GuestCredentialInfo.FromJson(__jsonGuestCredentials) : GuestCredentials;}
            {_copy = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("copy"), out var __jsonCopy) ? Commvault.Powershell.Models.IdName.FromJson(__jsonCopy) : Copy;}
            {_validateVMBackups = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("validateVMBackups"), out var __jsonValidateVMBackups) ? (bool?)__jsonValidateVMBackups : ValidateVMBackups;}
            {_recoveryTarget = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("recoveryTarget"), out var __jsonRecoveryTarget) ? (string)__jsonRecoveryTarget : (string)RecoveryTarget;}
            {_useSourceVMEsxToMount = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("useSourceVmESXToMount"), out var __jsonUseSourceVMEsxToMount) ? (bool?)__jsonUseSourceVMEsxToMount : UseSourceVMEsxToMount;}
            {_keepValidatedVMSRunning = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("keepValidatedVMsRunning"), out var __jsonKeepValidatedVMSRunning) ? (bool?)__jsonKeepValidatedVMSRunning : KeepValidatedVMSRunning;}
            {_maximumNoOfThreads = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("maximumNoOfThreads"), out var __jsonMaximumNoOfThreads) ? (int?)__jsonMaximumNoOfThreads : MaximumNoOfThreads;}
            AfterFromJson(json);
        }
    }
}