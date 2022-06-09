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
                opt.HasKey(opt => opt.IdInspection);
                opt.HasOne(opt => opt.Car)
                .WithMany(opt=> opt.Inspections)
                .HasForeignKey(opt=> opt.IdCar);
                opt.HasOne(opt => opt.Mechanic)
                .WithMany(opt => opt.Inspections)
                .HasForeignKey(opt => opt.IdMechanic);
                opt.Property(opt => opt.InspectionDate).IsRequired();
                opt.Property(opt => opt.Comment).HasMaxLength(300);




            });
            modelBuilder.Entity<Car>(opt=>
            {
                opt.HasKey(o => o.IdCar);
                opt.Property(o => o.Name).HasMaxLength(50).IsRequired();
                opt.Property(o => o.ProductionYear).IsRequired();

            });
            modelBuilder.Entity<Mechanic>(opt=>
            {
                opt.HasKey(o => o.IdMechanic);
                opt.Property(o => o.FirstName).HasMaxLength(20).IsRequired();
                opt.Property(o => o.LastName).HasMaxLength(30).IsRequired();
            });
            modelBuilder.Entity<ServiceTypeDict>();
            modelBuilder.Entity<ServiceTypeDictInspection>();
        }

    }
}
