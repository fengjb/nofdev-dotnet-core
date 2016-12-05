using Nofdev.Data.Dependency;
using Nofdev.Data.Services;
using System.Reflection;
using Castle.Core;

namespace Nofdev.Data.Validation.Interception
{
    internal static class ValidationInterceptorRegistrar
    {
        public static void Initialize(IIocManager iocManager)
        {
            iocManager.IocContainer.Kernel.ComponentRegistered += Kernel_ComponentRegistered;
        }

        /// <summary>
        /// IHandler和InterceptorReference也是castleWindsor中的接口，该方法还未迁移到core中，有毒啊
        /// </summary>
        /// <param name="key"></param>
        /// <param name="handler"></param>
        private static void Kernel_ComponentRegistered(string key, IHandler handler)
        {
            if (typeof(IApplicationService).IsAssignableFrom(handler.ComponentModel.Implementation))
            {
                handler.ComponentModel.Interceptors.Add(new InterceptorReference(typeof(ValidationInterceptor)));
            }
        }
    }
}