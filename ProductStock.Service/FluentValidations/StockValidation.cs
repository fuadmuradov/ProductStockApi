using FluentValidation;
using ProductStock.Core.Entities;
using ProductStock.Service.DTOs.StockDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStock.Service.FluentValidations
{
    public class StockValidation:AbstractValidator<StockPostDto>
    {
        public StockValidation()
        {
            RuleFor(x => x.ProductId).GreaterThan(0);
            RuleFor(x => x.ProductCount).GreaterThanOrEqualTo(0);
        }
    }
}
