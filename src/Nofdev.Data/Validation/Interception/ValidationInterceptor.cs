using Nofdev.Application.Services;
using Nofdev.Aspects;
using Nofdev.Dependency;
using Castle.DynamicProxy;

namespace Nofdev.Data.Validation.Interception
{
    /// <summary>
    /// This interceptor is used intercept method calls for classes which's methods must be validated.
    /// </summary>
    public class ValidationInterceptor : IInterceptor
    {
        private readonly IIocResolver _iocResolver;

        public ValidationInterceptor(IIocResolver iocResolver)
        {
            _iocResolver = iocResolver;
        }

        public void Intercept(IInvocation invocation)
        {
            if (NofdevCrossCuttingConcerns.IsApplied(invocation.InvocationTarget, NofdevCrossCuttingConcerns.Validation))
            {
                invocation.Proceed();
                return;
            }

            using (var validator = _iocResolver.ResolveAsDisposable<MethodInvocationValidator>())
            {
                validator.Object.Initialize(invocation.Method, invocation.Arguments);
                validator.Object.Validate();
            }
            
            invocation.Proceed();
        }
    }
}
