using System;
using Microsoft.EntityFrameworkCore;

namespace Taskly.Classes
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Wish> Wishes => Set<Wish>();
        public DbSet<MyTask> Tasks => Set<MyTask>();
        public UserContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=usersDb.db");
        }
    }
}
