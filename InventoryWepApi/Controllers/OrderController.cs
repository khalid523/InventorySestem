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
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService _orderService)
        {
            orderService = _orderService;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(Orders orders)
        {

            orderService.Insert(orders);
        }
        [HttpGet]
        [Route("LoadAll")]
        public List<Orders> LoadAll()
        {
            return orderService.LoadAll();
        }
        [HttpGet]
        [Route("Delete")]
        public void Delete(int Id)
        {

            orderService.Delete(Id);

        }
        public void Update(Orders orders)
        {

            orderService.Update(orders);

        }
        [HttpGet]
        [Route("LoadById")]
        public List<Orders> LoadById(int Id)
        {

            return orderService.LoadBy(Id);

        }


    }
}
