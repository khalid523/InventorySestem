using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
    public interface ICompanyService
    {
        public void Insert(Company company);
        public void Update(Company company);
        public void Delete(int Id);
        List<Company> LoadByname(string Name);
        List<Company> LoadAll();
        List<Company> loadByLoad(int Id);
    }
}
