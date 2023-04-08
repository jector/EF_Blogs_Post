using System.ComponentModel.DataAnnotations;

namespace EF_Blogs_Post.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        
        //navigation property
        public virtual List<Post> Posts { get; set; }
    }
}

