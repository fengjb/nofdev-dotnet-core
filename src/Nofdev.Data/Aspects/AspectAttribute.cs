using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Nofdev.Data.Aspects
{
    internal abstract class AspectAttribute : Attribute
    {
        public Type InterceptorType { get; set; }

        protected AspectAttribute(Type interceptorType)
        {
            InterceptorType = interceptorType;
        }
    }

    internal interface IAbpInterceptionContext
    {
        object Target { get; }

        MethodInfo Method { get; }

        object[] Arguments { get; }

        object ReturnValue { get; }

        bool Handled { get; set; }
    }
    internal interface IAbpBeforeExecutionInterceptionContext : IAbpInterceptionContext
    {

    }

    internal interface IAbpInterceptor<TAspect>
    {
        TAspect Aspect { get; set; }

        void BeforeExecution(IAbpBeforeExecutionInterceptionContext context);

        void AfterExecution(IAbpAfterExecutionInterceptionContext context);
    }

    internal interface IAbpAfterExecutionInterceptionContext : IAbpInterceptionContext
    {
        Exception Exception { get; }
    }
}
