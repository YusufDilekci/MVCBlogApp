using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            using (BlogContext context = new BlogContext())
            {
                var categories = context.Categories.ToList();
                return View(categories);

            }


        }

        public IActionResult AddCategory()
        {
            return View();
        }

        public IActionResult Blogs()
        {
            return View();
        }

    }
}
