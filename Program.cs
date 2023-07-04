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
                //var tag = new Tag { Name = ".NET", Slug = "dotnet" };
                //context.Tags.Add(tag);  
                //context.SaveChanges();

                //Update
                //var tag = context.Tags.FirstOrDefault(x=>x.Id == 3);
                //tag.Name = ".NET";
                //tag.Slug = "dotnet";
                //context.Update(tag);
                //context.SaveChanges();

                //Delete
                //var tag = context.Tags.FirstOrDefault(x => x.Id == 3);
                //context.Remove(tag);
                //context.SaveChanges();

                //ToList
                var tags = context
                    .Tags
                    .Where(x => x.Name.Contains(".NET"))
                    .ToList();

                foreach(var tag in tags) 
                {
                    Console.WriteLine(tag.Name);
                }

            }
        }
    }
} 