using BlogApp.Models;
using BlogApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Controllers
{
    
    public class BlogController : Controller
    {
        private readonly BlogContext _context;
        public BlogController(BlogContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult WriteBlog()
        {

                var categories = _context.Categories;

                ViewBag.Categories = categories.ToList();
                return View();
            
            

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult WriteBlog(Blog blog)
        {
 
                if (ModelState.IsValid)
                {
                    _context.Blogs.Add(blog);
                    _context.SaveChanges();

                    return View("Success");

                }
               
                return View("Error");
                
            
        }

        public IActionResult GetAll()
        {
           
            var blogs = _context.Blogs.Select(i => new BlogCategoryModel
            {
                BlogId= i.BlogId,
                BlogTitle = i.BlogTitle,
                BlogContent = i.BlogContent,
                CategoryName = i.Category.CategoryName
            }).ToList();

            return View(blogs);

        }

        public IActionResult Details(int id)
        {
            var blog = _context.Blogs.Where(i => i.BlogId== id).SingleOrDefault();
            return View(blog);
        }
      

    }
}
