﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nofdev.Data.Logging
{
    /// <summary>
    /// Indicates severity for log.
    /// </summary>
    public enum LogSeverity
    {
        /// <summary>
        /// Debug.
        /// </summary>
        Debug,

        /// <summary>
        /// Info.
        /// </summary>
        Info,

        /// <summary>
        /// Warn.
        /// </summary>
        Warn,

        /// <summary>
        /// Error.
        /// </summary>
        Error,

        /// <summary>
        /// Fatal.
        /// </summary>
        Fatal
    }
}
