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
 * Do not modify this file. This file is generated from the iot1click-devices-2018-05-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT1ClickDevicesService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT1ClickDevicesService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UntagResource Request Marshaller
    /// </summary>       
    public class UntagResourceRequestMarshaller : IMarshaller<IRequest, UntagResourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UntagResourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UntagResourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT1ClickDevicesService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-14";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetResourceArn())
                throw new AmazonIoT1ClickDevicesServiceException("Request object does not have required field ResourceArn set");
            request.AddPathResource("{resource-arn}", StringUtils.FromString(publicRequest.ResourceArn));
            
            if (publicRequest.IsSetTagKeys())
                request.ParameterCollection.Add("tagKeys", publicRequest.TagKeys);
            request.ResourcePath = "/tags/{resource-arn}";
            request.UseQueryString = true;

            return request;
        }
        private static UntagResourceRequestMarshaller _instance = new UntagResourceRequestMarshaller();        

        internal static UntagResourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UntagResourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}