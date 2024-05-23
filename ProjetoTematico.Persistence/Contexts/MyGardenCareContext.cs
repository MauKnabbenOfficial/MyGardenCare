using Microsoft.EntityFrameworkCore;
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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=teste.db");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AccessProfile>(accessProfile =>
        //    {
        //        accessProfile.HasKey
        //    });
        //}
    }
}
