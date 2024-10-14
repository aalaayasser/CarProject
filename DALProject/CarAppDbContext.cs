﻿using DALProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DALProject
{
    public class CarAppDbContext : DbContext
    {
        public CarAppDbContext(DbContextOptions<CarAppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
         public DbSet<Category> Categroies { get; set; }
         public DbSet<Service> Services { get; set; }
        public DbSet<Color> Colors{ get; set; }
        public DbSet<Part> Parts { get; set; }


        #region TPC
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        #endregion

    }
}
