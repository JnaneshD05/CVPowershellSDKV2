// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>HyperScaleNodeDetails</summary>
    public partial class HyperScaleNodeDetails
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IHyperScaleNodeDetails.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IHyperScaleNodeDetails.</returns>
        public static Commvault.Powershell.Models.IHyperScaleNodeDetails FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new HyperScaleNodeDetails(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="HyperScaleNodeDetails" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal HyperScaleNodeDetails(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_node = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("node"), out var __jsonNode) ? Commvault.Powershell.Models.IdName.FromJson(__jsonNode) : Node;}
            {_diskInformation = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("diskInformation"), out var __jsonDiskInformation) ? Commvault.Powershell.Models.HyperScaleDiskInfo.FromJson(__jsonDiskInformation) : DiskInformation;}
            {_serverInformation = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("serverInformation"), out var __jsonServerInformation) ? Commvault.Powershell.Models.HyperScaleServerInfo.FromJson(__jsonServerInformation) : ServerInformation;}
            {_disks = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("disks"), out var __jsonDisks) ? If( __jsonDisks as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Commvault.Powershell.Models.IHyperScaleNodeDisk[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.IHyperScaleNodeDisk) (Commvault.Powershell.Models.HyperScaleNodeDisk.FromJson(__u) )) ))() : null : Disks;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="HyperScaleNodeDetails" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="HyperScaleNodeDetails" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._node ? (Commvault.Powershell.Runtime.Json.JsonNode) this._node.ToJson(null,serializationMode) : null, "node" ,container.Add );
            AddIf( null != this._diskInformation ? (Commvault.Powershell.Runtime.Json.JsonNode) this._diskInformation.ToJson(null,serializationMode) : null, "diskInformation" ,container.Add );
            AddIf( null != this._serverInformation ? (Commvault.Powershell.Runtime.Json.JsonNode) this._serverInformation.ToJson(null,serializationMode) : null, "serverInformation" ,container.Add );
            if (null != this._disks)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._disks )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("disks",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}