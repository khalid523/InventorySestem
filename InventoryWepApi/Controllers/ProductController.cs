using InventoryBusiness_Logic.specificRepository;
using InventoryDataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryWepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly ICateogryService cateogryService;
        private readonly IBrandService brandService;
        private readonly IStoresService storesService;
        private readonly IAttributesValueService attributesValueService;

        public ProductController(IProductService _ProductService,ICateogryService _cateogryService,IBrandService _brandService,IStoresService _storesService,IAttributesValueService _attributesValueService)
        {
            productService = _ProductService;
            cateogryService = _cateogryService;
            brandService = _brandService;
            storesService = _storesService;
            attributesValueService = _attributesValueService;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(Product product)
        {
           
            productService.Insert(product);
        }
        [HttpGet]
        [Route("LoadAll")]
        public List<Product> LoadAll()
        {
        
            return productService.LoadAll();
        }
        [HttpGet]
        [Route("Delete")]
        public void Delete(int Id)
        {
           
            productService.Delete(Id);
            
        }
        public void Update(Product product)
        {
            
            productService.Update(product);

        }
        [HttpGet]
        [Route("loadBYLoadId")]
        public Product loadBYLoadId(int Id)
        {

            return productService.loadById(Id);
        }
    }
}
