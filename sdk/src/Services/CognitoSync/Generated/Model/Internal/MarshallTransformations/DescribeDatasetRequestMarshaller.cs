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

/*
 * Do not modify this file. This file is generated from the cognito-sync-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeDataset Request Marshaller
    /// </summary>       
    public class DescribeDatasetRequestMarshaller : IMarshaller<IRequest, DescribeDatasetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeDatasetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeDatasetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoSync");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-06-30";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDatasetName())
                throw new AmazonCognitoSyncException("Request object does not have required field DatasetName set");
            request.AddPathResource("{DatasetName}", StringUtils.FromString(publicRequest.DatasetName));
            if (!publicRequest.IsSetIdentityId())
                throw new AmazonCognitoSyncException("Request object does not have required field IdentityId set");
            request.AddPathResource("{IdentityId}", StringUtils.FromString(publicRequest.IdentityId));
            if (!publicRequest.IsSetIdentityPoolId())
                throw new AmazonCognitoSyncException("Request object does not have required field IdentityPoolId set");
            request.AddPathResource("{IdentityPoolId}", StringUtils.FromString(publicRequest.IdentityPoolId));
            request.ResourcePath = "/identitypools/{IdentityPoolId}/identities/{IdentityId}/datasets/{DatasetName}";

            return request;
        }
        private static DescribeDatasetRequestMarshaller _instance = new DescribeDatasetRequestMarshaller();        

        internal static DescribeDatasetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeDatasetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}