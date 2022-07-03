using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entities
{
    [Table("attributesvalue")]
   public class AttributesValue
    {
     
        public int Id { set; get; }
        
        public string Name { set; get; }
        [ForeignKey("attributes")]
        public int attributes_Id { set; get; }
        public Attributes attributes { set; get; }
        [InverseProperty("Size")]
        public List<Product> liProductsSize { set; get; }
        [InverseProperty("Color")]
        public List<Product> liProductsColor { set; get; }

    }
}
