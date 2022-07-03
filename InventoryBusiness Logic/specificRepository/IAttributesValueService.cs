using InventoryDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
   public interface IAttributesValueService
    {
        public void Insert(AttributesValue attributesValue);
        public void Update(AttributesValue attributesValue);
        public void Delete(int Id);
        List<AttributesValue> LoadByname(string Name);
        List<AttributesValue> LoadAll();
        AttributesValue Load(int Id);
        
        List<AttributesValue> LoadBy(int Id);
        
    }
}
