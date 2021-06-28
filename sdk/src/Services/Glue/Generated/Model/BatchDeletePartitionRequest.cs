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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDeletePartition operation.
    /// Deletes one or more partitions in a batch operation.
    /// </summary>
    public partial class BatchDeletePartitionRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _databaseName;
        private List<PartitionValueList> _partitionsToDelete = new List<PartitionValueList>();
        private string _tableName;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the partition to be deleted resides. If none is provided,
        /// the Amazon Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the catalog database in which the table in question resides.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionsToDelete. 
        /// <para>
        /// A list of <code>PartitionInput</code> structures that define the partitions to be
        /// deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public List<PartitionValueList> PartitionsToDelete
        {
            get { return this._partitionsToDelete; }
            set { this._partitionsToDelete = value; }
        }

        // Check to see if PartitionsToDelete property is set
        internal bool IsSetPartitionsToDelete()
        {
            return this._partitionsToDelete != null && this._partitionsToDelete.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table that contains the partitions to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}