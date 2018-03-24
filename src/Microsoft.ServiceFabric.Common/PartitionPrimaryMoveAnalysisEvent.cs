// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Common
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Partition Primary Move Analysis Event
    /// </summary>
    public partial class PartitionPrimaryMoveAnalysisEvent : PartitionAnalysisEvent
    {
        /// <summary>
        /// Initializes a new instance of the PartitionPrimaryMoveAnalysisEvent class.
        /// </summary>
        /// <param name="eventInstanceId">The identifier for the FabricEvent instance.</param>
        /// <param name="timeStamp">The time event was logged.</param>
        /// <param name="partitionId">An internal ID used by Service Fabric to uniquely identify a partition. This is a
        /// randomly generated GUID when the service was created. The partition ID is unique and does not change for the
        /// lifetime of the service. If the same service was deleted and recreated the IDs of its partitions would be
        /// different.</param>
        /// <param name="metadata">Metadata about an Analysis Event.</param>
        /// <param name="previousNode">The name of a Service Fabric node.</param>
        /// <param name="currentNode">The name of a Service Fabric node.</param>
        /// <param name="moveReason">Move Reason</param>
        /// <param name="relevantTraces">Relevant Traces</param>
        /// <param name="hasCorrelatedEvents">Shows that there is existing related events available.</param>
        public PartitionPrimaryMoveAnalysisEvent(
            Guid? eventInstanceId,
            DateTime? timeStamp,
            PartitionId partitionId,
            AnalysisEventMetadata metadata,
            NodeName previousNode,
            NodeName currentNode,
            string moveReason,
            string relevantTraces,
            bool? hasCorrelatedEvents = default(bool?))
            : base(
                eventInstanceId,
                timeStamp,
                Common.FabricEventKind.PartitionPrimaryMoveAnalysis,
                partitionId,
                metadata,
                hasCorrelatedEvents)
        {
            previousNode.ThrowIfNull(nameof(previousNode));
            currentNode.ThrowIfNull(nameof(currentNode));
            moveReason.ThrowIfNull(nameof(moveReason));
            relevantTraces.ThrowIfNull(nameof(relevantTraces));
            this.PreviousNode = previousNode;
            this.CurrentNode = currentNode;
            this.MoveReason = moveReason;
            this.RelevantTraces = relevantTraces;
        }

        /// <summary>
        /// Gets the name of a Service Fabric node.
        /// </summary>
        public NodeName PreviousNode { get; }

        /// <summary>
        /// Gets the name of a Service Fabric node.
        /// </summary>
        public NodeName CurrentNode { get; }

        /// <summary>
        /// Gets move Reason
        /// </summary>
        public string MoveReason { get; }

        /// <summary>
        /// Gets relevant Traces
        /// </summary>
        public string RelevantTraces { get; }
    }
}
