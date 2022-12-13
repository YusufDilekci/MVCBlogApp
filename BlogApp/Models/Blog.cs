

namespace BlogApp.Models
{
    public class Blog 
    {
        public int BlogId { get; set; }
        public int CategoryId { get; set; }
        public string BlogTitle { get; set;}
        public string BlogContent { get; set;}
        public virtual Category? Category { get; set; }
    }
}
