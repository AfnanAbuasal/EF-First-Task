using EF_Task1.Data;
using EF_Task1.Models;

namespace EF_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            User afnan = new User() { Name = "Afnan", Email = "afnanalaa49@gmail.com", Password = "1234" };
            User yasmeen = new User() { Name = "Yasmeen", Email = "yasmeen.bsharat@gmail.com", Password = "0000" };

            List<Blog> blogs = new List<Blog> {
                new Blog { Title = "Getting Started with EF Core", Description = "A beginner’s guide to Entity Framework Core.", User = afnan },
                new Blog { Title = "ASP.NET Core Tips", Description = "Handy tips for working with ASP.NET Core projects.", User = afnan },
                new Blog { Title = "C# LINQ Essentials", Description = "Understand the power of LINQ with practical examples.", User = afnan },
                new Blog { Title = "Deploying to Azure", Description = "How to deploy .NET apps to Microsoft Azure.", User = yasmeen },
                new Blog { Title = "Top 10 VS Shortcuts", Description = "Speed up your development with Visual Studio shortcuts.", User = yasmeen }
            };

            context.Users.Add(afnan);
            context.Users.Add(yasmeen);

            context.Blogs.AddRange(blogs);

            context.SaveChanges();
        }
    }
}
