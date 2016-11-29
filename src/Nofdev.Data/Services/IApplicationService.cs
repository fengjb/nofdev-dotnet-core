using Nofdev.Data.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nofdev.Data.Services
{
    /// <summary>
    /// This interface must be implemented by all application services to identify them by convention.
    /// </summary>
    public interface IApplicationService : ITransientDependency
    {

    }
}
