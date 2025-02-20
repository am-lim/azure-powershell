// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101
{
    using Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.PowerShell;

    /// <summary>Service properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(ServicePropertiesFormatTypeConverter))]
    public partial class ServicePropertiesFormat
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ServicePropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormat"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormat DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServicePropertiesFormat(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ServicePropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormat"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormat DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServicePropertiesFormat(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServicePropertiesFormat" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ServicePropertiesFormat" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormat FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ServicePropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServicePropertiesFormat(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ServiceQosPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQosPolicy = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicy) content.GetValueForProperty("ServiceQosPolicy",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQosPolicy, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.QosPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("ServicePrecedence"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServicePrecedence = (int) content.GetValueForProperty("ServicePrecedence",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServicePrecedence, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("PccRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).PccRule = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleConfiguration[]) content.GetValueForProperty("PccRule",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).PccRule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleConfiguration>(__y, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.PccRuleConfigurationTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServiceQoPolicyPreemptionCapability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyPreemptionCapability = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionCapability?) content.GetValueForProperty("ServiceQoPolicyPreemptionCapability",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyPreemptionCapability, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionCapability.CreateFrom);
            }
            if (content.Contains("ServiceQoPolicyPreemptionVulnerability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyPreemptionVulnerability = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionVulnerability?) content.GetValueForProperty("ServiceQoPolicyPreemptionVulnerability",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyPreemptionVulnerability, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionVulnerability.CreateFrom);
            }
            if (content.Contains("ServiceQoPolicyMaximumBitRate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyMaximumBitRate = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IAmbr) content.GetValueForProperty("ServiceQoPolicyMaximumBitRate",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyMaximumBitRate, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.AmbrTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServiceQoPolicyFiveQi"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyFiveQi = (int?) content.GetValueForProperty("ServiceQoPolicyFiveQi",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyFiveQi, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ServiceQoPolicyAllocationAndRetentionPriorityLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyAllocationAndRetentionPriorityLevel = (int?) content.GetValueForProperty("ServiceQoPolicyAllocationAndRetentionPriorityLevel",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyAllocationAndRetentionPriorityLevel, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MaximumBitRateUplink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).MaximumBitRateUplink = (string) content.GetValueForProperty("MaximumBitRateUplink",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).MaximumBitRateUplink, global::System.Convert.ToString);
            }
            if (content.Contains("MaximumBitRateDownlink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).MaximumBitRateDownlink = (string) content.GetValueForProperty("MaximumBitRateDownlink",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).MaximumBitRateDownlink, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ServicePropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServicePropertiesFormat(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ServiceQosPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQosPolicy = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicy) content.GetValueForProperty("ServiceQosPolicy",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQosPolicy, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.QosPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("ServicePrecedence"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServicePrecedence = (int) content.GetValueForProperty("ServicePrecedence",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServicePrecedence, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("PccRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).PccRule = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleConfiguration[]) content.GetValueForProperty("PccRule",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).PccRule, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleConfiguration>(__y, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.PccRuleConfigurationTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServiceQoPolicyPreemptionCapability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyPreemptionCapability = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionCapability?) content.GetValueForProperty("ServiceQoPolicyPreemptionCapability",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyPreemptionCapability, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionCapability.CreateFrom);
            }
            if (content.Contains("ServiceQoPolicyPreemptionVulnerability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyPreemptionVulnerability = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionVulnerability?) content.GetValueForProperty("ServiceQoPolicyPreemptionVulnerability",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyPreemptionVulnerability, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionVulnerability.CreateFrom);
            }
            if (content.Contains("ServiceQoPolicyMaximumBitRate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyMaximumBitRate = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IAmbr) content.GetValueForProperty("ServiceQoPolicyMaximumBitRate",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyMaximumBitRate, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.AmbrTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServiceQoPolicyFiveQi"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyFiveQi = (int?) content.GetValueForProperty("ServiceQoPolicyFiveQi",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyFiveQi, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ServiceQoPolicyAllocationAndRetentionPriorityLevel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyAllocationAndRetentionPriorityLevel = (int?) content.GetValueForProperty("ServiceQoPolicyAllocationAndRetentionPriorityLevel",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).ServiceQoPolicyAllocationAndRetentionPriorityLevel, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MaximumBitRateUplink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).MaximumBitRateUplink = (string) content.GetValueForProperty("MaximumBitRateUplink",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).MaximumBitRateUplink, global::System.Convert.ToString);
            }
            if (content.Contains("MaximumBitRateDownlink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).MaximumBitRateDownlink = (string) content.GetValueForProperty("MaximumBitRateDownlink",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServicePropertiesFormatInternal)this).MaximumBitRateDownlink, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Service properties.
    [System.ComponentModel.TypeConverter(typeof(ServicePropertiesFormatTypeConverter))]
    public partial interface IServicePropertiesFormat

    {

    }
}