using EF_Blogs_Post.Models;
using System.Linq;


namespace EF_Blogs_Post
{
    public class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            do
            {
                Console.WriteLine("\nEnter your selection:");
                Console.WriteLine("1) Display all Blogs\n2) Add Blog\n3) Display Posts\n4) Add Post");
                Console.WriteLine("Enter q to quit");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    using (var context = new BlogContex())
                    {
                        var blogList = context.Blogs.ToList();
                
                        Console.WriteLine("\nThe blogs are:");
                        foreach (var blog in blogList)
                        {
                            Console.WriteLine($"   {blog.Name}");
                        }
                    }
                }
                else if (choice == "2")
                {
                    using (var context = new BlogContex())
                    {
                        Console.WriteLine("\nEnter a name for a new Blog:");
                        var blogName = Console.ReadLine();

                        var blog = new Blog();
                        blog.Name = blogName;

                        context.Blogs.Add(blog);
                        context.SaveChanges();
                    }
                }
                else if (choice == "3")
                {
                    using (var context = new BlogContex())
                    {
                        var postsList = context.Posts.ToList();

                        Console.WriteLine("\nThe posts are:");
                        foreach (var post in postsList)
                        {
                            Console.WriteLine($"Blog: {post.Blog.Name}");
                            Console.WriteLine($"   {post.Title}");
                        }
                    }
                }
                else if (choice == "4")
                {
                    using (var context = new BlogContex())
                    {
                        Console.WriteLine("\nEnter a post title");
                        var title = Console.ReadLine();
                        Console.WriteLine("Enter post content");
                        var content = Console.ReadLine();
                        Console.WriteLine("Which blog?");
                        var blogId = Console.ReadLine();

                        var post = new Post();
                        post.Title = title;
                        post.Content = content;
                        post.BlogId = Convert.ToInt32(blogId);

                        context.Posts.Add(post);
                        context.SaveChanges();
                    }
                }

            } while (choice != "q");
        }
    }
}