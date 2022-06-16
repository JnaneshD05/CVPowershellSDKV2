// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Get SAML response</summary>
    public partial class Saml
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.ISaml.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.ISaml.</returns>
        public static Commvault.Powershell.Models.ISaml FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new Saml(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="Saml" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Saml(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_userGroup = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("userGroup"), out var __jsonUserGroup) ? Commvault.Powershell.Models.IdName.FromJson(__jsonUserGroup) : UserGroup;}
            {_createdForCompany = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("createdForCompany"), out var __jsonCreatedForCompany) ? Commvault.Powershell.Models.IdName.FromJson(__jsonCreatedForCompany) : CreatedForCompany;}
            {_identityProviderMetaData = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("identityProviderMetaData"), out var __jsonIdentityProviderMetaData) ? Commvault.Powershell.Models.SamlidpMetaDataResp.FromJson(__jsonIdentityProviderMetaData) : IdentityProviderMetaData;}
            {_serviceProviderMetaData = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("serviceProviderMetaData"), out var __jsonServiceProviderMetaData) ? Commvault.Powershell.Models.SamlspMetaDataResp.FromJson(__jsonServiceProviderMetaData) : ServiceProviderMetaData;}
            {_associations = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("associations"), out var __jsonAssociations) ? Commvault.Powershell.Models.SamlAssociations.FromJson(__jsonAssociations) : Associations;}
            {_name = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_description = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_enabled = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("enabled"), out var __jsonEnabled) ? (bool?)__jsonEnabled : Enabled;}
            {_autoCreateUser = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("autoCreateUser"), out var __jsonAutoCreateUser) ? (bool?)__jsonAutoCreateUser : AutoCreateUser;}
            {_userGroups = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("userGroups"), out var __jsonUserGroups) ? If( __jsonUserGroups as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Commvault.Powershell.Models.ICompanyWithUserGroupAssocDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.ICompanyWithUserGroupAssocDetails) (Commvault.Powershell.Models.CompanyWithUserGroupAssocDetails.FromJson(__u) )) ))() : null : UserGroups;}
            {_nameIdAttribute = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("nameIDAttribute"), out var __jsonNameIdAttribute) ? (string)__jsonNameIdAttribute : (string)NameIdAttribute;}
            {_attributeMappings = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("attributeMappings"), out var __jsonAttributeMappings) ? If( __jsonAttributeMappings as Commvault.Powershell.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Commvault.Powershell.Models.ISamlAttributes[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Commvault.Powershell.Models.ISamlAttributes) (Commvault.Powershell.Models.SamlAttributes.FromJson(__p) )) ))() : null : AttributeMappings;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Saml" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Saml" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._userGroup ? (Commvault.Powershell.Runtime.Json.JsonNode) this._userGroup.ToJson(null,serializationMode) : null, "userGroup" ,container.Add );
            AddIf( null != this._createdForCompany ? (Commvault.Powershell.Runtime.Json.JsonNode) this._createdForCompany.ToJson(null,serializationMode) : null, "createdForCompany" ,container.Add );
            AddIf( null != this._identityProviderMetaData ? (Commvault.Powershell.Runtime.Json.JsonNode) this._identityProviderMetaData.ToJson(null,serializationMode) : null, "identityProviderMetaData" ,container.Add );
            AddIf( null != this._serviceProviderMetaData ? (Commvault.Powershell.Runtime.Json.JsonNode) this._serviceProviderMetaData.ToJson(null,serializationMode) : null, "serviceProviderMetaData" ,container.Add );
            AddIf( null != this._associations ? (Commvault.Powershell.Runtime.Json.JsonNode) this._associations.ToJson(null,serializationMode) : null, "associations" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != this._enabled ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._enabled) : null, "enabled" ,container.Add );
            AddIf( null != this._autoCreateUser ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._autoCreateUser) : null, "autoCreateUser" ,container.Add );
            if (null != this._userGroups)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._userGroups )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("userGroups",__w);
            }
            AddIf( null != (((object)this._nameIdAttribute)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._nameIdAttribute.ToString()) : null, "nameIDAttribute" ,container.Add );
            if (null != this._attributeMappings)
            {
                var __r = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __s in this._attributeMappings )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("attributeMappings",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}