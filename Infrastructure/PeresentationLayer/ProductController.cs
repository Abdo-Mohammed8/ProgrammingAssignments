using Microsoft.AspNetCore.Mvc;
using ServiceAbstractionLayer;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeresentationLayer
{
    [ApiController]
    [Route("api/[Controller]")]

    public class ProductController (IServiceManager _serviceManager) :ControllerBase 
    {
        [HttpGet]

        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProduct()
        {
            var products = await _serviceManager.ProductService.GetAllProductsAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProductById(int id)
        {
            var product = await _serviceManager.ProductService.GetProductByIdAsync(id);
            return Ok(product);
        }

        [HttpGet("brands")]

        public async Task<ActionResult<BrandDto>> GetAllBrands()
        {
            var brands = await _serviceManager.ProductService.GetAllBrandsAsync();
            return Ok(brands);
        }
        [HttpGet("types")]

        public async Task<ActionResult<TypeDto>> GetAllTypes()
        {
            var types = await _serviceManager.ProductService.GetAllTypesAsync();
            return Ok(types);

        }

    }
}
