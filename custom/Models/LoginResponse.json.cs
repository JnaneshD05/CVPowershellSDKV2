// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6262, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>LoginResponse</summary>
    public partial class LoginResponse
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.ILoginResponse.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.ILoginResponse.</returns>
        public static Commvault.Powershell.Models.ILoginResponse FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new LoginResponse(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="LoginResponse" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal LoginResponse(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_aliasName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("aliasName"), out var __jsonAliasName) ? (string)__jsonAliasName : (string)AliasName;}
            {_capability = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("capability"), out var __jsonCapability) ? (float)__jsonCapability : Capability;}
            {_ccn = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("ccn"), out var __jsonCcn) ? (float)__jsonCcn : Ccn;}
            {_errList = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("errList"), out var __jsonErrList) ? If( __jsonErrList as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Commvault.Powershell.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : ErrList;}
            {_forcePasswordChange = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("forcePasswordChange"), out var __jsonForcePasswordChange) ? (bool)__jsonForcePasswordChange : ForcePasswordChange;}
            {_isAccountLocked = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("isAccountLocked"), out var __jsonIsAccountLocked) ? (bool)__jsonIsAccountLocked : IsAccountLocked;}
            {_loginAttempts = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("loginAttempts"), out var __jsonLoginAttempts) ? (float)__jsonLoginAttempts : LoginAttempts;}
            {_providerType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("providerType"), out var __jsonProviderType) ? (float)__jsonProviderType : ProviderType;}
            {_remainingLockTime = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("remainingLockTime"), out var __jsonRemainingLockTime) ? (float)__jsonRemainingLockTime : RemainingLockTime;}
            {_smtpAddress = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("smtpAddress"), out var __jsonSmtpAddress) ? (string)__jsonSmtpAddress : (string)SmtpAddress;}
            {_token = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("token"), out var __jsonToken) ? (string)__jsonToken : (string)Token;}
            {_userGuid = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("userGUID"), out var __jsonUserGuid) ? (string)__jsonUserGuid : (string)UserGuid;}
            {_userName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("userName"), out var __jsonUserName) ? (string)__jsonUserName : (string)UserName;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="LoginResponse" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="LoginResponse" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._aliasName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._aliasName.ToString()) : null, "aliasName" ,container.Add );
            AddIf( (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber(this._capability), "capability" ,container.Add );
            AddIf( (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber(this._ccn), "ccn" ,container.Add );
            if (null != this._errList)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._errList )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("errList",__w);
            }
            AddIf( (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean(this._forcePasswordChange), "forcePasswordChange" ,container.Add );
            AddIf( (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean(this._isAccountLocked), "isAccountLocked" ,container.Add );
            AddIf( (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber(this._loginAttempts), "loginAttempts" ,container.Add );
            AddIf( (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber(this._providerType), "providerType" ,container.Add );
            AddIf( (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber(this._remainingLockTime), "remainingLockTime" ,container.Add );
            AddIf( null != (((object)this._smtpAddress)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._smtpAddress.ToString()) : null, "smtpAddress" ,container.Add );
            AddIf( null != (((object)this._token)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._token.ToString()) : null, "token" ,container.Add );
            AddIf( null != (((object)this._userGuid)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._userGuid.ToString()) : null, "userGUID" ,container.Add );
            AddIf( null != (((object)this._userName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._userName.ToString()) : null, "userName" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}