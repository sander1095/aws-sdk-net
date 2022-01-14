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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEventsData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTEventsData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DisableAlarmActionRequest Marshaller
    /// </summary>
    public class DisableAlarmActionRequestMarshaller : IRequestMarshaller<DisableAlarmActionRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DisableAlarmActionRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAlarmModelName())
            {
                context.Writer.WritePropertyName("alarmModelName");
                context.Writer.Write(requestObject.AlarmModelName);
            }

            if(requestObject.IsSetKeyValue())
            {
                context.Writer.WritePropertyName("keyValue");
                context.Writer.Write(requestObject.KeyValue);
            }

            if(requestObject.IsSetNote())
            {
                context.Writer.WritePropertyName("note");
                context.Writer.Write(requestObject.Note);
            }

            if(requestObject.IsSetRequestId())
            {
                context.Writer.WritePropertyName("requestId");
                context.Writer.Write(requestObject.RequestId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DisableAlarmActionRequestMarshaller Instance = new DisableAlarmActionRequestMarshaller();

    }
}