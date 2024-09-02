using Market;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Toy { Name = "Freddy Fazbear", AgeGroup = 3, Price = 20.20 },
            new Meat { Name = "Steak", Doneness = Meat.DegreeOfDoneness.Medium, Price = 30.90 },
            new Vegetable { Name = "Tomatoes", Weight = 3, Price = 15.00},
            new Drinks { Name = "Vodka", alcohol = true, Price = 50.60},
            new Cigarettes {Name  = "Camel", Disease = Cigarettes.Diseases.insult, Price = 40.00}

        };

        foreach (var product in products)
        {
            Console.WriteLine(product.getInformation());
        }

    }
}
