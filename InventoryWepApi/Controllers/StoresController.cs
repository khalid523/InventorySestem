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
    public class StoresController : ControllerBase
    {
        private readonly IStoresService storesService;

        public StoresController(IStoresService _storesService)
        {
            storesService = _storesService;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(Stores stores)
        {

            storesService.Insert(stores);
        }
        [HttpGet]
        [Route("LoadAll")]

        public List<Stores> LoadAll()
        {
            return storesService.LoadAll();
        }
        [HttpGet]
        [Route("LoadByName")]
        public List<Stores> LoadByName(string name)
        {
            return storesService.LoadByname(name);
        }
        [HttpGet]
        [Route("Delete")]
        public void Delete(int Id)
        {
           
            storesService.Delete(Id);
            
        }
        [HttpPost]
        [Route("Update")]
        public void Update(Stores stores)
        {
            
            storesService.Update(stores);

        }

    }
}
