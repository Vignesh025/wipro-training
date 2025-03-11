using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_Razor_demo.Pages
{
    public class MyPage1Model : PageModel
    {
        public string Message { get; set; }

        public List<Product> Products { get; set; }
        //public void OnGet()
        //{
            //Message = "Hello all, welcome to asp.net core";

            //Products = new List<Product>
            //{
            //    new Product {Id=1,Name="Laptop",Price = 999.99m},
            //    new Product {Id=2,Name="Mobile",Price=444.99m},
            //    new Product {Id=3,Name="Tablet",Price=699.99m}
            //};
        //}

        public void OnGet()
        {
            Message = "This is a get request";
        }
        public void OnPost()
        {
            Message = "This is a Post Request";
        }
        public void OnPut()
        {
            Message = "This is a Put request";
        }
        public void OnDelete()
        {
            Message = "This is a Delete request";
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
    
}
