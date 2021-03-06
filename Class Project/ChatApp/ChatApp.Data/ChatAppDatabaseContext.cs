﻿using System;
using Microsoft.EntityFrameworkCore;
using ChatApp.Domain.Models;

namespace ChatApp.Data
{
    public class ChatAppDatabaseContext : DbContext
    {
        public ChatAppDatabaseContext(DbContextOptions<ChatAppDatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ChannelMembers>().HasKey(table => new
            {
                table.ChannelId, table.UserId
            });
        }

        public DbSet<User> User { get; set; }
        public DbSet<Channel> Channel { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<ChannelMessages> ChannelMessages { get; set; }
        public DbSet<ChannelMembers> ChannelMembers { get; set; }
    }
}
