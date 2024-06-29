﻿using ECommerce.Message.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ECommerce.Message.DAL.Context
{
    public class MessageContext:DbContext
    {
        public MessageContext(DbContextOptions<MessageContext> options):base(options)
        {
            
        }
        public DbSet<UserMessage> UserMessages { get; set; }
    }
}
