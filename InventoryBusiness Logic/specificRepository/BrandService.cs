using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using InventoryDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
   public class BrandService : IBrandService
    {
        private readonly InventoryContext context;
        private readonly Igeneric<Brand> generic;

        public BrandService(InventoryContext _context, Igeneric<Brand> _generic)
        {
            context = _context;
            generic = _generic;
        }
        public void Insert(Brand brand)
        {
            generic.Insert(brand);
        }

        public void Update(Brand brand)
        {
            generic.Update(brand);
        }
        public List<Brand> LoadByname (string Name)
        {
          return  context.brands.Where(b=>b.Name==Name).ToList();
        }

        public List<Brand> LoadAll()
        {
            return generic.LoadAll();
        }

        public void Delete(int Id)
        {
            generic.Delete(Id);
        }
    }
}
