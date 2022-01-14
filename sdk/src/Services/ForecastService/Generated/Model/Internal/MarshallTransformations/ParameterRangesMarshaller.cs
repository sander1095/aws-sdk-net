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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ForecastService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ForecastService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ParameterRanges Marshaller
    /// </summary>
    public class ParameterRangesMarshaller : IRequestMarshaller<ParameterRanges, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ParameterRanges requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCategoricalParameterRanges())
            {
                context.Writer.WritePropertyName("CategoricalParameterRanges");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCategoricalParameterRangesListValue in requestObject.CategoricalParameterRanges)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CategoricalParameterRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectCategoricalParameterRangesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetContinuousParameterRanges())
            {
                context.Writer.WritePropertyName("ContinuousParameterRanges");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectContinuousParameterRangesListValue in requestObject.ContinuousParameterRanges)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ContinuousParameterRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectContinuousParameterRangesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIntegerParameterRanges())
            {
                context.Writer.WritePropertyName("IntegerParameterRanges");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIntegerParameterRangesListValue in requestObject.IntegerParameterRanges)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = IntegerParameterRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectIntegerParameterRangesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ParameterRangesMarshaller Instance = new ParameterRangesMarshaller();

    }
}