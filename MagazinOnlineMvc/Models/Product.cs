using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MagazinOnlineMvc.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required]
        public string name { get; set; }

        public string description { get; set; }

        public decimal price { get; set; }

        [Range(1,100)]
        public int numberOfProducts { get; set; }   
    }

    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; } 
    }
}