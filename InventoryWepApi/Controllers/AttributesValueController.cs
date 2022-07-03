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
    public class AttributesValueController : ControllerBase
    {
        private readonly IAttributesValueService attributesValueService;

        public AttributesValueController(IAttributesValueService _attributesValueService)
        {
            attributesValueService = _attributesValueService;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(AttributesValue attributesValue)
        {

            attributesValueService.Insert(attributesValue);
        }
        [HttpGet]
        [Route("LoadAll")]
        public List<AttributesValue> LoadAll()
        {
            return attributesValueService.LoadAll();
        }
        [HttpGet]
        [Route("LoadByName")]
        public List<AttributesValue> LoadByName(string name)
        {
            return attributesValueService.LoadByname(name);
        }
        [HttpGet]
        [Route("Delete")]
        public void Delete(int Id)
        {
           
            attributesValueService.Delete(Id);

        }
        [HttpGet]
        [Route("LoadById")]
        public List<AttributesValue> LoadById(int Id)
        {

           return attributesValueService.LoadBy(Id);

        }
        [HttpPost]
        [Route("Update")]
        public void Update(AttributesValue attributesValue)
        {
            
            attributesValueService.Update(attributesValue);

        }
      
        

    }
}
