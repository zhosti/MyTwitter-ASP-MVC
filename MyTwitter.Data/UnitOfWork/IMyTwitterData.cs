
namespace MyTwitter.Data.UnitOfWork
{
    using MyTwitter.Data.Repository;
    using MyTwitter.Model;

    public interface IMyTwitterData
    {
        IRepository<User> Users { get; }

        IRepository<Tweet> Tweets { get; }
        int Save();
    }
}
