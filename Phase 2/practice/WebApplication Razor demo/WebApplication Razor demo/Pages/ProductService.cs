namespace WebApplication_Razor_demo.Pages
{
    public class ProductService
    {
        private readonly List<Product> _products;
        private int _nextId;

        public ProductService()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name="Product 1", Price =10.0m, Quantity = 100 },
                new Product { Id = 2, Name="Product 2", Price = 20.0m, Quantity = 80 }
            };
            _nextId = 3;
        }

        public List<Product> GetAll() => _products;

        public Product Get(int id) => _products.FirstOrDefault(p => p.Id == id);
        public void Add(Product product)
        {
            product.Id=_nextId;
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var existingProduct = Get(product.Id);
            if(existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Quantity = product.Quantity;
            }
        }

        public void Delete(int id)
        {
            var product = Get(id);
            if(product != null)
            {
                _products.Remove(product);
            }
        }
    }
}
