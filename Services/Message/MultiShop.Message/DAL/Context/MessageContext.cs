using Microsoft.EntityFrameworkCore;
using ECommerce.Message.DAL.Entities;

namespace ECommerce.Message.DAL.Context
{
    public class MessageContext : DbContext
    {
        public MessageContext(DbContextOptions<MessageContext> options) : base(options)
        {

        }
        public DbSet<UserMessage> UserMessages { get; set; }
    }
}
