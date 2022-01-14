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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AuditManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AuditManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAssessment Request Marshaller
    /// </summary>       
    public class UpdateAssessmentRequestMarshaller : IMarshaller<IRequest, UpdateAssessmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAssessmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAssessmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AuditManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAssessmentId())
                throw new AmazonAuditManagerException("Request object does not have required field AssessmentId set");
            request.AddPathResource("{assessmentId}", StringUtils.FromString(publicRequest.AssessmentId));
            request.ResourcePath = "/assessments/{assessmentId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssessmentDescription())
                {
                    context.Writer.WritePropertyName("assessmentDescription");
                    context.Writer.Write(publicRequest.AssessmentDescription);
                }

                if(publicRequest.IsSetAssessmentName())
                {
                    context.Writer.WritePropertyName("assessmentName");
                    context.Writer.Write(publicRequest.AssessmentName);
                }

                if(publicRequest.IsSetAssessmentReportsDestination())
                {
                    context.Writer.WritePropertyName("assessmentReportsDestination");
                    context.Writer.WriteObjectStart();

                    var marshaller = AssessmentReportsDestinationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AssessmentReportsDestination, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoles())
                {
                    context.Writer.WritePropertyName("roles");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRolesListValue in publicRequest.Roles)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RoleMarshaller.Instance;
                        marshaller.Marshall(publicRequestRolesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetScope())
                {
                    context.Writer.WritePropertyName("scope");
                    context.Writer.WriteObjectStart();

                    var marshaller = ScopeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Scope, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAssessmentRequestMarshaller _instance = new UpdateAssessmentRequestMarshaller();        

        internal static UpdateAssessmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAssessmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}