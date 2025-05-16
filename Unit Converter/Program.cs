using System;

class UnitConverter
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Unit Converter ===");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            Console.WriteLine("3. Kilometers to Miles");
            Console.WriteLine("4. Miles to Kilometers");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");

            string choice = Console.ReadLine();

            if (choice == "5")
                break;

            Console.Write("Enter the value to convert: ");
            if (!double.TryParse(Console.ReadLine(), out double input))
            {
                Console.WriteLine("Invalid input. Press any key to try again.");
                Console.ReadKey();
                continue;
            }

            double result = 0;
            string unitResult = "";

            switch (choice)
            {
                case "1":
                    result = (input * 9 / 5) + 32;
                    unitResult = "°F";
                    break;
                case "2":
                    result = (input - 32) * 5 / 9;
                    unitResult = "°C";
                    break;
                case "3":
                    result = input * 0.621371;
                    unitResult = "miles";
                    break;
                case "4":
                    result = input / 0.621371;
                    unitResult = "kilometers";
                    break;
                default:
                    Console.WriteLine("Invalid option. Press any key to try again.");
                    Console.ReadKey();
                    continue;
            }

            Console.WriteLine($"Converted value: {result:F2} {unitResult}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        Console.WriteLine("Thanks for using Unit Converter!");
    }
}
