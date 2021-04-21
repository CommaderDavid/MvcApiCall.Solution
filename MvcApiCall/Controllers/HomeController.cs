using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;

namespace MvcApiCall.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Article> allArticles = Article.GetArticles("[YOUR-API-KEY-HERE]");
            return View(allArticles);
        }
    }
}