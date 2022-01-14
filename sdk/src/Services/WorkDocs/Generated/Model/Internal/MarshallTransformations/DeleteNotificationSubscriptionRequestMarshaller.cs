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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkDocs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteNotificationSubscription Request Marshaller
    /// </summary>       
    public class DeleteNotificationSubscriptionRequestMarshaller : IMarshaller<IRequest, DeleteNotificationSubscriptionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteNotificationSubscriptionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteNotificationSubscriptionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetOrganizationId())
                throw new AmazonWorkDocsException("Request object does not have required field OrganizationId set");
            request.AddPathResource("{OrganizationId}", StringUtils.FromString(publicRequest.OrganizationId));
            if (!publicRequest.IsSetSubscriptionId())
                throw new AmazonWorkDocsException("Request object does not have required field SubscriptionId set");
            request.AddPathResource("{SubscriptionId}", StringUtils.FromString(publicRequest.SubscriptionId));
            request.ResourcePath = "/api/v1/organizations/{OrganizationId}/subscriptions/{SubscriptionId}";

            return request;
        }
        private static DeleteNotificationSubscriptionRequestMarshaller _instance = new DeleteNotificationSubscriptionRequestMarshaller();        

        internal static DeleteNotificationSubscriptionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteNotificationSubscriptionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}