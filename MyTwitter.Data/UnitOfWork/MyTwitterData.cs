using MyTwitter.Data.Repository;
using MyTwitter.Model;
namespace MyTwitter.Data.UnitOfWork
{
    using System;
    using System.Collections.Generic;
    
    public class MyTwitterData : IMyTwitterData
    {
        private readonly IDictionary<Type, object> repositories;
        public ApplicationDbContext Context { get; private set; }

        public MyTwitterData(ApplicationDbContext context)
        {
            this.Context = context;
            this.repositories = new Dictionary<Type, object>();
        }
        
        public IRepository<User> Users
        {
            get { return this.GetRepository<User>(); }
        }

        public IRepository<Tweet> Tweets
        {
            get { return this.GetRepository<Tweet>(); }
        }
        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var repositoryType = typeof(Repository<T>);
                this.repositories.Add(typeof(T), Activator.CreateInstance(repositoryType, this.Context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
        public int Save()
        {
            return this.Context.SaveChanges();
        }
    }
}
