using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlogApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BlogContext _context;

        public CategoryController(BlogContext context)
        {

            _context= context;
        }
        public IActionResult Index()
        {
                var categories = _context.Categories.ToList();
                return View(categories);

        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            if(ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return Content("Fucked up");
        }

        public IActionResult Blogs(int categoryId)
        {
            var blogs = _context.Blogs.Where(i => i.CategoryId == categoryId).ToList();
            return View(blogs);
        }

    }
}
