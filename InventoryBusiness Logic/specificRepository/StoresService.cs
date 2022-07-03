using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using InventoryDataAccess.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
    public class StoresService : IStoresService
    {
        private readonly InventoryContext context;
        private readonly Igeneric<Stores> generic;

        public StoresService(InventoryContext _context, Igeneric<Stores> _generic)
        {
            context = _context;
            generic = _generic;


        }

        public void Delete(int Id)
        {
            generic.Delete(Id);
        }

        public void Insert(Stores stores)
        {
            generic.Insert(stores);
        }

        public List<Stores> LoadAll()
        {
            return generic.LoadAll();
        }

        public List<Stores> LoadByname(string Name)
        {
            return context.stores.Where(s => s.Name == Name).ToList();
        }

        public void Update(Stores stores)
        {
            generic.Update(stores);
        }
    }
}
