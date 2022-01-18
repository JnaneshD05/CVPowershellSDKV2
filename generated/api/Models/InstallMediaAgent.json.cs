// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class InstallMediaAgent
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IInstallMediaAgent.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IInstallMediaAgent.</returns>
        public static Commvault.Powershell.Models.IInstallMediaAgent FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new InstallMediaAgent(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="InstallMediaAgent" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal InstallMediaAgent(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_hostNames = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("hostNames"), out var __jsonHostNames) ? If( __jsonHostNames as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Commvault.Powershell.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : HostNames;}
            {_username = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("username"), out var __jsonUsername) ? (string)__jsonUsername : (string)Username;}
            {_password = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("password"), out var __jsonPassword) ? (string)__jsonPassword : (string)Password;}
            {_oSType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("OSType"), out var __jsonOSType) ? (string)__jsonOSType : (string)OSType;}
            {_installLocation = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("installLocation"), out var __jsonInstallLocation) ? (string)__jsonInstallLocation : (string)InstallLocation;}
            {_rebootIfRequired = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("rebootIfRequired"), out var __jsonRebootIfRequired) ? (bool?)__jsonRebootIfRequired : RebootIfRequired;}
            {_sshKeyPath = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("SSHKeyPath"), out var __jsonSshKeyPath) ? (string)__jsonSshKeyPath : (string)SshKeyPath;}
            {_sshKeyFilePassphrase = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("SSHKeyFilePassphrase"), out var __jsonSshKeyFilePassphrase) ? (string)__jsonSshKeyFilePassphrase : (string)SshKeyFilePassphrase;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="InstallMediaAgent" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="InstallMediaAgent" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            if (null != this._hostNames)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._hostNames )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("hostNames",__w);
            }
            AddIf( null != (((object)this._username)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._username.ToString()) : null, "username" ,container.Add );
            AddIf( null != (((object)this._password)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._password.ToString()) : null, "password" ,container.Add );
            AddIf( null != (((object)this._oSType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._oSType.ToString()) : null, "OSType" ,container.Add );
            AddIf( null != (((object)this._installLocation)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._installLocation.ToString()) : null, "installLocation" ,container.Add );
            AddIf( null != this._rebootIfRequired ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._rebootIfRequired) : null, "rebootIfRequired" ,container.Add );
            AddIf( null != (((object)this._sshKeyPath)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._sshKeyPath.ToString()) : null, "SSHKeyPath" ,container.Add );
            AddIf( null != (((object)this._sshKeyFilePassphrase)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._sshKeyFilePassphrase.ToString()) : null, "SSHKeyFilePassphrase" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}