namespace MyTwitter.Data.Repository
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class Repository<T> : IRepository<T> where T : class 
    {
        public Repository(ApplicationDbContext context)
        {
            this.Context = context;
            this.DbSet = this.Context.Set<T>();
        }
        protected ApplicationDbContext Context { get; set; }

        protected IDbSet<T> DbSet { get; set; }

        public IQueryable<T> All()
        {
            return this.DbSet.AsQueryable();
        }

        public T GetById(object id)
        {
            return this.DbSet.Find(id);
        }

        public T Find(object id)
        {
            return this.DbSet.Find(id);
        }

        public T Add(T entity)
        {
            this.DbSet.Add(entity);
            return entity;
        }

        public T Update(T entity)
        {
            this.DbSet.AddOrUpdate(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            this.DbSet.Remove(entity);
        }

        public void Dispose()
        {
            this.Context.Dispose();
        }
    }
}
