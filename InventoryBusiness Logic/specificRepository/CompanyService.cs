using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using InventoryDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
    public class CompanyService : ICompanyService
    {
        private readonly InventoryContext context;
        private readonly Igeneric<Company> generic;

        public CompanyService(InventoryContext _context, Igeneric<Company> _generic)
        {
            context = _context;
            generic = _generic;
        }
        public void Delete(int Id)
        {
            generic.Delete(Id);
        }

        public void Insert(Company company)
        {
            generic.Insert(company);
        }

        public List<Company> LoadAll()
        {
           return generic.LoadAll();
        }

        public List<Company> LoadByname(string Name)
        {
           return context.companies.Where(C => C.Name == Name).ToList();
        }

        public void Update(Company company)
        {
            generic.Update(company);
        }
        public List<Company> loadByLoad(int Id)
        {
            return context.companies.Where(P => P.Id == Id).ToList();
        }
    }
}
