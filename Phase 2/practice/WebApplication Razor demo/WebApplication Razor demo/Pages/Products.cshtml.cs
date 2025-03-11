using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_Razor_demo.Pages
{

    public class ProductsModel : PageModel
    {
        public readonly ProductService _productService;
        public ProductsModel(ProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public Product Product { get; set; }

        public IEnumerable<Product> Products { get; private set; }
        public void OnGet()
        {
            Products = _productService.GetAll();
        }

        public IActionResult OnPostCreate()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _productService.Add(Product);
            return RedirectToPage();
        }
        public IActionResult OnPostEdit()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _productService.Update(Product);
            return RedirectToPage();
        }
        public IActionResult OnPostDelete(int id)
        {
            _productService.Delete(id);
            return RedirectToPage();
        }
    }
}
