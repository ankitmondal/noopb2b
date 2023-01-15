﻿using Nop.Core.Domain.Logging;
using Nop.Services.Caching;
using System.Threading.Tasks;

namespace Nop.Services.Logging.Caching
{
    /// <summary>
    /// Represents a activity log type cache event consumer
    /// </summary>
    public partial class ActivityLogTypeCacheEventConsumer : CacheEventConsumer<ActivityLogType>
    {
    }
}
