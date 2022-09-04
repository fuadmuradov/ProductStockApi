using AutoMapper;
using ProductStock.Core.Entities;
using ProductStock.Service.DTOs.StockDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStock.Service.Profiles
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Stock, StockGetDto>();
            CreateMap<StockPostDto, Stock>();
        }
    }
}
