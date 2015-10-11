using MyTwitter.Data;

namespace MyTwitter.App.Controllers
{
    using System.Web.Mvc;
    using MyTwitter.Data.UnitOfWork;
    using MyTwitter.Model;

    public abstract class BaseController : Controller
    {
        private IMyTwitterData data;
        protected BaseController(IMyTwitterData data)
        {
            this.Data = data;
        }

        protected BaseController()
            : this(new MyTwitterData(new ApplicationDbContext()))
        {
        }

        protected IMyTwitterData Data { get; private set; }
    }
}