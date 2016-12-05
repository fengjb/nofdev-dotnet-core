using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nofdev.Data.Dependency
{
    public interface IDisposableDependencyObjectWrapper<out T> : IDisposable
    {
        /// <summary>
        /// The resolved object.
        /// </summary>
        T Object { get; }
    }
}
