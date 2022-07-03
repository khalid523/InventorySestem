using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entities
{
    [Table("stores")]
   public class Stores
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Status { set; get; }
        public List<Product> liproducts { set; get; }
        //[ForeignKey("company")]
        //public int company_Id { set; get; }
        //public Company company { set; get; }
        

    }
}
