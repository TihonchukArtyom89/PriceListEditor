﻿using PriceListEditor.WebApplication.Models;

namespace PriceListEditor.WebApplication.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<Category> Categories { get; }
        void SaveProduct(Product p);
        void CreateProduct(Product p);
        void DeleteProduct(Product p);
    }
}