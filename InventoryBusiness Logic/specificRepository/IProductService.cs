using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
   public interface IProductService
    {
        public void Insert(Product product);
        public void Update(Product product);
        public void Delete(int Id);
        List<Product> LoadByname(string Name);
        List<Product> LoadAll();
        List<Product> loadByLoad(int Id);
        Product loadById(int Id);

    }
}
