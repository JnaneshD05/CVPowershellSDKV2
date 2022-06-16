// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Oracle Cloud Infrastructure Object Storage</summary>
    public partial class OracleObject
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IOracleObject.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IOracleObject.</returns>
        public static Commvault.Powershell.Models.IOracleObject FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new OracleObject(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="OracleObject" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OracleObject(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __cloudStorage = new Commvault.Powershell.Models.CloudStorage(json);
            __dedupeStorageList = new Commvault.Powershell.Models.DedupeStorageList(json);
            {_cloudType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("cloudType"), out var __jsonCloudType) ? (string)__jsonCloudType : (string)CloudType;}
            {_serviceHost = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("serviceHost"), out var __jsonServiceHost) ? (string)__jsonServiceHost : (string)ServiceHost;}
            {_tenancyOcid = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("tenancyOCID"), out var __jsonTenancyOcid) ? (string)__jsonTenancyOcid : (string)TenancyOcid;}
            {_userOcid = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("userOCID"), out var __jsonUserOcid) ? (string)__jsonUserOcid : (string)UserOcid;}
            {_keyFingerprint = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("keyFingerprint"), out var __jsonKeyFingerprint) ? (string)__jsonKeyFingerprint : (string)KeyFingerprint;}
            {_compartmentName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("compartmentName"), out var __jsonCompartmentName) ? (string)__jsonCompartmentName : (string)CompartmentName;}
            {_pemKeyFilename = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("pemKeyFilename"), out var __jsonPemKeyFilename) ? (string)__jsonPemKeyFilename : (string)PemKeyFilename;}
            {_privateKeyPassword = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("privateKeyPassword"), out var __jsonPrivateKeyPassword) ? (string)__jsonPrivateKeyPassword : (string)PrivateKeyPassword;}
            {_bucket = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("bucket"), out var __jsonBucket) ? (string)__jsonBucket : (string)Bucket;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OracleObject" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OracleObject" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            __cloudStorage?.ToJson(container, serializationMode);
            __dedupeStorageList?.ToJson(container, serializationMode);
            AddIf( null != (((object)this._cloudType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._cloudType.ToString()) : null, "cloudType" ,container.Add );
            AddIf( null != (((object)this._serviceHost)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._serviceHost.ToString()) : null, "serviceHost" ,container.Add );
            AddIf( null != (((object)this._tenancyOcid)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._tenancyOcid.ToString()) : null, "tenancyOCID" ,container.Add );
            AddIf( null != (((object)this._userOcid)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._userOcid.ToString()) : null, "userOCID" ,container.Add );
            AddIf( null != (((object)this._keyFingerprint)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._keyFingerprint.ToString()) : null, "keyFingerprint" ,container.Add );
            AddIf( null != (((object)this._compartmentName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._compartmentName.ToString()) : null, "compartmentName" ,container.Add );
            AddIf( null != (((object)this._pemKeyFilename)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._pemKeyFilename.ToString()) : null, "pemKeyFilename" ,container.Add );
            AddIf( null != (((object)this._privateKeyPassword)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._privateKeyPassword.ToString()) : null, "privateKeyPassword" ,container.Add );
            AddIf( null != (((object)this._bucket)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._bucket.ToString()) : null, "bucket" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}