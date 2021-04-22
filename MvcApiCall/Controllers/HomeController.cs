using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;
using System.Collections.Generic;

namespace MvcApiCall.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Article> allArticles = Article.GetArticles(EnvironmentVariables.ApiKey);
            return View(allArticles);
        }
    }
}