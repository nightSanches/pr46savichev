using System;
using pr45savichev.Model;
using Microsoft.EntityFrameworkCore;

namespace pr45savichev.Context
{
    public class TaskContext : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }
        public TaskContext()
        {
            Database.EnsureCreated();
            Tasks.Load();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql("server=127.0.0.1;port=3306;database=Base44;uid=root;pwd=", new MySqlServerVersion(new Version(8, 0, 11)));
    }
}
