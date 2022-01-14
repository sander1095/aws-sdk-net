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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubRefactorSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MigrationHubRefactorSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteRoute Request Marshaller
    /// </summary>       
    public class DeleteRouteRequestMarshaller : IMarshaller<IRequest, DeleteRouteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteRouteRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteRouteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MigrationHubRefactorSpaces");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-10-26";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetApplicationIdentifier())
                throw new AmazonMigrationHubRefactorSpacesException("Request object does not have required field ApplicationIdentifier set");
            request.AddPathResource("{ApplicationIdentifier}", StringUtils.FromString(publicRequest.ApplicationIdentifier));
            if (!publicRequest.IsSetEnvironmentIdentifier())
                throw new AmazonMigrationHubRefactorSpacesException("Request object does not have required field EnvironmentIdentifier set");
            request.AddPathResource("{EnvironmentIdentifier}", StringUtils.FromString(publicRequest.EnvironmentIdentifier));
            if (!publicRequest.IsSetRouteIdentifier())
                throw new AmazonMigrationHubRefactorSpacesException("Request object does not have required field RouteIdentifier set");
            request.AddPathResource("{RouteIdentifier}", StringUtils.FromString(publicRequest.RouteIdentifier));
            request.ResourcePath = "/environments/{EnvironmentIdentifier}/applications/{ApplicationIdentifier}/routes/{RouteIdentifier}";

            return request;
        }
        private static DeleteRouteRequestMarshaller _instance = new DeleteRouteRequestMarshaller();        

        internal static DeleteRouteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteRouteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}