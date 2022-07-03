using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
   public interface ICateogryService
    {
        public void Insert(Category category);
        public void Update(Category category);
        public void Delete(int Id);
        List<Category> LoadByname(string Name);
        List<Category> LoadAll();
    }
}
