using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Advanced
{
    internal class DelegateforUnitConversion
    {
        delegate double TemperatureConverterDelegate(double temperature);
        delegate void PrintResultDelegate(double result);

        static double CelsiusToFahrenheit(double temperatureinCelsius)
        {
            return (temperatureinCelsius * 9 / 5) + 32;
        }
        static double FahrenheitToCelsius(double temperatureinFahrenheit)
        {
            return (temperatureinFahrenheit - 32) * 5 / 9;
        }
        static void printConsole(double reault)
        {
            Console.WriteLine($"The converted temperature is: {reault}");
        }

        public static void ON()
        {
            double temperature;
            Console.WriteLine("Enter temperature: ");
            temperature = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose conversion (1 - Celsius to Fahrenheit, 2 - Fahrenheit to Celsius): ");
            int choice = int.Parse(Console.ReadLine());

            TemperatureConverterDelegate converter;
            switch (choice)
            {
                case 1:
                    converter = CelsiusToFahrenheit;
                    break;
                case 2:
                    converter = FahrenheitToCelsius;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
            PrintResultDelegate printResult = printConsole;
            double convertedTemp = converter(temperature);
            printResult(convertedTemp);
        }
    }
}
