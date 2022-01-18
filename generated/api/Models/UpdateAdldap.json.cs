// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Update the properties of an AD/LDAP</summary>
    public partial class UpdateAdldap
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IUpdateAdldap.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IUpdateAdldap.</returns>
        public static Commvault.Powershell.Models.IUpdateAdldap FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new UpdateAdldap(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="UpdateAdldap" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UpdateAdldap" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._directoryType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._directoryType.ToString()) : null, "directoryType" ,container.Add );
            AddIf( null != (((object)this._host)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._host.ToString()) : null, "host" ,container.Add );
            AddIf( null != (((object)this._osxServerName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._osxServerName.ToString()) : null, "OSXServerName" ,container.Add );
            AddIf( null != (((object)this._netbiosName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._netbiosName.ToString()) : null, "NETBIOSName" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._username)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._username.ToString()) : null, "username" ,container.Add );
            AddIf( null != (((object)this._password)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._password.ToString()) : null, "password" ,container.Add );
            AddIf( null != (((object)this._baseDnForCardUsers)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._baseDnForCardUsers.ToString()) : null, "baseDNForCardUsers" ,container.Add );
            AddIf( null != this._useSecureLdap ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._useSecureLdap) : null, "useSecureLDAP" ,container.Add );
            AddIf( null != this._enableSso ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._enableSso) : null, "enableSSO" ,container.Add );
            AddIf( null != this._accessViaClient ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._accessViaClient) : null, "accessViaClient" ,container.Add );
            if (null != this._proxies)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._proxies )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("proxies",__w);
            }
            if (null != this._ldapQueryParameters)
            {
                var __r = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __s in this._ldapQueryParameters )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("LDAPQueryParameters",__r);
            }
            if (null != this._attributeMap)
            {
                var __m = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __n in this._attributeMap )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("attributeMap",__m);
            }
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="UpdateAdldap" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal UpdateAdldap(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_directoryType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("directoryType"), out var __jsonDirectoryType) ? (string)__jsonDirectoryType : (string)DirectoryType;}
            {_host = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("host"), out var __jsonHost) ? (string)__jsonHost : (string)Host;}
            {_osxServerName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("OSXServerName"), out var __jsonOsxServerName) ? (string)__jsonOsxServerName : (string)OsxServerName;}
            {_netbiosName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("NETBIOSName"), out var __jsonNetbiosName) ? (string)__jsonNetbiosName : (string)NetbiosName;}
            {_name = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_username = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("username"), out var __jsonUsername) ? (string)__jsonUsername : (string)Username;}
            {_password = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("password"), out var __jsonPassword) ? (string)__jsonPassword : (string)Password;}
            {_baseDnForCardUsers = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("baseDNForCardUsers"), out var __jsonBaseDnForCardUsers) ? (string)__jsonBaseDnForCardUsers : (string)BaseDnForCardUsers;}
            {_useSecureLdap = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("useSecureLDAP"), out var __jsonUseSecureLdap) ? (bool?)__jsonUseSecureLdap : UseSecureLdap;}
            {_enableSso = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("enableSSO"), out var __jsonEnableSso) ? (bool?)__jsonEnableSso : EnableSso;}
            {_accessViaClient = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("accessViaClient"), out var __jsonAccessViaClient) ? (bool?)__jsonAccessViaClient : AccessViaClient;}
            {_proxies = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("proxies"), out var __jsonProxies) ? If( __jsonProxies as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Commvault.Powershell.Models.IIdName[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.IIdName) (Commvault.Powershell.Models.IdName.FromJson(__u) )) ))() : null : Proxies;}
            {_ldapQueryParameters = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("LDAPQueryParameters"), out var __jsonLdapQueryParameters) ? If( __jsonLdapQueryParameters as Commvault.Powershell.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Commvault.Powershell.Models.ILdapAttribute[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Commvault.Powershell.Models.ILdapAttribute) (Commvault.Powershell.Models.LdapAttribute.FromJson(__p) )) ))() : null : LdapQueryParameters;}
            {_attributeMap = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("attributeMap"), out var __jsonAttributeMap) ? If( __jsonAttributeMap as Commvault.Powershell.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Commvault.Powershell.Models.ILdapAttribute[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Commvault.Powershell.Models.ILdapAttribute) (Commvault.Powershell.Models.LdapAttribute.FromJson(__k) )) ))() : null : AttributeMap;}
            AfterFromJson(json);
        }
    }
}