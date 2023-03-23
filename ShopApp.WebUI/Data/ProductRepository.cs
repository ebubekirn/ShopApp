using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;
        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product {ProductId=1, Name="Iphone 7", Price=3000, Description="Telefon", IsApproved = false, ImageUrl="1.jpg"},
                new Product {ProductId=1,Name="Iphone 8", Price=6000, Description="Telefon", IsApproved = true, ImageUrl="2.jpg"},
                new Product {ProductId=1,Name="Iphone X", Price=9000, Description="Telefon", IsApproved = true, ImageUrl = "3.jpg"},
                new Product {ProductId=1,Name="Iphone 1", Price=12000, Description="Telefon", ImageUrl="4.jpg"}
            };
        }

        public static List<Product> Products
        {
            get {
                return _products;
            }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
