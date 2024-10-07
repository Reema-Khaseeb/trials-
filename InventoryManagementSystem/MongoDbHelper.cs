using MongoDB.Driver;

namespace InventoryManagementSystem;

public class MongoDbHelper
{
    private readonly IMongoCollection<Product> _products;

    public MongoDbHelper(string connectionString)
    {
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("InventoryDb");
        _products = database.GetCollection<Product>("Products");
    }

    public void AddProduct(Product product)
    {
        _products.InsertOne(product);
        Console.WriteLine("Product added to the database.");
    }

    public List<Product> GetAllProducts()
    {
        return _products.Find(product => true).ToList();
    }

    public Product GetProductByName(string productName)
    {
        return _products.Find(p => p.Name == productName).FirstOrDefault();
    }

    public Product GetProductById(string productId)
    {
        return _products.Find(p => p.Id == productId).FirstOrDefault();
    }

    public void DeleteProductByName(string productName)
    {
        var product = _products.Find(p => p.Name == productName).FirstOrDefault();
        if (product != null)
        {
            _products.DeleteOne(p => p.Id == product.Id);
            Console.WriteLine($"Product '{productName}' deleted from the database.");
        }
        else
        {
            Console.WriteLine($"No product found with the name '{productName}'.");
        }
    }

    public void EditProduct(string productName, string newName, double newPrice, int newQuantity)
    {
        var product = _products.Find(p => p.Name == productName).FirstOrDefault();
        if (product != null)
        {
            product.Name = newName;
            product.Price = newPrice;
            product.Quantity = newQuantity;
            _products.ReplaceOne(p => p.Id == product.Id, product);
            Console.WriteLine($"Product '{productName}' updated successfully.");
        }
        else
        {
            Console.WriteLine($"No product found with the name '{productName}'.");
        }
    }
}
