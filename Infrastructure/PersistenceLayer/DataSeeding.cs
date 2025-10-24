using DomainLayer.Contracts;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using PersistenceLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PersistenceLayer
{
    public class DataSeeding (StorDbContext _storDbContext): IDataSeeding
    {
        public void DataSeed()
        {
            try
            {
                if (_storDbContext.Database.GetAppliedMigrations().Any())
                {
                    _storDbContext.Database.Migrate();
                }

                if (!_storDbContext.ProductBrand.Any())
                {
                    var productBrandData = File.ReadAllText(@"..\Infrastructure\PersistenceLayer\Data\DataSeed\brands.json");

                    var brand = JsonSerializer.Deserialize<List<ProductBrand>>(productBrandData);

                    if (brand is not null && brand.Any())
                    {
                        _storDbContext.ProductBrand.AddRange(brand);
                    }
                }
                if (!_storDbContext.ProductType.Any())
                {
                    var productTypeData = File.ReadAllText(@"..\Infrastructure\PersistenceLayer\Data\DataSeed\types.json");

                    var type = JsonSerializer.Deserialize<List<ProductType>>(productTypeData);

                    if (type is not null && type.Any())
                    {
                        _storDbContext.ProductType.AddRange(type);
                    }
                }
                if (!_storDbContext.ProductBrand.Any())
                {
                    var productsData = File.ReadAllText(@"..\Infrastructure\PersistenceLayer\Data\DataSeed\products.json");

                    var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                    if (products is not null && products.Any())
                    {
                        _storDbContext.Products.AddRange(products);
                    }
                }

                _storDbContext.SaveChanges();
            }
            catch (Exception ex) { }
        }

    }
}
