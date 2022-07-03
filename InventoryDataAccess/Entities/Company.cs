using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entities
{
    [Table("Company")]
   public class Company
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string VatCharge { set; get; }
        public string address { set; get; }
        public string Phone { set; get; }
        public string Country { set; get; }
        public string Message { set; get; }
        //public string Availability { set; get; }
        public string Currency { set; get; }

        //public List<Stores> stores { set; get; }


    }
}
