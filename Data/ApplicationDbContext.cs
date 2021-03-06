﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Capstone_Proj.Models;

namespace Capstone_Proj.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Name = "Guide",
                    NormalizedName = "GUIDE"
                }
                );
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                }
                );
            base.OnModelCreating(builder);
            builder.Entity<WeatherForecast>(daily =>
            {
                daily.HasNoKey();
            });
        

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AreaOfExpertise> Spots { get; set; }
        public DbSet<FishingTrip> FishingTrips { get; set; }
        public DbSet<Inbox> Inboxes { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
