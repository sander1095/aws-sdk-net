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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Drs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeJobsRequestFilters Marshaller
    /// </summary>
    public class DescribeJobsRequestFiltersMarshaller : IRequestMarshaller<DescribeJobsRequestFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DescribeJobsRequestFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFromDate())
            {
                context.Writer.WritePropertyName("fromDate");
                context.Writer.Write(requestObject.FromDate);
            }

            if(requestObject.IsSetJobIDs())
            {
                context.Writer.WritePropertyName("jobIDs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectJobIDsListValue in requestObject.JobIDs)
                {
                        context.Writer.Write(requestObjectJobIDsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetToDate())
            {
                context.Writer.WritePropertyName("toDate");
                context.Writer.Write(requestObject.ToDate);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DescribeJobsRequestFiltersMarshaller Instance = new DescribeJobsRequestFiltersMarshaller();

    }
}