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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeGuruReviewer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeGuruReviewer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BranchDiffSourceCodeType Marshaller
    /// </summary>
    public class BranchDiffSourceCodeTypeMarshaller : IRequestMarshaller<BranchDiffSourceCodeType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BranchDiffSourceCodeType requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDestinationBranchName())
            {
                context.Writer.WritePropertyName("DestinationBranchName");
                context.Writer.Write(requestObject.DestinationBranchName);
            }

            if(requestObject.IsSetSourceBranchName())
            {
                context.Writer.WritePropertyName("SourceBranchName");
                context.Writer.Write(requestObject.SourceBranchName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BranchDiffSourceCodeTypeMarshaller Instance = new BranchDiffSourceCodeTypeMarshaller();

    }
}