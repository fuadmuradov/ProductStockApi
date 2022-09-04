using ProductStock.Core;
using ProductStock.Core.IRepositories;
using ProductStock.Data.Contexts;
using ProductStock.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStock.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StockDbContext context;
        private readonly IStockRepository stockRepository;
        public UnitOfWork(StockDbContext context)
        {
            this.context = context;
        }
        public IStockRepository StockRepository => stockRepository ?? new StockRepository(context);
    }
}
