// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class UserGroup
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IUserGroup.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IUserGroup.</returns>
        public static Commvault.Powershell.Models.IUserGroup FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new UserGroup(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="UserGroup" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UserGroup" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._plan ? (Commvault.Powershell.Runtime.Json.JsonNode) this._plan.ToJson(null,serializationMode) : null, "plan" ,container.Add );
            AddIf( null != this._company ? (Commvault.Powershell.Runtime.Json.JsonNode) this._company.ToJson(null,serializationMode) : null, "company" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._guid)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._guid.ToString()) : null, "GUID" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != this._enabled ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._enabled) : null, "enabled" ,container.Add );
            AddIf( null != (((object)this._serviceType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._serviceType.ToString()) : null, "serviceType" ,container.Add );
            AddIf( null != (((object)this._email)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._email.ToString()) : null, "email" ,container.Add );
            AddIf( null != (((object)this._enableTwoFactorAuthentication)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._enableTwoFactorAuthentication.ToString()) : null, "enableTwoFactorAuthentication" ,container.Add );
            if (null != this._associatedExternalGroups)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._associatedExternalGroups )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("associatedExternalGroups",__w);
            }
            AddIf( null != this._laptopAdmins ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._laptopAdmins) : null, "laptopAdmins" ,container.Add );
            if (null != this._associatedLocalGroups)
            {
                var __r = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __s in this._associatedLocalGroups )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("associatedLocalGroups",__r);
            }
            if (null != this._users)
            {
                var __m = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __n in this._users )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("users",__m);
            }
            if (null != this._associatedEntities)
            {
                var __h = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __i in this._associatedEntities )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("associatedEntities",__h);
            }
            if (serializationMode.HasFlag(Commvault.Powershell.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._eligibleToAllowMultipleCompanyMembers ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._eligibleToAllowMultipleCompanyMembers) : null, "eligibleToAllowMultipleCompanyMembers" ,container.Add );
            }
            AddIf( null != this._allowMultipleCompanyMembers ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._allowMultipleCompanyMembers) : null, "allowMultipleCompanyMembers" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="UserGroup" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal UserGroup(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_plan = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("plan"), out var __jsonPlan) ? Commvault.Powershell.Models.IdName.FromJson(__jsonPlan) : Plan;}
            {_company = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("company"), out var __jsonCompany) ? Commvault.Powershell.Models.IdName.FromJson(__jsonCompany) : Company;}
            {_id = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_name = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_guid = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("GUID"), out var __jsonGuid) ? (string)__jsonGuid : (string)Guid;}
            {_description = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_enabled = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("enabled"), out var __jsonEnabled) ? (bool?)__jsonEnabled : Enabled;}
            {_serviceType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("serviceType"), out var __jsonServiceType) ? (string)__jsonServiceType : (string)ServiceType;}
            {_email = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("email"), out var __jsonEmail) ? (string)__jsonEmail : (string)Email;}
            {_enableTwoFactorAuthentication = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("enableTwoFactorAuthentication"), out var __jsonEnableTwoFactorAuthentication) ? (string)__jsonEnableTwoFactorAuthentication : (string)EnableTwoFactorAuthentication;}
            {_associatedExternalGroups = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("associatedExternalGroups"), out var __jsonAssociatedExternalGroups) ? If( __jsonAssociatedExternalGroups as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Commvault.Powershell.Models.IIdName[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.IIdName) (Commvault.Powershell.Models.IdName.FromJson(__u) )) ))() : null : AssociatedExternalGroups;}
            {_laptopAdmins = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("laptopAdmins"), out var __jsonLaptopAdmins) ? (bool?)__jsonLaptopAdmins : LaptopAdmins;}
            {_associatedLocalGroups = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("associatedLocalGroups"), out var __jsonAssociatedLocalGroups) ? If( __jsonAssociatedLocalGroups as Commvault.Powershell.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Commvault.Powershell.Models.IIdName[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Commvault.Powershell.Models.IIdName) (Commvault.Powershell.Models.IdName.FromJson(__p) )) ))() : null : AssociatedLocalGroups;}
            {_users = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("users"), out var __jsonUsers) ? If( __jsonUsers as Commvault.Powershell.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Commvault.Powershell.Models.IIdName[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Commvault.Powershell.Models.IIdName) (Commvault.Powershell.Models.IdName.FromJson(__k) )) ))() : null : Users;}
            {_associatedEntities = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("associatedEntities"), out var __jsonAssociatedEntities) ? If( __jsonAssociatedEntities as Commvault.Powershell.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Commvault.Powershell.Models.IAssocEntity[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Commvault.Powershell.Models.IAssocEntity) (Commvault.Powershell.Models.AssocEntity.FromJson(__f) )) ))() : null : AssociatedEntities;}
            {_eligibleToAllowMultipleCompanyMembers = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("eligibleToAllowMultipleCompanyMembers"), out var __jsonEligibleToAllowMultipleCompanyMembers) ? (bool?)__jsonEligibleToAllowMultipleCompanyMembers : EligibleToAllowMultipleCompanyMembers;}
            {_allowMultipleCompanyMembers = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("allowMultipleCompanyMembers"), out var __jsonAllowMultipleCompanyMembers) ? (bool?)__jsonAllowMultipleCompanyMembers : AllowMultipleCompanyMembers;}
            AfterFromJson(json);
        }
    }
}