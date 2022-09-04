using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStock.Core.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductCount { get; set; }
    }
}
