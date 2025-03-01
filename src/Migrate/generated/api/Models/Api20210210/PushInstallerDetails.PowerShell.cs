namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>Push installer details.</summary>
    [System.ComponentModel.TypeConverter(typeof(PushInstallerDetailsTypeConverter))]
    public partial class PushInstallerDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.PushInstallerDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PushInstallerDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.PushInstallerDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PushInstallerDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PushInstallerDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.PushInstallerDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PushInstallerDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).BiosId = (string) content.GetValueForProperty("BiosId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).BiosId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).FabricObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Fqdn = (string) content.GetValueForProperty("Fqdn",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Fqdn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).LastHeartbeatUtc = (global::System.DateTime?) content.GetValueForProperty("LastHeartbeatUtc",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).LastHeartbeatUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Health = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth?) content.GetValueForProperty("Health",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Health, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).HealthError = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[]) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).HealthError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HealthErrorTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.PushInstallerDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PushInstallerDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).BiosId = (string) content.GetValueForProperty("BiosId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).BiosId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).FabricObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Fqdn = (string) content.GetValueForProperty("Fqdn",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Fqdn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Version, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).LastHeartbeatUtc = (global::System.DateTime?) content.GetValueForProperty("LastHeartbeatUtc",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).LastHeartbeatUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Health = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth?) content.GetValueForProperty("Health",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).Health, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.ProtectionHealth.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).HealthError = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError[]) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IPushInstallerDetailsInternal)this).HealthError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHealthError>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.HealthErrorTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Push installer details.
    [System.ComponentModel.TypeConverter(typeof(PushInstallerDetailsTypeConverter))]
    public partial interface IPushInstallerDetails

    {

    }
}