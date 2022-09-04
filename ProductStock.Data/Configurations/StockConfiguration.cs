using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductStock.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStock.Data.Configurations
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.Property(x => x.ProductId).IsRequired(true);
            builder.Property(x => x.ProductCount).IsRequired(true);
        }
    }
}
