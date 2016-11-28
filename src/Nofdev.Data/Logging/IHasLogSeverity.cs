using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nofdev.Data.Logging
{
    interface IHasLogSeverity
    {
        /// <summary>
        /// Log severity.
        /// </summary>
        LogSeverity Severity { get; set; }
    }
}
