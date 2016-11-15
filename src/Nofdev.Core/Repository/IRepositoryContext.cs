﻿using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Nofdev.Core.Domain;

namespace Nofdev.Core.Repository
{
    /// <summary>
    /// 仓储上下文接口
    /// </summary>
    public interface IRepositoryContext : IRepositoryRegistration
    {
        int SaveChanges();

        //UnitOfWork Unit { get; }

        //string DbName { get; set; }
        /// <summary>
        /// 通过主键获取对象
        /// </summary>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        T Get<T>(params object[] keyValues) where T: class,new();

        IQueryable<T> Queryable<T>() where T : class, new();

        ITenantContext TenantContext { get; set; }
    }

    public interface IRepositoryContextAsync : IRepositoryContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<int> SaveChangesAsync();
    }

    public abstract class RepositoryContext : IRepositoryContext
    {
        #region Implementation of IDisposable

        public abstract void Dispose();

        #endregion

        #region Implementation of IRepositoryRegistration

        public void Add<T>(T entity) where T : class, new()
        {
            TenantContext.AssignTenantId(entity);

            DoAdd(entity);

        }

        protected abstract void DoAdd<T>(T entity) where T : class, new();

        public void Update<T>(T entity) where T : class, new()
        {
            TenantContext.CheckTenant(entity);
            DoUpdate(entity);
        }

        protected abstract void DoUpdate<T>(T entity) where T : class, new();

        public void Delete<T>(T entity) where T : class, new()
        {
            TenantContext.CheckTenant(entity);
            DoDelete(entity);
        }

        protected abstract void DoDelete<T>(T entity) where T : class, new();

        #endregion

        #region Implementation of IRepositoryContext

        public abstract int SaveChanges();

        public T Get<T>(params object[] keyValues) where T : class, new()
        {
            var entity = DoGet<T>(keyValues);
            TenantContext.CheckTenant(entity);
            return entity;
        }

        protected abstract T DoGet<T>(params object[] keyValues) where T : class, new();

        public  IQueryable<T> Queryable<T>() where T : class, new()
        {
            return GetQueryable<T>();
        }


        protected abstract IQueryable<T> GetQueryable<T>() where T : class, new();

        public ITenantContext TenantContext { get; set; }

        #endregion
    }
}