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
                new Product {ProductId=1, Name="Iphone 7", Price=3000, Description="Telefon", IsApproved = false, ImageUrl="1.jpg", CategoryId=1},
                new Product {ProductId=2,Name="Iphone 8", Price=6000, Description="Telefon", IsApproved = true, ImageUrl="2.jpg", CategoryId=1},
                new Product {ProductId=3,Name="Iphone X", Price=9000, Description="Telefon", IsApproved = true, ImageUrl = "3.jpg", CategoryId = 1},
                new Product {ProductId=4,Name="Iphone 11", Price=12000, Description="Telefon", ImageUrl="4.jpg", CategoryId=1},
                new Product {ProductId=5,Name="Iphone 12", Price=12000, Description="Telefon", ImageUrl="4.jpg", CategoryId=1},
                new Product {ProductId=6, Name="Lenovo", Price=3000, Description="Bilgisayar", IsApproved = false, ImageUrl="1.jpg", CategoryId=2},
                new Product {ProductId=7,Name="Lenovo", Price=6000, Description="Bilgisayar", IsApproved = true, ImageUrl="2.jpg", CategoryId=2},
                new Product {ProductId=8,Name="Lenovo", Price=9000, Description="Bilgisayar", IsApproved = true, ImageUrl = "3.jpg", CategoryId = 2},
                new Product {ProductId=9,Name="Lenovo", Price=12000, Description="Bilgisayar", ImageUrl="4.jpg", CategoryId=2}
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
