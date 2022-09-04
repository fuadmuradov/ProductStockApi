using ProductStock.Service.DTOs.StockDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductStock.Service.Iservices
{
    public interface IStockService
    {
        Task<StockGetDto> AddStockAsync(StockPostDto postDto);
        Task<StockGetDto> RemoveStockAsync(StockPostDto postDto);
        Task<StockGetDto> GetStockAsync(int id);
        //Task DeleteProductCategoryAsync(int id);
    }
}
