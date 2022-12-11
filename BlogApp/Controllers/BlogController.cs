using BlogApp.Models;
using BlogApp.ViewModel;
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
            using (BlogContext context = new BlogContext())
            {
                var categories = context.Categories.ToList();

                var blogCategoryModel = new BlogCategoryModel();
                
                blogCategoryModel.Categories= categories;
                return View(blogCategoryModel);
            }
            

        }

        [HttpPost]
        public IActionResult WriteBlog(BlogCategoryModel blogCategoryModel)
        {
            using (BlogContext context = new BlogContext())
            {

                //var category = context.Categories.Where(i => i.CategoryName == blogCategoryModel.Category.CategoryName)
                //    .SingleOrDefault();

                //category.Blogs.Add(blogCategoryModel.Blog);
                //context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult GetAll()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

      

    }
}
