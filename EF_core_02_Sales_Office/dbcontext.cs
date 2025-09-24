using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_core_02_Sales_Office
{
    internal class dbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=.;Database=new_Sales_Office_02;Trusted_Connection=True;TrustServerCertificate=True;").UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owned_Property>()
                .HasKey(op => new { op.Owner_id, op.Property_id });


            modelBuilder.Entity<Owned_Property>()
                .HasOne(o => o.Owner)
                .WithMany(op => op.Owned_Properties)
                .HasForeignKey(o => o.Owner_id);

            modelBuilder.Entity<Owned_Property>()
               .HasOne(p => p.Property)
               .WithMany(op => op.Owned_Properties)
               .HasForeignKey(o => o.Property_id);
            /////////////////////////////////////////////////
            modelBuilder.Entity<Employee>()
               .HasOne(e => e.SalesOffice)
               .WithMany(s => s.Employees)
               .HasForeignKey(e => e.SalesOfficeId);
              // .IsRequired()
              // هنا كان في cascade وشلتها 
            ///////////////////////////////////////////////
            modelBuilder.Entity<Property>()
               .HasOne(p => p.SalesOffice)
               .WithMany(s => s.Properties)
               .HasForeignKey(p => p.SalesOfficeId)
               //.IsRequired()
               .OnDelete(DeleteBehavior.Cascade);
            ////////////////////////////////////////////////
            modelBuilder.Entity<Sales_Office>()
                .HasOne(s => s.Manager)
                .WithOne(e => e.ManagedOffice)
                .HasForeignKey<Sales_Office>(s => s.ManagerId)
               // .IsRequired()
               // الحذف هنا غيرتو 
                .OnDelete(DeleteBehavior.SetNull);

        }


    }
}
