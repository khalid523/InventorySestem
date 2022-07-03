using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entities
{
    [Table("orders")]
   public class Orders
    {
        public int Id { set; get; }
        public string CustomerName { set; get; }
        public string CustomerAddress { set; get; }
        public string CustomerPhone { set; get; }
        public List<Porduct_Order> liporduct_Orders { set; get; }

        public int Qty { set; get; }
        public double Rate { set; get; }
        public double Amount { set; get; }
        public double GrossAmount { set; get; }
        public double Vat { set; get; }
        public double NetAmount { set; get; }
        public string PaidStatus { set; get; }

    }
}
