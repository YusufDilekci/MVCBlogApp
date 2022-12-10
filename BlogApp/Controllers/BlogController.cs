using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult WriteBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriteBlog(BlogCategoryUser blogCategoryUser)
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return View();
        }

        public IActionResult GetBlogById()
        {
            return View();
        }

        public IActionResult GetBlogByCategory()
        {
            return View();
        }

    }
}
