using Blog.Data;
using Blog.Models;

namespace Blog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new BlogDataContext()) 
            {
                //Create
                //var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
                //context.Tags.Add(tag);  
                //context.SaveChanges();

                //Update
                var tag = context.Tags.FirstOrDefault(x=>x.Id == 3);
                tag.Name = ".NET";
                tag.Slug = "dotnet";

                context.Update(tag);
                context.SaveChanges();
                
            }
        }
    }
} 