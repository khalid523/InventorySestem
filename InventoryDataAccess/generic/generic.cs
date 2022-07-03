using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryDataAccess.Model
{
   public class generic<T>: Igeneric<T> where T : class
    {
        private readonly InventoryContext context;

        public generic(InventoryContext _context)
        {
            context = _context;
        }

        public void Delete(int Id)
        {
          T obj= context.Set<T>().Find(Id);
            context.Set<T>().Remove(obj);
            context.SaveChanges();
        }

        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public T Load(int Id)
        {
            return context.Set<T>().Find(Id);
        }

        public List<T> LoadAll()
        {
            return context.Set<T>().ToList();
        }

        public void Update(T obj)
        {
            context.Set<T>().Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
