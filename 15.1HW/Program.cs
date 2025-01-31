using System;
using _15._1HW;

class Program
{
    static void Main()
    {
        VegetableShop shop = new VegetableShop(20);

        shop.AddProduct(new Carrot(15));
        shop.AddProduct(new Tomato(18));
        shop.AddProduct(new Potato(20, 5));
        shop.AddProduct(new Cucumber(12, 3));

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Add a new product");
            Console.WriteLine("2. View all products");
            Console.WriteLine("3. Exit");
            Console.Write("Your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter a new product (name, base price, and count if applicable):");

                    Console.Write("Product name: ");
                    string name = Console.ReadLine();

                    Console.Write("Base price: ");
                    if (!decimal.TryParse(Console.ReadLine(), out decimal basePrice) || basePrice <= 0)
                    {
                        Console.WriteLine("Invalid price! Must be a positive number.");
                        continue;
                    }
                    int count = 1;

                    if (name == "Potato" || name == "Cucumber")
                    {
                        Console.Write("Enter count (kg): ");
                        if (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
                        {
                            Console.WriteLine("Invalid count! Must be a positive integer");
                            continue;
                        }

                        if (name == "Potato")
                        {
                            shop.AddProduct(new Potato(basePrice, count));
                            Console.WriteLine($"Potato ({count} kg) added to the shop.");
                        }
                        else if (name == "Cucumber")
                        {
                            shop.AddProduct(new Cucumber(basePrice, count));
                            Console.WriteLine($"Cucumber ({count} kg) added to the shop.");
                        }
                        continue;
                    }

                    if (name == "Carrot")
                    {
                        shop.AddProduct(new Carrot(basePrice));
                        Console.WriteLine("Carrot added to the shop");
                    }
                    else if (name == "Tomato")
                    {
                        shop.AddProduct(new Tomato(basePrice));
                        Console.WriteLine("Tomato added to the shop");
                    }
                    else
                    {
                        Console.WriteLine("Invalid product name!");
                    }
                    break;

                case 2:

                    Console.WriteLine("\nProducts in the shop:");
                    shop.PrintProductsInfo();
                    break;

                case 3:

                    Console.WriteLine("Exiting the program..");
                    running = false;
                    break;

                default:

                    Console.WriteLine("Invalid choice. Please select again");
                    break;

            }
        }    
    }
}
