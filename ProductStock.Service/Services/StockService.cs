using AutoMapper;
using ProductStock.Core;
using ProductStock.Core.Entities;
using ProductStock.Service.DTOs.StockDto;
using ProductStock.Service.Exceptions;
using ProductStock.Service.Iservices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductStock.Service.Profiles
{
    public class StockService : IStockService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public StockService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<StockGetDto> AddStockAsync(StockPostDto postDto)
        {
            Stock stock = await unitOfWork.StockRepository.GetAsync(x => x.ProductId == postDto.ProductId);
            if (stock == null)
                throw new ItemNotFoundException($"Item Not Found by Id({postDto.ProductId})");
            stock.ProductCount += postDto.ProductCount;
            await unitOfWork.StockRepository.SaveDbAsync();
            StockGetDto stockGet = mapper.Map<StockGetDto>(stock);
            return stockGet;
        }


        public async Task<StockGetDto> GetStockAsync(int id)
        {
            Stock stock = await unitOfWork.StockRepository.GetAsync(x => x.ProductId == id);
            if (stock == null)
                throw new ItemNotFoundException($"Item Not Found by Id({id})");
            StockGetDto stockGet = mapper.Map<StockGetDto>(stock);
            return stockGet;
        }

        public async Task<StockGetDto> RemoveStockAsync(StockPostDto postDto)
        {
            Stock stock = await unitOfWork.StockRepository.GetAsync(x => x.ProductId == postDto.ProductId);
            if (stock == null)
                throw new ItemNotFoundException($"Item Not Found by Id({postDto.ProductId})");
            if ((stock.ProductCount - postDto.ProductCount) < 0)
                throw new CountNotEnoughException($"{postDto.ProductCount} - Already Not Exist");
            else
            {
                stock.ProductCount -= postDto.ProductCount;
                await unitOfWork.StockRepository.SaveDbAsync();
            }

            StockGetDto stockGet = mapper.Map<StockGetDto>(stock);
            return stockGet;
        }
    }
}
