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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AccountAggregationSource Marshaller
    /// </summary>
    public class AccountAggregationSourceMarshaller : IRequestMarshaller<AccountAggregationSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AccountAggregationSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccountIds())
            {
                context.Writer.WritePropertyName("AccountIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAccountIdsListValue in requestObject.AccountIds)
                {
                        context.Writer.Write(requestObjectAccountIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAllAwsRegions())
            {
                context.Writer.WritePropertyName("AllAwsRegions");
                context.Writer.Write(requestObject.AllAwsRegions);
            }

            if(requestObject.IsSetAwsRegions())
            {
                context.Writer.WritePropertyName("AwsRegions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAwsRegionsListValue in requestObject.AwsRegions)
                {
                        context.Writer.Write(requestObjectAwsRegionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AccountAggregationSourceMarshaller Instance = new AccountAggregationSourceMarshaller();

    }
}