using ProductStock.Core.Entities;
using ProductStock.Core.IRepositories;
using ProductStock.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStock.Data.Repositories
{
    public class StockRepository:Repository<Stock>, IStockRepository
    {
        public StockRepository(StockDbContext context):base(context)
        {
        }
    }
}
