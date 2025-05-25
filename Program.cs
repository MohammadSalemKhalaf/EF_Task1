using EF_task1.Data;
using EF_task1.Models;

namespace EF_task1;

internal class Program
{
    public static AppDbContext Db = new AppDbContext();
   public static void Main(string[] args)
    {
        var user = new User() {Name="ahmad",Email="ahmad@gmail.com",Password="123456" };
        Db.Users.Add(user);
        List<Blog> blogs  =new List<Blog>() {
            new Blog(){Title="facebook post", Description="vacation",User=user },
            new Blog(){Title="facebook post", Description="post",User=user },
            new Blog(){Title="facebook reel", Description="vacation",User=user },
            new Blog(){Title="instagram", Description="vacation",User=user },
            new Blog(){Title="facebook", Description="vacation",User=user }
        };
        Db.Blogs.AddRange(blogs);
        Db.SaveChanges();
    }
}
