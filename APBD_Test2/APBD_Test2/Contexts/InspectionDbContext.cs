using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using APBD_Test2.Entities;


namespace APBD_Test2.Contexts
{
    public class InspectionDbContext: DbContext
    {
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<ServiceTypeDict> serviceTypeDicts { get; set; }
        public DbSet<ServiceTypeDictInspection> serviceTypeDictInspections { get; set; }

        public InspectionDbContext()
        {

        }
        public InspectionDbContext(DbContextOptions options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Inspection>(opt =>
            {
                opt.HasKey(opt=>opt.IdInspection);
                opt.HasOne(opt => opt.idCar);

                opt.HasKey(opt => opt.InspectionDate);
                opt.Property(opt => opt.Comment).HasMaxLength(300);




            })
        }

    }
}
