using System.Text.Json;

namespace PetStoreWk3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type \'exit\' to quit");
        string userInput = Console.ReadLine();

        while (userInput.ToLower() != "exit")
        {
            if (userInput == "1")
            {
                CatFood Friskies = new CatFood();
                Console.Write("Name of Product:");
                string Name = Console.ReadLine();
                Friskies.Name = Name;

                Console.Write("Price of Item:");
                string Price = Console.ReadLine();
                decimal PriceDecimal = decimal.Parse(Price);
                Friskies.Price = PriceDecimal;
                
                Console.Write("Desired Quantity:");
                string Quantity = Console.ReadLine();
                int QuantityInt = int.Parse(Quantity);
                Friskies.Quantity = QuantityInt;

                Console.Write("Flavor:");
                string Description = Console.ReadLine();
                Friskies.Decription = Description;

                Console.Write("Weight in Pounds:");
                string WeightPounds = Console.ReadLine();
                double WeightPoundsDouble = double.Parse(WeightPounds);
                Friskies.WeightPounds = WeightPoundsDouble;

                Console.Write("Kitten Food?");
                string KittenFood = Console.ReadLine();
                bool KittenFoodBool = bool.Parse(KittenFood);
                Friskies.KittenFood = KittenFoodBool;

                Console.WriteLine(JsonSerializer.Serialize(Friskies));
            }
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type \'exit\' to quit");
            userInput = Console.ReadLine();

        }

    }
}

