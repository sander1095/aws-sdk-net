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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateReportPlan Request Marshaller
    /// </summary>       
    public class CreateReportPlanRequestMarshaller : IMarshaller<IRequest, CreateReportPlanRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateReportPlanRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateReportPlanRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/audit/report-plans";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetIdempotencyToken())
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(publicRequest.IdempotencyToken);
                }

                else if(!(publicRequest.IsSetIdempotencyToken()))
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetReportDeliveryChannel())
                {
                    context.Writer.WritePropertyName("ReportDeliveryChannel");
                    context.Writer.WriteObjectStart();

                    var marshaller = ReportDeliveryChannelMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ReportDeliveryChannel, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetReportPlanDescription())
                {
                    context.Writer.WritePropertyName("ReportPlanDescription");
                    context.Writer.Write(publicRequest.ReportPlanDescription);
                }

                if(publicRequest.IsSetReportPlanName())
                {
                    context.Writer.WritePropertyName("ReportPlanName");
                    context.Writer.Write(publicRequest.ReportPlanName);
                }

                if(publicRequest.IsSetReportPlanTags())
                {
                    context.Writer.WritePropertyName("ReportPlanTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestReportPlanTagsKvp in publicRequest.ReportPlanTags)
                    {
                        context.Writer.WritePropertyName(publicRequestReportPlanTagsKvp.Key);
                        var publicRequestReportPlanTagsValue = publicRequestReportPlanTagsKvp.Value;

                            context.Writer.Write(publicRequestReportPlanTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetReportSetting())
                {
                    context.Writer.WritePropertyName("ReportSetting");
                    context.Writer.WriteObjectStart();

                    var marshaller = ReportSettingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ReportSetting, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateReportPlanRequestMarshaller _instance = new CreateReportPlanRequestMarshaller();        

        internal static CreateReportPlanRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateReportPlanRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}