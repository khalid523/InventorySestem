using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using InventoryDataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
    public class ProductService : IProductService
    {
        private readonly InventoryContext context;
        private readonly Igeneric<Product> generic;

        public ProductService(InventoryContext _context,Igeneric<Product> _generic)
        {
            context = _context;
            generic = _generic;
        }
        public void Delete(int Id)
        {
            generic.Delete(Id);
           
        }

        public void Insert(Product product)
        {
            generic.Insert(product);
        }

        public List<Product> LoadAll()
        {
            return context.products.Include("stores").ToList();
        }

        public List<Product> LoadByname(string Name)
        {
           return context.products.Where(P => P.Name == Name).ToList();
        }

        public void Update(Product product)
        {
            generic.Update(product);
        }
        public Product loadById(int Id)
        {
            return generic.Load(Id);
        }

        public List<Product> loadByLoad(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
