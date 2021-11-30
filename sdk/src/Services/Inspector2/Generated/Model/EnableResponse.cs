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
    /// This is the response object from the Enable operation.
    /// </summary>
    public partial class EnableResponse : AmazonWebServiceResponse
    {
        private List<Account> _accounts = new List<Account>();
        private List<FailedAccount> _failedAccounts = new List<FailedAccount>();

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// Information on the accounts that have had Amazon Inspector scans successfully enabled.
        /// Details are provided for each account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Account> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && this._accounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FailedAccounts. 
        /// <para>
        /// Information on any accounts for which Amazon Inspector scans could not be enabled.
        /// Details are provided for each account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<FailedAccount> FailedAccounts
        {
            get { return this._failedAccounts; }
            set { this._failedAccounts = value; }
        }

        // Check to see if FailedAccounts property is set
        internal bool IsSetFailedAccounts()
        {
            return this._failedAccounts != null && this._failedAccounts.Count > 0; 
        }

    }
}