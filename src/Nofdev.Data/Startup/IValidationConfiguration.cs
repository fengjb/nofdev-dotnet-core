using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nofdev.Data.Startup
{
    public interface IValidationConfiguration
    {
        List<Type> IgnoredTypes { get; }
    }
}
