using Bloggie.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Data
{
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions options) : base(options)
        {
        }

        //We create property of datatype DbSet which represents tables.
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
