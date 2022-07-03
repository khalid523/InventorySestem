using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entities
{
    [Table("Porduct_Order")]
  public class Porduct_Order
    {
        [ForeignKey("product")]
        public int product_Id { set; get; }
        public Product product { set; get; }
        [ForeignKey("orders")]
        public int orders_Id { set; get; }
        public Orders orders { set; get; }
    }
}
