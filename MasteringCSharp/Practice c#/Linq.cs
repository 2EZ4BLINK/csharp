namespace MasteringCSharp
{
    public class Product
    {
        public string Name {get; set;}
        public double Price {get; set;}
    }
    
    internal class MyLinq
    {
        public void GetProductList()
        {
            List<Product> products = new List<Product>{
                new Product { Name = "Orange",Price = 23.99},
                new Product { Name = "Apple",Price = 25},
                new Product { Name = "Grapes",Price = 26.99},
            };
            
            foreach(Product product in products)
            {
                Console.WriteLine($"Product {product.Name} for Price {product.Price}");
            }
        }
    }
}