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
#if AWS_ASYNC_API
using System.Threading.Tasks;
#endif
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;

namespace Amazon.S3
{
    public partial interface IAmazonS3 : IDisposable, Amazon.Runtime.SharedInterfaces.ICoreAmazonS3
    {
        #region GetPreSignedURL

        /// <summary>
        /// Create a signed URL allowing access to a resource that would 
        /// usually require authentication.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When using query string authentication you create a query,
        /// specify an expiration time for the query, sign it with your
        /// signature, place the data in an HTTP request, and distribute
        /// the request to a user or embed the request in a web page.
        /// </para>
        /// <para>
        /// A PreSigned URL can be generated for GET, PUT, DELETE and HEAD
        /// operations on your bucketName, keys, and versions.
        /// </para>
        /// </remarks>
        /// <param name="request">The GetPreSignedUrlRequest that defines the
        /// parameters of the operation.</param>
        /// <returns>A string that is the signed http request.</returns>
        /// <exception cref="T:System.ArgumentException" />
        /// <exception cref="T:System.ArgumentNullException" />
        string GetPreSignedURL(GetPreSignedUrlRequest request);

        #endregion
#if AWS_ASYNC_API
        #region GetPresignedURLAsync

        /// <summary>
        /// Asynchronously create a signed URL allowing access to a resource that would 
        /// usually require authentication.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When using query string authentication you create a query,
        /// specify an expiration time for the query, sign it with your
        /// signature, place the data in an HTTP request, and distribute
        /// the request to a user or embed the request in a web page.
        /// </para>
        /// <para>
        /// A PreSigned URL can be generated for GET, PUT, DELETE and HEAD
        /// operations on your bucketName, keys, and versions.
        /// </para>
        /// </remarks>
        /// <param name="request">The GetPreSignedUrlRequest that defines the
        /// parameters of the operation.</param>
        /// <returns>A string that is the signed http request.</returns>
        /// <exception cref="T:System.ArgumentException" />
        /// <exception cref="T:System.ArgumentNullException" />
        Task<string> GetPreSignedURLAsync(GetPreSignedUrlRequest request);

        #endregion
#endif

#if NET8_0_OR_GREATER
#pragma warning disable CA1033
        /// <summary>
        /// Create an instance of the default implementation of the service client interface.
        /// </summary>
        /// <param name="credentials">AWS credentials used to create the service client.</param>
        /// <param name="configure">Callback to configure the service client config object.</param>
        /// <returns></returns>
        static IAmazonService IAmazonService.CreateServiceClient(AWSCredentials credentials, Action<Amazon.Runtime.ClientConfig> configure)
        {
            var config = new AmazonS3Config();
            if(configure != null)
            {
                configure(config);
            }

            return credentials == null ? new AmazonS3Client(config) : new AmazonS3Client(credentials, config);
        }
#pragma warning restore CA1033
#endif
    }
}
