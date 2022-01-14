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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Captions Marshaller
    /// </summary>
    public class CaptionsMarshaller : IRequestMarshaller<Captions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Captions requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCaptionFormats())
            {
                context.Writer.WritePropertyName("CaptionFormats");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCaptionFormatsListValue in requestObject.CaptionFormats)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CaptionFormatMarshaller.Instance;
                    marshaller.Marshall(requestObjectCaptionFormatsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCaptionSources())
            {
                context.Writer.WritePropertyName("CaptionSources");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCaptionSourcesListValue in requestObject.CaptionSources)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CaptionSourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectCaptionSourcesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMergePolicy())
            {
                context.Writer.WritePropertyName("MergePolicy");
                context.Writer.Write(requestObject.MergePolicy);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CaptionsMarshaller Instance = new CaptionsMarshaller();

    }
}