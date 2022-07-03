using InventoryBusiness_Logic.specificRepository;
using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
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
    public class BrandController : ControllerBase
    {
        private readonly IBrandService brandservice;
        

        public BrandController(IBrandService _brandservice)
        {
            brandservice = _brandservice;
           
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(Brand brand) {

            brandservice.Insert(brand);
        }
        [HttpGet]
        [Route("LoadAll")]
        public List<Brand> LoadAll()
        {
           return brandservice.LoadAll();
        }
        [HttpGet]
        [Route("LoadByName")]
        public List<Brand> LoadByName(string name)
        {
            return brandservice.LoadByname(name);
        }
        [HttpGet]
        [Route("Delete")]
        public void Delete(int Id)
        {
            brandservice.Delete(Id);
           
        }
        [HttpPost]
        [Route("Update")]
        public void Update(Brand brand)
        {
            brandservice.Update(brand);

        }
    }
}
