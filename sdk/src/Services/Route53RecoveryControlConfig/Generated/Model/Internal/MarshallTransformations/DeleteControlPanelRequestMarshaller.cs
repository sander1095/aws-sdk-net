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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53RecoveryControlConfig.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Route53RecoveryControlConfig.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteControlPanel Request Marshaller
    /// </summary>       
    public class DeleteControlPanelRequestMarshaller : IMarshaller<IRequest, DeleteControlPanelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteControlPanelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteControlPanelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53RecoveryControlConfig");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-02";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetControlPanelArn())
                throw new AmazonRoute53RecoveryControlConfigException("Request object does not have required field ControlPanelArn set");
            request.AddPathResource("{ControlPanelArn}", StringUtils.FromString(publicRequest.ControlPanelArn));
            request.ResourcePath = "/controlpanel/{ControlPanelArn}";

            return request;
        }
        private static DeleteControlPanelRequestMarshaller _instance = new DeleteControlPanelRequestMarshaller();        

        internal static DeleteControlPanelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteControlPanelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}