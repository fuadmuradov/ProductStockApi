using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStock.Service.DTOs.StockDto
{
    public class StockGetDto
    {
        public int ProductId { get; set; }
        public int ProductCount { get; set; }
    }
}
