using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using InventoryDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
    public class AttributesValueService : IAttributesValueService
    {
        private readonly InventoryContext context;
        private readonly Igeneric<AttributesValue> generic;

        public AttributesValueService(InventoryContext _context,Igeneric<AttributesValue> _generic)   {
            context = _context;
            generic = _generic;
        }

        public void Delete(int Id)
        {
            generic.Delete(Id);
        }

        public void Insert(AttributesValue attributesValue)
        {
            generic.Insert(attributesValue); 
        }

        public AttributesValue Load(int Id)
         {
            return generic.Load(Id);
        }

        public List<AttributesValue> LoadAll()
        {
            return generic.LoadAll();
        }

        public List<AttributesValue> LoadBy(int Id)
        {
            List<AttributesValue> li = new List<AttributesValue>();

             context.attributesValues.Find(Id);
            li = context.attributesValues.Where(a => a.attributes_Id == Id).ToList();
            return li;
         }
       

        public List<AttributesValue> LoadByname(string Name)
        {
           return context.attributesValues.Where(a => a.Name == Name).ToList();
        }

        public void Update(AttributesValue attributesValue)
        {
            generic.Update(attributesValue);
        }

       
    }
}
