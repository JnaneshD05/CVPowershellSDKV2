// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class SnapCopyInfo
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.ISnapCopyInfo.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.ISnapCopyInfo.</returns>
        public static Commvault.Powershell.Models.ISnapCopyInfo FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new SnapCopyInfo(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="SnapCopyInfo" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SnapCopyInfo(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_snapEngine = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("snapEngine"), out var __jsonSnapEngine) ? Commvault.Powershell.Models.IdName.FromJson(__jsonSnapEngine) : SnapEngine;}
            {_crossAccountCopyDestinationClient = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("CrossAccountCopyDestinationClient"), out var __jsonCrossAccountCopyDestinationClient) ? Commvault.Powershell.Models.IdName.FromJson(__jsonCrossAccountCopyDestinationClient) : CrossAccountCopyDestinationClient;}
            {_snapMountProxy = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("snapMountProxy"), out var __jsonSnapMountProxy) ? Commvault.Powershell.Models.IdName.FromJson(__jsonSnapMountProxy) : SnapMountProxy;}
            {_enableHardwareSnapshot = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("enableHardwareSnapshot"), out var __jsonEnableHardwareSnapshot) ? (bool?)__jsonEnableHardwareSnapshot : EnableHardwareSnapshot;}
            {_snapMountEsxHost = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("snapMountESXHost"), out var __jsonSnapMountEsxHost) ? (string)__jsonSnapMountEsxHost : (string)SnapMountEsxHost;}
            {_isIndependentDisksEnabled = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("isIndependentDisksEnabled"), out var __jsonIsIndependentDisksEnabled) ? (bool?)__jsonIsIndependentDisksEnabled : IsIndependentDisksEnabled;}
            {_isRawDeviceMapsEnabled = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("isRawDeviceMapsEnabled"), out var __jsonIsRawDeviceMapsEnabled) ? (bool?)__jsonIsRawDeviceMapsEnabled : IsRawDeviceMapsEnabled;}
            {_useSeparateProxyForSnapToTape = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("useSeparateProxyForSnapToTape"), out var __jsonUseSeparateProxyForSnapToTape) ? (bool?)__jsonUseSeparateProxyForSnapToTape : UseSeparateProxyForSnapToTape;}
            {_isCrossAccountEnabled = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("isCrossAccountEnabled"), out var __jsonIsCrossAccountEnabled) ? (bool?)__jsonIsCrossAccountEnabled : IsCrossAccountEnabled;}
            {_isCrossAccountCopyEnabled = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonBoolean>("isCrossAccountCopyEnabled"), out var __jsonIsCrossAccountCopyEnabled) ? (bool?)__jsonIsCrossAccountCopyEnabled : IsCrossAccountCopyEnabled;}
            {_vMApplicationUserName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("vmApplicationUserName"), out var __jsonVMApplicationUserName) ? (string)__jsonVMApplicationUserName : (string)VMApplicationUserName;}
            {_backupCopyInterface = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("backupCopyInterface"), out var __jsonBackupCopyInterface) ? (string)__jsonBackupCopyInterface : (string)BackupCopyInterface;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SnapCopyInfo" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SnapCopyInfo" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._snapEngine ? (Commvault.Powershell.Runtime.Json.JsonNode) this._snapEngine.ToJson(null,serializationMode) : null, "snapEngine" ,container.Add );
            AddIf( null != this._crossAccountCopyDestinationClient ? (Commvault.Powershell.Runtime.Json.JsonNode) this._crossAccountCopyDestinationClient.ToJson(null,serializationMode) : null, "CrossAccountCopyDestinationClient" ,container.Add );
            AddIf( null != this._snapMountProxy ? (Commvault.Powershell.Runtime.Json.JsonNode) this._snapMountProxy.ToJson(null,serializationMode) : null, "snapMountProxy" ,container.Add );
            AddIf( null != this._enableHardwareSnapshot ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._enableHardwareSnapshot) : null, "enableHardwareSnapshot" ,container.Add );
            AddIf( null != (((object)this._snapMountEsxHost)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._snapMountEsxHost.ToString()) : null, "snapMountESXHost" ,container.Add );
            AddIf( null != this._isIndependentDisksEnabled ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._isIndependentDisksEnabled) : null, "isIndependentDisksEnabled" ,container.Add );
            AddIf( null != this._isRawDeviceMapsEnabled ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._isRawDeviceMapsEnabled) : null, "isRawDeviceMapsEnabled" ,container.Add );
            AddIf( null != this._useSeparateProxyForSnapToTape ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._useSeparateProxyForSnapToTape) : null, "useSeparateProxyForSnapToTape" ,container.Add );
            AddIf( null != this._isCrossAccountEnabled ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._isCrossAccountEnabled) : null, "isCrossAccountEnabled" ,container.Add );
            AddIf( null != this._isCrossAccountCopyEnabled ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonBoolean((bool)this._isCrossAccountCopyEnabled) : null, "isCrossAccountCopyEnabled" ,container.Add );
            AddIf( null != (((object)this._vMApplicationUserName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._vMApplicationUserName.ToString()) : null, "vmApplicationUserName" ,container.Add );
            AddIf( null != (((object)this._backupCopyInterface)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._backupCopyInterface.ToString()) : null, "backupCopyInterface" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}