﻿//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

namespace System.Device.Wifi
{
    /// <summary>
    /// Status of the connection attempt.
    /// </summary>
    public enum WifiConnectionStatus
    {
        /// <summary>
        /// Connection failed because access to the network has been revoked.
        /// </summary>
        AccessRevoked,

        /// <summary>
        /// Connection failed because an invalid credential was presented.
        /// </summary>
        InvalidCredential,

        /// <summary>
        /// Connection failed because the network is not available.
        /// </summary>
        NetworkNotAvailable,

        /// <summary>
        /// Connection succeeded.
        /// </summary>
        Success,

        /// <summary>
        /// Connection failed because the connection attempt timed out.
        /// </summary>
        Timeout,

        /// <summary>
        /// Connection failed for a reason other than those in this list.
        /// </summary>
        UnspecifiedFailure,

        /// <summary>
        /// Connection failed because the authentication protocol is not supported.
        /// </summary>
        UnsupportedAuthenticationProtocol
    }
}
