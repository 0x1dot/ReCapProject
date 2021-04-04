﻿using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class ReCapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCapProject;Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //modelBuilder.HasDefaultSchema("admin");//şema
        //modelBuilder.Entity<Color>().ToTable("Clr");
        //Color tablomuzun aslında isminin Clr olduğunu varsayarsak
        //ve Color nesnemize yönlendirmek istersek bu yöntemi kullanıcaz.
        //modelBuilder.Entity<Color>().Property(p => p.ColorId).HasColumnName("ColorId");//özelliklerin veritabanı ile ilişkilendirilmesi
        //}
    }
}