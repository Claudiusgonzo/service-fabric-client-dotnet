// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Common
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents the base for all Container Events.
    /// </summary>
    public partial class ContainerEvent : FabricEvent
    {
        /// <summary>
        /// Initializes a new instance of the ContainerEvent class.
        /// </summary>
        /// <param name="eventInstanceId">The identifier for the FabricEvent instance.</param>
        /// <param name="timeStamp">The time event was logged.</param>
        /// <param name="hasCorrelatedEvents">Shows that there is existing related events available.</param>
        public ContainerEvent(
            Guid? eventInstanceId,
            DateTime? timeStamp,
            bool? hasCorrelatedEvents = default(bool?))
            : base(
                eventInstanceId,
                timeStamp,
                Common.FabricEventKind.ContainerEvent,
                hasCorrelatedEvents)
        {
        }
    }
}
