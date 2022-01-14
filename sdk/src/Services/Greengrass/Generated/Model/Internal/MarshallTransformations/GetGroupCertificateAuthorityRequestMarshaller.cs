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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetGroupCertificateAuthority Request Marshaller
    /// </summary>       
    public class GetGroupCertificateAuthorityRequestMarshaller : IMarshaller<IRequest, GetGroupCertificateAuthorityRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetGroupCertificateAuthorityRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetGroupCertificateAuthorityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Greengrass");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-06-07";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetCertificateAuthorityId())
                throw new AmazonGreengrassException("Request object does not have required field CertificateAuthorityId set");
            request.AddPathResource("{CertificateAuthorityId}", StringUtils.FromString(publicRequest.CertificateAuthorityId));
            if (!publicRequest.IsSetGroupId())
                throw new AmazonGreengrassException("Request object does not have required field GroupId set");
            request.AddPathResource("{GroupId}", StringUtils.FromString(publicRequest.GroupId));
            request.ResourcePath = "/greengrass/groups/{GroupId}/certificateauthorities/{CertificateAuthorityId}";

            return request;
        }
        private static GetGroupCertificateAuthorityRequestMarshaller _instance = new GetGroupCertificateAuthorityRequestMarshaller();        

        internal static GetGroupCertificateAuthorityRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetGroupCertificateAuthorityRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}