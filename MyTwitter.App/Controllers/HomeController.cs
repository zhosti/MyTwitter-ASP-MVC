using System.Linq;
using System.Web;
using MyTwitter.App.Models;

namespace MyTwitter.App.Controllers
{
    using System.Web.Mvc;
    public class HomeController : BaseController
    {
        public ActionResult Index(int page = 1)
        {
            if (page < 1)
            {
                throw new HttpException(400, "Bad Request");
            }

            var tweets = this.Data.Tweets.All()
                .OrderBy(t => t.TimeStamp)
                .Select(TweetViewModel.Create)
                .Skip((page - 1) * 10)
                .Take(10)
                .ToList();
            this.ViewBag.Page = page;

            return View(tweets);
        }

    }
}