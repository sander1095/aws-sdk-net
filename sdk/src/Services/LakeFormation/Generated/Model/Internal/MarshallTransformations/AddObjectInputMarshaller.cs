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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddObjectInput Marshaller
    /// </summary>
    public class AddObjectInputMarshaller : IRequestMarshaller<AddObjectInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AddObjectInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetETag())
            {
                context.Writer.WritePropertyName("ETag");
                context.Writer.Write(requestObject.ETag);
            }

            if(requestObject.IsSetPartitionValues())
            {
                context.Writer.WritePropertyName("PartitionValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPartitionValuesListValue in requestObject.PartitionValues)
                {
                        context.Writer.Write(requestObjectPartitionValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSize())
            {
                context.Writer.WritePropertyName("Size");
                context.Writer.Write(requestObject.Size);
            }

            if(requestObject.IsSetUri())
            {
                context.Writer.WritePropertyName("Uri");
                context.Writer.Write(requestObject.Uri);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AddObjectInputMarshaller Instance = new AddObjectInputMarshaller();

    }
}