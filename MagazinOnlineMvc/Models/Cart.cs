using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagazinOnlineMvc.Models
{
    public class Cart
    {
        public List<Product> products { get; set; }
        public int totalPrice { get; set; }

        public Cart()
        {
            products = new List<Product>();
        }

        public void addToCart(Product prod)
        {               
            this.products.Add(prod);
        }

        public int calculateTotalaPrice()
        {
            this.totalPrice = 0;
            foreach (Product prod in products)
                totalPrice += (int) prod.price;
            return this.totalPrice;
        }

        public string showProductsInCar()
        {
            if ( products.Count == 0)
            {
                return "Empty cart";
            }

            String message = "\n Product you want to buy:";
            foreach(Product prod in products)
            {
                message += prod.name + ", " + prod.price + " lei;   \n";
            }

            message += " \n            Total cost: " + calculateTotalaPrice().ToString();


            return message;
        }

    }
}