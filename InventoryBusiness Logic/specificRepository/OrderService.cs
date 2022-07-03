using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using InventoryDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
    public class OrderService : IOrderService
    {
        private readonly InventoryContext context;
        private readonly Igeneric<Orders> generic;

        public OrderService(InventoryContext _context,Igeneric<Orders> _generic)
        {
            context = _context;
            generic = _generic;
        }
        public void Delete(int Id)
        {
            generic.Delete(Id);
            
        }

        public void Insert(Orders orders)
        {
            generic.Insert(orders);
        }

        public List<Orders> LoadAll()
        {
           return generic.LoadAll();
        }

        public List<Orders> LoadByname(string Name)
        {
           return context.orders.Where(O => O.CustomerName == Name).ToList();
        }

        public void Update(Orders orders)
        {
            generic.Update(orders);
        }
        public List<Orders> LoadBy(int Id)
        {
            List<Orders> li = new List<Orders>();

            context.orders.Find(Id);
            li = context.orders.Where(a => a.Id == Id).ToList();
            return li;
        }
    }
}
