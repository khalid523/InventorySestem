using InventoryBusiness_Logic.specificRepository;
using InventoryDataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryWepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributesController : ControllerBase
    {
        private readonly IAttributesService attributesService;

        public AttributesController(IAttributesService _attributesService)
        {
            attributesService = _attributesService;
        }
        [HttpGet]
        [Route("LoadAll")]
        public List<Attributes> LoadAll()
        {
            return attributesService.LoadAll();
        }
        [HttpGet]
        [Route("loadCount")]
        public List<VmAttribute>loadCount(int Id)
        {
            return attributesService.loadCount(Id);
        }

    }
    
}
