using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
   public interface IStoresService
    {
        public void Insert(Stores stores);
        public void Update(Stores stores);
        public void Delete(int Id);
        List<Stores> LoadByname(string Name);
        List<Stores> LoadAll();
    }
}
