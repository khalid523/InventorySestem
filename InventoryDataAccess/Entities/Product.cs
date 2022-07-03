using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entities
{
    [Table("products")]
    public class Product
    { 
        public int Id { set; get; }
        public string Name { set; get;}
        public string Sku { set; get; }
        public double Price { set; get; }
        public int Qty { set; get; }
        public string Description { set; get; }
        [Required]
        [ForeignKey("category")]
        public int category_Id { set; get; }
        public Category category { set; get; }
        [ForeignKey("brand")]
        public int brand_Id { set; get; }
        public Brand brand { set; get; }

        [ForeignKey("stores")]
        public int stores_Id { set; get; }
        public Stores stores { set; get; }
        [NotMapped]
        public IFormFile Image { set; get; }
        public string ImagePath { set; get; }

        public List<Porduct_Order> liporduct_Orders { set; get; }

        [ForeignKey("Size")]
        public int Size_Id { set; get; }
        public AttributesValue Size { set; get; }
        [ForeignKey("Color")]
        public int Color_Id { set; get; }
        public AttributesValue Color { set; get; }
        public string Availability { set; get; }
    }
}
