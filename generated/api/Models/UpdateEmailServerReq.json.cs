// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// None of the fields are mandatory. whichever field is specified should be updated. Rest should be untouched.
    /// </summary>
    public partial class UpdateEmailServerReq
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IUpdateEmailServerReq.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IUpdateEmailServerReq.</returns>
        public static Commvault.Powershell.Models.IUpdateEmailServerReq FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new UpdateEmailServerReq(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="UpdateEmailServerReq" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UpdateEmailServerReq" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._smtpServerName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._smtpServerName.ToString()) : null, "SMTPServerName" ,container.Add );
            AddIf( null != this._smtpPort ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._smtpPort) : null, "SMTPPort" ,container.Add );
            AddIf( null != (((object)this._senderEmail)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._senderEmail.ToString()) : null, "senderEmail" ,container.Add );
            AddIf( null != (((object)this._senderName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._senderName.ToString()) : null, "senderName" ,container.Add );
            AddIf( null != (((object)this._encryptionAlgorithm)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._encryptionAlgorithm.ToString()) : null, "encryptionAlgorithm" ,container.Add );
            AddIf( null != this._useAuthentication ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._useAuthentication) : null, "useAuthentication" ,container.Add );
            AddIf( null != (((object)this._username)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._username.ToString()) : null, "username" ,container.Add );
            AddIf( null != (((object)this._password)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._password.ToString()) : null, "password" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="UpdateEmailServerReq" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal UpdateEmailServerReq(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_smtpServerName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("SMTPServerName"), out var __jsonSmtpServerName) ? (string)__jsonSmtpServerName : (string)SmtpServerName;}
            {_smtpPort = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("SMTPPort"), out var __jsonSmtpPort) ? (int?)__jsonSmtpPort : SmtpPort;}
            {_senderEmail = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("senderEmail"), out var __jsonSenderEmail) ? (string)__jsonSenderEmail : (string)SenderEmail;}
            {_senderName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("senderName"), out var __jsonSenderName) ? (string)__jsonSenderName : (string)SenderName;}
            {_encryptionAlgorithm = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("encryptionAlgorithm"), out var __jsonEncryptionAlgorithm) ? (string)__jsonEncryptionAlgorithm : (string)EncryptionAlgorithm;}
            {_useAuthentication = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("useAuthentication"), out var __jsonUseAuthentication) ? (bool?)__jsonUseAuthentication : UseAuthentication;}
            {_username = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("username"), out var __jsonUsername) ? (string)__jsonUsername : (string)Username;}
            {_password = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("password"), out var __jsonPassword) ? (string)__jsonPassword : (string)Password;}
            AfterFromJson(json);
        }
    }
}