using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nofdev.Data.Services
{
    public interface IAvoidDuplicateCrossCuttingConcerns
    {
        List<string> AppliedCrossCuttingConcerns { get; }
    }
}
