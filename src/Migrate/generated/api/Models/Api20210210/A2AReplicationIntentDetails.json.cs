namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>A2A provider specific settings.</summary>
    public partial class A2AReplicationIntentDetails
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject into a new instance of <see cref="A2AReplicationIntentDetails" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal A2AReplicationIntentDetails(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __replicationProtectionIntentProviderSpecificSettings = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ReplicationProtectionIntentProviderSpecificSettings(json);
            {_protectionProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("protectionProfile"), out var __jsonProtectionProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ProtectionProfileCustomDetails.FromJson(__jsonProtectionProfile) : ProtectionProfile;}
            {_primaryStagingStorageAccount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("primaryStagingStorageAccount"), out var __jsonPrimaryStagingStorageAccount) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetails.FromJson(__jsonPrimaryStagingStorageAccount) : PrimaryStagingStorageAccount;}
            {_recoveryAvailabilitySet = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("recoveryAvailabilitySet"), out var __jsonRecoveryAvailabilitySet) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryAvailabilitySetCustomDetails.FromJson(__jsonRecoveryAvailabilitySet) : RecoveryAvailabilitySet;}
            {_recoveryVirtualNetwork = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("recoveryVirtualNetwork"), out var __jsonRecoveryVirtualNetwork) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryVirtualNetworkCustomDetails.FromJson(__jsonRecoveryVirtualNetwork) : RecoveryVirtualNetwork;}
            {_recoveryProximityPlacementGroup = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("recoveryProximityPlacementGroup"), out var __jsonRecoveryProximityPlacementGroup) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryProximityPlacementGroupCustomDetails.FromJson(__jsonRecoveryProximityPlacementGroup) : RecoveryProximityPlacementGroup;}
            {_recoveryBootDiagStorageAccount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("recoveryBootDiagStorageAccount"), out var __jsonRecoveryBootDiagStorageAccount) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetails.FromJson(__jsonRecoveryBootDiagStorageAccount) : RecoveryBootDiagStorageAccount;}
            {_diskEncryptionInfo = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("diskEncryptionInfo"), out var __jsonDiskEncryptionInfo) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.DiskEncryptionInfo.FromJson(__jsonDiskEncryptionInfo) : DiskEncryptionInfo;}
            {_fabricObjectId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("fabricObjectId"), out var __jsonFabricObjectId) ? (string)__jsonFabricObjectId : (string)FabricObjectId;}
            {_primaryLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("primaryLocation"), out var __jsonPrimaryLocation) ? (string)__jsonPrimaryLocation : (string)PrimaryLocation;}
            {_recoveryLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryLocation"), out var __jsonRecoveryLocation) ? (string)__jsonRecoveryLocation : (string)RecoveryLocation;}
            {_recoverySubscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoverySubscriptionId"), out var __jsonRecoverySubscriptionId) ? (string)__jsonRecoverySubscriptionId : (string)RecoverySubscriptionId;}
            {_vMDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray>("vmDisks"), out var __jsonVMDisks) ? If( __jsonVMDisks as Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails) (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AProtectionIntentDiskInputDetails.FromJson(__u) )) ))() : null : VMDisk;}
            {_vMManagedDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray>("vmManagedDisks"), out var __jsonVMManagedDisks) ? If( __jsonVMManagedDisks as Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentManagedDiskInputDetails[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentManagedDiskInputDetails) (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2AProtectionIntentManagedDiskInputDetails.FromJson(__p) )) ))() : null : VMManagedDisk;}
            {_recoveryResourceGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryResourceGroupId"), out var __jsonRecoveryResourceGroupId) ? (string)__jsonRecoveryResourceGroupId : (string)RecoveryResourceGroupId;}
            {_autoProtectionOfDataDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("autoProtectionOfDataDisk"), out var __jsonAutoProtectionOfDataDisk) ? (string)__jsonAutoProtectionOfDataDisk : (string)AutoProtectionOfDataDisk;}
            {_multiVMGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("multiVmGroupName"), out var __jsonMultiVMGroupName) ? (string)__jsonMultiVMGroupName : (string)MultiVMGroupName;}
            {_multiVMGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("multiVmGroupId"), out var __jsonMultiVMGroupId) ? (string)__jsonMultiVMGroupId : (string)MultiVMGroupId;}
            {_recoveryAvailabilityZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryAvailabilityZone"), out var __jsonRecoveryAvailabilityZone) ? (string)__jsonRecoveryAvailabilityZone : (string)RecoveryAvailabilityZone;}
            {_recoveryAvailabilityType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryAvailabilityType"), out var __jsonRecoveryAvailabilityType) ? (string)__jsonRecoveryAvailabilityType : (string)RecoveryAvailabilityType;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetails.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetails.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AReplicationIntentDetails FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json ? new A2AReplicationIntentDetails(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="A2AReplicationIntentDetails" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="A2AReplicationIntentDetails" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __replicationProtectionIntentProviderSpecificSettings?.ToJson(container, serializationMode);
            AddIf( null != this._protectionProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._protectionProfile.ToJson(null,serializationMode) : null, "protectionProfile" ,container.Add );
            AddIf( null != this._primaryStagingStorageAccount ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._primaryStagingStorageAccount.ToJson(null,serializationMode) : null, "primaryStagingStorageAccount" ,container.Add );
            AddIf( null != this._recoveryAvailabilitySet ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._recoveryAvailabilitySet.ToJson(null,serializationMode) : null, "recoveryAvailabilitySet" ,container.Add );
            AddIf( null != this._recoveryVirtualNetwork ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._recoveryVirtualNetwork.ToJson(null,serializationMode) : null, "recoveryVirtualNetwork" ,container.Add );
            AddIf( null != this._recoveryProximityPlacementGroup ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._recoveryProximityPlacementGroup.ToJson(null,serializationMode) : null, "recoveryProximityPlacementGroup" ,container.Add );
            AddIf( null != this._recoveryBootDiagStorageAccount ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._recoveryBootDiagStorageAccount.ToJson(null,serializationMode) : null, "recoveryBootDiagStorageAccount" ,container.Add );
            AddIf( null != this._diskEncryptionInfo ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._diskEncryptionInfo.ToJson(null,serializationMode) : null, "diskEncryptionInfo" ,container.Add );
            AddIf( null != (((object)this._fabricObjectId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._fabricObjectId.ToString()) : null, "fabricObjectId" ,container.Add );
            AddIf( null != (((object)this._primaryLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._primaryLocation.ToString()) : null, "primaryLocation" ,container.Add );
            AddIf( null != (((object)this._recoveryLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryLocation.ToString()) : null, "recoveryLocation" ,container.Add );
            AddIf( null != (((object)this._recoverySubscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoverySubscriptionId.ToString()) : null, "recoverySubscriptionId" ,container.Add );
            if (null != this._vMDisk)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.XNodeArray();
                foreach( var __x in this._vMDisk )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("vmDisks",__w);
            }
            if (null != this._vMManagedDisk)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.XNodeArray();
                foreach( var __s in this._vMManagedDisk )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("vmManagedDisks",__r);
            }
            AddIf( null != (((object)this._recoveryResourceGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryResourceGroupId.ToString()) : null, "recoveryResourceGroupId" ,container.Add );
            AddIf( null != (((object)this._autoProtectionOfDataDisk)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._autoProtectionOfDataDisk.ToString()) : null, "autoProtectionOfDataDisk" ,container.Add );
            AddIf( null != (((object)this._multiVMGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._multiVMGroupName.ToString()) : null, "multiVmGroupName" ,container.Add );
            AddIf( null != (((object)this._multiVMGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._multiVMGroupId.ToString()) : null, "multiVmGroupId" ,container.Add );
            AddIf( null != (((object)this._recoveryAvailabilityZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryAvailabilityZone.ToString()) : null, "recoveryAvailabilityZone" ,container.Add );
            AddIf( null != (((object)this._recoveryAvailabilityType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryAvailabilityType.ToString()) : null, "recoveryAvailabilityType" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}