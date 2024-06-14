using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjetoTematico.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Persistence
{
    public class MyGardenCareContext : DbContext
    {

        public DbSet<AccessProfile> AccessProfiles { get; set; }
        public DbSet<Care> Cares { get; set; }
        public DbSet<Garden> Gardens { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Report> Reports { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Works> Works { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string outputPath = Directory.GetCurrentDirectory();
            string databasePath = Path.Combine(outputPath, "teste.db");
            optionsBuilder.UseSqlite($"Data Source={databasePath}");

            //optionsBuilder.UseSqlite("Data Source=./database/teste.db");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }
    }
}
