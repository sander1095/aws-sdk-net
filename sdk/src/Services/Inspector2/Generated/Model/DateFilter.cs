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
    /// Contains details on the time range used to filter findings.
    /// </summary>
    public partial class DateFilter
    {
        private DateTime? _endInclusive;
        private DateTime? _startInclusive;

        /// <summary>
        /// Gets and sets the property EndInclusive. 
        /// <para>
        /// A timestamp representing the end of the time period filtered on.
        /// </para>
        /// </summary>
        public DateTime EndInclusive
        {
            get { return this._endInclusive.GetValueOrDefault(); }
            set { this._endInclusive = value; }
        }

        // Check to see if EndInclusive property is set
        internal bool IsSetEndInclusive()
        {
            return this._endInclusive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartInclusive. 
        /// <para>
        /// A timestamp representing the start of the time period filtered on.
        /// </para>
        /// </summary>
        public DateTime StartInclusive
        {
            get { return this._startInclusive.GetValueOrDefault(); }
            set { this._startInclusive = value; }
        }

        // Check to see if StartInclusive property is set
        internal bool IsSetStartInclusive()
        {
            return this._startInclusive.HasValue; 
        }

    }
}