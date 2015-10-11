namespace MyTwitter.Data.Repository
{
    using System;
    using System.Linq;

    public interface IRepository<T> : IDisposable

    {
        IQueryable<T> All();

        T Find(object id);

        T Add(T entity);

        T Update(T entity);

        void Delete(T entity);
    }
}
