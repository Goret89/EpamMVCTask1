using System.Data.Entity;

namespace EpamMVCTask1.DLL.Models
{
    public class BlogContext : DbContext
    {
        static BlogContext()
        {
            Database.SetInitializer<BlogContext>(new BlogContextInitializer());
            //Database.SetInitializer(new CreateDatabaseIfNotExists<BlogContext>());
        }
        public BlogContext() : base("BlogContext")
        {
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
   
