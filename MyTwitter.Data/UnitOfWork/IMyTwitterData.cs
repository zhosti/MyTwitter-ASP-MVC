
namespace MyTwitter.Data.UnitOfWork
{
    using MyTwitter.Data.Repository;
    using MyTwitter.Model;

    public interface IMyTwitterData
    {
        IRepository<User> Users { get; }

        int Save();
    }
}
