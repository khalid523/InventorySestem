using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
   public interface IOrderService
    {
        public void Insert(Orders orders);
        public void Update(Orders orders);
        public void Delete(int Id);
        List<Orders> LoadByname(string Name);
        List<Orders> LoadAll();
        List<Orders> LoadBy(int Id);
    }
}
