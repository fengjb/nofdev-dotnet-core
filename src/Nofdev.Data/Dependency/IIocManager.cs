using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nofdev.Data.Dependency
{
    /// <summary>
    /// This interface is used to directly perform dependency injection tasks.
    /// </summary>
    public interface IIocManager : IIocRegistrar, IIocResolver, IDisposable
    {
        /// <summary>
        /// Reference to the Castle Windsor Container.
        /// 这个是castleWindsor中的接口，该方法还未迁移到core中，有毒啊
        /// </summary>
        IWindsorContainer IocContainer { get; }

        /// <summary>
        /// Checks whether given type is registered before.
        /// </summary>
        /// <param name="type">Type to check</param>
        new bool IsRegistered(Type type);

        /// <summary>
        /// Checks whether given type is registered before.
        /// </summary>
        /// <typeparam name="T">Type to check</typeparam>
        new bool IsRegistered<T>();
    }
}
