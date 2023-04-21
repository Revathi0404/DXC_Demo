// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Print table header
        Console.WriteLine("Temperature in Celsius\tTemperature in Fahrenheit");

        // Compute and print temperature values
        for (int celsius = 0; celsius <= 100; celsius += 10)
        {
            double fahrenheit = (celsius * 9 / 5.0) + 32; // Convert Celsius to Fahrenheit
            Console.WriteLine($"{celsius}°C\t\t\t\t{fahrenheit}°F");
        }
    }
}

