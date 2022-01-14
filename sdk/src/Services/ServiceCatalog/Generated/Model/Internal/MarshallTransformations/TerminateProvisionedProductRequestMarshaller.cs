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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServiceCatalog.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServiceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TerminateProvisionedProduct Request Marshaller
    /// </summary>       
    public class TerminateProvisionedProductRequestMarshaller : IMarshaller<IRequest, TerminateProvisionedProductRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TerminateProvisionedProductRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TerminateProvisionedProductRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceCatalog");
            string target = "AWS242ServiceCatalogService.TerminateProvisionedProduct";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-12-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAcceptLanguage())
                {
                    context.Writer.WritePropertyName("AcceptLanguage");
                    context.Writer.Write(publicRequest.AcceptLanguage);
                }

                if(publicRequest.IsSetIgnoreErrors())
                {
                    context.Writer.WritePropertyName("IgnoreErrors");
                    context.Writer.Write(publicRequest.IgnoreErrors);
                }

                if(publicRequest.IsSetProvisionedProductId())
                {
                    context.Writer.WritePropertyName("ProvisionedProductId");
                    context.Writer.Write(publicRequest.ProvisionedProductId);
                }

                if(publicRequest.IsSetProvisionedProductName())
                {
                    context.Writer.WritePropertyName("ProvisionedProductName");
                    context.Writer.Write(publicRequest.ProvisionedProductName);
                }

                if(publicRequest.IsSetRetainPhysicalResources())
                {
                    context.Writer.WritePropertyName("RetainPhysicalResources");
                    context.Writer.Write(publicRequest.RetainPhysicalResources);
                }

                if(publicRequest.IsSetTerminateToken())
                {
                    context.Writer.WritePropertyName("TerminateToken");
                    context.Writer.Write(publicRequest.TerminateToken);
                }

                else if(!(publicRequest.IsSetTerminateToken()))
                {
                    context.Writer.WritePropertyName("TerminateToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static TerminateProvisionedProductRequestMarshaller _instance = new TerminateProvisionedProductRequestMarshaller();        

        internal static TerminateProvisionedProductRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TerminateProvisionedProductRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}