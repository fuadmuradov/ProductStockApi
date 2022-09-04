using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductStock.Service.DTOs.StockDto;
using ProductStock.Service.Iservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStock.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IStockService stockService;
        public StocksController(IStockService stockService)
        {
            this.stockService = stockService;
        }

        [Route("GetStock/{id}")]
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var response = await stockService.GetStockAsync(id);
            return Ok(response);
        }

        [Route("AddStock")]
        [HttpPut]
        public async Task<IActionResult> Add(StockPostDto postDto)
        {
            var response = stockService.AddStockAsync(postDto);
            return Ok(response);
        }

        [Route("RemoveStock")]
        [HttpPut]
        public async Task<IActionResult> Remove(StockPostDto postDto)
        {
            var response = stockService.RemoveStockAsync(postDto);
            return Ok(response);
        }
    }
}
