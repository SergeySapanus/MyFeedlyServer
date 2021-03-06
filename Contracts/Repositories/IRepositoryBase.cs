﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyFeedlyServer.Contracts.Repositories
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> FindAll();
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

        void Save();

        Task<IEnumerable<T>> FindAllAsync();
        Task<IEnumerable<T>> FindByConditionAync(Expression<Func<T, bool>> expression);
        Task SaveAsync();
    }
}