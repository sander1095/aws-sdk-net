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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// This is the response object from the GetDelegatedAdminAccount operation.
    /// </summary>
    public partial class GetDelegatedAdminAccountResponse : AmazonWebServiceResponse
    {
        private DelegatedAdmin _delegatedAdmin;

        /// <summary>
        /// Gets and sets the property DelegatedAdmin. 
        /// <para>
        /// The Amazon Web Services account ID of the Amazon Inspector delegated administrator.
        /// </para>
        /// </summary>
        public DelegatedAdmin DelegatedAdmin
        {
            get { return this._delegatedAdmin; }
            set { this._delegatedAdmin = value; }
        }

        // Check to see if DelegatedAdmin property is set
        internal bool IsSetDelegatedAdmin()
        {
            return this._delegatedAdmin != null;
        }

    }
}