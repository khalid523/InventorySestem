using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
    public interface IBrandService
    {
        public void Insert(Brand brand);
        public void Update(Brand brand);
        public void Delete(int Id);
        List<Brand> LoadByname(string Name);
        List<Brand> LoadAll();
    }
}
