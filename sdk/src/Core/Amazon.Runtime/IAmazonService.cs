/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;

namespace Amazon.Runtime
{
    /// <summary>
    /// All Amazon service interfaces like IAmazonS3 extend from this interface. This allows all the 
    /// Amazon service interfaces be identified by this base interface and helps with generic constraints.
    /// </summary>
    public interface IAmazonService
    {
        /// <summary>
        /// A readonly view of the configuration for the service client.
        /// </summary>
        IClientConfig Config
        {
            get;
        }

#if NET8_0_OR_GREATER
#pragma warning disable CA1000 // Do not declare static members on generic types
        /// <summary>
        /// Create an instance of the default implementation of the service client interface.
        /// </summary>
        /// <param name="credentials">AWS credentials used to create the service client.</param>
        /// <param name="configure">Callback to configure the service client config object.</param>
        /// <returns></returns>
        static abstract IAmazonService CreateServiceClient(AWSCredentials credentials, Action<ClientConfig> configure);
#pragma warning restore CA1000 // Do not declare static members on generic types
#endif
    }
}