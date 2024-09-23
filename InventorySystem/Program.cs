using System;

namespace InventorySystem
{
  internal class Program
  {
    private static string[,] inventory = new string[35, 3];
    private static byte productIdCount = 0;
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Inventory Management System");
      Console.WriteLine("-------------------------------------------");

      Console.WriteLine("1. Add a Product");
      Console.WriteLine("2. Update a Product");
      Console.WriteLine("3. View Products");
      Console.WriteLine("4. Exit");

      Console.WriteLine("-------------------------------------------");

      //(Id, Name, Quantity, Price)

      while (true)
      {
        Console.Write("Enter your choice from 1 to 4: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
          case "1":
            AddProduct();
            break;
          case "2":
            UpdateProduct();
            break;
          case "3":
            ViewProducts();
            break;
          case "4":
            Console.WriteLine("\n\nThank you for using our inventory system. Goodbye!");
            Environment.Exit(0);
            break;
          default:
            Console.WriteLine("Invalid Choice");
            break;
        }
        Console.WriteLine();
      }

    }
    private static void AddProduct()
    {
      Console.Write("Enter Product Name: ");
      string productName = Console.ReadLine();
      Console.Write("Enter Product Quantity: ");
      string productQuantity = Console.ReadLine();
      Console.Write("Enter Product Price: ");
      string productPrice = Console.ReadLine();

      inventory[productIdCount, 0] = productName;
      inventory[productIdCount, 1] = productQuantity;
      inventory[productIdCount, 2] = productPrice;

      productIdCount++;

      Console.WriteLine("Product has benn added Successfully!");
    }
    private static void ViewProducts()
    {
      if (productIdCount > 0)
      {
        for (int i = 0; i < productIdCount; i++)
        {
          Console.WriteLine($"Product {i} Details ==>  Name:{inventory[i, 0]}, Quantity:{inventory[i, 1]}, Price:{inventory[i, 2]}");
        }
      }
      else Console.WriteLine("No Products to View");
    }
    private static void UpdateProduct()
    {
      Console.Write("Please Enter the Name of Product you want to Update: ");
      string targetProductName = Console.ReadLine();
      bool flag = false;

      int i;
      for (i = 0; i < productIdCount; i++)
      {
        if (targetProductName.ToLower() == inventory[i, 0].ToLower())
        {
          flag = true;
          break;
        }
      }
      if (flag)
      {
        Console.Write($"Enter New Quantity for {targetProductName}: ");
        string newQuantity = Console.ReadLine();

        Console.Write($"Enter New Price for {targetProductName}: ");
        string newPrice = Console.ReadLine();

        inventory[i, 1] = newQuantity;
        inventory[i, 2] = newPrice;
      }
      else Console.WriteLine("There's no Product with that Name");

    }
  }
}
