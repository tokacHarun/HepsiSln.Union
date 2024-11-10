﻿using HepsiSln.Application.DTOs;
using HepsiSln.Domain.Entities;
using MediatR;

namespace HepsiSln.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandRequest : IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public IList<int> CategoryIdss { get; set; }
    }
}