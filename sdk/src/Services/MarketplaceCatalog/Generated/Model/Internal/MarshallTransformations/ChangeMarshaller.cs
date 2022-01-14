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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceCatalog.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MarketplaceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Change Marshaller
    /// </summary>
    public class ChangeMarshaller : IRequestMarshaller<Change, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Change requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetChangeName())
            {
                context.Writer.WritePropertyName("ChangeName");
                context.Writer.Write(requestObject.ChangeName);
            }

            if(requestObject.IsSetChangeType())
            {
                context.Writer.WritePropertyName("ChangeType");
                context.Writer.Write(requestObject.ChangeType);
            }

            if(requestObject.IsSetDetails())
            {
                context.Writer.WritePropertyName("Details");
                context.Writer.Write(requestObject.Details);
            }

            if(requestObject.IsSetEntity())
            {
                context.Writer.WritePropertyName("Entity");
                context.Writer.WriteObjectStart();

                var marshaller = EntityMarshaller.Instance;
                marshaller.Marshall(requestObject.Entity, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ChangeMarshaller Instance = new ChangeMarshaller();

    }
}