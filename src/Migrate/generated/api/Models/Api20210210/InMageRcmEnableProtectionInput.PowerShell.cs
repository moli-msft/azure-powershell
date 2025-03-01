namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>InMageRcm specific enable protection input.</summary>
    [System.ComponentModel.TypeConverter(typeof(InMageRcmEnableProtectionInputTypeConverter))]
    public partial class InMageRcmEnableProtectionInput
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmEnableProtectionInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InMageRcmEnableProtectionInput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmEnableProtectionInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInput"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InMageRcmEnableProtectionInput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InMageRcmEnableProtectionInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInput FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmEnableProtectionInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InMageRcmEnableProtectionInput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DisksDefault = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmDisksDefaultInput) content.GetValueForProperty("DisksDefault",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DisksDefault, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmDisksDefaultInputTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).FabricDiscoveryMachineId = (string) content.GetValueForProperty("FabricDiscoveryMachineId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).FabricDiscoveryMachineId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DisksToInclude = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmDiskInput[]) content.GetValueForProperty("DisksToInclude",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DisksToInclude, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmDiskInput>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmDiskInputTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetResourceGroupId = (string) content.GetValueForProperty("TargetResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetNetworkId = (string) content.GetValueForProperty("TargetNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetNetworkId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TestNetworkId = (string) content.GetValueForProperty("TestNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TestNetworkId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetSubnetName = (string) content.GetValueForProperty("TargetSubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetSubnetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TestSubnetName = (string) content.GetValueForProperty("TestSubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TestSubnetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetVMName = (string) content.GetValueForProperty("TargetVMName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetVMName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetVMSize = (string) content.GetValueForProperty("TargetVMSize",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetVMSize, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).LicenseType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType?) content.GetValueForProperty("LicenseType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).LicenseType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetAvailabilitySetId = (string) content.GetValueForProperty("TargetAvailabilitySetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetAvailabilitySetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetAvailabilityZone = (string) content.GetValueForProperty("TargetAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetAvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetProximityPlacementGroupId = (string) content.GetValueForProperty("TargetProximityPlacementGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetProximityPlacementGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetBootDiagnosticsStorageAccountId = (string) content.GetValueForProperty("TargetBootDiagnosticsStorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetBootDiagnosticsStorageAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).RunAsAccountId = (string) content.GetValueForProperty("RunAsAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).RunAsAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).ProcessServerId = (string) content.GetValueForProperty("ProcessServerId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).ProcessServerId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).MultiVMGroupName = (string) content.GetValueForProperty("MultiVMGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).MultiVMGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)this).InstanceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DiskDefaultLogStorageAccountId = (string) content.GetValueForProperty("DiskDefaultLogStorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DiskDefaultLogStorageAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DiskDefaultDiskType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType) content.GetValueForProperty("DiskDefaultDiskType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DiskDefaultDiskType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DiskDefaultDiskEncryptionSetId = (string) content.GetValueForProperty("DiskDefaultDiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DiskDefaultDiskEncryptionSetId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmEnableProtectionInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InMageRcmEnableProtectionInput(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DisksDefault = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmDisksDefaultInput) content.GetValueForProperty("DisksDefault",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DisksDefault, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmDisksDefaultInputTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).FabricDiscoveryMachineId = (string) content.GetValueForProperty("FabricDiscoveryMachineId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).FabricDiscoveryMachineId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DisksToInclude = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmDiskInput[]) content.GetValueForProperty("DisksToInclude",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DisksToInclude, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmDiskInput>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmDiskInputTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetResourceGroupId = (string) content.GetValueForProperty("TargetResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetResourceGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetNetworkId = (string) content.GetValueForProperty("TargetNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetNetworkId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TestNetworkId = (string) content.GetValueForProperty("TestNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TestNetworkId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetSubnetName = (string) content.GetValueForProperty("TargetSubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetSubnetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TestSubnetName = (string) content.GetValueForProperty("TestSubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TestSubnetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetVMName = (string) content.GetValueForProperty("TargetVMName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetVMName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetVMSize = (string) content.GetValueForProperty("TargetVMSize",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetVMSize, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).LicenseType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType?) content.GetValueForProperty("LicenseType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).LicenseType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetAvailabilitySetId = (string) content.GetValueForProperty("TargetAvailabilitySetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetAvailabilitySetId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetAvailabilityZone = (string) content.GetValueForProperty("TargetAvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetAvailabilityZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetProximityPlacementGroupId = (string) content.GetValueForProperty("TargetProximityPlacementGroupId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetProximityPlacementGroupId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetBootDiagnosticsStorageAccountId = (string) content.GetValueForProperty("TargetBootDiagnosticsStorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).TargetBootDiagnosticsStorageAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).RunAsAccountId = (string) content.GetValueForProperty("RunAsAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).RunAsAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).ProcessServerId = (string) content.GetValueForProperty("ProcessServerId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).ProcessServerId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).MultiVMGroupName = (string) content.GetValueForProperty("MultiVMGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).MultiVMGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IEnableProtectionProviderSpecificInputInternal)this).InstanceType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DiskDefaultLogStorageAccountId = (string) content.GetValueForProperty("DiskDefaultLogStorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DiskDefaultLogStorageAccountId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DiskDefaultDiskType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType) content.GetValueForProperty("DiskDefaultDiskType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DiskDefaultDiskType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DiskDefaultDiskEncryptionSetId = (string) content.GetValueForProperty("DiskDefaultDiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmEnableProtectionInputInternal)this).DiskDefaultDiskEncryptionSetId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// InMageRcm specific enable protection input.
    [System.ComponentModel.TypeConverter(typeof(InMageRcmEnableProtectionInputTypeConverter))]
    public partial interface IInMageRcmEnableProtectionInput

    {

    }
}