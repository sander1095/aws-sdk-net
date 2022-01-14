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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlueDataBrew.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GlueDataBrew.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ViewFrame Marshaller
    /// </summary>
    public class ViewFrameMarshaller : IRequestMarshaller<ViewFrame, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ViewFrame requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAnalytics())
            {
                context.Writer.WritePropertyName("Analytics");
                context.Writer.Write(requestObject.Analytics);
            }

            if(requestObject.IsSetColumnRange())
            {
                context.Writer.WritePropertyName("ColumnRange");
                context.Writer.Write(requestObject.ColumnRange);
            }

            if(requestObject.IsSetHiddenColumns())
            {
                context.Writer.WritePropertyName("HiddenColumns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectHiddenColumnsListValue in requestObject.HiddenColumns)
                {
                        context.Writer.Write(requestObjectHiddenColumnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRowRange())
            {
                context.Writer.WritePropertyName("RowRange");
                context.Writer.Write(requestObject.RowRange);
            }

            if(requestObject.IsSetStartColumnIndex())
            {
                context.Writer.WritePropertyName("StartColumnIndex");
                context.Writer.Write(requestObject.StartColumnIndex);
            }

            if(requestObject.IsSetStartRowIndex())
            {
                context.Writer.WritePropertyName("StartRowIndex");
                context.Writer.Write(requestObject.StartRowIndex);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ViewFrameMarshaller Instance = new ViewFrameMarshaller();

    }
}