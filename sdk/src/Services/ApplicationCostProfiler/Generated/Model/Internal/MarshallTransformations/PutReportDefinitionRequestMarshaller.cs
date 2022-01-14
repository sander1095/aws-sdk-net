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
 * Do not modify this file. This file is generated from the applicationcostprofiler-2020-09-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationCostProfiler.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ApplicationCostProfiler.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutReportDefinition Request Marshaller
    /// </summary>       
    public class PutReportDefinitionRequestMarshaller : IMarshaller<IRequest, PutReportDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutReportDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutReportDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApplicationCostProfiler");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-09-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/reportDefinition";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDestinationS3Location())
                {
                    context.Writer.WritePropertyName("destinationS3Location");
                    context.Writer.WriteObjectStart();

                    var marshaller = S3LocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DestinationS3Location, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFormat())
                {
                    context.Writer.WritePropertyName("format");
                    context.Writer.Write(publicRequest.Format);
                }

                if(publicRequest.IsSetReportDescription())
                {
                    context.Writer.WritePropertyName("reportDescription");
                    context.Writer.Write(publicRequest.ReportDescription);
                }

                if(publicRequest.IsSetReportFrequency())
                {
                    context.Writer.WritePropertyName("reportFrequency");
                    context.Writer.Write(publicRequest.ReportFrequency);
                }

                if(publicRequest.IsSetReportId())
                {
                    context.Writer.WritePropertyName("reportId");
                    context.Writer.Write(publicRequest.ReportId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutReportDefinitionRequestMarshaller _instance = new PutReportDefinitionRequestMarshaller();        

        internal static PutReportDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutReportDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}