using ECommerce.Comment.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Comment.Context
{
    public class CommentContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1442;initial Catalog=ECommerceCommentDb;User=sa;Password=123456aA*");
        }

        public DbSet<UserComment> UserComments { get; set; }
    }
}
