using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Tema6.Entities;

namespace Tema6.Database
{
    class CarDealershipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDb;Initial Catalog=CarDealership;");
        }

        public DbSet<ModelCar> ModelCar { get; set; }

        public DbSet<Brand> Brand { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Inventory> Inventory { get; set; }

        public DbSet<ActualFeature> ActualFeature { get; set; }
        public DbSet<PossibleFeature> PossibleFeature { get; set; }

        public DbSet<PotentialCustomer> PotentialCustomer { get; set; }
    }
}
