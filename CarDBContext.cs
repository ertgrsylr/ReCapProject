using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DataAcces.Concrete.EntityFreamwork
{

    public class CarDBContext:DbContext
    {
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
         	optionsBuilder.UseSqlServer();
         }
         
         public DbSet<Car> Cars { get; set; } 
         public DbSet<Brand> Brands { get; set; }
         public DbSet<Color> Colors { get; set; }
    }
}