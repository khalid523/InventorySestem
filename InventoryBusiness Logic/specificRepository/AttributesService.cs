using InventoryDataAccess.Context;
using InventoryDataAccess.Entities;
using InventoryDataAccess.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryBusiness_Logic.specificRepository
{
    public class AttributesService : IAttributesService
    {
        private readonly Igeneric<Attributes> generic;
        private readonly InventoryContext context;

        public AttributesService( Igeneric<Attributes> _generic, InventoryContext _context)
        {
            generic = _generic;
            context = _context;
        }
        public List<Attributes> LoadAll()
        {
           return generic.LoadAll();
        }
      
        public List<VmAttribute> loadCount(int Id)
        {
            //return context.attributes.GroupJoin(context.attributesValues, d => d.Id, e => e.attributes_Id, (attr, value) => new { attr.Name, count = value.Count() });
            List<VmAttribute> li = context.attributes.Select( data =>
             new VmAttribute()
             {
                   
                 Count = data.attributesValues.Count()
             }
             ).ToList();
                
                
                
                
            return li;
            
        }

       
    }
}
