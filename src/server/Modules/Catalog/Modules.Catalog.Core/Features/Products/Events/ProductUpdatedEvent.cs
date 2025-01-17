﻿using FluentPOS.Shared.Core.Domain;
using System;
using FluentPOS.Modules.Catalog.Core.Entities;

namespace FluentPOS.Modules.Catalog.Core.Features.Products.Events
{
    public class ProductUpdatedEvent : Event
    {
        public Guid Id { get; }
        public string Name { get; }
        public string LocaleName { get; }
        public Guid BrandId { get; }
        public Guid CategoryId { get; }
        public decimal Price { get; }
        public decimal Cost { get; }
        public string ImageUrl { get; }
        public string Tax { get; }
        public string TaxMethod { get; }
        public string BarcodeSymbology { get; }
        public bool IsAlert { get; }
        public decimal AlertQuantity { get; }
        public string Detail { get; }

        public ProductUpdatedEvent(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            LocaleName = product.LocaleName;
            BrandId = product.BrandId;
            CategoryId = product.CategoryId;
            Price = product.Price;
            Cost = product.Cost;
            ImageUrl = product.ImageUrl;
            Tax = product.Tax;
            TaxMethod = product.TaxMethod;
            BarcodeSymbology = product.BarcodeSymbology;
            IsAlert = product.IsAlert;
            AlertQuantity = product.AlertQuantity;
            Detail = product.Detail;
            AggregateId = product.Id;
        }
    }
}