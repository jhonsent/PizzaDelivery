using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PizzaOrderApp
{

    public static class ProductData
    {


        public static List<Product> Products { get; private set; }

        static ProductData()
        {
            var temp = new List<Product>();

            AddProduct(temp);
           

            Products = temp.OrderBy(i => i.Name).ToList();


        }

        static void AddProduct(List<Product> Products)
        {


            Products.Add(new Product()
            {
                Name = "HAWAIIAN",
                Price = "P240.00",
                ImageUrl = "images/HAWAIIAN.png",
                Details = "Aloha Pizza with double layers of ham and pineapple."
            });
            Products.Add(new Product()
            {
                Name = "SUPREME",
                Price = "P250.00",
                ImageUrl = "images/SUPREME.png",
                Details = "Six delightful toppings - beef, pepperoni, seasoned pork, bell pepper, mushrooms and onions."
            });

            Products.Add(new Product()
            {
                Name = "ITALIAN ",
                Price = "P250.00",
                ImageUrl = "images/ITALIAN.png",
                Details = "Italian sausage, sweet ham, bell peppers, onions, mushrooms and pineapples in our signature pizza."
            });

            Products.Add(new Product()
            {
                Name = "MEAT LOVER ",
                Price = "P250.00",
                ImageUrl = "images/MEAT.png",
                Details = "Enjoy a protein-packed serving of bacon, beef, ham, italian sausage, pepperoni and seasoned pork."
            });

            
        }
        
    }
}