using BlogApp.Models;

namespace BlogApp.ViewModel
{
    public class BlogCategoryModel
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string CategoryName { get; set; }
    }
}
