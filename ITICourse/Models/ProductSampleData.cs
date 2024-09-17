namespace ITICourse.Models
{
    public class ProductSampleData
    {
        List<Product> products;

        public ProductSampleData()
        {
            products = new List<Product>();
            products.Add(new Product() { Id = 1, Name = "IPhone", Price = 10000, Image = "1.jpg" });
            products.Add(new Product() { Id = 2, Name = "IPhone2", Price = 20000, Image = "1.jpg" });
            products.Add(new Product() { Id = 3, Name = "IPhone3", Price = 30000, Image = "1.jpg" });
            products.Add(new Product() { Id = 4, Name = "IPhone4", Price = 40000, Image = "1.jpg" });
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }

   
}