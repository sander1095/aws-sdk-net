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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudTrail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EventSelector Marshaller
    /// </summary>
    public class EventSelectorMarshaller : IRequestMarshaller<EventSelector, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EventSelector requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataResources())
            {
                context.Writer.WritePropertyName("DataResources");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDataResourcesListValue in requestObject.DataResources)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataResourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectDataResourcesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetExcludeManagementEventSources())
            {
                context.Writer.WritePropertyName("ExcludeManagementEventSources");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExcludeManagementEventSourcesListValue in requestObject.ExcludeManagementEventSources)
                {
                        context.Writer.Write(requestObjectExcludeManagementEventSourcesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIncludeManagementEvents())
            {
                context.Writer.WritePropertyName("IncludeManagementEvents");
                context.Writer.Write(requestObject.IncludeManagementEvents);
            }

            if(requestObject.IsSetReadWriteType())
            {
                context.Writer.WritePropertyName("ReadWriteType");
                context.Writer.Write(requestObject.ReadWriteType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EventSelectorMarshaller Instance = new EventSelectorMarshaller();

    }
}