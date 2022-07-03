using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using InventoryDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
   public class CateogryService : ICateogryService
    {
        private readonly InventoryContext contxt;
        private readonly Igeneric<Category> generic;

        public CateogryService(InventoryContext _contxt, Igeneric<Category> _generic)
        {
            contxt = _contxt;
            generic = _generic;
        }

        public void Delete(int Id)
        {

            generic.Delete(Id);


        }

        public void Insert(Category category)
        {
            generic.Insert(category);
           
        }

        public List<Category> LoadAll()
        {
            return generic.LoadAll();
        }

        public List<Category> LoadByname(string Name)
        {
            return contxt.categories.Where(C => C.Name == Name).ToList();
        }

        public void Update(Category category)
        {
            generic.Update(category);
        }
    }
}
