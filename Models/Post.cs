namespace EF_Blogs_Post.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        // navigation properties
        public virtual Blog Blog { get; set; }
        
    }
}
