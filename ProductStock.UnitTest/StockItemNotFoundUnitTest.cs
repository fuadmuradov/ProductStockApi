using NUnit.Framework;
using ProductStock.Service.Iservices;

namespace ProductStock.UnitTest
{
    public class StockItemNotFoundUnitTest
    {
        private readonly IStockService stockService;
        public StockItemNotFoundUnitTest(IStockService stockService)
        {
            this.stockService = stockService;
        }

        [Test]
        public void Product_IdIsNotExist_ThrowItemNotFoundException()
        {
            var result = stockService.GetStockAsync(23);
            if (result == null) Assert.Pass();
            else Assert.Fail();
        }
    }
}