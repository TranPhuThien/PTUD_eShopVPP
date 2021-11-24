using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PTUD_eShopVPP.Application.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTUD_eShopVPP.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;

        public ProductsController(IPublicProductService publicProductService,
            IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }

        //http://localhost:port/product
        //[HttpGet("{languageId}")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _publicProductService.GetAll();
            return Ok(products);
        }
    }
}
