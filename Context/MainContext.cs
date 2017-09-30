using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WearManager.Models;

namespace WearManager.Context 
{
    class MainContext : DbContext
    {
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Wheel> Wheels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WearManager.db");
        }
    }
}