using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entities
{
    [Table("attributes")]
   public class Attributes
    {
       
        public int Id { set; get; }
        public string Name { set; get; }
        
       
       public List<AttributesValue> attributesValues { set; get; }
        public List<Product> liproducts { set; get; }

      
    }
}
