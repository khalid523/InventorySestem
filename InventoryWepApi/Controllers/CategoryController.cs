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
    public class CategoryController : ControllerBase
    {
        private readonly ICateogryService cateogryService;

        public CategoryController(ICateogryService _cateogryService)
        {
            cateogryService = _cateogryService;
        }

        [HttpPost]
        [Route("Insert")]
        public void Insert(Category category)
        {

            cateogryService.Insert(category);
        }
        [HttpGet]
        [Route("LoadAll")]
        public List<Category> LoadAll()
        {
            return cateogryService.LoadAll();
        }
        [HttpGet]
        [Route("Delete")]
        public void Delete(int Id)
        {
            cateogryService.Delete(Id);

        }
        [Route("LoadByName")]
        public List<Category> LoadByName(string name)
        {
            return cateogryService.LoadByname(name);
        }
        [HttpPost]
        [Route("Update")]
        public void Update(Category category)
        {
            cateogryService.Update(category);

        }
    }
}
