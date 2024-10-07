namespace InventoryManagementSystem;

public class Inventory
{
    private readonly MongoDbHelper _dbHelper;

    public Inventory(MongoDbHelper dbHelper)
    {
        _dbHelper = dbHelper;
    }

    public void AddProduct(Product product)
    {
        _dbHelper.AddProduct(product);
    }

    public void ViewAllProducts()
    {
        var products = _dbHelper.GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
        }
    }

    public void EditProduct(string productName, string newName, double newPrice, int newQuantity)
    {
        _dbHelper.EditProduct(productName, newName, newPrice, newQuantity);
    }

    public void DeleteProduct(string productName)
    {
        _dbHelper.DeleteProductByName(productName);
    }

    public Product SearchProductByName(string productName)
    {
        return _dbHelper.GetProductByName(productName);
    }
}
