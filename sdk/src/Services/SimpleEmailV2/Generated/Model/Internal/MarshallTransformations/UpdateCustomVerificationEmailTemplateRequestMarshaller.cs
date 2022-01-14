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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCustomVerificationEmailTemplate Request Marshaller
    /// </summary>       
    public class UpdateCustomVerificationEmailTemplateRequestMarshaller : IMarshaller<IRequest, UpdateCustomVerificationEmailTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCustomVerificationEmailTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateCustomVerificationEmailTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmailV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-27";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetTemplateName())
                throw new AmazonSimpleEmailServiceV2Exception("Request object does not have required field TemplateName set");
            request.AddPathResource("{TemplateName}", StringUtils.FromString(publicRequest.TemplateName));
            request.ResourcePath = "/v2/email/custom-verification-email-templates/{TemplateName}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFailureRedirectionURL())
                {
                    context.Writer.WritePropertyName("FailureRedirectionURL");
                    context.Writer.Write(publicRequest.FailureRedirectionURL);
                }

                if(publicRequest.IsSetFromEmailAddress())
                {
                    context.Writer.WritePropertyName("FromEmailAddress");
                    context.Writer.Write(publicRequest.FromEmailAddress);
                }

                if(publicRequest.IsSetSuccessRedirectionURL())
                {
                    context.Writer.WritePropertyName("SuccessRedirectionURL");
                    context.Writer.Write(publicRequest.SuccessRedirectionURL);
                }

                if(publicRequest.IsSetTemplateContent())
                {
                    context.Writer.WritePropertyName("TemplateContent");
                    context.Writer.Write(publicRequest.TemplateContent);
                }

                if(publicRequest.IsSetTemplateSubject())
                {
                    context.Writer.WritePropertyName("TemplateSubject");
                    context.Writer.Write(publicRequest.TemplateSubject);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateCustomVerificationEmailTemplateRequestMarshaller _instance = new UpdateCustomVerificationEmailTemplateRequestMarshaller();        

        internal static UpdateCustomVerificationEmailTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateCustomVerificationEmailTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}