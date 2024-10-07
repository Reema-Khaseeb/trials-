using Microsoft.Extensions.Configuration;

namespace InventoryManagementSystem;

public class Program
{
    public static void Main()
    {
        // Load configuration from appsettings.json
        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        string connectionString = config.GetSection("MongoDbSettings")["ConnectionString"];

        // Pass the connection string to MongoDbHelper
        var dbHelper = new MongoDbHelper(connectionString);
        var inventory = new Inventory(dbHelper);

        while (true)
        {
            Console.WriteLine("\n--- Inventory Management System ---");
            Console.WriteLine("1. Add a product");
            Console.WriteLine("2. View all products");
            Console.WriteLine("3. Edit a product");
            Console.WriteLine("4. Delete a product");
            Console.WriteLine("5. Search for a product");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter product quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        var newProduct = new Product(name, price, quantity);
                        inventory.AddProduct(newProduct);
                        Console.WriteLine("Product added successfully.");
                        break;

                    case 2:
                        inventory.ViewAllProducts();
                        break;

                    case 3:
                        Console.Write("Enter product name to edit: ");
                        string editName = Console.ReadLine();

                        var product = inventory.SearchProductByName(editName);
                        if (product != null)
                        {
                            Console.Write("Enter new name: ");
                            string newName = Console.ReadLine();
                            Console.Write("Enter new price: ");
                            double newPrice = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter new quantity: ");
                            int newQuantity = Convert.ToInt32(Console.ReadLine());

                            inventory.EditProduct(product.Name, newName, newPrice, newQuantity);
                        }
                        else
                        {
                            Console.WriteLine("Product not found.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter product name to delete: ");
                        string deleteName = Console.ReadLine();
                        inventory.DeleteProduct(deleteName);
                        break;

                    case 5:
                        Console.Write("Enter product name to search: ");
                        string searchName = Console.ReadLine();
                        var foundProduct = inventory.SearchProductByName(searchName);
                        if (foundProduct != null)
                        {
                            Console.WriteLine($"Name: {foundProduct.Name}, Price: {foundProduct.Price}, Quantity: {foundProduct.Quantity}");
                        }
                        else
                        {
                            Console.WriteLine("Product not found.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
        }
    }
}


