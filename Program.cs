using Blog.Data;

namespace Blog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new BlogDataContext()) { }
        }
    }
} 