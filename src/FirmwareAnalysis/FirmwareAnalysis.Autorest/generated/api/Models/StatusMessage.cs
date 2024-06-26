// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Runtime.Extensions;

    /// <summary>Error and status message</summary>
    public partial class StatusMessage :
        Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IStatusMessage,
        Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Models.IStatusMessageInternal
    {

        /// <summary>Backing field for <see cref="ErrorCode" /> property.</summary>
        private long? _errorCode;

        /// <summary>The error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Origin(Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.PropertyOrigin.Owned)]
        public long? ErrorCode { get => this._errorCode; set => this._errorCode = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>The error or status message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Origin(Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Creates an new <see cref="StatusMessage" /> instance.</summary>
        public StatusMessage()
        {

        }
    }
    /// Error and status message
    public partial interface IStatusMessage :
        Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Runtime.IJsonSerializable
    {
        /// <summary>The error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The error code",
        SerializedName = @"errorCode",
        PossibleTypes = new [] { typeof(long) })]
        long? ErrorCode { get; set; }
        /// <summary>The error or status message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FirmwareAnalysis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The error or status message",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    /// Error and status message
    internal partial interface IStatusMessageInternal

    {
        /// <summary>The error code</summary>
        long? ErrorCode { get; set; }
        /// <summary>The error or status message</summary>
        string Message { get; set; }

    }
}