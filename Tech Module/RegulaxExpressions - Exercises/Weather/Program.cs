using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Camera_view
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cityWeather = new Dictionary<string, string>();
            Dictionary<string, double> cityDegrees = new Dictionary<string, double>();



            string pattern = "([A-Z]{2})([0-9]+\\.[0-9]+)([a-zA-Z]+)\\|";
            string input;
            // Regex regX = new Regex(pattern);


            while ((input = Console.ReadLine()) != "end")
            {

                if (Regex.IsMatch(input, pattern))
                {
                    Match matchesToDictionary = Regex.Match(input, pattern);

                    string city = matchesToDictionary.Groups[1].Value;
                    string weather = matchesToDictionary.Groups[3].Value;
                    double degrees = double.Parse(matchesToDictionary.Groups[2].Value);


                    cityWeather[city] = weather;
                    cityDegrees[city] = degrees;
                }
            }

            Dictionary<string, double> sortedDict = cityDegrees.OrderBy(x => x.Value)
                .ToDictionary(u => u.Key, u => u.Value);

            foreach (var city in sortedDict)
            {
                Console.WriteLine($"{city.Key} => {city.Value:f2} => {cityWeather[city.Key]}");
            }
        }
    }
}