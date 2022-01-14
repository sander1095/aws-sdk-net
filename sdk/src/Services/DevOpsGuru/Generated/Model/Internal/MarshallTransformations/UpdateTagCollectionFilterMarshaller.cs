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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsGuru.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DevOpsGuru.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTagCollectionFilter Marshaller
    /// </summary>
    public class UpdateTagCollectionFilterMarshaller : IRequestMarshaller<UpdateTagCollectionFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateTagCollectionFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAppBoundaryKey())
            {
                context.Writer.WritePropertyName("AppBoundaryKey");
                context.Writer.Write(requestObject.AppBoundaryKey);
            }

            if(requestObject.IsSetTagValues())
            {
                context.Writer.WritePropertyName("TagValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTagValuesListValue in requestObject.TagValues)
                {
                        context.Writer.Write(requestObjectTagValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateTagCollectionFilterMarshaller Instance = new UpdateTagCollectionFilterMarshaller();

    }
}