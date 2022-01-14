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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.XRay.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.XRay.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetTraceSummaries Request Marshaller
    /// </summary>       
    public class GetTraceSummariesRequestMarshaller : IMarshaller<IRequest, GetTraceSummariesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTraceSummariesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetTraceSummariesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.XRay");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-04-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "/TraceSummaries";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEndTime())
                {
                    context.Writer.WritePropertyName("EndTime");
                    context.Writer.Write(publicRequest.EndTime);
                }

                if(publicRequest.IsSetFilterExpression())
                {
                    context.Writer.WritePropertyName("FilterExpression");
                    context.Writer.Write(publicRequest.FilterExpression);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetSampling())
                {
                    context.Writer.WritePropertyName("Sampling");
                    context.Writer.Write(publicRequest.Sampling);
                }

                if(publicRequest.IsSetSamplingStrategy())
                {
                    context.Writer.WritePropertyName("SamplingStrategy");
                    context.Writer.WriteObjectStart();

                    var marshaller = SamplingStrategyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SamplingStrategy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStartTime())
                {
                    context.Writer.WritePropertyName("StartTime");
                    context.Writer.Write(publicRequest.StartTime);
                }

                if(publicRequest.IsSetTimeRangeType())
                {
                    context.Writer.WritePropertyName("TimeRangeType");
                    context.Writer.Write(publicRequest.TimeRangeType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetTraceSummariesRequestMarshaller _instance = new GetTraceSummariesRequestMarshaller();        

        internal static GetTraceSummariesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTraceSummariesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}