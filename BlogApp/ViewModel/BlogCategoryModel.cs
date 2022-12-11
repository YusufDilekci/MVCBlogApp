using BlogApp.Models;

namespace BlogApp.ViewModel
{
    public class BlogCategoryModel
    {
        public Blog Blog { get; set; }
        public List<Category> Categories { get; set; }
        public Category Category { get; set; }
    }
}
