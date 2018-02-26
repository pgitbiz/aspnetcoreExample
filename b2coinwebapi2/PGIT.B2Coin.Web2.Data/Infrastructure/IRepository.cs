namespace PGIT.B2Coin.Web2.Data.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
        
        void Delete(Expression<Func<T, bool>> where);

        T Get(Expression<Func<T, bool>> where);

        Task<T> GetAsync(Expression<Func<T, bool>> where);

        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync();

        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

        Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> where);

        Task<IEnumerable<T>> GetPageAsync<TOrder>(Page page,
            Expression<Func<T, bool>> where, Expression<Func<T, TOrder>> order);

        Task<IEnumerable<T>> GetPageAsync<TOrder>(Page page,
            Expression<Func<T, TOrder>> order);

        Task<IEnumerable<T>> GetPageDescendingAsync<TOrder>(Page page,
            Expression<Func<T, bool>> where, Expression<Func<T, TOrder>> order);

        Task<IEnumerable<T>> GetPageDescendingAsync<TOrder>(Page page,
            Expression<Func<T, TOrder>> order);

        Task<IEnumerable<T>> GetOrderAsync<TOrder>(Expression<Func<T, bool>> where,
            Expression<Func<T, TOrder>> order);

        Task<IEnumerable<T>> GetOrderAsync<TOrder>(Expression<Func<T, bool>> where,
            Expression<Func<T, TOrder>> order, int takeCount);

        Task<IEnumerable<T>> GetOrderAsync<TOrder>(Expression<Func<T, TOrder>> order,
            int takeCount);

        Task<IEnumerable<T>> GetDescendingAsync<TOrder>(Expression<Func<T, bool>> where,
            Expression<Func<T, TOrder>> order);

        Task<IEnumerable<T>> GetDescendingAsync<TOrder>(Expression<Func<T, bool>> where,
            Expression<Func<T, TOrder>> order, int takeCount);

        Task<IEnumerable<T>> GetDescendingAsync<TOrder>
            (Expression<Func<T, TOrder>> order, int takeCount);

        Task<int> GetCountAsync(Expression<Func<T, bool>> where);
    }
}
