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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFacet Request Marshaller
    /// </summary>       
    public class UpdateFacetRequestMarshaller : IMarshaller<IRequest, UpdateFacetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFacetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFacetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudDirectory");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-01-11";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/amazonclouddirectory/2017-01-11/facet";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttributeUpdates())
                {
                    context.Writer.WritePropertyName("AttributeUpdates");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAttributeUpdatesListValue in publicRequest.AttributeUpdates)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = FacetAttributeUpdateMarshaller.Instance;
                        marshaller.Marshall(publicRequestAttributeUpdatesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetObjectType())
                {
                    context.Writer.WritePropertyName("ObjectType");
                    context.Writer.Write(publicRequest.ObjectType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if (publicRequest.IsSetSchemaArn()) 
            {
                request.Headers["x-amz-data-partition"] = publicRequest.SchemaArn;
            }

            return request;
        }
        private static UpdateFacetRequestMarshaller _instance = new UpdateFacetRequestMarshaller();        

        internal static UpdateFacetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFacetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}