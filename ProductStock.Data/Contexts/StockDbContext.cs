using Microsoft.EntityFrameworkCore;
using ProductStock.Core.Entities;
using ProductStock.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStock.Data.Contexts
{
    public class StockDbContext:DbContext
    {
        public StockDbContext(DbContextOptions<StockDbContext> options) : base(options) { }
        public DbSet<Stock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new StockConfiguration());
        }

    }
}
