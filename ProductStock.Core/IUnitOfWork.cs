using ProductStock.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStock.Core
{
    public interface IUnitOfWork
    {
        public IStockRepository StockRepository { get;}
    }
}
