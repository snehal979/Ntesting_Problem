using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntesting
{
    internal class TemperatureConversion
    {
        public static void TemperatureConversionCelsius_To_Fahrenheit(int temp)
        {
            //Celsius to Fahrenheit: (°C × 9/5) + 32 = °F
            float Fahrenheit = (temp * (9 / 5f)) + 32;
            Console.WriteLine("{0}C into fahrenheit is {1}F", temp, Fahrenheit);
                   
             
            
        }
        public static void TemperatureConversionFahrenheit_To_Celsius(int temp)
        {
            //Fahrenheit to Celsius: (°F − 32) x 5/9 = °C
            float cels = (temp - 32) * (5 / 9f);
            Console.WriteLine("{0}F into Celsius is {1}C", temp, cels);
        }
    }

}

