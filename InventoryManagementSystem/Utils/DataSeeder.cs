namespace InventoryManagementSystem.Utils;

public static class DataSeeder
{
    public static void SeedProducts(Inventory inventory)
    {
        var initialProducts = new List<Product>
        {
            new Product("Laptop", 1000.0, 10),
            new Product("Smartphone", 600.0, 20),
            new Product("Tablet", 300.0, 15),
            new Product("Headphones", 100.0, 50)
        };

        foreach (var product in initialProducts)
        {
            var existingProduct = inventory.SearchProductByName(product.Name);
            if (existingProduct == null)
            {
                inventory.AddProduct(product);
            }
        }

        Console.WriteLine("Initial data seeded successfully.");
    }
}
