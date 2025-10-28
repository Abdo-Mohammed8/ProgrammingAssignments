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
        public async Task DataSeedAsync()
        {
            try
            {
                if ((await _storDbContext.Database.GetAppliedMigrationsAsync()).Any())
                {
                    await _storDbContext.Database.MigrateAsync();
                }

                if (!_storDbContext.ProductBrand.Any())
                {
                    //var productBrandData = await File.ReadAllTextAsync(@"..\Infrastructure\PersistenceLayer\Data\DataSeed\brands.json");
                    var productBrandData =  File.OpenRead(@"..\Infrastructure\PersistenceLayer\Data\DataSeed\brands.json");

                    var brand = await JsonSerializer.DeserializeAsync<List<ProductBrand>>(productBrandData);

                    if (brand is not null && brand.Any())
                    {
                       await _storDbContext.ProductBrand.AddRangeAsync(brand);
                    }
                }
                if (!_storDbContext.ProductType.Any())
                {
                    var productTypeData = File.OpenRead(@"..\Infrastructure\PersistenceLayer\Data\DataSeed\types.json");

                    var type = await JsonSerializer.DeserializeAsync<List<ProductType>>(productTypeData);

                    if (type is not null && type.Any())
                    {
                        await _storDbContext.ProductType.AddRangeAsync(type);
                    }
                }
                if (!_storDbContext.ProductBrand.Any())
                {
                    var productsData = File.OpenRead(@"..\Infrastructure\PersistenceLayer\Data\DataSeed\products.json");

                    var products =await JsonSerializer.DeserializeAsync<List<Product>>(productsData);

                    if (products is not null && products.Any())
                    {
                        await _storDbContext.Products.AddRangeAsync(products);
                    }
                }

               await _storDbContext.SaveChangesAsync();
            }
            catch (Exception ex) { }
        }

    }
}
