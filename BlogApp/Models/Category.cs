﻿

namespace BlogApp.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImage { get; set; }
        public virtual ICollection<Blog>? Blogs { get; set; }

    }
}
