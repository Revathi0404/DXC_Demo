// See https://aka.ms/new-console-template for more information
using System;
class TemperatureConverter
{
    static void Main()
    {
        do
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);

            Console.Write("Do you want to continue? (y/n): ");
            string response = Console.ReadLine();
            if (response != "y")
            {
                break;
            }

        } while (true);
    }
}


