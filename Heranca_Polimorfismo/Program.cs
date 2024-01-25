// See https://aka.ms/new-console-template for more information
using Heranca_Polimorfismo.Entities;

Console.Write("Enter the number of products: ");
int number = int.Parse(Console.ReadLine());

List<Product> Product = new List<Product>();

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char tipe = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());
    if (tipe == 'i')
    {
        Console.Write("Customs fee: ");
        double fee = double.Parse(Console.ReadLine());
        Product.Add(new ImportedProduct(name, price, fee));
    }else if(tipe == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Product.Add(new UsedProduct(name, price, date));
    }
    else
    {
        Product.Add(new Product(name, price));
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");
foreach (Product emp in Product)
{
    Console.WriteLine(emp.PriceTag());
}

