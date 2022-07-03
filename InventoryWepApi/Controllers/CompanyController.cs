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
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService companyService;

        public CompanyController(ICompanyService _companyService)
        {
            companyService = _companyService;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(Company company)
        {

            companyService.Insert(company);
        }
        [HttpGet]
        [Route("LoadAll")]
        public List<Company> LoadAll()
        {
            return companyService.LoadAll();
        }
        [HttpPost]
        [Route("Delete")]
        public void Delete(int Id)
        {
            
            companyService.Delete(Id);

        }
        public void Update(Company company)
        {
            
            companyService.Update(company);

        }
        [HttpGet]
        [Route("loadBYLoadId")]
        public List<Company> loadBYLoadId(int Id)
        {

            return companyService.loadByLoad(Id);
        }
    }
}
