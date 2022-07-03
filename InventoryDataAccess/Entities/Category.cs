using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entities
{
    [Table("Categories")]
   public class Category
    {

        public int Id { set; get; }
        
        public string Name { set; get; }
        public string Status { set; get; }

        public List<Product> liproductss { set; get; }
    }
}
