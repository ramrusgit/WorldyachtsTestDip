﻿using System.Data.Entity;

namespace WorldyachtsBl.Model
{
    public class CrmContext : DbContext
    {
        /// <summary>
        /// This class contains the database context.
        /// </summary>
        public CrmContext() : base("Worldyachts") { }

        public DbSet<Check> Checks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }
}
