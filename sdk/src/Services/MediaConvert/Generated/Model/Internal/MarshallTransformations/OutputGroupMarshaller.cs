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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OutputGroup Marshaller
    /// </summary>
    public class OutputGroupMarshaller : IRequestMarshaller<OutputGroup, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OutputGroup requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAutomatedEncodingSettings())
            {
                context.Writer.WritePropertyName("automatedEncodingSettings");
                context.Writer.WriteObjectStart();

                var marshaller = AutomatedEncodingSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AutomatedEncodingSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCustomName())
            {
                context.Writer.WritePropertyName("customName");
                context.Writer.Write(requestObject.CustomName);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetOutputGroupSettings())
            {
                context.Writer.WritePropertyName("outputGroupSettings");
                context.Writer.WriteObjectStart();

                var marshaller = OutputGroupSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputGroupSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOutputs())
            {
                context.Writer.WritePropertyName("outputs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOutputsListValue in requestObject.Outputs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = OutputMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OutputGroupMarshaller Instance = new OutputGroupMarshaller();

    }
}